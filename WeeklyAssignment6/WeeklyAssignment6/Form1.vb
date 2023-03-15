Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbAverage.Text = ""
    End Sub

    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        Dim input As Decimal
        Dim inputTxt As String
        Dim askAgain As Boolean = True
        lsbInternet.Items.Clear()
        While askAgain
            inputTxt = InputBox("Enter Internet Speed", "Internet Speed", "")
            If inputTxt = "" Then
                Exit While
            End If
            If IsNumeric(inputTxt) Then
                input = Convert.ToDecimal(inputTxt)
                If input >= 0 Then
                    lsbInternet.Items.Add(Math.Round(input, 2, MidpointRounding.AwayFromZero).ToString())
                    If lsbInternet.Items.Count = 10 Then

                        askAgain = False
                    End If
                Else
                    MsgBox("Value Is Negative", 0)
                End If
            Else
                MsgBox("Enter A Numeric Value", 0)
            End If
        End While
        Dim sum As Decimal = 0D
        Dim average As Decimal = 0D
        For index As Integer = 1 To lsbInternet.Items.Count
            sum += Convert.ToDecimal(lsbInternet.Items(index - 1))
        Next
        If lsbInternet.Items.Count > 0 Then
            average = sum / lsbInternet.Items.Count
        End If
        lbAverage.Text = Math.Round(average, 2, MidpointRounding.AwayFromZero).ToString() + " Mbps"
    End Sub
End Class
