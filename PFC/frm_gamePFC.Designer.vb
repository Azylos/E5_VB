<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gamePFC
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_pierre = New Button()
        btn_feuille = New Button()
        btn_ciseau = New Button()
        lbl_nomJ = New Label()
        lbl_resultat = New Label()
        lbl_nomBot = New Label()
        pb_fond = New PictureBox()
        CType(pb_fond, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_pierre
        ' 
        btn_pierre.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        btn_pierre.Location = New Point(24, 405)
        btn_pierre.Name = "btn_pierre"
        btn_pierre.Size = New Size(173, 55)
        btn_pierre.TabIndex = 0
        btn_pierre.Text = "Pierre"
        btn_pierre.UseVisualStyleBackColor = True
        ' 
        ' btn_feuille
        ' 
        btn_feuille.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        btn_feuille.Location = New Point(287, 405)
        btn_feuille.Name = "btn_feuille"
        btn_feuille.Size = New Size(173, 55)
        btn_feuille.TabIndex = 1
        btn_feuille.Text = "Feuille"
        btn_feuille.UseVisualStyleBackColor = True
        ' 
        ' btn_ciseau
        ' 
        btn_ciseau.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold)
        btn_ciseau.Location = New Point(543, 405)
        btn_ciseau.Name = "btn_ciseau"
        btn_ciseau.Size = New Size(173, 55)
        btn_ciseau.TabIndex = 2
        btn_ciseau.Text = "Ciseau"
        btn_ciseau.UseVisualStyleBackColor = True
        ' 
        ' lbl_nomJ
        ' 
        lbl_nomJ.AutoSize = True
        lbl_nomJ.BackColor = Color.Transparent
        lbl_nomJ.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_nomJ.Location = New Point(325, 307)
        lbl_nomJ.Name = "lbl_nomJ"
        lbl_nomJ.Size = New Size(110, 20)
        lbl_nomJ.TabIndex = 3
        lbl_nomJ.Text = "(nom joueur)"
        ' 
        ' lbl_resultat
        ' 
        lbl_resultat.AutoSize = True
        lbl_resultat.BackColor = Color.Black
        lbl_resultat.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold)
        lbl_resultat.ForeColor = SystemColors.ButtonHighlight
        lbl_resultat.Location = New Point(242, 184)
        lbl_resultat.Name = "lbl_resultat"
        lbl_resultat.Size = New Size(281, 37)
        lbl_resultat.TabIndex = 4
        lbl_resultat.Text = "resultat du match"
        ' 
        ' lbl_nomBot
        ' 
        lbl_nomBot.AutoSize = True
        lbl_nomBot.BackColor = Color.Transparent
        lbl_nomBot.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_nomBot.Location = New Point(325, 45)
        lbl_nomBot.Name = "lbl_nomBot"
        lbl_nomBot.Size = New Size(86, 20)
        lbl_nomBot.TabIndex = 5
        lbl_nomBot.Text = "(nom bot)"
        ' 
        ' pb_fond
        ' 
        pb_fond.BackColor = Color.Transparent
        pb_fond.BackgroundImage = My.Resources.Resources.fond
        pb_fond.BackgroundImageLayout = ImageLayout.Stretch
        pb_fond.Dock = DockStyle.Fill
        pb_fond.Location = New Point(0, 0)
        pb_fond.Name = "pb_fond"
        pb_fond.Size = New Size(776, 519)
        pb_fond.TabIndex = 6
        pb_fond.TabStop = False
        ' 
        ' frm_gamePFC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(776, 519)
        Controls.Add(lbl_nomBot)
        Controls.Add(lbl_resultat)
        Controls.Add(lbl_nomJ)
        Controls.Add(btn_ciseau)
        Controls.Add(btn_feuille)
        Controls.Add(btn_pierre)
        Controls.Add(pb_fond)
        Name = "frm_gamePFC"
        Text = "PFC Game"
        CType(pb_fond, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_pierre As Button
    Friend WithEvents btn_feuille As Button
    Friend WithEvents btn_ciseau As Button
    Friend WithEvents lbl_nomJ As Label
    Friend WithEvents lbl_resultat As Label
    Friend WithEvents lbl_nomBot As Label
    Friend WithEvents pb_fond As PictureBox
End Class
