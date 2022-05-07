<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebForm.students.add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thêm sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server" />
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-danger">Thêm sinh viên</h3>
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label class="form-label">Mã số sinh viên</label>
                    <asp:TextBox ID="txtID" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Họ tên</label>
                    <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Quê quán</label>
                    <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Năm sinh</label>
                    <asp:TextBox ID="txtBirth" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Giới tính</label>
                    <asp:DropDownList CssClass="form-select" ID="ddlGender" runat="server">
                        <asp:ListItem Value="Nam" Text="Nam"></asp:ListItem>
                        <asp:ListItem Value="Nữ" Text="Nữ"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Mã lớp</label>
                    <asp:DropDownList CssClass="form-select" ID="ddlClassID" runat="server"></asp:DropDownList>
                </div>
                <div class="d-flex-center">
                    <asp:Button ID="btnSubmit" CssClass="btn btn-success mx-1 fa" runat="server" Text="&#xf0c7; Thêm" OnClick="btnSubmit_Click" />
                    <a class="btn btn-danger mx-1" href="/students/list.aspx"><i class="fas fa-ban"></i>Hủy</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
