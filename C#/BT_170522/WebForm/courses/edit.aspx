<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebForm.courses.edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sửa khoá học</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-primary">Sửa khoá học</h3>
            <div class="mb-3">
                <label class="form-label">Mã khoá học</label>
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Tên khoá học</label>
                <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Chương trình đào tạo</label>
                <asp:DropDownList ID="ddlEducation" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3 d-flex-center">
                <asp:Button ID="btnEdit" CssClass="btn btn-success me-1" runat="server" Text="Lưu" OnClick="btnEdit_Click" />
                <a class="btn btn-danger ms-1" href="/courses/list.aspx">Huỷ</a>
            </div>
        </div>
    </div>
</asp:Content>
