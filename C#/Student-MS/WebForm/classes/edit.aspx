<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebForm.classes.edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sửa lớp</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server" />
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-danger">Sửa lớp</h3>
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label class="form-label">Mã lớp</label>
                    <asp:TextBox ID="txtID" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Tên lớp</label>
                    <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="d-flex-center">
                    <asp:Button ID="btnSubmit" CssClass="btn btn-success mx-1 fa" runat="server" Text="&#xf0c7; Lưu" OnClick="btnSubmit_Click" />
                    <a class="btn btn-danger mx-1" href="/classes/list.aspx"><i class="fas fa-ban"></i> Hủy</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
