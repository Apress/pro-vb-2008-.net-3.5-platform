<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Inventory.aspx.vb" Inherits="Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Here is what we currently have in stock."></asp:Label><br />
    <br />
    &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
      AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
      BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
      DataKeyNames="CarID" DataSourceID="SqlDataSource1" 
      EmptyDataText="There are no data records to display." GridLines="Vertical">
      <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
      <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
      <Columns>
        <asp:CommandField ShowEditButton="True" />
        <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
        <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
        <asp:BoundField DataField="PetName" HeaderText="PetName" 
          SortExpression="PetName" />
        <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="True" 
          SortExpression="CarID" />
      </Columns>
      <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
      <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
      <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
      <AlternatingRowStyle BackColor="#DCDCDC" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
      ConnectionString="<%$ ConnectionStrings:AutoLotConnectionString %>" 
      DeleteCommand="DELETE FROM [Inventory] WHERE [CarID] = @CarID" 
      InsertCommand="INSERT INTO [Inventory] ([Color], [Make], [PetName], [CarID]) VALUES (@Color, @Make, @PetName, @CarID)" 
      ProviderName="<%$ ConnectionStrings:AutoLotConnectionString.ProviderName %>" 
      SelectCommand="SELECT [Color], [Make], [PetName], [CarID] FROM [Inventory]" 
      UpdateCommand="UPDATE [Inventory] SET [Color] = @Color, [Make] = @Make, [PetName] = @PetName WHERE [CarID] = @CarID">
      <DeleteParameters>
        <asp:Parameter Name="CarID" Type="Int32" />
      </DeleteParameters>
      <InsertParameters>
        <asp:Parameter Name="Color" Type="String" />
        <asp:Parameter Name="Make" Type="String" />
        <asp:Parameter Name="PetName" Type="String" />
        <asp:Parameter Name="CarID" Type="Int32" />
      </InsertParameters>
      <UpdateParameters>
        <asp:Parameter Name="Color" Type="String" />
        <asp:Parameter Name="Make" Type="String" />
        <asp:Parameter Name="PetName" Type="String" />
        <asp:Parameter Name="CarID" Type="Int32" />
      </UpdateParameters>
    </asp:SqlDataSource>
&nbsp;
</asp:Content>

