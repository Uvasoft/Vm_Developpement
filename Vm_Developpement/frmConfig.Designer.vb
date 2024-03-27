<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfig
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
    Me.TabPageBdd = New System.Windows.Forms.TabPage()
    Me.bModifyField = New System.Windows.Forms.Button()
    Me.bInsertField = New System.Windows.Forms.Button()
    Me.lvFields = New System.Windows.Forms.ListView()
    Me.NomChamp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.NomVariable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.TailleCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.bSuppField = New System.Windows.Forms.Button()
    Me.bAddField = New System.Windows.Forms.Button()
    Me.sFieldDsc = New System.Windows.Forms.TextBox()
    Me.bQuitter = New System.Windows.Forms.Button()
    Me.rbSens270 = New System.Windows.Forms.RadioButton()
    Me.rbSens180 = New System.Windows.Forms.RadioButton()
    Me.rbSens90 = New System.Windows.Forms.RadioButton()
    Me.sPathPrevisu = New System.Windows.Forms.Label()
    Me.sPathImages = New System.Windows.Forms.Label()
    Me.sPathLabels = New System.Windows.Forms.Label()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.rbSens0 = New System.Windows.Forms.RadioButton()
    Me.rbImpCsNon = New System.Windows.Forms.RadioButton()
    Me.rbImpCsOui = New System.Windows.Forms.RadioButton()
    Me.rbImpCs = New System.Windows.Forms.RadioButton()
    Me.rbParamCsNon = New System.Windows.Forms.RadioButton()
    Me.rbParamCsOui = New System.Windows.Forms.RadioButton()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.RadioButton1 = New System.Windows.Forms.RadioButton()
    Me.RadioButton2 = New System.Windows.Forms.RadioButton()
    Me.RadioButton3 = New System.Windows.Forms.RadioButton()
    Me.rbParamCs = New System.Windows.Forms.RadioButton()
    Me.GroupBox5 = New System.Windows.Forms.GroupBox()
    Me.RadioButton4 = New System.Windows.Forms.RadioButton()
    Me.RadioButton5 = New System.Windows.Forms.RadioButton()
    Me.RadioButton6 = New System.Windows.Forms.RadioButton()
    Me.TabPageNiceLabel = New System.Windows.Forms.TabPage()
    Me.cbMergeDatabase = New System.Windows.Forms.CheckBox()
    Me.cbSeqInitZebra = New System.Windows.Forms.CheckBox()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.sLabelCpy = New System.Windows.Forms.TextBox()
    Me.sPathRequetes = New System.Windows.Forms.Label()
    Me.cbPathRequetes = New System.Windows.Forms.CheckBox()
    Me.cbEffVar = New System.Windows.Forms.CheckBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.obZoom = New System.Windows.Forms.RadioButton()
    Me.obEtire = New System.Windows.Forms.RadioButton()
    Me.RadioButton10 = New System.Windows.Forms.RadioButton()
    Me.RadioButton11 = New System.Windows.Forms.RadioButton()
    Me.RadioButton12 = New System.Windows.Forms.RadioButton()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cbCodesoft = New System.Windows.Forms.CheckBox()
    Me.cbPathImages = New System.Windows.Forms.CheckBox()
    Me.cbPathLabs = New System.Windows.Forms.CheckBox()
    Me.bPathRequetesCS = New System.Windows.Forms.Button()
    Me.bPathRequetes = New System.Windows.Forms.Button()
    Me.bPathImagesCS = New System.Windows.Forms.Button()
    Me.bPathLabsCS = New System.Windows.Forms.Button()
    Me.bPathImages = New System.Windows.Forms.Button()
    Me.bPathPrevisu = New System.Windows.Forms.Button()
    Me.bPathLabs = New System.Windows.Forms.Button()
    Me.sMdp = New System.Windows.Forms.TextBox()
    Me.cbMdpArret = New System.Windows.Forms.CheckBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.cbDebugNL = New System.Windows.Forms.CheckBox()
    Me.bRepDonnees = New System.Windows.Forms.Button()
    Me.bRepApp = New System.Windows.Forms.Button()
    Me.cbDebug = New System.Windows.Forms.CheckBox()
    Me.bVoir = New System.Windows.Forms.Button()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage8 = New System.Windows.Forms.TabPage()
    Me.bSelMDT = New System.Windows.Forms.Button()
    Me.Label37 = New System.Windows.Forms.Label()
    Me.sImpMDT = New System.Windows.Forms.TextBox()
    Me.bSelMDP = New System.Windows.Forms.Button()
    Me.Label36 = New System.Windows.Forms.Label()
    Me.sImpMDP = New System.Windows.Forms.TextBox()
    Me.bClear = New System.Windows.Forms.Button()
    Me.bSuppress = New System.Windows.Forms.Button()
    Me.bReplace = New System.Windows.Forms.Button()
    Me.bAdd = New System.Windows.Forms.Button()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.ListCourante = New System.Windows.Forms.ListBox()
    Me.LstPrinters = New System.Windows.Forms.ListBox()
    Me.ConfigPoste = New System.Windows.Forms.TabPage()
    Me.sListeOperateur2 = New System.Windows.Forms.TextBox()
    Me.Label40 = New System.Windows.Forms.Label()
    Me.sListeOperateur1 = New System.Windows.Forms.TextBox()
    Me.Label39 = New System.Windows.Forms.Label()
    Me.sListeSite = New System.Windows.Forms.TextBox()
    Me.Label38 = New System.Windows.Forms.Label()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.bSelPathScrutation = New System.Windows.Forms.Button()
    Me.sPathScrutation = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Automate = New System.Windows.Forms.TabPage()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.sIpAutomate = New System.Windows.Forms.TextBox()
    Me.bCancel = New System.Windows.Forms.Button()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.ListViewBdd = New System.Windows.Forms.ListView()
    Me.bRaffraichir = New System.Windows.Forms.Button()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Label2 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.TabPage5 = New System.Windows.Forms.TabPage()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.TextBox3 = New System.Windows.Forms.TextBox()
    Me.TabPageBdd.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox5.SuspendLayout()
    Me.TabPageNiceLabel.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage8.SuspendLayout()
    Me.ConfigPoste.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.Automate.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabPageBdd
    '
    Me.TabPageBdd.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPageBdd.Controls.Add(Me.bModifyField)
    Me.TabPageBdd.Controls.Add(Me.bInsertField)
    Me.TabPageBdd.Controls.Add(Me.lvFields)
    Me.TabPageBdd.Controls.Add(Me.bSuppField)
    Me.TabPageBdd.Controls.Add(Me.bAddField)
    Me.TabPageBdd.Controls.Add(Me.sFieldDsc)
    Me.TabPageBdd.Location = New System.Drawing.Point(4, 32)
    Me.TabPageBdd.Name = "TabPageBdd"
    Me.TabPageBdd.Size = New System.Drawing.Size(774, 490)
    Me.TabPageBdd.TabIndex = 5
    Me.TabPageBdd.Text = "BaseDeDonnées"
    '
    'bModifyField
    '
    Me.bModifyField.BackColor = System.Drawing.Color.SteelBlue
    Me.bModifyField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bModifyField.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bModifyField.ForeColor = System.Drawing.Color.White
    Me.bModifyField.Location = New System.Drawing.Point(404, 207)
    Me.bModifyField.Name = "bModifyField"
    Me.bModifyField.Size = New System.Drawing.Size(148, 37)
    Me.bModifyField.TabIndex = 88
    Me.bModifyField.Text = "Modif. Champ"
    Me.bModifyField.UseVisualStyleBackColor = False
    '
    'bInsertField
    '
    Me.bInsertField.BackColor = System.Drawing.Color.SteelBlue
    Me.bInsertField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bInsertField.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bInsertField.ForeColor = System.Drawing.Color.White
    Me.bInsertField.Location = New System.Drawing.Point(404, 335)
    Me.bInsertField.Name = "bInsertField"
    Me.bInsertField.Size = New System.Drawing.Size(148, 37)
    Me.bInsertField.TabIndex = 87
    Me.bInsertField.Text = "Insert Champ"
    Me.bInsertField.UseVisualStyleBackColor = False
    '
    'lvFields
    '
    Me.lvFields.BackColor = System.Drawing.Color.LightSteelBlue
    Me.lvFields.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NomChamp, Me.NomVariable, Me.TailleCol})
    Me.lvFields.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lvFields.ForeColor = System.Drawing.Color.Black
    Me.lvFields.FullRowSelect = True
    Me.lvFields.HideSelection = False
    Me.lvFields.Location = New System.Drawing.Point(34, 19)
    Me.lvFields.Margin = New System.Windows.Forms.Padding(2)
    Me.lvFields.Name = "lvFields"
    Me.lvFields.Size = New System.Drawing.Size(354, 448)
    Me.lvFields.TabIndex = 85
    Me.lvFields.UseCompatibleStateImageBehavior = False
    Me.lvFields.View = System.Windows.Forms.View.Details
    '
    'NomChamp
    '
    Me.NomChamp.Text = "NomChamp"
    Me.NomChamp.Width = 150
    '
    'NomVariable
    '
    Me.NomVariable.Text = "NomVariable"
    Me.NomVariable.Width = 150
    '
    'TailleCol
    '
    Me.TailleCol.Text = "TailleCol"
    Me.TailleCol.Width = 150
    '
    'bSuppField
    '
    Me.bSuppField.BackColor = System.Drawing.Color.SteelBlue
    Me.bSuppField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bSuppField.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bSuppField.ForeColor = System.Drawing.Color.White
    Me.bSuppField.Location = New System.Drawing.Point(404, 112)
    Me.bSuppField.Name = "bSuppField"
    Me.bSuppField.Size = New System.Drawing.Size(148, 37)
    Me.bSuppField.TabIndex = 84
    Me.bSuppField.Text = "Supp Champ"
    Me.bSuppField.UseVisualStyleBackColor = False
    '
    'bAddField
    '
    Me.bAddField.BackColor = System.Drawing.Color.SteelBlue
    Me.bAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bAddField.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bAddField.ForeColor = System.Drawing.Color.White
    Me.bAddField.Location = New System.Drawing.Point(404, 269)
    Me.bAddField.Name = "bAddField"
    Me.bAddField.Size = New System.Drawing.Size(148, 37)
    Me.bAddField.TabIndex = 83
    Me.bAddField.Text = "Add Champ"
    Me.bAddField.UseVisualStyleBackColor = False
    '
    'sFieldDsc
    '
    Me.sFieldDsc.BackColor = System.Drawing.Color.SteelBlue
    Me.sFieldDsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sFieldDsc.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sFieldDsc.ForeColor = System.Drawing.Color.White
    Me.sFieldDsc.Location = New System.Drawing.Point(403, 157)
    Me.sFieldDsc.Margin = New System.Windows.Forms.Padding(2)
    Me.sFieldDsc.Name = "sFieldDsc"
    Me.sFieldDsc.Size = New System.Drawing.Size(355, 30)
    Me.sFieldDsc.TabIndex = 81
    '
    'bQuitter
    '
    Me.bQuitter.BackColor = System.Drawing.Color.SteelBlue
    Me.bQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bQuitter.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bQuitter.ForeColor = System.Drawing.Color.White
    Me.bQuitter.Location = New System.Drawing.Point(596, 556)
    Me.bQuitter.Name = "bQuitter"
    Me.bQuitter.Size = New System.Drawing.Size(234, 33)
    Me.bQuitter.TabIndex = 98
    Me.bQuitter.Text = "&Enregistrer / Quitter"
    Me.bQuitter.UseVisualStyleBackColor = False
    '
    'rbSens270
    '
    Me.rbSens270.AutoSize = True
    Me.rbSens270.Location = New System.Drawing.Point(200, 48)
    Me.rbSens270.Name = "rbSens270"
    Me.rbSens270.Size = New System.Drawing.Size(64, 27)
    Me.rbSens270.TabIndex = 4
    Me.rbSens270.TabStop = True
    Me.rbSens270.Text = "-90°"
    Me.rbSens270.UseVisualStyleBackColor = True
    '
    'rbSens180
    '
    Me.rbSens180.AutoSize = True
    Me.rbSens180.Location = New System.Drawing.Point(135, 48)
    Me.rbSens180.Name = "rbSens180"
    Me.rbSens180.Size = New System.Drawing.Size(67, 27)
    Me.rbSens180.TabIndex = 3
    Me.rbSens180.TabStop = True
    Me.rbSens180.Text = "180°"
    Me.rbSens180.UseVisualStyleBackColor = True
    '
    'rbSens90
    '
    Me.rbSens90.AutoSize = True
    Me.rbSens90.Location = New System.Drawing.Point(67, 48)
    Me.rbSens90.Name = "rbSens90"
    Me.rbSens90.Size = New System.Drawing.Size(57, 27)
    Me.rbSens90.TabIndex = 2
    Me.rbSens90.TabStop = True
    Me.rbSens90.Text = "90°"
    Me.rbSens90.UseVisualStyleBackColor = True
    '
    'sPathPrevisu
    '
    Me.sPathPrevisu.BackColor = System.Drawing.Color.Transparent
    Me.sPathPrevisu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sPathPrevisu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sPathPrevisu.Location = New System.Drawing.Point(43, 64)
    Me.sPathPrevisu.Name = "sPathPrevisu"
    Me.sPathPrevisu.Size = New System.Drawing.Size(574, 23)
    Me.sPathPrevisu.TabIndex = 86
    '
    'sPathImages
    '
    Me.sPathImages.BackColor = System.Drawing.Color.LightSteelBlue
    Me.sPathImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sPathImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sPathImages.Location = New System.Drawing.Point(39, 247)
    Me.sPathImages.Name = "sPathImages"
    Me.sPathImages.Size = New System.Drawing.Size(578, 23)
    Me.sPathImages.TabIndex = 85
    '
    'sPathLabels
    '
    Me.sPathLabels.BackColor = System.Drawing.Color.Transparent
    Me.sPathLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sPathLabels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sPathLabels.Location = New System.Drawing.Point(39, 184)
    Me.sPathLabels.Name = "sPathLabels"
    Me.sPathLabels.Size = New System.Drawing.Size(578, 23)
    Me.sPathLabels.TabIndex = 84
    '
    'GroupBox4
    '
    Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox4.Controls.Add(Me.rbSens270)
    Me.GroupBox4.Controls.Add(Me.rbSens180)
    Me.GroupBox4.Controls.Add(Me.rbSens90)
    Me.GroupBox4.Controls.Add(Me.rbSens0)
    Me.GroupBox4.Location = New System.Drawing.Point(43, 98)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(402, 52)
    Me.GroupBox4.TabIndex = 83
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Rotation pré-visualisation"
    Me.GroupBox4.Visible = False
    '
    'rbSens0
    '
    Me.rbSens0.AutoSize = True
    Me.rbSens0.Location = New System.Drawing.Point(7, 48)
    Me.rbSens0.Name = "rbSens0"
    Me.rbSens0.Size = New System.Drawing.Size(47, 27)
    Me.rbSens0.TabIndex = 1
    Me.rbSens0.TabStop = True
    Me.rbSens0.Text = "0°"
    Me.rbSens0.UseVisualStyleBackColor = True
    '
    'rbImpCsNon
    '
    Me.rbImpCsNon.AutoSize = True
    Me.rbImpCsNon.Location = New System.Drawing.Point(284, 48)
    Me.rbImpCsNon.Name = "rbImpCsNon"
    Me.rbImpCsNon.Size = New System.Drawing.Size(56, 24)
    Me.rbImpCsNon.TabIndex = 3
    Me.rbImpCsNon.TabStop = True
    Me.rbImpCsNon.Text = "Non"
    Me.rbImpCsNon.UseVisualStyleBackColor = True
    '
    'rbImpCsOui
    '
    Me.rbImpCsOui.AutoSize = True
    Me.rbImpCsOui.Location = New System.Drawing.Point(215, 48)
    Me.rbImpCsOui.Name = "rbImpCsOui"
    Me.rbImpCsOui.Size = New System.Drawing.Size(51, 24)
    Me.rbImpCsOui.TabIndex = 2
    Me.rbImpCsOui.TabStop = True
    Me.rbImpCsOui.Text = "Oui"
    Me.rbImpCsOui.UseVisualStyleBackColor = True
    '
    'rbImpCs
    '
    Me.rbImpCs.AutoSize = True
    Me.rbImpCs.Location = New System.Drawing.Point(7, 48)
    Me.rbImpCs.Name = "rbImpCs"
    Me.rbImpCs.Size = New System.Drawing.Size(191, 24)
    Me.rbImpCs.TabIndex = 1
    Me.rbImpCs.TabStop = True
    Me.rbImpCs.Text = "Selon Param. Codesoft"
    Me.rbImpCs.UseVisualStyleBackColor = True
    '
    'rbParamCsNon
    '
    Me.rbParamCsNon.AutoSize = True
    Me.rbParamCsNon.Location = New System.Drawing.Point(284, 48)
    Me.rbParamCsNon.Name = "rbParamCsNon"
    Me.rbParamCsNon.Size = New System.Drawing.Size(56, 24)
    Me.rbParamCsNon.TabIndex = 3
    Me.rbParamCsNon.TabStop = True
    Me.rbParamCsNon.Text = "Non"
    Me.rbParamCsNon.UseVisualStyleBackColor = True
    '
    'rbParamCsOui
    '
    Me.rbParamCsOui.AutoSize = True
    Me.rbParamCsOui.Location = New System.Drawing.Point(215, 48)
    Me.rbParamCsOui.Name = "rbParamCsOui"
    Me.rbParamCsOui.Size = New System.Drawing.Size(51, 24)
    Me.rbParamCsOui.TabIndex = 2
    Me.rbParamCsOui.TabStop = True
    Me.rbParamCsOui.Text = "Oui"
    Me.rbParamCsOui.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox2.Controls.Add(Me.RadioButton1)
    Me.GroupBox2.Controls.Add(Me.RadioButton2)
    Me.GroupBox2.Controls.Add(Me.RadioButton3)
    Me.GroupBox2.Controls.Add(Me.rbImpCsNon)
    Me.GroupBox2.Controls.Add(Me.rbImpCsOui)
    Me.GroupBox2.Controls.Add(Me.rbImpCs)
    Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(43, 364)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(402, 52)
    Me.GroupBox2.TabIndex = 88
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Utiliser IMPRIMANTE Enreg. dans le Document"
    Me.GroupBox2.Visible = False
    '
    'RadioButton1
    '
    Me.RadioButton1.AutoSize = True
    Me.RadioButton1.Location = New System.Drawing.Point(302, 23)
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.Size = New System.Drawing.Size(56, 24)
    Me.RadioButton1.TabIndex = 6
    Me.RadioButton1.TabStop = True
    Me.RadioButton1.Text = "Non"
    Me.RadioButton1.UseVisualStyleBackColor = True
    '
    'RadioButton2
    '
    Me.RadioButton2.AutoSize = True
    Me.RadioButton2.Location = New System.Drawing.Point(233, 23)
    Me.RadioButton2.Name = "RadioButton2"
    Me.RadioButton2.Size = New System.Drawing.Size(51, 24)
    Me.RadioButton2.TabIndex = 5
    Me.RadioButton2.TabStop = True
    Me.RadioButton2.Text = "Oui"
    Me.RadioButton2.UseVisualStyleBackColor = True
    '
    'RadioButton3
    '
    Me.RadioButton3.AutoSize = True
    Me.RadioButton3.Location = New System.Drawing.Point(25, 23)
    Me.RadioButton3.Name = "RadioButton3"
    Me.RadioButton3.Size = New System.Drawing.Size(191, 24)
    Me.RadioButton3.TabIndex = 4
    Me.RadioButton3.TabStop = True
    Me.RadioButton3.Text = "Selon Param. Codesoft"
    Me.RadioButton3.UseVisualStyleBackColor = True
    '
    'rbParamCs
    '
    Me.rbParamCs.AutoSize = True
    Me.rbParamCs.Location = New System.Drawing.Point(7, 48)
    Me.rbParamCs.Name = "rbParamCs"
    Me.rbParamCs.Size = New System.Drawing.Size(191, 24)
    Me.rbParamCs.TabIndex = 1
    Me.rbParamCs.TabStop = True
    Me.rbParamCs.Text = "Selon Param. Codesoft"
    Me.rbParamCs.UseVisualStyleBackColor = True
    '
    'GroupBox5
    '
    Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox5.Controls.Add(Me.RadioButton4)
    Me.GroupBox5.Controls.Add(Me.RadioButton5)
    Me.GroupBox5.Controls.Add(Me.RadioButton6)
    Me.GroupBox5.Controls.Add(Me.rbParamCsNon)
    Me.GroupBox5.Controls.Add(Me.rbParamCsOui)
    Me.GroupBox5.Controls.Add(Me.rbParamCs)
    Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox5.Location = New System.Drawing.Point(43, 431)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.Size = New System.Drawing.Size(402, 52)
    Me.GroupBox5.TabIndex = 89
    Me.GroupBox5.TabStop = False
    Me.GroupBox5.Text = "Utiliser PARAMETRES Enreg. dans le Document"
    Me.GroupBox5.Visible = False
    '
    'RadioButton4
    '
    Me.RadioButton4.AutoSize = True
    Me.RadioButton4.Location = New System.Drawing.Point(301, 21)
    Me.RadioButton4.Name = "RadioButton4"
    Me.RadioButton4.Size = New System.Drawing.Size(56, 24)
    Me.RadioButton4.TabIndex = 6
    Me.RadioButton4.TabStop = True
    Me.RadioButton4.Text = "Non"
    Me.RadioButton4.UseVisualStyleBackColor = True
    '
    'RadioButton5
    '
    Me.RadioButton5.AutoSize = True
    Me.RadioButton5.Location = New System.Drawing.Point(232, 21)
    Me.RadioButton5.Name = "RadioButton5"
    Me.RadioButton5.Size = New System.Drawing.Size(51, 24)
    Me.RadioButton5.TabIndex = 5
    Me.RadioButton5.TabStop = True
    Me.RadioButton5.Text = "Oui"
    Me.RadioButton5.UseVisualStyleBackColor = True
    '
    'RadioButton6
    '
    Me.RadioButton6.AutoSize = True
    Me.RadioButton6.Location = New System.Drawing.Point(24, 21)
    Me.RadioButton6.Name = "RadioButton6"
    Me.RadioButton6.Size = New System.Drawing.Size(191, 24)
    Me.RadioButton6.TabIndex = 4
    Me.RadioButton6.TabStop = True
    Me.RadioButton6.Text = "Selon Param. Codesoft"
    Me.RadioButton6.UseVisualStyleBackColor = True
    '
    'TabPageNiceLabel
    '
    Me.TabPageNiceLabel.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPageNiceLabel.Controls.Add(Me.cbMergeDatabase)
    Me.TabPageNiceLabel.Controls.Add(Me.cbSeqInitZebra)
    Me.TabPageNiceLabel.Controls.Add(Me.Label17)
    Me.TabPageNiceLabel.Controls.Add(Me.sLabelCpy)
    Me.TabPageNiceLabel.Controls.Add(Me.sPathRequetes)
    Me.TabPageNiceLabel.Controls.Add(Me.cbPathRequetes)
    Me.TabPageNiceLabel.Controls.Add(Me.cbEffVar)
    Me.TabPageNiceLabel.Controls.Add(Me.GroupBox1)
    Me.TabPageNiceLabel.Controls.Add(Me.GroupBox5)
    Me.TabPageNiceLabel.Controls.Add(Me.GroupBox2)
    Me.TabPageNiceLabel.Controls.Add(Me.sPathPrevisu)
    Me.TabPageNiceLabel.Controls.Add(Me.sPathImages)
    Me.TabPageNiceLabel.Controls.Add(Me.sPathLabels)
    Me.TabPageNiceLabel.Controls.Add(Me.GroupBox4)
    Me.TabPageNiceLabel.Controls.Add(Me.Label3)
    Me.TabPageNiceLabel.Controls.Add(Me.cbCodesoft)
    Me.TabPageNiceLabel.Controls.Add(Me.cbPathImages)
    Me.TabPageNiceLabel.Controls.Add(Me.cbPathLabs)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathRequetesCS)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathRequetes)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathImagesCS)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathLabsCS)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathImages)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathPrevisu)
    Me.TabPageNiceLabel.Controls.Add(Me.bPathLabs)
    Me.TabPageNiceLabel.Location = New System.Drawing.Point(4, 32)
    Me.TabPageNiceLabel.Name = "TabPageNiceLabel"
    Me.TabPageNiceLabel.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPageNiceLabel.Size = New System.Drawing.Size(774, 490)
    Me.TabPageNiceLabel.TabIndex = 2
    Me.TabPageNiceLabel.Text = "NiceLabel"
    '
    'cbMergeDatabase
    '
    Me.cbMergeDatabase.AutoSize = True
    Me.cbMergeDatabase.Checked = True
    Me.cbMergeDatabase.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbMergeDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbMergeDatabase.Location = New System.Drawing.Point(480, 446)
    Me.cbMergeDatabase.Name = "cbMergeDatabase"
    Me.cbMergeDatabase.Size = New System.Drawing.Size(161, 24)
    Me.cbMergeDatabase.TabIndex = 106
    Me.cbMergeDatabase.Text = "Merge Database"
    Me.cbMergeDatabase.UseVisualStyleBackColor = True
    Me.cbMergeDatabase.Visible = False
    '
    'cbSeqInitZebra
    '
    Me.cbSeqInitZebra.AutoSize = True
    Me.cbSeqInitZebra.Checked = True
    Me.cbSeqInitZebra.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbSeqInitZebra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbSeqInitZebra.Location = New System.Drawing.Point(480, 416)
    Me.cbSeqInitZebra.Name = "cbSeqInitZebra"
    Me.cbSeqInitZebra.Size = New System.Drawing.Size(148, 24)
    Me.cbSeqInitZebra.TabIndex = 105
    Me.cbSeqInitZebra.Text = "Seq. Init Zebra"
    Me.cbSeqInitZebra.UseVisualStyleBackColor = True
    Me.cbSeqInitZebra.Visible = False
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(484, 382)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(98, 23)
    Me.Label17.TabIndex = 104
    Me.Label17.Text = "LabelCpy :"
    Me.Label17.Visible = False
    '
    'sLabelCpy
    '
    Me.sLabelCpy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sLabelCpy.Location = New System.Drawing.Point(583, 379)
    Me.sLabelCpy.MaxLength = 4
    Me.sLabelCpy.Name = "sLabelCpy"
    Me.sLabelCpy.Size = New System.Drawing.Size(60, 26)
    Me.sLabelCpy.TabIndex = 103
    Me.sLabelCpy.Text = "9999"
    Me.sLabelCpy.Visible = False
    '
    'sPathRequetes
    '
    Me.sPathRequetes.BackColor = System.Drawing.Color.LightSteelBlue
    Me.sPathRequetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sPathRequetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sPathRequetes.Location = New System.Drawing.Point(39, 308)
    Me.sPathRequetes.Name = "sPathRequetes"
    Me.sPathRequetes.Size = New System.Drawing.Size(578, 23)
    Me.sPathRequetes.TabIndex = 101
    Me.sPathRequetes.Visible = False
    '
    'cbPathRequetes
    '
    Me.cbPathRequetes.AutoSize = True
    Me.cbPathRequetes.BackColor = System.Drawing.Color.Transparent
    Me.cbPathRequetes.Checked = True
    Me.cbPathRequetes.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbPathRequetes.Location = New System.Drawing.Point(43, 278)
    Me.cbPathRequetes.Name = "cbPathRequetes"
    Me.cbPathRequetes.Size = New System.Drawing.Size(295, 27)
    Me.cbPathRequetes.TabIndex = 99
    Me.cbPathRequetes.Text = "Répertoire des fichiers requêtes"
    Me.cbPathRequetes.UseVisualStyleBackColor = False
    Me.cbPathRequetes.Visible = False
    '
    'cbEffVar
    '
    Me.cbEffVar.AutoSize = True
    Me.cbEffVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbEffVar.Location = New System.Drawing.Point(480, 351)
    Me.cbEffVar.Name = "cbEffVar"
    Me.cbEffVar.Size = New System.Drawing.Size(167, 24)
    Me.cbEffVar.TabIndex = 90
    Me.cbEffVar.Text = "Eff. des variables"
    Me.cbEffVar.UseVisualStyleBackColor = True
    Me.cbEffVar.Visible = False
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox1.Controls.Add(Me.obZoom)
    Me.GroupBox1.Controls.Add(Me.obEtire)
    Me.GroupBox1.Controls.Add(Me.RadioButton10)
    Me.GroupBox1.Controls.Add(Me.RadioButton11)
    Me.GroupBox1.Controls.Add(Me.RadioButton12)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(466, 98)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(190, 52)
    Me.GroupBox1.TabIndex = 89
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Prévisu Etiré ou Zoomé"
    Me.GroupBox1.Visible = False
    '
    'obZoom
    '
    Me.obZoom.AutoSize = True
    Me.obZoom.Checked = True
    Me.obZoom.Location = New System.Drawing.Point(97, 23)
    Me.obZoom.Name = "obZoom"
    Me.obZoom.Size = New System.Drawing.Size(68, 24)
    Me.obZoom.TabIndex = 5
    Me.obZoom.TabStop = True
    Me.obZoom.Text = "Zoom"
    Me.obZoom.UseVisualStyleBackColor = True
    '
    'obEtire
    '
    Me.obEtire.AutoSize = True
    Me.obEtire.Location = New System.Drawing.Point(25, 23)
    Me.obEtire.Name = "obEtire"
    Me.obEtire.Size = New System.Drawing.Size(60, 24)
    Me.obEtire.TabIndex = 4
    Me.obEtire.Text = "Etiré"
    Me.obEtire.UseVisualStyleBackColor = True
    '
    'RadioButton10
    '
    Me.RadioButton10.AutoSize = True
    Me.RadioButton10.Location = New System.Drawing.Point(284, 48)
    Me.RadioButton10.Name = "RadioButton10"
    Me.RadioButton10.Size = New System.Drawing.Size(56, 24)
    Me.RadioButton10.TabIndex = 3
    Me.RadioButton10.Text = "Non"
    Me.RadioButton10.UseVisualStyleBackColor = True
    '
    'RadioButton11
    '
    Me.RadioButton11.AutoSize = True
    Me.RadioButton11.Location = New System.Drawing.Point(215, 48)
    Me.RadioButton11.Name = "RadioButton11"
    Me.RadioButton11.Size = New System.Drawing.Size(51, 24)
    Me.RadioButton11.TabIndex = 2
    Me.RadioButton11.Text = "Oui"
    Me.RadioButton11.UseVisualStyleBackColor = True
    '
    'RadioButton12
    '
    Me.RadioButton12.AutoSize = True
    Me.RadioButton12.Location = New System.Drawing.Point(7, 48)
    Me.RadioButton12.Name = "RadioButton12"
    Me.RadioButton12.Size = New System.Drawing.Size(191, 24)
    Me.RadioButton12.TabIndex = 1
    Me.RadioButton12.Text = "Selon Param. Codesoft"
    Me.RadioButton12.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(39, 38)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(306, 23)
    Me.Label3.TabIndex = 82
    Me.Label3.Text = "Répertoire du fichier Previsu.png"
    '
    'cbCodesoft
    '
    Me.cbCodesoft.AutoSize = True
    Me.cbCodesoft.BackColor = System.Drawing.Color.Transparent
    Me.cbCodesoft.Location = New System.Drawing.Point(50, 14)
    Me.cbCodesoft.Name = "cbCodesoft"
    Me.cbCodesoft.Size = New System.Drawing.Size(159, 27)
    Me.cbCodesoft.TabIndex = 79
    Me.cbCodesoft.Text = "Codesoft Visible"
    Me.cbCodesoft.UseVisualStyleBackColor = False
    Me.cbCodesoft.Visible = False
    '
    'cbPathImages
    '
    Me.cbPathImages.AutoSize = True
    Me.cbPathImages.BackColor = System.Drawing.Color.Transparent
    Me.cbPathImages.Checked = True
    Me.cbPathImages.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbPathImages.Location = New System.Drawing.Point(43, 217)
    Me.cbPathImages.Name = "cbPathImages"
    Me.cbPathImages.Size = New System.Drawing.Size(281, 27)
    Me.cbPathImages.TabIndex = 73
    Me.cbPathImages.Text = "Répertoire des fichiers images"
    Me.cbPathImages.UseVisualStyleBackColor = False
    '
    'cbPathLabs
    '
    Me.cbPathLabs.AutoSize = True
    Me.cbPathLabs.BackColor = System.Drawing.Color.Transparent
    Me.cbPathLabs.Checked = True
    Me.cbPathLabs.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cbPathLabs.Location = New System.Drawing.Point(43, 155)
    Me.cbPathLabs.Name = "cbPathLabs"
    Me.cbPathLabs.Size = New System.Drawing.Size(255, 27)
    Me.cbPathLabs.TabIndex = 72
    Me.cbPathLabs.Text = "Répertoire des fichiers labs"
    Me.cbPathLabs.UseVisualStyleBackColor = False
    '
    'bPathRequetesCS
    '
    Me.bPathRequetesCS.Image = Global.Vm_Developpement.My.Resources.Resources.icons8_eye_32
    Me.bPathRequetesCS.Location = New System.Drawing.Point(634, 306)
    Me.bPathRequetesCS.Margin = New System.Windows.Forms.Padding(2)
    Me.bPathRequetesCS.Name = "bPathRequetesCS"
    Me.bPathRequetesCS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.bPathRequetesCS.Size = New System.Drawing.Size(30, 26)
    Me.bPathRequetesCS.TabIndex = 102
    Me.bPathRequetesCS.UseVisualStyleBackColor = True
    Me.bPathRequetesCS.Visible = False
    '
    'bPathRequetes
    '
    Me.bPathRequetes.Image = Global.Vm_Developpement.My.Resources.Resources.folder
    Me.bPathRequetes.Location = New System.Drawing.Point(681, 301)
    Me.bPathRequetes.Name = "bPathRequetes"
    Me.bPathRequetes.Size = New System.Drawing.Size(51, 36)
    Me.bPathRequetes.TabIndex = 100
    Me.bPathRequetes.UseVisualStyleBackColor = True
    Me.bPathRequetes.Visible = False
    '
    'bPathImagesCS
    '
    Me.bPathImagesCS.Image = Global.Vm_Developpement.My.Resources.Resources.icons8_eye_32
    Me.bPathImagesCS.Location = New System.Drawing.Point(634, 245)
    Me.bPathImagesCS.Margin = New System.Windows.Forms.Padding(2)
    Me.bPathImagesCS.Name = "bPathImagesCS"
    Me.bPathImagesCS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.bPathImagesCS.Size = New System.Drawing.Size(30, 26)
    Me.bPathImagesCS.TabIndex = 98
    Me.bPathImagesCS.UseVisualStyleBackColor = True
    '
    'bPathLabsCS
    '
    Me.bPathLabsCS.Image = Global.Vm_Developpement.My.Resources.Resources.icons8_eye_32
    Me.bPathLabsCS.Location = New System.Drawing.Point(634, 182)
    Me.bPathLabsCS.Margin = New System.Windows.Forms.Padding(2)
    Me.bPathLabsCS.Name = "bPathLabsCS"
    Me.bPathLabsCS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.bPathLabsCS.Size = New System.Drawing.Size(30, 26)
    Me.bPathLabsCS.TabIndex = 97
    Me.bPathLabsCS.UseVisualStyleBackColor = True
    '
    'bPathImages
    '
    Me.bPathImages.Image = Global.Vm_Developpement.My.Resources.Resources.folder
    Me.bPathImages.Location = New System.Drawing.Point(681, 240)
    Me.bPathImages.Name = "bPathImages"
    Me.bPathImages.Size = New System.Drawing.Size(51, 36)
    Me.bPathImages.TabIndex = 77
    Me.bPathImages.UseVisualStyleBackColor = True
    '
    'bPathPrevisu
    '
    Me.bPathPrevisu.Image = Global.Vm_Developpement.My.Resources.Resources.folder
    Me.bPathPrevisu.Location = New System.Drawing.Point(655, 57)
    Me.bPathPrevisu.Name = "bPathPrevisu"
    Me.bPathPrevisu.Size = New System.Drawing.Size(51, 37)
    Me.bPathPrevisu.TabIndex = 81
    Me.bPathPrevisu.UseVisualStyleBackColor = True
    '
    'bPathLabs
    '
    Me.bPathLabs.Image = Global.Vm_Developpement.My.Resources.Resources.folder
    Me.bPathLabs.Location = New System.Drawing.Point(681, 177)
    Me.bPathLabs.Name = "bPathLabs"
    Me.bPathLabs.Size = New System.Drawing.Size(51, 36)
    Me.bPathLabs.TabIndex = 76
    Me.bPathLabs.UseVisualStyleBackColor = True
    '
    'sMdp
    '
    Me.sMdp.BackColor = System.Drawing.Color.SteelBlue
    Me.sMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sMdp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sMdp.ForeColor = System.Drawing.Color.White
    Me.sMdp.Location = New System.Drawing.Point(233, 84)
    Me.sMdp.MaxLength = 10
    Me.sMdp.Name = "sMdp"
    Me.sMdp.Size = New System.Drawing.Size(193, 30)
    Me.sMdp.TabIndex = 71
    '
    'cbMdpArret
    '
    Me.cbMdpArret.AutoSize = True
    Me.cbMdpArret.BackColor = System.Drawing.Color.SteelBlue
    Me.cbMdpArret.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbMdpArret.ForeColor = System.Drawing.Color.White
    Me.cbMdpArret.Location = New System.Drawing.Point(233, 131)
    Me.cbMdpArret.Margin = New System.Windows.Forms.Padding(10)
    Me.cbMdpArret.Name = "cbMdpArret"
    Me.cbMdpArret.Padding = New System.Windows.Forms.Padding(5)
    Me.cbMdpArret.Size = New System.Drawing.Size(457, 37)
    Me.cbMdpArret.TabIndex = 70
    Me.cbMdpArret.Text = "Utiliser le mot de passe pour sortir du programme"
    Me.cbMdpArret.UseVisualStyleBackColor = False
    Me.cbMdpArret.Visible = False
    '
    'Label10
    '
    Me.Label10.BackColor = System.Drawing.Color.SteelBlue
    Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.ForeColor = System.Drawing.Color.White
    Me.Label10.Location = New System.Drawing.Point(22, 83)
    Me.Label10.Margin = New System.Windows.Forms.Padding(3)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(192, 31)
    Me.Label10.TabIndex = 69
    Me.Label10.Text = "Mot de passe : "
    Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'TabPage1
    '
    Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage1.Controls.Add(Me.cbDebugNL)
    Me.TabPage1.Controls.Add(Me.bRepDonnees)
    Me.TabPage1.Controls.Add(Me.bRepApp)
    Me.TabPage1.Controls.Add(Me.cbDebug)
    Me.TabPage1.Controls.Add(Me.bVoir)
    Me.TabPage1.Controls.Add(Me.sMdp)
    Me.TabPage1.Controls.Add(Me.cbMdpArret)
    Me.TabPage1.Controls.Add(Me.Label10)
    Me.TabPage1.Location = New System.Drawing.Point(4, 32)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(774, 490)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Général"
    '
    'cbDebugNL
    '
    Me.cbDebugNL.AutoSize = True
    Me.cbDebugNL.BackColor = System.Drawing.Color.SteelBlue
    Me.cbDebugNL.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbDebugNL.ForeColor = System.Drawing.Color.White
    Me.cbDebugNL.Location = New System.Drawing.Point(365, 175)
    Me.cbDebugNL.Name = "cbDebugNL"
    Me.cbDebugNL.Padding = New System.Windows.Forms.Padding(5)
    Me.cbDebugNL.Size = New System.Drawing.Size(190, 37)
    Me.cbDebugNL.TabIndex = 109
    Me.cbDebugNL.Text = "Debug NIce Label"
    Me.cbDebugNL.UseVisualStyleBackColor = False
    '
    'bRepDonnees
    '
    Me.bRepDonnees.BackColor = System.Drawing.Color.SteelBlue
    Me.bRepDonnees.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bRepDonnees.ForeColor = System.Drawing.Color.White
    Me.bRepDonnees.Location = New System.Drawing.Point(233, 353)
    Me.bRepDonnees.Name = "bRepDonnees"
    Me.bRepDonnees.Size = New System.Drawing.Size(268, 42)
    Me.bRepDonnees.TabIndex = 103
    Me.bRepDonnees.Text = "Rep. Données"
    Me.bRepDonnees.UseVisualStyleBackColor = False
    '
    'bRepApp
    '
    Me.bRepApp.BackColor = System.Drawing.Color.SteelBlue
    Me.bRepApp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bRepApp.ForeColor = System.Drawing.Color.White
    Me.bRepApp.Location = New System.Drawing.Point(233, 294)
    Me.bRepApp.Name = "bRepApp"
    Me.bRepApp.Size = New System.Drawing.Size(268, 42)
    Me.bRepApp.TabIndex = 102
    Me.bRepApp.Text = "Rep. Application"
    Me.bRepApp.UseVisualStyleBackColor = False
    '
    'cbDebug
    '
    Me.cbDebug.AutoSize = True
    Me.cbDebug.BackColor = System.Drawing.Color.SteelBlue
    Me.cbDebug.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbDebug.ForeColor = System.Drawing.Color.White
    Me.cbDebug.Location = New System.Drawing.Point(233, 175)
    Me.cbDebug.Name = "cbDebug"
    Me.cbDebug.Padding = New System.Windows.Forms.Padding(5)
    Me.cbDebug.Size = New System.Drawing.Size(95, 37)
    Me.cbDebug.TabIndex = 101
    Me.cbDebug.Text = "Debug"
    Me.cbDebug.UseVisualStyleBackColor = False
    '
    'bVoir
    '
    Me.bVoir.BackColor = System.Drawing.Color.SteelBlue
    Me.bVoir.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bVoir.ForeColor = System.Drawing.Color.White
    Me.bVoir.Location = New System.Drawing.Point(233, 235)
    Me.bVoir.Name = "bVoir"
    Me.bVoir.Size = New System.Drawing.Size(268, 42)
    Me.bVoir.TabIndex = 100
    Me.bVoir.Text = "&Voir ElaInnovation.ini"
    Me.bVoir.UseVisualStyleBackColor = False
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPageNiceLabel)
    Me.TabControl1.Controls.Add(Me.TabPage8)
    Me.TabControl1.Controls.Add(Me.TabPageBdd)
    Me.TabControl1.Controls.Add(Me.ConfigPoste)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.Automate)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Controls.Add(Me.TabPage5)
    Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabControl1.Location = New System.Drawing.Point(48, 24)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(974, 526)
    Me.TabControl1.TabIndex = 97
    '
    'TabPage8
    '
    Me.TabPage8.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage8.Controls.Add(Me.bSelMDT)
    Me.TabPage8.Controls.Add(Me.Label37)
    Me.TabPage8.Controls.Add(Me.sImpMDT)
    Me.TabPage8.Controls.Add(Me.bSelMDP)
    Me.TabPage8.Controls.Add(Me.Label36)
    Me.TabPage8.Controls.Add(Me.sImpMDP)
    Me.TabPage8.Controls.Add(Me.bClear)
    Me.TabPage8.Controls.Add(Me.bSuppress)
    Me.TabPage8.Controls.Add(Me.bReplace)
    Me.TabPage8.Controls.Add(Me.bAdd)
    Me.TabPage8.Controls.Add(Me.Label11)
    Me.TabPage8.Controls.Add(Me.ListCourante)
    Me.TabPage8.Controls.Add(Me.LstPrinters)
    Me.TabPage8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPage8.Location = New System.Drawing.Point(4, 32)
    Me.TabPage8.Name = "TabPage8"
    Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage8.Size = New System.Drawing.Size(774, 490)
    Me.TabPage8.TabIndex = 7
    Me.TabPage8.Text = "Imprimantes"
    '
    'bSelMDT
    '
    Me.bSelMDT.BackColor = System.Drawing.Color.SteelBlue
    Me.bSelMDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bSelMDT.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bSelMDT.ForeColor = System.Drawing.Color.White
    Me.bSelMDT.Location = New System.Drawing.Point(438, 259)
    Me.bSelMDT.Name = "bSelMDT"
    Me.bSelMDT.Size = New System.Drawing.Size(120, 32)
    Me.bSelMDT.TabIndex = 90
    Me.bSelMDT.Text = "Sélection"
    Me.bSelMDT.UseVisualStyleBackColor = False
    '
    'Label37
    '
    Me.Label37.AutoSize = True
    Me.Label37.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label37.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label37.Location = New System.Drawing.Point(439, 184)
    Me.Label37.Name = "Label37"
    Me.Label37.Size = New System.Drawing.Size(197, 23)
    Me.Label37.TabIndex = 89
    Me.Label37.Text = "Imp. de table CL6NX :"
    '
    'sImpMDT
    '
    Me.sImpMDT.BackColor = System.Drawing.Color.SteelBlue
    Me.sImpMDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sImpMDT.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sImpMDT.ForeColor = System.Drawing.Color.White
    Me.sImpMDT.Location = New System.Drawing.Point(438, 216)
    Me.sImpMDT.Name = "sImpMDT"
    Me.sImpMDT.Size = New System.Drawing.Size(315, 30)
    Me.sImpMDT.TabIndex = 88
    Me.sImpMDT.Text = "Select Imp. de table CL6NX"
    '
    'bSelMDP
    '
    Me.bSelMDP.BackColor = System.Drawing.Color.SteelBlue
    Me.bSelMDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bSelMDP.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bSelMDP.ForeColor = System.Drawing.Color.White
    Me.bSelMDP.Location = New System.Drawing.Point(438, 106)
    Me.bSelMDP.Name = "bSelMDP"
    Me.bSelMDP.Size = New System.Drawing.Size(120, 32)
    Me.bSelMDP.TabIndex = 87
    Me.bSelMDP.Text = "Sélection"
    Me.bSelMDP.UseVisualStyleBackColor = False
    '
    'Label36
    '
    Me.Label36.AutoSize = True
    Me.Label36.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label36.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label36.Location = New System.Drawing.Point(439, 30)
    Me.Label36.Name = "Label36"
    Me.Label36.Size = New System.Drawing.Size(185, 23)
    Me.Label36.TabIndex = 86
    Me.Label36.Text = "Imp. pose LA4050E :"
    '
    'sImpMDP
    '
    Me.sImpMDP.BackColor = System.Drawing.Color.SteelBlue
    Me.sImpMDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sImpMDP.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sImpMDP.ForeColor = System.Drawing.Color.White
    Me.sImpMDP.Location = New System.Drawing.Point(438, 62)
    Me.sImpMDP.Name = "sImpMDP"
    Me.sImpMDP.Size = New System.Drawing.Size(316, 30)
    Me.sImpMDP.TabIndex = 85
    Me.sImpMDP.Text = "Select Imp. pose LA4050E"
    '
    'bClear
    '
    Me.bClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bClear.Location = New System.Drawing.Point(633, 353)
    Me.bClear.Name = "bClear"
    Me.bClear.Size = New System.Drawing.Size(120, 37)
    Me.bClear.TabIndex = 7
    Me.bClear.Text = "Efface tout"
    Me.bClear.UseVisualStyleBackColor = True
    Me.bClear.Visible = False
    '
    'bSuppress
    '
    Me.bSuppress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bSuppress.Location = New System.Drawing.Point(428, 353)
    Me.bSuppress.Name = "bSuppress"
    Me.bSuppress.Size = New System.Drawing.Size(120, 37)
    Me.bSuppress.TabIndex = 6
    Me.bSuppress.Text = "Enleve"
    Me.bSuppress.UseVisualStyleBackColor = True
    Me.bSuppress.Visible = False
    '
    'bReplace
    '
    Me.bReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bReplace.Location = New System.Drawing.Point(224, 353)
    Me.bReplace.Name = "bReplace"
    Me.bReplace.Size = New System.Drawing.Size(120, 37)
    Me.bReplace.TabIndex = 5
    Me.bReplace.Text = "Remplace"
    Me.bReplace.UseVisualStyleBackColor = True
    Me.bReplace.Visible = False
    '
    'bAdd
    '
    Me.bAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bAdd.Location = New System.Drawing.Point(18, 353)
    Me.bAdd.Name = "bAdd"
    Me.bAdd.Size = New System.Drawing.Size(120, 37)
    Me.bAdd.TabIndex = 4
    Me.bAdd.Text = "Ajoute"
    Me.bAdd.UseVisualStyleBackColor = True
    Me.bAdd.Visible = False
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(14, 15)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(214, 23)
    Me.Label11.TabIndex = 3
    Me.Label11.Text = "Imprimantes disponibles"
    '
    'ListCourante
    '
    Me.ListCourante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListCourante.FormattingEnabled = True
    Me.ListCourante.ItemHeight = 20
    Me.ListCourante.Location = New System.Drawing.Point(18, 396)
    Me.ListCourante.Name = "ListCourante"
    Me.ListCourante.Size = New System.Drawing.Size(736, 84)
    Me.ListCourante.TabIndex = 2
    Me.ListCourante.Visible = False
    '
    'LstPrinters
    '
    Me.LstPrinters.BackColor = System.Drawing.Color.LightSteelBlue
    Me.LstPrinters.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LstPrinters.ForeColor = System.Drawing.Color.Black
    Me.LstPrinters.FormattingEnabled = True
    Me.LstPrinters.ItemHeight = 23
    Me.LstPrinters.Location = New System.Drawing.Point(18, 37)
    Me.LstPrinters.Name = "LstPrinters"
    Me.LstPrinters.Size = New System.Drawing.Size(414, 257)
    Me.LstPrinters.TabIndex = 1
    '
    'ConfigPoste
    '
    Me.ConfigPoste.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ConfigPoste.Controls.Add(Me.sListeOperateur2)
    Me.ConfigPoste.Controls.Add(Me.Label40)
    Me.ConfigPoste.Controls.Add(Me.sListeOperateur1)
    Me.ConfigPoste.Controls.Add(Me.Label39)
    Me.ConfigPoste.Controls.Add(Me.sListeSite)
    Me.ConfigPoste.Controls.Add(Me.Label38)
    Me.ConfigPoste.Location = New System.Drawing.Point(4, 32)
    Me.ConfigPoste.Name = "ConfigPoste"
    Me.ConfigPoste.Size = New System.Drawing.Size(774, 490)
    Me.ConfigPoste.TabIndex = 10
    Me.ConfigPoste.Text = "ConfigDuPoste"
    '
    'sListeOperateur2
    '
    Me.sListeOperateur2.BackColor = System.Drawing.Color.SteelBlue
    Me.sListeOperateur2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sListeOperateur2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sListeOperateur2.ForeColor = System.Drawing.Color.White
    Me.sListeOperateur2.Location = New System.Drawing.Point(265, 121)
    Me.sListeOperateur2.Name = "sListeOperateur2"
    Me.sListeOperateur2.Size = New System.Drawing.Size(392, 30)
    Me.sListeOperateur2.TabIndex = 106
    '
    'Label40
    '
    Me.Label40.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label40.Location = New System.Drawing.Point(81, 123)
    Me.Label40.Name = "Label40"
    Me.Label40.Size = New System.Drawing.Size(164, 23)
    Me.Label40.TabIndex = 105
    Me.Label40.Text = "Liste Opérateur 2"
    '
    'sListeOperateur1
    '
    Me.sListeOperateur1.BackColor = System.Drawing.Color.SteelBlue
    Me.sListeOperateur1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sListeOperateur1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sListeOperateur1.ForeColor = System.Drawing.Color.White
    Me.sListeOperateur1.Location = New System.Drawing.Point(265, 78)
    Me.sListeOperateur1.Name = "sListeOperateur1"
    Me.sListeOperateur1.Size = New System.Drawing.Size(392, 30)
    Me.sListeOperateur1.TabIndex = 104
    '
    'Label39
    '
    Me.Label39.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label39.Location = New System.Drawing.Point(81, 80)
    Me.Label39.Name = "Label39"
    Me.Label39.Size = New System.Drawing.Size(164, 23)
    Me.Label39.TabIndex = 103
    Me.Label39.Text = "Liste Opérateur 1"
    '
    'sListeSite
    '
    Me.sListeSite.BackColor = System.Drawing.Color.SteelBlue
    Me.sListeSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sListeSite.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sListeSite.ForeColor = System.Drawing.Color.White
    Me.sListeSite.Location = New System.Drawing.Point(265, 37)
    Me.sListeSite.Name = "sListeSite"
    Me.sListeSite.Size = New System.Drawing.Size(392, 30)
    Me.sListeSite.TabIndex = 102
    '
    'Label38
    '
    Me.Label38.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label38.Location = New System.Drawing.Point(81, 39)
    Me.Label38.Name = "Label38"
    Me.Label38.Size = New System.Drawing.Size(164, 23)
    Me.Label38.TabIndex = 101
    Me.Label38.Text = "Liste site "
    '
    'TabPage2
    '
    Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage2.Controls.Add(Me.bRaffraichir)
    Me.TabPage2.Controls.Add(Me.ListViewBdd)
    Me.TabPage2.Controls.Add(Me.bSelPathScrutation)
    Me.TabPage2.Controls.Add(Me.sPathScrutation)
    Me.TabPage2.Controls.Add(Me.Label1)
    Me.TabPage2.Location = New System.Drawing.Point(4, 32)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(966, 490)
    Me.TabPage2.TabIndex = 11
    Me.TabPage2.Text = "Scrutation"
    '
    'bSelPathScrutation
    '
    Me.bSelPathScrutation.Image = CType(resources.GetObject("bSelPathScrutation.Image"), System.Drawing.Image)
    Me.bSelPathScrutation.Location = New System.Drawing.Point(582, 55)
    Me.bSelPathScrutation.Name = "bSelPathScrutation"
    Me.bSelPathScrutation.Size = New System.Drawing.Size(51, 37)
    Me.bSelPathScrutation.TabIndex = 105
    Me.bSelPathScrutation.UseVisualStyleBackColor = True
    '
    'sPathScrutation
    '
    Me.sPathScrutation.BackColor = System.Drawing.Color.SteelBlue
    Me.sPathScrutation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sPathScrutation.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sPathScrutation.ForeColor = System.Drawing.Color.White
    Me.sPathScrutation.Location = New System.Drawing.Point(57, 55)
    Me.sPathScrutation.Name = "sPathScrutation"
    Me.sPathScrutation.Size = New System.Drawing.Size(500, 30)
    Me.sPathScrutation.TabIndex = 104
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(53, 29)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(286, 23)
    Me.Label1.TabIndex = 103
    Me.Label1.Text = "Rép. de scrutation ERP :"
    '
    'Automate
    '
    Me.Automate.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Automate.Controls.Add(Me.Label13)
    Me.Automate.Controls.Add(Me.Label12)
    Me.Automate.Controls.Add(Me.Label9)
    Me.Automate.Controls.Add(Me.Label7)
    Me.Automate.Controls.Add(Me.Label6)
    Me.Automate.Controls.Add(Me.sIpAutomate)
    Me.Automate.Location = New System.Drawing.Point(4, 32)
    Me.Automate.Name = "Automate"
    Me.Automate.Padding = New System.Windows.Forms.Padding(3)
    Me.Automate.Size = New System.Drawing.Size(966, 490)
    Me.Automate.TabIndex = 12
    Me.Automate.Text = "Automate"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.Location = New System.Drawing.Point(227, 338)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(310, 23)
    Me.Label13.TabIndex = 183
    Me.Label13.Text = "Automate : Emission UDP sur 11001"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(227, 304)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(321, 23)
    Me.Label12.TabIndex = 182
    Me.Label12.Text = "Automate : Réception UDP sur 11000"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(227, 257)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(249, 23)
    Me.Label9.TabIndex = 181
    Me.Label9.Text = "Pc : Emission UDP sur 11000"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(227, 225)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(260, 23)
    Me.Label7.TabIndex = 180
    Me.Label7.Text = "Pc : Réception UDP sur 11001"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(227, 129)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(184, 23)
    Me.Label6.TabIndex = 179
    Me.Label6.Text = "Adresse IP Automate"
    '
    'sIpAutomate
    '
    Me.sIpAutomate.BackColor = System.Drawing.Color.SteelBlue
    Me.sIpAutomate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.sIpAutomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.sIpAutomate.ForeColor = System.Drawing.Color.White
    Me.sIpAutomate.Location = New System.Drawing.Point(231, 156)
    Me.sIpAutomate.Name = "sIpAutomate"
    Me.sIpAutomate.Size = New System.Drawing.Size(157, 26)
    Me.sIpAutomate.TabIndex = 178
    Me.sIpAutomate.Text = "192.168.1.xxx"
    '
    'bCancel
    '
    Me.bCancel.BackColor = System.Drawing.Color.SteelBlue
    Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bCancel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bCancel.ForeColor = System.Drawing.Color.White
    Me.bCancel.Location = New System.Drawing.Point(458, 556)
    Me.bCancel.Name = "bCancel"
    Me.bCancel.Size = New System.Drawing.Size(119, 33)
    Me.bCancel.TabIndex = 99
    Me.bCancel.Text = "&Annuler"
    Me.bCancel.UseVisualStyleBackColor = False
    '
    'TabPage3
    '
    Me.TabPage3.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage3.Controls.Add(Me.Label2)
    Me.TabPage3.Controls.Add(Me.TextBox1)
    Me.TabPage3.Location = New System.Drawing.Point(4, 32)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(966, 490)
    Me.TabPage3.TabIndex = 13
    Me.TabPage3.Text = "Palettiseur"
    '
    'TabPage4
    '
    Me.TabPage4.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage4.Controls.Add(Me.Label4)
    Me.TabPage4.Controls.Add(Me.TextBox2)
    Me.TabPage4.Location = New System.Drawing.Point(4, 32)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(966, 490)
    Me.TabPage4.TabIndex = 14
    Me.TabPage4.Text = "Banderolleuse"
    '
    'ListViewBdd
    '
    Me.ListViewBdd.Activation = System.Windows.Forms.ItemActivation.OneClick
    Me.ListViewBdd.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ListViewBdd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
    Me.ListViewBdd.ForeColor = System.Drawing.SystemColors.WindowText
    Me.ListViewBdd.HideSelection = False
    Me.ListViewBdd.Location = New System.Drawing.Point(57, 103)
    Me.ListViewBdd.Name = "ListViewBdd"
    Me.ListViewBdd.Size = New System.Drawing.Size(500, 349)
    Me.ListViewBdd.TabIndex = 106
    Me.ListViewBdd.UseCompatibleStateImageBehavior = False
    Me.ListViewBdd.View = System.Windows.Forms.View.Details
    '
    'bRaffraichir
    '
    Me.bRaffraichir.BackColor = System.Drawing.Color.SteelBlue
    Me.bRaffraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.bRaffraichir.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bRaffraichir.ForeColor = System.Drawing.Color.White
    Me.bRaffraichir.Location = New System.Drawing.Point(582, 103)
    Me.bRaffraichir.Name = "bRaffraichir"
    Me.bRaffraichir.Size = New System.Drawing.Size(148, 37)
    Me.bRaffraichir.TabIndex = 107
    Me.bRaffraichir.Text = "Raffraichir"
    Me.bRaffraichir.UseVisualStyleBackColor = False
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "*.csv"
    Me.ColumnHeader1.Width = 353
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(277, 45)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(190, 23)
    Me.Label2.TabIndex = 181
    Me.Label2.Text = "Adresse IP Palettiseur"
    '
    'TextBox1
    '
    Me.TextBox1.BackColor = System.Drawing.Color.SteelBlue
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.ForeColor = System.Drawing.Color.White
    Me.TextBox1.Location = New System.Drawing.Point(281, 72)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(157, 26)
    Me.TextBox1.TabIndex = 180
    Me.TextBox1.Text = "192.168.1.xxx"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(276, 43)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(221, 23)
    Me.Label4.TabIndex = 181
    Me.Label4.Text = "Adresse IP Bandorelleuse"
    '
    'TextBox2
    '
    Me.TextBox2.BackColor = System.Drawing.Color.SteelBlue
    Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox2.ForeColor = System.Drawing.Color.White
    Me.TextBox2.Location = New System.Drawing.Point(280, 70)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(157, 26)
    Me.TextBox2.TabIndex = 180
    Me.TextBox2.Text = "192.168.1.xxx"
    '
    'TabPage5
    '
    Me.TabPage5.BackColor = System.Drawing.Color.LightSteelBlue
    Me.TabPage5.Controls.Add(Me.Label5)
    Me.TabPage5.Controls.Add(Me.TextBox3)
    Me.TabPage5.Location = New System.Drawing.Point(4, 32)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage5.Size = New System.Drawing.Size(966, 490)
    Me.TabPage5.TabIndex = 15
    Me.TabPage5.Text = "ClampBoxIp"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(277, 42)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(204, 23)
    Me.Label5.TabIndex = 183
    Me.Label5.Text = "Adresse IP ClampBoxIp"
    '
    'TextBox3
    '
    Me.TextBox3.BackColor = System.Drawing.Color.SteelBlue
    Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox3.ForeColor = System.Drawing.Color.White
    Me.TextBox3.Location = New System.Drawing.Point(281, 69)
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(157, 26)
    Me.TextBox3.TabIndex = 182
    Me.TextBox3.Text = "192.168.1.xxx"
    '
    'frmConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.LightSteelBlue
    Me.ClientSize = New System.Drawing.Size(1063, 601)
    Me.Controls.Add(Me.bCancel)
    Me.Controls.Add(Me.bQuitter)
    Me.Controls.Add(Me.TabControl1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(2)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmConfig"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Config"
    Me.TabPageBdd.ResumeLayout(False)
    Me.TabPageBdd.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox4.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox5.ResumeLayout(False)
    Me.GroupBox5.PerformLayout()
    Me.TabPageNiceLabel.ResumeLayout(False)
    Me.TabPageNiceLabel.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage8.ResumeLayout(False)
    Me.TabPage8.PerformLayout()
    Me.ConfigPoste.ResumeLayout(False)
    Me.ConfigPoste.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.Automate.ResumeLayout(False)
    Me.Automate.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage3.PerformLayout()
    Me.TabPage4.ResumeLayout(False)
    Me.TabPage4.PerformLayout()
    Me.TabPage5.ResumeLayout(False)
    Me.TabPage5.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents TabPageBdd As TabPage
  Friend WithEvents bQuitter As Button
  Friend WithEvents rbSens270 As RadioButton
  Friend WithEvents rbSens180 As RadioButton
  Friend WithEvents rbSens90 As RadioButton
  Friend WithEvents sPathPrevisu As Label
  Friend WithEvents sPathImages As Label
  Friend WithEvents sPathLabels As Label
  Friend WithEvents GroupBox4 As GroupBox
  Friend WithEvents rbSens0 As RadioButton
  Friend WithEvents rbImpCsNon As RadioButton
  Friend WithEvents rbImpCsOui As RadioButton
  Friend WithEvents rbImpCs As RadioButton
  Friend WithEvents rbParamCsNon As RadioButton
  Friend WithEvents rbParamCsOui As RadioButton
  Friend WithEvents GroupBox2 As GroupBox
  Friend WithEvents rbParamCs As RadioButton
  Friend WithEvents GroupBox5 As GroupBox
  Friend WithEvents TabPageNiceLabel As TabPage
  Friend WithEvents Label3 As Label
  Friend WithEvents cbCodesoft As CheckBox
  Friend WithEvents cbPathImages As CheckBox
  Friend WithEvents cbPathLabs As CheckBox
  Friend WithEvents bPathImages As Button
  Friend WithEvents bPathPrevisu As Button
  Friend WithEvents bPathLabs As Button
  Friend WithEvents sMdp As TextBox
  Friend WithEvents cbMdpArret As CheckBox
  Friend WithEvents Label10 As Label
  Friend WithEvents TabPage1 As TabPage
  Friend WithEvents TabControl1 As TabControl
  Friend WithEvents TabPage8 As TabPage
  Friend WithEvents bClear As Button
  Friend WithEvents bSuppress As Button
  Friend WithEvents bReplace As Button
  Friend WithEvents bAdd As Button
  Friend WithEvents Label11 As Label
  Friend WithEvents ListCourante As ListBox
  Friend WithEvents LstPrinters As ListBox
  Friend WithEvents RadioButton1 As RadioButton
  Friend WithEvents RadioButton2 As RadioButton
  Friend WithEvents RadioButton3 As RadioButton
  Friend WithEvents RadioButton4 As RadioButton
  Friend WithEvents RadioButton5 As RadioButton
  Friend WithEvents RadioButton6 As RadioButton
  Friend WithEvents bCancel As Button
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents obZoom As RadioButton
  Friend WithEvents obEtire As RadioButton
  Friend WithEvents RadioButton10 As RadioButton
  Friend WithEvents RadioButton11 As RadioButton
  Friend WithEvents RadioButton12 As RadioButton
  Friend WithEvents bVoir As Button
  Friend WithEvents cbEffVar As CheckBox
  Friend WithEvents cbDebug As CheckBox
  Friend WithEvents bRepApp As Button
  Friend WithEvents bRepDonnees As Button
  Friend WithEvents bPathImagesCS As Button
  Friend WithEvents bPathLabsCS As Button
  Friend WithEvents bPathRequetesCS As Button
  Friend WithEvents sPathRequetes As Label
  Friend WithEvents cbPathRequetes As CheckBox
  Friend WithEvents bPathRequetes As Button
  Friend WithEvents Label17 As Label
  Friend WithEvents sLabelCpy As TextBox
  Friend WithEvents cbSeqInitZebra As CheckBox
  Friend WithEvents cbMergeDatabase As CheckBox
  Friend WithEvents bSelMDT As Button
  Friend WithEvents Label37 As Label
  Friend WithEvents sImpMDT As TextBox
  Friend WithEvents bSelMDP As Button
  Friend WithEvents Label36 As Label
  Friend WithEvents sImpMDP As TextBox
  Friend WithEvents sFieldDsc As TextBox
  Friend WithEvents bAddField As Button
  Friend WithEvents lvFields As ListView
  Friend WithEvents NomChamp As ColumnHeader
  Friend WithEvents NomVariable As ColumnHeader
  Friend WithEvents TailleCol As ColumnHeader
  Friend WithEvents bInsertField As Button
  Friend WithEvents bSuppField As Button
  Friend WithEvents bModifyField As Button
  Friend WithEvents ConfigPoste As TabPage
  Friend WithEvents sListeOperateur2 As TextBox
  Friend WithEvents Label40 As Label
  Friend WithEvents sListeOperateur1 As TextBox
  Friend WithEvents Label39 As Label
  Friend WithEvents sListeSite As TextBox
  Friend WithEvents Label38 As Label
  Friend WithEvents cbDebugNL As CheckBox
  Friend WithEvents TabPage2 As TabPage
  Friend WithEvents bSelPathScrutation As Button
  Friend WithEvents sPathScrutation As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents Automate As TabPage
  Friend WithEvents Label13 As Label
  Friend WithEvents Label12 As Label
  Friend WithEvents Label9 As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents sIpAutomate As TextBox
  Friend WithEvents TabPage3 As TabPage
  Friend WithEvents TabPage4 As TabPage
  Friend WithEvents bRaffraichir As Button
  Friend WithEvents ListViewBdd As ListView
  Friend WithEvents ColumnHeader1 As ColumnHeader
  Friend WithEvents Label2 As Label
  Friend WithEvents TextBox1 As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents TabPage5 As TabPage
  Friend WithEvents Label5 As Label
  Friend WithEvents TextBox3 As TextBox
End Class
