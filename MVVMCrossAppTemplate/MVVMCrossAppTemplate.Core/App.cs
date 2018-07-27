using MVVMCrossAppTemplate.Core.ViewModels;
using MvvmCross.ViewModels;

namespace MVVMCrossAppTemplate.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Setup.Register();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
