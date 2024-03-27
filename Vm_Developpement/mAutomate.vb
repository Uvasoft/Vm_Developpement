Module mAutomate
  Structure tAutomate
    ' TcpIp
    Dim IpAdresse As String
    Dim MsgIpLng As Integer
    Dim MsgIp As String
    Dim MsgID As String
    Dim MsgPose As String
    'Dim Msg1 As String ' reserve
    'Dim Msg2 As String ' reserve
    ' Emission
    'Dim cptEmission As Integer
    'Dim cptReception As Integer
    'Dim Decalage As Integer
    'Dim DecalageE As Integer
    'Lab en cours
    'Dim MsgLabEnCours As String
  End Structure
  Public Const NB_AUTOMATES = 1
  Public Automate(NB_AUTOMATES) As tAutomate ' on commence à 0 en indice

End Module
