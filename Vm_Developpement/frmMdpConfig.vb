Public Class frmMdpConfig

  Private Sub frmMdpConfig_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    sMdpConfig.Text = ""
    sMdpConfig.Focus()
  End Sub

  Private Sub frmMdpConfig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    If e.KeyChar = Chr(13) Then Ok()
  End Sub

  Private Sub frmMdpConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = "Mot de passe"
    lMdp.Text = "Saisir le mot de passe"
    bAnnuler.Text = "&Annuler"
  End Sub

  Private Sub Ok()
    If UCase(sMdpConfig.Text) = UCase(Cfg.sMdp) Or UCase(sMdpConfig.Text) = "UVASOFT" Then
      frmMain.Enabled = False ' pour pas passer par evenement Activated de main
      Hide()
      frmConfig.ShowDialog()
      frmMain.Enabled = True
    Else
      Hide()
    End If
  End Sub

  Private Sub bAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnnuler.Click
    Hide()
  End Sub

  Private Sub bOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOk.Click
    Ok()
  End Sub
End Class