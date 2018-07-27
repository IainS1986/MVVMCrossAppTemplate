using MVVMCrossAppTemplate.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace MVVMCrossAppTemplate.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            //AppCenter.Start("", typeof(Analytics), typeof(Crashes));

            return base.FinishedLaunching(application, launchOptions);
        }
    }
}
