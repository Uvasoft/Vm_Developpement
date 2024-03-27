Imports System.IO
Imports System.Net

Public Class frmConfig
  Public Enum eBouton
    bAucun = 10
    bOkOnly = vbOKOnly
    bOkCancel = vbOKCancel
  End Enum

  Public Sub LireConfig()
    Try
      Dim i As Integer, s1 As String ', s As String
      Dim tmp() As String
      Cfg.bInitOk = True
      'onglet général
      sMdp.Text = GetVarIni("sMdp", Cfg.sMdp)
      Cfg.sMdp = sMdp.Text
      cbMdpArret.Checked = GetVarIni("cbMdpArret", cbMdpArret.Checked)
      Cfg.cbMdpArret = cbMdpArret.Checked
      cbDebug.Checked = GetVarIni("cbDebug", cbDebug.Checked)
      Cfg.cbDebug = cbDebug.Checked
      Cfg.cbDebugNL = GetVarIni("cbDebugNL", True)
      cbDebugNL.Checked = Cfg.cbDebugNL
      'onglet imprimantes
      sImpMDP.Text = GetVarIni("sImpMDP", "Select Imp. de pose")
      Cfg.sImpMDP = sImpMDP.Text
      sImpMDT.Text = GetVarIni("sImpMDT", "Select Imp. de table")
      Cfg.sImpMDT = sImpMDT.Text
      ' onglet Config du Poste
      Cfg.sListeSite = GetVarIni("sListeSite", "MIOS|MIOS1")
      sListeSite.Text = Cfg.sListeSite
      Cfg.SiteCourant = GetVarIni("SiteCourant", "MIOS")
      Cfg.sListeOperateur1 = GetVarIni("sListeOperateur1", "OPE1|OPE2")
      sListeOperateur1.Text = Cfg.sListeOperateur1
      Cfg.Operateur1Courant = GetVarIni("Operateur1Courant", "OPE1")
      Cfg.sListeOperateur2 = GetVarIni("sListeOperateur2", "OPE1|OPE2")
      sListeOperateur2.Text = Cfg.sListeOperateur2
      Cfg.Operateur2Courant = GetVarIni("Operateur2Courant", "OPE2")
      'onglet Scrutation
      sPathScrutation.Text = GetVarIni("sPathScrutation", AppliFolder & "\Scrutation")
      Cfg.sPathScrutation = sPathScrutation.Text
      'onglet automate
      sIpAutomate.Text = GetVarIni("sIpAutomate", "192.168.1.175")
      Cfg.sIpAutomate = sIpAutomate.Text
      Cfg.sPortAutomate = 11000
    Catch ex As Exception
      MsgBox("Erreur LireConfig : " & ex.Message)
    End Try
  End Sub

  Public Sub LireConfigFlash()
    Try
      ' MAIN
      Cfg.bImpDePose = GetVarFlash("bImpDePose", True)
      ' Cfg.cbModeAuto = GetVarFlash("cbModeAuto", True)
      Cfg.ImpCourante = GetVarFlash("ImpCourante", "")
      ' Cfg.ArticleCourant = GetVarFlash("ArticleCourant", "")
      Cfg.cbAvecApercu = GetVarFlash("cbAvecApercu", False)
      Cfg.sDateDeCoulee = GetVarFlash("sDateDeCoulee", "")
    Catch ex As Exception
      MsgBox("Erreur LireConfigFlash : " & ex.Message)
    End Try
  End Sub

  Public Function EcrireConfig() As Boolean
    Dim s1 As String
    Dim Modify As Boolean = False
    'onglet général
    Call SaveVarIni("sMdp", sMdp.Text)
    Cfg.sMdp = sMdp.Text
    Call SaveVarIni("cbMdpArret", cbMdpArret.Checked)
    Cfg.cbMdpArret = cbMdpArret.Checked
    'onglet codesoft
    Cfg.cbDebugNL = cbDebugNL.Checked
    Call SaveVarIni("cbDebugNL", Cfg.cbDebugNL)
    'onglet imprimantes
    Call SaveVarIni("sImpMDP", Cfg.sImpMDP)
    Call SaveVarIni("sImpMDT", Cfg.sImpMDT)
    If Modify Then
      Call frmMessage.Message("Veuillez redémarrer le programme pour prendre en compte les modifications")
      frmMessage.ShowDialog()
    End If

    'Config du Poste
    Cfg.sListeSite = sListeSite.Text
    Call SaveVarIni("sListeSite", Cfg.sListeSite)
    Call SaveVarIni("SiteCourant", Cfg.SiteCourant)
    '
    Cfg.sListeOperateur1 = sListeOperateur1.Text
    Call SaveVarIni("sListeOperateur1", Cfg.sListeOperateur1)
    Call SaveVarIni("Operateur1Courant", Cfg.Operateur1Courant)
    '
    Cfg.sListeOperateur2 = sListeOperateur2.Text
    Call SaveVarIni("sListeOperateur2", Cfg.sListeOperateur2)
    Call SaveVarIni("Operateur2Courant", Cfg.Operateur2Courant)
    'onglet scrutation
    Call SaveVarIni("sPathScrutation", sPathScrutation.Text)
    Cfg.sPathScrutation = sPathScrutation.Text
    'onglet Automate
    Call SaveVarIni("sIpAutomate", sIpAutomate.Text)
    Cfg.sIpAutomate = sIpAutomate.Text
    Return True
  End Function


  Private Sub bQuitter_Click(sender As Object, e As EventArgs) Handles bQuitter.Click
    Dim ret As Boolean
    ret = EcrireConfig()
    If ret Then Me.Close()
  End Sub

  Public Function EcrireConfigFlash() As Boolean
    ' MAIN
    Call SaveVarFlash("bImpDePose", Cfg.bImpDePose)
    'Call SaveVarFlash("cbModeAuto", Cfg.cbModeAuto)
    Call SaveVarFlash("ImpCourante", Cfg.ImpCourante)
    ' Call SaveVarFlash("ArticleCourant", Cfg.ArticleCourant)
    Call SaveVarFlash("cbAvecApercu", Cfg.cbAvecApercu)
    Call SaveVarFlash("sDateDeCoulee", Cfg.sDateDeCoulee)
    'onglet automate
    'onglet Transvis
    Call SaveVarIni("sIpAutomate", sIpAutomate.Text)
    Cfg.sIpAutomate = sIpAutomate.Text
    Return True
  End Function

  Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
    Me.Close()
    frmMain.Show()
  End Sub

  Private Sub ListeImprimante()
    Try
      If NL_PrintEngine.Initialized = False Then
        'MsgBox ("Impossible d'afficher la liste [imprimantes disponibles] car codesoft est absent")
        LstPrinters.Items.Clear()
        LstPrinters.Items.Add("IMPOSSIBLE d'afficher")
        LstPrinters.Items.Add("la liste des imp.")
        LstPrinters.Items.Add("car NiceLabel n'est pas lancé")
        Exit Sub
      End If
      ''''Nombre1 = Classe.AppCs.PrinterSystem.Printers(Tmp1).Count
      LstPrinters.Items.Clear()
      For Each NL_Printer In NL_PrintEngine.Printers
        LstPrinters.Items.Add(NL_Printer.Name)
      Next
    Catch Ex As Exception
      MsgBox(Ex.Message)
    End Try
  End Sub

  Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'LireConfig()
    ListeImprimante()
    TabControl1.TabPages.Remove(TabPageNiceLabel)
    TabControl1.TabPages.Remove(ConfigPoste)
    TabControl1.TabPages.Remove(TabPageBdd)
  End Sub

  Private Sub bRepApp_Click(sender As Object, e As EventArgs) Handles bRepApp.Click
    Process.Start(RepInstallation)
  End Sub

  Private Sub bRepDonnees_Click(sender As Object, e As EventArgs) Handles bRepDonnees.Click
    Process.Start(AppliFolder)
  End Sub

  Private Sub bAddField_Click(sender As Object, e As EventArgs) Handles bAddField.Click
    'Dim NewItem As ListViewItem = lvFields.Items.Insert(lvFields.SelectedIndices(0), sFieldDsc.Text)
    Try
      Dim tmp() As String = Split(sFieldDsc.Text, ";")
      If UBound(tmp) <> 2 Then
        MsgBox("Erreur de format : NomChamp;Valeur;Largeur Display")
        Exit Sub
      End If
      Dim NewItem As ListViewItem = lvFields.Items.Add(tmp(0))
      NewItem.SubItems.Add(tmp(1))
      NewItem.SubItems.Add(tmp(2))
      Renumerote()
    Catch ex As Exception
      MsgBox("AddField : " & ex.Message)
    End Try
  End Sub

  Private Sub bSuppField_Click(sender As Object, e As EventArgs) Handles bSuppField.Click
    Try
      If lvFields.SelectedItems.Count = 0 Then
        MsgBox("Veuillez sélectionner un e cellule dans la premiere colonne")
      Else
        lvFields.SelectedItems(0).Remove()
      End If
      Renumerote()
    Catch ex As Exception
      MsgBox("SuppField : " & ex.Message)
    End Try
  End Sub

  Private Sub bInsertField_Click(sender As Object, e As EventArgs) Handles bInsertField.Click
    Try
      If lvFields.SelectedItems.Count = 0 Then
        MsgBox("Veuillez sélectionner un Champ")
        Exit Sub
      End If
      Dim tmp() As String = Split(sFieldDsc.Text, ";")
      If UBound(tmp) <> 2 Then
        MsgBox("Erreur de format : NomChamp;Valeur;Largeur Display")
        Exit Sub
      End If
      Dim item As New ListViewItem
      item.Text = tmp(0)
      Dim NewItem As ListViewItem = lvFields.Items.Insert(lvFields.SelectedItems(0).Index, item)
      NewItem.SubItems.Add(tmp(1))
      NewItem.SubItems.Add(tmp(2))
      Renumerote()
    Catch ex As Exception
      MsgBox("InsertField : " & ex.Message)
    End Try
  End Sub

  Private Sub Renumerote()
    Try
      Dim Item As ListViewItem
      For Each Item In lvFields.Items
        Item.Text = "Fields" & (Item.Index + 1).ToString
      Next
    Catch ex As Exception
      MsgBox("Renumerote : " & ex.Message)
    End Try
  End Sub

  Private Sub lvFields_Click(sender As Object, e As EventArgs) Handles lvFields.Click
    sFieldDsc.Text = lvFields.SelectedItems(0).Text & ";" & lvFields.SelectedItems(0).SubItems(1).Text & ";" & lvFields.SelectedItems(0).SubItems(2).Text
  End Sub

  Private Sub bModifyField_Click(sender As Object, e As EventArgs) Handles bModifyField.Click
    Try
      Dim Tmp() As String = Split(sFieldDsc.Text, ";")
      If UBound(Tmp) <> 2 Then
        MsgBox("Erreur de format : NomChamp;Valeur;Largeur Display")
        Exit Sub
      End If
      lvFields.SelectedItems(0).Text = Tmp(0)
      lvFields.SelectedItems(0).SubItems(1).Text = Tmp(1)
      lvFields.SelectedItems(0).SubItems(2).Text = Tmp(2)
    Catch ex As Exception
      MsgBox("Modifier : " & ex.Message)
    End Try
  End Sub

  Private Sub bVoir_Click(sender As Object, e As EventArgs) Handles bVoir.Click
    Process.Start("notepad", AppliFolder & "\" & getFichierIni())
  End Sub

  Private Sub bSelMDP_Click(sender As Object, e As EventArgs) Handles bSelMDP.Click
    If LstPrinters.SelectedIndex = -1 Then
      Call frmMessage.Message("Veuillez sélectionner une imprimante dans la liste")
      frmMessage.ShowDialog()
      Exit Sub
    Else
      sImpMDP.Text = LstPrinters.SelectedItem
      Cfg.sImpMDP = sImpMDP.Text
    End If
  End Sub

  Private Sub bSelMDT_Click(sender As Object, e As EventArgs) Handles bSelMDT.Click
    If LstPrinters.SelectedIndex = -1 Then
      Call frmMessage.Message("Veuillez sélectionner une imprimante dans la liste")
      frmMessage.ShowDialog()
      Exit Sub
    Else
      sImpMDT.Text = LstPrinters.SelectedItem
      Cfg.sImpMDT = sImpMDT.Text
    End If
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

  Private Sub bSelPathScrutation_Click(sender As Object, e As EventArgs) Handles bSelPathScrutation.Click
    SelPathScrutation()
  End Sub

  Private Sub SelPathScrutation()
    ' First create a FolderBrowserDialog object
    Dim FolderBrowserDialog1 As New FolderBrowserDialog

    ' Then use the following code to create the Dialog window
    ' Change the .SelectedPath property to the default location
    With FolderBrowserDialog1
      ' Desktop is the root folder in the dialog.
      .RootFolder = Environment.SpecialFolder.Desktop
      ' Select the C:\Windows directory on entry.
      '.SelectedPath = IIf(Trim(sRepTxt.Text) = "", PilotAutoFolder, sRepTxt.Text)
      .SelectedPath = sPathScrutation.Text
      ' Prompt the user with a custom message.
      .Description = "Sélectionner le répertoire de scrutation"
      If .ShowDialog = DialogResult.OK Then
        ' Display the selected folder if the user clicked on the OK button.
        sPathScrutation.Text = .SelectedPath
      End If
    End With
  End Sub

  Private Sub bRaffraichir_Click(sender As Object, e As EventArgs) Handles bRaffraichir.Click
    'ListViewBdd.FullRowSelect = True
    'ListViewBdd.HideSelection = False
    'ListViewBdd.MultiSelect = False
    'ListViewBdd.Sorting = SortOrder.Ascending
    ListeFichiersAutomate()
  End Sub

  Private Sub ListeFichiersAutomate()
    Try
      'Dim Repertoire As New IO.DirectoryInfo(Cfg.sRepTxtDst)
      Dim Repertoire As New IO.DirectoryInfo(Cfg.sPathScrutation)
      Dim ListeFichier As IO.FileInfo() = Repertoire.GetFiles("*.csv")
      Dim Fichier As IO.FileInfo
      'list the names of all files in the specified directory
      ListViewBdd.Items.Clear()
      For Each Fichier In ListeFichier
        Dim item As New ListViewItem
        item.Text = Fichier.Name
        ListViewBdd.Items.Add(item)
      Next
      ListViewBdd.Refresh()
    Catch ex As Exception
      'LOG_Text_Add("CATCH ListeFichiersAutomate : " & ex.Message, True, False)
      'File1.ToolTipText = fConfig.sPathTexteMode & "\" & File1.Pattern
    End Try
  End Sub
End Class