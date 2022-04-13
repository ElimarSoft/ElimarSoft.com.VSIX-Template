namespace ElimarSoft.com.VSIX_Template
{
    internal enum myIDs
    {
        IDM_VS_TOOL_MAINMENU = 0x0000,
        IDM_VS_TOOL_STANDARD = 0x0001,
        IDM_VS_TOOL_WINDOWUI = 0x0002,
        IDM_VS_TOOL_PROJWIN = 0x0003,
        IDM_VS_TOOL_OBJECT_BROWSER_GO = 0x0007,
        IDM_VS_TOOL_CLASSVIEW_GO = 0x0008,
        IDM_VS_TOOL_OBJSEARCH = 0x0009,
        IDM_VS_TOOL_FINDALLREF = 0x000a,
        IDM_VS_TOOL_OPENWINDOWS = 0x000b,
        IDM_VS_TOOL_VIEWBAR = 0x000c,
        IDM_VS_TOOL_BUILD = 0x000d,
        IDM_VS_TOOL_TEXTEDITOR = 0x000e,
        IDM_VS_TOOL_OBJBROWSER = 0x000f,
        IDM_VS_TOOL_CLASSVIEW = 0x0010,
        IDM_VS_TOOL_PROPERTIES = 0x0011,
        IDM_VS_TOOL_DATA = 0x0012,
        IDM_VS_TOOL_SCHEMA = 0x0013,
        IDM_VS_TOOL_OUTPUTWINDOW = 0x0014,
        IDM_VS_TOOL_FINDRESULTS1 = 0x0015,
        IDM_VS_TOOL_FINDRESULTS2 = 0x0016,
        IDM_VS_TOOL_UNIFIEDFIND = 0x0017,
        IDM_VS_TOOL_FINDRESULTSTABLE = 0x0018,
        IDM_VS_TOOL_BOOKMARKWIND = 0x0019,
        IDM_VS_TOOL_CALLBROWSER1 = 0x001a,
        IDM_VS_TOOL_CALLBROWSER2 = 0x001b,
        IDM_VS_TOOL_CALLBROWSER3 = 0x001c,
        IDM_VS_TOOL_CALLBROWSER4 = 0x001d,
        IDM_VS_TOOL_CALLBROWSER5 = 0x001e,
        IDM_VS_TOOL_CALLBROWSER6 = 0x001f,
        IDM_VS_TOOL_CALLBROWSER7 = 0x0020,
        IDM_VS_TOOL_CALLBROWSER8 = 0x0021,
        IDM_VS_TOOL_CALLBROWSER9 = 0x0022,
        IDM_VS_TOOL_CALLBROWSER10 = 0x0023,
        IDM_VS_TOOL_CALLBROWSER11 = 0x0024,
        IDM_VS_TOOL_CALLBROWSER12 = 0x0025,
        IDM_VS_TOOL_CALLBROWSER13 = 0x0026,
        IDM_VS_TOOL_CALLBROWSER14 = 0x0027,
        IDM_VS_TOOL_CALLBROWSER15 = 0x0028,
        IDM_VS_TOOL_CALLBROWSER16 = 0x0029,
        IDM_VS_TOOL_TASKLIST = 0x002a,
        IDM_VS_TOOL_USERTASKS = 0x002b,
        IDM_VS_TOOL_ERRORLIST = 0x002c,
        IDM_VS_TOOL_SNIPPETMENUS = 0x002D,
        IDM_VS_CALLBROWSER_TYPE_POPUP = 0x0030,
        //////////////////////////////////////////////////////////////////////////////
        // Toolbar ID for customize mode only
        //
        // **** NOTE ****  DO NOT add any menu or toolbar that has an ID greater than
        //                 IDM_VS_TOOL_ADDCOMMAND, otherwise you WILL break customize
        //                 mode. IDM_VS_TOOL_UDEFINED is a very special toolbar.
        //                 Do not use or place it anywhere - used by shell only.
        //////////////////////////////////////////////////////////////////////////////
        IDM_VS_TOOL_UNDEFINED = 0xEDFF,
        IDM_VS_TOOL_ADDCOMMAND = 0xEE00,
        //////////////////////////////////////////////////////////////////////////////
        //
        // Menu Identifiers, created by Visual Studio Shell
        //
        //////////////////////////////////////////////////////////////////////////////
        IDM_VS_MENU_FILE = 0x0080,
        IDM_VS_MENU_EDIT = 0x0081,
        IDM_VS_MENU_VIEW = 0x0082,
        IDM_VS_MENU_PROJECT = 0x0083,
        IDM_VS_MENU_TOOLS = 0x0085,
        IDM_VS_MENU_WINDOW = 0x0086,
        IDM_VS_MENU_ADDINS = 0x0087,
        IDM_VS_MENU_HELP = 0x0088,
        IDM_VS_MENU_DEBUG = 0x0089,
        IDM_VS_MENU_FORMAT = 0x008A,
        IDM_VS_MENU_ALLMACROS = 0x008B,
        IDM_VS_MENU_BUILD = 0x008C,
        IDM_VS_MENU_CONTEXTMENUS = 0x008D,
        IDG_VS_MENU_CONTEXTMENUS = 0x008E,
        IDM_VS_MENU_REFACTORING = 0x008f,
        IDM_VS_MENU_COMMUNITY = 0x0090,
        IDM_VS_MENU_EXTENSIONS = 0x0091,
        ///////////////////////////////////////////////
        //
        // Editor menu groups
        //
        ///////////////////////////////////////////////
        IDG_VS_EDITOR_CMDS = 0x3E8A,
        IDG_VS_EDITOR_BOOKMARK_FOLDER_CMDS = 0x3EB0,
        IDG_VS_EDITOR_BOOKMARK_DOCUMENT_CMDS = 0x3EB1,
        IDG_VS_EDITOR_BOOKMARK_ALLDOCS_CMDS = 0x3EB2,
        IDG_VS_EDITOR_BOOKMARK_TASKLIST_CMDS = 0x3EB3,
        IDG_VS_EDITOR_ADVANCED_CMDS = 0x3E8F,
        IDG_VS_EDITOR_OUTLINING_CMDS = 0x3E90,
        IDG_VS_EDITOR_LANGUAGE_INFO = 0x3E93,
        IDG_VS_EDITOR_INTELLISENSE_CMDS = 0x3E94,
        IDG_TOOLS_SNIPPETS = 0x3E95,   //actually on the tools menu defined above
        IDM_VS_EDITOR_BOOKMARK_MENU = 0x3E9E,
        IDM_VS_EDITOR_ADVANCED_MENU = 0x3EA0,
        IDM_VS_EDITOR_OUTLINING_MENU = 0x3EA1,
        IDM_VS_EDITOR_INTELLISENSE_MENU = 0x3EA2,
        IDM_VS_EDITOR_FIND_MENU = 0x3EA3,
        IDM_VS_EDITOR_PASTE_MENU = 0x3EA4,
        IDM_VS_EDITOR_GOTO_MENU = 0x3EA5,
        //////////////////////////////////////////////////////////////////////////////
        //
        // Group Identifiers, created by Visual Studio Shell
        //
        //////////////////////////////////////////////////////////////////////////////
        // Main Menu Bar Groups
        IDG_VS_MM_FILEEDITVIEW = 0x0101,   // File/Edit/View menus go here
        IDG_VS_MM_PROJECT = 0x0102,   // Project menu go here
        IDG_VS_MM_BUILDDEBUGRUN = 0x0103,   // Build/Debug/Run menus go here
        IDG_VS_MM_TOOLSADDINS = 0x0104,   // Tools/Addins menu goes here
        IDG_VS_MM_WINDOWHELP = 0x0105,   // Window/Help menus go here
        IDG_VS_MM_FULLSCREENBAR = 0x0106,   // Full Screen group
                                            //VS 2005 Bug #58088   Put refactorings on top-level menu
        IDG_VS_MM_REFACTORING = 0x0107,   // Refactorings go here
        IDG_VS_MM_REFACTORING_JS = 0x0108,   // VS 2005 bug #275998
        IDG_VS_MM_TOOLS = 0x0109,   // Tools menu goes here
                                    // All Macros Groups
        IDG_VS_MM_MACROS = 0x010A,
        // File Menu Groups
        IDG_VS_FILE_NEW_PROJ_CSCD = 0x010E,
        IDG_VS_FILE_ITEM = 0x010F,
        IDG_VS_FILE_FILE = 0x0110,
        IDG_VS_FILE_ADD = 0x0111,
        IDG_VS_FILE_SAVE = 0x0112,
        IDG_VS_FILE_RENAME = 0x0113,
        IDG_VS_FILE_PRINT = 0x0114,
        IDG_VS_FILE_ACCOUNTSETTINGS = 0x0711,
        IDG_VS_FILE_MRU = 0x0115,
        IDG_VS_FILE_EXIT = 0x0116,
        IDG_VS_FILE_DELETE = 0x0117,
        IDG_VS_FILE_SOLUTION = 0x0118,
        IDG_VS_FILE_NEW_CASCADE = 0x0119,
        IDG_VS_FILE_OPENP_CASCADE = 0x011A,
        IDG_VS_FILE_OPENF_CASCADE = 0x011B,
        IDG_VS_FILE_ADD_PROJECT_NEW = 0x011C,
        IDG_VS_FILE_ADD_PROJECT_EXI = 0x011D,
        IDG_VS_FILE_FMRU_CASCADE = 0x011E,
        IDG_VS_FILE_PMRU_CASCADE = 0x011F,
        IDG_VS_FILE_BROWSER = 0x0120,
        IDG_VS_FILE_MOVE = 0x0121,
        IDG_VS_FILE_MOVE_CASCADE = 0x0122,
        IDG_VS_FILE_MOVE_PICKER = 0x0123,
        IDG_VS_FILE_MISC = 0x0124,
        IDG_VS_FILE_MISC_CASCADE = 0x0125,
        IDG_VS_FILE_MAKE_EXE = 0x0126,
        IDG_VS_FILE_OPENSCC_CASCADE = 0x0127,
        // Edit Menu Groups
        IDG_VS_EDIT_OBJECTS = 0x0128,
        IDG_VS_EDIT_UNDOREDO = 0x0129,
        IDG_VS_EDIT_CUTCOPY = 0x012A,
        IDG_VS_EDIT_SELECT = 0x012B,
        IDG_VS_EDIT_FIND = 0x012C,
        IDG_VS_EDIT_GOTO = 0x012D,
        IDG_VS_EDIT_COMMANDWELL = 0x012E,
        IDG_VS_EDIT_PASTE = 0x012F,
        // View Menu Groups
        IDG_VS_VIEW_BROWSER = 0x0130,
        IDG_VS_VIEW_PROPPAGES = 0x0131,
        IDG_VS_VIEW_TOOLBARS = 0x0132,
        IDG_VS_VIEW_FORMCODE = 0x0133,
        IDG_VS_VIEW_DEFINEVIEWS = 0x0134,
        IDG_VS_VIEW_WINDOWS = 0x0135,
        IDG_VS_VIEW_ARCH_WINDOWS = 0x0720,
        IDG_VS_VIEW_ORG_WINDOWS = 0x0721,
        IDG_VS_VIEW_CODEBROWSENAV_WINDOWS = 0x0722,
        IDG_VS_VIEW_DEV_WINDOWS = 0x0723,
        IDG_VS_WNDO_FINDRESULTS = 0x0724,
        IDG_VS_VIEW_REFRESH = 0x0136,
        IDG_VS_VIEW_NAVIGATE = 0x0137,
        IDG_VS_VIEW_SYMBOLNAVIGATE = 0x0138,
        IDG_VS_VIEW_SMALLNAVIGATE = 0x0139,
        IDG_VS_VIEW_OBJBRWSR = 0x013A,
        IDG_VS_VIEW_LINKS = 0x013B,
        IDG_VS_VIEW_COMMANDWELL = 0x013C,
        IDG_VS_VIEW_SYMBOLNAVIGATE_JS = 0x013D,   // VS 2005 bug #303148
                                                  // Project Menu Groups
        IDG_VS_PROJ_ADD = 0x0140,
        IDG_VS_PROJ_OPTIONS = 0x0141,
        IDG_VS_PROJ_REFERENCE = 0x0142,
        IDG_VS_PROJ_FOLDER = 0x0143,
        IDG_VS_PROJ_UNLOADRELOAD = 0x0144,
        IDG_VS_PROJ_ADDCODE = 0x0145,
        IDG_VS_PROJ_PROJECT = 0x0146,
        IDG_VS_PROJ_ADDREMOVE = 0x0147,
        IDG_VS_PROJ_WEB1 = 0x0148,
        IDG_VS_PROJ_WEB2 = 0x0149,
        IDG_VS_PROJ_TOOLBAR1 = 0x014A,
        IDG_VS_PROJ_TOOLBAR2 = 0x014B,
        IDG_VS_PROJ_MISCADD = 0x014C,
        IDG_VS_PROJ_SETTINGS = 0x014D,
        IDG_VS_PROJ_ADMIN = 0x014E,
        // Run Menu Groups
        IDG_VS_RUN_START = 0x0150,
        IDG_VS_DBG_STEP = 0x0151,
        IDG_VS_DBG_WATCH = 0x0152,
        IDG_VS_DBG_BRKPTS = 0x0153,
        IDG_VS_DBG_STATEMENT = 0x0154,
        IDG_VS_DBG_ATTACH = 0x0155,
        IDG_VS_DBG_TBBRKPTS = 0x0156,
        IDG_VS_DBG_DBGWINDOWS = 0x0157,   // this actually resides on the debugger toolbar
                                          //Tools->External Tools Groups
        IDG_VS_TOOLS_EXT_CUST = 0x0158,
        IDG_VS_TOOLS_EXT_TOOLS = 0x0159,
        // Tools Menu Groups
        IDG_VS_TOOLS_OPTIONS = 0x015A,
        IDG_VS_TOOLS_OTHER2 = 0x015B,
        IDG_VS_TOOLS_OBJSUBSET = 0x015C,
        IDG_VS_TOOLS_EXTENSIBILITY = 0x015F,
        // Extensions Menu Groups
        IDG_VS_EXTENSIONS = 0x6000,
        IDG_VS_EXTENSIONS_REPARENT = 0x6001,
        // Addins Menu Groups
        IDG_VS_ADDIN_BUILTIN = 0x015D,
        IDG_VS_ADDIN_MANAGER = 0x015E,
        // Window Menu Groups
        IDG_VS_WINDOW_NEW = 0x0160,
        IDG_VS_WINDOW_ARRANGE = 0x0161,
        IDG_VS_WINDOW_LIST = 0x0162,
        IDG_VS_WINDOW_NAVIGATION = 0x0163,
        IDG_VS_WINDOW_LAYOUT = 0x0164,
        IDG_VS_WINDOW_LAYOUT_LIST = 0x0165,
        IDG_VS_WINDOW_TABORIENTATION = 0x0166,   // Group for tab well orientation (left, top, right)
                                                 // Help Menu Groups
        IDG_VS_HELP_SUPPORT = 0x016A,
        IDG_VS_HELP_ABOUT = 0x016B,
        IDG_VS_HELP_ACCESSIBILITY = 0x016D,
        //#define IDG_VS_HELP_SAMPLES       0x016C
        // Standard Toolbar Groups
        IDG_VS_TOOLSB_NEWADD = 0x0170,
        IDG_VS_TOOLSB_SAVEOPEN = 0x0171,
        IDG_VS_TOOLSB_CUTCOPY = 0x0172,
        IDG_VS_TOOLSB_UNDOREDO = 0x0173,
        IDG_VS_TOOLSB_RUNBUILD = 0x0174,
        IDG_VS_TOOLSB_WINDOWS = 0x0175,   // don't use
        IDG_VS_TOOLSB_GAUGE = 0x0176,
        IDG_VS_TOOLSB_SEARCH = 0x0177,
        IDG_VS_TOOLSB_NEWWINDOWS = 0x0178,
        IDG_VS_TOOLSB_NAVIGATE = 0x0179,
        IDG_VS_FINDTAB = 0x017D,
        IDG_VS_REPLACETAB = 0x017E,
        // Window UI Toolbar Groups
        IDG_VS_WINDOWUI_LOADSAVE = 0x017A,
        // Open Windows Toolbar Groups
        IDG_VS_OPENWIN_WINDOWS = 0x017B,
        // View Bar Toolbar Groups
        IDG_VS_VIEWBAR_VIEWS = 0x017C,
        // Watch context menu groups
        IDG_VS_WATCH_EDITADDDEL = 0x0180,
        //#define IDG_VS_WATCH_COLLAPSE       0x0181
        IDG_VS_WATCH_PROCDEFN = 0x0182,
        IDG_VS_WATCH_STARTEND = 0x0183,
        // Thread context menu groups
        IDG_VS_THREAD_SUSPENDRESUME = 0x0184,
        // Hexadecimal group
        IDG_VS_DEBUG_DISPLAYRADIX = 0x0185,
        // Treegrid context menu
        IDG_VS_TREEGRID = 0x0186,
        // Immediate context menu groups
        IDG_VS_IMMD_OBPROCDEFN = 0x0188,
        // Docking / Hide Pane Group
        IDG_VS_DOCKCLOSE = 0x0189,
        IDG_VS_DOCKHIDE = 0x0190,
        IDG_VS_DOCUMENTDOCKHIDE = 0x0192,
        // Thread context menu groups
        IDG_VS_CALLST_RUNTOCURSOR = 0x0191,
        // 0x0192 is used above in IDG_VS_DOCUMENTDOCKHIDE
        // MenuDesigner Context Menu Groups
        IDG_VS_MNUDES_CUTCOPY = 0x0195,
        IDG_VS_MNUDES_INSERT = 0x0196,
        IDG_VS_MNUDES_EDITNAMES = 0x0197,
        IDG_VS_MNUDES_VIEWCODE = 0x0198,
        IDG_VS_MNUDES_PROPERTIES = 0x0199,
        IDG_VS_MNUDES_UNDOREDO = 0x019A,
        // Window Menu Cascade groups
        IDG_VS_WNDO_OTRWNDWS0 = 0x019E,
        IDG_VS_WNDO_OTRWNDWS1 = 0x019F,
        IDG_VS_WNDO_OTRWNDWS2 = 0x01A0,
        IDG_VS_WNDO_OTRWNDWS3 = 0x01A1,
        IDG_VS_WNDO_OTRWNDWS4 = 0x01A2,
        IDG_VS_WNDO_OTRWNDWS5 = 0x01A3,
        IDG_VS_WNDO_OTRWNDWS6 = 0x01A4,
        IDG_VS_WNDO_WINDOWS1 = 0x01A5,
        IDG_VS_WNDO_WINDOWS2 = 0x01A6,
        IDG_VS_WNDO_DBGWINDOWS = IDG_VS_WNDO_WINDOWS1,
        IDG_VS_WNDO_INTERACTIVEWNDWS = 0x01A7,
        // OLE Verbs Menu Cascade groups
        IDG_VS_EDIT_OLEVERBS = 0x01A8,
        // PropBrs Context menu groups
        IDG_VS_PROPBRS_MISC = 0x01AA,
        // Output Window Pane Context menu groups
        IDG_VS_RESULTSLISTCOPY = 0x01AC,
        IDG_VS_RESULTSLISTCLEAR = 0x01AD,
        IDG_VS_RESULTSLISTGOTO = 0x01AE,
        IDG_VS_RESULTSLISTOUTLINE = 0x01AF,
        // New Toolbox Context Menu groups
        IDG_VS_TOOLBOX_ACTIONS = 0x01B0,
        IDG_VS_TOOLBOX_ITEM = 0x01B1,
        IDG_VS_TOOLBOX_TAB = 0x01B2,
        IDG_VS_TOOLBOX_MOVE = 0x01B3,
        IDG_VS_TOOLBOX_VIEW = 0x01B4,
        // Miscellaneous Files project context menu groups
        IDG_VS_MISCFILES_PROJ = 0x01B8,
        // Miscellaneous Files project item context menu groups
        IDG_VS_MISCFILES_PROJITEM = 0x01BA,
        // Solution Items project item context menu groups
        IDG_VS_SOLNITEMS_PROJ = 0x01BC,
        IDG_VS_SOLNITEMS_PROJITEM = 0x01BD,
        // Stub (unloaded/placeholder) project context menu groups
        IDG_VS_STUB_PROJECT = 0x01BE,
        // Code Window context menu groups
        IDG_VS_CODEWIN_TEXTEDIT = 0x01C0,
        //#define unused menu ID            0x01C1
        IDG_VS_CODEWIN_DEBUG_WATCH = 0x01C2,
        IDG_VS_CODEWIN_DEBUG_STEP = 0x01C3,
        IDG_VS_CODEWIN_MARKER = 0x01C4,
        IDG_VS_CODEWIN_OPENURL = 0x01C5,
        IDG_VS_CODEWIN_SHORTCUT = 0x01C6,
        IDG_VS_CODEWIN_INTELLISENSE = 0x02B0,
        IDG_VS_CODEWIN_NAVIGATETOLOCATION = 0x02B1,
        IDG_VS_CODEWIN_NAVIGATETOFILE = 0x02B2,
        IDG_VS_CODEWIN_OUTLINING = 0x02B3,
        IDG_VS_CODEWIN_CTXT_OUTLINING = 0x02B4,
        IDG_VS_CODEWIN_REFACTORING = 0x02b5,
        // 0x02B6 used below in IDG_VS_FINDRESULTS1_STOPFIND
        // 0x02B7 used below in IDG_VS_FINDRESULTS2_STOPFIND
        IDG_VS_CODEWIN_REFACTORING_JS = 0x02b8,   // VS 2005 bug #275998
        IDG_VS_CODEWIN_LANGUAGE = 0x02D0,
        // Snippet flyout menu and groups
        IDG_VS_CODEWIN_SNIPPETS = 0x02D2,
        IDM_VS_CODEWIN_SNIPPET_ROOT = 0x02D3,
        IDG_VS_CODEWIN_SNIPPET_ROOT = 0x02D4,
        // Annotation flyout menu and groups
        IDG_VS_CODEWIN_ANNOTATION = 0x02D5,
        IDM_VS_CODEWIN_ANNOTATION_ROOT = 0x02D6,
        IDG_VS_CODEWIN_ANNOTATION_ROOT = 0x02D7,
        // IntelliTrace step menu groups.
        IDG_VS_CODEWIN_INTELLITRACE_STEP = 0x02D8,
        // Task List context menu groups
        IDG_VS_TASKLIST = 0x01C7,
        IDG_VS_ERRORLIST = 0x01CB,
        // cascading Task list menu groups
        IDG_VS_TASKLIST_SORT = 0x01C8,
        IDG_VS_TASKLIST_CLIENT = 0x01CA,
        // 0x01CB used above (IDG_VS_ERRORLIST)
        IDG_VS_ERRORLIST_CLIENT = 0x01CC,
        IDG_VS_ERRORLIST_NEXTPREV_ERR = 0x01CD,
        IDG_VS_TASKLIST_GROUPS = 0x01CE,
        IDG_VS_TASKLIST_COLUMNS = 0x01CF,
        IDG_VS_TASKLIST_SORT_COLUMN = 0x01D0,
        // Tasklist toolbar provider list group
        IDG_VS_TASKLIST_PROVIDERLIST = 0x01D1,
        // Build toolbar group
        IDG_VS_BUILDBAR = 0x01D2,
        // User Tasks toolbar group
        IDG_VS_USERTASKS_EDIT = 0x01D3,
        // Error List toolbar group
        IDG_VS_ERRORLIST_ERRORGROUP = 0x01D4,
        // Project Window Toolbar group
        IDG_VS_PROJ_TOOLBAR3 = 0x01D5,
        IDG_VS_PROJ_TOOLBAR4 = 0x01D6,
        IDG_VS_PROJ_TOOLBAR5 = 0x01D7,
        // More error list toolbar groups -- see IDG_VS_ERRORLIST_ERRORGROUP above
        IDG_VS_ERRORLIST_WARNINGGROUP = 0x01D8,
        IDG_VS_ERRORLIST_MESSAGEGROUP = 0x01D9,
        IDG_VS_ERRORLIST_FILTERLISTTOGROUP = 0x01DA,
        IDG_VS_ERRORLIST_FILTERCATEGORIESGROUP = 0x01DB,
        IDG_VS_ERRORLIST_BUILDGROUP = 0x01DC,
        IDG_VS_ERRORLIST_CLEARFILTERGROUP = 0x01DD,
        IDG_VS_TASKLIST_COPYONLY = 0x01DF,
        // Solution Node ctxt menu groups
        IDG_VS_SOLNNODE_CTXT_TOP = 0x01E0,
        IDG_VS_SOLNNODE_CTXT_BOTTOM = 0x01E1,
        // Project Window Default group
        IDG_VS_PROJWIN_NODE_CTXT_TOP = 0x01E2,
        IDG_VS_PROJWIN_NODE_CTXT_BOTTOM = 0x01E3,
        IDG_VS_PROJWIN_ITEM_CTXT_TOP = 0x01E4,
        IDG_VS_PROJWIN_ITEM_CTXT_BOTTOM = 0x01E5,
        // Document Window Default groups
        IDG_VS_DOCWINDOW_CTXT_TOP = 0x01E6,
        IDG_VS_DOCWINDOW_CTXT_BOTTOM = 0x01E7,
        // Tool Window Default groups
        IDG_VS_TOOLWINDOW_CTXT_TOP = 0x01E8,
        IDG_VS_TOOLWINDOW_CTXT_BOTTOM = 0x01E9,
        // EZ MDI groups
        IDG_VS_EZ_TILE = 0x01EA,
        IDG_VS_EZ_CANCEL = 0x01EB,
        IDG_VS_EZ_DOCWINDOWOPS = 0x01EC,
        IDG_VS_EZ_DOCWINDOWPATHOPS = 0x01ED,
        // Pinned Tabs
        IDG_VS_PINNEDTABS = 0x01EE,
        // Tab Orientation
        IDG_VS_EZ_TABORIENTATION = 0x01EF,
        //0x02B0 used for Codewindow context menu
        //0x02B1 used for Codewindow context menu
        //0x02B2 used for Codewindow context menu
        IDG_VS_BWNEXTBM = 0x01F0,
        IDG_VS_BWPREVBM = 0x01F1,
        IDG_VS_BWNEXTBMF = 0x01F2,
        IDG_VS_BWPREVBMF = 0x01F3,
        IDG_VS_BWNEWFOLDER = 0x01F4,
        IDG_VS_BWENABLE = 0x01F5,
        IDG_VS_BWDISABLE = 0x01F6,
        IDG_VS_CTXT_BW1 = 0x01F7,
        IDG_VS_CTXT_BW2 = 0x01F8,
        IDG_VS_BWDELETE = 0x01F9,
        // Tab Colorization
        IDG_VS_EZ_TABCOLOR = 0x01FA,
        // Debugger Group
        IDG_VS_TOOL_DEBUGGER = 0x0200,
        // Shell defined context menu groups
        IDG_VS_CTXT_MULTIPROJ_BUILD = 0x0201,
        IDG_VS_CTXT_PROJECT_ADD = 0x0202,
        IDG_VS_CTXT_PROJECT_ADD_ITEMS = 0x0203,
        IDG_VS_CTXT_PROJECT_DEBUG = 0x0204,
        IDG_VS_CTXT_PROJECT_START = 0x0205,
        IDG_VS_CTXT_PROJECT_BUILD = 0x0206,
        IDG_VS_CTXT_PROJECT_TRANSFER = 0x0207,
        IDG_VS_CTXT_ITEM_VIEWOBJECT = 0x0208,
        IDG_VS_CTXT_ITEM_OPEN = 0x0209,
        IDG_VS_CTXT_ITEM_TRANSFER = 0x020A,
        IDG_VS_CTXT_ITEM_VIEWBROWSER = 0x020B,
        IDG_VS_CTXT_SAVE = 0x020C,
        IDG_VS_CTXT_ITEM_PRINT = 0x020D,
        IDG_VS_CTXT_ITEM_PROPERTIES = 0x020E,
        IDG_VS_CTXT_SCC = 0x020F,
        IDG_VS_CTXT_ITEM_RENAME = 0x0210,
        IDG_VS_CTXT_PROJECT_RENAME = 0x0211,
        IDG_VS_CTXT_SOLUTION_RENAME = 0x0212,
        IDG_VS_CTXT_ITEM_SAVE = IDG_VS_CTXT_SAVE,
        IDG_VS_CTXT_PROJECT_SAVE = 0x0213,
        IDG_VS_CTXT_PROJECT_PROPERTIES = 0x0214,
        IDG_VS_CTXT_SOLUTION_PROPERTIES = 0x0215,
        IDG_VS_CTXT_ITEM_SCC = IDG_VS_CTXT_SCC,
        IDG_VS_CTXT_PROJECT_SCC = 0x0216,
        IDG_VS_CTXT_SOLUTION_SCC = 0x0217,
        IDG_VS_CTXT_SOLUTION_SAVE = 0x0218,
        IDG_VS_CTXT_SOLUTION_BUILD = 0x0219,
        IDG_VS_UNUSED = 0x021A,   // unused group for hidden cmds
        IDG_VS_CTXT_SOLUTION_START = 0x021B,
        IDG_VS_CTXT_SOLUTION_TRANSFER = 0x021C,
        IDG_VS_CTXT_SOLUTION_ADD_PROJ = 0x021D,
        IDG_VS_CTXT_SOLUTION_ADD_ITEM = 0x021E,
        IDG_VS_CTXT_SOLUTION_DEBUG = 0x021F,
        IDG_VS_CTXT_DOCOUTLINE = 0x0220,
        IDG_VS_CTXT_NOCOMMANDS = 0x0221,
        IDG_VS_TOOLS_CMDLINE = 0x0222,
        IDG_VS_TOOLS_SNIPPETS = IDG_TOOLS_SNIPPETS,
        IDG_VS_CTXT_CMDWIN_MARK = 0x0223,
        IDG_VS_CTXT_AUTOHIDE = 0x0224,
        //External tools context menu groups
        IDG_VS_EXTTOOLS_CURARGS = 0x0225,
        IDG_VS_EXTTOOLS_PROJARGS = 0x0226,
        IDG_VS_EXTTOOLS_SLNARGS = 0x0227,
        IDG_VS_EXTTOOLS_CURDIRS = 0x0228,
        IDG_VS_EXTTOOLS_PROJDIRS = 0x0229,
        IDG_VS_EXTTOOLS_SLNDIRS = 0x022A,
        IDG_VS_EXTTOOLS_TARGETARGS = 0x022B,
        IDG_VS_EXTTOOLS_EDITORARGS = 0x022C,
        IDG_VS_EXTTOOLS_TARGETDIRS = 0x022D,
        IDG_VS_CTXT_ITEM_VIEW = 0x022E,
        IDG_VS_CTXT_DELETE = 0x022F,
        IDG_VS_CTXT_FOLDER_TRANSFER = 0x0230,
        IDG_VS_CTXT_MULTISELECT_TRANSFER = 0x0231,
        IDG_VS_CTXT_PROJECT_DEPS = 0x0232,
        IDG_VS_CTXT_SOLUTION_ADD = 0x0233,
        IDG_VS_CTXT_PROJECT_CONFIG = 0x0234,
        // New File/Add New Item Open button drop-down menu
        IDG_VS_OPENDROPDOWN_MENU = 0x0235,
        // Unhide group on solution context menu
        IDG_VS_CTXT_SOLUTION_UNHIDE = 0x0236,
        // Context menu group for editing a project file
        IDG_VS_CTXT_PROJECT_EDITFILE = 0x0237,
        // Object search menu groups
        IDG_VS_OBJSEARCH_NAVIGATE = 0x0238,
        IDG_VS_OBJSEARCH_EDIT = 0x0239,
        //#define IDG_VS_OBJSEARCH_SORTING      0x0268
        // Context menu group for unloading/reloading a project
        IDG_VS_CTXT_PROJECT_UNLOADRELOAD = 0x023A,
        // Classview menu groups
        IDG_VS_CLASSVIEW_BASE_DERIVED_GRP = 0x023B,
        IDG_VS_CLASSVIEW_DISPLAY2 = 0x023C,
        IDG_VS_CLASSVIEW_MEMACCESSGRP = 0x023D,
        IDG_VS_CLASSVIEW_SEARCH2 = 0x023E,
        IDG_VS_CLASSVIEW_MEMGRP = 0x023F,
        IDG_VS_CLASSVIEW_FOLDERS = 0x0240,   // Used in toolbar
        IDG_VS_CLASSVIEW_FOLDERS2 = 0x0241,   // Used in context menu
        IDG_VS_CLASSVIEW_DISPLAY = 0x0242,
        IDG_VS_CLASSVIEW_SEARCH = 0x0243,
        IDG_VS_CLASSVIEW_EDIT = 0x0244,
        IDG_VS_CLASSVIEW_NAVIGATION = 0x0245,
        IDG_VS_CLASSVIEW_SHOWINFO = 0x0247,
        IDG_VS_CLASSVIEW_PROJADD = 0x0248,
        IDG_VS_CLASSVIEW_ITEMADD = 0x0249,
        IDG_VS_CLASSVIEW_GROUPING = 0x024a,
        IDG_VS_CLASSVIEW_PROJWIZARDS = 0x024b,
        IDG_VS_CLASSVIEW_ITEMWIZARDS = 0x024c,
        IDG_VS_CLASSVIEW_PROJADDITEMS = 0x024d,
        IDG_VS_CLASSVIEW_FOLDERS_EDIT = 0x024e,
        // Regular Expression Context menu groups
        IDG_VS_FINDREGEXNORM0 = 0x024f,
        IDG_VS_FINDREGEXNORM1 = 0x0250,
        IDG_VS_FINDREGEXHELP = 0x0251,
        IDG_VS_REPLACEREGEXNORM = 0x0252,
        IDG_VS_REPLACEREGEXHELP = 0x0253,
        IDG_VS_FINDWILDNORM = 0x0254,
        IDG_VS_FINDWILDHELP = 0x0255,
        IDG_VS_REPLACEWILDNORM = 0x0256,
        IDG_VS_REPLACEWILDHELP = 0x0257,
        IDG_VS_FINDREGEXNORM2 = 0x0258,
        IDG_VS_FINDREGEXNORM3 = 0x0259,
        IDG_VS_FINDREGEXNORM4 = 0x5300,
        IDG_VS_EXTTOOLS_BINARGS = 0x025A,
        IDG_VS_EXTTOOLS_BINDIRS = 0x025B,
        // Solution Folders context menu groups
        IDG_VS_CTXT_SLNFLDR_ADD_PROJ = 0x0261,
        IDG_VS_CTXT_SLNFLDR_ADD_ITEM = 0x0262,
        IDG_VS_CTXT_SLNFLDR_BUILD = 0x0263,
        IDG_VS_CTXT_SLNFLDR_ADD = 0x0264,
        IDG_VS_CTXT_SOLUTION_EXPLORE = 0x0265,
        IDG_VS_CTXT_PROJECT_EXPLORE = 0x0266,
        IDG_VS_CTXT_FOLDER_EXPLORE = 0x0267,
        // object search (find symbol results) context menu group
        IDG_VS_OBJSEARCH_SORTING = 0x0268,
        IDG_VS_OBJSEARCH_NAVIGATE2 = 0x0269,   // Used in toolbar
        IDG_VS_OBJSEARCH_BROWSE = 0x026a,
        IDG_VS_OBJSEARCH_COMMON = 0x026b,
        // Find All References toolbar groups
        IDG_VS_FINDALLREF_COMMON = 0x026c,
        IDG_VS_FINDALLREF_PRESETGROUPINGS = 0x026d,
        IDG_VS_FINDALLREF_LOCKWINGROUP = 0x026e,
        IDG_VS_FINDALLREF_PRESERVED = 0x026f,
        // Object Browser menu groups
        IDG_VS_OBJBROWSER_SUBSETS = 0x0270,
        IDG_VS_OBJBROWSER_DISPLAY = 0x0271,
        IDG_VS_OBJBROWSER_DISPLAY2 = 0x0272,
        IDG_VS_OBJBROWSER_SEARCH = 0x0273,
        IDG_VS_OBJBROWSER_SEARCH2 = 0x0274,
        IDG_VS_OBJBROWSER_NAVIGATION = 0x0275,
        IDG_VS_OBJBROWSER_EDIT = 0x0276,
        IDG_VS_OBJBROWSER_OBJGRP = 0x0277,
        IDG_VS_OBJBROWSER_MEMGRP = 0x0278,
        IDG_VS_OBJBROWSER_GROUPINGS = 0x0279,
        IDG_VS_OBJBROWSER_VIEWGRP = 0x027A,
        IDG_VS_OBJBROWSER_MEMACCESSGRP = 0x027B,
        IDG_VS_OBJBROWSER_BROWSERSETTINGSBTN = 0x027C,
        IDG_VS_OBJBROWSER_BASE_DERIVED_GRP = 0x027D,
        IDG_VS_OBJBROWSER_BROWSERSETTINGS = 0x027E,
        IDG_VS_OBJBROWSER_MEMBERSETTINGS = 0x027F,
        // Build Menu groups
        IDG_VS_BUILD_SOLUTION = 0x0280,
        IDG_VS_BUILD_SELECTION = 0x0281,
        IDG_VS_BUILD_MISC = 0x0282,
        IDG_VS_BUILD_CANCEL = 0x0283,
        IDG_VS_BUILD_CASCADE = 0x0284,
        IDG_VS_REBUILD_CASCADE = 0x0285,
        IDG_VS_CLEAN_CASCADE = 0x0286,
        IDG_VS_DEPLOY_CASCADE = 0x0287,
        IDG_VS_BUILD_PROJPICKER = 0x0288,
        IDG_VS_REBUILD_PROJPICKER = 0x0289,
        IDG_VS_PGO_SELECTION = 0x028A,
        // 0x028B is used below (IDG_VS_PGO_BUILD_CASCADE_RUN)
        IDG_VS_BUILD_COMPILE = 0x028C,
        IDG_VS_CLEAN_PROJPICKER = 0x0290,
        IDG_VS_DEPLOY_PROJPICKER = 0x0291,
        IDG_VS_CTXT_CMDWIN_CUTCOPY = 0x0292,
        // Output Window menu groups
        IDG_VS_OUTPUTWINDOW_SELECT = 0x0293,
        IDG_VS_OUTPUTWINDOW_GOTO = 0x0294,
        IDG_VS_OUTPUTWINDOW_NEXTPREV = 0x0295,
        IDG_VS_OUTPUTWINDOW_CLEAR = 0x0296,
        IDG_VS_OUTPUTWINDOW_WORDWRAP = 0x029F,
        // Find Results 1 menu groups
        IDG_VS_FINDRESULTS1_GOTO = 0x0297,
        IDG_VS_FINDRESULTS1_NEXTPREV = 0x0298,
        IDG_VS_FINDRESULTS1_CLEAR = 0x0299,
        IDG_VS_FINDRESULTS1_STOPFIND = 0x02B6,
        // Find Results 2 menu groups
        IDG_VS_FINDRESULTS2_GOTO = 0x029A,
        IDG_VS_FINDRESULTS2_NEXTPREV = 0x029B,
        IDG_VS_FINDRESULTS2_CLEAR = 0x029C,
        IDG_VS_FINDRESULTS2_STOPFIND = 0x02B7,
        IDG_VS_PROJONLY_CASCADE = 0x029D,
        IDG_VS_PGO_BUILD_CASCADE_BUILD = 0x029E,
        IDG_VS_PGO_BUILD_CASCADE_RUN = 0x028B,
        // 0x029F used above (IDG_VS_OUTPUTWINDOW_WORDWRAP)
        // Additional Shell defined context menu groups
        IDG_VS_CTXT_PROJECT_ADD_FORMS = 0x02A0,
        IDG_VS_CTXT_PROJECT_ADD_MISC = 0x02A1,
        IDG_VS_CTXT_ITEM_INCLUDEEXCLUDE = 0x02A2,
        IDG_VS_CTXT_FOLDER_ADD = 0x02A3,
        IDG_VS_CTXT_REFROOT_ADD = 0x02A4,
        IDG_VS_CTXT_REFROOT_TRANSFER = 0x02A5,
        IDG_VS_CTXT_WEBREFFOLDER_ADD = 0x02A6,
        IDG_VS_CTXT_COMPILELINK = 0x02A7,
        IDG_VS_CTXT_REFERENCE = 0x02A8,
        IDG_VS_CTXT_APPDESIGNERFOLDER_OPEN = 0x02A9,
        IDG_VS_OBJSEARCH_CLEAR = 0x02AA,
        IDG_VS_CTXT_CMDWIN_CLEAR = 0x02AB,
        IDG_VS_UFINDQUICK = 0x02AD,
        IDG_VS_UFINDFIF = 0x02AE,
        IDG_VS_FFINDSYMBOL = 0x02AF,
        IDG_VS_CTXT_PROJECT_CLASSDIAGRAM = 0x02B8,
        IDG_VS_CTXT_PROJECT_ADD_REFERENCES = 0x02B9,
        // Properties panel groups
        IDG_VS_PROPERTIES_SORT = 0x02BA,
        IDG_VS_PROPERTIES_PAGES = 0x02BB,
        IDG_VS_CLASSVIEW_SETTINGS = 0x02BC,   // Used in toolbar
        IDG_VS_CLASSVIEW_BROWSERSETTINGSBTN = 0x02BD,
        IDG_VS_CLASSVIEW_SHOW_INHERITED = 0x02BE,
        //////////////////////////////////////////////////////////////////////////////
        //
        // Groups for Menu Controllers
        //
        //////////////////////////////////////////////////////////////////////////////
        IDG_VS_MNUCTRL_NEWITM = 0x02C0,
        IDG_VS_MNUCTRL_NEWITM_BOTTOM = 0x02C1,
        IDG_VS_MNUCTRL_NEWPRJ = 0x02C2,
        IDG_VS_MNUCTRL_NEWPRJ_BOTTOM = 0x02C3,
        IDG_VS_MNUCTRL_NAVBACK = 0x02C4,
        IDG_VS_MNUCTRL_OBSEARCHOPTIONS = 0x02C5,
        IDG_VS_MNUCTRL_FIND = 0x02C6,
        IDG_VS_MNUCTRL_REPLACE = 0x02C7,
        IDG_VS_SNIPPET_PROP = 0x02C8,
        IDG_VS_SNIPPET_REF = 0x02C9,
        IDG_VS_SNIPPET_REPL = 0x02CA,
        IDG_VS_FINDRESULTSTABLE = 0x02DE,
        IDG_VS_FINDRESULTSTABLE_FINDSTOP = 0x02DF,
        IDG_VS_CTXT_PROJECT_BUILDDEPENDENCIES = 0x02E0,
        IDG_VS_CTXT_PROJECT_SCC_CONTAINER = 0x02E1,
        IDG_VS_CTXT_PROJECT_ANALYZE_GENERAL = 0x02E2,
        IDG_VS_CTXT_PROJECT_VIEW_GENERAL = 0x02E3,
        IDG_VS_CTXT_PROJECT_CONVERT_GENERAL = 0x02E4,
        IDG_VS_CTXT_ITEM_ANALYZE_GENERAL = 0x02E5,
        IDG_VS_CTXT_ITEM_EXPLORE = 0x02E6,
        IDG_VS_CTXT_XPROJ_PROJITEM_EXPLORE = 0x02E7,
        IDG_VS_CTXT_PACKAGEMANAGEMENT = 0x02F0,
        IDG_VS_CTXT_REFERENCEMANAGEMENT = 0x02F1,
        IDG_VS_CTXT_ASSEMBLYREFERENCE_MANAGE = 0x02F2,
        IDG_VS_CTXT_COMREFERENCE_MANAGE = 0x02F3,
        IDG_VS_CTXT_PROJECTREFERENCE_MANAGE = 0x02F4,
        IDG_VS_CTXT_SDKREFERENCE_MANAGE = 0x02F5,
        IDG_VS_CTXT_ITEM_OBJECTBROWSER = 0x02F6,
        //////////////////////////////////////////////////////////////////////////////
        //
        // Cascading Menu Identifiers, created by Visual Studio Shell
        //
        //////////////////////////////////////////////////////////////////////////////
        IDM_VS_CSCD_EXTTOOLS = 0x0340,
        IDM_VS_CSCD_SOLUTION_ADD = 0x0350,
        IDM_VS_CSCD_SOLUTION_DEBUG = 0x0351,
        IDM_VS_CSCD_PROJECT_ADD = 0x0352,
        IDM_VS_CSCD_PROJECT_DEBUG = 0x0353,
        // ClassView cascades
        IDM_VS_CSCD_CV_PROJADD = 0x0354,
        IDM_VS_CSCD_CV_ITEMADD = 0x0355,
        IDM_VS_CSCD_SLNFLDR_ADD = 0x0357,
        IDM_VS_CSCD_TASKLIST_COLUMNS = 0x0358,
        IDM_VS_CSCD_CALLBROWSER = 0x0359,
        IDG_VS_VIEW_CALLBROWSER = 0x035A,
        IDG_VS_VIEW_CALLBROWSER_CASCADE = 0x035B,
        IDG_VS_VIEW_CALLBROWSER_SHOW = 0x035C,
        IDM_VS_CSCD_FINDRESULTS = 0x035D,
        IDM_VS_CSCD_PROJECT_ANALYZE = 0x035E,
        IDM_VS_CSCD_PROJECT_VIEW = 0x035F,
        IDM_VS_CSCD_PROJECT_CONVERT = 0x0360,
        IDM_VS_CSCD_PROJECT_BUILDDEPENDENCIES = 0x0361,
        IDM_VS_CSCD_PROJECT_SCC = 0x0362,
        IDM_VS_CSCD_WINDOW_LAYOUTS = 0x0363,
        IDM_VS_CSCD_TASKLIST_GROUPS = 0x0364,
        IDM_VS_CSCD_ITEM_ANALYZE = 0x036A,
        IDM_VS_EZ_TABORIENTATION = 0x0400,
        IDM_VS_EZ_TABCOLOR = 0x0401,
        //////////////////////////////////////////////////////////////////////////////
        //
        // Context Menu Identifiers, created by Visual Studio Shell
        //
        //////////////////////////////////////////////////////////////////////////////
        IDM_VS_CTXT_PROJNODE = 0x0402,
        IDM_VS_CTXT_PROJWIN = 0x0403,
        IDM_VS_CTXT_PROJWINBREAK = 0x0404,
        IDM_VS_CTXT_ERRORLIST = 0x0405,
        IDM_VS_CTXT_DOCKEDWINDOW = 0x0406,
        IDM_VS_CTXT_MENUDES = 0x0407,
        IDM_VS_CTXT_PROPBRS = 0x0408,
        IDM_VS_CTXT_TOOLBOX = 0x0409,
        // UNUSED: 0x040A - 0x040C
        IDM_VS_CTXT_CODEWIN = 0x040D,
        IDM_VS_CTXT_TASKLIST = 0x040E,
        IDM_VS_CTXT_RESULTSLIST = 0x0411,
        IDM_VS_CTXT_STUBPROJECT = 0x0412,
        IDM_VS_CTXT_SOLNNODE = 0x0413,
        IDM_VS_CTXT_SOLNFOLDER = 0x0414,
        // Slctn of one or more ProjNodes & SolnNode (doesn't involve ProjItem nodes)
        IDM_VS_CTXT_XPROJ_SLNPROJ = 0x0415,
        // Slctn of one or more ProjItems & SolnNode (min 1 ProjItem & may involve ProjNodes too)
        IDM_VS_CTXT_XPROJ_SLNITEM = 0x0416,
        // Selection of one more Project Nodes and one or more Project Items across projects (does not involve Solution Node)
        IDM_VS_CTXT_XPROJ_PROJITEM = 0x0417,
        // Selection of two or more Project Nodes (does not involve the Solution Node or Project Item Nodes)
        IDM_VS_CTXT_XPROJ_MULTIPROJ = 0x0418,
        // Selection of one more Project Items across projects (does not involve Project Nodes or Solution Node)
        IDM_VS_CTXT_XPROJ_MULTIITEM = 0x0419,
        IDM_VS_CTXT_NOCOMMANDS = 0x041A,
        // Miscellaneous Files project and item context menus
        IDM_VS_CTXT_MISCFILESPROJ = 0x041B,
        // Selection of two or more solution folders
        IDM_VS_CTXT_XPROJ_MULTIFOLDER = 0x041C,
        // Selection of combination of projects and solution folders
        IDM_VS_CTXT_XPROJ_MULTIPROJFLDR = 0x041D,
        // Command Window context menu
        IDM_VS_CTXT_COMMANDWINDOW = 0x041F,
        // AutoHide context menu on channel
        IDM_VS_CTXT_AUTOHIDE = 0x0420,
        // Expansion Manager description pane context menu
        IDM_VS_CTXT_EXPANSION_DESC = 0x0421,
        // Expansion Manager description pane context menu commands
        IDG_VS_CTXT_EXPANSION_DESC_COPY = 0x0422,
        IDG_VS_CTXT_EXPANSION_DESC_SELECTALL = 0x0423,
        IDM_VS_CTXT_FIND_REGEX = 0x0424,
        IDM_VS_CTXT_REPLACE_REGEX = 0x0425,
        IDM_VS_CTXT_FIND_WILD = 0x0426,
        IDM_VS_CTXT_REPLACE_WILD = 0x0427,
        IDM_VS_CTXT_EXTTOOLSARGS = 0x0428,
        IDM_VS_CTXT_EXTTOOLSDIRS = 0x0429,
        // EZMdi context menus
        IDM_VS_CTXT_EZTOOLWINTAB = 0x042A,
        IDM_VS_CTXT_EZDOCWINTAB = 0x042B,
        IDM_VS_CTXT_EZDRAGGING = 0x042C,
        IDM_VS_CTXT_EZCHANNEL = 0x042D,
        // New File/Add New Item Open button drop-down menu
        IDM_VS_CTXT_OPENDROPDOWN = 0x042E,
        // Framework Version drop-down menu
        IDM_VS_CTXT_FRAMEWORKVERSION = 0x042F,
        // Common Item Node context menu
        IDM_VS_CTXT_ITEMNODE = 0x0430,
        // Folder Node context menu
        IDM_VS_CTXT_FOLDERNODE = 0x0431,
        //////////////////////////////////////////////////////////////////////////////
        // ClassView context menus
        IDM_VS_CTXT_CV_PROJECT = 0x0432,
        IDM_VS_CTXT_CV_ITEM = 0x0433,
        IDM_VS_CTXT_CV_FOLDER = 0x0434,
        IDM_VS_CTXT_CV_GROUPINGFOLDER = 0x0435,
        IDM_VS_CTXT_CV_MULTIPLE = 0x0436,
        IDM_VS_CTXT_CV_MULTIPLE_MEMBERS = 0x0437,
        IDM_VS_CTXT_CV_MEMBER = 0x0438,
        IDM_VS_CTXT_CV_NON_SYMBOL_MEMBERS = 0x0439,
        IDM_VS_CTXT_CV_PROJECT_REFS_FOLDER = 0x0440,
        IDM_VS_CTXT_CV_PROJECT_REFERENCE = 0x0441,
        IDM_VS_CTXT_CV_NO_SOURCE_ITEM = 0x0442,
        IDM_VS_CTXT_CV_NO_SOURCE_MEMBER = 0x0443,
        IDM_VS_CTXT_CV_MULTIPLE_NO_SOURCE = 0x049,
        IDM_VS_CTXT_CV_MULTIPLE_MEMBERS_NO_SOURCE = 0x04A,
        // Object Browsing tools context menus
        IDM_VS_SYMBOLS_DUMMY = 0x0444,
        IDM_VS_CTXT_OBJBROWSER_OBJECTS = 0x0445,
        IDM_VS_CTXT_OBJBROWSER_MEMBERS = 0x0446,
        IDM_VS_CTXT_OBJBROWSER_DESC = 0x0447,
        IDM_VS_CTXT_OBJSEARCH = 0x0448,
        //#define IDM_VS_CTXT_CV_MULTIPLE_NO_SOURCE          0x049
        //#define IDM_VS_CTXT_CV_MULTIPLE_MEMBERS_NO_SOURCE  0x04A
        IDG_VS_FRAMEWORKVERSIONDROPDOWN_MENU = 0x0449,
        //////////////////////////////////////////////////////////////////////////////
        // Reference context menus
        // Reference Root Node context menu
        IDM_VS_CTXT_REFERENCEROOT = 0x0450,
        // Reference Item context menu
        IDM_VS_CTXT_REFERENCE = 0x0451,
        // Web Reference Folder context menu
        IDM_VS_CTXT_WEBREFFOLDER = 0x0452,
        // App Designer Folder context menu
        IDM_VS_CTXT_APPDESIGNERFOLDER = 0x0453,
        // Find All References context menu
        IDM_VS_CTXT_FINDALLREF = 0x0454,
        // Menus for top-level 'Dependencies' tree items not found in 'References' tree
        IDM_VS_CTXT_DEPENDENCYTARGET = 0X04A0,   // Target framework group node
        IDM_VS_CTXT_REFERENCE_GROUP = 0X04A1,   // Assembly reference group
        IDM_VS_CTXT_PACKAGEREFERENCE_GROUP = 0x04A2,
        IDM_VS_CTXT_PACKAGEREFERENCE = 0x04A3,
        IDM_VS_CTXT_COMREFERENCE_GROUP = 0x04A4,
        IDM_VS_CTXT_COMREFERENCE = 0x04A5,
        IDM_VS_CTXT_PROJECTREFERENCE_GROUP = 0x04A6,
        IDM_VS_CTXT_PROJECTREFERENCE = 0x04A7,
        IDM_VS_CTXT_SHAREDPROJECTREFERENCE = 0x04A8,
        IDM_VS_CTXT_FRAMEWORKREFERENCE_GROUP = 0x04A9,
        IDM_VS_CTXT_FRAMEWORKREFERENCE = 0x04AA,
        IDM_VS_CTXT_ANALYZERREFERENCE_GROUP = 0x04AB,
        IDM_VS_CTXT_ANALYZERREFERENCE = 0x04AC,
        IDM_VS_CTXT_SDKREFERENCE_GROUP = 0x04AD,
        IDM_VS_CTXT_SDKREFERENCE = 0x04AE,
        // Menus for dependency tree items attached to (descendents of) top-level project dependencies.
        // These are not hierarchy items, and a more limited set of operations is available for them compared
        // to their top-level counterparts. These items should be identified via their browse objects using
        // the metadata values indicated.
        IDM_VS_CTXT_DEPENDENCY_TRANSITIVE_ITEM = 0x04B0,   // fallback/default menu
        IDM_VS_CTXT_TRANSITIVE_ASSEMBLY_REFERENCE = 0x04B1,   // metadata: "Path"
        IDM_VS_CTXT_TRANSITIVE_PACKAGE_REFERENCE = 0x04B2,   // metadata: "Path", "Identity", "Version"
        IDM_VS_CTXT_TRANSITIVE_PROJECT_REFERENCE = 0x04B3,   // metadata: "Path", "Identity"
                                                             //////////////////////////////////////////////////////////////////////////////
                                                             // Right drag menu group
        IDM_VS_CTXT_RIGHT_DRAG = 0x0460,
        IDG_VS_CTXT_RIGHT_DRAG1 = 0x0461,
        IDG_VS_CTXT_RIGHT_DRAG2 = 0x0462,
        //////////////////////////////////////////////////////////////////////////////
        // Web context menus
        IDM_VS_CTXT_WEBPROJECT = 0x0470,
        IDM_VS_CTXT_WEBFOLDER = 0x0471,
        IDM_VS_CTXT_WEBITEMNODE = 0x0472,
        // BEWARE!!!: IDM_VS_CTXT_BOOKMARK is defined as 0x0473
        IDM_VS_CTXT_WEBSUBWEBNODE = 0x0474,
        //////////////////////////////////////////////////////////////////////////////
        // Error correction context menu and group
        IDM_VS_CTXT_ERROR_CORRECTION = 0x0480,
        IDG_VS_CTXT_ERROR_CORRECTION = 0x0481,
        //////////////////////////////////////////////////////////////////////////////
        // Context menu organizers
        //No group for the Misc menu, since nobody purposely adds menus to this group,
        //it's used as a catchall to which we programmatically assign unparented context menus
        IDM_VS_CTXT_MISC = 0x0490,
        IDM_VS_CTXT_CV_ALL = 0x0491,
        IDG_VS_CTXT_CV_ALL = 0x0492,
        IDM_VS_CTXT_OBJBROWSER_ALL = 0x0493,
        IDG_VS_CTXT_OBJBROWSER_ALL = 0x0494,
        IDM_VS_CTXT_SOLNEXPL_ALL = 0x0495,
        IDG_VS_CTXT_SOLNEXPL_ALL = 0x0496,
        // CSHARP REFACTORING Context menu
        IDM_VS_CTX_REFACTORING = 0x0497,
        IDM_VS_CTXT_EDITOR_ALL = 0x0498,
        IDG_VS_CTXT_EDITOR_ALL = 0x0499,
        // BEWARE!!!: 0X04A_ is defined above, for the dependencies tree
        // BEWARE!!!: 0X04B_ is defined above, for the dependencies tree
        //////////////////////////////////////////////////////////////////////////////
        // Bookmark window context menu
        IDM_VS_CTXT_BOOKMARK = 0x0473,
        //////////////////////////////////////////////////////////////////////////////
        //
        // Menu Controller dentifiers, created by Visual Studio Shell
        //
        //////////////////////////////////////////////////////////////////////////////
        IDM_VS_MNUCTRL_NEWITM = 0x0500,
        IDM_VS_MNUCTRL_NEWPRJ = 0x0501,
        IDM_VS_MNUCTRL_OTRWNDWS = 0x0502,
        IDM_VS_MNUCTRL_NAVBACK = 0x0503,
        IDM_VS_MNUCTRL_OBSEARCHOPTS = 0x0504,
        IDM_VS_MNUCTRL_CVGROUPING = 0x0505,
        IDM_VS_MNUCTRL_OBGRPOBJS = 0x0506,
        IDM_VS_MNUCTRL_OBGRPMEMS = 0x0507,
        IDM_VS_MNUCTRL_OBGRPVIEWS = 0x0509,
        IDM_VS_MNUCTRL_OBGRPMEMSACCESS = 0x050A,
        IDM_VS_MNUCTRL_CALLBROWSER1_SETTINGS = 0x050B,
        IDM_VS_MNUCTRL_CALLBROWSER2_SETTINGS = 0x050C,
        IDM_VS_MNUCTRL_CALLBROWSER3_SETTINGS = 0x050D,
        IDM_VS_MNUCTRL_CALLBROWSER4_SETTINGS = 0x050E,
        IDM_VS_MNUCTRL_CALLBROWSER5_SETTINGS = 0x050F,
        IDM_VS_MNUCTRL_CALLBROWSER6_SETTINGS = 0x0510,
        IDM_VS_MNUCTRL_CALLBROWSER7_SETTINGS = 0x0511,
        IDM_VS_MNUCTRL_CALLBROWSER8_SETTINGS = 0x0512,
        IDM_VS_MNUCTRL_CALLBROWSER9_SETTINGS = 0x0513,
        IDM_VS_MNUCTRL_CALLBROWSER10_SETTINGS = 0x0514,
        IDM_VS_MNUCTRL_CALLBROWSER11_SETTINGS = 0x0515,
        IDM_VS_MNUCTRL_CALLBROWSER12_SETTINGS = 0x0516,
        IDM_VS_MNUCTRL_CALLBROWSER13_SETTINGS = 0x0517,
        IDM_VS_MNUCTRL_CALLBROWSER14_SETTINGS = 0x0518,
        IDM_VS_MNUCTRL_CALLBROWSER15_SETTINGS = 0x0519,
        IDM_VS_MNUCTRL_CALLBROWSER16_SETTINGS = 0x051A,
        IDM_VS_MNUCTRL_FIND = 0x051B,
        IDM_VS_MNUCTRL_REPLACE = 0x051C,
        IDM_VS_MNUCTRL_FILTERERRORLIST = 0x051D,
        IDM_VS_MNUCTRL_FILTERSOLUTIONEXPLORER = 0x051E,
        // Text editor toolbar groups
        IDG_VS_EDITTOOLBAR_COMPLETION = 0x0550,
        IDG_VS_EDITTOOLBAR_INDENT = 0x0551,
        IDG_VS_EDITTOOLBAR_COMMENT = 0x0552,
        IDG_VS_EDITTOOLBAR_TEMPBOOKMARKS = 0x0553,
        // Edit menu groups (HTML Editor Edit | Advanced)
        IDG_TAG_OUTLINING = 0x5554,
        // Format Menu groups
        IDG_VS_FORMAT_STYLE = 0x0569,
        IDG_VS_FORMAT_COLOR = 0x056A,
        IDG_VS_FORMAT_PARAGRAPH = 0x056B,
        IDG_VS_FORMAT_INDENT = 0x056C,
        IDG_VS_FORMAT_GRID = 0x0554,
        IDG_VS_FORMAT_SPACE = 0x0555,
        IDG_VS_FORMAT_CENTER = 0x0556,
        IDG_VS_FORMAT_ORDER = 0x0557,
        IDG_VS_FORMAT_ALIGN = 0x0567,
        IDG_VS_FORMAT_LOCK = 0x0558,
        IDG_VS_FORMAT_ELEMENT = 0x056D,
        // skip down to 0x0590 for IDG_VS_FORMAT_ANCHORS
        // Format Align menu groups
        IDG_VS_FORMAT_ALIGN_X = 0x0559,
        IDG_VS_FORMAT_ALIGN_Y = 0x055A,
        IDG_VS_FORMAT_ALIGN_GRID = 0x055B,
        // Format Size menu groups
        IDG_VS_FORMAT_SIZE = 0x055C,
        // Format Space menu groups
        IDG_VS_FORMAT_SPACE_X = 0x055D,
        IDG_VS_FORMAT_SPACE_Y = 0x055E,
        // Format Center menu groups
        IDG_VS_FORMAT_CENTER_CMDS = 0x055F,
        // Format Order menu groups
        IDG_VS_FORMAT_ORDER_CMDS = 0x0560,
        // Format Grid menu group
        IDG_VS_FORMAT_GRID_CMDS = 0x0570,
        // Layout Position menu group
        IDG_VS_LAYOUT_POSITION_CMDS = 0x592,
        IDG_VS_LAYOUT_POSITION_OPTIONS = 0x596,
        // Format cascaded menus
        IDM_VS_CSCD_FORMAT_FONT = 0x056F,
        IDM_VS_CSCD_FORMAT_JUSTIFY = 0x0570,
        IDM_VS_CSCD_FORMAT_ALIGN = 0x0561,
        IDM_VS_CSCD_FORMAT_SIZE = 0x0562,
        IDM_VS_CSCD_FORMAT_SPACE_X = 0x0563,
        IDM_VS_CSCD_FORMAT_SPACE_Y = 0x0564,
        IDM_VS_CSCD_FORMAT_CENTER = 0x0565,
        IDM_VS_CSCD_FORMAT_ORDER = 0x0566,
        // View menu groups
        IDG_VS_VIEW_TABORDER = 0x0568,
        IDG_VS_VIEW_OPTIONS = 0x0571,
        // 0x0569 used in IDG_VS_FORMAT_STYLE above
        // 0x056A used in IDG_VS_FORMAT_COLOR above
        // 0x056B used in IDG_VS_FORMAT_PARAGRAPH above
        // 0x056C used in IDG_VS_FORMAT_INDENT above
        // 0x056D used in IDG_VS_FORMAT_ELEMENT above
        // 0x056F used in IDM_VS_CSCD_FORMAT_FONT above
        // 0x0570 used in IDM_VS_CSCD_FORMAT_JUSTIFY above
        // 0x0571 used in IDG_VS_VIEW_OPTIONS above
        // Format Paragraph menu groups
        IDG_VS_FORMAT_FONTFACE = 0x0572,
        IDG_VS_FORMAT_FONTSCRIPT = 0x0573,
        IDG_VS_FORMAT_JUSTIFY = 0x0574,
        // Layout menu
        IDM_VS_LAYOUT_MENU = 0x0575,
        // Table cascaded menus
        IDM_VS_CSCD_TABLE_INSERT = 0x0576,
        IDM_VS_CSCD_TABLE_DELETE = 0x0577,
        IDM_VS_CSCD_TABLE_SELECT = 0x0578,
        IDM_VS_CSCD_TABLE_RESIZE = 0x0596,
        // Table menu groups
        IDG_VS_TABLE_MAIN = 0x0579,
        IDG_VS_TABLE_INSERT_1 = 0x057A,
        IDG_VS_TABLE_INSERT_2 = 0x057B,
        IDG_VS_TABLE_INSERT_3 = 0x057C,
        IDG_VS_TABLE_INSERT_4 = 0x057D,
        IDG_VS_TABLE_DELETE = 0x057E,
        IDG_VS_TABLE_SELECT = 0x057F,
        IDM_VS_CSCD_LAYOUT_POSITION = 0x0593,
        IDG_VS_TABLE_RESIZE = 0x0595,
        // Frame Set Menu
        IDM_VS_FRAMESET_MENU = 0x0580,
        // Frame Set Menu groups
        IDG_VS_FRAME_WHOLE = 0x0581,
        IDG_VS_FRAME_INDV = 0x0582,
        IDG_VS_FRAME_NEW = 0x0583,
        // Tools Menu groups
        IDG_VS_TOOLS_EDITOPT = 0x0584,
        // Insert Menu
        IDM_VS_INSERT_MENU = 0x0585,
        // Insert Menu groups
        IDG_VS_INSERT_TAGS = 0x0586,
        IDG_VS_INSERT_TAGS2 = 0x0587,
        // Continuation of Format Menu groups
        IDG_VS_FORMAT_ANCHORS = 0x0590,
        IDG_VS_LAYOUT_POSITION = 0x0591,
        // Project cascaded menus
        IDM_VS_CSCD_PROJECT_WEB = 0x0600,
        // More Object browser groups
        IDG_VS_OBJBROWSER_ADDREFERENCE = 0x0610,
        IDG_VS_OBJBROWSER_ADDTOFAVOURITES = 0x0611,
        IDG_VS_OBJBROWSER_SHOW_INHERITED = 0x0612,
        // Code Definition View groups
        IDG_VS_CODEDEFVIEW = 0x0617,
        // Project menu groups
        IDG_VS_CTXT_PROJECT_BUILD_ORDER = 0x0620,
        IDG_VS_CTXT_PROJECT_BUILD_PGO = 0x0621,
        // Goto menu
        IDG_VS_GOTO = 0x0622,
        ///////////////////////////////////////////////
        //
        // EzMDI files command group
        //
        ///////////////////////////////////////////////
        IDM_EZMDI_FILELIST = 0x0650,
        IDG_EZMDI_FILELIST = 0x0651,
        ///////////////////////
        // Calls Browser groups
        ///////////////////////
        IDG_VS_CALLBROWSER_TYPE = 0x0660,
        IDG_VS_CALLBROWSER_EDIT = 0x0661,
        IDG_VS_CALLBROWSER_NAVIGATION = 0x0662,
        IDM_VS_CTXT_CALLBROWSER = 0x0663,
        IDG_VS_TOOLBAR_CALLBROWSER1_CBSETTINGS = 0x0670,
        IDG_VS_TOOLBAR_CALLBROWSER2_CBSETTINGS = 0x0671,
        IDG_VS_TOOLBAR_CALLBROWSER3_CBSETTINGS = 0x0672,
        IDG_VS_TOOLBAR_CALLBROWSER4_CBSETTINGS = 0x0673,
        IDG_VS_TOOLBAR_CALLBROWSER5_CBSETTINGS = 0x0674,
        IDG_VS_TOOLBAR_CALLBROWSER6_CBSETTINGS = 0x0675,
        IDG_VS_TOOLBAR_CALLBROWSER7_CBSETTINGS = 0x0676,
        IDG_VS_TOOLBAR_CALLBROWSER8_CBSETTINGS = 0x0677,
        IDG_VS_TOOLBAR_CALLBROWSER9_CBSETTINGS = 0x0678,
        IDG_VS_TOOLBAR_CALLBROWSER10_CBSETTINGS = 0x0679,
        IDG_VS_TOOLBAR_CALLBROWSER11_CBSETTINGS = 0x067A,
        IDG_VS_TOOLBAR_CALLBROWSER12_CBSETTINGS = 0x067B,
        IDG_VS_TOOLBAR_CALLBROWSER13_CBSETTINGS = 0x067C,
        IDG_VS_TOOLBAR_CALLBROWSER14_CBSETTINGS = 0x067D,
        IDG_VS_TOOLBAR_CALLBROWSER15_CBSETTINGS = 0x067E,
        IDG_VS_TOOLBAR_CALLBROWSER16_CBSETTINGS = 0x067F,
        IDG_VS_CALLBROWSER1_SETTINGSBTN = 0x0680,
        IDG_VS_CALLBROWSER2_SETTINGSBTN = 0x0681,
        IDG_VS_CALLBROWSER3_SETTINGSBTN = 0x0682,
        IDG_VS_CALLBROWSER4_SETTINGSBTN = 0x0683,
        IDG_VS_CALLBROWSER5_SETTINGSBTN = 0x0684,
        IDG_VS_CALLBROWSER6_SETTINGSBTN = 0x0685,
        IDG_VS_CALLBROWSER7_SETTINGSBTN = 0x0686,
        IDG_VS_CALLBROWSER8_SETTINGSBTN = 0x0687,
        IDG_VS_CALLBROWSER9_SETTINGSBTN = 0x0688,
        IDG_VS_CALLBROWSER10_SETTINGSBTN = 0x0689,
        IDG_VS_CALLBROWSER11_SETTINGSBTN = 0x068A,
        IDG_VS_CALLBROWSER12_SETTINGSBTN = 0x068B,
        IDG_VS_CALLBROWSER13_SETTINGSBTN = 0x068C,
        IDG_VS_CALLBROWSER14_SETTINGSBTN = 0x068D,
        IDG_VS_CALLBROWSER15_SETTINGSBTN = 0x068E,
        IDG_VS_CALLBROWSER16_SETTINGSBTN = 0x068F,
        IDG_VS_CALLBROWSER1_SORTING = 0x0690,
        IDG_VS_CALLBROWSER2_SORTING = 0x0691,
        IDG_VS_CALLBROWSER3_SORTING = 0x0692,
        IDG_VS_CALLBROWSER4_SORTING = 0x0693,
        IDG_VS_CALLBROWSER5_SORTING = 0x0694,
        IDG_VS_CALLBROWSER6_SORTING = 0x0695,
        IDG_VS_CALLBROWSER7_SORTING = 0x0696,
        IDG_VS_CALLBROWSER8_SORTING = 0x0697,
        IDG_VS_CALLBROWSER9_SORTING = 0x0698,
        IDG_VS_CALLBROWSER10_SORTING = 0x0699,
        IDG_VS_CALLBROWSER11_SORTING = 0x069A,
        IDG_VS_CALLBROWSER12_SORTING = 0x069B,
        IDG_VS_CALLBROWSER13_SORTING = 0x069C,
        IDG_VS_CALLBROWSER14_SORTING = 0x069D,
        IDG_VS_CALLBROWSER15_SORTING = 0x069E,
        IDG_VS_CALLBROWSER16_SORTING = 0x069F,
        IDG_VS_CALLBROWSER1_SETTINGS = 0x06A0,
        IDG_VS_CALLBROWSER2_SETTINGS = 0x06A1,
        IDG_VS_CALLBROWSER3_SETTINGS = 0x06A2,
        IDG_VS_CALLBROWSER4_SETTINGS = 0x06A3,
        IDG_VS_CALLBROWSER5_SETTINGS = 0x06A4,
        IDG_VS_CALLBROWSER6_SETTINGS = 0x06A5,
        IDG_VS_CALLBROWSER7_SETTINGS = 0x06A6,
        IDG_VS_CALLBROWSER8_SETTINGS = 0x06A7,
        IDG_VS_CALLBROWSER9_SETTINGS = 0x06A8,
        IDG_VS_CALLBROWSER10_SETTINGS = 0x06A9,
        IDG_VS_CALLBROWSER11_SETTINGS = 0x06AA,
        IDG_VS_CALLBROWSER12_SETTINGS = 0x06AB,
        IDG_VS_CALLBROWSER13_SETTINGS = 0x06AC,
        IDG_VS_CALLBROWSER14_SETTINGS = 0x06AD,
        IDG_VS_CALLBROWSER15_SETTINGS = 0x06AE,
        IDG_VS_CALLBROWSER16_SETTINGS = 0x06AF,
        IDG_VS_TOOLBAR_CALLBROWSER1_TYPE = 0x06B0,
        IDG_VS_TOOLBAR_CALLBROWSER2_TYPE = 0x06B1,
        IDG_VS_TOOLBAR_CALLBROWSER3_TYPE = 0x06B2,
        IDG_VS_TOOLBAR_CALLBROWSER4_TYPE = 0x06B3,
        IDG_VS_TOOLBAR_CALLBROWSER5_TYPE = 0x06B4,
        IDG_VS_TOOLBAR_CALLBROWSER6_TYPE = 0x06B5,
        IDG_VS_TOOLBAR_CALLBROWSER7_TYPE = 0x06B6,
        IDG_VS_TOOLBAR_CALLBROWSER8_TYPE = 0x06B7,
        IDG_VS_TOOLBAR_CALLBROWSER9_TYPE = 0x06B8,
        IDG_VS_TOOLBAR_CALLBROWSER10_TYPE = 0x06B9,
        IDG_VS_TOOLBAR_CALLBROWSER11_TYPE = 0x06BA,
        IDG_VS_TOOLBAR_CALLBROWSER12_TYPE = 0x06BB,
        IDG_VS_TOOLBAR_CALLBROWSER13_TYPE = 0x06BC,
        IDG_VS_TOOLBAR_CALLBROWSER14_TYPE = 0x06BD,
        IDG_VS_TOOLBAR_CALLBROWSER15_TYPE = 0x06BE,
        IDG_VS_TOOLBAR_CALLBROWSER16_TYPE = 0x06BF,
        IDG_VS_CALLBROWSER_TYPE_POPUP = 0x06C0,
        ///////////////////////
        // Preview Changes groups
        ///////////////////////
        IDG_VS_PREVIEWCHANGES_EDIT = 0x06D0,
        IDM_VS_CTXT_PREVIEWCHANGES = 0x06D1,
        IDG_VS_TOOLBAR_CALLBROWSER1_ACTIONS = 0x06E0,
        IDG_VS_TOOLBAR_CALLBROWSER2_ACTIONS = 0x06E1,
        IDG_VS_TOOLBAR_CALLBROWSER3_ACTIONS = 0x06E2,
        IDG_VS_TOOLBAR_CALLBROWSER4_ACTIONS = 0x06E3,
        IDG_VS_TOOLBAR_CALLBROWSER5_ACTIONS = 0x06E4,
        IDG_VS_TOOLBAR_CALLBROWSER6_ACTIONS = 0x06E5,
        IDG_VS_TOOLBAR_CALLBROWSER7_ACTIONS = 0x06E6,
        IDG_VS_TOOLBAR_CALLBROWSER8_ACTIONS = 0x06E7,
        IDG_VS_TOOLBAR_CALLBROWSER9_ACTIONS = 0x06E8,
        IDG_VS_TOOLBAR_CALLBROWSER10_ACTIONS = 0x06E9,
        IDG_VS_TOOLBAR_CALLBROWSER11_ACTIONS = 0x06EA,
        IDG_VS_TOOLBAR_CALLBROWSER12_ACTIONS = 0x06EB,
        IDG_VS_TOOLBAR_CALLBROWSER13_ACTIONS = 0x06EC,
        IDG_VS_TOOLBAR_CALLBROWSER14_ACTIONS = 0x06ED,
        IDG_VS_TOOLBAR_CALLBROWSER15_ACTIONS = 0x06EE,
        IDG_VS_TOOLBAR_CALLBROWSER16_ACTIONS = 0x06EF,
        ///////////////////////////////////////////////
        //
        // VS Enterprise menu and menu groups
        //
        ///////////////////////////////////////////////
        // Team Foundation Client standard menu
        IDM_MENU_TEAM_FOUNDATION_CLIENT = 0x700,
        IDM_MENU_PROJECT_CONTEXT_MENU = 0x707,
        IDM_TEAM_PROJECT_SETTINGS_MENU = 0x708,
        IDM_TEAM_SERVER_SETTINGS_MENU = 0x709,
        // Team Foundation Client Toolbar Group
        IDG_TEAM_FOUNDATION_CLIENT_TOOLBAR = 0x701,
        // Commands on the Team menu for projects that require project context
        IDG_MENU_PROJECT_CONTEXT = 0x702,
        // Commands on the Team menu shared by tools (e.g. Properties)
        IDG_SHARED_COMMANDS = 0x703,
        // Tool-specific commands on the Team menu
        IDG_TOOL_COMMANDS = 0x704,
        // Team Project Settings Cascade Menu Group
        IDG_TEAM_PROJECT_SETTINGS_COMMANDS = 0x705,
        // Team Server Settings Cascade Menu Group
        IDG_TEAM_SERVER_SETTINGS_COMMANDS = 0x706,
        // Commands on the TE context menu for projects that require project context
        IDG_CTXT_PROJECT_CONTEXT = 0x710,
        // Thes are defined up and copies here to ensure accident reuse does not occur
        // #define IDG_VS_FILE_ACCOUNTSETTINGS        0x0711
        //
        //
        // #define IDG_VS_VIEW_ARCH_WINDOWS      0x0720
        // #define IDG_VS_VIEW_ORG_WINDOWS       0x0721
        // #define IDG_VS_VIEW_CODEBROWSENAV_WINDOWS 0x0722
        // #define IDG_VS_VIEW_DEV_WINDOWS       0x0723
        // #define IDG_VS_WNDO_FINDRESULTS       0x0724
        IDG_VS_TOOLBAR_PROJWIN_NAVIGATION = 0x0730,   // Contains navigation commands for the Solution Explorer (back, forward, home)
        IDG_VS_TOOLBAR_PROJWIN_NEWVIEW = 0x0731,   // Contains the New View toolbar command
        IDM_VS_CTXT_PROJWIN_FILECONTENTS = 0x0732,   // Context menu for GraphNode items in the Solution Explorer
        IDM_VS_CSCD_PROJWIN_FILECONTENTS_SCOPELIST = 0x0733,   // Flyout menu for changing the view to a different aspect
        IDG_VS_CTXT_PROJWIN_SCOPE = 0x0734,   // Group for containing view-scoping commands (Scope View To This, New View, Change View To)
        IDG_VS_CTXT_PROJWIN_SCOPELIST = 0x0735,   // Group for containing the dynamic list of scopes the Solution Explorer can be changed to
        IDG_VS_CTXT_PROJWIN_FILECONTENTS_SCOPE = 0x0736,   // Group specifically for the Item Contents context menu, containing the Scope View To This command
        IDG_VS_CTXT_PROJWIN_FILECONTENTS_NEWVIEW = 0x0737,   // Group specifically for the Item Contents context menu, containing the New View command
        IDG_VS_TOOLBAR_PROJWIN_FILTERS = 0x0738,   // Group containing common filters for the Solution Explorer (e.g. Opened, Pending Changes)
        IDM_VS_CTXT_PEEKRESULT = 0x0739,   // Context menu for results in Peek
        IDG_VS_CTXT_PEEKRESULTGROUP = 0x073A,   // Contains commands that can run on peek results (Copy Full Path, Promote to Document, Open Containing Folder)
                                                // Context menus and groups for document tab well
        IDM_VS_CTXT_DOCUMENT_TABWELL = 0x0740,   // Context menu for document tab wells
        IDM_VS_CTXT_FLOATING_DOCUMENT_TABWELL = 0x0741,   // Context menu for floating document tab wells
        IDG_VS_EZ_DOCWELLOPS = 0x0742,
        IDG_VS_EZ_FLOATALL = 0x0743,
        IDG_VS_EZ_DOCUMENT_TAB_SETTINGS = 0x0744,   // Group for command to invoke the "Tabs and Windows" page in Tools.Options
        IDM_VS_CTXT_DOCUMENT_TABWELL_SETTINGS = 0x0745,   // Context menu for document tab well settings
        IDG_VS_TABOPT_SORT_ORDER = 0x0746,   // Group for tab sort order (alpha, MRO, etc.)
        IDG_VS_TABOPT_GROUPING = 0x0747,   // Group for tab grouping (none, by project)
        IDG_VS_TABOPT_COLORIZATION = 0x0748,   // Group for tab colorization (none, by project, etc.)
        IDG_VS_EZ_TAB_COLOR_SELECTION = 0x0749,   // Group for tab color selection (i.e., select from a range of colors)
        IDG_VS_EZ_TAB_NOCOLOR_SELECTION = 0x074A,   // Group for command for "no tab color" selection
                                                    ////////////////////////////////////////////////
                                                    //
                                                    // Refactor menu groups
                                                    //
                                                    ////////////////////////////////////////////////
        IDG_REFACTORING_COMMON = 0x1801,
        IDG_REFACTORING_ADVANCED = 0x1802,
        IDBI_ExtractMethod = 1,
        IDBI_EncapsulateField = 2,
        IDBI_ExtractInterface = 3,
        IDBI_Rename = 4,
        IDBI_ReorderParameters = 5,
        IDBI_RemoveParameters = 6,
        IDBI_AddUsing = 7,
        IDBI_GenerateMethod = 8,
        IDBI_PromoteLocal = 9,
        IDBI_Snippet = 10,
        ///////////////////////////////////////////////
        //
        // Server Explorer menu groups
        //
        ///////////////////////////////////////////////
        // Groups
        IDG_SE_CONTEXT_GENERAL = 0x0312,
        IDG_SE_CONTEXT_DELETE = 0x0313,
        IDG_SE_CONTEXT_DATA = 0x0314,
        IDG_SE_CONTEXT_NODE = 0x0315,
        IDG_SE_CONTEXT_DATAPROP = 0x0316,
        IDG_SE_CONTEXT_SQLINSTANCE = 0x0317,
        IDG_SE_TOOLBAR_REFRESH = 0X0403,
        IDG_SE_TOOLBAR_VIEW = 0x0404,
        IDG_SE_TOOLBAR_VIEW_LIST = 0x0405,
        IDG_SE_TOOLBAR_VIEW_SAVE = 0x0406,
        // A new group under the Tools menu.  It's for <Add..> nodes.
        IDG_SE_TOOLS_ADD = 0x0408,
        // Menus
        IDM_SE_CONTEXT_STANDARD = 0x0503,
        IDM_SE_TOOLBAR_VIEW = 0x0504,
        IDM_SE_TOOLBAR_SERVEREXPLORER = 0x0600,
        ///////////////////////////////////////////////
        //
        // SQL Server Object Explorer menu groups
        //
        ///////////////////////////////////////////////
        //Context Menu
        mnuIdSqlServerObjectExplorerContextMenu = 0x2003,
        ///////////////////////////////////////////////
        //
        // Data Explorer menu groups
        //
        ///////////////////////////////////////////////
        IDG_DV_GLOBAL1 = 0x4001,
        IDG_DV_GLOBAL2 = 0x4002,
        IDG_DV_GLOBAL3 = 0x4003,
        IDG_DV_CONNECTION = 0x4101,
        // These are the old (DDEX 1.0) names
        IDG_DV_STATIC = 0x4401,
        IDG_DV_OBJECT = 0x4301,
        IDG_DV_STATICS = 0x4701,
        IDG_DV_OBJECTS = 0x4501,
        IDG_DV_MIXED_OBJECTS = 0x4601,
        IDG_DV_MIXED = 0x4801,
        // These are the new (DDEX 2.0+) names
        IDG_DV_STATIC_NODE = 0x4401,
        IDG_DV_OBJECT_NODE = 0x4301,
        IDG_DV_STATIC_NODES = 0x4701,
        IDG_DV_HOMOGENOUS_OBJECT_NODES = 0x4501,
        IDG_DV_HETEROGENOUS_OBJECT_NODES = 0x4601,
        IDG_DV_HETEROGENOUS_NODES = 0x4801,
        //IDG_VS_TOOLBAR is a group that simply contains IDG_VS_TOOLBAR_LIST (the dynamic toolbar list) and IDG_VS_TOOLBAR_CUSTOMIZE (the customize
        //command).  This group is placed both on IDM_VS_CSCD_COMMANDBARS and the toolbar tray context menu (IDM_VS_CTXT_TOOLBARS)
        IDG_VS_TOOLBAR = 0x4802,
        IDG_VS_TOOLBAR_LIST = 0x4803,
        IDG_VS_TOOLBAR_CUSTOMIZE = 0x4804,
        IDM_VS_CTXT_TOOLBARS = 0x4805,
        // Group containing explorer windows in other windows menu
        IDG_VS_WNDO_OTRWNDWSEXPLORERS = 0x5200,
        // groups for upgrade commands
        IDG_VS_ALL_PROJ_UPGRADE = 0x5030,
        // Solution/project fault resolution
        IDG_VS_CTXT_SOLUTION_RESOLVE = 0x5032
    }
}
