namespace KodiRPC.Responses.Types.Video.Details
{
    public class TvShow : Item
    {
        public string SortTitle { get; set; }
        public string MPAA { get; set; }
        public string Premiered { get; set; }

        public TvShow(string sorttitle, string mpaa, string premiered)
        {
            SortTitle = sorttitle;
            MPAA = mpaa;
            Premiered = premiered;
        }
    }
}
