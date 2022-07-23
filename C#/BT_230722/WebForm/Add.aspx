<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebForm.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Thêm nhân viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="my-3">
        <h2 class="text-primary text-center">Thêm sinh viên</h2>
    </div>

    <div class="card my-3">
        <div class="card-body">
            <div class="row">
                <div class="col-md-6 mb-3">
                    <label class="form-label">Mã nhân viên</label>
                    <asp:TextBox ID="txtMaNV" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Họ</label>
                    <asp:TextBox ID="txtHo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Tên lót</label>
                    <asp:TextBox ID="txtTenLot" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Tên</label>
                    <asp:TextBox ID="txtTen" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Ngày sinh</label>
                    <asp:TextBox ID="txtNgaySinh" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Địa chỉ</label>
                    <asp:TextBox ID="txtDiaChi" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Phái</label>
                    <asp:DropDownList ID="ddlPhai" CssClass="form-control" runat="server">
                        <asp:ListItem Value="NAM">Nam</asp:ListItem>
                        <asp:ListItem Value="NU">Nữ</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Hệ số lương</label>
                    <asp:TextBox ID="txtHSLuong" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Mã người quản lý</label>
                    <asp:DropDownList ID="ddlMaNQL" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-6 mb-3">
                    <label class="form-label">Mã phòng</label>
                    <asp:DropDownList ID="ddlMaPhong" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="col-md-12 mb-3">
                    <asp:Button ID="btnAdd" CssClass="btn btn-success" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
