
Partial Class status
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CaptureSession()
        End If
    End Sub

    Sub CaptureSession()
        If Request.Params("fbStatus") IsNot Nothing Then
            Session("fbStatus") = Request.Params("fbStatus")
            lblFacebook.Text = Request.Params("fbStatus")
        Else
            lblFacebook.Text = Session("fbStatus")
        End If

        If Request.Params("twitterStatus") IsNot Nothing Then
            Session("twitterStatus") = Request.Params("twitterStatus")
            lblTwitter.Text = Request.Params("twitterStatus")
        Else
            lblTwitter.Text = Session("twitterStatus")
        End If

        If Request.Params("gmailStatus") IsNot Nothing Then
            Session("gmailStatus") = Request.Params("gmailStatus")
            lblGmail.Text = Request.Params("gmailStatus")
        Else
            lblGmail.Text = Session("gmailStatus")
        End If

        If Request.Params("winLiveStatus") IsNot Nothing Then
            Session("winLiveStatus") = Request.Params("winLiveStatus")
            lblHotmail.Text = Request.Params("winLiveStatus")
        Else
            lblHotmail.Text = Session("winLiveStatus")
        End If
    End Sub

    Protected Sub btnKillSessions_Click(sender As Object, e As EventArgs) Handles btnKillSessions.Click
        Session.Clear()
        CaptureSession()
    End Sub

    Protected Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        CaptureSession()
    End Sub

    Protected Sub aspTimer_Tick(sender As Object, e As EventArgs) Handles aspTimer.Tick
        CaptureSession()
    End Sub

    Protected Sub btnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        If aspTimer.Enabled = False Then
            aspTimer.Enabled = True
            btnTimer.Text = "Stop Timer"
            If String.IsNullOrEmpty(txtTimer.Text) Then
                aspTimer.Interval = 5000
            Else
                aspTimer.Interval = Convert.ToInt32(txtTimer.Text) * 1000
            End If
        Else
            aspTimer.Enabled = False
            btnTimer.Text = "Start Timer"
        End If
        
    End Sub
End Class
