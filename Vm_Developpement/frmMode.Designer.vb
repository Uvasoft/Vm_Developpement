<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMode
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
    Me.components = New System.ComponentModel.Container()
    Me.lModeAuto = New System.Windows.Forms.Label()
    Me.bManu = New System.Windows.Forms.Button()
    Me.bAuto = New System.Windows.Forms.Button()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'lModeAuto
    '
    Me.lModeAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lModeAuto.Location = New System.Drawing.Point(16, 27)
    Me.lModeAuto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lModeAuto.Name = "lModeAuto"
    Me.lModeAuto.Size = New System.Drawing.Size(520, 28)
    Me.lModeAuto.TabIndex = 67
    Me.lModeAuto.Text = "Passage en mode Auto dans x secondes"
    Me.lModeAuto.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'bManu
    '
    Me.bManu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bManu.Location = New System.Drawing.Point(58, 75)
    Me.bManu.Margin = New System.Windows.Forms.Padding(4)
    Me.bManu.Name = "bManu"
    Me.bManu.Size = New System.Drawing.Size(174, 66)
    Me.bManu.TabIndex = 69
    Me.bManu.Text = "Mode Manuel"
    Me.bManu.UseVisualStyleBackColor = True
    '
    'bAuto
    '
    Me.bAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bAuto.Location = New System.Drawing.Point(295, 75)
    Me.bAuto.Margin = New System.Windows.Forms.Padding(4)
    Me.bAuto.Name = "bAuto"
    Me.bAuto.Size = New System.Drawing.Size(174, 66)
    Me.bAuto.TabIndex = 70
    Me.bAuto.Text = "&Mode Automatique"
    Me.bAuto.UseVisualStyleBackColor = True
    '
    'Timer1
    '
    '
    'frmMode
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ClientSize = New System.Drawing.Size(552, 175)
    Me.ControlBox = False
    Me.Controls.Add(Me.bAuto)
    Me.Controls.Add(Me.bManu)
    Me.Controls.Add(Me.lModeAuto)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "frmMode"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mode d'impression"
    Me.TopMost = True
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lModeAuto As System.Windows.Forms.Label
  Friend WithEvents bManu As System.Windows.Forms.Button
  Friend WithEvents bAuto As System.Windows.Forms.Button
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
