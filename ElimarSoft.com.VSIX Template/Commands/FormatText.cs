using Community.VisualStudio.Toolkit;
using System.IO;
using System.Linq;

namespace ElimarSoft.com.VSIX_Template.Commands
{
    internal class FormatText
    {
        //*******************************************************************************************************************
        internal static void InsertBraces(DocumentView docView)
        {
            if (docView?.TextView == null) return;
            var selection = docView?.TextView.Selection.SelectedSpans.FirstOrDefault();
            var selectedText = docView?.TextView.Selection.StreamSelectionSpan.GetText();
            if (selection.HasValue) docView.TextBuffer.Replace(selection.Value, "{ " + selectedText + " }");
        }
        //*******************************************************************************************************************
        internal static void RemoveBraces(DocumentView docView)
        {
            if (docView?.TextView == null) return;
            var selection = docView?.TextView.Selection.SelectedSpans.FirstOrDefault();
            var selectedText = docView?.TextView.Selection.StreamSelectionSpan.GetText();
            if (selection.HasValue)
            {
                string text = selectedText.Trim();
                if (text.StartsWith("{") && text.EndsWith("}")) text = text.Substring(1, text.Length - 2);
                if (!string.IsNullOrEmpty(text))
                {
                    text = " " + text.Trim();
                    docView.TextBuffer.Replace(selection.Value, text);
                }
            }
        }
        //*******************************************************************************************************************
        internal static void DeleteLines(DocumentView docView)
        {
            if (docView == null) return;
            docView.Document.Save();
            string fileName = docView.FilePath;
            var lines = File.ReadAllLines(fileName).Where(line => !string.IsNullOrWhiteSpace(line));
            File.WriteAllLines(fileName, lines);
            docView.Document.Reload();
        }
        //*******************************************************************************************************************
    }
}
