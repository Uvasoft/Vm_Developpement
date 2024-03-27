Public Class frmMode
  Public Sub New()
    ' Cet appel est requis par le concepteur.
    InitializeComponent()
    ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub

  Private Sub frmMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Pgm.Cpt = 5
    lModeAuto.Text = "Passage en mode AUTO dans " & Pgm.Cpt & " secondes"
    Timer1.Interval = 1000
    Timer1.Enabled = True
  End Sub

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    Pgm.Cpt = Pgm.Cpt - 1
    If Pgm.Cpt = 0 Then
      Timer1.Enabled = False
      Pgm.cbModeAuto = True
      Me.Hide()
      frmMain.Show()
    Else
      lModeAuto.Text = "Passage en mode AUTO dans " & Pgm.Cpt & " secondes"
    End If
  End Sub

  Private Sub bManu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bManu.Click
    Timer1.Enabled = False
    Pgm.cbModeAuto = False
    Me.Hide()
    frmMain.Show()
  End Sub

  Private Sub bAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAuto.Click
    Timer1.Enabled = False
    Pgm.cbModeAuto = True
    Me.Hide()
    frmMain.Show()
  End Sub

End Class