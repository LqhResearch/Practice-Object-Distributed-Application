<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="De_1.aspx.cs" Inherits="ASPNET_UI.De_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="assets/Style.css" />
    <title>Đề 1: Phương trình bậc 1 và số nguyên tố</title>
</head>
<body>
    <form id="form1" runat="server" class="background-full">
        <div class="container d-flex-center" style="width: 100%; height: 100vh; margin: 16px 0">
            <div class="card">
                <div class="card-header">
                    <h2>Đề 1: Phương trình bậc 1 và số nguyên tố</h2>
                </div>
                <div class="card-body">
                    <div class="input-group">
                        <label class="input-group-text">A: </label>
                        <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-group">
                        <label class="input-group-text">B: </label>
                        <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
                    </div>
                    <div class="btn-group">
                        <asp:Button ID="btnAns" CssClass="btn" runat="server" Text="Kết quả" OnClick="btnAns_Click" />
                        <asp:Button ID="btnReset" CssClass="btn" runat="server" Text="Reset" OnClick="btnReset_Click" />
                    </div>
                    <asp:TextBox ID="txtMessage" CssClass="textarea" runat="server" ReadOnly="True"></asp:TextBox>
                    <div class="input-group">
                        <label class="input-group-text">Kiểm tra số nguyên tố: </label>
                        <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
                    </div>
                    <div class="btn-group">
                        <asp:Button ID="btnAns1" CssClass="btn" runat="server" Text="Kết quả" OnClick="btnAns1_Click" />
                        <asp:Button ID="btnReset1" CssClass="btn" runat="server" Text="Reset" OnClick="btnReset1_Click" />
                    </div>
                    <asp:TextBox ID="txtMessage1" CssClass="textarea" runat="server" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
