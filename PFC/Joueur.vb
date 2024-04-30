Imports PFC.PFCgame

Public Class Joueur
    Public Property Nom As String
    Public Property Choix As Choix

    Public Sub New(nom As String)
        Me.Nom = nom
    End Sub
    Public Sub Choisir(coup As Choix)
        Me.Choix = coup
    End Sub

End Class
