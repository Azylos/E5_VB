Imports System.Reflection.Emit
Imports PFC.PFCgame

Public Class frm_gamePFC
    Private joueur As Joueur
    Private Bot As Bot
    Private Jeu As PFCgame

    Private Sub frm_gamePFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DemanderNomJoueur()
        lbl_nomJ.Parent = pb_fond
        lbl_resultat.Parent = pb_fond
        lbl_nomBot.Parent = pb_fond
        Bot = New Bot("Azylos Bot")
        Jeu = New PFCgame()
        lbl_nomJ.Text = joueur.Nom()
        lbl_nomBot.Text = Bot.Nom()
    End Sub

    Private Sub DemanderNomJoueur()
        Dim nom As String = InputBox("Veuillez saisir votre nom :", "Nom du joueur")
        If nom = "" Then
            End
        ElseIf nom.Trim() = "" Then
            MsgBox("Nom invalide. Veuillez saisir un nom valide.", vbCritical, "Erreur")
            DemanderNomJoueur()
        Else
            joueur = New Joueur(nom)
        End If
    End Sub

    Private Sub btn_pierre_Click(sender As Object, e As EventArgs) Handles btn_pierre.Click
        joueur.Choisir(Choix.Pierre)
        Jeu.JouerCoupJoueur(joueur.Choix, Bot, lbl_nomBot, lbl_resultat)
        lbl_nomJ.Text = joueur.Nom + " a choisi : " + joueur.Choix.ToString()
    End Sub

    Private Sub btn_feuille_Click(sender As Object, e As EventArgs) Handles btn_feuille.Click
        joueur.Choisir(Choix.Feuille)
        Jeu.JouerCoupJoueur(joueur.Choix, Bot, lbl_nomBot, lbl_resultat)
        lbl_nomJ.Text = joueur.Nom() + " a choisi : " + joueur.Choix.ToString()
    End Sub

    Private Sub btn_ciseau_Click(sender As Object, e As EventArgs) Handles btn_ciseau.Click
        joueur.Choisir(Choix.Ciseaux)
        Jeu.JouerCoupJoueur(joueur.Choix, Bot, lbl_nomBot, lbl_resultat)
        lbl_nomJ.Text = joueur.Nom() + " a choisi : " + joueur.Choix.ToString()
    End Sub
End Class