
Partial Class status
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Params("fbStatus") IsNot Nothing Then
            Session("fbStatus") = Request.Params("fbStatus")
        Else
            lblFacebook.Text = Session("fbStatus")
        End If

        If Request.Params("twitterStatus") IsNot Nothing Then
            Session("twitterStatus") = Request.Params("twitterStatus")
        Else
            lblTwitter.Text = Session("twitterStatus")
        End If



        'lblTwitter.Text = Request.Params("twitterStatus")
        'lblGmail.Text = Request.Params("gmailStatus")
        'lblHotmail.Text = Request.Params("winLiveStatus")
    End Sub
End Class
