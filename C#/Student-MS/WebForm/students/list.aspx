<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="WebForm.students.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Danh sách sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server" />
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-danger">Danh sách sinh viên</h3>

            <div class="d-flex-between my-3">
                <a class="btn btn-success" href="/students/add.aspx"><i class="fas fa-plus"></i>Thêm</a>
                <div class="input-group" style="width: 300px">
                    <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" CssClass="btn btn-info fa" runat="server" Text="Tìm" OnClick="btnSearch_Click" />
                </div>
            </div>

            <table class="table table-bordered">
                <thead>
                    <tr class="bg-info text-white">
                        <th>Mã số sinh viên</th>
                        <th>Họ tên</th>
                        <th>Quê quán</th>
                        <th>Năm sinh</th>
                        <th>Giới tính</th>
                        <th>Mã lớp</th>
                        <th width="105">Công cụ</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptStudentsList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("MSSV") %></td>
                                <td><%# Eval("HoTen") %></td>
                                <td><%# Eval("QueQuan") %></td>
                                <td><%# Eval("NamSinh") %></td>
                                <td><%# Eval("GioiTinh") %></td>
                                <td><%# Eval("MaLop") %></td>
                                <td>
                                    <a class="btn btn-warning" href="/students/edit.aspx?mssv=<%# Eval("MSSV") %>"><i class="fas fa-pencil-alt"></i></a>
                                    <a class="btn btn-danger" href="?del-mssv=<%# Eval("MSSV") %>"><i class="fas fa-trash-alt"></i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
