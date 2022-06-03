<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebForm.exams.add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thêm kết quả thi</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-primary">Thêm kết quả thi</h3>
            <div class="mb-3">
                <label class="form-label">Mã sinh viên</label>
                <asp:DropDownList ID="ddlStudents" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label class="form-label">Mã môn học</label>
                <asp:DropDownList ID="ddlSubjects" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label class="form-label">Lần thi</label>
                <asp:DropDownList ID="ddlTimes" CssClass="form-select" runat="server">
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <label class="form-label">Điểm</label>
                <asp:TextBox ID="txtPoint" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 d-flex-center">
                <asp:Button ID="btnAdd" CssClass="btn btn-success me-1" runat="server" Text="Lưu" OnClick="btnAdd_Click" />
                <a class="btn btn-danger ms-1" href="/exams/list.aspx">Huỷ</a>
            </div>
        </div>
    </div>
</asp:Content>
