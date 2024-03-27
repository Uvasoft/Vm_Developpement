<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdpConfig
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMdpConfig))
    Me.lMdp = New System.Windows.Forms.Label()
    Me.bOk = New System.Windows.Forms.Button()
    Me.bAnnuler = New System.Windows.Forms.Button()
    Me.sMdpConfig = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'lMdp
    '
    Me.lMdp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lMdp.Location = New System.Drawing.Point(56, 26)
    Me.lMdp.Name = "lMdp"
    Me.lMdp.Size = New System.Drawing.Size(235, 22)
    Me.lMdp.TabIndex = 27
    Me.lMdp.Text = "Saisie du mot de passe"
    Me.lMdp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'bOk
    '
    Me.bOk.BackColor = System.Drawing.Color.SteelBlue
    Me.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bOk.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bOk.ForeColor = System.Drawing.Color.White
    Me.bOk.Location = New System.Drawing.Point(192, 117)
    Me.bOk.Name = "bOk"
    Me.bOk.Size = New System.Drawing.Size(99, 36)
    Me.bOk.TabIndex = 28
    Me.bOk.Text = "&Ok"
    Me.bOk.UseVisualStyleBackColor = False
    '
    'bAnnuler
    '
    Me.bAnnuler.BackColor = System.Drawing.Color.SteelBlue
    Me.bAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bAnnuler.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bAnnuler.ForeColor = System.Drawing.Color.White
    Me.bAnnuler.Location = New System.Drawing.Point(56, 117)
    Me.bAnnuler.Name = "bAnnuler"
    Me.bAnnuler.Size = New System.Drawing.Size(99, 36)
    Me.bAnnuler.TabIndex = 29
    Me.bAnnuler.Text = "&Annuler"
    Me.bAnnuler.UseVisualStyleBackColor = False
    '
    'sMdpConfig
    '
    Me.sMdpConfig.BackColor = System.Drawing.Color.SteelBlue
    Me.sMdpConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sMdpConfig.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sMdpConfig.ForeColor = System.Drawing.Color.White
    Me.sMdpConfig.Location = New System.Drawing.Point(56, 69)
    Me.sMdpConfig.MaxLength = 10
    Me.sMdpConfig.Name = "sMdpConfig"
    Me.sMdpConfig.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.sMdpConfig.Size = New System.Drawing.Size(235, 30)
    Me.sMdpConfig.TabIndex = 30
    '
    'frmMdpConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ClientSize = New System.Drawing.Size(349, 165)
    Me.ControlBox = False
    Me.Controls.Add(Me.sMdpConfig)
    Me.Controls.Add(Me.bAnnuler)
    Me.Controls.Add(Me.bOk)
    Me.Controls.Add(Me.lMdp)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.Name = "frmMdpConfig"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mot de passe"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lMdp As System.Windows.Forms.Label
  Friend WithEvents bOk As System.Windows.Forms.Button
  Friend WithEvents bAnnuler As System.Windows.Forms.Button
  Friend WithEvents sMdpConfig As System.Windows.Forms.TextBox
End Class
