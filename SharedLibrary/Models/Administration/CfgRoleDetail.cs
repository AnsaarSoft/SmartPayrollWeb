namespace SharedLibrary.Models.Administration
{
    public class CfgRoleDetail
    {
        public CfgRole Role { get; set; }

        public CfgMenu Form { get; set; }

        public bool FlgView { get; set; }

        public bool FlgEdit { get; set; }

        public bool FlgAdmin { get; set; }
    }
}
