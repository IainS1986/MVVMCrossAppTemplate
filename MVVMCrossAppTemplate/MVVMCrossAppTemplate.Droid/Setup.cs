using Android.Content;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.IoC;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Presenters;
using MVVMCrossAppTemplate.Core;

namespace MVVMCrossAppTemplate.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override IMvxIoCProvider InitializeIoC()
        {
            return base.InitializeIoC();
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter() => new MvxAppCompatViewPresenter(AndroidViewAssemblies);

    }
}
