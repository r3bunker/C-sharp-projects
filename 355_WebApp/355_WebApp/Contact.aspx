<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="_355_WebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p>Your contact page.</p>

    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>
    <address>
        &nbsp;</address>
    <address>
        <strong>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </strong>
    </address>
    <address>
        <strong>
        <asp:TextBox ID="TextBox1" runat="server" Width="149px"></asp:TextBox>
        </strong>
    </address>
    <address>
        <strong>
        <asp:Button ID="Button1" runat="server" Height="53px" Text="Button" Width="137px" />
        </strong>
    </address>

    <address>
        <strong>Support:</strong><a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong><a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
