<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="admin1.aspx.cs" Inherits="final_project.admin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label1" runat="server" Text="STUDENTS REGISTERED:-"></asp:Label>
&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" EnableModelValidation="True" 
        BackColor="#CCCCCC" Width="847px">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" />
            <asp:BoundField DataField="qualification" HeaderText="qualification" 
                SortExpression="qualification" />
            <asp:BoundField DataField="univname" HeaderText="univname" 
                SortExpression="univname" />
            <asp:BoundField DataField="yearofpassout" HeaderText="yearofpassout" 
                SortExpression="yearofpassout" />
            <asp:BoundField DataField="skills" HeaderText="skills" 
                SortExpression="skills" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
        SelectCommand="SELECT * FROM [candidateapplication1]"></asp:SqlDataSource>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
</asp:Content>
