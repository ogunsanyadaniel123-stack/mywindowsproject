Public Class Form1

    Private Sub sumCalculatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sumCalculatebtn.Click
        Dim firstNumber, secondNumber, result As Double
        firstNumber = firstNumber_txt.Text
        secondNumber = secondNumber_txt.Text

        result = firstNumber / secondNumber
        result_txt.Text = result
    End Sub
End Class
