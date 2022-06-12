/// <summary>
/// Contains all models of this Avalonia application.
/// </summary>
namespace SpaghettiCh2.Models
{
    /// <summary>
    /// Translate these strings please:
    /// (I was too lazy to move them into a file)
    /// </summary>
    public static class StringsModel
    {
        public static string StatusAllGood => "Everything in order!";
        public static string StatusFileDoesNotExist => "File does not exist.";
        public static string StatusRunningScript => "Installing the translation ...";
        public static string StatusLoading => "Loading game files ...";
        public static string StatusSaving => "When saving, DO NOT close the window";
        public static string StatusDone => "Completed. You can close me and start the game!";
        public static string AssetsDoNotExist => "The path to the assets for translation does not exist. \nPlease \n re-download the installer ->";
        public static string AssetsVersionError => "Error reading Asset version. \nPlease \n re-download the installer ->";
        public static string ERROR => "ERROR: {0}";
        public static string StatusNoGame => "No valid game file selected, press Browse";
        public static string DialogFilterName => "Game files (* .exe, * .app, * .win, * .ios, * .unx)";
        public static string DialogTitle => "Select DELTARUNE.exe, .app or data.win";
        public static string WebsiteLink => "https://undertaleita.net/deltarune.html";
        public static string StatusFormat => "Status: {0}";
        public static string UIVersionStringFormat => "Installer Version: {0} \nAssets Version: {1} \nDebug Info: {2}";
        public static string UIGreeting => "Undertale / Deltarune Patch Italian \nof the Undertale Spaghetti Project";
        public static string UIBelowGreeting => "Choose what to do:";
        public static string UIButtonInstall => "Install";
        public static string UIButtonWebsite => "Visit our site";
        public static string UIAboveTextBox => "Game path:";
        public static string UIButtonBrowse => "Browse ...";
        public static string UIButtonApply => "Apply the patch!";
        // ... or "your game path here"
        public static string UIBoxWatermark => "Press 'Browse' to choose the game ...";
        public static string UIWindowTitle => "Undertale / Deltarune Patcher of the USP";
        public static string UIAssetDirRO => "Using temp dir for assets";
        public static string UICheckingForUpdates => "Looking for updates ...";
        public static string UIDownloadingUpdate => "Update found, in download ...";
    }
}