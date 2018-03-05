Public Class Form2
    Dim childcounter, femalecounter, malecounter As Integer
    Private Sub CmbPatgender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPatgender.SelectedIndexChanged

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbPatgender.Items.Add("male")
        CmbPatgender.Items.Add("female")
        childcounter = 0
        femalecounter = 0
        malecounter = 0
    End Sub

    Private Sub BtnAdmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdmit.Click
        Dim age As Integer
        Dim gender As String
        age = TxtPatage.Text
        gender = CmbPatgender.Text
        If age <= 10 Then
            Child.Items.Add(TxtPatname.Text)
            childcounter = childcounter + 1
            If Val(TxtNoChild.Text) >= 5 Then
                MsgBox("ward is full")
            Else
                TxtNoChild.Text = childcounter

            End If
            TxtNoChild.Text = childcounter

        ElseIf age > 10 And gender = "male" Then
            Male.Items.Add(TxtPatname.Text)
            malecounter = malecounter + 1
            TxtNoMale.Text = malecounter
        ElseIf gender = "female" Then
            Female.Items.Add(TxtPatname.Text)
            femalecounter = femalecounter + 1
            TxtNoFemale.Text = femalecounter



        End If

    End Sub

    Private Sub TxtPatage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPatage.TextChanged

    End Sub
End Class