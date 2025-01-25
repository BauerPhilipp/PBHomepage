using PBHomepage.Components.Pages.ProjectPages.Print;

namespace PBHomepage.Components.Models
{
    public class ProjectDataContainer
    {
        public List<CardData> CardsData = new List<CardData>()
        {
            new CardData(ImageLink:"Projects/Printing/WacomStand/Thumbnail.jpg", ImageText:"WacomStand", PageLink:"/PrintWacomStand", ProjectType.Print),
            new CardData(ImageLink:"Projects/Printing/Portafilter/Thumbnail.jpg", ImageText:"Protafilter", PageLink:"/Print/Portafilter", ProjectType.Print),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/Cooking/FiloStrudel", ProjectType.Cooking),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/PrintWacomStand", ProjectType.Cooking),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/PrintWacomStand", ProjectType.Cooking),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/PrintWacomStand", ProjectType.Cooking),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/PrintWacomStand", ProjectType.Cooking),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/PrintWacomStand", ProjectType.Cooking),
            new CardData(ImageLink:"Projects/Cooking/FiloStrudel/Thumbnail.jpg", ImageText:"FiloStrudel", PageLink:"/PrintWacomStand", ProjectType.Cooking)

        };

    }

    public record CardData(string ImageLink, string ImageText, string PageLink, ProjectType ProjectType);
}
