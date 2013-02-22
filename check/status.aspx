<%@ Page Language="VB" AutoEventWireup="false" CodeFile="status.aspx.vb" Inherits="status" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your login status!</title>
    <style>
		#divContainer div{
			margin: 10px;
			padding: 10px;
			border: solid 1px #CDCDCD;
		}
		h2, #divContainer {
			display: table;
			margin: 50px auto;
		}

		#divContainer span{
			display: inline-block; width: 100px;
		}

		label {width: 120px; text-align: center;}
        input[type="text"] { width: 30px; text-align:center;}
        #divControls { margin: 0px auto; text-align:center;}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divContainer">
    <h2>I have captured your online presence!</h2>
    
	<div>
		<span>Facebook</span>
        <asp:Label runat="server" ID="lblFacebook"></asp:Label>
	</div>
	<div>
		<span>Twitter</span>
        <asp:Label runat="server" ID="lblTwitter"></asp:Label>
	</div>
		<div>
		<span>Gmail</span>
        <asp:Label runat="server" ID="lblGmail"></asp:Label>
	</div>
	<div>
		<span>Hotmail</span>
        <asp:Label runat="server" ID="lblHotmail"></asp:Label>
	</div>
    <div id="divControls">
        <asp:ScriptManager ID="scrManager" runat="server"></asp:ScriptManager>
        <asp:TextBox ID="txtTimer" runat="server" Text="5"></asp:TextBox>
        <asp:Button ID="btnTimer" Text="Start Timer" runat="server" />
        <asp:Button ID="btnReload" Text="Reload" runat="server" />
        <asp:Button ID="btnKillSessions" Text="Kill sessions" runat="server" />
        <asp:Timer runat="server" ID="aspTimer" Enabled="false"></asp:Timer>
    </div>
    </div>
    </form>
</body>
</html>
