Public Class frmCalculator

    ''Variables declaration

    Dim marker As Integer
    Dim total As Decimal
    Dim pend As Decimal
    Dim job As String
    Dim operation As String

    ''Button '.'(dot)

    Private Sub btnpoint_Click(sender As Object, e As EventArgs) Handles btnpoint.Click
        If Not txtAnswer.Text.Contains(".") And marker <> 1 Then
            txtAnswer.Text &= "."
        End If
    End Sub

    ''Button '0'

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "0"
            marker = 0
        Else
            txtAnswer.Text &= "0"
        End If
    End Sub

    ''Button '9'

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "9"
            marker = 0
        Else
            txtAnswer.Text &= "9"
        End If
    End Sub

    ''Button '8'

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "8"
            marker = 0
        Else
            txtAnswer.Text &= "8"
        End If
    End Sub

    ''Button '7'

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "7"
            marker = 0
        Else
            txtAnswer.Text &= "7"
        End If
    End Sub

    ''Button '6'

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "6"
            marker = 0
        Else
            txtAnswer.Text &= "6"
        End If
    End Sub

    ''Button '5'

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "5"
            marker = 0
        Else
            txtAnswer.Text &= "5"
        End If
    End Sub

    ''Button '4'

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "4"
            marker = 0
        Else
            txtAnswer.Text &= "4"
        End If
    End Sub

    ''Button '3'

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "3"
            marker = 0
        Else
            txtAnswer.Text &= "3"
        End If
    End Sub

    ''Button '2'

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "2"
            marker = 0
        Else
            txtAnswer.Text &= "2"
        End If
    End Sub

    ''Button '1'

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtAnswer.Text = "0" Or marker = 1 Then
            txtAnswer.Text = "1"
            marker = 0
        Else
            txtAnswer.Text &= "1"
        End If
    End Sub

    ''Button '+'

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click

        If operation = "" Or marker = 1 Then
            total = CDec(txtAnswer.Text)
            operation = "+"
            txtAnswer.Text = Str(total)
        ElseIf operation = "+" Then
            total = CDec(total) + CDec(txtAnswer.Text)
            operation = "+"
            txtAnswer.Text = Str(total)
        ElseIf operation = "-" Then
            total = CDec(total) - CDec(txtAnswer.Text)
            operation = "+"
            txtAnswer.Text = Str(total)
        ElseIf operation = "*" Then
            total = CDec(total) * CDec(txtAnswer.Text)
            operation = "+"
            txtAnswer.Text = Str(total)
        ElseIf operation = "/" Then
            total = CDec(total) / CDec(txtAnswer.Text)
            operation = "+"
            txtAnswer.Text = Str(total)
        End If
        marker = 1
    End Sub

    ''Button '-'

    Private Sub btnsubstract_Click(sender As Object, e As EventArgs) Handles btnsubstract.Click

        If operation = "" Or marker = 1 Then
            total = CDec(txtAnswer.Text)
            operation = "-"
            txtAnswer.Text = Str(total)
        ElseIf operation = "+" Then
            total = CDec(total) + CDec(txtAnswer.Text)
            operation = "-"
            txtAnswer.Text = Str(total)
        ElseIf operation = "-" Then
            total = CDec(total) - CDec(txtAnswer.Text)
            operation = "-"
            txtAnswer.Text = Str(total)
        ElseIf operation = "*" Then
            total = CDec(total) * CDec(txtAnswer.Text)
            operation = "-"
            txtAnswer.Text = Str(total)
        ElseIf operation = "/" Then
            total = CDec(total) / CDec(txtAnswer.Text)
            operation = "-"
            txtAnswer.Text = Str(total)
        End If
        marker = 1
    End Sub

    ''Button '*'

    Private Sub btnmultyply_Click(sender As Object, e As EventArgs) Handles btnmultyply.Click

        If operation = "" Or marker = 1 Then
            total = CDec(txtAnswer.Text)
            operation = "*"
            txtAnswer.Text = Str(total)
        ElseIf operation = "+" Then
            total = CDec(total) + CDec(txtAnswer.Text)
            operation = "*"
            txtAnswer.Text = Str(total)
        ElseIf operation = "-" Then
            total = CDec(total) - CDec(txtAnswer.Text)
            operation = "*"
            txtAnswer.Text = Str(total)
        ElseIf operation = "*" Then
            total = CDec(total) * CDec(txtAnswer.Text)
            operation = "*"
            txtAnswer.Text = Str(total)
        ElseIf operation = "/" Then
            total = CDec(total) / CDec(txtAnswer.Text)
            operation = "*"
            txtAnswer.Text = Str(total)
        End If
        marker = 1
    End Sub

    ''Button '/'

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click

        If operation = "" Or marker = 1 Then
            total = CDec(txtAnswer.Text)
            operation = "/"
            txtAnswer.Text = Str(total)
        ElseIf operation = "+" Then
            total = CDec(total) + CDec(txtAnswer.Text)
            operation = "/"
            txtAnswer.Text = Str(total)
        ElseIf operation = "-" Then
            total = CDec(total) - CDec(txtAnswer.Text)
            operation = "/"
            txtAnswer.Text = Str(total)
        ElseIf operation = "*" Then
            total = CDec(total) * CDec(txtAnswer.Text)
            operation = "/"
            txtAnswer.Text = Str(total)
        ElseIf operation = "/" Then
            total = CDec(total) / CDec(txtAnswer.Text)
            operation = "/"
            txtAnswer.Text = Str(total)
        End If
        marker = 1
    End Sub

    ''Button '='

    Private Sub btnequals_Click(sender As Object, e As EventArgs) Handles btnequals.Click

        If operation = "" Or marker = 1 Then
            total = CDec(txtAnswer.Text)
            operation = ""
            txtAnswer.Text = Str(total)
        ElseIf operation = "+" Then
            total = CDec(total) + CDec(txtAnswer.Text)
            operation = ""
            txtAnswer.Text = Str(total)
        ElseIf operation = "-" Then
            total = CDec(total) - CDec(txtAnswer.Text)
            operation = ""
            txtAnswer.Text = Str(total)
        ElseIf operation = "*" Then
            total = CDec(total) * CDec(txtAnswer.Text)
            operation = ""
            txtAnswer.Text = Str(total)
        ElseIf operation = "/" Then
            total = CDec(total) / CDec(txtAnswer.Text)
            operation = ""
            txtAnswer.Text = Str(total)
        End If
        marker = 1
    End Sub

    ''Button 'C'

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtAnswer.Text = "0"
    End Sub

End Class

