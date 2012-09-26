<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhotoGallery._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
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
