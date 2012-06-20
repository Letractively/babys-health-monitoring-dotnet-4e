﻿<%@ Page Title="BHM - (Dinkes) Laporan" Language="C#" MasterPageFile="~/Dinkes.Master" AutoEventWireup="true"
    CodeBehind="LaporanGizi.aspx.cs" Inherits="Bhm.Web.DinasKes.LaporanGizi" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Laporan Gizi Balita</h2>
    <div class="accountInfo">
        <fieldset class="register">
            <legend>Pilih Kecamatan</legend>
            <p>
                <asp:DropDownList ID="KecamatanDropDown" runat="server" />
                <asp:Button ID="CariKecamatanButton" runat="server" Text="Cari" OnClick="Cari_Clicked" />
            </p>
        </fieldset>
    </div>
    </asp:Content>
