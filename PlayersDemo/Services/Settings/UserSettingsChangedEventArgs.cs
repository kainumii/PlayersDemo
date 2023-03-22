namespace PlayersDemo.Services.Settings
{
    public class UserSettingsChangedEventArgs : EventArgs
    {
        public UserSettingsChangedEventArgs(UserSettings settings)
        {
            Settings = settings;
        }

        public UserSettings Settings;
    }
}
