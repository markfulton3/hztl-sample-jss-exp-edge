using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace NewProject.Models
{
    public class Tab
    {
        public TextField Title { get; set; } = default!;

        public RichTextField Content { get; set; } = default!;
    }
}
