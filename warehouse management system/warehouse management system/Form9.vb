Public Class Form9

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.username = TextBox1.Text And My.Settings.password = TextBox2.Text Then
            If TextBox4.Text = TextBox5.Text Then
                My.Settings.username = TextBox3.Text
                My.Settings.password = TextBox5.Text
                My.Settings.Save()
                MsgBox("Successfully Changed!!!", MsgBoxStyle.Information)
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("passwords don't match", MsgBoxStyle.AbortRetryIgnore)
            End If
        Else
            MsgBox("Invalid Command, Exit Please", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class