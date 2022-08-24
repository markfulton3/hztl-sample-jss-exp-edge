using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace NewProject.Models
{
    public class ContentBlock : HeadingOnly
    {
        public RichTextField Content { get; set; } = default!;
    }
}
