using PBHomepage.Components.Pages.ProjectPages.Print;

namespace PBHomepage.Components.Models
{
    public class ProjectDataContainer
    {
        public List<CardData> CardsData = new List<CardData>()
        {
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand"),
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand")
        };

    }

    public record CardData(string ImageLink, string ImageText, string PageLink);
}
