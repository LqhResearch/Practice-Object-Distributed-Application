<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="WebForm.classes.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Danh sách sinh viên</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <h3 class="text-center text-danger">Danh sách lớp</h3>

            <div class="d-flex-between my-3">
                <a class="btn btn-success" href="/classes/add.aspx"><i class="fas fa-plus"></i>Thêm</a>
                <div class="input-group" style="width: 300px">
                    <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" CssClass="btn btn-info" runat="server" Text="Tìm" />
                </div>
            </div>

            <table class="table table-bordered">
                <thead>
                    <tr class="bg-info text-white">
                        <th>Mã lớp</th>
                        <th>Tên lớp</th>
                        <th width="105">Công cụ</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptClassesList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("MaLop") %></td>
                                <td><%# Eval("TenLop") %></td>
                                <td>
                                    <a class="btn btn-warning" href="/classes/edit.aspx?malop=<%# Eval("MaLop") %>"><i class="fas fa-pencil-alt"></i></a>
                                    <a class="btn btn-danger" href="?del-malop=<%# Eval("MaLop") %>"><i class="fas fa-trash-alt"></i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
