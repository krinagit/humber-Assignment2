<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeeklyCalendar.aspx.cs" Inherits="N01331772_BonusAssignment.WeeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>weekly work/study schedule</title>
</head>
<body>
    <form id="form1" runat="server">
       
        <main>
            <div>
                <section>
                     
                          <h3>Select your day</h3>
<%--                         <label>Enter your week days</label><asp:TextBox runat="server" ID="aspx_Name_of_day" ></asp:TextBox>--%>
<%--                         <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="enter the day" ForeColor="DarkRed" ControlToValidate="aspx_Name_of_day"></asp:RequiredFieldValidator>--%>
                      
                      <asp:CheckBoxList ID="aspx_Name_of_day" runat="server">
                        <asp:ListItem Text="Sunday" Value="Sunday"></asp:ListItem>
                        <asp:ListItem Text="Monday" Value="Monday"></asp:ListItem>
                        <asp:ListItem Text="Tuesday" Value="Tuesday"></asp:ListItem>
                        <asp:ListItem Text="Wednesday" Value="Wednesday"></asp:ListItem>  
                        <asp:ListItem Text="Thursday" Value="Thursday"></asp:ListItem>  
                        <asp:ListItem Text="Friday" Value="Friday"></asp:ListItem> 
                       <asp:ListItem Text="Saturday" Value="Saturday"></asp:ListItem>

                      </asp:CheckBoxList>
                </section>
                <section>
                    <asp:ValidationSummary runat="server" ShowSummary="true" />
                </section>
				<section id="confirmbox" runat="server">
				</section>
				<section>
                    <input type="submit" value="submit" />
				</section>
                   
              </div>
        </main>
    </form>
</body>
</html>
