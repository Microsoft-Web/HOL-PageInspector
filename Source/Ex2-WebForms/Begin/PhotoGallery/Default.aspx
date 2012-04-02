<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="PhotoGallery._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <ul class="thumbnails">
    <%           
    foreach (var photo in PhotoGallery.PhotoService.GetPhotos())
    { %>
        <li class="item">
            <a href="<%= ResolveUrl("/photos/" + photo.FileName) %>">
                <img alt="<%= photo.Title %>" src="<%= ResolveUrl("/photos/" + photo.FileName) %>" class="thumbnail-border" width="180" />
            </a>
                <span class="image-overlay"><%= photo.Title %></span>
        </li>
    <% } %>
</ul>
</asp:Content>
