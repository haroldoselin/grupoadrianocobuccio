Public Class Helper

    Public Shared Function SomenteNumeros(Keyascii As Short) As Short
        Dim iNumero As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            iNumero = 0
        Else
            iNumero = Keyascii
        End If

        Select Case Keyascii
            Case 8
                iNumero = Keyascii
            Case 13
                iNumero = Keyascii
            Case 32
                iNumero = Keyascii
        End Select

        Return iNumero

    End Function

End Class
