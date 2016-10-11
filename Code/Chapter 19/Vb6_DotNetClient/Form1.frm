VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "A COM Application using a .NET Type"
   ClientHeight    =   3480
   ClientLeft      =   120
   ClientTop       =   420
   ClientWidth     =   5040
   LinkTopic       =   "Form1"
   ScaleHeight     =   3480
   ScaleWidth      =   5040
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton btnUseDotNetObject 
      Caption         =   "Use COM Object"
      Height          =   735
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   4455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub btnUseDotNetObject_Click()
  ' Create the .NET object.
  Dim c As New DotNetCalc
  MsgBox c.Add(10, 10), , "Adding with .NET"

  ' Invoke some members of System.Object.
  MsgBox c.ToString, , "ToString value"
End Sub

