'Name: Aidan Raney
'Date: 3/4/2021
'Purpose: L6 - Test Assignment 3

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FitnessCalculator
    Dim lstUsers As New BindingList(Of User)
    Dim boolAgeNum As Boolean
    Dim boolWeightNum As Boolean
    Dim boolHeightNum As Boolean
    Dim decRMR As Decimal
    Dim decRMRMultiplier As Decimal
    Dim decActivity As Decimal
    Dim strErrorMsg As String
    Dim objSelectedUser As User
    Dim dsUser As New DataSet()
    Private Sub Output()
        'Check is a user is selected
        If Not objSelectedUser Is Nothing Then
            If objSelectedUser.Activity = "Sitting or Lying all day" Then
                decRMRMultiplier = 1.2
            ElseIf objSelectedUser.Activity = "Seated work, no exercise" Then
                decRMRMultiplier = 1.3
            ElseIf objSelectedUser.Activity = "Seated work, light exercise" Then
                decRMRMultiplier = 1.4
            ElseIf objSelectedUser.Activity = "Moderately physical work, no exercise" Then
                decRMRMultiplier = 1.5
            ElseIf objSelectedUser.Activity = "Moderately physical work, light exercise" Then
                decRMRMultiplier = 1.6
            ElseIf objSelectedUser.Activity = "Moderately physical work, heavy exercise" Then
                decRMRMultiplier = 1.7
            ElseIf objSelectedUser.Activity = "Heavy work or Heavy Exercise" Then
                decRMRMultiplier = 1.8
            End If
            'Checks gender
            If objSelectedUser.Gender = "Male" Then
                'Calculates data
                decRMR = (88.4 + 13.4 * (objSelectedUser.Weight * 0.453592)) + (4.8 * (objSelectedUser.Height * 2.54)) - (5.68 * objSelectedUser.Age)
                decActivity = decRMR * decRMRMultiplier
                Dim Factor1 As Double
                Dim Factor2 As Double
                Dim Lean As Double
                Dim Fat As Double

                Factor1 = (objSelectedUser.Weight * 1.082) + 94.42
                Factor2 = objSelectedUser.Waist * 4.15
                Lean = Factor1 - Factor2
                Fat = objSelectedUser.Weight - Lean

                'Outputs data
                optFat.Text = (Fat * 100) / objSelectedUser.Weight
                optBMR.Text = decActivity
                optAge.Text = objSelectedUser.Age
                optName.Text = objSelectedUser.Name
                optWeight.Text = objSelectedUser.Weight
                optHeight.Text = objSelectedUser.Height
                optGender.Text = objSelectedUser.Gender
                optActivity.Text = objSelectedUser.Activity
            Else
                'Calculates data
                decRMR = (447.6 + 9.25 * (objSelectedUser.Weight * 0.453592)) + (4.8 * (objSelectedUser.Height * 2.54)) - (4.33 * objSelectedUser.Age)
                decActivity = decRMR * decRMRMultiplier
                Dim Factor1 As Double
                Dim Factor2 As Double
                Dim Factor3 As Double
                Dim Factor4 As Double
                Dim Factor5 As Double
                Dim Lean As Double
                Dim Fat As Double

                Factor1 = (objSelectedUser.Weight * 0.732) + 8.987
                Factor2 = objSelectedUser.Wrist * 3.14
                Factor3 = objSelectedUser.Waist * 0.157
                Factor4 = objSelectedUser.Hip * 0.249
                Factor5 = objSelectedUser.Forearm * 0.434
                Lean = Factor1 + Factor2 - Factor3 - Factor4 + Factor5
                Fat = objSelectedUser.Weight - Lean

                'Outputs data
                optFat.Text = (Fat * 100) / objSelectedUser.Weight
                optBMR.Text = decActivity
                optAge.Text = objSelectedUser.Age
                optName.Text = objSelectedUser.Name
                optWeight.Text = objSelectedUser.Weight
                optHeight.Text = objSelectedUser.Height
                optGender.Text = objSelectedUser.Gender
                optActivity.Text = objSelectedUser.Activity
            End If
        Else
            'If no user is selected set output to empty
            optFat.Text = "*"
            optBMR.Text = "*"
            optAge.Text = "*"
            optName.Text = "*"
            optWeight.Text = "*"
            optHeight.Text = "*"
            optGender.Text = "*"
            optActivity.Text = "*"
        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim objUser As New User()
        boolAgeNum = True
        boolWeightNum = True
        boolHeightNum = True
        decRMR = 0
        decRMRMultiplier = 0
        decActivity = 0
        'I'm using a errorMsg variable so I can store multiple error messages into a single msgBox in order to avoid spamming the user with multiple msgBoxes from different errors
        strErrorMsg = ""
        If Not txtName.Text = "" Then
            objUser.Name = txtName.Text
        Else
            strErrorMsg += "You must enter a name." & vbCrLf
        End If

        'Method containing various methods to validate the input from the user before setting the variable equal to the input
        'Simple check to ensure that something was inputted and the value is not default
        If Not txtAge.Text = "" Then
            'Validates that the text only contains digits and sets boolean to false if it does not
            For i = 0 To txtAge.Text.Length - 1
                If Not Char.IsDigit(txtAge.Text.Chars(i)) Then
                    strErrorMsg += "Age must be a number." & vbCrLf
                    boolAgeNum = False
                End If
            Next
            'A wrapper statement checking boolAgeNum is not false, to ensure the code doesn't try to run Convert.ToInt32 when their is invalid charachters in the input
            If boolAgeNum = True Then
                'Checks that the converted integer is not 0
                If Convert.ToInt32(txtAge.Text) > 0 Then
                    objUser.Age = Convert.ToInt32(txtAge.Text)
                Else
                    strErrorMsg += "You must enter an age more than 0." & vbCrLf
                End If
            End If
        Else
            strErrorMsg += "You must enter an age." & vbCrLf
        End If

        Try
            objUser.Waist = txtWaist.Text
        Catch ex As Exception
            strErrorMsg += "You entered an invalid waist measurement." & vbCrLf
        End Try

        Try
            objUser.Wrist = txtWrist.Text
        Catch ex As Exception
            strErrorMsg += "You entered an invalid wrist measurement." & vbCrLf
        End Try

        Try
            objUser.Hip = txtHip.Text
        Catch ex As Exception
            strErrorMsg += "You entered an invalid hip measurement." & vbCrLf
        End Try

        Try
            objUser.Forearm = txtForearm.Text
        Catch ex As Exception
            strErrorMsg += "You entered an invalid forearm measurement." & vbCrLf
        End Try

        'Method containing various methods to validate the input from the user before setting the variable equal to the input
        'Simple check to ensure that something was inputted and the value is not default
        If Not txtWeight.Text = "" Then
            'Validates that the text only contains digits and sets boolean to false if it does not
            For i = 0 To txtWeight.Text.Length - 1
                If Not Char.IsDigit(txtWeight.Text.Chars(i)) Then
                    strErrorMsg += "Weight must be a number." & vbCrLf
                    boolWeightNum = False
                End If
            Next
            'A wrapper statement checking boolWeightNum is not false, to ensure the code doesn't try to run Convert.ToInt32 when their is invalid charachters in the input
            If boolWeightNum = True Then
                'Checks that the converted integer is not 0
                If Convert.ToInt32(txtWeight.Text) > 0 Then
                    objUser.Weight = Convert.ToInt32(txtWeight.Text)
                Else
                    strErrorMsg += "You must enter a weight more than 0." & vbCrLf
                End If
            End If
        Else
            strErrorMsg += "You must enter a weight." & vbCrLf
        End If

        'Method containing various methods to validate the input from the user before setting the variable equal to the input
        'Simple check to ensure that something was inputted and the value is not default
        If Not txtHeight.Text = "" Then
            'Validates that the text only contains digits and sets boolean to false if it does not
            For i = 0 To txtHeight.Text.Length - 1
                If Not Char.IsDigit(txtHeight.Text.Chars(i)) Then
                    strErrorMsg += "Height must be a number." & vbCrLf
                    boolHeightNum = False
                End If
            Next
            'A wrapper statement checking boolHeightNum is not false, to ensure the code doesn't try to run Convert.ToInt32 when their is invalid charachters in the input
            If boolHeightNum = True Then
                'Checks that the converted integer is not 0
                If Convert.ToInt32(txtHeight.Text) > 0 Then
                    objUser.Height = Convert.ToInt32(txtHeight.Text)
                Else
                    strErrorMsg += "You must enter a height more than 0." & vbCrLf
                End If
            End If
        Else
            strErrorMsg += "You must enter a height." & vbCrLf
        End If

        'Validate that the user has selected an item in cmbSex then set strSex equal to it
        If Not cmbSex.SelectedItem = "" Then
            objUser.Gender = cmbSex.SelectedItem
        Else
            strErrorMsg += "You must select a sex." & vbCrLf
        End If

        'Validate that the user has selected an item in cmbActivity then set strActivity equal to it
        If Not cmbActivity.SelectedItem = "" Then
            objUser.Activity = cmbActivity.SelectedItem
        Else
            strErrorMsg += "You must select an activity level." & vbCrLf
        End If

        If objUser.Activity = "" Or objUser.Gender = "" Or objUser.Age = 0 Or objUser.Weight = 0 Or objUser.Height = 0 Then
            'This IF ELSE clause was added incase the user changes an input variable to something invalid after running it with 
            'something valid. If that happens the calculation method would still run but with invalid data. To prevent that I added this validation
            'stage.
        Else
            'Sets correct value of decRMRMultiplier by getting what activity was selected
            If objUser.Activity = "Sitting or Lying all day" Then
                decRMRMultiplier = 1.2
            ElseIf objUser.Activity = "Seated work, no exercise" Then
                decRMRMultiplier = 1.3
            ElseIf objUser.Activity = "Seated work, light exercise" Then
                decRMRMultiplier = 1.4
            ElseIf objUser.Activity = "Moderately physical work, no exercise" Then
                decRMRMultiplier = 1.5
            ElseIf objUser.Activity = "Moderately physical work, light exercise" Then
                decRMRMultiplier = 1.6
            ElseIf objUser.Activity = "Moderately physical work, heavy exercise" Then
                decRMRMultiplier = 1.7
            ElseIf objUser.Activity = "Heavy work or Heavy Exercise" Then
                decRMRMultiplier = 1.8
            End If
            'Checks genders
            If objUser.Gender = "Male" Then
                'Calculates data
                decRMR = (88.4 + 13.4 * (objUser.Weight * 0.453592)) + (4.8 * (objUser.Height * 2.54)) - (5.68 * objUser.Age)
                decActivity = decRMR * decRMRMultiplier
                Dim Factor1 As Double
                Dim Factor2 As Double
                Dim Lean As Double
                Dim Fat As Double

                Factor1 = (objUser.Weight * 1.082) + 94.42
                Factor2 = objUser.Waist * 4.15
                Lean = Factor1 - Factor2
                Fat = objUser.Weight - Lean

                'Ouputs data
                optFat.Text = (Fat * 100) / objUser.Weight
                optBMR.Text = decActivity
                optAge.Text = objUser.Age
                optName.Text = objUser.Name
                optWeight.Text = objUser.Weight
                optHeight.Text = objUser.Height
                optGender.Text = objUser.Gender
                optActivity.Text = objUser.Activity
                lstUsers.Add(objUser)
                objSelectedUser = objUser
            Else
                'Calculates data
                decRMR = (447.6 + 9.25 * (objUser.Weight * 0.453592)) + (4.8 * (objUser.Height * 2.54)) - (4.33 * objUser.Age)
                decActivity = decRMR * decRMRMultiplier
                Dim Factor1 As Double
                Dim Factor2 As Double
                Dim Factor3 As Double
                Dim Factor4 As Double
                Dim Factor5 As Double
                Dim Lean As Double
                Dim Fat As Double

                Factor1 = (objUser.Weight * 0.732) + 8.987
                Factor2 = objUser.Wrist * 3.14
                Factor3 = objUser.Waist * 0.157
                Factor4 = objUser.Hip * 0.249
                Factor5 = objUser.Forearm * 0.434
                Lean = Factor1 + Factor2 - Factor3 - Factor4 + Factor5
                Fat = objUser.Weight - Lean

                'Outputs data
                optFat.Text = (Fat * 100) / objUser.Weight
                optBMR.Text = decActivity
                optAge.Text = objUser.Age
                optName.Text = objUser.Name
                optWeight.Text = objUser.Weight
                optHeight.Text = objUser.Height
                optGender.Text = objUser.Gender
                optActivity.Text = objUser.Activity
                lstUsers.Add(objUser)
                objSelectedUser = objUser
            End If
        End If
        'Checks is there is any error messages, then displays them if there are
        If Not strErrorMsg = "" Then
            MsgBox(strErrorMsg)
        End If



    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears value of public variables
        decRMR = 0
        decRMRMultiplier = 0
        decActivity = 0

        'Clears value of text boxes and clears selection of combo boxes
        txtAge.Text = ""
        txtWeight.Text = ""
        txtHeight.Text = ""
        txtWaist.Text = ""
        txtWrist.Text = ""
        txtForearm.Text = ""
        txtHip.Text = ""
        txtName.Text = ""
        optFat.Text = "*"
        optBMR.Text = "*"
        optAge.Text = "*"
        optName.Text = "*"
        optWeight.Text = "*"
        optHeight.Text = "*"
        optGender.Text = "*"
        optActivity.Text = "*"
        cmbSex.SelectedIndex = -1
        cmbActivity.SelectedIndex = -1
    End Sub

    Private Sub FitnessCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbxUsers.DataSource = lstUsers
        lbxUsers.DisplayMember = "name"

        'Sets up connection to database, retrieves data, then gives it to the application
        Dim dbConnection As SqlConnection = ConnectToDb()
        Dim daUser As New SqlDataAdapter("SELECT * FROM [User]", dbConnection)

        daUser.FillSchema(dsUser, SchemaType.Source, "[User]")
        daUser.Fill(dsUser, "[User]")

        Dim userTable As DataTable = dsUser.Tables.Item("[User]")
        Dim selectCommand As New SqlCommand("SELECT * FROM [User]", dbConnection)

        For Each uRow As DataRow In userTable.Rows
            Dim storedUser As New User()
            storedUser.Id = CInt(uRow.Item("Id"))
            storedUser.Name = uRow.Item("Name").ToString
            storedUser.Age = uRow.Item("Age")
            storedUser.Activity = uRow.Item("Activity").ToString
            storedUser.Gender = uRow.Item("Gender").ToString
            storedUser.Height = uRow.Item("Height")
            storedUser.Weight = uRow.Item("Weight")
            storedUser.Waist = uRow.Item("Waist")
            storedUser.Wrist = uRow.Item("Wrist")
            storedUser.Hip = uRow.Item("Hip")
            storedUser.Forearm = uRow.Item("Forearm")
            lstUsers.Add(storedUser)
        Next

        objSelectedUser = CType(lbxUsers.SelectedItem, User)
        Output()

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub lbxUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUsers.SelectedIndexChanged
        If Not lbxUsers.SelectedItem Is Nothing Then
            objSelectedUser = CType(lbxUsers.SelectedItem, User)
            Output()
        Else
            objSelectedUser = Nothing
            Output()
        End If
    End Sub

    Private Function ConnectToDb() As SqlConnection
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        Dim strconnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "Fitness.mdf"
        Dim dbConnection As New SqlConnection(strconnection)
        dbConnection.Open()
        Return dbConnection
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check if a user is selected
        If objSelectedUser Is Nothing Then
            MsgBox("You must select a user.")
        Else
            'Save User to Database
            Dim dbConnection As SqlConnection = ConnectToDb()
            Dim daUser As New SqlDataAdapter("SELECT * FROM [User]", dbConnection)
            Dim cmd As New SqlCommandBuilder(daUser)

            daUser.InsertCommand = cmd.GetInsertCommand
            daUser.UpdateCommand = cmd.GetUpdateCommand
            Dim userTable As DataTable = dsUser.Tables.Item("[User]")

            If objSelectedUser.Id > 0 Then
                ' existing user so we do update
                Dim existingRow As DataRow = userTable.Rows.Find(objSelectedUser.Id)
                PopulateRow(existingRow)
            Else
                ' new user so we do insert
                Dim newRow As DataRow = userTable.NewRow()
                PopulateRow(newRow)
                userTable.Rows.Add(newRow)

                objSelectedUser.Id = CInt(newRow.Item("Id"))
            End If

            daUser.Update(dsUser, "[User]")

            dbConnection.Close()
            dbConnection.Dispose()
        End If
    End Sub

    Private Sub PopulateRow(row As DataRow)
        row.Item("Name") = objSelectedUser.Name
        row.Item("Age") = objSelectedUser.Age
        row.Item("Activity") = objSelectedUser.Activity
        row.Item("Gender") = objSelectedUser.Gender
        row.Item("Height") = objSelectedUser.Height
        row.Item("Weight") = objSelectedUser.Weight
        row.Item("Waist") = objSelectedUser.Waist
        row.Item("Wrist") = objSelectedUser.Wrist
        row.Item("Hip") = objSelectedUser.Hip
        row.Item("Forearm") = objSelectedUser.Forearm
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Check if a user is selected
        If objSelectedUser Is Nothing Then
            MsgBox("You must select a user.")
        Else
            'Delete from database
            If dsUser.Tables("[User]").Rows.Contains(objSelectedUser.Id) Then
                Dim dbConnection As SqlConnection = ConnectToDb()
                Dim daUser As New SqlDataAdapter("SELECT * FROM [User]", dbConnection)
                Dim cmd As New SqlCommandBuilder(daUser)

                daUser.DeleteCommand = cmd.GetDeleteCommand()
                dsUser.Tables("[User]").Rows.Find(objSelectedUser.Id).Delete()

                daUser.Update(dsUser, "[User]")

                dbConnection.Close()
                dbConnection.Dispose()
            End If

            'Remove deleted user
            lstUsers.Remove(objSelectedUser)
            objSelectedUser = CType(lbxUsers.SelectedItem, User)
            Output()
        End If
    End Sub

End Class
