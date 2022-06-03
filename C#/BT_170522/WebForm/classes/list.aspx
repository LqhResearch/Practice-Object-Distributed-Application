<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="WebForm.classes.list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Danh sách lớp</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <div class="card">
        <div class="card-body">
            <div class="d-flex-between">
                <a class="btn btn-success" href="/classes/add.aspx"><i class="fas fa-plus"></i>Thêm</a>
                <div class="input-group" style="width: 300px">
                    <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" CssClass="btn btn-primary" runat="server" Text="Tìm" OnClick="btnSearch_Click" />
                </div>
            </div>
            <table class="table table-bordered mt-3">
                <thead>
                    <tr class="bg-primary text-white">
                        <th>Mã lớp</th>
                        <th>Tên lớp</th>
                        <th>Mã khoá học</th>
                        <th width="105">Công cụ</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rptClassesList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th scope="row"><%# Eval("MaLop") %></th>
                                <td><%# Eval("TenLop") %></td>
                                <td><%# Eval("MaKH") %></td>
                                <td>
                                    <a class="btn btn-warning" href="/classes/edit.aspx?class-id=<%# Eval("MaLop") %>"><i class="fas fa-pencil-alt"></i></a>
                                    <a class="btn btn-danger" href="?del-class-id=<%# Eval("MaLop") %>"><i class="fas fa-trash-alt"></i></a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:Label ID="lblNoData" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
