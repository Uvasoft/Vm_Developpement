Public Class frmMessage
  Public Enum eBouton
    bAucun = 10
    bOkOnly = vbOKOnly
    bOkCancel = vbOKCancel
  End Enum
  'Dim Wait As Integer
  Private Sub bOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOk.Click
    '   Me.DialogResult = DialogResult.OK
  End Sub

  Public Sub Message(ByVal Message As String, Optional ByVal Bouton As eBouton = eBouton.bOkOnly) ' jmw ByVal DisplayMode As FormShowConstants)
    If Bouton = eBouton.bOkOnly Then
      bOk.Visible = True
      bCancel.Visible = False
    ElseIf Bouton = eBouton.bOkCancel Then
      bOk.Visible = True
      bCancel.Visible = True
    ElseIf Bouton = eBouton.bAucun Then
      bOk.Visible = False
      bCancel.Visible = False
    End If
    lMessage.Text = Message
  End Sub

  Private Sub frmWait_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    Me.TopMost = True
    If Me.Modal Then
      bOk.Visible = True
      Me.Text = "Message"
    Else
      Me.Text = "Traitement en cours"
      'Wait = 1
      'While Wait <> 0
      'System.Windows.Forms.Application.DoEvents()
      'End While
    End If
  End Sub

  Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
    '    Me.DialogResult = DialogResult.Cancel
  End Sub

End Class