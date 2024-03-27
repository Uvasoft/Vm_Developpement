Module Settings
  Private Const VmDeveloppement_INI As String = "VmDeveloppement.ini"
  Private Const VmDeveloppement_TMP As String = "VmDeveloppement.tmp"
  ' on passe par un .TMP car on ne peut pas modifier directement dans .INI
  Public Function getFichierIni() As String
    getFichierIni = VmDeveloppement_INI
  End Function
  Function SaveVarIni(ByVal Recherche As String, ByVal Valeur As String) As Integer
    ' permet de sauvegarder les var systèmes
    Dim Entet As String, Chaine As String, Compar As String
    Dim ItemTrouve As Boolean
    Dim NumIni As Integer, NumTmp As Integer
    Valeur = Replace(Valeur, ",", "@")
    Entet = "" : Chaine = ""
    Compar = "[" + Trim(Recherche) + "]"
    On Error Resume Next
    NumIni = FreeFile()
    FileOpen(NumIni, AppliFolder & "\" & VmDeveloppement_INI, OpenMode.Input)
    If Err.Number = 0 Then
      NumTmp = FreeFile()
      FileOpen(NumTmp, AppliFolder & "\" & VmDeveloppement_TMP, OpenMode.Output)
      ItemTrouve = False
      Do
        Input(NumIni, Entet)
        If Entet <> "" Then
          Input(NumIni, Chaine)
          If UCase(Entet) = UCase(Compar) Then
            PrintLine(NumTmp, Entet + "," + Valeur)
            ItemTrouve = True
          Else
            PrintLine(NumTmp, Entet + "," + Chaine)
          End If
        End If
      Loop While Not EOF(NumIni)
      If Not ItemTrouve Then
        PrintLine(NumTmp, Compar + "," + Valeur)
      End If
      FileClose(NumIni)
      FileClose(NumTmp)
    Else
      NumTmp = FreeFile()
      FileOpen(NumTmp, AppliFolder & "\" & VmDeveloppement_TMP, OpenMode.Output)
      PrintLine(NumTmp, Compar + "," + Valeur)
      FileClose(NumTmp)
    End If
    FileCopy(AppliFolder & "\" & VmDeveloppement_TMP, AppliFolder & "\" & VmDeveloppement_INI)
    Kill(AppliFolder & "\" & VmDeveloppement_TMP)
  End Function

  Function GetVarIni(ByVal Recherche As String, ByVal Init As String) As String
    Dim Entet As String, Chaine As String, Compar As String
    Dim NumFichier As Integer
    Entet = "" : Chaine = ""
    NumFichier = FreeFile()
    Compar = "[" + Trim(Recherche) + "]"
    On Error GoTo TraiteErreur
    FileOpen(NumFichier, AppliFolder & "\" & VmDeveloppement_INI, OpenMode.Input)
    Do
      Input(NumFichier, Entet)
      If Entet <> "" Then
        Input(NumFichier, Chaine)
        If UCase(Entet) = UCase(Compar) Then
          GetVarIni = Replace(Chaine, "@", ",")
          FileClose(NumFichier)
          Exit Function
        End If
      End If
    Loop While Not EOF(NumFichier)
TraiteErreur:
    FileClose(NumFichier)
    Call SaveVarIni(Recherche, Init)
    GetVarIni = Replace(Init, "@", ",")
  End Function
End Module
