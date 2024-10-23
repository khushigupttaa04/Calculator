Imports System.Runtime.CompilerServices

Public Class Calculator
    Dim x As Double
    Dim y As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If y = "+" Then
            RichTextBox1.Text = Val(x) + Val(RichTextBox1.Text)
        ElseIf y = "-" Then
            RichTextBox1.Text = Val(x) - Val(RichTextBox1.Text)
        ElseIf y = "x" Then
            RichTextBox1.Text = Val(x) * Val(RichTextBox1.Text)
        ElseIf y = "/" Then
            RichTextBox1.Text = Val(x) / Val(RichTextBox1.Text)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.Text = RichTextBox1.Text + "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = RichTextBox1.Text + "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Text = RichTextBox1.Text + "2"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.Text = RichTextBox1.Text + "3"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox1.Text = RichTextBox1.Text + "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.Text = RichTextBox1.Text + "5"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox1.Text = RichTextBox1.Text + "6"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.Text = RichTextBox1.Text + "7"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox1.Text = RichTextBox1.Text + "8"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RichTextBox1.Text = RichTextBox1.Text + "9"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RichTextBox1.Text = RichTextBox1.Text + "."

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        x = RichTextBox1.Text
        y = "+"
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        x = RichTextBox1.Text
        y = "-"
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        x = RichTextBox1.Text
        y = "x"
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        x = RichTextBox1.Text
        y = "/"
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        x = RichTextBox1.Text
        RichTextBox1.Text = Math.Sqrt(Val(x))
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        x = RichTextBox1.Text
        RichTextBox1.Text = Math.Log10(Val(x))
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RichTextBox1.Text = ""
        y = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        x = RichTextBox1.Text
        RichTextBox1.Text = Math.Sin(Val(x))
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        x = RichTextBox1.Text
        RichTextBox1.Text = Math.Cos(Val(x))
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        x = RichTextBox1.Text
        RichTextBox1.Text = Math.Tan(Val(x))
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        x = RichTextBox1.Text
        RichTextBox1.Text = Math.Exp(Val(x))
    End Sub
End Class
