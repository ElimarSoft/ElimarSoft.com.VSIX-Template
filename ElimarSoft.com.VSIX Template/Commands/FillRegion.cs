using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ElimarSoft.com.VSIX_Template.Commands
{
    internal class FillRegion
    {
        List<string> outList = new();
        List<string> srcList = new();
        List<string> tags = new();
        Microsoft.CSharp.CSharpCodeProvider codeProvider = new Microsoft.CSharp.CSharpCodeProvider();
        string[] sourceVarArray;
        string[] resultVarArray;
        List<List<string>> blockList = new();
        //*******************************************************************************************************************
        internal FillRegion(DocumentView docView)
        {
            const string SepStr = "\r\n";
            if (docView == null) return;
            int textLength = docView.TextBuffer.CurrentSnapshot.Length;
            ProcessLines(docView.TextBuffer.CurrentSnapshot.Lines);
            docView.TextBuffer.Replace(new Span(0, textLength), String.Join(SepStr, outList));
        }
        //*******************************************************************************************************************
        private void ProcessLines(IEnumerable<ITextSnapshotLine> bufLines)
        {
            bool BlockOn = false, SourceOn = false, ResultOn = false;
            outList.Clear();
            foreach (var bufline in bufLines)
            {
                string line = bufline.GetText();
                // Block OFF
                if (line.Trim().StartsWith(Const.EndBlock))
                {
                    if (SourceOn) { SourceOn = false; }
                    else if (ResultOn) { ResultOn = false; ProcessSource(); }
                    else if (BlockOn) BlockOn = false;
                }
                // Actions
                if (BlockOn && !SourceOn && !ResultOn)
                    ReadTableData(line);
                if (SourceOn)
                    srcList.Add(line);
                if (!ResultOn)
                    outList.Add(line);
                // Block ON
                if (line.Trim().StartsWith(Const.StartBlock)) { BlockOn = true; InitLists(); }
                else if ((line.Trim().StartsWith(Const.SourceBlock)) && BlockOn) SourceOn = true;
                else if ((line.Trim().StartsWith(Const.ResultBlock)) && BlockOn) ResultOn = true;
            }
        }
        //*******************************************************************************************************************
        private void InitLists()
        {
            srcList.Clear();
            blockList.Clear();
            tags.Clear();
        }
        //*******************************************************************************************************************
        internal void ReadTableData(string line)
        {
            if (line.Trim().StartsWith("//"))
            {
                int index = line.IndexOf(Const.DataBlock);
                if (index > 0)
                {
                    string[] DataArray = line.Substring(index).Split(',');
                    int listIndex = int.Parse(DataArray[1]);
                    while (blockList.Count < listIndex + 1) blockList.Add(new());
                    for (int i = 2; i < DataArray.Length; i++) blockList[listIndex].Add(DataArray[i].Trim());
                }
            }
        }
        //*******************************************************************************************************************
        internal void ProcessSource()
        {
            if (blockList.Count < 2) return;
            sourceVarArray = blockList[0].ToArray();
            for (int i = 1; i < blockList.Count; i++)
            {
                resultVarArray = blockList[i].ToArray();
                foreach (var line in srcList) outList.Add(Regex.Replace(line, Const.RegExp1, MatchEvaluatorRutine));
                outList.Add(String.Empty);
            }
            ShowInformation();
        }
        //*******************************************************************************************************************
        private void ShowInformation()
        {
            outList.Add("// This code has been automatically generated based on text substitution of previous block");
            if (tags.Count > 0)
            {
                string tagAll = "// These Tags have been omitted";
                foreach (var tag in tags) tagAll += "," + tag;
                outList.Add(tagAll);
            }
        }
        //*******************************************************************************************************************
        public string MatchEvaluatorRutine(Match match)
        {
            for (int i = 0; i < sourceVarArray.Length; i++) if (sourceVarArray[i] == match.Value) return resultVarArray[i];
            if (!(tags.IndexOf(match.Value) > -1)) if (codeProvider.IsValidIdentifier(match.Value)) tags.Add(match.Value);
            return match.Value;
        }
        //*******************************************************************************************************************
    }
}
