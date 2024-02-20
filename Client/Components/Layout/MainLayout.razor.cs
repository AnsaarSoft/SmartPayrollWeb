using Client.Services;
using Microsoft.AspNetCore.Components;

namespace Client.Components.Layout
{
    public partial class MainLayout
    {
        #region Dependency
        [Inject] NavigationManager navigation {  get; set; }
        //[Inject] AccountService accountService { get; set; }

        #endregion

        #region Variable
        bool _drawerOpen = true;

        #endregion

        #region Functions

        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        async Task Logout()
        {
            try
            {
                await Task.Delay(1000);
                navigation.NavigateTo("login");
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
    }
}
