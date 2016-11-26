<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="admin2.aspx.cs" Inherits="final_project.admin2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="COMPANIES REGISTERED:-"></asp:Label>
<br />
<br />
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" EnableModelValidation="True" 
        BackColor="#CCCCCC" Width="860px">
        <Columns>
            <asp:BoundField DataField="companyname" HeaderText="companyname" 
                SortExpression="companyname" />
            <asp:BoundField DataField="website" HeaderText="website" 
                SortExpression="website" />
            <asp:BoundField DataField="regno" HeaderText="regno" SortExpression="regno" />
            <asp:BoundField DataField="location" HeaderText="location" 
                SortExpression="location" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="password" HeaderText="password" 
                SortExpression="password" />
            <asp:BoundField DataField="confirmpassword" HeaderText="confirmpassword" 
                SortExpression="confirmpassword" />
            <asp:BoundField DataField="contactno" HeaderText="contactno" 
                SortExpression="contactno" />
            <asp:BoundField DataField="skills" HeaderText="skills" 
                SortExpression="skills" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
        SelectCommand="SELECT * FROM [companyprofile1]"></asp:SqlDataSource>
</asp:Content>
