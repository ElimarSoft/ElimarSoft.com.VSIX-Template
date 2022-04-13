using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ElimarSoft.com.VSIX_Template.Commands
{
    internal class SelectRegion
    {
        internal SelectRegion(DocumentView docView)
        {
            if (docView?.TextView == null) return;
            SnapshotSpan? selection = docView?.TextView.Selection.SelectedSpans.FirstOrDefault();
            string selectedText = docView?.TextView.Selection.StreamSelectionSpan.GetText();
            String[] dataBlocks = new string[2];
            dataBlocks[0] = GetTagList(selectedText);
            dataBlocks[1] = dataBlocks[0].Replace(",0,", ",1,");
            string preText = Const.StartBlock + Const.nl; ;
            foreach (string block in dataBlocks) preText += block + Const.nl;
            preText += Const.SourceBlock + Const.nl; ;
            string postText = Const.SourceBlockEnd + Const.nl;
            postText += Const.ResultBlock + Const.nl;
            postText += Const.ResultBlockEnd + Const.nl;
            postText += Const.StartBlockEnd + Const.nl;
            if (selection.HasValue) docView.TextBuffer.Replace(selection.Value, preText + selectedText + postText);
        }
        //*******************************************************************************************************************
        private string GetTagList(string selection)
        {
            List<string> tagsProc = new List<string>();
            var Tags = Regex.Matches(selection, Const.RegExp1);
            foreach (var tagObj in Tags)
            {
                string Tag = (tagObj as Match).Value;
                if (tagsProc.IndexOf(Tag) < 0) tagsProc.Add(Tag);
            }
            string result = "// " + Const.DataBlock + ",0";
            foreach (var tag in tagsProc) result += "," + tag;
            return result;
        }
        //*******************************************************************************************************************
    }
}
