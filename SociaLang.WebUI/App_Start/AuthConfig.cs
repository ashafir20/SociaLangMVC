using Microsoft.Web.WebPages.OAuth;

namespace SociaLang.WebUI
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "183230238553561",
                appSecret: "a6c4c7a3da3351b1f52a4474404b126c");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
