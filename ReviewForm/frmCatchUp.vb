Option Strict On
Option Explicit On
'Cher Hill

Public Class frmCatchUp
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim int1, int2 As Integer
        Dim intAnswer As Integer
        If IsNumeric(txt1.Text) And IsNumeric(txt2.Text) Then

            'convert input to integer 
            int1 = CInt(txt1.Text)
            int2 = CInt(txt2.Text)
            If int1 > 0 And int1 <= 10 And
                    int2 > 0 And int2 <= 10 Then

                'Do math
                intAnswer = int1 + int2
                'Output answer to label
                lblOutput.Text = CStr(intAnswer)
            Else
                MsgBox("Please enter #s between 0 and 10")
            End If
        Else
            MsgBox("Please enter only numeric values")

        End If
        txt1.Focus()
        txt2.SelectAll()

    End Sub
End Class
