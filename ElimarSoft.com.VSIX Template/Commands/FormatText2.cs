using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.TextManager.Interop;
using System.IO;
using System.Linq;

namespace ElimarSoft.com.VSIX_Template.Commands
{
    internal class FormatText2
    {
        //*******************************************************************************************************************
        internal static void InsertBraces(IVsTextView textView)
        {
            var docView = textView.ToDocumentView();

            if (docView?.TextView == null) return;
            var selection = docView?.TextView.Selection.SelectedSpans.FirstOrDefault();
            var selectedText = docView?.TextView.Selection.StreamSelectionSpan.GetText();
            if (selection.HasValue) docView.TextBuffer.Replace(selection.Value, "{ " + selectedText + " }");
        }
        //*******************************************************************************************************************
    }
    //*******************************************************************************************************************
    internal class FormatText3
    {
        //*******************************************************************************************************************
        internal static void InsertBraces(IVsTextView textView)
        {

            //if (textView == null) return;
            ////textView.GetBuffer(out IVsTextLines lines);

            //textView.GetSelectedText(out string selectedText);
            //textView.GetSelection(out int sl, out int sc, out int el, out int ec);
            //string newText = "["+selectedText+"]";
            //textView.ReplaceTextOnLine(sl,sc, selectedText.ToCharArray().Length, newText,newText.ToCharArray().Length);


        }
        //*******************************************************************************************************************
    }
}
