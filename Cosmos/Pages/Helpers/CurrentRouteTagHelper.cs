using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
namespace Cosmos.Pages.Helpers;

[HtmlTargetElement(Attributes = "current-route")]
public class CurrentRouteTagHelper : TagHelper
{
    [HtmlAttributeName("asp-page")]
    public string? Page { get; set; }

    [HtmlAttributeName("current-route-class")]
    public string Class { get; set; } = "demo";

    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext? ViewContext { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);

        string? page = ViewContext?.RouteData.Values["page"]?.ToString();

        var active = !String.IsNullOrWhiteSpace(Page) switch
        {
            true => String.Equals(Page!, page, StringComparison.OrdinalIgnoreCase),
            false => false
        };

        if (active)
        {
            output.AddClass(Class, HtmlEncoder.Default);
        }
    }
}