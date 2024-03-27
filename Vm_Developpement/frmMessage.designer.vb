<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessage))
    Me.lMessage = New System.Windows.Forms.Label()
    Me.bOk = New System.Windows.Forms.Button()
    Me.bCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lMessage
    '
    Me.lMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lMessage.Location = New System.Drawing.Point(36, 31)
    Me.lMessage.Name = "lMessage"
    Me.lMessage.Size = New System.Drawing.Size(406, 101)
    Me.lMessage.TabIndex = 0
    Me.lMessage.Text = "Message"
    Me.lMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'bOk
    '
    Me.bOk.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.bOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bOk.Location = New System.Drawing.Point(327, 148)
    Me.bOk.Name = "bOk"
    Me.bOk.Size = New System.Drawing.Size(115, 42)
    Me.bOk.TabIndex = 1
    Me.bOk.Text = "&Ok"
    Me.bOk.UseVisualStyleBackColor = True
    '
    'bCancel
    '
    Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.bCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bCancel.Location = New System.Drawing.Point(178, 148)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.Size = New System.Drawing.Size(115, 42)
    Me.bCancel.TabIndex = 2
    Me.bCancel.Text = "&Cancel"
    Me.bCancel.UseVisualStyleBackColor = True
    '
    'frmMessage
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ClientSize = New System.Drawing.Size(475, 216)
    Me.ControlBox = False
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bOk)
    Me.Controls.Add(Me.lMessage)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmMessage"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Traitement en cours"
    Me.TopMost = True
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lMessage As System.Windows.Forms.Label
  Friend WithEvents bOk As System.Windows.Forms.Button
  Friend WithEvents bCancel As System.Windows.Forms.Button
End Class
