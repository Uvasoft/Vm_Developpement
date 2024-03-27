Imports System.Net
Module Variables
  Public Const ElaInnovation_BMP As String = "VmDeveloppement.bmp"
  Public Const ElaInnovationDEBUG As Boolean = False
  Public Const Uvasoft As String = "Uvasoft" + vbCrLf + "Tél.: 06 41 68 28 39" & vbCrLf & "e-mail : jmarc.weber@uvasoft.fr"
  Public AppliFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Uvasoft\VmDeveloppement"
  Public NLVersionTrouve As Integer
  Public Enum eSortieMdp
    MDPpourCONFIG = 1
    MDPpourQUITTER = 2
  End Enum

  Structure tPictureBoxSize 'preview
    Dim bPreviewSize As Boolean
    Public Top As Integer
    Public Left As Integer
    Public Height As Integer
    Public Width As Integer
  End Structure
  Public pbSize As tPictureBoxSize
  Structure tFieldsStruc
    Public NomChamp As String
    Public NomVariable As String
    Public TailleChamp As String
  End Structure
  Structure tConfig
    Public bInitOk As Boolean
    'onglet général
    Public sMdp As String
    Public cbMdpArret As Boolean
    Public bMdpOk As Boolean
    Public cbDebug As Boolean
    ' onglet imprimantes
    Public sImpMDP As String
    Public sImpMDT As String
    'onglet BDD
    'Public sFieldDsc As String
    'Public Fields() As String
    'Public FieldsStruc() As tFieldsStruc
    'Public sFichierMdb As String
    'Public rbConnection As String
    ' onglet txt
    'Public sRepTxtSrc As String

    '  Public EffVar As Boolean
    '  Public Plus() As String ' tableau 5 premiers = boolean, 5 derniers = valeur
    ' MAIN 
    Public bImpDePose As Boolean
    'Public cbModeAuto As Boolean
    Public ImpCourante As String
    'Public ArticleCourant As String
    Public cbDebugNL As Boolean
    Public cbAvecApercu As Boolean
    ' Config du poste
    Public SiteCourant As String
    Public sListeSite As String
    Public Operateur1Courant As String
    Public sListeOperateur1 As String
    Public Operateur2Courant As String
    Public sListeOperateur2 As String
    Public sDateDeCoulee As String
    ' onglet Scrutation
    Public sPathScrutation As String
    ' onglet automate
    Public sPortAutomate
    Public sIpAutomate
  End Structure

  Public Cfg As tConfig
  Public RepInst As String

  'Public Printers(PRINTERS_MAX) As String

  'Structure tAutomate
  'Public CodeArticle As String
  'Public OuiNon As String
  'Public Site As String
  'Public Operateur1 As String
  'Public Operateur2 As String
  'Public DateCoulee As String
  'End Structure

  ' Public Automate_Fichier As tAutomate

  '  Public fApercu As Boolean
  '  Public bddNomFichier As String
  '  Public Orientation As Integer
  '  Public bddReference As String
  '  Public bddCodeFamille As String
  '  Public bddCodeSousFamille As String

  Public NL_PrintEngine As NiceLabel.SDK.IPrintEngine
  Public NL_Printer As NiceLabel.SDK.IPrinter
  Public NL_Label As NiceLabel.SDK.ILabel
  Public NL_labelPreviewSettings As NiceLabel.SDK.ILabelPreviewSettings

  Public Bdd(1, 1) As String
  Public bImpFound As Boolean
  Public bArtFound As Boolean
End Module
