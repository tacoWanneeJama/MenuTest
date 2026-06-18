namespace MenuTest.Layout
{
    public partial class NavMenu
    {

        private System.Timers.Timer _delayConnectTimer = new System.Timers.Timer(1_000);

        private bool _vanstatusEnabled = true;
        private bool _showWastePicturesForm = true;
        private bool _showWastePictureApproval;
        private bool _showVanHealthForm = true;
        private bool _supportRegistrations = true;
        private bool _supportCms = false;
        private bool _supportAnalysis = false;
        private bool _supportKcc = false;
        private bool _supportBincoach = false;
        private bool _supportAnalytics = false;
        private bool _supportWasteport = false;
        private bool _editUserEnabled = false;
        private bool _serviceVisible = true;
        private bool _serviceTablesVisible = false;
        private bool _menuEditorVisible = false;
        private bool _customerSettingsEnabled = false;
        private bool _showErrorLogging = false;
        private bool _changeCustomerEnabled = false;
        private bool _dashboardEnabled = false;
        private bool _navigationEnabled = false;

        private int _serviceOpenActionsNumber = 0;
        private int _downloadedBackgroundtaskCount = 0;

        // values shown in the form
        private string CompanyName = "- Bedrijf -";

        private string CompanyLogoSVG = "";



        private void DisableAllAuthorisations()
        {
            _vanstatusEnabled = false;
            _showWastePicturesForm = false;
            _showWastePictureApproval = false;
            _showVanHealthForm = false;
            _supportRegistrations = false;
            _supportAnalysis = false;
            _supportKcc = false;
            _supportCms = false;
            _supportBincoach = false;
            _supportWasteport = false;
            _editUserEnabled = false;
            _serviceVisible = false;
            _serviceTablesVisible = false;
            _menuEditorVisible = false;
            _customerSettingsEnabled = false;
            _showErrorLogging = false;
            _changeCustomerEnabled = false;
            _supportAnalytics = false;
            _serviceOpenActionsNumber = 0;
            _dashboardEnabled = false;
            _navigationEnabled = false;
        }

        protected override async Task OnInitializedAsync()
        {
            DisableAllAuthorisations();
            await base.OnInitializedAsync();
        }


    }
}
