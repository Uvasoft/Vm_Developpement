Module SettingsFlash
  Private Const VmDeveloppementFLASH_INI As String = "VmDeveloppementFLASH.ini"
  Private Const VmDeveloppementFLASH_TMP As String = "VmDeveloppementFLASH.tmp"
  ' on passe par un .TMP car on ne peut pas modifier directement dans .INI
  Function SaveVarFlash(ByVal Recherche As String, ByVal Valeur As String) As Integer
    ' permet de sauvegarder les var systèmes
    Dim Entet As String, Chaine As String, Compar As String
    Dim ItemTrouve As Boolean
    Dim NumIni As Integer, NumTmp As Integer
    Valeur = Replace(Valeur, ",", "@")
    Entet = "" : Chaine = ""
    Compar = "[" + Trim(Recherche) + "]"
    On Error Resume Next
    NumIni = FreeFile()
    FileOpen(NumIni, AppliFolder & "\" & VmDeveloppementFLASH_INI, OpenMode.Input)
    If Err.Number = 0 Then
      NumTmp = FreeFile()
      FileOpen(NumTmp, AppliFolder & "\" & VmDeveloppementFLASH_TMP, OpenMode.Output)
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
      FileOpen(NumTmp, AppliFolder & "\" & VmDeveloppementFLASH_TMP, OpenMode.Output)
      PrintLine(NumTmp, Compar + "," + Valeur)
      FileClose(NumTmp)
    End If
    FileCopy(AppliFolder & "\" & VmDeveloppementFLASH_TMP, AppliFolder & "\" & VmDeveloppementFLASH_INI)
    Kill(AppliFolder & "\" & VmDeveloppementFLASH_TMP)
  End Function

  Function GetVarFlash(ByVal Recherche As String, ByVal Init As String) As String
    Dim Entet As String, Chaine As String, Compar As String
    Dim NumFichier As Integer
    Entet = "" : Chaine = ""
    NumFichier = FreeFile()
    Compar = "[" + Trim(Recherche) + "]"
    On Error GoTo TraiteErreur
    FileOpen(NumFichier, AppliFolder & "\" & VmDeveloppementFLASH_INI, OpenMode.Input)
    Do
      Input(NumFichier, Entet)
      If Entet <> "" Then
        Input(NumFichier, Chaine)
        If UCase(Entet) = UCase(Compar) Then
          GetVarFlash = Replace(Chaine, "@", ",")
          FileClose(NumFichier)
          Exit Function
        End If
      End If
    Loop While Not EOF(NumFichier)
TraiteErreur:
    FileClose(NumFichier)
    Call SaveVarFlash(Recherche, Init)
    GetVarFlash = Replace(Init, "@", ",")
  End Function
End Module
