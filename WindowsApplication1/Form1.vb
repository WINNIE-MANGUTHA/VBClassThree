Public Class Form1

    Private Sub BtnAssgn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAssgn.Click
        If TextMarks.Text <= 50 Then
            TextGrade.Text = "F"
            TextComment.Text = "fail"
        Else
            TextGrade.Text = "P"
            TextComment.Text = "pass"



        End If
    End Sub

    Private Sub TextGrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextGrade.TextChanged
        Dim Marks As Integer
        Marks = Val(TextMarks.Text)
        If Marks <= 40 Then
            TextGrade.Text = "F"
            TextComment.Text = "fail"
        ElseIf Marks < 50 Then
            TextGrade.Text = "D"
            TextComment.Text = "poor"
        ElseIf Marks < 60 Then
            TextGrade.Text = "c"
            TextComment.Text = "fair"
        ElseIf Marks < 70 Then
            TextGrade.Text = "B"
            TextComment.Text = "good"
        ElseIf Marks <= 100 Then
            TextGrade.Text = "A"
            TextComment.Text = "Excellent"
        End If



    End Sub

    Private Sub BtnCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCase.Click
        Dim Marks As Integer
        Marks = TextMarks.Text
        Select Case Marks
            Case 0 To 40
                    TextGrade.Text = "F"
                    TextComment.Text = "fail"
                    Case 41 to 50
                    TextGrade.Text = "D"
                    TextComment.Text = "poor"
            Case 51 To 60
                TextGrade.Text = "c"
                TextComment.Text = "fair"
            Case 61 To 70
                TextGrade.Text = "B"
                TextComment.Text = "good"
            Case 71 To 100
                TextGrade.Text = "A"
                TextComment.Text = "Excellent"
            Case Else
                MsgBox("Enter marks in the right format from 0-100")




        End Select
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TextMarks.Text = ""
        TextGrade.Text = ""
        TextComment.Text = ""

    End Sub

    Private Sub BtnForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForm2.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
