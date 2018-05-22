Public Class Form5
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabControl1.SelectTab(0)
        Label12.Text = "New warehouse Application: New Entry"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TabControl1.SelectTab(1)
        Label12.Text = "New warehouse Application: Incoming Stock Entry"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TabControl1.SelectTab(2)
        Label12.Text = "New warehouse Application: Outgoing Stock Entry"
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox("successful", MsgBoxStyle.ApplicationModal)
        Me.Hide()
        Form3.Show()
        Form6.DataGridView1.Rows.Add(Txtac.Text, Txtemail.Text, Txtno.Text, TextBox2.Text, TextBox1.Text, txtentry.Text, txtdeliver.Text)
        Txtac.Clear()
        Txtemail.Clear()
        Txtno.Clear()
        TextBox2.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("successful", MsgBoxStyle.ApplicationModal)
        Me.Hide()
        Form3.Show()
        Form4.DataGridView1.Rows.Add(txtname.Text, txtaddress.Text, txtitem.Text, txtquan.Text, txtunit.Text, entry.Text, deliver.Text)
        Form6.DataGridView1.Rows.Add(txtname.Text, txtaddress.Text, txtitem.Text, txtquan.Text, txtunit.Text, entry.Text, deliver.Text)
        txtname.Clear()
        txtaddress.Clear()
        txtitem.Clear()
        txtquan.Clear()
        txtunit.Clear()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("successful", MsgBoxStyle.ApplicationModal)
        Me.Hide()
        Form3.Show()
        Form7.DataGridView1.Rows.Add(TextBox7.Text, TextBox5.Text, TextBox6.Text, TextBox4.Text, TextBox3.Text, txtenter.Text, txtdeliv.Text)
        TextBox7.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox4.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("logging off now....", MsgBoxStyle.Critical)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class