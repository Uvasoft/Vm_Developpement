Imports System.Net
Module Librairie
  Structure tPgm
    Public TexteMode As Integer
    Public FinInit As Integer
    Public Cpt As Long
    Public cbModeAuto As Boolean
  End Structure
  Public Pgm As tPgm

  Structure tTempo
    Dim Cpt As Long
    Dim bEnCours As Boolean
  End Structure
  Public Tempo As tTempo
  Public ArretOperateur As Integer

  Public DerQte As Integer
  ' variable PrevisuManu
  ' pas de chgt d'etat du status, pas d'impression
  Public PrevisuManu As Boolean
  Public SpoolerForceClose As Boolean
  Public ErrorMemory As Boolean

  Public Structure OSVERSIONINFOEX
    Dim dwOSVersionInfoSize As Long
    Dim dwMajorVersion As Long
    Dim dwMinorVersion As Long
    Dim dwBuildNumber As Long
    Dim dwPlatformID As Long
    Dim szCSDVersion As String
    Dim dwServicePackMajor As Integer
    Dim dwServicePackMinor As Integer
    Dim wSuiteMask As Integer
    Dim wProductType As Byte
    Dim wReserved As Byte
  End Structure

  Public Declare Function GetVersionExA Lib "kernel32" (ByVal lpVersionInformation As OSVERSIONINFOEX) As Integer

  Public Enum SetHWND 'WndInsertAfterEnum
    HWND_BOTTOM = 1
    HWND_BROADCAST = &HFFFF&
    HWND_DESKTOP = 0
    HWND_NOTOPMOST = -2
    HWND_TOP = 0
    HWND_TOPMOST = -1
  End Enum

  Public Enum SetSWP 'SetWindowPosFlagsEnum
    SWP_FRAMECHANGED = &H20
    SWP_DRAWFRAME = SWP_FRAMECHANGED
    SWP_HIDEWINDOW = &H80
    SWP_NOACTIVATE = &H10
    SWP_NOCOPYBITS = &H100
    SWP_NOMOVE = &H2
    SWP_NOOWNERZORDER = &H200
    SWP_NOREDRAW = &H8
    SWP_NOREPOSITION = SWP_NOOWNERZORDER
    SWP_NOSIZE = &H1
    SWP_NOZORDER = &H4
    SWP_SHOWWINDOW = &H40
  End Enum

  'Public Declare Function SafeArrayGetDim Lib "oleaut32.dll" (ByRef saArray() As Any) As Long
  Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As SetHWND,
                             ByVal x As Long, ByVal y As Long, ByVal cx As Long,
                           ByVal cy As Long, ByVal wFlags As SetSWP) As Long

  Public Function DEVMODE() As Boolean
    '  DEVMODE = False ' fake pour éviter erreur compil
    ' jmw Debug.Assert(Not TestIde(DEVMODE()))
    'DEVMODE = True
#If (DEBUG) Then
    Return True
#Else
    Return False
#End If
  End Function

  Private Function TestIde(ByVal test As Boolean) As Boolean
    Return True
  End Function
  '
  'Then, to get a form to stay on top...
  Public Sub WinTop(ByVal form_hwnd As Long, ByVal Top As Boolean)
    If Top Then
      SetWindowPos(form_hwnd, SetHWND.HWND_TOPMOST, 0, 0, 0, 0, SetSWP.SWP_NOSIZE Or SetSWP.SWP_NOMOVE)
    Else
      'and to stop a form from being always on top...
      SetWindowPos(form_hwnd, SetHWND.HWND_NOTOPMOST, 0, 0, 0, 0, SetSWP.SWP_NOSIZE Or SetSWP.SWP_NOMOVE)
    End If
  End Sub

  Public Function RepInstallation() As String
    RepInstallation = Application.StartupPath
    RepInstallation = Replace(RepInstallation, "\bin\Release", "")
    RepInstallation = Replace(RepInstallation, "\bin\Debug", "")
  End Function

  'Public Function GetrbConnection() As String
  'If Cfg.rbConnection = 1 Then
  'Return "Microsoft.JET.OLEDB.4.0"
  'ElseIf Cfg.rbConnection = 2 Then
  'Return "Microsoft.ACE.OLEDB.12.0"
  'Else
  'Return "Microsoft.ACE.OLEDB.12.0" 'jmw ?
  'End If
  'End Function

  Function GetLocalIP() As String
    Dim IpAdd As IPAddress
    Dim IPList As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
    For Each IPAdd In IPList.AddressList
      'Only return IPv4 routable IPs
      'If (IPAdd.AddressFamily = Sockets.AddressFamily.InterNetwork) AndAlso (Not IsPrivateIP(IPAdd.ToString)) Then
      If (IpAdd.AddressFamily = Sockets.AddressFamily.InterNetwork) Then
        Return IpAdd.ToString
      End If
    Next
    Return ""
  End Function
End Module
