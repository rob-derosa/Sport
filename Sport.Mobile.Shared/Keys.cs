using Microsoft.WindowsAzure.MobileServices;

namespace Sport.Mobile.Shared
{
	public class Keys
	{
		public static readonly MobileServiceAuthenticationProvider AuthenticationProvider = MobileServiceAuthenticationProvider.Google;
		public static string GoogleClientId;
		public static string GoogleServerID;
		public static readonly string MobileCenterKeyiOS = "98ff82f0-6280-48c1-b46a-c1a112d16760";
        public static readonly string MobileCenterKeyAndroid = "0b2ff72a-2b90-4f4e-89fe-8ae8d684852e";

        public static readonly string SourceCodeUrl = "https://github.com/xamarin/sport";
		public static readonly string GooglePushNotificationSenderId = "643221174110";
        public static readonly string AzureDomainLocal = "http://10.211.55.3/Sport.Service/";
        public static readonly string AzureDomainRemote = "https://xamarin-sportv2.azurewebsites.net/";

		public static readonly string GoogleClientIdiOS = "707751590419-1rv4eautkn4qlt8djvkbqa6nov0p7f0p.apps.googleusercontent.com"; //iOS App
		public static readonly string GoogleServerIdiOS = "707751590419-6kh953g6p97ad1b7iolcoar5liepacnd.apps.googleusercontent.com"; //WebApp for server
		public static readonly string GoogleServerIdAndroid = "707751590419-6kh953g6p97ad1b7iolcoar5liepacnd.apps.googleusercontent.com"; //WebApp for Android
		public static readonly string GoogleClientIdAndroid = GoogleServerIdAndroid; //Android auth uses the WebApp key

		public static string AzureDomain = AzureDomainRemote;
	}
}