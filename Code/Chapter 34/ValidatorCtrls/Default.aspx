<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Fun with ASP.NET Validators"></asp:Label><br />
            <hr />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Required Field:"></asp:Label><br />
            <asp:TextBox ID="txtRequiredField" runat="server">Please enter your name</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRequiredField"
                ErrorMessage="Oops!  Need to enter data." InitialValue="Please enter your name"></asp:RequiredFieldValidator><br />
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Range 0 - 100:"></asp:Label><br />
                <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRange"
                    ErrorMessage="Please enter value between 0 and 100." MaximumValue="100" MinimumValue="0"
                    Type="Integer"></asp:RangeValidator><br />
                <br />
                <div>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Enter your US SSN:"></asp:Label><br />
                    <asp:TextBox ID="txtRegExp" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtRegExp"
                        ErrorMessage="Please enter a valid US SSN." ValidationExpression="\d{3}-\d{2}-\d{4}"></asp:RegularExpressionValidator><br />
                    <br />
                    <div>
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Value < 20"></asp:Label><br />
                        <asp:TextBox ID="txtComparison" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtComparison"
                            ErrorMessage="Enter a value less than 20." Operator="LessThan" ValueToCompare="20"></asp:CompareValidator><br />
                        <br />
                        <hr />
                        &nbsp;<br />
                        <asp:Button ID="btnPostback" runat="server" OnClick="btnPostback_Click" Text="Post back" />
                        <asp:Label ID="lblValidationComplete" runat="server"></asp:Label><br />
                    </div>
                    <br />
                </div>
                <br />
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
