Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "+"
        Dim num1 As Double = System.Convert.ToDouble(TextBox1.Text)
        Dim num2 As Double = System.Convert.ToDouble(TextBox2.Text)
        Dim result As Double = num1 + num2
        Label2.Text = "=" + System.Convert.ToString(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "-"
        Dim num1 As Double = System.Convert.ToDouble(TextBox1.Text)
        Dim num2 As Double = System.Convert.ToDouble(TextBox2.Text)
        Dim result As Double = num1 - num2
        Label2.Text = "=" + System.Convert.ToString(result)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "*"
        Dim num1 As Double = System.Convert.ToDouble(TextBox1.Text)
        Dim num2 As Double = System.Convert.ToDouble(TextBox2.Text)
        Dim result As Double = num1 * num2
        Label2.Text = "=" + System.Convert.ToString(result)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "/"
        Dim num1 As Double = System.Convert.ToDouble(TextBox1.Text)
        Dim num2 As Double = System.Convert.ToDouble(TextBox2.Text)
        Dim result As Double = num1 / num2
        Label2.Text = "=" + System.Convert.ToString(result)
    End Sub
End Class
