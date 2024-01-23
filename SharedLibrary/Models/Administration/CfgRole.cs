namespace SharedLibrary.Models.Administration
{
    public class CfgRole
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        [StringLength(10)]
        public string DocSeries { get; set; } = string.Empty;
        public int SortNo { get; set; }
        [StringLength(50)]
        public string DocNum { get; set; } = string.Empty;
    }
}
