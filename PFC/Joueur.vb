Imports PFC.PFCgame

Public Class Joueur
    Inherits Entite
    Private Property Choix As Choix
    Public Sub New(nom As String)
        MyBase.New(nom)
    End Sub
    Public Sub Choisir(coup As Choix)
        Me.Choix = coup
    End Sub
    Public Function GetChoix()
        Return Choix
    End Function
End Class
