Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class frmTestAutomate
  'Inherits System.Windows.Forms.Form
  ' TCPIP
  Dim Init As Boolean
  Dim IpAdresse As String
  Dim MsgIpLng As Integer
  Dim MsgIp As String
  Dim MsgCodeFonction As String
  Dim MsgNumErreur As String
  Dim MsgNumLigne As String
  'Dim MsgCoeff As String
  'Dim MsgCycleOn As String
  Dim MsgBitDet As BitArray
  ' EMISSION
  Dim Decalage As Integer
  Dim cptEmission
  Dim GLOIP As IPAddress
  Dim GLOINTPORT As Integer
  Dim bytCommand As Byte() = New Byte() {}
  Dim udpClient As New UdpClient
  ' RECEPTION
  Public cptReception
  Public receivingUdpClient As UdpClient
  Public RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
  Public ThreadReceive As System.Threading.Thread
  Dim SocketNO As Integer
  Dim SaveIndex As Integer ' automate 1 à 6 selon combobox
  Public cptWatchDog As Integer = 5

  Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
    'Dim s As String
    's = stxtMessage.Text
    'stxtMessage.Text = s.Substring(s.Length - 4, 4)
    SendMessage()
  End Sub

  Private Sub Demarrer()
    Try
      SocketNO = sPortAutomate.Text + 1
      receivingUdpClient = New System.Net.Sockets.UdpClient(SocketNO)
      ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessage)
      ThreadReceive.Start()
      TextBox1.Enabled = True
      bStop.Enabled = True
      bStart.Enabled = False
      sPortAutomate.ReadOnly = True
      TextBox1.Text = "Attente de Réception sur port " & SocketNO & vbCrLf
    Catch x As Exception
      Console.WriteLine(x.Message)
      TextBox1.Text = TextBox1.Text & vbCrLf & x.Message
    End Try
  End Sub

  Private Sub Arreter()
    Try
      TcpipClose()
      ThreadReceive.Join()
      ThreadReceive.Abort()
      'receivingUdpClient.Close()
      TextBox1.Text = "Attente de réception arrêté"
      'TextBox1.Enabled = False
      bStop.Enabled = False
      bStart.Enabled = True
      'txtIP.Text = ""
      'txtPort.ReadOnly = False
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub bStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStop.Click
    Arreter()
  End Sub

  Private Sub SendMessage()
    Dim pRet As Integer
    Dim tempStr As String = "", tempStr2 As String
    Dim i As Integer = 0, j As Integer = 0, ligne As Integer = 0
    Dim BitDet As BitArray
    Try
      GLOIP = IPAddress.Parse(sIpAutomate.Text)
      If GLOIP.ToString = "127.0.0.1" Or GLOIP.ToString = GetLocalIP() Then
        bytCommand = Encoding.ASCII.GetBytes(stxtMessage.Text)
        GLOINTPORT = sPortAutomate.Text + 1
      Else
        bytCommand = Encoding.ASCII.GetBytes(stxtMessage.Text)
        GLOINTPORT = sPortAutomate.Text
      End If
      udpClient.Connect(GLOIP, GLOINTPORT)
      pRet = udpClient.Send(bytCommand, bytCommand.Length)
      cptEmission += 1
      txtInfo.Text = cptEmission & " Message à " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & vbCrLf & "La longueur du message est de " & pRet
      txtInfo.Text &= vbCrLf + "Le message envoyé sur " & GLOIP.ToString & ":" & GLOINTPORT & " : """
      txtInfo.Text &= Encoding.ASCII.GetChars(bytCommand) & """"
      If chkBit.Checked = True Then
        BitDet = New BitArray(bytCommand)
        txtInfo.Text &= vbCrLf & ligne.ToString & ") "
        For j = 0 To BitDet.Length - 1
          tempStr2 = tempStr
          If BitDet(j) = True Then
            tempStr = " 1" + tempStr2
          Else
            tempStr = " 0" + tempStr2
          End If
          i += 1
          If i = 8 And j <= (BitDet.Length - 1) Then
            ligne += 1 : i = 0
            txtInfo.Text &= tempStr & vbCrLf
            tempStr = "" : tempStr2 = ""
            If j <> (BitDet.Length - 1) Then
              txtInfo.Text &= ligne.ToString & ") "
            End If
          End If
        Next
      End If
    Catch ex As Exception
      txtInfo.Text &= vbCrLf & ex.Message
    End Try
  End Sub

  Public Sub ReceiveMessage()
    Dim Msg() As String
    Try
      Do
        Dim receiveBytes As [Byte]() = receivingUdpClient.Receive(RemoteIpEndPoint)
        'txtIP.Invoke(New Action(Sub() txtIP.Text = RemoteIpEndPoint.Address.ToString))
        IpAdresse = RemoteIpEndPoint.Address.ToString
        MsgBitDet = New BitArray(receiveBytes)
        'Dim strReturnData As String = System.Text.Encoding.Unicode.GetString(receiveBytes)
        MsgIpLng = receiveBytes.Length
        MsgIp = Encoding.ASCII.GetChars(receiveBytes)
        ' Appel direct d'un objet d'une forme 
        ' TextBox1.Invoke(New Action(Sub() TextBox1.Text = s))
        ' Appel d'une fonction dans le thread principal
        If MsgIp = "fin" Then
          receivingUdpClient.Close()
          Debug.Print("fin")
          Exit Do
        End If
        Msg = Split(MsgIp, ":")
        If UBound(Msg) = 1 Then
          MsgCodeFonction = Msg(0)
          MsgNumLigne = Msg(1)
          'MsgCoeff = Msg(2)
          'MsgCycleOn = Msg(3)
        End If
        Invoke(New Action(Of String)(AddressOf TraiteReception), "")
        ' NewInitialize() ' sinon le thread s'arrête
      Loop
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub TraiteReception()
    Dim tempStr As String = "", tempStr2 As String
    Dim s As String = "", i As Integer = 0, j As Integer = 0, line As Integer = 0
    Try
      cptReception += 1
      'cptWatchDog = 5
      s = cptReception & " Message à " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
      s += vbCrLf & "La longueur du message est de " & MsgIpLng
      s += vbCrLf & "Le message reçu est """ & MsgIp & """"
      s += vbCrLf & "Code Fonction : """ & MsgCodeFonction & """"
      s += vbCrLf & "Num Mandrin : """ & MsgNumLigne & """"
      '    s += vbCrLf & "Coeff : """ & MsgCoeff & """"
      '    s += vbCrLf & "Cycle : """ & MsgCycleOn & """"
      If chkBit.Checked = True Then
        s += vbCrLf & line.ToString & ") "
        For j = 0 To MsgBitDet.Length - 1
          If MsgBitDet(j) = True Then
            ' Console.Write("1 ")
            tempStr2 = tempStr : tempStr = " 1" + tempStr2
          Else
            ' Console.Write("0 ")
            tempStr2 = tempStr : tempStr = " 0" + tempStr2
          End If
          i += 1
          If i = 8 And j <= (MsgBitDet.Length - 1) Then
            line += 1
            i = 0 : s = s + tempStr : tempStr = "" : tempStr2 = "" : s = s + vbCrLf
            If j <> (MsgBitDet.Length - 1) Then
              s += line.ToString & ") "
              'Console.WriteLine()
            End If
          End If
        Next
      End If
      s += vbCrLf
      ' Console.WriteLine(s)
      TextBox1.Text = s
      'lTick.Text = s.Substring(s.Length - 6, 3)
      lTick.Text = MsgIp
      lTick.BackColor = Color.LightGreen
    Catch ex As Exception
      TextBox1.Text += vbCrLf & ex.Message
    End Try
  End Sub

  Public Sub NewInitialize()
    Console.WriteLine("Process de Réception réinitialisé")
    ThreadReceive.Abort()
    ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessage)
    ThreadReceive.Start()
  End Sub

  Private Sub frmAutomate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Try
      TcpipClose()
      ThreadReceive.Join()      'Reception
      ThreadReceive.Abort()
      'Emission
      'udpClient.Close()
      '****ThreadReceive.Join()      'Reception
      '****ThreadReceive.Abort()
      'receivingUdpClient.Close()
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try
  End Sub

  Private Sub bQuitter_Click(sender As Object, e As EventArgs) Handles bQuitter.Click
    Me.Close()
  End Sub

  Private Sub bStart_Click(sender As Object, e As EventArgs) Handles bStart.Click
    Demarrer()
  End Sub

  Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
    TextBox1.Text = "Attente de Réception" & vbCrLf
  End Sub

  Private Sub cbWatchDog_CheckedChanged(sender As Object, e As EventArgs) Handles cbWatchDog.CheckedChanged
    If cbWatchDog.Checked Then
      StartWatchDog()
      sTick.BackColor = Color.LightGreen
    Else
      tWatchDog.Stop()
      sTick.BackColor = Color.LightGray
    End If
  End Sub

  Private Sub StartWatchDog()
    If Val(sWatchDog.Text) < 50 Then
      MsgBox("WatchDog doit être > 50")
      Exit Sub
    End If
    'stxtMessage.Text = Decalage
    tWatchDog.Interval = sWatchDog.Text
    tWatchDog.Enabled = True
    tWatchDog.Start()
  End Sub

  Private Sub tWatchDog_Tick(sender As Object, e As EventArgs) Handles tWatchDog.Tick
    sTick.Text = IIf(sTick.Text = "/", "\", "/")
    SendMessage()
    RuptureCommIp()
  End Sub

  Private Sub RuptureCommIp()
    If Not cbWatchDog.Checked Then Exit Sub
    cptWatchDog -= 1
    If cptWatchDog = 0 Then
      cptWatchDog = 5
      lTick.BackColor = Color.Red
    End If
  End Sub

  Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
    e.Handled = True
  End Sub

  Private Sub TcpipClose()
    Dim pRet As Integer
    'Dim tempStr As String = ""
    Dim i As Integer '= 0, j As Integer = 0, ligne As Integer = 0
    Dim GLOIP As IPAddress
    Dim GLOINTPORT As Integer
    Dim bytCommand As Byte() = New Byte() {}
    Dim udpClient As New UdpClient
    Try
      GLOIP = IPAddress.Parse("127.0.0.1")
      GLOINTPORT = CInt(Cfg.sPortAutomate + 1)
      udpClient.Connect(GLOIP, GLOINTPORT)
      bytCommand = Encoding.ASCII.GetBytes("fin")
      pRet = udpClient.Send(bytCommand, bytCommand.Length)
      ' on attend la fin des threads de réception
      For i = 1 To 1000 'il faut 100 boucles a peu près
        Application.DoEvents() ' sinon erreur dans la FENETRE EXECUTION du debugger de visual basic
        If ThreadReceive.IsAlive = False Then Exit For
      Next
      ' on attend la fin du thread de réception
      'For i = 1 To 1000 'il faut 100 boucles a peu près
      'Application.DoEvents() ' sinon erreur dans la FENETRE EXECUTION du debugger de visual basic
      'If ThreadReceive.IsAlive = False Then
      'Exit For
      'End If
      'Next
      'ThreadReceive.Abort()
      ' on vérifie que le thread est arrêté
      'If ThreadReceive IsNot Nothing Then
      'MsgBox("ThreadReceive  " & ThreadReceive.Name & " Non arrêté " & ThreadReceive.ThreadState)
      'End If
    Catch ex As Exception
      'txtInfo.Text &= vbCrLf &
      MsgBox(ex.Message)
    End Try
  End Sub

  Private Sub frmTestAutomate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'RECEPTION
    Init = True
    TextBox1.Text = "" ' init
    sPortAutomate.Text = Cfg.sPortAutomate
    sIpAutomate.Text = Cfg.sIpAutomate
    Demarrer()
    Init = False
  End Sub

  Public Function CheckIpAvailable(Ip As String) As Boolean
    Return My.Computer.Network.Ping(Ip, 100)
  End Function

  Private Sub bPing_Click(sender As Object, e As EventArgs) Handles bPing.Click
    If CheckIpAvailable(sIpAutomate.Text) Then
      sIpAutomate.BackColor = Color.Green
      sIpAutomate.ForeColor = Color.White
    Else
      sIpAutomate.BackColor = Color.Red
      sIpAutomate.ForeColor = Color.White
    End If
  End Sub
End Class