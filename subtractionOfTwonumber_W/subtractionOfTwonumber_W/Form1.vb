Public Class Form1



    Private Sub diffrenceCalculatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diffrenceCalculatebtn.Click
        Dim firstNumber, secondNumber, result As Double
        firstNumber = firstNumber_txt.Text
        secondNumber = secondNunber_txt.Text

        result = firstNumber - secondNumber
        result_txt.Text = result
    End Sub
End Class
