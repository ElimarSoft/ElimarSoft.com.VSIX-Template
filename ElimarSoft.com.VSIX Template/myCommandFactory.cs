using Microsoft.VisualStudio;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TextManager.Interop;

namespace ElimarSoft.com.VSIX_Template
{
    internal sealed class myCommandFactory
    {

        internal static IVsTextManager textManager;
        internal static IVsSolutionBuildManager solutionBuildManager;
        internal static IVsAppCommandLine appCommandLine;
        internal static IVsShell shell;
        internal static IVsUIShell uiShell;
        internal static IVsOpenProjectOrSolutionDlg openProjectOrSolutionDlg;
        internal static IVsSolution solution;
        internal static IVsStatusbar statusbar;

        //*******************************************************************************************************************
        private readonly IMenuCommandService _commandService;
        //*******************************************************************************************************************
        private myCommandFactory(IMenuCommandService commandService) { _commandService = commandService; }
        //*******************************************************************************************************************
        // Static entry point
        //*******************************************************************************************************************
        public static async Task<myCommandFactory> CreateAsync(AsyncPackage package)
        {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(package.DisposalToken);

            IMenuCommandService commandService = (IMenuCommandService)await package.GetServiceAsync(typeof(IMenuCommandService));
            EnvDTE.DTE DTEService = (EnvDTE.DTE)await package.GetServiceAsync(typeof(EnvDTE.DTE));
      
            Actions.myCommandService = commandService;
            Actions.myDTEService = DTEService;


            await LinkServices();
            return new myCommandFactory(commandService);
        }
        //*******************************************************************************************************************
        public static async Task<bool> LinkServices()
        {
            textManager = await ServiceProvider.GetGlobalServiceAsync<SVsTextManager, IVsTextManager>(swallowExceptions: false);
            solutionBuildManager = await ServiceProvider.GetGlobalServiceAsync<SVsSolutionBuildManager, IVsSolutionBuildManager>(swallowExceptions: false);
            appCommandLine = await ServiceProvider.GetGlobalServiceAsync<SVsAppCommandLine, IVsAppCommandLine>(swallowExceptions: false);
            shell = await ServiceProvider.GetGlobalServiceAsync<SVsShell, IVsShell>(swallowExceptions: false);
            uiShell = await ServiceProvider.GetGlobalServiceAsync<SVsUIShell, IVsUIShell>(swallowExceptions: false);
            openProjectOrSolutionDlg = await ServiceProvider.GetGlobalServiceAsync<SVsOpenProjectOrSolutionDlg, IVsOpenProjectOrSolutionDlg>(swallowExceptions: false);
            solution = await ServiceProvider.GetGlobalServiceAsync<SVsSolution, IVsSolution>(swallowExceptions: false);
            statusbar = await ServiceProvider.GetGlobalServiceAsync<SVsStatusbar, IVsStatusbar>(swallowExceptions: false);
            return true;
        }
        //*******************************************************************************************************************
        internal void Register(System.Guid commandGuid, int commandId)
        {
            var cmdId = new CommandID(commandGuid, commandId);
            var cmd = new MenuCommand(Actions.Exec, cmdId);
            _commandService.AddCommand(cmd);
        }
        //*******************************************************************************************************************
        internal void GetCommands()
        {

            //CommandID cmd1 = new CommandID(Microsoft.VisualStudio.VSConstants.CMDSETID.ShellMainMenu_guid, (int)myCommands.cmdidAbout);
            CommandID cmd1 = new CommandID(PackageGuids.ElimarSoft_com_VSIX_Template, PackageIds.IDBI_ES_CONTEXT_BUTTON1);
            MenuCommand cl = _commandService.FindCommand(cmd1);
            if (cl != null)
            {
                System.Diagnostics.Debug.Print("Bad Command");
            }

        }



        //*******************************************************************************************************************
    }
}
