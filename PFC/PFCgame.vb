Public Class PFCgame
    Public Enum Choix
        Pierre
        Feuille
        Ciseaux
    End Enum

    Public Sub JouerCoupJoueur(choixJoueur As Choix, bot As Bot, lbl_nomBot As Label, lbl_resultat As Label)
        Dim coupBot As Choix = bot.ChoisirCoup()

        Dim resultat As String = DeterminerGagnant(choixJoueur, coupBot)

        ' Afficher le résultat dans une étiquette ou une zone de texte
        lbl_nomBot.Text = $"{bot.Nom} a choisi : {coupBot}"
        lbl_resultat.Text = resultat
    End Sub

    Private Function DeterminerGagnant(coupJoueur As Choix, coupBot As Choix) As String
        If coupJoueur = coupBot Then
            Return "match nul"
        ElseIf (coupJoueur = Choix.Pierre AndAlso coupBot = Choix.Ciseaux) OrElse
               (coupJoueur = Choix.Feuille AndAlso coupBot = Choix.Pierre) OrElse
               (coupJoueur = Choix.Ciseaux AndAlso coupBot = Choix.Feuille) Then
            Return "Vous avez gagné !"
        Else
            Return "Azylos a gagné."
        End If
    End Function
End Class
