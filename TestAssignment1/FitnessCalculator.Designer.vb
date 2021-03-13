<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FitnessCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.cmbActivity = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWaist = New System.Windows.Forms.Label()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWrist = New System.Windows.Forms.TextBox()
        Me.lblHip = New System.Windows.Forms.Label()
        Me.txtHip = New System.Windows.Forms.TextBox()
        Me.lblForearm = New System.Windows.Forms.Label()
        Me.txtForearm = New System.Windows.Forms.TextBox()
        Me.lbxUsers = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.optName = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbxMeasurement = New System.Windows.Forms.ComboBox()
        Me.optHeight = New System.Windows.Forms.Label()
        Me.optWeight = New System.Windows.Forms.Label()
        Me.optAge = New System.Windows.Forms.Label()
        Me.optGender = New System.Windows.Forms.Label()
        Me.optBMR = New System.Windows.Forms.Label()
        Me.optActivity = New System.Windows.Forms.Label()
        Me.optFat = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(14, 68)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(85, 13)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Enter Weight:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(18, 101)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(82, 13)
        Me.lblHeight.TabIndex = 2
        Me.lblHeight.Text = "Enter Height:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(102, 65)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 4
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(102, 97)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 5
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPounds.Location = New System.Drawing.Point(205, 69)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(49, 13)
        Me.lblPounds.TabIndex = 6
        Me.lblPounds.Text = "Pounds"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInches.Location = New System.Drawing.Point(205, 105)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(45, 13)
        Me.lblInches.TabIndex = 7
        Me.lblInches.Text = "Inches"
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbSex.Location = New System.Drawing.Point(102, 129)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(100, 21)
        Me.cmbSex.TabIndex = 8
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(47, 133)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(52, 13)
        Me.lblSex.TabIndex = 9
        Me.lblSex.Text = "Gender:"
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivity.Location = New System.Drawing.Point(13, 167)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(88, 13)
        Me.lblActivity.TabIndex = 11
        Me.lblActivity.Text = "Activity Level:"
        '
        'cmbActivity
        '
        Me.cmbActivity.FormattingEnabled = True
        Me.cmbActivity.Items.AddRange(New Object() {"Sitting or Lying all day", "Seated work, no exercise", "Seated work, light exercise", "Moderately physical work, no exercise", "Moderately physical work, light exercise", "Moderately physical work, heavy exercise", "Heavy work or Heavy Exercise"})
        Me.cmbActivity.Location = New System.Drawing.Point(103, 162)
        Me.cmbActivity.Name = "cmbActivity"
        Me.cmbActivity.Size = New System.Drawing.Size(212, 21)
        Me.cmbActivity.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(597, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 28)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(715, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 28)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(102, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 26
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(56, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 13)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "Name:"
        '
        'lblWaist
        '
        Me.lblWaist.AutoSize = True
        Me.lblWaist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaist.Location = New System.Drawing.Point(57, 227)
        Me.lblWaist.Name = "lblWaist"
        Me.lblWaist.Size = New System.Drawing.Size(43, 13)
        Me.lblWaist.TabIndex = 27
        Me.lblWaist.Text = "Waist:"
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(102, 223)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(100, 20)
        Me.txtWaist.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Wrist:"
        '
        'txtWrist
        '
        Me.txtWrist.Location = New System.Drawing.Point(102, 252)
        Me.txtWrist.Name = "txtWrist"
        Me.txtWrist.Size = New System.Drawing.Size(100, 20)
        Me.txtWrist.TabIndex = 30
        '
        'lblHip
        '
        Me.lblHip.AutoSize = True
        Me.lblHip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHip.Location = New System.Drawing.Point(71, 285)
        Me.lblHip.Name = "lblHip"
        Me.lblHip.Size = New System.Drawing.Size(30, 13)
        Me.lblHip.TabIndex = 31
        Me.lblHip.Text = "Hip:"
        '
        'txtHip
        '
        Me.txtHip.Location = New System.Drawing.Point(103, 281)
        Me.txtHip.Name = "txtHip"
        Me.txtHip.Size = New System.Drawing.Size(100, 20)
        Me.txtHip.TabIndex = 32
        '
        'lblForearm
        '
        Me.lblForearm.AutoSize = True
        Me.lblForearm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForearm.Location = New System.Drawing.Point(44, 314)
        Me.lblForearm.Name = "lblForearm"
        Me.lblForearm.Size = New System.Drawing.Size(56, 13)
        Me.lblForearm.TabIndex = 33
        Me.lblForearm.Text = "Forearm:"
        '
        'txtForearm
        '
        Me.txtForearm.Location = New System.Drawing.Point(102, 311)
        Me.txtForearm.Name = "txtForearm"
        Me.txtForearm.Size = New System.Drawing.Size(100, 20)
        Me.txtForearm.TabIndex = 34
        '
        'lbxUsers
        '
        Me.lbxUsers.FormattingEnabled = True
        Me.lbxUsers.Location = New System.Drawing.Point(343, 56)
        Me.lbxUsers.Name = "lbxUsers"
        Me.lbxUsers.Size = New System.Drawing.Size(208, 277)
        Me.lbxUsers.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(611, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(608, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Height:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(606, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Weight:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(625, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(607, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Gender:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(621, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "BMR:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(605, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Activity:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(584, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Body Fat %:"
        '
        'optName
        '
        Me.optName.AutoSize = True
        Me.optName.Location = New System.Drawing.Point(656, 159)
        Me.optName.Name = "optName"
        Me.optName.Size = New System.Drawing.Size(11, 13)
        Me.optName.TabIndex = 49
        Me.optName.Text = "*"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(103, 192)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(67, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Age:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(620, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Results:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(340, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Users:"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(579, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(239, 192)
        Me.Label17.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(604, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Settings:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(620, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Metric/Imperial:"
        '
        'cbxMeasurement
        '
        Me.cbxMeasurement.FormattingEnabled = True
        Me.cbxMeasurement.Items.AddRange(New Object() {"Metric", "Imperial"})
        Me.cbxMeasurement.Location = New System.Drawing.Point(706, 109)
        Me.cbxMeasurement.Name = "cbxMeasurement"
        Me.cbxMeasurement.Size = New System.Drawing.Size(100, 21)
        Me.cbxMeasurement.TabIndex = 48
        '
        'optHeight
        '
        Me.optHeight.AutoSize = True
        Me.optHeight.Location = New System.Drawing.Point(656, 178)
        Me.optHeight.Name = "optHeight"
        Me.optHeight.Size = New System.Drawing.Size(11, 13)
        Me.optHeight.TabIndex = 55
        Me.optHeight.Text = "*"
        '
        'optWeight
        '
        Me.optWeight.AutoSize = True
        Me.optWeight.Location = New System.Drawing.Point(656, 202)
        Me.optWeight.Name = "optWeight"
        Me.optWeight.Size = New System.Drawing.Size(11, 13)
        Me.optWeight.TabIndex = 56
        Me.optWeight.Text = "*"
        '
        'optAge
        '
        Me.optAge.AutoSize = True
        Me.optAge.Location = New System.Drawing.Point(656, 224)
        Me.optAge.Name = "optAge"
        Me.optAge.Size = New System.Drawing.Size(11, 13)
        Me.optAge.TabIndex = 57
        Me.optAge.Text = "*"
        '
        'optGender
        '
        Me.optGender.AutoSize = True
        Me.optGender.Location = New System.Drawing.Point(657, 247)
        Me.optGender.Name = "optGender"
        Me.optGender.Size = New System.Drawing.Size(11, 13)
        Me.optGender.TabIndex = 58
        Me.optGender.Text = "*"
        '
        'optBMR
        '
        Me.optBMR.AutoSize = True
        Me.optBMR.Location = New System.Drawing.Point(657, 268)
        Me.optBMR.Name = "optBMR"
        Me.optBMR.Size = New System.Drawing.Size(11, 13)
        Me.optBMR.TabIndex = 59
        Me.optBMR.Text = "*"
        '
        'optActivity
        '
        Me.optActivity.AutoSize = True
        Me.optActivity.Location = New System.Drawing.Point(656, 292)
        Me.optActivity.Name = "optActivity"
        Me.optActivity.Size = New System.Drawing.Size(11, 13)
        Me.optActivity.TabIndex = 62
        Me.optActivity.Text = "*"
        '
        'optFat
        '
        Me.optFat.AutoSize = True
        Me.optFat.Location = New System.Drawing.Point(656, 316)
        Me.optFat.Name = "optFat"
        Me.optFat.Size = New System.Drawing.Size(11, 13)
        Me.optFat.TabIndex = 63
        Me.optFat.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(205, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Inches"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(205, 256)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Inches"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(205, 285)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Inches"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(205, 315)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Inches"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(597, 46)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 28)
        Me.btnSave.TabIndex = 68
        Me.btnSave.Text = "Save User"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(716, 46)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 28)
        Me.btnDelete.TabIndex = 69
        Me.btnDelete.Text = "Delete User"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'FitnessCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(830, 359)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.optFat)
        Me.Controls.Add(Me.optActivity)
        Me.Controls.Add(Me.optBMR)
        Me.Controls.Add(Me.optGender)
        Me.Controls.Add(Me.optAge)
        Me.Controls.Add(Me.optWeight)
        Me.Controls.Add(Me.optHeight)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.optName)
        Me.Controls.Add(Me.cbxMeasurement)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbxUsers)
        Me.Controls.Add(Me.txtForearm)
        Me.Controls.Add(Me.lblForearm)
        Me.Controls.Add(Me.txtHip)
        Me.Controls.Add(Me.lblHip)
        Me.Controls.Add(Me.txtWrist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWaist)
        Me.Controls.Add(Me.lblWaist)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblActivity)
        Me.Controls.Add(Me.cmbActivity)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.cmbSex)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FitnessCalculator"
        Me.Text = "Fitness Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblActivity As Label
    Friend WithEvents cmbActivity As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblWaist As Label
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWrist As TextBox
    Friend WithEvents lblHip As Label
    Friend WithEvents txtHip As TextBox
    Friend WithEvents lblForearm As Label
    Friend WithEvents txtForearm As TextBox
    Friend WithEvents lbxUsers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents optName As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbxMeasurement As ComboBox
    Friend WithEvents optHeight As Label
    Friend WithEvents optWeight As Label
    Friend WithEvents optAge As Label
    Friend WithEvents optGender As Label
    Friend WithEvents optBMR As Label
    Friend WithEvents optActivity As Label
    Friend WithEvents optFat As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
End Class
