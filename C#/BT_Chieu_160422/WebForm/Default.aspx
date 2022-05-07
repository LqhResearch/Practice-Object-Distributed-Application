<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bài tập thực hành</title>
    <!-- Bootstrap 5 -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>

    <style>
        .shadow {
            box-shadow: rgba(0, 0, 0, 0.15) 1.95px 1.95px 2.6px !important;
        }
    </style>
</head>
<body style="background-color: #f0f0f0">
    <div class="container">
        <form id="form1" runat="server">
            <div class="card shadow mt-4">
                <div class="card-body">
                    <p>Nhập vào 1 số thập phân, in ra các số nhị phân.</p>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:TextBox ID="txtInput1" CssClass="form-control" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtOutput1" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnSubmit1" CssClass="btn btn-primary mt-3" runat="server" Text="Kết quả" OnClick="btnSubmit1_Click" />
                </div>
            </div>

            <div class="card shadow mt-4">
                <div class="card-body">
                    <p>Nhập vào 1 số nguyên dương, nếu n là số lẻ tính S = 1 + 1/3 + 1/5 + ... + 1/n, nếu n là số chẵn tính: S = 1 + 1/2 + ... + 1/n</p>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:TextBox ID="txtInput2" CssClass="form-control" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtOutput2" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnSubmit2" CssClass="btn btn-primary mt-3" runat="server" Text="Kết quả" OnClick="btnSubmit2_Click" />
                </div>
            </div>

            <div class="card shadow mt-4">
                <div class="card-body">
                    <p>Nhập vào 1 số nguyên dương, tính n giai thừa</p>
                    <div class="row">
                        <div class="col-md-6">
                            <asp:TextBox ID="txtInput3" CssClass="form-control" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtOutput3" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnSubmit3" CssClass="btn btn-primary mt-3" runat="server" Text="Kết quả" OnClick="btnSubmit3_Click" />
                </div>
            </div>

            <div class="card shadow mt-4">
                <div class="card-body">
                    <p>Nhập vào 2 số nguyên dương a, b bất kỳ, in ra các số nguyên tố từ a đến b</p>
                    <div class="row">
                        <div class="col-md-3">
                            <asp:TextBox ID="txtInput4_1" CssClass="form-control" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtInput4_2" CssClass="form-control" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtOutput4" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnSubmit4" CssClass="btn btn-primary mt-3" runat="server" Text="Kết quả" OnClick="btnSubmit4_Click" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
