namespace Client.Components.Pages.AccountManagement
{
    public partial class Login : ComponentBase
    {

        #region Variable
        MstUser model = new();
        
        #endregion

        #region Dependency
        [Inject] ILogger<Login> logger { get; set; }
        [Inject] NavigationManager navigation { get; set; }

        #endregion

        #region Function

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            //return base.OnInitializedAsync();
            model.UserCode = string.Empty;
            model.Password = string.Empty;

        }

        void OnSubmit()
        {
            navigation.NavigateTo("/");
        }

        #endregion
    }
}
