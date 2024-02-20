

namespace Client.Components.Layout
{
    public partial class AccountLayout
    {
        #region Dependency
        [Inject] NavigationManager oNavigation {  get; set; }
        #endregion

        #region Functions

        protected override async Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();
            try
            {
                await Task.Delay(500);
            }
            catch (Exception ex)
            {

            }
        }

        #endregion


    }
}
