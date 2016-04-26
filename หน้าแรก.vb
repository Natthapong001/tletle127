Public Class คำนวนส่วนสูงมาตรฐาน
    Dim a, s, d As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            a = CSng(TextBox1.Text)
            s = CSng(TextBox2.Text)

            If a >= 0 And s >= 0 Then
                If a >= (s + 110) Then

                    ผลลัพธ์.TextBox1.Text = "ผ่าน"
                    ผลลัพธ์.Show()

                ElseIf a < (s + 110) Then
                    ผลลัพธ์.TextBox1.Text = "ไม่ผ่าน"
                    ผลลัพธ์.Show()

                End If

            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาใส่ตัวเลขและให้ครบทุกช่อง")
            TextBox1.Text = ("")
            TextBox2.Text = ("")
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ("")
        TextBox2.Text = ("")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ออกจากโปรแกรมหรือไม่?",
        MsgBoxStyle.OkCancel + _
        MsgBoxStyle.Question + _
        MsgBoxStyle.ApplicationModal, _
        "ออกจากโปรแกรม")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
            ผลลัพธ์.Close()
            Me.Close()

        End If
        TextBox1.Text = ("")
        TextBox2.Text = ("")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class
