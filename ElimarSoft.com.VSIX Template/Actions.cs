using Community.VisualStudio.Toolkit;
using ElimarSoft.com.VSIX_Template.Commands;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.TextManager.Interop;
using System.Diagnostics;
using System.Collections.Generic;
namespace ElimarSoft.com.VSIX_Template
{
    internal class Actions
    {
        //*******************************************************************************************************************
        internal static IMenuCommandService myCommandService { get; set; }
        internal static EnvDTE.DTE myDTEService { get; set; }
        internal static IVsTextView myTextView { get; set; }
        //*******************************************************************************************************************
        internal async static void Exec(object s, EventArgs e)
        {
            DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
            CommandID commandID = new CommandID(GetGuid(), (int)myCommands.ECMD_VIEWDEPENDENCIES);
            var menuCommand = (s as MenuCommand);
            switch (menuCommand.CommandID.ID)
            {
                case PackageIds.IDBI_ES_CONTEXT_BUTTON1:
                    FormatText.InsertBraces(docView); break;
                case PackageIds.IDBI_ES_CONTEXT_BUTTON2:
                    FormatText.RemoveBraces(docView); break;
                case PackageIds.IDBI_ES_CONTEXT_BUTTON3:
                    FormatText.DeleteLines(docView); break;
                case PackageIds.IDM_ES_CONTEXT_MENU1_GRP1_BUTTON1:
                    new SelectRegion(docView); break;
                case PackageIds.IDM_ES_CONTEXT_MENU1_GRP1_BUTTON2:
                    new FillRegion(docView); break;
                case PackageIds.IDBI_ES_CONTEXT_BUTTON4:
                    ExecCommand("Edit.FormatDocument"); break;
                case PackageIds.IDBI_ES_CONTEXT_BUTTON5:
                    Test02(); break;
            }
        }
        //*******************************************************************************************************************
        internal static void ExecCommand(string cmd) => myDTEService.ExecuteCommand(cmd);
        //*******************************************************************************************************************
        internal static void Test01()
        {
            myTextView.GetSelection(piAnchorLine: out int sl, piAnchorCol: out int sc, piEndLine: out int el, piEndCol: out int ec);
            myTextView.GetSelectedText(out string text);
            myTextView.GetBuffer(out var buf);
            buf.GetLineCount(out int lineCount);
            TextSpan pSpan = new TextSpan();
            //pSpan.iStartLine = sl;
            //pSpan.iEndLine = el+8;
            //pSpan.iStartIndex = sc;
            //pSpan.iEndIndex = ec;
            TextSpan[] textSpans = { pSpan };
            myTextView.GetSelectionSpan(textSpans);
            myTextView.GetCaretPos(out int piLine, out int piCol);
            ExecCommand("Edit.FormatDocument");
            myTextView.SetCaretPos(piLine, piCol);
            System.Diagnostics.Debug.Print("{0:d4}, {1:d4}, {2:d4}, {3:d4} {4}", sl, sc, el, ec, text);
            //FormatText2.InsertBraces(myTextView);
        }
        internal async static void Test02()
        {
            //**********************************************************************************
            IEnumerable<Project> projs = await VS.Solutions.GetAllProjectsAsync();
            foreach(Project proj in projs)
            {
                Debug.Print(proj.Name);
                foreach(SolutionItem item in proj.Children)
                {
                    //Debug.Print("\t"+item.Name);
                }
            }
            //**********************************************************************************
            Solution solution  = VS.Solutions.GetCurrentSolution();
            foreach (SolutionItem item1 in solution.Children)
            {
                Debug.Print(item1.Name);
                foreach (SolutionItem item2 in item1.Children)
                {
                    //Debug.Print("\t" + item2.Name);
                }
            }
            //**********************************************************************************
            uint grfGetOpts = 0;
            uint cProjects = 1;
            string[] rgbstrProjectNames = new string[36];
            myCommandFactory.solution.GetProjectFilesInSolution
                (grfGetOpts, cProjects, rgbstrProjectNames, out uint pcProjectsFetched);
            //**********************************************************************************
        }
        //*******************************************************************************************************************
        internal static Guid GetGuid()
        {
            //return Microsoft.VisualStudio.VSConstants.CMDSETID.SolutionExplorerPivotList_guid;
            //return Microsoft.VisualStudio.VSConstants.CMDSETID.StandardCommandSet2010_guid;
            //return Microsoft.VisualStudio.VSConstants.CMDSETID.StandardCommandSet2010_guid;
            return Microsoft.VisualStudio.VSConstants.CMDSETID.ShellMainMenu_guid;
            //return Microsoft.VisualStudio.VSConstants.CMDSETID.StandardCommandSet2K_guid;
            //return PackageGuids.ElimarSoft_com_VSIX_Template;
            //return Guid.Empty;
        }
        //*******************************************************************************************************************
    }
}
