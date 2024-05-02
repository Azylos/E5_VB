Public Class PFCgame
    Public Enum Choix
        Pierre
        Feuille
        Ciseaux
    End Enum

    Public Sub JouerCoupJoueur(choixJoueur As Choix, joueur As Joueur, bot As Bot, lbl_nomBot As Label, lbl_resultat As Label, lbl_scores As Label)
        Dim coupBot As Choix = bot.ChoisirCoup()

        Dim resultat As String = DeterminerGagnant(choixJoueur, coupBot, joueur, bot)

        ' Afficher le résultat
        lbl_nomBot.Text = $"{bot.GetNom()} a choisi : {coupBot}"
        lbl_resultat.Text = resultat

        ' Mise à jour du score
        lbl_scores.Text = $"Score {joueur.GetNom()} : {joueur.GetScore()} {vbCrLf} Score {bot.GetNom()} : {bot.GetScore()}"
    End Sub

    Private Function DeterminerGagnant(coupJoueur As Choix, coupBot As Choix, joueur As Joueur, bot As Bot) As String
        If coupJoueur = coupBot Then
            Return "match nul"
        ElseIf (coupJoueur = Choix.Pierre AndAlso coupBot = Choix.Ciseaux) OrElse
               (coupJoueur = Choix.Feuille AndAlso coupBot = Choix.Pierre) OrElse
               (coupJoueur = Choix.Ciseaux AndAlso coupBot = Choix.Feuille) Then
            joueur.AjouterScore()
            Return $"{joueur.GetNom()} a gagné !"
        Else
            bot.AjouterScore()
            Return $"{bot.GetNom()} a gagné."
        End If
    End Function
End Class
