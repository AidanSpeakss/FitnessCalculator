'Name: Aidan Raney
'Date: 3/4/2021
'Purpose: L6 - Test Assignment 3

Option Strict On
Option Explicit On

Public Class User
    Public Id As Integer
    Private strName As String
    Private dblHeight As Double
    Private dblWeight As Double
    Private dblAge As Double
    Private strGender As String
    Private strActivity As String
    Private dblWaist As Double
    Private dblWrist As Double
    Private dblHip As Double
    Private dblForearm As Double

    Public Property Name As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = value
        End Set
    End Property

    Public Property Height As Double
        Get
            Return dblHeight
        End Get
        Set(value As Double)
            dblHeight = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return dblWeight
        End Get
        Set(value As Double)
            dblWeight = value
        End Set
    End Property

    Public Property Age As Double
        Get
            Return dblAge
        End Get
        Set(value As Double)
            dblAge = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return strGender
        End Get
        Set(value As String)
            strGender = value
        End Set
    End Property

    Public Property Activity As String
        Get
            Return strActivity
        End Get
        Set(value As String)
            strActivity = value
        End Set
    End Property

    Public Property Waist As Double
        Get
            Return dblWaist
        End Get
        Set(value As Double)
            dblWaist = value
        End Set
    End Property

    Public Property Wrist As Double
        Get
            Return dblWrist
        End Get
        Set(value As Double)
            dblWrist = value
        End Set
    End Property
    Public Property Hip As Double
        Get
            Return dblHip
        End Get
        Set(value As Double)
            dblWrist = value
        End Set
    End Property

    Public Property Forearm As Double
        Get
            Return dblForearm
        End Get
        Set(value As Double)
            dblForearm = value
        End Set
    End Property

    Public Sub New()
        strName = String.Empty
        dblHeight = 0
        dblWeight = 0
        dblAge = 0
        strGender = String.Empty
        strActivity = String.Empty
        dblWaist = 0
        dblWrist = 0
        dblHip = 0
        dblForearm = 0
    End Sub
End Class
