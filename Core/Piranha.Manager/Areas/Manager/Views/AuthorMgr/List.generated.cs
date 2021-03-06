﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.AuthorMgr
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/AuthorMgr/List.cshtml")]
    public partial class List : System.Web.Mvc.WebViewPage<dynamic>
    {
        public List()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
  
	ViewBag.Title = Piranha.Manager.Resources.Author.ListTitle;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("script", () => {

WriteLiteral("\r\n");

WriteLiteral("\t");

            
            #line 5 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
Write(Html.Partial("Partial/Editor", new { height = 150, autoresize = false }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n\t\tko.applyBindings(new manager.models.author({\r\n\t\t\taddTitle: \'");

            
            #line 9 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
                  Write(Piranha.Manager.Resources.Author.AddTitle);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n\t\t\teditTitle: \'");

            
            #line 10 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
                   Write(Piranha.Manager.Resources.Author.EditTitle);

            
            #line default
            #line hidden
WriteLiteral("\'\r\n\t\t}));\r\n\t</script>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n");

WriteLiteral("\t");

            
            #line 16 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
Write(Html.Partial("Partial/EditAuthor"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t<table");

WriteLiteral(" id=\"authorList\"");

WriteLiteral(" class=\"table table-striped table-main\"");

WriteLiteral(">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>");

            
            #line 21 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
               Write(Piranha.Manager.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n\t\t\t\t<th>");

            
            #line 22 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
               Write(Piranha.Manager.Resources.Global.Email);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n\t\t\t\t<th");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 23 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
                            Write(Piranha.Manager.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n\t\t\t\t<th");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\Manager\Views\AuthorMgr\List.cshtml"
                            Write(Piranha.Manager.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n\t\t\t\t<th");

WriteLiteral(" class=\"actions one\"");

WriteLiteral("></th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n\t\t\t<!-- ko foreach: { data: items, as: \'item\' } -->\r\n\t\t\t<tr");

WriteLiteral(" data-bind=\"attr: { \'data-id\': item.Id }, css: { \'pre-saved\': Saved }\"");

WriteLiteral(">\r\n\t\t\t\t<td>\r\n\t\t\t\t\t<img");

WriteLiteral(" class=\"gravatar\"");

WriteLiteral(" data-bind=\"attr: { src: item.GravatarUrl }\"");

WriteLiteral(" />\r\n\t\t\t\t\t<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-bind=\"click: function (item) { $root.edit(item.Id); }, text: item.Name\"");

WriteLiteral("></a>\r\n\t\t\t\t</td>\r\n\t\t\t\t<td");

WriteLiteral(" data-bind=\"text: item.Email\"");

WriteLiteral("></td>\r\n\t\t\t\t<td");

WriteLiteral(" data-bind=\"text: item.Updated\"");

WriteLiteral("></td>\r\n\t\t\t\t<td");

WriteLiteral(" data-bind=\"text: item.Created\"");

WriteLiteral("></td>\r\n\t\t\t\t<td");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n\t\t\t\t\t<a");

WriteLiteral(" class=\"delete\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-bind=\"click: function (item) { $root.delete(item.Id); }\"");

WriteLiteral("></a>\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t\t<!-- /ko -->\r\n\t\t</tbody>\r\n\t</table>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
