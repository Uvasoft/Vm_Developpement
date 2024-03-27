Imports NiceLabel
Imports NiceLabel.SDK
Imports System.IO
Imports System.Drawing
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class frmMain
  Dim i, j As Integer
  Dim sTMP As String
  Dim bError As Boolean
  Dim bErrorFatal As Boolean
  ' connexion UDP
  Dim RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
  'émission
  Dim sendingUdpClient As New UdpClient
  Dim Increment As Integer
  ' Reception
  Public receivingUdpClient1 As UdpClient
  'Public receivingUdpClient2 As UdpClient
  'Public receivingUdpClient3 As UdpClient
  'Public receivingUdpClient4 As UdpClient
  'Public receivingUdpClient5 As UdpClient
  'Public receivingUdpClient6 As UdpClient
  ' threads de réception ( 5 automates )
  Dim clsThreads As New Generic.List(Of System.Threading.Thread)
  Dim TcpipIsOpen As Boolean

  Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' attention aussi changer la version dans SETUP
    ' si on genere un setup de'installation
    lUvasoft.Text = "Uvasoft " & " V1.0"
    Pgm.FinInit = 0
    'ReDim Cfg.sIpAut(NB_AUTOMATES)
    'ReDim Cfg.sOffAut(NB_AUTOMATES)
    'ReDim Cfg.sCoefAut(NB_AUTOMATES)
    'ReDim Cfg.sCoefMM(NB_AUTOMATES)
    'ReDim Cfg.sDecEnMM(NB_AUTOMATES)
    RepInst = RepInstallation()
    NL_Load()
    frmConfig.LireConfig()
    frmConfig.LireConfigFlash()
    InitInterface()
    ImpSelect(Cfg.bImpDePose)
    'NL_LstPrinter()
    'If LireBdd() Then Exit Sub
    ModeSelect(Pgm.cbModeAuto)
    TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
    'If Cfg.ArticleCourant <> "" Then
    'lArticleEnCours.Text = Cfg.ArticleCourant
    '   Automate_Fichier.CodeArticle = Cfg.ArticleCourant
    'End If
    Timer1.Interval = 1000
    ListViewErp_Ec.FullRowSelect = True
    ListViewErp_Ec.HideSelection = False
    ListViewErp_Ec.MultiSelect = False
    ListViewErp_Ec.Sorting = SortOrder.Ascending
    ListViewBddSelect()
    'TabControl1.TabPages.Remove(Erp_Ec)
    TcpipOpen()
    ListeFichiersErp()
    Pgm.FinInit = 1
    'If Pgm.cbModeAuto Then
    'cbModeAuto.CheckState = CheckState.Unchecked
    'Else
    'cbModeAuto.CheckState = CheckState.Checked
    'End If
    'cbPrevisu.Checked = Cfg.cbPrevisu
  End Sub

  Private Sub NL_Load()
    Try
      If Directory.Exists(AppliFolder) = False Then
        Directory.CreateDirectory(AppliFolder)
        If Directory.Exists(AppliFolder) Then
          Call frmMessage.Message("Création du répertoire " & AppliFolder)
          frmMessage.ShowDialog()
        Else
          Call frmMessage.Message("Impossible de créer le répertoire :   " & AppliFolder)
          frmMessage.ShowDialog()
          Exit Sub
        End If
      End If
      ' création des répertoires dans c:\programdata
      CreationRep("\Labels")
      CreationRep("\Graphics")
      CreationRep("\TxtSrc")
      CreationRep("\Scrutation")
      CreationRep("\Erp_Encours")
      CreationRep("\TxtArchives")
      CreationRep("\Database")
      CreationRep("\Logs")
      ' répertoire labels
      CopieDeFichier("\Labels\LabTest.nlbl")
      ' répertoire Scrutation
      CopieDeFichier("\TxtSrc\A.csv")
      ' répertoire Database
      'CopieDeFichier("\Database\Mismanu.txt")
      'CopieDeFichier("\Database\Mismanu.sch")
      ' graphics
      CopieDeFichier("\Graphics\Image1.jpg")
      CopieDeFichier("\Graphics\Image2.jpg")
      'CopieDeFichier("\Graphics\Logo.jpg")
      If ElaInnovationDEBUG Then
        Call frmMessage.Message("ATTENTION, programme en mode DEBUG")
        frmMessage.ShowDialog()
      End If
      If PrevInstance() Then
        frmMessage.Message("Programme déja lancé / Programm already running")
        frmMessage.ShowDialog()
        Quitter()
      End If
      ' Exit Sub
      'Dim sdkFilesPath As String = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "") ' "..\\..\\..\\SDKFiles")
      Dim sdkFilesPath As String
      If Directory.Exists("C:\Program Files\NiceLabel\NiceLabel 10\bin.net\") Then
        NLVersionTrouve = 10
        sdkFilesPath = "C:\Program Files\NiceLabel\NiceLabel 10\bin.net\"
      ElseIf Directory.Exists("C:\Program Files\NiceLabel\NiceLabel 2019\bin.net\") Then
        NLVersionTrouve = 2019
        sdkFilesPath = "C:\Program Files\NiceLabel\NiceLabel 2019\bin.net\"
      ElseIf Directory.Exists("C:\Program Files\NiceLabel\NiceLabel 2017\bin.net\") Then
        NLVersionTrouve = 2017
        sdkFilesPath = "C:\Program Files\NiceLabel\NiceLabel 2017\bin.net\"
      Else
        NLVersionTrouve = 0
        sdkFilesPath = ""
        lNiceLabel.Text = "Nicelabel ABSENT"
        lNiceLabel.BackColor = Color.Red
        lNiceLabel.ForeColor = Color.White
        Exit Sub
      End If
      NiceLabel.SDK.PrintEngineFactory.SDKFilesPath = sdkFilesPath
      NL_PrintEngine = NiceLabel.SDK.PrintEngineFactory.PrintEngine
      If Cfg.cbDebugNL Then
        NL_PrintEngine.TraceFile = AppliFolder & "\Logs\NL.log"
      End If
      NL_PrintEngine.Initialize()
      If NL_PrintEngine.Initialized Then
        lNiceLabel.BackColor = Color.Green
        lNiceLabel.ForeColor = Color.White
        lNiceLabel.Text = "Nicelabel " & NLVersionTrouve
        LOG_Text_Add("Nicelabel PrintEngine initialisé ", False, False)
      Else
        lNiceLabel.Text = "Nicelabel PB INIT"
        lNiceLabel.BackColor = Color.Red
        lNiceLabel.ForeColor = Color.White
        LOG_Text_Add("NL_LOAD PrintEngine PB INIT ", True, False)
      End If
      'NL_PrintEngine.SetSetting("") = pa
    Catch ex As Exception
      LOG_Text_Add("CATCH : NL_LOAD : " & ex.Message, True, False)
    End Try
  End Sub

  Private Sub CopieDeFichier(f As String)
    If Not File.Exists(RepInst & "\ProgramData" & f) Then
      LOG_Text_Add("CopieDeFichier : " & " ABSENT : " & RepInst & "\ProgramData" & f, True, False)
      Exit Sub
    End If
    If Not File.Exists(AppliFolder & f) Then FileCopy(RepInst & "\ProgramData" & f, AppliFolder & f)
  End Sub

  Private Sub CreationRep(r As String)
    If Not Directory.Exists(AppliFolder & r) Then
      Directory.CreateDirectory(AppliFolder & r)
    End If
  End Sub

  Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    On Error Resume Next
    If NL_PrintEngine.Initialized Then NL_PrintEngine.Shutdown()
  End Sub

  Private Sub bImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImp.Click
    'InitSaisieManuelle()
    'ImpressionNL("", Cfg.ImpCourante, Val(lQte.Text), False, True)

    'ListViewBdd.Focus()
  End Sub

  Private Sub NL_LstPrinter()
    'For Each NL_Printer In NL_PrintEngine.Printers
    'lstPrinters.Items.Add(NL_Printer.Name)
    'Next
    'MsgBox(NL_PrintEngine.Printers.Count)
  End Sub

  Private Sub NL_GetPreview()
    Try
      If NLVersionTrouve = 0 Then Exit Sub
      NL_Label = NL_PrintEngine.OpenLabel(AppliFolder & "\Labels\GetLabelPreviewSample.nlbl")
      'NL_Label = NL_PrintEngine.OpenLabel(Cfg.sPathLabels & "\GetLabelPreviewSample.nlbl")
      'NL_Label = NL_PrintEngine.OpenLabel(Cfg.sPathLabels & "\Mismanu_UVA.nlbl")
      ' variable must exists because of missing result-code 
      NL_Label.Variables.Item("Name").SetValue("Weber Jean-Marc")
      NL_Label.Variables.Item("Company").SetValue("Uvasoft")
      NL_Label.Variables.Item("Title").SetValue("Développeur")
      NL_Label.Variables.Item("Email").SetValue("jmarc.weber@uvasoft.fr")
      NL_Label.Variables.Item("Phone").SetValue("06 41 68 28 39")
      NL_Label.PrintSettings.PrinterName = Cfg.ImpCourante
      SizePreview()
      'Set up LabelPreviewSettings to be passed to the GetLabelPreview method.
      NL_labelPreviewSettings = New LabelPreviewSettings()
      NL_labelPreviewSettings.PreviewToFile = cbPreviewToFile.Checked ' If True, result will be the file name, If False, result will be a Byte array.
      NL_labelPreviewSettings.ImageFormat = "PNG"                               ' file format Of graphics.  Valid formats: JPG, PNG, BMP.
      NL_labelPreviewSettings.Width = pbPreview.Width              ' Width of image to generate
      NL_labelPreviewSettings.Height = pbPreview.Height            ' Height Of image To generate
      ' NL_labelPreviewSettings.Destination = TextBoxFileName.Text           ' If PrintToFile Is True, this Is the name Of the file that will be generated.
      NL_labelPreviewSettings.Destination = AppliFolder & "\Previsu.png"
      NL_labelPreviewSettings.FormatPreviewSide = GetPreviewSide()         ' Which label side(s) To generate the image For.  
      ' Generate Preview File
      Dim imageObj As Object = NL_Label.GetLabelPreview(NL_labelPreviewSettings)
      ' Display image in UI
      If TypeOf imageObj Is Byte() Then
        ' When PrintToFiles = false
        ' Convert byte[] to Bitmap And set as image source for PictureBox control
        pbPreview.Image = ByteToImage(imageObj)
      ElseIf TypeOf imageObj Is String Then
        ' When PrintToFiles = true
        pbPreview.ImageLocation = imageObj
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub
  '
  'Gets the preview side(s) selected by user.
  '<returns>FormatPreviewSide with user's selection.</returns>
  '<exception cref="System.InvalidOperationException">You must choose at least one label side to preview.</exception>
  Private Function GetPreviewSide() As FormatPreviewSide
    ' Determine which side(s) of label to include
    If cbFrontSide.Checked Then
      If cbBackSide.Checked Then
        Return FormatPreviewSide.BothSides
      Else
        Return FormatPreviewSide.FrontSide
      End If
    End If
    If cbBackSide.Checked Then
      Return FormatPreviewSide.BackSide
    Else
      MsgBox("Vous devez sélectionner un coté pour la Prévisu")
      Return FormatPreviewSide.BothSides
    End If
  End Function
  '
  'Helper method to convert Bytes to image.
  '<param name="bytes">The image as a byte array.</param>
  '<returns>Bitmap of the image.</returns>
  Private Function ByteToImage(Bytes() As Byte) As Bitmap
    Dim MS As MemoryStream = New MemoryStream()
    MS.Write(Bytes, 0, Convert.ToInt32(Bytes.Length))
    Dim BM As Bitmap = New Bitmap(MS, False)
    MS.Dispose()
    Return BM
  End Function
  '
  Private Sub cbPreviewToFile_CheckedChanged(sender As Object, e As EventArgs) Handles cbPreviewToFile.CheckedChanged
    'TextBoxFileName.Enabled = cbPreviewToFile.Checked
    'labelFileName.Enabled = cbPreviewToFile.Checked
  End Sub

  Private Sub NL_Impression()
    MsgBox("a valider")
    Return
    Try
      If NLVersionTrouve = 0 Then Exit Sub
      Const iLabels As Integer = 3
      Dim sLabel As String = AppliFolder & "\Labels\LabelTest.nlbl"
      'Const sPrinter As String = "SATO S86-ex 203dpi"
      Const sPrinter As String = "SATO CL4NX 305dpi"
      bError = False
      ' open label & set variables
      NL_Label = NL_PrintEngine.OpenLabel(sLabel)
      ' variable must exists because of missing result-code 
      NL_Label.Variables.Item("Var01").SetValue("this is my company")
      ' alternative loop through NL_Label.Variables:
      For i = 0 To NL_Label.Variables.Count - 1 'alle Variablen auf Etikett
        If NL_Label.Variables.Item(i).Name = "Var02" Then NL_Label.Variables.Item(i).SetValue("I am the CEO")
      Next
      ' printer check & set (loop-check because of missing result-code)
      bImpFound = False
      For Each NL_Printer In NL_PrintEngine.Printers
        If NL_Printer.Name = sPrinter Then bImpFound = True
      Next
      If Not bImpFound Then
        LOG_Text_Add("NL_Printer non trouvée:" & sPrinter, True, True)
        Exit Sub
      Else
        NL_Label.PrintSettings.PrinterName = sPrinter
      End If
      ' print label 
      If Not bError Then
        NL_Label.PrintSettings.JobName = "VmDeveloppement"
        NL_Label.Print(iLabels)
        LOG_Text_Add("Label '" & sLabel & "' imprimé sur '" & sPrinter, False, False)
      Else
        LOG_Text_Add("Label '" & sLabel & "' ECHEC PRINT", True, False)
        Exit Sub
      End If
    Catch ex As Exception
      sTMP = "Erreur : NL_Impression : " & ex.Message
      LOG_Text_Add(sTMP, True, True)
      bErrorFatal = True
    End Try
  End Sub

  Private Function ImpressionNL(ClearSpool As Boolean, Label As String, ChampsNoms() As String, ChampsValeurs() As String, imp As String, qte As Integer, bApercu As Boolean, bImpression As Boolean) As Boolean
    Dim sPrinter As String
    Try
      If NLVersionTrouve = 0 Then Return False
      ' si jamais le nom du lab vient du fichier data.txt de l'automate
      ' If Label <> "" Then sLabel = AppliFolder & "\Labels\" & Label

      NL_Label = NL_PrintEngine.OpenLabel(AppliFolder & "\Labels\" & Label)
      'MsgBox(NL_Label.FilePath)
      TransmitFields(ChampsNoms, ChampsValeurs)
      If bError Then Return False
      'If bArtFound = False Then
      'LOG_Text_Add("Article non trouvé : " & Cfg.ArticleCourant, True, True)
      'Return False
      'End If
      sPrinter = imp
      ' printer check & set (loop-check because of missing result-code)
      bImpFound = False
      For Each NL_Printer In NL_PrintEngine.Printers
        If NL_Printer.Name = sPrinter Then
          bImpFound = True
          Exit For
        End If
      Next
      If Not bImpFound Then
        LOG_Text_Add("ImpressionNL imp. non trouvée : " & sPrinter, True, True)
        Return False
      Else
        NL_Label.PrintSettings.PrinterName = sPrinter
      End If
      ' print label 
      If bApercu Then
        SizePreview()
        NL_labelPreviewSettings = New LabelPreviewSettings()
        NL_labelPreviewSettings.PreviewToFile = cbPreviewToFile.Checked ' If True, result will be the file name, If False, result will be a Byte array.
        NL_labelPreviewSettings.ImageFormat = "PNG"                    ' file format Of graphics.  Valid formats: JPG, PNG, BMP.
        NL_labelPreviewSettings.Width = pbPreview.Width          ' Width of image to generate
        NL_labelPreviewSettings.Height = pbPreview.Height            ' Height Of image To generate
        'NL_labelPreviewSettings.Destination = TextBoxFileName.Text ' If PrintToFile Is True, this Is the name Of the file that will be generated.
        NL_labelPreviewSettings.Destination = AppliFolder & "\Previsu.png"
        NL_labelPreviewSettings.FormatPreviewSide = GetPreviewSide()  ' Which label side(s) To generate the image For.  
        ' Generate Preview File
        Dim imageObj As Object = NL_Label.GetLabelPreview(NL_labelPreviewSettings)
        'Display image in UI
        If TypeOf imageObj Is Byte() Then
          ' When PrintToFiles = false
          ' Convert byte[] to Bitmap And set as image source for PictureBox control
          pbPreview.Image = ByteToImage(imageObj)
        ElseIf TypeOf imageObj Is String Then
          ' When PrintToFiles = true
          pbPreview.ImageLocation = imageObj
        End If
      End If
      If bImpression Then
        NL_Label.PrintSettings.JobName = "VmDeveloppement"
        Dim Reset(7) As Byte
        Reset(0) = &H1B
        Reset(1) = &H41
        Reset(2) = &H1B
        Reset(3) = &H2A
        Reset(4) = &H1B
        Reset(5) = &H5A
        Reset(6) = &HD
        'NL_Printer.SendDataToPrinter(System.Text.Encoding.ASCII.GetBytes("^XA~JA^XZ"))
        If ClearSpool Then NL_Printer.SendDataToPrinter(Reset)
        NL_Label.Print(qte)
        LOG_Text_Add("Label:" & Label & " imprimé sur '" & sPrinter, False, False)
        'LOG_Text_Add("Label '" & sLabel & "' ECHEC PRINT", False, False)
        'End If
      End If
      Return True
    Catch ex As Exception
      sTMP = "ImpressionNL de " & Label & " : " & ex.Message
      LOG_Text_Add(sTMP, True, True)
      bErrorFatal = True
      Return False
    End Try
  End Function

  Sub LOG_Text_Add(ByVal pText As String, ByVal bLetale As Boolean, ByVal bErrorTag As Boolean)
    LOGText.AppendText(Now.ToString & " " & pText & vbNewLine)
    If bErrorTag Then bError = True
    If bLetale Then btnJournalRED()
    Message(pText, bLetale)
    Log_Fichier(Now.ToString & " " & pText)
  End Sub

  Sub LireTxt()
    ' non utilisé
    Try
      Dim array As String() = File.ReadAllLines("z:\file.txt")
      Dim line As String
      Dim Fields() As String
      For Each line In array
        Fields = Split(line, ";")
        If UBound(Fields) = 5 Then
          MsgBox(line)
        Else
          MsgBox("Nombre de champs incorrect :" & UBound(Fields) & ", attendu : 5")
        End If
      Next
    Catch ex As Exception
      MsgBox("Erreur : " & ex.Message)
    End Try
  End Sub

  Private Sub AddColumn(c As String, w As Integer)
    Dim Column As New ColumnHeader
    Column.Text = c
    Column.Width = w
    ListViewErp_Ec.Columns.Add(Column)
  End Sub

  Private Function TransmitFields(ChampsNoms() As String, ChampsValeurs() As String) As Boolean
    Dim i As Integer
    Try
      Dim VarList As SDK.IVariableList
      VarList = NL_Label.Variables
      Dim item As IVariable
      For Each item In VarList
        For i = 0 To UBound(ChampsNoms) - 1 'UBound(Cfg.FieldsStruc) - 1
          If item.Name.ToLower = ChampsNoms(i).ToLower Then ' Cfg.FieldsStruc(i).NomVariable.ToLower Then
            NL_Label.Variables.Item(ChampsNoms(i)).SetValue(ChampsValeurs(i))
          End If
        Next
      Next
      Return False
    Catch ex As Exception
      LOG_Text_Add("CATCH : TransmitFields : " & ChampsNoms(i), True, False)
      Return True
    End Try
  End Function

  Function PrevInstance() As Boolean
    If UBound(Diagnostics.Process.GetProcessesByName _
       (Diagnostics.Process.GetCurrentProcess.ProcessName)) _
       > 0 Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub bQuitter_Click(sender As Object, e As EventArgs) Handles bQuitter.Click
    Quitter()
  End Sub

  Private Sub bConfig_Click(sender As Object, e As EventArgs) Handles bConfig.Click
    If Cfg.sMdp <> "" Then
      frmMdpConfig.ShowDialog()
      'sRefOuPF.Focus() ' important sinon la forme n'a pas le focus
    Else
      frmConfig.ShowDialog()
    End If
    InitInterface()
    Message("Sél. Imp. " & Cfg.ImpCourante, False)
  End Sub

  Private Sub pbPreview_Click(sender As Object, e As EventArgs) Handles pbPreview.Click
    'pbSize.bPreviewSize = Not pbSize.bPreviewSize
    'SizePreview()
    'ImpressionNL(Cfg.ImpCourante, 1, True, False)
    'NL_GetPreview()
  End Sub

  Private Sub SizePreview()
    pbPreview.Top = Apercu.Top - 30
    pbPreview.Left = Apercu.Left
    pbPreview.Height = Apercu.Height
    pbPreview.Width = Apercu.Width
  End Sub

  Private Sub AffichePreview(Taille As Boolean)
    ' non utilisée pas testée..manque init de pbSize
    If Taille Then
      pbSize.Top = pbPreview.Top
      pbSize.Left = pbPreview.Left
      pbSize.Height = pbPreview.Height
      pbSize.Width = pbPreview.Width
      pbPreview.Top = Apercu.Top
      pbPreview.Left = Apercu.Left
      pbPreview.Height = Apercu.Height
      pbPreview.Width = Apercu.Width
    Else
      pbPreview.Top = pbSize.Top
      pbPreview.Left = pbSize.Left
      pbPreview.Height = pbSize.Height
      pbPreview.Width = pbSize.Width
    End If
    'ImpressionNL("", Cfg.ImpCourante, 1, True, False)
  End Sub

  Private Sub lUvasoft_Click(sender As Object, e As EventArgs) Handles lUvasoft.Click
    MsgBox("jmarc.weber@uvasoft.com" & vbCrLf & "Tél.: 0641682839")
  End Sub

  Private Sub ListViewBdd_Click(sender As Object, e As EventArgs) Handles ListViewErp_Ec.Click
    'lArticleEnCours.Text = ListViewBdd.SelectedItems(0).Text
    'Cfg.ArticleCourant = ListViewBdd.SelectedItems(0).Text
  End Sub

  Private Sub ImpSelect(b As Boolean)
    If b Then
      rbMDP.Checked = True
      rbMDP.BackColor = Color.RoyalBlue
      rbMDP.ForeColor = Color.White
      rbMDT.BackColor = Color.LightGray
      rbMDT.ForeColor = Color.Black
      Cfg.ImpCourante = Cfg.sImpMDP
    Else
      rbMDT.Checked = True
      rbMDP.BackColor = Color.LightGray
      rbMDP.ForeColor = Color.Black
      rbMDT.BackColor = Color.RoyalBlue
      rbMDT.ForeColor = Color.White
      Cfg.ImpCourante = Cfg.sImpMDT
    End If
    Message("Sél.Imp. : " & Cfg.ImpCourante, False)
  End Sub

  Private Sub ModeSelect(b As Boolean)
    cbModeAuto.Checked = b
    If b Then
      'cbModeAuto.Text = "Mode AUTO"
      cbModeAuto.BackColor = Color.RoyalBlue
      cbModeAuto.ForeColor = Color.White
    Else
      'cbModeAuto.Text = "Mode MANU"
      cbModeAuto.BackColor = Color.LightGray
      cbModeAuto.ForeColor = Color.Black
    End If
    Timer1.Enabled = b
  End Sub

  Private Sub Message(s As String, bLetale As Boolean)
    lMessage.Text = Now() & " : " & s
    If bLetale Then
      lMessage.BackColor = Color.Red
      lMessage.ForeColor = Color.White
    Else
      lMessage.BackColor = Color.RoyalBlue
      lMessage.ForeColor = Color.White
    End If
    lMessage.Refresh()
    Threading.Thread.Sleep(100)
  End Sub

  Private Sub Log_Fichier(s As String)
    Dim NomFichier As String
    If DateTime.Today.ToString("hh") > 4 Then
      NomFichier = "Log_" & DateTime.Today.ToString("ddMMyyyy") & ".txt"
    Else
      NomFichier = "Log_" & DateTime.Today.AddDays(-1).ToString("ddMMyyyy") & ".txt"
    End If
    Dim strFile As String = AppliFolder & "\Logs\" & NomFichier
    Dim sw As StreamWriter
    Try
      If (Not File.Exists(strFile)) Then
        sw = File.CreateText(strFile)
      Else
        sw = File.AppendText(strFile)
      End If
      sw.WriteLine(s)
      sw.Close()
    Catch ex As IOException
      MsgBox("Erreur LOG_Fichier : " & NomFichier)
    End Try
  End Sub

  Private Sub Quitter()
    On Error Resume Next
    If NL_PrintEngine.Initialized Then NL_PrintEngine.Shutdown()
    frmConfig.EcrireConfigFlash() ' pour sauvegarder les saisies locales dans MAIN
    Application.Exit()
  End Sub

  Private Sub bPrevisuTest_Click(sender As Object, e As EventArgs) Handles bPrevisuTest.Click
    '
    NL_GetPreview()
    TabControl1.SelectedTab = Apercu
  End Sub

  Private Sub bSaisie_Click(sender As Object, e As EventArgs)
    'Dim f As New tsNumericKeypad.tsNumericKeypad
    'Dim dr As DialogResult = f.ShowDialog
    'If dr = DialogResult.OK Then
    'lArticleEnCours.Text = f.Data
    'Cfg.ArticleCourant = f.Data
    ' Automate_Fichier = New tAutomate ' on efface, pas de saisie de faite
    '  on met la saisie en debut de liste
    'ListViewBddSelect()
    'End If
  End Sub

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    lTimer.Text = IIf(lTimer.Text = "/", "\", "/")
    Timer1.Enabled = False
    ListeFichiersErp()
    TraiteFichiersErp()
    Timer1.Enabled = True
  End Sub

  Private Sub ListeFichiersErp()
    Try
      'Dim Repertoire As New IO.DirectoryInfo(Cfg.sRepTxtDst)
      Dim Repertoire As New IO.DirectoryInfo(Cfg.sPathScrutation)
      Dim ListeFichier As IO.FileInfo() = Repertoire.GetFiles("*.csv")
      Dim Fichier As IO.FileInfo
      'list the names of all files in the specified directory
      ListViewErp.Items.Clear()
      For Each Fichier In ListeFichier
        Dim item As New ListViewItem
        item.Text = Fichier.Name
        ListViewErp.Items.Add(item)
      Next
      ListViewErp.Refresh()
    Catch ex As Exception
      LOG_Text_Add("CATCH ListeFichiersErp : " & ex.Message, True, False)
      'File1.ToolTipText = fConfig.sPathTexteMode & "\" & File1.Pattern
    End Try
  End Sub

  Private Sub TraiteFichiersErp()
    Dim ret As Boolean
    If ListViewErp.Items.Count > 0 Then
      Rename(AppliFolder & "\Scrutation\" & ListViewErp.Items(0).Text, AppliFolder & "\Scrutation\" & "EC_" & ListViewErp.Items(0).Text)
      ListeFichiersErp()
      ret = ExecuteFichierErp(ListViewErp.Items(0).Text)
      If ret Then
        EnvoiAutomate(1, " Impression OK")
      Else
        EnvoiAutomate(0, " Err Impression")
      End If
      MoveFile(ListViewErp.Items(0).Text)
    End If
  End Sub

  Private Function ExecuteFichierErp(f As String) As Boolean
    Try
      Dim ret As Boolean
      Dim array As String() = File.ReadAllLines(AppliFolder & "\scrutation\" & f)
      Dim label As String = "labname.nlbl"
      Dim ClearSpool As Boolean = False
      Dim ChampsNoms() As String = Split(array(0), ";")
      Dim ChampsValeurs() As String = Split(array(1), ";")
      For i = 0 To UBound(ChampsNoms)
        If ChampsNoms(i).ToLower = "masque" Then
          label = ChampsValeurs(i)
          'Exit For
        ElseIf ChampsNoms(i).ToLower = "clearspool" Then
          ClearSpool = ChampsValeurs(i)
        End If
      Next
      SendCel(ChampsNoms, ChampsValeurs)
      ret = ImpressionNL(ClearSpool, label, ChampsNoms, ChampsValeurs, Cfg.ImpCourante, 1, cbAvecApercu.Checked, True)
      Return True
    Catch ex As Exception
      Message("Erreur : " & ex.Message, True)
      Return False
    End Try
  End Function

  Private Sub SendCel(ChampsNoms() As String, CHampsValeurs() As String)
    Dim CelValeurs() As String, i As Integer, j As Integer
    j = 1
    For i = 0 To UBound(ChampsNoms)
      ReDim Preserve CelValeurs(j)
    Next
  End Sub

  Private Sub MoveFile(f As String)
    Dim txtDst As String = Cfg.sPathScrutation & "\" & f
    Dim txtArc As String = AppliFolder & "\TxtArchives\"
    Dim NewName As String
    '    Dim f1 As String = AppliFolder & "\TxtDst\" & f
    Try
      ' NewName = "DATA_" & Cfg.ArticleCourant & "_" & Format(Now(), "HHmmss") & ".csv"
      NewName = Replace(LCase(f), ".csv", "") & "_" & Format(Now(), "HHmmss") & ".csv"
      ' My.Computer.FileSystem.RenameFile(txtDst, NewName)
      Dim f1 As New IO.FileInfo(txtDst)
      f1.MoveTo(txtArc & NewName)
      'ListViewAut.Items(0).Remove()
      'ListViewAut.Refresh()
    Catch ex As IOException
      Message(ex.Message, True)
    End Try
  End Sub

  Private Sub bSimErp_Click(sender As Object, e As EventArgs) Handles bSimErp.Click
    Try
      If Directory.GetFiles(AppliFolder & "\scrutation", "*.*", SearchOption.TopDirectoryOnly).Count > 0 Then
        Message("Of en cours", True)
        Exit sub
      End If
      Message("Copie de " & AppliFolder & "\TxtSrc\A.csv" & " vers " & Cfg.sPathScrutation & "\A.csv", False)
      FileCopy(AppliFolder & "\TxtSrc\A.csv", Cfg.sPathScrutation & "\A.csv")
      If cbModeAuto.CheckState = False Then
        Message("Scrutation", False)
        ListeFichiersErp()
        Message("Traitement", False)
        TraiteFichiersErp()
        If cbAvecApercu.Checked Then TabControl1.SelectTab(Apercu)
        ListeFichiersErp()
      End If
    Catch ex As IOException
      Message("SimAut : " & ex.Message, True)
    End Try
  End Sub

  Private Sub bJournal_Click(sender As Object, e As EventArgs) Handles bJournal.Click
    TabControl1.SelectedTab = Journal
    bJournal.BackColor = Color.SteelBlue
    bJournal.ForeColor = Color.White
    bError = False
  End Sub

  Private Sub btnJournalRED()
    bJournal.BackColor = Color.Red
    bJournal.ForeColor = Color.White
  End Sub

  Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
    Dim g As Graphics = e.Graphics
    Dim tp As TabPage = TabControl1.TabPages(e.Index)
    Dim br As Brush
    Dim sf As New StringFormat
    Dim r As New RectangleF(e.Bounds.X, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height - 2)
    sf.Alignment = StringAlignment.Center
    Dim strTitle As String = tp.Text
    'If the current index is the Selected Index, change the color
    If TabControl1.SelectedIndex = e.Index Then
      'this is the background color of the tabpage
      'you could make this a stndard color for the selected page
      br = New SolidBrush(tp.BackColor)
      'this is the background color of the tab page
      g.FillRectangle(br, e.Bounds)
      'this is the background color of the tab page
      'you could make this a stndard color for the selected page
      br = New SolidBrush(tp.ForeColor)
      g.DrawString(strTitle, TabControl1.Font, br, r, sf)
    Else
      'these are the standard colors for the unselected tab pages
      br = New SolidBrush(Color.WhiteSmoke)
      g.FillRectangle(br, e.Bounds)
      br = New SolidBrush(Color.Black)
      g.DrawString(strTitle, TabControl1.Font, br, r, sf)
    End If
  End Sub

  Private Sub rbMDT_Click(sender As Object, e As EventArgs) Handles rbMDT.Click
    Cfg.bImpDePose = False
    ImpSelect(Cfg.bImpDePose)
  End Sub

  Private Sub rbMDP_Click(sender As Object, e As EventArgs) Handles rbMDP.Click
    Cfg.bImpDePose = True
    ImpSelect(Cfg.bImpDePose)
  End Sub

  Private Sub cbModeAuto_Click(sender As Object, e As EventArgs) Handles cbModeAuto.Click
    Pgm.cbModeAuto = cbModeAuto.Checked
    ModeSelect(Pgm.cbModeAuto)
  End Sub

  Private Sub ListViewBddSelect()
    Try
      ListViewErp_Ec.SelectedItems.Clear()
      ListViewErp_Ec.Focus()
      'Dim Item As ListViewItem = ListViewBdd.FindItemWithText(lArticleEnCours.Text, False, 0)
      If ListViewErp_Ec.Items.Count > 0 Then
        ListViewErp_Ec.SelectedItems.Clear()
        ListViewErp_Ec.TopItem = ListViewErp_Ec.Items(0)
        ListViewErp_Ec.Items(ListViewErp_Ec.TopItem.Index).Selected = True
      End If
    Catch ex As Exception
      LOG_Text_Add("CATCH ListViewBddSelect : " & ex.Message, True, False)
    End Try
  End Sub

  Private Sub cbAvecApercu_Click(sender As Object, e As EventArgs) Handles cbAvecApercu.Click
    Cfg.cbAvecApercu = cbAvecApercu.Checked
  End Sub

  Private Sub sDateDeCoulee_Click(sender As Object, e As EventArgs)
    'Dim f As New tsNumericKeypad.tsNumericKeypad
    'Dim dr As DialogResult = f.ShowDialog
    'If dr = DialogResult.OK Then
    'sDateDeCoulee.Text = f.Data
    'Cfg.sDateDeCoulee = f.Data
    'End If
  End Sub

  Private Sub bClearLog_Click(sender As Object, e As EventArgs) Handles bClearLog.Click
    LOGText.Text = ""
  End Sub

  Private Sub bVoirJournal_Click(sender As Object, e As EventArgs) Handles bVoirJournal.Click
    Process.Start(AppliFolder & "\logs")
  End Sub



  Private Sub bSaisieQte_Click(sender As Object, e As EventArgs) Handles bSaisieQte.Click
    'Dim f As New tsNumericKeypad.tsNumericKeypad
    'Dim dr As DialogResult = f.ShowDialog
    'If dr = DialogResult.OK Then
    'lQte.Text = Val(f.Data)
    'Automate_Fichier = New tAutomate ' on efface, pas de saisie de faite
    'on met la saisie en debut de liste
    'ListViewBddSelect()
    'End If
  End Sub

  Private Sub bTestAutomate_Click(sender As Object, e As EventArgs) Handles bTestAutomate.Click
    TcpipClose()
    frmTestAutomate.ShowDialog()
    TcpipOpen()
  End Sub

  Private Sub InitInterface()
    lScrutation.Text = "Rép. de scrutation : " & Cfg.sPathScrutation
    cbAvecApercu.Checked = Cfg.cbAvecApercu
    If Cfg.cbDebugNL Then
      lDebugNL.ForeColor = Color.White
      lDebugNL.BackColor = Color.Red
      lDebugNL.Text = "Debug NL activé"
    Else
      lDebugNL.ForeColor = Color.Black
      lDebugNL.BackColor = Color.LightSteelBlue
      lDebugNL.Text = ""
    End If
  End Sub

  Private Sub TraiteReception(i As Integer) ' traite réception transvis, i = numéro de l'automate
    ' traitement dans le thread principal
    Dim ret As Boolean
    Dim watch As Stopwatch = Stopwatch.StartNew()
    Try
      If i = 1 Then
        lMsgRecCEL.Text = Now & " : Reception Automate de : " & Automate(1).MsgID & ":" & Automate(1).MsgPose
        If Val(Automate(1).MsgID) = 1 Then
          watch.Restart()
          '-------------------test du compteur
          'For ii As Integer = 0 To 10 - 1
          'Threading.Thread.Sleep(100)
          'Next
          'watch.Stop()
          'lMessage.Text = "Temps de cycle : " & watch.Elapsed.TotalMilliseconds & " ms"
          '-------------------fin test
          ret = ExecuteFichierErp(Automate(1).MsgPose)
          lMessage.Text = ret
          'ValideImpression("Impression", "1", clsCodesoft.Contenu(0)) ' contenu de 0 c'est l'ID
          If ret Then
            EnvoiAutomate(1, " Impression OK")
          Else
            EnvoiAutomate(0, " Err Impression")
          End If
          watch.Stop()
          lMessage.Text = "Temps de cycle : " & Int(watch.Elapsed.TotalMilliseconds) & " ms"
        End If
      End If
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub EnvoiAutomate(NumMsg As Integer, Message As String)
    Dim pRet As Integer, Msg As String
    Dim GLOIP As IPAddress
    Dim GLOINTPORT As Integer
    Dim bytCommand As Byte() = New Byte() {}
    If Not TcpipIsOpen Then Exit Sub
    Try
      GLOIP = IPAddress.Parse(Cfg.sIpAutomate)
      'GLOIP = IPAddress.Parse("127.0.0.1")
      GLOINTPORT = CInt(Cfg.sPortAutomate)
      sendingUdpClient.Connect(GLOIP, GLOINTPORT)
      Msg = "00:" & Strings.Right("00" & NumMsg, 2)
      bytCommand = Encoding.ASCII.GetBytes(Msg)
      pRet = sendingUdpClient.Send(bytCommand, bytCommand.Length)
      lMsgEmiCEL.Text = Now() & " : Envoi vers Automate de : " & Msg & " : AdresseIp = " & GLOIP.ToString & " : Port = " & GLOINTPORT & Message
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub TcpipOpen()
    Dim i As Integer
    Try
      clsThreads.Add(New System.Threading.Thread(AddressOf ReceiveMessage1))
      'clsThreads.Add(New System.Threading.Thread(AddressOf ReceiveMessage2))
      'clsThreads.Add(New System.Threading.Thread(AddressOf ReceiveMessage3))
      'clsThreads.Add(New System.Threading.Thread(AddressOf ReceiveMessage4))
      'clsThreads.Add(New System.Threading.Thread(AddressOf ReceiveMessage5))
      'clsThreads.Add(New System.Threading.Thread(AddressOf ReceiveMessage6))
      For i = 1 To clsThreads.Count
        If i = 1 Then
          receivingUdpClient1 = New System.Net.Sockets.UdpClient(CInt(Cfg.sPortAutomate) + i)
        ElseIf i = 2 Then
          'receivingUdpClient2 = New System.Net.Sockets.UdpClient(CInt(Cfg.sPortAutomate) + i)
        ElseIf i = 3 Then
          'receivingUdpClient3 = New System.Net.Sockets.UdpClient(CInt(Cfg.sPortAutomate) + i)
        ElseIf i = 4 Then
          'receivingUdpClient4 = New System.Net.Sockets.UdpClient(CInt(Cfg.sPortAutomate) + i)
        ElseIf i = 5 Then
          'receivingUdpClient5 = New System.Net.Sockets.UdpClient(CInt(Cfg.sPortAutomate) + i)
        ElseIf i = 6 Then
          'receivingUdpClient6 = New System.Net.Sockets.UdpClient(CInt(Cfg.sPortAutomate) + i)
        End If
        clsThreads(i - 1).Name = "Automate" & (i).ToString()
        clsThreads(i - 1).IsBackground = True
        clsThreads(i - 1).Start()
      Next
      TcpipIsOpen = True
    Catch Ex As Exception
      Console.WriteLine(Ex.Message)
      'TextBox1.Text = TextBox1.Text & vbCrLf & x.Message
    End Try
  End Sub

  Private Sub TcpipClose()
    Dim pRet As Integer
    Dim tempStr As String = ""
    Dim i As Integer = 0, j As Integer = 0, ligne As Integer = 0
    Dim GLOIP As IPAddress
    Dim GLOINTPORT As Integer
    Dim bytCommand As Byte() = New Byte() {}
    Dim udpClient As New UdpClient
    TcpipIsOpen = False
    Try
      GLOIP = IPAddress.Parse("127.0.0.1")
      For i = 1 To NB_AUTOMATES
        GLOINTPORT = CInt(Cfg.sPortAutomate) + i
        udpClient.Connect(GLOIP, GLOINTPORT)
        bytCommand = Encoding.ASCII.GetBytes("exit")
        pRet = udpClient.Send(bytCommand, bytCommand.Length)
      Next
      ' on attend la fin des threads de réception
      For j = 1 To NB_AUTOMATES
        For i = 1 To 1000 'il faut 100 boucles a peu près
          Application.DoEvents() ' sinon erreur dans la FENETRE EXECUTION du debugger de visual basic
          If clsThreads(j - 1).IsAlive = False Then Exit For
        Next
      Next
      TcpipAbort()
      ' on vérifie que les threads sont arrêtés
      'For j = 1 To NB_AUTOMATES
      'If clsThreads(j - 1).IsAlive Then
      'MsgBox("Thread " & clsThreads(j - 1).Name & " Non arrêté")
      'End If
      'Next
      'TcpipAbort()
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub TcpipAbort()
    Dim i As Integer
    Try
      ' on attend un peu pour que "fin" ait eu le temps de se propager
      'System.Threading.Thread.Sleep(500)
      For i = 1 To clsThreads.Count
        'clsThreads(i - 1).Join()
        clsThreads(i - 1).Abort()
      Next
      clsThreads.Clear()
      TcpipIsOpen = False
    Catch Ex As Exception
      Console.WriteLine(Ex.Message)
    End Try
  End Sub

  Private Sub ReceiveMessage1() ' réception transvis
    Dim Msg() As String
    Try
      ' boucle infinie en attente de message recu, se termine par le message "fin"
      Do
        ' le thread reste bloqué sur la ligne en dessous en attente de message
        Dim receiveBytes As [Byte]() = receivingUdpClient1.Receive(RemoteIpEndPoint)
        Automate(1).IpAdresse = RemoteIpEndPoint.Address.ToString
        Automate(1).MsgIpLng = receiveBytes.Length
        Automate(1).MsgIp = Encoding.ASCII.GetChars(receiveBytes)
        ' Appel d'une fonction dans le thread principal
        If Automate(1).MsgIp = "exit" Then
          Invoke(New Action(Of Integer)(AddressOf TraiteExit), 1)
          receivingUdpClient1.Close()
          Exit Do
        ElseIf Automate(1).MsgIp = "finof" Then
          Invoke(New Action(Of Integer)(AddressOf TraiteFinOf), 1)
        ElseIf Automate(1).MsgIp = "test" Then
          Invoke(New Action(Of Integer)(AddressOf TraiteTest), 1)
          ' Exit Do  sort du loop et arrete le thread 
        Else
          Msg = Split(Automate(1).MsgIp, ":")
          If UBound(Msg) = 1 Then
            Automate(1).MsgID = Msg(0)
            Automate(1).MsgPose = Msg(1)
            'Automate(1).Msg1 = Msg(2)
            'Automate(1).Msg2 = Msg(3)
            Invoke(New Action(Of Integer)(AddressOf TraiteReception), 1)
            '  NewInitialize() ' sinon le thread s'arrête
          End If
        End If
      Loop
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub TraiteExit(i As Integer)
    ' traitement dans le thread principal
    Try
      If i = 1 Then
        Message("UDP exit", True)
      End If
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub TraiteFinOf(i As Integer)
    ' traitement dans le thread principal
    Try
      If i = 1 Then
        Message("UDP FinOf", True)
        InitInterface()
      End If
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub bClearErp_Click(sender As Object, e As EventArgs) Handles bClearErp.Click
    Dim directoryName As String = Cfg.sPathScrutation
    For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
      File.Delete(deleteFile)
    Next
    ListeFichiersErp()
  End Sub

  Private Sub TraiteTest(i As Integer)
    ' traitement dans le thread principal
    Try
      If i = 1 Then
        Message("test", True)
      End If
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub sLectureOf_KeyDown(sender As Object, e As KeyEventArgs) Handles sLectureOf.KeyDown
    If e.KeyCode = Keys.Enter Then
      ' envoi demande a l'ERP en fonction du code lu
      MsgBox("Demande ERP : " & sLectureOf.Text)
      Message("Copie de " & AppliFolder & "\TxtSrc\Data.csv" & " vers " & Cfg.sPathScrutation & "\Data.csv", False)
      FileCopy(AppliFolder & "\TxtSrc\Data.csv", Cfg.sPathScrutation & "\Data.csv")
      If cbModeAuto.CheckState = False Then
        Message("Scrutation", False)
        ListeFichiersErp()
        Message("Traitement", False)
        TraiteFichiersErp()
        If cbAvecApercu.Checked Then TabControl1.SelectTab(Apercu)
        ListeFichiersErp()
      End If
    End If
  End Sub
End Class