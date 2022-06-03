<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebForm.students.edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sửa sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-primary">Sửa sinh viên</h3>
            <div class="mb-3">
                <label class="form-label">Mã số sinh viên</label>
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Họ tên</label>
                <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Giới tính</label>
                <asp:DropDownList ID="ddlGender" CssClass="form-select" runat="server">
                    <asp:ListItem Value="Nam">Nam</asp:ListItem>
                    <asp:ListItem Value="Nữ">Nữ</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <label class="form-label">Ngày sinh</label>
                <asp:TextBox ID="txtBirth" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Nơi sinh</label>
                <asp:TextBox ID="txtPlace" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Mã lớp</label>
                <asp:DropDownList ID="ddlClasses" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3 d-flex-center">
                <asp:Button ID="btnEdit" CssClass="btn btn-success me-1" runat="server" Text="Lưu" OnClick="btnEdit_Click" />
                <a class="btn btn-danger ms-1" href="/students/list.aspx">Huỷ</a>
            </div>
        </div>
    </div>
</asp:Content>
