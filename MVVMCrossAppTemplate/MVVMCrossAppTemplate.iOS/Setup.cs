using MVVMCrossAppTemplate.Core;
using MvvmCross.Platforms.Ios.Core;
using UIKit;
using MvvmCross.IoC;

namespace MVVMCrossAppTemplate.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override IMvxIoCProvider InitializeIoC()
        {
            return base.InitializeIoC();
        }
    }
}
