<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login"CodePage="950" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link id="stylesheet" rel="stylesheet" type="text/css" runat="server" href="StyleSheet.css" />
    <title>首頁</title>
    </head>
    <body>
<div class="whist">
 <form id="form2" runat="server"> 
<div class="bid"> <img src="image/yellbg.png" style="height: 780px; width: 782px"/>
<div class="down">      
  <p><img src="image/icon人頭.png" />
      <asp:Label ID="lbusername" runat="server" style="font-size:20px">帳號：</asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
   <asp:TextBox ID="tbusername" BorderStyle="None" runat="server" Width="250px" Height="40px"></asp:TextBox> 
   </p> 
       
 
     
  <p><img src="image/icon1.png" />
      <asp:Label ID="lbpsw" runat="server" style="font-size:20px">密碼：</asp:Label>
  <asp:TextBox ID="tbpsw" runat="server" TextMode="Password" BorderStyle="None" Width="250px" Height="40px"></asp:TextBox> 

  </p>  


  <p> 
      <asp:ImageButton ID="btnLogin" src="image/loginbutton.png" runat="server"  Width="250px" Height="40px" onclick="btnLogin_Click"/>

      <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

      

      

     
 </div>
 </div>
 </form> 
</div>
       
</body>  
    </html>