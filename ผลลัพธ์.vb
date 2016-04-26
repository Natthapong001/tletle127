Public Class ผลลัพธ์

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        คำนวนส่วนสูงมาตรฐาน.TextBox1.Text = ("")
        คำนวนส่วนสูงมาตรฐาน.TextBox2.Text = ("")
        คำนวนส่วนสูงมาตรฐาน.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel + _
        MsgBoxStyle.Question + _
        MsgBoxStyle.ApplicationModal, _
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
            คำนวนส่วนสูงมาตรฐาน.Close()
            Me.Close()

        End If


    End Sub
End Class