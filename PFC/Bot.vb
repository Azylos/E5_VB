Imports PFC.PFCgame

Public Class Bot
    Public Property Nom As String
    Public Sub New(nom As String)
        Me.Nom = nom
    End Sub
    Public Function ChoisirCoup() As Choix
        Dim aleatoire As New Random()
        Dim valeurAleatoire As Integer = aleatoire.Next(1, 4)

        Select Case valeurAleatoire
            Case 1
                Return Choix.Pierre
            Case 2
                Return Choix.Feuille
            Case Else
                Return Choix.Ciseaux
        End Select
    End Function
End Class
