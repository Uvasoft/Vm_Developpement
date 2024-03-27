<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestAutomate
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
    Me.tbReception = New System.Windows.Forms.TabControl()
    Me.tpEmission = New System.Windows.Forms.TabPage()
    Me.stxtMessage = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtInfo = New System.Windows.Forms.TextBox()
    Me.cmdSend = New System.Windows.Forms.Button()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.lTick = New System.Windows.Forms.Label()
    Me.bClear = New System.Windows.Forms.Button()
    Me.bStop = New System.Windows.Forms.Button()
    Me.bStart = New System.Windows.Forms.Button()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.chkBit = New System.Windows.Forms.CheckBox()
    Me.bQuitter = New System.Windows.Forms.Button()
    Me.sPortAutomate = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.sWatchDog = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cbWatchDog = New System.Windows.Forms.CheckBox()
    Me.tWatchDog = New System.Windows.Forms.Timer(Me.components)
    Me.sTick = New System.Windows.Forms.Label()
    Me.sIpAutomate = New System.Windows.Forms.TextBox()
    Me.bPing = New System.Windows.Forms.Button()
    Me.tbReception.SuspendLayout()
    Me.tpEmission.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.SuspendLayout()
    '
    'tbReception
    '
    Me.tbReception.Controls.Add(Me.tpEmission)
    Me.tbReception.Controls.Add(Me.TabPage2)
    Me.tbReception.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tbReception.Location = New System.Drawing.Point(9, 40)
    Me.tbReception.Margin = New System.Windows.Forms.Padding(2)
    Me.tbReception.Name = "tbReception"
    Me.tbReception.SelectedIndex = 0
    Me.tbReception.Size = New System.Drawing.Size(852, 414)
    Me.tbReception.TabIndex = 0
    '
    'tpEmission
    '
    Me.tpEmission.BackColor = System.Drawing.Color.LightSteelBlue
    Me.tpEmission.Controls.Add(Me.stxtMessage)
    Me.tpEmission.Controls.Add(Me.Label1)
    Me.tpEmission.Controls.Add(Me.txtInfo)
    Me.tpEmission.Controls.Add(Me.cmdSend)
    Me.tpEmission.Location = New System.Drawing.Point(4, 29)
    Me.tpEmission.Margin = New System.Windows.Forms.Padding(2)
    Me.tpEmission.Name = "tpEmission"
    Me.tpEmission.Padding = New System.Windows.Forms.Padding(2)
    Me.tpEmission.Size = New System.Drawing.Size(844, 381)
    Me.tpEmission.TabIndex = 0
    Me.tpEmission.Text = "Emission"
    '
    'stxtMessage
    '
    Me.stxtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.stxtMessage.Location = New System.Drawing.Point(106, 16)
    Me.stxtMessage.Margin = New System.Windows.Forms.Padding(2)
    Me.stxtMessage.MaxLength = 10
    Me.stxtMessage.Name = "stxtMessage"
    Me.stxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.stxtMessage.Size = New System.Drawing.Size(469, 26)
    Me.stxtMessage.TabIndex = 11
    Me.stxtMessage.Text = "01:11"
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(19, 19)
    Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(86, 21)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Emission :"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtInfo
    '
    Me.txtInfo.Location = New System.Drawing.Point(23, 50)
    Me.txtInfo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtInfo.Multiline = True
    Me.txtInfo.Name = "txtInfo"
    Me.txtInfo.ReadOnly = True
    Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtInfo.Size = New System.Drawing.Size(553, 253)
    Me.txtInfo.TabIndex = 9
    Me.txtInfo.Text = "INFORMATION"
    '
    'cmdSend
    '
    Me.cmdSend.BackColor = System.Drawing.Color.Transparent
    Me.cmdSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdSend.Location = New System.Drawing.Point(594, 16)
    Me.cmdSend.Margin = New System.Windows.Forms.Padding(2)
    Me.cmdSend.Name = "cmdSend"
    Me.cmdSend.Size = New System.Drawing.Size(94, 29)
    Me.cmdSend.TabIndex = 8
    Me.cmdSend.Text = "Envoi"
    Me.cmdSend.UseVisualStyleBackColor = False
    '
    'TabPage2
    '
    Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage2.Controls.Add(Me.lTick)
    Me.TabPage2.Controls.Add(Me.bClear)
    Me.TabPage2.Controls.Add(Me.bStop)
    Me.TabPage2.Controls.Add(Me.bStart)
    Me.TabPage2.Controls.Add(Me.TextBox1)
    Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPage2.Location = New System.Drawing.Point(4, 29)
    Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
    Me.TabPage2.Size = New System.Drawing.Size(844, 381)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Réception"
    '
    'lTick
    '
    Me.lTick.BackColor = System.Drawing.Color.Silver
    Me.lTick.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lTick.Location = New System.Drawing.Point(16, 306)
    Me.lTick.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.lTick.Name = "lTick"
    Me.lTick.Size = New System.Drawing.Size(528, 58)
    Me.lTick.TabIndex = 15
    Me.lTick.Text = "199"
    Me.lTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'bClear
    '
    Me.bClear.BackColor = System.Drawing.Color.Transparent
    Me.bClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bClear.Location = New System.Drawing.Point(586, 132)
    Me.bClear.Margin = New System.Windows.Forms.Padding(2)
    Me.bClear.Name = "bClear"
    Me.bClear.Size = New System.Drawing.Size(100, 30)
    Me.bClear.TabIndex = 14
    Me.bClear.Text = "Clear All"
    Me.bClear.UseVisualStyleBackColor = False
    '
    'bStop
    '
    Me.bStop.BackColor = System.Drawing.Color.Transparent
    Me.bStop.Enabled = False
    Me.bStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bStop.Location = New System.Drawing.Point(586, 92)
    Me.bStop.Margin = New System.Windows.Forms.Padding(2)
    Me.bStop.Name = "bStop"
    Me.bStop.Size = New System.Drawing.Size(100, 26)
    Me.bStop.TabIndex = 12
    Me.bStop.Text = "Stop"
    Me.bStop.UseVisualStyleBackColor = False
    '
    'bStart
    '
    Me.bStart.BackColor = System.Drawing.Color.Transparent
    Me.bStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bStart.Location = New System.Drawing.Point(586, 53)
    Me.bStart.Margin = New System.Windows.Forms.Padding(2)
    Me.bStart.Name = "bStart"
    Me.bStart.Size = New System.Drawing.Size(100, 26)
    Me.bStart.TabIndex = 11
    Me.bStart.Text = "Start"
    Me.bStart.UseVisualStyleBackColor = False
    '
    'TextBox1
    '
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBox1.Enabled = False
    Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.Location = New System.Drawing.Point(16, 20)
    Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ReadOnly = True
    Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.TextBox1.Size = New System.Drawing.Size(528, 284)
    Me.TextBox1.TabIndex = 1
    Me.TextBox1.Text = "INFORMATION"
    '
    'chkBit
    '
    Me.chkBit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkBit.Location = New System.Drawing.Point(746, 8)
    Me.chkBit.Margin = New System.Windows.Forms.Padding(2)
    Me.chkBit.Name = "chkBit"
    Me.chkBit.Size = New System.Drawing.Size(99, 23)
    Me.chkBit.TabIndex = 13
    Me.chkBit.Text = "Bit Décode"
    '
    'bQuitter
    '
    Me.bQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bQuitter.Location = New System.Drawing.Point(742, 488)
    Me.bQuitter.Margin = New System.Windows.Forms.Padding(2)
    Me.bQuitter.Name = "bQuitter"
    Me.bQuitter.Size = New System.Drawing.Size(119, 33)
    Me.bQuitter.TabIndex = 3
    Me.bQuitter.Text = "Quitter"
    Me.bQuitter.UseVisualStyleBackColor = True
    '
    'sPortAutomate
    '
    Me.sPortAutomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sPortAutomate.Location = New System.Drawing.Point(670, 8)
    Me.sPortAutomate.Margin = New System.Windows.Forms.Padding(2)
    Me.sPortAutomate.Name = "sPortAutomate"
    Me.sPortAutomate.Size = New System.Drawing.Size(64, 26)
    Me.sPortAutomate.TabIndex = 15
    Me.sPortAutomate.Text = "11000"
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(615, 10)
    Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(48, 20)
    Me.Label3.TabIndex = 14
    Me.Label3.Text = "Port :"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(309, 8)
    Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(125, 20)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "IP Automate :"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'sWatchDog
    '
    Me.sWatchDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sWatchDog.Location = New System.Drawing.Point(130, 8)
    Me.sWatchDog.Margin = New System.Windows.Forms.Padding(2)
    Me.sWatchDog.Name = "sWatchDog"
    Me.sWatchDog.Size = New System.Drawing.Size(39, 26)
    Me.sWatchDog.TabIndex = 17
    Me.sWatchDog.Text = "250"
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(191, 8)
    Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(34, 24)
    Me.Label5.TabIndex = 18
    Me.Label5.Text = "ms"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cbWatchDog
    '
    Me.cbWatchDog.AutoSize = True
    Me.cbWatchDog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbWatchDog.Location = New System.Drawing.Point(12, 8)
    Me.cbWatchDog.Margin = New System.Windows.Forms.Padding(2)
    Me.cbWatchDog.Name = "cbWatchDog"
    Me.cbWatchDog.Size = New System.Drawing.Size(112, 24)
    Me.cbWatchDog.TabIndex = 12
    Me.cbWatchDog.Text = "WatchDog"
    Me.cbWatchDog.UseVisualStyleBackColor = True
    '
    'tWatchDog
    '
    '
    'sTick
    '
    Me.sTick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sTick.Location = New System.Drawing.Point(173, 8)
    Me.sTick.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
    Me.sTick.Name = "sTick"
    Me.sTick.Size = New System.Drawing.Size(14, 24)
    Me.sTick.TabIndex = 19
    Me.sTick.Text = "/"
    Me.sTick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'sIpAutomate
    '
    Me.sIpAutomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sIpAutomate.Location = New System.Drawing.Point(447, 8)
    Me.sIpAutomate.Margin = New System.Windows.Forms.Padding(2)
    Me.sIpAutomate.Name = "sIpAutomate"
    Me.sIpAutomate.Size = New System.Drawing.Size(153, 26)
    Me.sIpAutomate.TabIndex = 20
    '
    'bPing
    '
    Me.bPing.BackColor = System.Drawing.Color.Transparent
    Me.bPing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bPing.Location = New System.Drawing.Point(807, 7)
    Me.bPing.Margin = New System.Windows.Forms.Padding(2)
    Me.bPing.Name = "bPing"
    Me.bPing.Size = New System.Drawing.Size(94, 29)
    Me.bPing.TabIndex = 21
    Me.bPing.Text = "Ping"
    Me.bPing.UseVisualStyleBackColor = False
    '
    'frmTestAutomate
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ClientSize = New System.Drawing.Size(912, 532)
    Me.ControlBox = False
    Me.Controls.Add(Me.bPing)
    Me.Controls.Add(Me.sIpAutomate)
    Me.Controls.Add(Me.sTick)
    Me.Controls.Add(Me.cbWatchDog)
    Me.Controls.Add(Me.chkBit)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.sWatchDog)
    Me.Controls.Add(Me.sPortAutomate)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.bQuitter)
    Me.Controls.Add(Me.tbReception)
    Me.Controls.Add(Me.Label2)
    Me.Margin = New System.Windows.Forms.Padding(2)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmTestAutomate"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Test automate"
    Me.tbReception.ResumeLayout(False)
    Me.tpEmission.ResumeLayout(False)
    Me.tpEmission.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents tbReception As TabControl
  Friend WithEvents tpEmission As TabPage
  Friend WithEvents TabPage2 As TabPage
  Friend WithEvents bQuitter As Button
  Friend WithEvents sPortAutomate As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents stxtMessage As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents txtInfo As TextBox
  Friend WithEvents cmdSend As Button
  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents bStop As Button
  Friend WithEvents bStart As Button
  Friend WithEvents chkBit As CheckBox
  Friend WithEvents bClear As Button
  Friend WithEvents sWatchDog As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents cbWatchDog As CheckBox
  Friend WithEvents tWatchDog As Timer
  Friend WithEvents sTick As Label
  Friend WithEvents lTick As Label
  Friend WithEvents sIpAutomate As TextBox
  Friend WithEvents bPing As Button
End Class
