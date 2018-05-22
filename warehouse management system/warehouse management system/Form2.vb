Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusername.Text = My.Settings.username And txtpassword.Text = My.Settings.password Then
            MsgBox("Access Granted")
            Me.Hide()
            Form3.Show()
            txtusername.Clear()
            txtpassword.Clear()
        Else
            MsgBox("Access denied")
            txtusername.Clear()
            txtpassword.Clear()
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class