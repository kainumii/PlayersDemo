namespace PlayersDemo.Services.Settings
{
    public class UserSettingsService : IUserSettingsService
    {
        public UserSettings UserSettings { get; set; } = new UserSettings
        {
            AppTitle = "Default App title",
            MyProperty = "Property"
        };

        public event EventHandler<UserSettingsChangedEventArgs> UserSettingsChanged;

        public void RaiseSettingsChanged()
        {
            if(UserSettingsChanged != null)
                UserSettingsChanged.Invoke(this, new UserSettingsChangedEventArgs(UserSettings));
        }
    }
}
