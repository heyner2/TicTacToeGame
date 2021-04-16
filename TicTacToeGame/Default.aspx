<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TicTacToeGame._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   

    
    <br />
    <asp:Panel CssClass="text-center" ID="Panel1" runat="server" Height="79px" style="margin-left: 0px" Width="1176px" BackColor="#333333">
       <br />
        <asp:Label CssClass="l-header" ID="Label2" runat="server" Text="" Font-Bold="True" Font-Italic="True" Font-Size="40px" ForeColor="White"></asp:Label>
        <br /> 
    </asp:Panel>

    <asp:Panel CssClass="text-center" ID="Panel2" runat="server" style="margin-left: 48px" Width="1103px" Height="384px" BackColor="#3366FF">
        <br />
        <asp:Button CssClass="b1" ID="Button1" runat="server" Width="93px" BackColor="White" BorderStyle="Solid" Height="72px" Font-Bold="True" Font-Italic="True" Font-Size="30px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b2" Height="72px" Width="93px" Font-Bold="True" Font-Italic="True" Font-Size="30px" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b3" Height="72px" Width="93px" Font-Bold="True" Font-Italic="True" Font-Size="30px" OnClick="Button3_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Str" runat="server" BackColor="White" BorderStyle="Solid" CssClass="btn-reset" Font-Bold="True" Font-Italic="True" Font-Size="25px" Height="72px" OnClick="Start" Text="Start" Width="172px" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b4" Font-Bold="True" Font-Italic="True" Font-Size="30px" Height="72px" OnClick="Button4_Click" Width="93px" />
        <asp:Button ID="Button5" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b5" Font-Bold="True" Font-Italic="True" Font-Size="30px" Height="72px" OnClick="Button5_Click" Width="93px" />
        <asp:Button ID="Button6" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b6" Font-Bold="True" Font-Italic="True" Font-Size="30px" Height="72px" OnClick="Button6_Click" Width="93px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b7" Font-Bold="True" Font-Italic="True" Font-Size="30px" Height="72px" OnClick="Button7_Click" Width="93px" />
        <asp:Button ID="Button8" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b8" Font-Bold="True" Font-Italic="True" Font-Size="30px" Height="72px" OnClick="Button8_Click" Width="93px" />
        <asp:Button ID="Button9" runat="server" BackColor="White" BorderStyle="Solid" CssClass="b9" Font-Bold="True" Font-Italic="True" Font-Size="30px" Height="72px" OnClick="Button9_Click" Width="93px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Rst" runat="server" BackColor="White" BorderStyle="Solid" CssClass="btn-reset" Font-Bold="True" Font-Italic="True" Font-Size="25px" Height="72px" OnClick="Reset" Text="Reset" Width="172px" />


        </asp:Panel>
   

    
        
    <br />

    
    
        
</asp:Content>
