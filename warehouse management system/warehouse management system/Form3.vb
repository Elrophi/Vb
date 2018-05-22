Public Class Form3

    Sub New()

        InitializeComponent()

        AddHandler pan_header.MouseDown, New MouseEventHandler(AddressOf ctl_mousedown)
        AddHandler pan_header.MouseMove, New MouseEventHandler(AddressOf ctl_mousemove)
        AddHandler pan_header.MouseUp, New MouseEventHandler(AddressOf ctl_mouseup)
    End Sub


#Region "MOUSE EVENT ON PANEL CONTROL"
    Private m_windowstate As FormWindowState = FormWindowState.Normal
    Private m_mousepressed As Boolean = False
    Private m_oldx As Integer, m_oldy As Integer
    Private Sub ctl_mousedown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim TS As Point = Me.PointToScreen(e.Location)
        m_oldx = TS.X
        m_oldy = TS.Y
        m_mousepressed = True
    End Sub
    Private Sub ctl_mouseup(ByVal sender As Object, ByVal e As MouseEventArgs)
        m_mousepressed = False
    End Sub
    Private Sub ctl_mousemove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If m_mousepressed = True AndAlso m_windowstate <> FormWindowState.Maximized Then
            Dim TS As Point = Me.PointToScreen(e.Location)

            Me.Location = New Point(Me.Location.X + (TS.X - m_oldx), Me.Location.Y + (TS.Y - m_oldy))
            m_oldx = TS.X
            m_oldx = TS.Y
        End If
    End Sub
#End Region
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnchange.Click
        Me.Hide()
        Form9.ShowDialog()
    End Sub
    Private Sub Pcnon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pcnon.Click
        Pcnon.BackColor = Color.Aqua
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Pctnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pctnew.Click
        Pctnew.BackColor = Color.Aqua
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Pcnavailable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pcnavailable.Click
        Pcnavailable.BackColor = Color.Aqua
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Pcnnotavailable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pcnnotavailable.Click
        Pcnnotavailable.BackColor = Color.Aqua
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Pcnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pcnhelp.Click
        Pcnhelp.BackColor = Color.Aqua
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub btnend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnend.Click
        Me.Close()
    End Sub

    Private Sub pan_body_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pan_body.Paint

    End Sub
End Class