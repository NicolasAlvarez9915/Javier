Imports System.Diagnostics.CodeAnalysis

Public Class Form1

    Dim numero1
    Dim numero2
    Dim Reset
    Dim operacion = "1"
    Dim aux

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtTablero.Text = "Sintax error" Then
        Else
            numero2 = Convert.ToInt32(TxtTablero.Text)
            RealizarOperacion()
            TxtTablero.Text = numero1
            operacion = "1"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (operacion = "1") Then
            numero1 = Convert.ToInt32(TxtTablero.Text)
        Else
            numero2 = Convert.ToInt32(TxtTablero.Text)
            If numero2 = 0 Then
                numero1 = "Sintax error"
            Else
                numero1 /= numero2
            End If

        End If
        TxtTablero.Text = numero1
        operacion = "Divicion"
        Reset = "1"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "1"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "1"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "2"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "1"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "3"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "3"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "4"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "4"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "5"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "5"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "6"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "6"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "7"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "7"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "8"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "8"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "9"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "9"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (Reset = "1") Then
            TxtTablero.Text = ""
            aux = TxtTablero.Text
            aux += "0"
            TxtTablero.Text = aux
            Reset = "2"
        Else
            aux = TxtTablero.Text
            aux += "0"
            TxtTablero.Text = aux
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If (operacion = "1") Then
            numero1 = Convert.ToInt32(TxtTablero.Text)
        Else
            numero2 = Convert.ToInt32(TxtTablero.Text)
            numero1 += numero2
        End If
        TxtTablero.Text = numero1
        operacion = "Suma"
        Reset = "1"
    End Sub

    Private Sub RealizarOperacion()
        If operacion = "Suma" Then
            numero1 += numero2
        Else
            If operacion = "Resta" Then
                numero1 -= numero2
            Else
                If operacion = "Multiplicacion" Then
                    numero1 *= numero2
                Else
                    If operacion = "Divicion" Then
                        If numero2 = 0 Then
                            numero1 = "Sintax error"
                        Else
                            numero1 /= numero2
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (operacion = "1") Then
            numero1 = Convert.ToInt32(TxtTablero.Text)
        Else
            numero2 = Convert.ToInt32(TxtTablero.Text)
            numero1 -= numero2
        End If
        TxtTablero.Text = numero1
        operacion = "Resta"
        Reset = "1"
    End Sub


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (operacion = "1") Then
            numero1 = Convert.ToInt32(TxtTablero.Text)
        Else
            numero2 = Convert.ToInt32(TxtTablero.Text)
            numero1 *= numero2
        End If
        TxtTablero.Text = numero1
        operacion = "Multiplicacion"
        Reset = "1"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        numero1 = 0
        numero2 = 0
        operacion = "1"
        TxtTablero.Text = ""
    End Sub
End Class
