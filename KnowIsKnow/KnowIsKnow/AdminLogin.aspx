<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="KnowIsKnow.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/AdminLogin.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/AdminLogin.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="adminlogin">
            <div class="lgheader">
                Konw is know
            </div>
            <div class="lgcontent">
                <ul>
                    <li  class="Adminli">
                        <input type="text" name="name" value="AdminEmail " class="admininput email" runat="server" id="ademail"/>
                        <span class="icon"></span>
                    </li>
                     <li  class="Adminli">
                        <input type="password" name="name" value="AdminPassword" class="admininput password" runat="server" id="adpassword"/>
                        <span class="icon mima"></span>
                    </li>
                </ul>

                <asp:Button Text="Sign in" runat="server" id="toadmin" OnClick="toadmin_Click" class="dianjijinru"/>
            </div>
        </div>
        <div class="adminfooter">KonwIsKonw © 2014.</div>
    </form>
</body>
</html>
