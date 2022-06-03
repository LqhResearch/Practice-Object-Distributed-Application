<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebForm.subjects.add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thêm môn học</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-primary">Thêm môn học</h3>
            <div class="mb-3">
                <label class="form-label">Mã môn học</label>
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Tên môn học</label>
                <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 d-flex-center">
                <asp:Button ID="btnAdd" CssClass="btn btn-success me-1" runat="server" Text="Lưu" OnClick="btnAdd_Click" />
                <a class="btn btn-danger ms-1" href="/subjects/list.aspx">Huỷ</a>
            </div>
        </div>
    </div>
</asp:Content>
