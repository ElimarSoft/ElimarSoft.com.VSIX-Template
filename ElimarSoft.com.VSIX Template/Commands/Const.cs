using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElimarSoft.com.VSIX_Template.Commands
{
    internal static class Const
    {
        internal const string repPath = @"C:\Users\jsala\source\repos\";
        internal const string RegExp1 = "([A-Za-z@\"]+[A-Za-z0-9_\"]*)";

        internal const string StartBlock = "#region -> ElimarSoft.Block";
        internal const string SourceBlock = "#region -> ElimarSoft.Source";
        internal const string ResultBlock = "#region -> ElimarSoft.Result";
        internal const string StartBlockEnd = "#endregion ElimarSoft.Block";
        internal const string SourceBlockEnd = "#endregion ElimarSoft.Source";
        internal const string ResultBlockEnd = "#endregion ElimarSoft.Result";
        internal const string EndBlock = "#endregion";
        internal const string nl = "\r\n";
        internal const string DataBlock = "DataBlock";
    }
}
