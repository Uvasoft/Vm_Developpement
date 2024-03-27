<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
  Inherits System.Windows.Forms.Form

  'Form remplace la méthode Dispose pour nettoyer la liste des composants.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.lScrutation = New System.Windows.Forms.Label()
    Me.FichiersErp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.bSimErp = New System.Windows.Forms.Button()
    Me.ListViewErp = New System.Windows.Forms.ListView()
    Me.bSaisieQte = New System.Windows.Forms.Button()
    Me.bPrevisu = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.Erp = New System.Windows.Forms.TabPage()
    Me.sLectureOf = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cbAvecApercu = New System.Windows.Forms.CheckBox()
    Me.bClearErp = New System.Windows.Forms.Button()
    Me.Apercu = New System.Windows.Forms.TabPage()
    Me.pbPreview = New System.Windows.Forms.PictureBox()
    Me.cbFrontSide = New System.Windows.Forms.CheckBox()
    Me.cbBackSide = New System.Windows.Forms.CheckBox()
    Me.cbPreviewToFile = New System.Windows.Forms.CheckBox()
    Me.Journal = New System.Windows.Forms.TabPage()
    Me.bVoirJournal = New System.Windows.Forms.Button()
    Me.bClearLog = New System.Windows.Forms.Button()
    Me.LOGText = New System.Windows.Forms.RichTextBox()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.rbMDT = New System.Windows.Forms.RadioButton()
    Me.rbMDP = New System.Windows.Forms.RadioButton()
    Me.bJournal = New System.Windows.Forms.Button()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.lTimer = New System.Windows.Forms.Label()
    Me.cbModeAuto = New System.Windows.Forms.CheckBox()
    Me.lDebugNL = New System.Windows.Forms.Label()
    Me.lMessage = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.bImp = New System.Windows.Forms.Button()
    Me.bConfig = New System.Windows.Forms.Button()
    Me.bQuitter = New System.Windows.Forms.Button()
    Me.lUvasoft = New System.Windows.Forms.Label()
    Me.lNiceLabel = New System.Windows.Forms.Label()
    Me.lQte = New System.Windows.Forms.Label()
    Me.bPrevisuTest = New System.Windows.Forms.Button()
    Me.bTestAutomate = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.lMsgEmiCEL = New System.Windows.Forms.Label()
    Me.lMsgRecCEL = New System.Windows.Forms.Label()
    Me.CelBan = New System.Windows.Forms.TabPage()
    Me.ListViewErp_Ec = New System.Windows.Forms.ListView()
    Me.Pose = New System.Windows.Forms.TabPage()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.FichiersErp_Ec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.TabControl1.SuspendLayout()
    Me.Erp.SuspendLayout()
    Me.Apercu.SuspendLayout()
    CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Journal.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.Pose.SuspendLayout()
    Me.SuspendLayout()
    '
    'lScrutation
    '
    Me.lScrutation.AutoSize = True
    Me.lScrutation.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lScrutation.ForeColor = System.Drawing.Color.Black
    Me.lScrutation.Location = New System.Drawing.Point(19, 12)
    Me.lScrutation.Name = "lScrutation"
    Me.lScrutation.Size = New System.Drawing.Size(147, 23)
    Me.lScrutation.TabIndex = 1
    Me.lScrutation.Text = "Scrutation ERP :"
    '
    'FichiersErp
    '
    Me.FichiersErp.Text = "Fichiers"
    Me.FichiersErp.Width = 395
    '
    'bSimErp
    '
    Me.bSimErp.BackColor = System.Drawing.Color.SteelBlue
    Me.bSimErp.FlatAppearance.BorderSize = 2
    Me.bSimErp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bSimErp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bSimErp.ForeColor = System.Drawing.Color.White
    Me.bSimErp.Location = New System.Drawing.Point(231, 439)
    Me.bSimErp.Name = "bSimErp"
    Me.bSimErp.Size = New System.Drawing.Size(126, 36)
    Me.bSimErp.TabIndex = 38
    Me.bSimErp.Text = "Sim. Erp"
    Me.bSimErp.UseVisualStyleBackColor = False
    '
    'ListViewErp
    '
    Me.ListViewErp.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ListViewErp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListViewErp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FichiersErp})
    Me.ListViewErp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListViewErp.ForeColor = System.Drawing.Color.Black
    Me.ListViewErp.HideSelection = False
    Me.ListViewErp.Location = New System.Drawing.Point(6, 49)
    Me.ListViewErp.Name = "ListViewErp"
    Me.ListViewErp.Size = New System.Drawing.Size(626, 360)
    Me.ListViewErp.TabIndex = 0
    Me.ListViewErp.UseCompatibleStateImageBehavior = False
    Me.ListViewErp.View = System.Windows.Forms.View.Details
    '
    'bSaisieQte
    '
    Me.bSaisieQte.BackColor = System.Drawing.Color.SteelBlue
    Me.bSaisieQte.FlatAppearance.BorderSize = 2
    Me.bSaisieQte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bSaisieQte.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bSaisieQte.ForeColor = System.Drawing.Color.White
    Me.bSaisieQte.Location = New System.Drawing.Point(1063, 343)
    Me.bSaisieQte.Name = "bSaisieQte"
    Me.bSaisieQte.Size = New System.Drawing.Size(124, 48)
    Me.bSaisieQte.TabIndex = 93
    Me.bSaisieQte.Text = "Saisie Qté"
    Me.bSaisieQte.UseVisualStyleBackColor = False
    Me.bSaisieQte.Visible = False
    '
    'bPrevisu
    '
    Me.bPrevisu.BackColor = System.Drawing.Color.SteelBlue
    Me.bPrevisu.FlatAppearance.BorderSize = 2
    Me.bPrevisu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bPrevisu.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bPrevisu.ForeColor = System.Drawing.Color.White
    Me.bPrevisu.Location = New System.Drawing.Point(908, 343)
    Me.bPrevisu.Name = "bPrevisu"
    Me.bPrevisu.Size = New System.Drawing.Size(126, 48)
    Me.bPrevisu.TabIndex = 87
    Me.bPrevisu.Text = "Apercu"
    Me.bPrevisu.UseVisualStyleBackColor = False
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(15, 42)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(155, 23)
    Me.Label3.TabIndex = 86
    Me.Label3.Text = "Article En Cours :"
    Me.Label3.Visible = False
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.Erp)
    Me.TabControl1.Controls.Add(Me.CelBan)
    Me.TabControl1.Controls.Add(Me.Pose)
    Me.TabControl1.Controls.Add(Me.Apercu)
    Me.TabControl1.Controls.Add(Me.Journal)
    Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabControl1.Location = New System.Drawing.Point(19, 88)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(866, 514)
    Me.TabControl1.TabIndex = 81
    '
    'Erp
    '
    Me.Erp.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Erp.Controls.Add(Me.sLectureOf)
    Me.Erp.Controls.Add(Me.Label9)
    Me.Erp.Controls.Add(Me.cbAvecApercu)
    Me.Erp.Controls.Add(Me.bClearErp)
    Me.Erp.Controls.Add(Me.lScrutation)
    Me.Erp.Controls.Add(Me.ListViewErp)
    Me.Erp.Controls.Add(Me.bSimErp)
    Me.Erp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Erp.Location = New System.Drawing.Point(4, 32)
    Me.Erp.Name = "Erp"
    Me.Erp.Padding = New System.Windows.Forms.Padding(3)
    Me.Erp.Size = New System.Drawing.Size(858, 478)
    Me.Erp.TabIndex = 0
    Me.Erp.Text = "Erp "
    '
    'sLectureOf
    '
    Me.sLectureOf.BackColor = System.Drawing.Color.SteelBlue
    Me.sLectureOf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sLectureOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sLectureOf.ForeColor = System.Drawing.Color.White
    Me.sLectureOf.Location = New System.Drawing.Point(658, 93)
    Me.sLectureOf.Name = "sLectureOf"
    Me.sLectureOf.Size = New System.Drawing.Size(183, 26)
    Me.sLectureOf.TabIndex = 179
    Me.sLectureOf.Text = "123456789"
    Me.sLectureOf.Visible = False
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.ForeColor = System.Drawing.Color.Black
    Me.Label9.Location = New System.Drawing.Point(654, 67)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(120, 23)
    Me.Label9.TabIndex = 39
    Me.Label9.Text = "Lecture OF : "
    Me.Label9.Visible = False
    '
    'cbAvecApercu
    '
    Me.cbAvecApercu.BackColor = System.Drawing.Color.SteelBlue
    Me.cbAvecApercu.FlatAppearance.BorderSize = 2
    Me.cbAvecApercu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cbAvecApercu.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbAvecApercu.ForeColor = System.Drawing.Color.White
    Me.cbAvecApercu.Location = New System.Drawing.Point(15, 439)
    Me.cbAvecApercu.Name = "cbAvecApercu"
    Me.cbAvecApercu.Padding = New System.Windows.Forms.Padding(5)
    Me.cbAvecApercu.Size = New System.Drawing.Size(195, 34)
    Me.cbAvecApercu.TabIndex = 36
    Me.cbAvecApercu.Text = "Avec Apercu"
    Me.cbAvecApercu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.cbAvecApercu.UseVisualStyleBackColor = False
    '
    'bClearErp
    '
    Me.bClearErp.BackColor = System.Drawing.Color.SteelBlue
    Me.bClearErp.FlatAppearance.BorderSize = 2
    Me.bClearErp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bClearErp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bClearErp.ForeColor = System.Drawing.Color.White
    Me.bClearErp.Location = New System.Drawing.Point(675, 437)
    Me.bClearErp.Name = "bClearErp"
    Me.bClearErp.Size = New System.Drawing.Size(111, 38)
    Me.bClearErp.TabIndex = 35
    Me.bClearErp.Text = "Clear Erp"
    Me.bClearErp.UseVisualStyleBackColor = False
    '
    'Apercu
    '
    Me.Apercu.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Apercu.Controls.Add(Me.pbPreview)
    Me.Apercu.Controls.Add(Me.cbFrontSide)
    Me.Apercu.Controls.Add(Me.cbBackSide)
    Me.Apercu.Controls.Add(Me.cbPreviewToFile)
    Me.Apercu.Location = New System.Drawing.Point(4, 32)
    Me.Apercu.Name = "Apercu"
    Me.Apercu.Size = New System.Drawing.Size(858, 478)
    Me.Apercu.TabIndex = 3
    Me.Apercu.Text = "Apercu  "
    '
    'pbPreview
    '
    Me.pbPreview.BackColor = System.Drawing.Color.LightSteelBlue
    Me.pbPreview.Location = New System.Drawing.Point(3, 3)
    Me.pbPreview.Name = "pbPreview"
    Me.pbPreview.Size = New System.Drawing.Size(805, 406)
    Me.pbPreview.TabIndex = 14
    Me.pbPreview.TabStop = False
    '
    'cbFrontSide
    '
    Me.cbFrontSide.AutoSize = True
    Me.cbFrontSide.Checked = True
    Me.cbFrontSide.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbFrontSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbFrontSide.Location = New System.Drawing.Point(642, 164)
    Me.cbFrontSide.Name = "cbFrontSide"
    Me.cbFrontSide.Size = New System.Drawing.Size(71, 24)
    Me.cbFrontSide.TabIndex = 16
    Me.cbFrontSide.Text = "Recto"
    Me.cbFrontSide.UseVisualStyleBackColor = True
    Me.cbFrontSide.Visible = False
    '
    'cbBackSide
    '
    Me.cbBackSide.AutoSize = True
    Me.cbBackSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbBackSide.Location = New System.Drawing.Point(643, 134)
    Me.cbBackSide.Name = "cbBackSide"
    Me.cbBackSide.Size = New System.Drawing.Size(70, 24)
    Me.cbBackSide.TabIndex = 17
    Me.cbBackSide.Text = "Verso"
    Me.cbBackSide.UseVisualStyleBackColor = True
    Me.cbBackSide.Visible = False
    '
    'cbPreviewToFile
    '
    Me.cbPreviewToFile.AutoSize = True
    Me.cbPreviewToFile.Checked = True
    Me.cbPreviewToFile.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbPreviewToFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbPreviewToFile.Location = New System.Drawing.Point(645, 415)
    Me.cbPreviewToFile.Name = "cbPreviewToFile"
    Me.cbPreviewToFile.Size = New System.Drawing.Size(163, 24)
    Me.cbPreviewToFile.TabIndex = 13
    Me.cbPreviewToFile.Text = "Previsu vers Fichier"
    Me.cbPreviewToFile.UseVisualStyleBackColor = True
    Me.cbPreviewToFile.Visible = False
    '
    'Journal
    '
    Me.Journal.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Journal.Controls.Add(Me.bVoirJournal)
    Me.Journal.Controls.Add(Me.bClearLog)
    Me.Journal.Controls.Add(Me.LOGText)
    Me.Journal.Location = New System.Drawing.Point(4, 32)
    Me.Journal.Name = "Journal"
    Me.Journal.Size = New System.Drawing.Size(858, 478)
    Me.Journal.TabIndex = 4
    Me.Journal.Text = "Journal"
    '
    'bVoirJournal
    '
    Me.bVoirJournal.BackColor = System.Drawing.Color.SteelBlue
    Me.bVoirJournal.FlatAppearance.BorderSize = 2
    Me.bVoirJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bVoirJournal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bVoirJournal.ForeColor = System.Drawing.Color.White
    Me.bVoirJournal.Location = New System.Drawing.Point(428, 428)
    Me.bVoirJournal.Name = "bVoirJournal"
    Me.bVoirJournal.Size = New System.Drawing.Size(146, 35)
    Me.bVoirJournal.TabIndex = 37
    Me.bVoirJournal.Text = "Voir Journal"
    Me.bVoirJournal.UseVisualStyleBackColor = False
    '
    'bClearLog
    '
    Me.bClearLog.BackColor = System.Drawing.Color.SteelBlue
    Me.bClearLog.FlatAppearance.BorderSize = 2
    Me.bClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bClearLog.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bClearLog.ForeColor = System.Drawing.Color.White
    Me.bClearLog.Location = New System.Drawing.Point(645, 428)
    Me.bClearLog.Name = "bClearLog"
    Me.bClearLog.Size = New System.Drawing.Size(146, 35)
    Me.bClearLog.TabIndex = 36
    Me.bClearLog.Text = "Efface Journal"
    Me.bClearLog.UseVisualStyleBackColor = False
    '
    'LOGText
    '
    Me.LOGText.BackColor = System.Drawing.Color.LightSteelBlue
    Me.LOGText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.LOGText.DetectUrls = False
    Me.LOGText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LOGText.ForeColor = System.Drawing.Color.Black
    Me.LOGText.Location = New System.Drawing.Point(22, 13)
    Me.LOGText.Name = "LOGText"
    Me.LOGText.ReadOnly = True
    Me.LOGText.Size = New System.Drawing.Size(771, 396)
    Me.LOGText.TabIndex = 8
    Me.LOGText.Text = ""
    Me.LOGText.WordWrap = False
    '
    'Timer1
    '
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.rbMDT)
    Me.GroupBox1.Controls.Add(Me.rbMDP)
    Me.GroupBox1.Location = New System.Drawing.Point(908, 64)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(256, 123)
    Me.GroupBox1.TabIndex = 89
    Me.GroupBox1.TabStop = False
    '
    'rbMDT
    '
    Me.rbMDT.AutoSize = True
    Me.rbMDT.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbMDT.Location = New System.Drawing.Point(21, 67)
    Me.rbMDT.Name = "rbMDT"
    Me.rbMDT.Padding = New System.Windows.Forms.Padding(5)
    Me.rbMDT.Size = New System.Drawing.Size(215, 37)
    Me.rbMDT.TabIndex = 1
    Me.rbMDT.TabStop = True
    Me.rbMDT.Text = "Imprimante de Table"
    Me.rbMDT.UseVisualStyleBackColor = True
    '
    'rbMDP
    '
    Me.rbMDP.AutoSize = True
    Me.rbMDP.BackColor = System.Drawing.Color.LightSteelBlue
    Me.rbMDP.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbMDP.ForeColor = System.Drawing.Color.Black
    Me.rbMDP.Location = New System.Drawing.Point(21, 18)
    Me.rbMDP.Name = "rbMDP"
    Me.rbMDP.Padding = New System.Windows.Forms.Padding(5)
    Me.rbMDP.Size = New System.Drawing.Size(213, 37)
    Me.rbMDP.TabIndex = 0
    Me.rbMDP.TabStop = True
    Me.rbMDP.Text = "Imprimante de  Pose"
    Me.rbMDP.UseVisualStyleBackColor = False
    '
    'bJournal
    '
    Me.bJournal.BackColor = System.Drawing.Color.SteelBlue
    Me.bJournal.FlatAppearance.BorderSize = 2
    Me.bJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bJournal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bJournal.ForeColor = System.Drawing.Color.White
    Me.bJournal.Location = New System.Drawing.Point(908, 481)
    Me.bJournal.Name = "bJournal"
    Me.bJournal.Size = New System.Drawing.Size(126, 48)
    Me.bJournal.TabIndex = 82
    Me.bJournal.Text = "Journal"
    Me.bJournal.UseVisualStyleBackColor = False
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.lTimer)
    Me.GroupBox2.Controls.Add(Me.cbModeAuto)
    Me.GroupBox2.Location = New System.Drawing.Point(908, 193)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(256, 66)
    Me.GroupBox2.TabIndex = 90
    Me.GroupBox2.TabStop = False
    '
    'lTimer
    '
    Me.lTimer.AutoSize = True
    Me.lTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.lTimer.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lTimer.Location = New System.Drawing.Point(161, 20)
    Me.lTimer.Name = "lTimer"
    Me.lTimer.Size = New System.Drawing.Size(23, 23)
    Me.lTimer.TabIndex = 96
    Me.lTimer.Text = "\ "
    '
    'cbModeAuto
    '
    Me.cbModeAuto.AutoSize = True
    Me.cbModeAuto.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbModeAuto.Location = New System.Drawing.Point(21, 19)
    Me.cbModeAuto.Name = "cbModeAuto"
    Me.cbModeAuto.Size = New System.Drawing.Size(119, 27)
    Me.cbModeAuto.TabIndex = 94
    Me.cbModeAuto.Text = "Mode Auto"
    Me.cbModeAuto.UseVisualStyleBackColor = True
    '
    'lDebugNL
    '
    Me.lDebugNL.BackColor = System.Drawing.Color.Red
    Me.lDebugNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.lDebugNL.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lDebugNL.ForeColor = System.Drawing.Color.White
    Me.lDebugNL.Location = New System.Drawing.Point(644, 24)
    Me.lDebugNL.Name = "lDebugNL"
    Me.lDebugNL.Size = New System.Drawing.Size(165, 37)
    Me.lDebugNL.TabIndex = 91
    Me.lDebugNL.Text = "Debug NL activé"
    Me.lDebugNL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lMessage
    '
    Me.lMessage.BackColor = System.Drawing.Color.SteelBlue
    Me.lMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.lMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lMessage.ForeColor = System.Drawing.Color.White
    Me.lMessage.Location = New System.Drawing.Point(120, 612)
    Me.lMessage.Name = "lMessage"
    Me.lMessage.Size = New System.Drawing.Size(761, 37)
    Me.lMessage.TabIndex = 85
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(19, 612)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(95, 23)
    Me.Label2.TabIndex = 84
    Me.Label2.Text = "Message :"
    '
    'bImp
    '
    Me.bImp.BackColor = System.Drawing.Color.SteelBlue
    Me.bImp.FlatAppearance.BorderSize = 2
    Me.bImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bImp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bImp.ForeColor = System.Drawing.Color.White
    Me.bImp.Location = New System.Drawing.Point(1063, 481)
    Me.bImp.Name = "bImp"
    Me.bImp.Size = New System.Drawing.Size(126, 48)
    Me.bImp.TabIndex = 76
    Me.bImp.Text = "Impression"
    Me.bImp.UseVisualStyleBackColor = False
    '
    'bConfig
    '
    Me.bConfig.BackColor = System.Drawing.Color.SteelBlue
    Me.bConfig.FlatAppearance.BorderSize = 2
    Me.bConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bConfig.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bConfig.ForeColor = System.Drawing.Color.White
    Me.bConfig.Location = New System.Drawing.Point(908, 550)
    Me.bConfig.Margin = New System.Windows.Forms.Padding(4)
    Me.bConfig.Name = "bConfig"
    Me.bConfig.Size = New System.Drawing.Size(126, 48)
    Me.bConfig.TabIndex = 78
    Me.bConfig.Text = "&Config"
    Me.bConfig.UseVisualStyleBackColor = False
    '
    'bQuitter
    '
    Me.bQuitter.BackColor = System.Drawing.Color.SteelBlue
    Me.bQuitter.FlatAppearance.BorderSize = 2
    Me.bQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bQuitter.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bQuitter.ForeColor = System.Drawing.Color.White
    Me.bQuitter.Location = New System.Drawing.Point(1063, 608)
    Me.bQuitter.Margin = New System.Windows.Forms.Padding(4)
    Me.bQuitter.Name = "bQuitter"
    Me.bQuitter.Size = New System.Drawing.Size(124, 48)
    Me.bQuitter.TabIndex = 77
    Me.bQuitter.Text = "&Quitter"
    Me.bQuitter.UseVisualStyleBackColor = False
    '
    'lUvasoft
    '
    Me.lUvasoft.BackColor = System.Drawing.Color.SteelBlue
    Me.lUvasoft.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lUvasoft.ForeColor = System.Drawing.Color.White
    Me.lUvasoft.Location = New System.Drawing.Point(1031, 24)
    Me.lUvasoft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lUvasoft.Name = "lUvasoft"
    Me.lUvasoft.Size = New System.Drawing.Size(154, 37)
    Me.lUvasoft.TabIndex = 80
    Me.lUvasoft.Text = "Uvasoft"
    Me.lUvasoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lNiceLabel
    '
    Me.lNiceLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lNiceLabel.Location = New System.Drawing.Point(828, 24)
    Me.lNiceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lNiceLabel.Name = "lNiceLabel"
    Me.lNiceLabel.Size = New System.Drawing.Size(188, 37)
    Me.lNiceLabel.TabIndex = 79
    Me.lNiceLabel.Text = "NiceLabel"
    Me.lNiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lQte
    '
    Me.lQte.AutoSize = True
    Me.lQte.BackColor = System.Drawing.Color.RoyalBlue
    Me.lQte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.lQte.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lQte.ForeColor = System.Drawing.Color.White
    Me.lQte.Location = New System.Drawing.Point(1111, 419)
    Me.lQte.Name = "lQte"
    Me.lQte.Size = New System.Drawing.Size(26, 29)
    Me.lQte.TabIndex = 92
    Me.lQte.Text = "1"
    Me.lQte.Visible = False
    '
    'bPrevisuTest
    '
    Me.bPrevisuTest.BackColor = System.Drawing.Color.SteelBlue
    Me.bPrevisuTest.FlatAppearance.BorderSize = 2
    Me.bPrevisuTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bPrevisuTest.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bPrevisuTest.ForeColor = System.Drawing.Color.White
    Me.bPrevisuTest.Location = New System.Drawing.Point(908, 412)
    Me.bPrevisuTest.Name = "bPrevisuTest"
    Me.bPrevisuTest.Size = New System.Drawing.Size(126, 48)
    Me.bPrevisuTest.TabIndex = 88
    Me.bPrevisuTest.Text = "Apercu Test"
    Me.bPrevisuTest.UseVisualStyleBackColor = False
    '
    'bTestAutomate
    '
    Me.bTestAutomate.BackColor = System.Drawing.Color.SteelBlue
    Me.bTestAutomate.FlatAppearance.BorderSize = 2
    Me.bTestAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bTestAutomate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bTestAutomate.ForeColor = System.Drawing.Color.White
    Me.bTestAutomate.Location = New System.Drawing.Point(908, 278)
    Me.bTestAutomate.Name = "bTestAutomate"
    Me.bTestAutomate.Size = New System.Drawing.Size(229, 48)
    Me.bTestAutomate.TabIndex = 94
    Me.bTestAutomate.Text = "Test Automate"
    Me.bTestAutomate.UseVisualStyleBackColor = False
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(19, 659)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(106, 23)
    Me.Label7.TabIndex = 95
    Me.Label7.Text = "Pc -> CEL :"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(19, 697)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(106, 23)
    Me.Label8.TabIndex = 96
    Me.Label8.Text = "Pc <- CEL :"
    '
    'lMsgEmiCEL
    '
    Me.lMsgEmiCEL.BackColor = System.Drawing.Color.SteelBlue
    Me.lMsgEmiCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.lMsgEmiCEL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lMsgEmiCEL.ForeColor = System.Drawing.Color.White
    Me.lMsgEmiCEL.Location = New System.Drawing.Point(185, 655)
    Me.lMsgEmiCEL.Name = "lMsgEmiCEL"
    Me.lMsgEmiCEL.Size = New System.Drawing.Size(696, 37)
    Me.lMsgEmiCEL.TabIndex = 97
    '
    'lMsgRecCEL
    '
    Me.lMsgRecCEL.BackColor = System.Drawing.Color.SteelBlue
    Me.lMsgRecCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.lMsgRecCEL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lMsgRecCEL.ForeColor = System.Drawing.Color.White
    Me.lMsgRecCEL.Location = New System.Drawing.Point(185, 697)
    Me.lMsgRecCEL.Name = "lMsgRecCEL"
    Me.lMsgRecCEL.Size = New System.Drawing.Size(696, 37)
    Me.lMsgRecCEL.TabIndex = 98
    '
    'CelBan
    '
    Me.CelBan.BackColor = System.Drawing.Color.LightSteelBlue
    Me.CelBan.Location = New System.Drawing.Point(4, 32)
    Me.CelBan.Name = "CelBan"
    Me.CelBan.Padding = New System.Windows.Forms.Padding(3)
    Me.CelBan.Size = New System.Drawing.Size(858, 478)
    Me.CelBan.TabIndex = 5
    Me.CelBan.Text = "Cel-Ban"
    '
    'ListViewErp_Ec
    '
    Me.ListViewErp_Ec.Activation = System.Windows.Forms.ItemActivation.OneClick
    Me.ListViewErp_Ec.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ListViewErp_Ec.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FichiersErp_Ec})
    Me.ListViewErp_Ec.ForeColor = System.Drawing.SystemColors.WindowText
    Me.ListViewErp_Ec.HideSelection = False
    Me.ListViewErp_Ec.Location = New System.Drawing.Point(18, 58)
    Me.ListViewErp_Ec.Name = "ListViewErp_Ec"
    Me.ListViewErp_Ec.Size = New System.Drawing.Size(823, 360)
    Me.ListViewErp_Ec.TabIndex = 0
    Me.ListViewErp_Ec.UseCompatibleStateImageBehavior = False
    Me.ListViewErp_Ec.View = System.Windows.Forms.View.Details
    '
    'Pose
    '
    Me.Pose.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Pose.Controls.Add(Me.Label1)
    Me.Pose.Controls.Add(Me.ListViewErp_Ec)
    Me.Pose.Location = New System.Drawing.Point(4, 32)
    Me.Pose.Name = "Pose"
    Me.Pose.Size = New System.Drawing.Size(858, 478)
    Me.Pose.TabIndex = 2
    Me.Pose.Text = "Pose"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.Location = New System.Drawing.Point(20, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(130, 23)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Erp en cours :"
    '
    'FichiersErp_Ec
    '
    Me.FichiersErp_Ec.Text = "Fichiers"
    Me.FichiersErp_Ec.Width = 485
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ClientSize = New System.Drawing.Size(1209, 740)
    Me.Controls.Add(Me.lMsgRecCEL)
    Me.Controls.Add(Me.lMsgEmiCEL)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.bTestAutomate)
    Me.Controls.Add(Me.bSaisieQte)
    Me.Controls.Add(Me.bPrevisu)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.bJournal)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.lDebugNL)
    Me.Controls.Add(Me.lMessage)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.bImp)
    Me.Controls.Add(Me.bConfig)
    Me.Controls.Add(Me.bQuitter)
    Me.Controls.Add(Me.lUvasoft)
    Me.Controls.Add(Me.lNiceLabel)
    Me.Controls.Add(Me.lQte)
    Me.Controls.Add(Me.bPrevisuTest)
    Me.Name = "frmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmMain"
    Me.TabControl1.ResumeLayout(False)
    Me.Erp.ResumeLayout(False)
    Me.Erp.PerformLayout()
    Me.Apercu.ResumeLayout(False)
    Me.Apercu.PerformLayout()
    CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Journal.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.Pose.ResumeLayout(False)
    Me.Pose.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents lScrutation As Label
  Friend WithEvents FichiersErp As ColumnHeader
  Friend WithEvents bSimErp As Button
  Friend WithEvents ListViewErp As ListView
  Friend WithEvents bSaisieQte As Button
  Friend WithEvents bPrevisu As Button
  Friend WithEvents Label3 As Label
  Friend WithEvents TabControl1 As TabControl
  Friend WithEvents Erp As TabPage
  Friend WithEvents cbAvecApercu As CheckBox
  Friend WithEvents bClearErp As Button
  Friend WithEvents Apercu As TabPage
  Friend WithEvents pbPreview As PictureBox
  Friend WithEvents cbFrontSide As CheckBox
  Friend WithEvents cbBackSide As CheckBox
  Friend WithEvents cbPreviewToFile As CheckBox
  Friend WithEvents Journal As TabPage
  Friend WithEvents bVoirJournal As Button
  Friend WithEvents bClearLog As Button
  Friend WithEvents LOGText As RichTextBox
  Friend WithEvents Timer1 As Timer
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents rbMDT As RadioButton
  Friend WithEvents rbMDP As RadioButton
  Friend WithEvents bJournal As Button
  Friend WithEvents GroupBox2 As GroupBox
  Friend WithEvents lDebugNL As Label
  Friend WithEvents lMessage As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents bImp As Button
  Friend WithEvents bConfig As Button
  Friend WithEvents bQuitter As Button
  Friend WithEvents lUvasoft As Label
  Friend WithEvents lNiceLabel As Label
  Friend WithEvents lQte As Label
  Friend WithEvents bPrevisuTest As Button
  Friend WithEvents cbModeAuto As CheckBox
  Friend WithEvents lTimer As Label
  Friend WithEvents bTestAutomate As Button
  Friend WithEvents Label7 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents lMsgEmiCEL As Label
  Friend WithEvents lMsgRecCEL As Label
  Friend WithEvents Label9 As Label
  Friend WithEvents sLectureOf As TextBox
  Friend WithEvents CelBan As TabPage
  Friend WithEvents Pose As TabPage
  Friend WithEvents ListViewErp_Ec As ListView
  Friend WithEvents Label1 As Label
  Friend WithEvents FichiersErp_Ec As ColumnHeader
End Class
