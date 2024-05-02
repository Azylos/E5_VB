Imports System.Formats.Asn1.AsnWriter

Public Class Entite
    Private Nom As String
    Private Score As Integer

    Public Sub New(nom As String)
        Me.Nom = nom
        Score = 0
    End Sub
    Public Function GetNom() As String
        Return Nom
    End Function
    Public Function GetScore() As Integer
        Return Score
    End Function
    Public Sub AjouterScore()
        Score += 1
    End Sub

End Class
