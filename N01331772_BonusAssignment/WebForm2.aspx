<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="N01331772_BonusAssignment.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <section>
            <label>Number of tickets ordered:</label>
            <asp:TextBox ID="num_of_tickets" runat="server"/>

            </section>
            <section id="confirmbox" runat="server">
	        </section>
		    <section>
               <input type="submit" value="submit" />
			</section>
        </div>
    </form>
</body>
</html>
