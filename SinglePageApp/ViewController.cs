using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using UIKit;

namespace SinglePageApp
{
    public partial class ViewController : UIViewController
    {
        private const string Authority = "https://login.microsoftonline.com/common";
        private const string ClientId  = "a5d92493-ae5a-4a9f-bcbf-9f1d354067d3";
        private const string Resource  = "https://graph.windows.net";
        private const string ReturnUrl = "http://MyDirectorySearcherApp";

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            GetTokenButton.TouchUpInside += async (sender, e) =>
            {
                try
                {
                    // Use ADAL directly in this app
                    //var context = new AuthenticationContext(authority);
                    //var platformParameters = new PlatformParameters(this);
                    //var response = await context.AcquireTokenAsync(resource, clientId, new Uri(returnUrl), platformParameters);
                    //TokenTextView.Text = response.AccessToken;

                    // Use ADAL via another PCL
                    var tokenService = new PortableLibrary.TokenService(Authority);
                    var platformParameters = new PlatformParameters(this);
                    var token = await tokenService.GetTokenAsync(Resource, ClientId, ReturnUrl, platformParameters);
                    TokenTextView.Text = token;
                }
                catch (Exception ex)
                {
                    TokenTextView.Text = $"Exception: {ex.Message}";
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
