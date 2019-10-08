<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate.aspx.cs" Inherits="N01331772_BonusAssignment.Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coordinate</title>
</head>

<body>
    <form id="form1" runat="server">
        <main>
        <div>
           <label>Enter the value of x:</label><asp:TextBox runat="server" ID="aspx_Value_of_x" ></asp:TextBox>
           <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="enter the value"  ForeColor="DarkRed" ControlToValidate="aspx_Value_of_x"></asp:RequiredFieldValidator>
           <asp:CompareValidator runat="server" ControlToValidate="aspx_Value_of_x" ValueToCompare="0" Operator="GreaterThan" ErrorMessage="enter a non-zero x quadrant value"></asp:CompareValidator>

         </div>
         <div>
           <label>Enter the value of y:</label><asp:TextBox runat="server" ID="aspx_Value_of_y" ></asp:TextBox>
           <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="enter the value" ForeColor="DarkRed" ControlToValidate="aspx_Value_of_y"></asp:RequiredFieldValidator>
           <asp:CompareValidator runat="server" ControlToValidate="aspx_Value_of_y" ValueToCompare="0" Operator="GreaterThan" ErrorMessage="enter a non-zero y quadrant value"></asp:CompareValidator>
        </div>
        <section id="confirmbox" runat="server">
	    </section>
       	<section>
             <input type="submit" value="submit" />
	    </section>
        </main>
    </form>
</body>
</html>
