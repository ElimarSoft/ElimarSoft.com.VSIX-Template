global using Microsoft.VisualStudio.Shell;
global using System;
global using Task = System.Threading.Tasks.Task;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace ElimarSoft.com.VSIX_Template
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(PackageGuids.ElimarSoft_com_VSIX_TemplateString)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideBindingPath]
    public sealed class MyCompanyPackage : AsyncPackage
    {
        //*******************************************************************************************************************
        // Entry point
        //*******************************************************************************************************************
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            //System.Diagnostics.Debug.WriteLine("InitializeAsync");
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            var commandFactory = await myCommandFactory.CreateAsync(this);
            RegisterPackages(commandFactory);
            commandFactory.GetCommands();

        }

        //*******************************************************************************************************************
        private static void RegisterPackages(myCommandFactory factory)
        {
            var packageIds = new PackageIds();
            foreach (var field in packageIds.GetType().GetFields())
                if (field.GetValue(packageIds) is int intField)
                    factory.Register(PackageGuids.ElimarSoft_com_VSIX_Template, intField);
        }
        //*******************************************************************************************************************

        //*******************************************************************************************************************
    }


}
