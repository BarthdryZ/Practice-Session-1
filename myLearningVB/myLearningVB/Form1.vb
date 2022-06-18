Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim add As Decimal = CDec(TextBox1.Text) + CDec(TextBox2.Text)
        MsgBox("The sum is " + CStr(add), MsgBoxStyle.Information, "Result")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CDec(TextBox1.Text) > CDec(TextBox2.Text) Then
            Dim subract As Decimal = CDec(TextBox1.Text) - CDec(TextBox2.Text)
            MsgBox("The difference is " + CStr(subract), MsgBoxStyle.Information, "Result")
        Else
            Dim subract As Decimal = CDec(TextBox2.Text) - CDec(TextBox1.Text)
            MsgBox("The difference is " + CStr(subract), MsgBoxStyle.Information, "Result")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mult As Decimal = CDec(TextBox1.Text) * CDec(TextBox2.Text)
        MsgBox("The product is " + CStr(mult), MsgBoxStyle.Information, "Result")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim div As Decimal = CDec(TextBox1.Text) / CDec(TextBox2.Text)
        MsgBox("The quotient is " + CStr(div), MsgBoxStyle.Information, "Result")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
End Class
