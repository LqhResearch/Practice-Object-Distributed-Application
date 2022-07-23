<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Hiển thị nhân viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="my-3">
        <h2 class="text-primary text-center">Danh sách sinh viên</h2>
    </div>

    <div class="card my-3">
        <div class="card-body">
            <a href="/Add.aspx" class="btn btn-success"><i class="fas fa-plus"></i>Thêm</a>
        </div>
    </div>

    <div class="card my-3">
        <div class="card-body">
            <table class="table table-bordered">
                <thead>
                    <tr class="bg-primary text-white">
                        <th>Mã nhân viên</th>
                        <th>Họ</th>
                        <th>Tên lớp</th>
                        <th>Tên</th>
                        <th>Ngày sinh</th>
                        <th>Phái</th>
                        <th>Địa chỉ</th>
                        <th>Hệ số lương</th>
                        <th>Mã người quản lý</th>
                        <th>Mã phòng</th>
                        <th>Sửa</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("MANV") %></td>
                                <td><%# Eval("HONV") %></td>
                                <td><%# Eval("TENLOTNV") %></td>
                                <td><%# Eval("TENNV") %></td>
                                <td><%# Convert.ToDateTime(Eval("NGAYSINH")).ToString("dd-MM-yyyy") %></td>
                                <td><%# Eval("PHAI") %></td>
                                <td><%# Eval("DIACHI") %></td>
                                <td><%# Eval("HSLUONG") %></td>
                                <td><%# Eval("MANQL") %></td>
                                <td><%# Eval("MAPHONG") %></td>
                                <td>
                                    <a class="btn btn-warning" href="/Update.aspx?id=<%# Eval("MANV") %>"><i class="fas fa-marker"></i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
