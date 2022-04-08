Public Class Form1
    Dim mtk, bindo, bing, ipa, ratarata As Double

    Sub rata()
        ipa = Convert.ToDouble(TextBox1.Text)
        bindo = Convert.ToDouble(TextBox2.Text)
        bing = Convert.ToDouble(TextBox3.Text)
        mtk = Convert.ToDouble(TextBox4.Text)
        ratarata = (ipa + bindo + bing + mtk) / 4
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse kunci = Keys.Back) Then
            kunci = 0
        End If
        e.Handled = CBool(kunci)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or
                TextBox2.Text = "" Or
                TextBox3.Text = "" Or
                TextBox4.Text = "" Then
            MsgBox("Fill all columns", vbCritical)
        ElseIf TextBox1.Text > 100 Then
        MsgBox("Value for IPA Is Incorrect", vbCritical)
                TextBox1.Text = Nothing
            ElseIf TextBox2.Text > 100 Then
                MsgBox("Value For Bindo is incorrect", vbCritical)
                TextBox2.Text = Nothing
            ElseIf TextBox3.Text > 100 Then
                MsgBox("Value for Bing is incorrect", vbCritical)
                TextBox3.Text = Nothing
            ElseIf TextBox4.Text > 100 Then
                MsgBox("Value for MTk is incorrect", vbCritical)
                TextBox4.Text = Nothing
            Else
                Call rata()
            If ratarata = 100 Then
                MsgBox("You're S Grade", MsgBoxStyle.Information)
                label_grade.Text = "S"
            ElseIf ratarata > 100 Then
                MsgBox("Input is incorrect", vbCritical)
            ElseIf ratarata > 94 Then
                MsgBox("You're A+ Grade", MsgBoxStyle.Information)
                label_grade.Text = "A+"
            ElseIf ratarata > 89 Then
                MsgBox("You're A Grade", MsgBoxStyle.Information)
                label_grade.Text = "A"
            ElseIf ratarata > 84 Then
                MsgBox("You're B+ Grade", MsgBoxStyle.Information)
                label_grade.Text = "B+"
            ElseIf ratarata > 79 Then
                MsgBox("You're B Grade", MsgBoxStyle.Information)
                label_grade.Text = "B"
            ElseIf ratarata > 74 Then
                MsgBox("You're C+ Grade", MsgBoxStyle.Information)
                label_grade.Text = "C+"
            ElseIf ratarata > 69 Then
                MsgBox("You're C Grade", MsgBoxStyle.Information)
                label_grade.Text = "C"
            ElseIf ratarata < 69 Then
                MsgBox("You're D Grade", MsgBoxStyle.Information)
                label_grade.Text = "D"
            Else
                MsgBox("Input is incorrect", vbCritical)
            End If
        End If
        label_rata.Text = CStr(ratarata)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse kunci = Keys.Back) Then
            kunci = 0
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse kunci = Keys.Back) Then
            kunci = 0
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim kunci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse kunci = Keys.Back) Then
            kunci = 0
        End If

    End Sub
End Class
