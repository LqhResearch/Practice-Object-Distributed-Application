<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="De_3.aspx.cs" Inherits="WebForm.De_3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Đề 3</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row g-0">
        <div class="col-md-4 p-3">
            <div class="card shadow">
                <div class="card-header text-center">
                    <h2>Bài tập: </h2>
                </div>
                <div class="card-body">
                    <p>Sắp xếp giảm dần các số lẻ trước, tăng dần các số chẳn sau và tính tổng của chúng.</p>
                </div>
            </div>
        </div>
        <div class="col-md-8 p-3">
            <div class="card shadow">
                <div class="card-header text-center">
                    <h2>Bài tập: </h2>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class="mb-3">Nhập 7 số nguyên dương: </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum1" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum2" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum3" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum4" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum5" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum6" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:TextBox ID="txtNum7" CssClass="form-control" TextMode="Number" Text="0" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <asp:Button ID="btnSubmit" CssClass="btn btn-primary" runat="server" Text="Kết quả" OnClick="btnSubmit_Click" />
                        </div>
                        <div class="col-md-12 mb-3">
                            <asp:TextBox ID="txtAns" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-md-12 mb-3">
                            <asp:TextBox ID="txtAns1" CssClass="form-control" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
