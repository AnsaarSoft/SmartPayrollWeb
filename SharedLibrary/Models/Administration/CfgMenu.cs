namespace SharedLibrary.Models.Administration
{
    public class CfgMenu
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        public bool FlgHead { get; set; }

        public bool FlgForm { get; set; }

        [StringLength(200)]
        public string FormUrl { get; set; } = string.Empty;

        public CfgMenu ParentForm { get; set; }

        [StringLength(100)]
        public string FormIcon { get; set; } = string.Empty;
    }
}
