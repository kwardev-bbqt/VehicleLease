using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace VehicleLease.HtmlHelpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString ActionLinkButton(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues = null, object htmlAttributes = null, string btnClass = "action-btn-primary")
        {
            var attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes ?? new { });

            // Add default classes
            if (attributes.ContainsKey("class"))
            {
                attributes["class"] += " action-btn " + btnClass;
            }
            else
            {
                attributes["class"] = "action-btn " + btnClass;
            }

            return htmlHelper.ActionLink(linkText, actionName, controllerName, routeValues, attributes);
        }

        public static MvcHtmlString ActionLinkIconButton(this HtmlHelper htmlHelper, string iconClass, string linkText, string actionName, string controllerName, object routeValues = null, object htmlAttributes = null, string btnClass = "action-btn-primary")
        {
            var icon = new TagBuilder("i");
            icon.AddCssClass(iconClass);

            var text = new TagBuilder("span");
            text.InnerHtml = linkText;

            var linkTextWithIcon = icon.ToString(TagRenderMode.Normal) + text.ToString(TagRenderMode.Normal);

            return ActionLinkButton(htmlHelper, linkTextWithIcon, actionName, controllerName, routeValues, htmlAttributes, btnClass);
        }
    }
}