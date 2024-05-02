Imports System.IO
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
        lbl_scores.Parent = pb_fond
        Bot = New Bot("Azylos Bot")
        Jeu = New PFCgame()
        lbl_nomJ.Text = joueur.GetNom()
        lbl_nomBot.Text = Bot.GetNom()
        lbl_scores.Text = $"Score {joueur.GetNom()} : {joueur.GetScore()} {vbCrLf} Score {Bot.GetNom()} : {Bot.GetScore()}"
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
        Jeu.JouerCoupJoueur(joueur.GetChoix(), joueur, Bot, lbl_nomBot, lbl_resultat, lbl_scores)
        lbl_nomJ.Text = $"{joueur.GetNom()} a choisi : {joueur.GetChoix()}"
    End Sub

    Private Sub btn_feuille_Click(sender As Object, e As EventArgs) Handles btn_feuille.Click
        joueur.Choisir(Choix.Feuille)
        Jeu.JouerCoupJoueur(joueur.GetChoix(), joueur, Bot, lbl_nomBot, lbl_resultat, lbl_scores)
        lbl_nomJ.Text = $"{joueur.GetNom()} a choisi : {joueur.GetChoix()}"
    End Sub

    Private Sub btn_ciseau_Click(sender As Object, e As EventArgs) Handles btn_ciseau.Click
        joueur.Choisir(Choix.Ciseaux)
        Jeu.JouerCoupJoueur(joueur.GetChoix(), joueur, Bot, lbl_nomBot, lbl_resultat, lbl_scores)
        lbl_nomJ.Text = $"{joueur.GetNom()} a choisi : {joueur.GetChoix()}"
    End Sub
    Private Sub frm_gamePFC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Sauvegarder les scores avant de fermer l'application
        SauvegarderScores(joueur, Bot)
    End Sub
    Private Sub SauvegarderScores(joueur As Joueur, bot As Bot)
        Dim scoresFilePath = Path.Combine(Path.Combine(Path.Combine(Application.StartupPath, "..\..\.."), "data_scores"), "scores.csv")

        ' Vérifier si le fichier existe
        If Not File.Exists(scoresFilePath) Then
            ' Créer le fichier s'il n'existe pas
            Using writer As New StreamWriter(scoresFilePath)
                ' Écrire l'en-tête du fichier CSV si nécessaire
                writer.WriteLine("Date, Nom Joueur, Score Joueur, Nom Bot, Score Bot")
            End Using
        End If

        ' Ouvrir le fichier en mode ajout
        Using writer As New StreamWriter(scoresFilePath, True)
            ' Écrire la nouvelle ligne de score
            writer.WriteLine($"{DateTime.Now},{joueur.GetNom()},{joueur.GetScore()},{bot.GetNom()},{bot.GetScore()}")
        End Using
    End Sub
End Class