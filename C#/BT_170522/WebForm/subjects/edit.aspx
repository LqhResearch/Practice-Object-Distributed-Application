<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebForm.subjects.edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sửa môn học</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-primary">Sửa môn học</h3>
            <div class="mb-3">
                <label class="form-label">Mã môn học</label>
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Tên môn học</label>
                <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 d-flex-center">
                <asp:Button ID="btnEdit" CssClass="btn btn-success me-1" runat="server" Text="Lưu" OnClick="btnEdit_Click" />
                <a class="btn btn-danger ms-1" href="/subjects/list.aspx">Huỷ</a>
            </div>
        </div>
    </div>
</asp:Content>
