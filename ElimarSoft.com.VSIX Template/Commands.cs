using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ElimarSoft.com.VSIX_Template
{
    internal enum myCommands
    {
        //-----------------------------------------------------------------------------
        // Microsoft Visual Studio
        //
        // Copyright 1995-2003 Microsoft Corporation. All Rights Reserved.
        //
        // File: stdidcmd.h
        // Area: IOleCommandTarget and IOleComponentUIManager
        //
        // Contents:
        // Contains ids used for commands used in StandardCommandSet97.
        // StandardCommandSet97 is defined by the following guid:
        //
        // {5efc7975-14bc-11cf-9b2b-00aa00573819}
        // DEFINE_GUID(CLSID_StandardCommandSet97,
        // 0x5efc7975, 0x14bc, 0x11cf, 0x9b, 0x2b, 0x00, 0xaa, 0x00,
        // 0x57, 0x38, 0x19);
        //
        // Contains ids used for commands used in StandardCommandSet2K.
        // StandardCommandSet2K is defined by the following guid:
        //
        // {1496A755-94DE-11D0-8C3F-00C04FC2AAE2}
        // DEFINE_GUID(CMDSETID_StandardCommandSet2K,
        // 0x1496A755, 0x94DE, 0x11D0, 0x8C, 0x3F, 0x00, 0xC0, 0x4F, 0xC2, 0xAA, 0xE2);
        //
        // Contains ids used for commands used in StandardCommandSet10.
        // StandardCommandSet10 is defined by the following guid:
        //
        // {5DD0BB59-7076-4c59-88D3-DE36931F63F0}
        // DEFINE_GUID(CMDSETID_StandardCommandSet10,
        // 0x5dd0bb59, 0x7076, 0x4c59, 0x88, 0xd3, 0xde, 0x36, 0x93, 0x1f, 0x63, 0xf0);
        //
        // Contains ids used for commands used in StandardCommandSet11.
        // StandardCommandSet11 is defined by the following guid:
        //
        // {D63DB1F0-404E-4B21-9648-CA8D99245EC3}
        // DEFINE_GUID(CMDSETID_StandardCommandSet11,
        // 0xd63db1f0, 0x404e, 0x4b21, 0x96, 0x48, 0xca, 0x8d, 0x99, 0x24, 0x5e, 0xc3);
        //
        // Contains ids used for commands used in StandardCommandSet12.
        // StandardCommandSet12 is defined by the following guid:
        //
        // {2A8866DC-7BDE-4dc8-A360-A60679534384}
        // DEFINE_GUID(CMDSETID_StandardCommandSet12,
        // 0x2A8866DC, 0x7BDE, 0x4dc8, 0xA3, 0x60, 0xA6, 0x06, 0x79, 0x53, 0x43, 0x84);
        //
        // Contains ids used for commands used in StandardCommandSet14.
        // StandardCommandSet14 is defined by the following guid:
        //
        // {4C7763BF-5FAF-4264-A366-B7E1F27BA958}
        // DEFINE_GUID(CMDSETID_StandardCommandSet14,
        // 0x4c7763bf, 0x5faf, 0x4264, 0xa3, 0x66, 0xb7, 0xe1, 0xf2, 0x7b, 0xa9, 0x58);
        //
        // {712C6C80-883B-4AAD-B430-BBCA5256FA9D}
        // DEFINE_GUID(CMDSETID_StandardCommandSet15,
        // 0x712c6c80, 0x883b, 0x4aad, 0xb4, 0x30, 0xbb, 0xca, 0x52, 0x56, 0xfa, 0x9d);
        //
        // {8F380902-6040-4097-9837-D3F40E66F908}
        // DEFINE_GUID(CMDSETID_StandardCommandSet16,
        // 0x8f380902, 0x6040, 0x4097, 0x98, 0x37, 0xd3, 0xf4, 0x0e, 0x66, 0xf9, 0x08);
        //
        // NOTE that new commands should be added to the end of StandardCommandSet2K
        // and that CLSID_StandardCommandSet97 should not be further added to.
        // NOTE also that in StandardCommandSet2K all commands up to ECMD_FINAL are
        // standard editor commands and have been moved here from editcmd.h.
        //-----------------------------------------------------------------------------
        cmdidAlignBottom = 1,
        cmdidAlignHorizontalCenters = 2,
        cmdidAlignLeft = 3,
        cmdidAlignRight = 4,
        cmdidAlignToGrid = 5,
        cmdidAlignTop = 6,
        cmdidAlignVerticalCenters = 7,
        cmdidArrangeBottom = 8,
        cmdidArrangeRight = 9,
        cmdidBringForward = 10,
        cmdidBringToFront = 11,
        cmdidCenterHorizontally = 12,
        cmdidCenterVertically = 13,
        cmdidCode = 14,
        cmdidCopy = 15,
        cmdidCut = 16,
        cmdidDelete = 17,
        cmdidFontName = 18,
        cmdidFontNameGetList = 500,
        cmdidFontSize = 19,
        cmdidFontSizeGetList = 501,
        cmdidGroup = 20,
        cmdidHorizSpaceConcatenate = 21,
        cmdidHorizSpaceDecrease = 22,
        cmdidHorizSpaceIncrease = 23,
        cmdidHorizSpaceMakeEqual = 24,
        cmdidLockControls = 369,
        cmdidInsertObject = 25,
        cmdidPaste = 26,
        cmdidPrint = 27,
        cmdidProperties = 28,
        cmdidRedo = 29,
        cmdidMultiLevelRedo = 30,
        cmdidSelectAll = 31,
        cmdidSendBackward = 32,
        cmdidSendToBack = 33,
        cmdidShowTable = 34,
        cmdidSizeToControl = 35,
        cmdidSizeToControlHeight = 36,
        cmdidSizeToControlWidth = 37,
        cmdidSizeToFit = 38,
        cmdidSizeToGrid = 39,
        cmdidSnapToGrid = 40,
        cmdidTabOrder = 41,
        cmdidToolbox = 42,
        cmdidUndo = 43,
        cmdidMultiLevelUndo = 44,
        cmdidUngroup = 45,
        cmdidVertSpaceConcatenate = 46,
        cmdidVertSpaceDecrease = 47,
        cmdidVertSpaceIncrease = 48,
        cmdidVertSpaceMakeEqual = 49,
        cmdidZoomPercent = 50,
        cmdidBackColor = 51,
        cmdidBold = 52,
        cmdidBorderColor = 53,
        cmdidBorderDashDot = 54,
        cmdidBorderDashDotDot = 55,
        cmdidBorderDashes = 56,
        cmdidBorderDots = 57,
        cmdidBorderShortDashes = 58,
        cmdidBorderSolid = 59,
        cmdidBorderSparseDots = 60,
        cmdidBorderWidth1 = 61,
        cmdidBorderWidth2 = 62,
        cmdidBorderWidth3 = 63,
        cmdidBorderWidth4 = 64,
        cmdidBorderWidth5 = 65,
        cmdidBorderWidth6 = 66,
        cmdidBorderWidthHairline = 67,
        cmdidFlat = 68,
        cmdidForeColor = 69,
        cmdidItalic = 70,
        cmdidJustifyCenter = 71,
        cmdidJustifyGeneral = 72,
        cmdidJustifyLeft = 73,
        cmdidJustifyRight = 74,
        cmdidRaised = 75,
        cmdidSunken = 76,
        cmdidUnderline = 77,
        cmdidChiseled = 78,
        cmdidEtched = 79,
        cmdidShadowed = 80,
        cmdidCompDebug1 = 81,
        cmdidCompDebug2 = 82,
        cmdidCompDebug3 = 83,
        cmdidCompDebug4 = 84,
        cmdidCompDebug5 = 85,
        cmdidCompDebug6 = 86,
        cmdidCompDebug7 = 87,
        cmdidCompDebug8 = 88,
        cmdidCompDebug9 = 89,
        cmdidCompDebug10 = 90,
        cmdidCompDebug11 = 91,
        cmdidCompDebug12 = 92,
        cmdidCompDebug13 = 93,
        cmdidCompDebug14 = 94,
        cmdidCompDebug15 = 95,
        cmdidExistingSchemaEdit = 96,
        cmdidFind = 97,
        cmdidGetZoom = 98,
        cmdidQueryOpenDesign = 99,
        cmdidQueryOpenNew = 100,
        cmdidSingleTableDesign = 101,
        cmdidSingleTableNew = 102,
        cmdidShowGrid = 103,
        cmdidNewTable = 104,
        cmdidCollapsedView = 105,
        cmdidFieldView = 106,
        cmdidVerifySQL = 107,
        cmdidHideTable = 108,
        cmdidPrimaryKey = 109,
        cmdidSave = 110,
        cmdidSaveAs = 111,
        cmdidSortAscending = 112,
        cmdidSortDescending = 113,
        cmdidAppendQuery = 114,
        cmdidCrosstabQuery = 115,
        cmdidDeleteQuery = 116,
        cmdidMakeTableQuery = 117,
        cmdidSelectQuery = 118,
        cmdidUpdateQuery = 119,
        cmdidParameters = 120,
        cmdidTotals = 121,
        cmdidViewCollapsed = 122,
        cmdidViewFieldList = 123,
        cmdidViewKeys = 124,
        cmdidViewGrid = 125,
        cmdidInnerJoin = 126,
        cmdidRightOuterJoin = 127,
        cmdidLeftOuterJoin = 128,
        cmdidFullOuterJoin = 129,
        cmdidUnionJoin = 130,
        cmdidShowSQLPane = 131,
        cmdidShowGraphicalPane = 132,
        cmdidShowDataPane = 133,
        cmdidShowQBEPane = 134,
        cmdidSelectAllFields = 135,
        cmdidOLEObjectMenuButton = 136,
        // ids on the ole verbs menu - these must be sequential ie verblist0-verblist9
        cmdidObjectVerbList0 = 137,
        cmdidObjectVerbList1 = 138,
        cmdidObjectVerbList2 = 139,
        cmdidObjectVerbList3 = 140,
        cmdidObjectVerbList4 = 141,
        cmdidObjectVerbList5 = 142,
        cmdidObjectVerbList6 = 143,
        cmdidObjectVerbList7 = 144,
        cmdidObjectVerbList8 = 145,
        cmdidObjectVerbList9 = 146,
        cmdidConvertObject = 147,
        cmdidCustomControl = 148,
        cmdidCustomizeItem = 149,
        cmdidRename = 150,
        cmdidImport = 151,
        cmdidNewPage = 152,
        cmdidMove = 153,
        cmdidCancel = 154,
        cmdidFont = 155,
        cmdidExpandLinks = 156,
        cmdidExpandImages = 157,
        cmdidExpandPages = 158,
        cmdidRefocusDiagram = 159,
        cmdidTransitiveClosure = 160,
        cmdidCenterDiagram = 161,
        cmdidZoomIn = 162,
        cmdidZoomOut = 163,
        cmdidRemoveFilter = 164,
        cmdidHidePane = 165,
        cmdidDeleteTable = 166,
        cmdidDeleteRelationship = 167,
        cmdidRemove = 168,
        cmdidJoinLeftAll = 169,
        cmdidJoinRightAll = 170,
        cmdidAddToOutput = 171,
        cmdidOtherQuery = 172,
        cmdidGenerateChangeScript = 173,
        cmdidSaveSelection = 174,
        cmdidAutojoinCurrent = 175,
        cmdidAutojoinAlways = 176,
        cmdidEditPage = 177,
        cmdidViewLinks = 178,
        cmdidStop = 179,
        cmdidPause = 180,
        cmdidResume = 181,
        cmdidFilterDiagram = 182,
        cmdidShowAllObjects = 183,
        cmdidShowApplications = 184,
        cmdidShowOtherObjects = 185,
        cmdidShowPrimRelationships = 186,
        cmdidExpand = 187,
        cmdidCollapse = 188,
        cmdidRefresh = 189,
        cmdidLayout = 190,
        cmdidShowResources = 191,
        cmdidInsertHTMLWizard = 192,
        cmdidShowDownloads = 193,
        cmdidShowExternals = 194,
        cmdidShowInBoundLinks = 195,
        cmdidShowOutBoundLinks = 196,
        cmdidShowInAndOutBoundLinks = 197,
        cmdidPreview = 198,
        cmdidOpen = 261,
        cmdidOpenWith = 199,
        cmdidShowPages = 200,
        cmdidRunQuery = 201,
        cmdidClearQuery = 202,
        cmdidRecordFirst = 203,
        cmdidRecordLast = 204,
        cmdidRecordNext = 205,
        cmdidRecordPrevious = 206,
        cmdidRecordGoto = 207,
        cmdidRecordNew = 208,
        cmdidInsertNewMenu = 209,
        cmdidInsertSeparator = 210,
        cmdidEditMenuNames = 211,
        cmdidDebugExplorer = 212,
        cmdidDebugProcesses = 213,
        cmdidViewThreadsWindow = 214,
        cmdidWindowUIList = 215,
        // ids on the file menu
        cmdidNewProject = 216,
        cmdidOpenProject = 217,
        cmdidOpenSolution = 218,
        cmdidCloseSolution = 219,
        cmdidFileNew = 221,
        cmdidNewProjectFromExisting = 385,
        cmdidFileOpen = 222,
        cmdidFileOpenFromWeb = 451,
        cmdidFileClose = 223,
        cmdidSaveSolution = 224,
        cmdidSaveSolutionAs = 225,
        cmdidSaveProjectItemAs = 226,
        cmdidPageSetup = 227,
        cmdidPrintPreview = 228,
        cmdidExit = 229,
        // ids on the edit menu
        cmdidReplace = 230,
        cmdidGoto = 231,
        // ids on the view menu
        cmdidPropertyPages = 232,
        cmdidFullScreen = 233,
        cmdidProjectExplorer = 234,
        cmdidPropertiesWindow = 235,
        cmdidTaskListWindow = 236,
        //#define cmdidErrorListWindow 320 // defined below
        cmdidOutputWindow = 237,
        cmdidObjectBrowser = 238,
        cmdidDocOutlineWindow = 239,
        cmdidImmediateWindow = 240,
        cmdidWatchWindow = 241,
        cmdidLocalsWindow = 242,
        cmdidCallStack = 243,
        // moved below definition
        //#define cmdidAutosWindow cmdidDebugReserved1
        //#define cmdidThisWindow cmdidDebugReserved2
        // ids on project menu
        cmdidAddNewItem = 220,
        cmdidAddExistingItem = 244,
        cmdidNewFolder = 245,
        cmdidSetStartupProject = 246,
        cmdidProjectSettings = 247,
        cmdidProjectReferences = 367,
        // ids on the debug menu
        cmdidStepInto = 248,
        cmdidStepOver = 249,
        cmdidStepOut = 250,
        cmdidRunToCursor = 251,
        cmdidAddWatch = 252,
        cmdidEditWatch = 253,
        cmdidQuickWatch = 254,
        cmdidToggleBreakpoint = 255,
        cmdidClearBreakpoints = 256,
        cmdidShowBreakpoints = 257,
        cmdidSetNextStatement = 258,
        cmdidShowNextStatement = 259,
        cmdidEditBreakpoint = 260,
        cmdidDetachDebugger = 262,
        // ids on the tools menu
        cmdidCustomizeKeyboard = 263,
        cmdidToolsOptions = 264,
        // ids on the windows menu
        cmdidNewWindow = 265,
        cmdidSplit = 266,
        cmdidCascade = 267,
        cmdidTileHorz = 268,
        cmdidTileVert = 269,
        // ids on the help menu
        cmdidTechSupport = 270,
        cmdidOnlinePrivacyStatement = 475,
        // #define cmdidDebugContextWindow 327 // defined below
        // NOTE cmdidAbout and cmdidDebugOptions must be consecutive
        // cmd after cmdidDebugOptions (ie 273) must not be used
        cmdidAbout = 271,
        cmdidDebugOptions = 272,
        // ids on the watch context menu
        // CollapseWatch appears as 'Collapse Parent', on any
        // non-top-level item
        cmdidDeleteWatch = 274,
        cmdidCollapseWatch = 275,
        // ids 276 277 278 279 280 are in use
        // below
        // ids on the property browser context menu
        cmdidPbrsToggleStatus = 282,
        cmdidPropbrsHide = 283,
        // ids on the docking context menu
        cmdidDockingView = 284,
        cmdidHideActivePane = 285,
        // ids for window selection via keyboard
        //#define cmdidPaneNextPane 316 (listed below in order)
        //#define cmdidPanePrevPane 317 (listed below in order)
        cmdidPaneNextTab = 286,
        cmdidPanePrevTab = 287,
        cmdidPaneCloseToolWindow = 288,
        cmdidPaneActivateDocWindow = 289,
        cmdidDockingViewDocument = 290,
        cmdidDockingViewFloater = 291,
        cmdidAutoHideWindow = 292,
        cmdidMoveToDropdownBar = 293,
        cmdidFindCmd = 294,
        cmdidStart = 295,
        cmdidRestart = 296,
        cmdidMultiLevelUndoList = 298,
        cmdidMultiLevelRedoList = 299,
        cmdidToolboxAddTab = 300,
        cmdidToolboxDeleteTab = 301,
        cmdidToolboxRenameTab = 302,
        cmdidToolboxTabMoveUp = 303,
        cmdidToolboxTabMoveDown = 304,
        cmdidToolboxRenameItem = 305,
        cmdidToolboxListView = 306,
        //(below) cmdidSearchSetCombo 307
        cmdidWindowUIGetList = 308,
        cmdidInsertValuesQuery = 309,
        cmdidShowProperties = 310,
        cmdidThreadSuspend = 311,
        cmdidThreadResume = 312,
        cmdidThreadSetFocus = 313,
        cmdidDisplayRadix = 314,
        cmdidOpenProjectItem = 315,
        cmdidPaneNextPane = 316,
        cmdidPanePrevPane = 317,
        cmdidClearPane = 318,
        cmdidGotoErrorTag = 319,
        cmdidErrorListWindow = 320,
        cmdidCancelEZDrag = 326,
        cmdidDebugContextWindow = 327,
        // Samples are no longer supported post d15
        // #define cmdidHelpSamples 328
        cmdidToolboxAddItem = 329,
        cmdidToolboxReset = 330,
        cmdidSaveProjectItem = 331,
        cmdidSaveOptions = 959,
        cmdidViewForm = 332,
        cmdidViewCode = 333,
        cmdidPreviewInBrowser = 334,
        cmdidBrowseWith = 336,
        cmdidSearchSetCombo = 307,
        cmdidSearchCombo = 337,
        cmdidEditLabel = 338,
        cmdidExceptions = 339,
        // UNUSED 340
        cmdidToggleSelMode = 341,
        cmdidToggleInsMode = 342,
        cmdidLoadUnloadedProject = 343,
        cmdidUnloadLoadedProject = 344,
        // ids on the treegrids (watch/local/threads/stack)
        cmdidElasticColumn = 345,
        cmdidHideColumn = 346,
        cmdidToggleDesigner = 347,
        cmdidZoomDialog = 348,
        // find/replace options
        cmdidFindInSelection = 354,
        cmdidFindStop = 355,
        cmdidFindInFiles = 277,
        cmdidReplaceInFiles = 278,
        cmdidNextLocation = 279,
        cmdidPreviousLocation = 280,
        ECMD_DELETEROWS = 260,
        ECMD_SELECTTABLE = 261,
        ECMD_SELECTTABLECOL = 262,
        ECMD_SELECTTABLEROW = 263,
        ECMD_SELECTTABLECELL = 264,
        ECMD_MERGECELLS = 265,
        ECMD_SPLITCELL = 266,
        ECMD_INSERTCELLLEFT = 267,
        ECMD_DELETECELLS = 268,
        ECMD_SHOWGRID = 277,
        ECMD_SNAPTOGRID = 278,
        ECMD_BOOKMARK = 279,
        ECMD_HYPERLINK = 280,
        // unused 284
        ECMD_BULLETEDLIST = 287,
        ECMD_NUMBEREDLIST = 288,
        ECMD_EDITSCRIPT = 289,
        ECMD_EDITCODEBEHIND = 290,
        ECMD_DOCOUTLINEHTML = 291,
        ECMD_RUNATSERVER = 293,
        ECMD_WEBFORMSVERBS = 294,
        ECMD_WEBFORMSTEMPLATES = 295,
        ECMD_ENDTEMPLATE = 296,
        ECMD_EDITDEFAULTEVENT = 297,
        ECMD_SUPERSCRIPT = 298,
        ECMD_SUBSCRIPT = 299,
        ECMD_EDITSTYLE = 300,
        ECMD_ADDIMAGEHEIGHTWIDTH = 301,
        ECMD_REMOVEIMAGEHEIGHTWIDTH = 302,
        ECMD_LOCKELEMENT = 303,
        ECMD_AUTOCLOSEOVERRIDE = 305,
        ECMD_NEWANY = 306,
        ECMD_NEWANYATTRIBUTE = 307,
        ECMD_DELETEKEY = 308,
        ECMD_AUTOARRANGE = 309,
        ECMD_VALIDATESCHEMA = 310,
        ECMD_NEWFACET = 311,
        ECMD_VALIDATEXMLDATA = 312,
        ECMD_DOCOUTLINETOGGLE = 313,
        ECMD_VALIDATEHTMLDATA = 314,
        ECMD_VIEWXMLSCHEMAOVERVIEW = 315,
        ECMD_SHOWDEFAULTVIEW = 316,
        ECMD_EXPAND_CHILDREN = 317,
        ECMD_COLLAPSE_CHILDREN = 318,
        ECMD_TOPDOWNLAYOUT = 319,
        ECMD_LEFTRIGHTLAYOUT = 320,
        ECMD_INSERTCELLRIGHT = 321,
        ECMD_EDITMASTER = 322,
        ECMD_INSERTSNIPPET = 323,
        ECMD_FORMATANDVALIDATION = 324,
        ECMD_COLLAPSETAG = 325,
        ECMD_SELECT_TAG = 329,
        ECMD_SELECT_TAG_CONTENT = 330,
        ECMD_CHECK_ACCESSIBILITY = 331,
        ECMD_UNCOLLAPSETAG = 332,
        ECMD_GENERATEPAGERESOURCE = 333,
        ECMD_SHOWNONVISUALCONTROLS = 334,
        ECMD_RESIZECOLUMN = 335,
        ECMD_RESIZEROW = 336,
        ECMD_MAKEABSOLUTE = 337,
        ECMD_MAKERELATIVE = 338,
        ECMD_MAKESTATIC = 339,
        ECMD_INSERTLAYER = 340,
        ECMD_UPDATEDESIGNVIEW = 341,
        ECMD_UPDATESOURCEVIEW = 342,
        ECMD_INSERTCAPTION = 343,
        ECMD_DELETECAPTION = 344,
        ECMD_MAKEPOSITIONNOTSET = 345,
        ECMD_AUTOPOSITIONOPTIONS = 346,
        ECMD_EDITIMAGE = 347,
        ECMD_VALIDATION_TARGET = 11281,
        ECMD_VALIDATION_TARGET_GET_LIST = 11282,
        ECMD_CSS_TARGET = 11283,
        ECMD_CSS_TARGET_GET_LIST = 11284,
        //
        // Shareable commands originating in the VC project
        //
        ECMD_COMPILE = 350,
        //
        ECMD_PROJSETTINGS = 352,
        ECMD_LINKONLY = 353,
        //
        ECMD_REMOVE = 355,
        ECMD_PROJSTARTDEBUG = 356,
        ECMD_PROJSTEPINTO = 357,
        ECMD_UPDATEMGDRES = 358,
        ECMD_PROJSTARTNODEBUG = 359,
        //
        //
        ECMD_UPDATEWEBREF = 360,
        //
        ECMD_ADDRESOURCE = 362,
        ECMD_WEBDEPLOY = 363,
        //
        ECMD_PROJTOOLORDER = 367,
        //
        ECMD_PROJECTTOOLFILES = 368,
        //
        ECMD_OTB_PGO_INSTRUMENT = 369,
        ECMD_OTB_PGO_OPT = 370,
        ECMD_OTB_PGO_UPDATE = 371,
        ECMD_OTB_PGO_RUNSCENARIO = 372,
        cmdidUpgradeProject = 390,
        cmdidUpgradeAllProjects = 391,
        cmdidShowUpdateSolutionDialog = 392,
        //
        // Shareable commands originating in the VB and VBA projects
        // Note that there are two versions of each command. One
        // version is originally from the main (project) menu and the
        // other version from a cascading Add context menu. The main
        // difference between the two commands is that the main menu
        // version starts with the text Add whereas this is not
        // present on the context menu version.
        //
        ECMD_ADDHTMLPAGE = 400,
        ECMD_ADDHTMLPAGECTX = 401,
        ECMD_ADDMODULE = 402,
        ECMD_ADDMODULECTX = 403,
        // unused 404
        // unused 405
        ECMD_ADDWFCFORM = 406,
        // unused 407
        // unused 408
        // unused 409
        ECMD_ADDWEBFORM = 410,
        ECMD_ADDMASTERPAGE = 411,
        ECMD_ADDUSERCONTROL = 412,
        ECMD_ADDCONTENTPAGE = 413,
        // unused 414 to 425
        ECMD_ADDDHTMLPAGE = 426,
        // unused 427 to 431
        ECMD_ADDIMAGEGENERATOR = 432,
        // unused 433
        ECMD_ADDINHERWFCFORM = 434,
        // unused 435
        ECMD_ADDINHERCONTROL = 436,
        // unused 437
        ECMD_ADDWEBUSERCONTROL = 438,
        // unused 439
        // unused 440
        // unused 441
        ECMD_ADDTBXCOMPONENT = 442,
        // unused 443
        ECMD_ADDWEBSERVICE = 444,
        ECMD_ADDSTYLESHEET = 445,
        ECMD_SETBROWSELOCATION = 446,
        ECMD_REFRESHFOLDER = 447,
        ECMD_SETBROWSELOCATIONCTX = 448,
        ECMD_VIEWMARKUP = 449,
        ECMD_NEXTMETHOD = 450,
        ECMD_PREVMETHOD = 451,
        // VB refactoring commands
        ECMD_RENAMESYMBOL = 452,
        ECMD_SHOWREFERENCES = 453,
        ECMD_CREATESNIPPET = 454,
        ECMD_CREATEREPLACEMENT = 455,
        ECMD_INSERTCOMMENT = 456,
        ECMD_VIEWCOMPONENTDESIGNER = 457,
        ECMD_GOTOTYPEDEF = 458,
        ECMD_SHOWSNIPPETHIGHLIGHTING = 459,
        ECMD_HIDESNIPPETHIGHLIGHTING = 460,
        //
        // Shareable commands originating in the VFP project
        //
        ECMD_ADDVFPPAGE = 500,
        ECMD_SETBREAKPOINT = 501,
        //
        // Shareable commands originating in the HELP WORKSHOP project
        //
        ECMD_SHOWALLFILES = 600,
        ECMD_ADDTOPROJECT = 601,
        ECMD_ADDBLANKNODE = 602,
        ECMD_ADDNODEFROMFILE = 603,
        ECMD_CHANGEURLFROMFILE = 604,
        ECMD_EDITTOPIC = 605,
        ECMD_EDITTITLE = 606,
        ECMD_MOVENODEUP = 607,
        ECMD_MOVENODEDOWN = 608,
        ECMD_MOVENODELEFT = 609,
        ECMD_MOVENODERIGHT = 610,
        //
        // Shareable commands originating in the Deploy project
        //
        // Note there are two groups of deploy project commands.
        // The first group of deploy commands.
        ECMD_ADDOUTPUT = 700,
        ECMD_ADDFILE = 701,
        ECMD_MERGEMODULE = 702,
        ECMD_ADDCOMPONENTS = 703,
        ECMD_LAUNCHINSTALLER = 704,
        ECMD_LAUNCHUNINSTALL = 705,
        ECMD_LAUNCHORCA = 706,
        ECMD_FILESYSTEMEDITOR = 707,
        ECMD_REGISTRYEDITOR = 708,
        ECMD_FILETYPESEDITOR = 709,
        ECMD_USERINTERFACEEDITOR = 710,
        ECMD_CUSTOMACTIONSEDITOR = 711,
        ECMD_LAUNCHCONDITIONSEDITOR = 712,
        ECMD_EDITOR = 713,
        ECMD_EXCLUDE = 714,
        ECMD_REFRESHDEPENDENCIES = 715,
        ECMD_VIEWOUTPUTS = 716,
        ECMD_VIEWDEPENDENCIES = 717,
        ECMD_VIEWFILTER = 718,
        //
        // The Second group of deploy commands.
        // Note that there is a special sub-group in which the relative
        // positions are important (see below)
        //
        ECMD_KEY = 750,
        ECMD_STRING = 751,
        ECMD_BINARY = 752,
        ECMD_DWORD = 753,
        ECMD_KEYSOLO = 754,
        ECMD_IMPORT = 755,
        ECMD_FOLDER = 756,
        ECMD_PROJECTOUTPUT = 757,
        ECMD_FILE = 758,
        ECMD_ADDMERGEMODULES = 759,
        ECMD_CREATESHORTCUT = 760,
        ECMD_LARGEICONS = 761,
        ECMD_SMALLICONS = 762,
        ECMD_LIST = 763,
        ECMD_DETAILS = 764,
        ECMD_ADDFILETYPE = 765,
        ECMD_ADDACTION = 766,
        ECMD_SETASDEFAULT = 767,
        ECMD_MOVEUP = 768,
        ECMD_MOVEDOWN = 769,
        ECMD_ADDDIALOG = 770,
        ECMD_IMPORTDIALOG = 771,
        ECMD_ADDFILESEARCH = 772,
        ECMD_ADDREGISTRYSEARCH = 773,
        ECMD_ADDCOMPONENTSEARCH = 774,
        ECMD_ADDLAUNCHCONDITION = 775,
        ECMD_ADDCUSTOMACTION = 776,
        ECMD_OUTPUTS = 777,
        ECMD_DEPENDENCIES = 778,
        ECMD_FILTER = 779,
        ECMD_COMPONENTS = 780,
        ECMD_ENVSTRING = 781,
        ECMD_CREATEEMPTYSHORTCUT = 782,
        ECMD_ADDFILECONDITION = 783,
        ECMD_ADDREGISTRYCONDITION = 784,
        ECMD_ADDCOMPONENTCONDITION = 785,
        ECMD_ADDURTCONDITION = 786,
        ECMD_ADDIISCONDITION = 787,
        //
        // The relative positions of the commands within the following deploy
        // subgroup must remain unaltered, although the group as a whole may
        // be repositioned. Note that the first and last elements are special
        // boundary elements.
        ECMD_SPECIALFOLDERBASE = 800,
        ECMD_USERSAPPLICATIONDATAFOLDER = 800,
        ECMD_COMMONFILES64FOLDER = 801,
        ECMD_COMMONFILESFOLDER = 802,
        ECMD_CUSTOMFOLDER = 803,
        ECMD_USERSDESKTOP = 804,
        ECMD_USERSFAVORITESFOLDER = 805,
        ECMD_FONTSFOLDER = 806,
        ECMD_GLOBALASSEMBLYCACHEFOLDER = 807,
        ECMD_MODULERETARGETABLEFOLDER = 808,
        ECMD_USERSPERSONALDATAFOLDER = 809,
        ECMD_PROGRAMFILES64FOLDER = 810,
        ECMD_PROGRAMFILESFOLDER = 811,
        ECMD_USERSPROGRAMSMENU = 812,
        ECMD_USERSSENDTOMENU = 813,
        ECMD_SHAREDCOMPONENTSFOLDER = 814,
        ECMD_USERSSTARTMENU = 815,
        ECMD_USERSSTARTUPFOLDER = 816,
        ECMD_SYSTEM64FOLDER = 817,
        ECMD_SYSTEMFOLDER = 818,
        ECMD_APPLICATIONFOLDER = 819,
        ECMD_USERSTEMPLATEFOLDER = 820,
        ECMD_WEBCUSTOMFOLDER = 821,
        ECMD_WINDOWSFOLDER = 822,
        ECMD_SPECIALFOLDERLAST = 822,
        // End of deploy sub-group
        //
        // Shareable commands originating in the Visual Studio Analyzer project
        //
        ECMD_EXPORTEVENTS = 900,
        ECMD_IMPORTEVENTS = 901,
        ECMD_VIEWEVENT = 902,
        ECMD_VIEWEVENTLIST = 903,
        ECMD_VIEWCHART = 904,
        ECMD_VIEWMACHINEDIAGRAM = 905,
        ECMD_VIEWPROCESSDIAGRAM = 906,
        ECMD_VIEWSOURCEDIAGRAM = 907,
        ECMD_VIEWSTRUCTUREDIAGRAM = 908,
        ECMD_VIEWTIMELINE = 909,
        ECMD_VIEWSUMMARY = 910,
        ECMD_APPLYFILTER = 911,
        ECMD_CLEARFILTER = 912,
        ECMD_STARTRECORDING = 913,
        ECMD_STOPRECORDING = 914,
        ECMD_PAUSERECORDING = 915,
        ECMD_ACTIVATEFILTER = 916,
        ECMD_SHOWFIRSTEVENT = 917,
        ECMD_SHOWPREVIOUSEVENT = 918,
        ECMD_SHOWNEXTEVENT = 919,
        ECMD_SHOWLASTEVENT = 920,
        ECMD_REPLAYEVENTS = 921,
        ECMD_STOPREPLAY = 922,
        ECMD_INCREASEPLAYBACKSPEED = 923,
        ECMD_DECREASEPLAYBACKSPEED = 924,
        ECMD_ADDMACHINE = 925,
        ECMD_ADDREMOVECOLUMNS = 926,
        ECMD_SORTCOLUMNS = 927,
        ECMD_SAVECOLUMNSETTINGS = 928,
        ECMD_RESETCOLUMNSETTINGS = 929,
        ECMD_SIZECOLUMNSTOFIT = 930,
        ECMD_AUTOSELECT = 931,
        ECMD_AUTOFILTER = 932,
        ECMD_AUTOPLAYTRACK = 933,
        ECMD_GOTOEVENT = 934,
        ECMD_ZOOMTOFIT = 935,
        ECMD_ADDGRAPH = 936,
        ECMD_REMOVEGRAPH = 937,
        ECMD_CONNECTMACHINE = 938,
        ECMD_DISCONNECTMACHINE = 939,
        ECMD_EXPANDSELECTION = 940,
        ECMD_COLLAPSESELECTION = 941,
        ECMD_ADDFILTER = 942,
        ECMD_ADDPREDEFINED0 = 943,
        ECMD_ADDPREDEFINED1 = 944,
        ECMD_ADDPREDEFINED2 = 945,
        ECMD_ADDPREDEFINED3 = 946,
        ECMD_ADDPREDEFINED4 = 947,
        ECMD_ADDPREDEFINED5 = 948,
        ECMD_ADDPREDEFINED6 = 949,
        ECMD_ADDPREDEFINED7 = 950,
        ECMD_ADDPREDEFINED8 = 951,
        ECMD_TIMELINESIZETOFIT = 952,
        //
        // Shareable commands originating with Crystal Reports
        //
        ECMD_FIELDVIEW = 1000,
        ECMD_SELECTEXPERT = 1001,
        ECMD_TOPNEXPERT = 1002,
        ECMD_SORTORDER = 1003,
        ECMD_PROPPAGE = 1004,
        ECMD_HELP = 1005,
        ECMD_SAVEREPORT = 1006,
        ECMD_INSERTSUMMARY = 1007,
        ECMD_INSERTGROUP = 1008,
        ECMD_INSERTSUBREPORT = 1009,
        ECMD_INSERTCHART = 1010,
        ECMD_INSERTPICTURE = 1011,
        //
        // Shareable commands from the common project area (DirPrj)
        //
        ECMD_SETASSTARTPAGE = 1100,
        ECMD_RECALCULATELINKS = 1101,
        ECMD_WEBPERMISSIONS = 1102,
        ECMD_COMPARETOMASTER = 1103,
        ECMD_WORKOFFLINE = 1104,
        ECMD_SYNCHRONIZEFOLDER = 1105,
        ECMD_SYNCHRONIZEALLFOLDERS = 1106,
        ECMD_COPYPROJECT = 1107,
        ECMD_IMPORTFILEFROMWEB = 1108,
        ECMD_INCLUDEINPROJECT = 1109,
        ECMD_EXCLUDEFROMPROJECT = 1110,
        ECMD_BROKENLINKSREPORT = 1111,
        ECMD_ADDPROJECTOUTPUTS = 1112,
        ECMD_ADDREFERENCE = 1113,
        ECMD_ADDWEBREFERENCE = 1114,
        ECMD_ADDWEBREFERENCECTX = 1115,
        ECMD_UPDATEWEBREFERENCE = 1116,
        ECMD_RUNCUSTOMTOOL = 1117,
        ECMD_SETRUNTIMEVERSION = 1118,
        ECMD_VIEWREFINOBJECTBROWSER = 1119,
        ECMD_PUBLISH = 1120,
        ECMD_PUBLISHCTX = 1121,
        ECMD_STARTOPTIONS = 1124,
        ECMD_ADDREFERENCECTX = 1125,
        // note cmdidPropertyManager is consuming  1126 and it shouldn't
        ECMD_STARTOPTIONSCTX = 1127,
        ECMD_DETACHLOCALDATAFILECTX = 1128,
        ECMD_ADDSERVICEREFERENCE = 1129,
        ECMD_ADDSERVICEREFERENCECTX = 1130,
        ECMD_UPDATESERVICEREFERENCE = 1131,
        ECMD_CONFIGURESERVICEREFERENCE = 1132,
        //
        // Shareable commands for right drag operations
        //
        ECMD_DRAG_MOVE = 1140,
        ECMD_DRAG_COPY = 1141,
        ECMD_DRAG_CANCEL = 1142,
        //
        // Shareable commands from the VC resource editor
        //
        ECMD_TESTDIALOG = 1200,
        ECMD_SPACEACROSS = 1201,
        ECMD_SPACEDOWN = 1202,
        ECMD_TOGGLEGRID = 1203,
        ECMD_TOGGLEGUIDES = 1204,
        ECMD_SIZETOTEXT = 1205,
        ECMD_CENTERVERT = 1206,
        ECMD_CENTERHORZ = 1207,
        ECMD_FLIPDIALOG = 1208,
        ECMD_SETTABORDER = 1209,
        ECMD_BUTTONRIGHT = 1210,
        ECMD_BUTTONBOTTOM = 1211,
        ECMD_AUTOLAYOUTGROW = 1212,
        ECMD_AUTOLAYOUTNORESIZE = 1213,
        ECMD_AUTOLAYOUTOPTIMIZE = 1214,
        ECMD_GUIDESETTINGS = 1215,
        ECMD_RESOURCEINCLUDES = 1216,
        ECMD_RESOURCESYMBOLS = 1217,
        ECMD_OPENBINARY = 1218,
        ECMD_RESOURCEOPEN = 1219,
        ECMD_RESOURCENEW = 1220,
        ECMD_RESOURCENEWCOPY = 1221,
        ECMD_INSERT = 1222,
        ECMD_EXPORT = 1223,
        ECMD_CTLMOVELEFT = 1224,
        ECMD_CTLMOVEDOWN = 1225,
        ECMD_CTLMOVERIGHT = 1226,
        ECMD_CTLMOVEUP = 1227,
        ECMD_CTLSIZEDOWN = 1228,
        ECMD_CTLSIZEUP = 1229,
        ECMD_CTLSIZELEFT = 1230,
        ECMD_CTLSIZERIGHT = 1231,
        ECMD_NEWACCELERATOR = 1232,
        ECMD_CAPTUREKEYSTROKE = 1233,
        ECMD_INSERTACTIVEXCTL = 1234,
        ECMD_INVERTCOLORS = 1235,
        ECMD_FLIPHORIZONTAL = 1236,
        ECMD_FLIPVERTICAL = 1237,
        ECMD_ROTATE90 = 1238,
        ECMD_SHOWCOLORSWINDOW = 1239,
        ECMD_NEWSTRING = 1240,
        ECMD_NEWINFOBLOCK = 1241,
        ECMD_DELETEINFOBLOCK = 1242,
        ECMD_ADJUSTCOLORS = 1243,
        ECMD_LOADPALETTE = 1244,
        ECMD_SAVEPALETTE = 1245,
        ECMD_CHECKMNEMONICS = 1246,
        ECMD_DRAWOPAQUE = 1247,
        ECMD_TOOLBAREDITOR = 1248,
        ECMD_GRIDSETTINGS = 1249,
        ECMD_NEWDEVICEIMAGE = 1250,
        ECMD_OPENDEVICEIMAGE = 1251,
        ECMD_DELETEDEVICEIMAGE = 1252,
        ECMD_VIEWASPOPUP = 1253,
        ECMD_CHECKMENUMNEMONICS = 1254,
        ECMD_SHOWIMAGEGRID = 1255,
        ECMD_SHOWTILEGRID = 1256,
        ECMD_MAGNIFY = 1257,
        cmdidResProps = 1258,
        ECMD_IMPORTICONIMAGE = 1259,
        ECMD_EXPORTICONIMAGE = 1260,
        ECMD_OPENEXTERNALEDITOR = 1261,
        //
        // Shareable commands from the VC resource editor (Image editor toolbar)
        //
        ECMD_PICKRECTANGLE = 1300,
        ECMD_PICKREGION = 1301,
        ECMD_PICKCOLOR = 1302,
        ECMD_ERASERTOOL = 1303,
        ECMD_FILLTOOL = 1304,
        ECMD_PENCILTOOL = 1305,
        ECMD_BRUSHTOOL = 1306,
        ECMD_AIRBRUSHTOOL = 1307,
        ECMD_LINETOOL = 1308,
        ECMD_CURVETOOL = 1309,
        ECMD_TEXTTOOL = 1310,
        ECMD_RECTTOOL = 1311,
        ECMD_OUTLINERECTTOOL = 1312,
        ECMD_FILLEDRECTTOOL = 1313,
        ECMD_ROUNDRECTTOOL = 1314,
        ECMD_OUTLINEROUNDRECTTOOL = 1315,
        ECMD_FILLEDROUNDRECTTOOL = 1316,
        ECMD_ELLIPSETOOL = 1317,
        ECMD_OUTLINEELLIPSETOOL = 1318,
        ECMD_FILLEDELLIPSETOOL = 1319,
        ECMD_SETHOTSPOT = 1320,
        ECMD_ZOOMTOOL = 1321,
        ECMD_ZOOM1X = 1322,
        ECMD_ZOOM2X = 1323,
        ECMD_ZOOM6X = 1324,
        ECMD_ZOOM8X = 1325,
        ECMD_TRANSPARENTBCKGRND = 1326,
        ECMD_OPAQUEBCKGRND = 1327,
        //---------------------------------------------------
        // The commands ECMD_ERASERSMALL thru ECMD_LINELARGER
        // must be left in the same order for the use of the
        // Resource Editor - They may however be relocated as
        // a complete block
        //---------------------------------------------------
        ECMD_ERASERSMALL = 1328,
        ECMD_ERASERMEDIUM = 1329,
        ECMD_ERASERLARGE = 1330,
        ECMD_ERASERLARGER = 1331,
        ECMD_CIRCLELARGE = 1332,
        ECMD_CIRCLEMEDIUM = 1333,
        ECMD_CIRCLESMALL = 1334,
        ECMD_SQUARELARGE = 1335,
        ECMD_SQUAREMEDIUM = 1336,
        ECMD_SQUARESMALL = 1337,
        ECMD_LEFTDIAGLARGE = 1338,
        ECMD_LEFTDIAGMEDIUM = 1339,
        ECMD_LEFTDIAGSMALL = 1340,
        ECMD_RIGHTDIAGLARGE = 1341,
        ECMD_RIGHTDIAGMEDIUM = 1342,
        ECMD_RIGHTDIAGSMALL = 1343,
        ECMD_SPLASHSMALL = 1344,
        ECMD_SPLASHMEDIUM = 1345,
        ECMD_SPLASHLARGE = 1346,
        ECMD_LINESMALLER = 1347,
        ECMD_LINESMALL = 1348,
        ECMD_LINEMEDIUM = 1349,
        ECMD_LINELARGE = 1350,
        ECMD_LINELARGER = 1351,
        ECMD_LARGERBRUSH = 1352,
        ECMD_LARGEBRUSH = 1353,
        ECMD_STDBRUSH = 1354,
        ECMD_SMALLBRUSH = 1355,
        ECMD_SMALLERBRUSH = 1356,
        ECMD_ZOOMIN = 1357,
        ECMD_ZOOMOUT = 1358,
        ECMD_PREVCOLOR = 1359,
        ECMD_PREVECOLOR = 1360,
        ECMD_NEXTCOLOR = 1361,
        ECMD_NEXTECOLOR = 1362,
        ECMD_IMG_OPTIONS = 1363,
        //
        // Sharable Commands from Visual Web Developer (website projects)
        //
        ECMD_STARTWEBADMINTOOL = 1400,
        ECMD_NESTRELATEDFILES = 1401,
        ECMD_ADDCONFIGTRANSFORMS = 1402,
        //
        // Shareable commands from WINFORMS
        //
        ECMD_CANCELDRAG = 1500,
        ECMD_DEFAULTACTION = 1501,
        ECMD_CTLMOVEUPGRID = 1502,
        ECMD_CTLMOVEDOWNGRID = 1503,
        ECMD_CTLMOVELEFTGRID = 1504,
        ECMD_CTLMOVERIGHTGRID = 1505,
        ECMD_CTLSIZERIGHTGRID = 1506,
        ECMD_CTLSIZEUPGRID = 1507,
        ECMD_CTLSIZELEFTGRID = 1508,
        ECMD_CTLSIZEDOWNGRID = 1509,
        ECMD_NEXTCTL = 1510,
        ECMD_PREVCTL = 1511,
        ECMD_RENAME = 1550,
        ECMD_EXTRACTMETHOD = 1551,
        ECMD_ENCAPSULATEFIELD = 1552,
        ECMD_EXTRACTINTERFACE = 1553,
        ECMD_REMOVEPARAMETERS = 1555,
        ECMD_REORDERPARAMETERS = 1556,
        ECMD_GENERATEMETHODSTUB = 1557,
        ECMD_IMPLEMENTINTERFACEIMPLICIT = 1558,
        ECMD_IMPLEMENTINTERFACEEXPLICIT = 1559,
        ECMD_IMPLEMENTABSTRACTCLASS = 1560,
        ECMD_SURROUNDWITH = 1561,
        //---------------------------------------------------
        // Additional shell commands added to CMDSETID_StandardCommandSet2K
        // because CLSID_StandardCommandSet97 is now considered closed.
        //---------------------------------------------------
        cmdidToggleWordWrapOW = 1600,
        cmdidGotoNextLocationOW = 1601,
        cmdidGotoPrevLocationOW = 1602,
        cmdidBuildOnlyProject = 1603,
        cmdidRebuildOnlyProject = 1604,
        cmdidCleanOnlyProject = 1605,
        cmdidSetBuildStartupsOnlyOnRun = 1606,
        cmdidUnhideAll = 1607,
        cmdidHideFolder = 1608,
        cmdidUnhideFolders = 1609,
        cmdidCopyFullPathName = 1610,
        cmdidSaveFolderAsSolution = 1611,
        cmdidManageUserSettings = 1612,
        cmdidNewSolutionFolder = 1613,
        cmdidSetTrackSelInSlnExp = 1614,
        cmdidClearPaneOW = 1615,
        cmdidGotoErrorTagOW = 1616,
        cmdidGotoNextErrorTagOW = 1617,
        cmdidGotoPrevErrorTagOW = 1618,
        cmdidClearPaneFR1 = 1619,
        cmdidGotoErrorTagFR1 = 1620,
        cmdidGotoNextErrorTagFR1 = 1621,
        cmdidGotoPrevErrorTagFR1 = 1622,
        cmdidClearPaneFR2 = 1623,
        cmdidGotoErrorTagFR2 = 1624,
        cmdidGotoNextErrorTagFR2 = 1625,
        cmdidGotoPrevErrorTagFR2 = 1626,
        // Output Window pane selection dropdown
        cmdidOutputPaneCombo = 1627,
        cmdidOutputPaneComboList = 1628,
        cmdidDisableDockingChanges = 1629,
        cmdidToggleFloat = 1630,
        cmdidResetLayout = 1631,
        cmdidEditProjectFile = 1632,
        cmdidOpenInFormView = 1633,
        cmdidOpenInCodeView = 1634,
        cmdidExploreFolderInWindows = 1635,
        cmdidEnableDPLSolution = 1636,
        cmdidDisableDPLSolution = 1637,
        cmdidNewSolutionFolderBar = 1638,
        cmdidDataShortcut = 1639,
        // Tool window navigation
        cmdidNextToolWindow = 1640,
        cmdidPrevToolWindow = 1641,
        cmdidBrowseToFileInExplorer = 1642,
        cmdidShowEzMDIFileMenu = 1643,
        cmdidNextToolWindowNav = 1644,
        cmdidPrevToolWindowNav = 1645,
        // One Time build with static analysis for ProjOnly
        cmdidStaticAnalysisOnlyProject = 1646,
        //Run Code Analysis on Build Menu
        ECMD_RUNFXCOPSEL = 1647,
        //Run Code Analysis on Context menu for the selected project
        ECMD_RUNFXCOPPROJCTX = 1648,
        // One Time build with static analysis for individual items
        cmdidStaticAnalysisSelectedItems = 1649,
        cmdidCloseAllButThis = 1650,
        cmdidSaveFilterFile = 1651,
        cmdidLoadAllProjects = 1652,
        cmdidShowUnloadedProjects = 1653,
        cmdidHideUnloadedProjects = 1654,
        cmdidLoadProjectDependencies = 1655,
        cmdidLoadAllProjectDependencies = 1656,
        cmdidLoadProjectWithDependencies = 1657,
        cmdidShowSolutionFilterWidget = 1658,
        // not real commands - used to define Class view and Object browser commands
        SYM_TOOL_COMMAND_FIRST = 1,
        cmdidSymToolShowInheritedMembers = 1,
        cmdidSymToolShowBaseTypes = 2,
        cmdidSymToolShowDerivedTypes = 3,
        cmdidSymToolShowHidden = 4,
        cmdidSymToolBack = 5,
        cmdidSymToolForward = 6,
        cmdidSymToolSearchCombo = 7,
        cmdidSymToolSearch = 8,
        cmdidSymToolSortObjectsAlpha = 9,
        cmdidSymToolSortObjectsType = 10,
        cmdidSymToolSortObjectsAccess = 11,
        cmdidSymToolGroupObjectsType = 12,
        cmdidSymToolSortMembersAlpha = 13,
        cmdidSymToolSortMembersType = 14,
        cmdidSymToolSortMembersAccess = 15,
        cmdidSymToolTypeBrowserSettings = 16,
        cmdidSymToolViewMembersAsImplementor = 17,
        cmdidSymToolViewMembersAsSubclass = 18,
        cmdidSymToolViewMembersAsUser = 19,
        cmdidSymToolNamespacesView = 20,
        cmdidSymToolContainersView = 21,
        cmdidSymToolShowProjectReferences = 22,
        cmdidSymToolGroupMembersType = 23,
        cmdidSymToolClearSearch = 24,
        cmdidSymToolFilterToType = 25,
        cmdidSymToolSortByBestMatch = 26,
        cmdidSymToolSearchMRUList = 27,
        cmdidSymToolViewOtherMembers = 28,
        cmdidSymToolSearchCmd = 29,
        cmdidSymToolGoToSearchCmd = 30,
        cmdidSymToolShowExtensionMembers = 31,
        SYM_TOOL_COMMAND_LAST = 31,
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // the numbers from 1650 to 1699 are reserved for Class view specific commands
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        CV_COMMANDS_BASE = 1650,
        cmdidCVShowInheritedMembers = 1651,
        cmdidCVShowBaseTypes = 1652,
        cmdidCVShowDerivedTypes = 1653,
        cmdidCVShowHidden = 1654,
        cmdidCVBack = 1655,
        cmdidCVForward = 1656,
        cmdidCVSearchCombo = 1657,
        cmdidCVSearch = 1658,
        cmdidCVSortObjectsAlpha = 1659,
        cmdidCVSortObjectsType = 1660,
        cmdidCVSortObjectsAccess = 1661,
        cmdidCVGroupObjectsType = 1662,
        cmdidCVSortMembersAlpha = 1663,
        cmdidCVSortMembersType = 1664,
        cmdidCVSortMembersAccess = 1665,
        cmdidCVTypeBrowserSettings = 1666,
        cmdidCVViewMembersAsImplementor = 1667,
        cmdidCVViewMembersAsSubclass = 1668,
        cmdidCVViewMembersAsUser = 1669,
        cmdidCVReserved1 = 1670,
        cmdidCVReserved2 = 1671,
        cmdidCVShowProjectReferences = 1672,
        cmdidCVGroupMembersType = 1673,
        cmdidCVClearSearch = 1674,
        cmdidCVFilterToType = 1675,
        cmdidCVSortByBestMatch = 1676,
        cmdidCVSearchMRUList = 1677,
        cmdidCVViewOtherMembers = 1678,
        cmdidCVSearchCmd = 1679,
        cmdidCVGoToSearchCmd = 1680,
        cmdidCVUnused9 = 1681,
        cmdidCVUnused10 = 1682,
        cmdidCVUnused11 = 1683,
        cmdidCVUnused12 = 1684,
        cmdidCVUnused13 = 1685,
        cmdidCVUnused14 = 1686,
        cmdidCVUnused15 = 1687,
        cmdidCVUnused16 = 1688,
        cmdidCVUnused17 = 1689,
        cmdidCVUnused18 = 1690,
        cmdidCVUnused19 = 1691,
        cmdidCVUnused20 = 1692,
        cmdidCVUnused21 = 1693,
        cmdidCVUnused22 = 1694,
        cmdidCVUnused23 = 1695,
        cmdidCVUnused24 = 1696,
        cmdidCVUnused25 = 1697,
        cmdidCVUnused26 = 1698,
        cmdidCVUnused27 = 1699,
        //-------------------end of CV commands----------------------------------------------
        cmdidControlGallery = 1700,
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // the numbers from 1710 to 1759 are reserved for Object Browser specific commands
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        OB_COMMANDS_BASE = 1710,
        cmdidOBShowInheritedMembers = 1711,
        cmdidOBShowBaseTypes = 1712,
        cmdidOBShowDerivedTypes = 1713,
        cmdidOBShowHidden = 1714,
        cmdidOBBack = 1715,
        cmdidOBForward = 1716,
        cmdidOBSearchCombo = 1717,
        cmdidOBSearch = 1718,
        cmdidOBSortObjectsAlpha = 1719,
        cmdidOBSortObjectsType = 1720,
        cmdidOBSortObjectsAccess = 1721,
        cmdidOBGroupObjectsType = 1722,
        cmdidOBSortMembersAlpha = 1723,
        cmdidOBSortMembersType = 1724,
        cmdidOBSortMembersAccess = 1725,
        cmdidOBTypeBrowserSettings = 1726,
        cmdidOBViewMembersAsImplementor = 1727,
        cmdidOBViewMembersAsSubclass = 1728,
        cmdidOBViewMembersAsUser = 1729,
        cmdidOBNamespacesView = 1730,
        cmdidOBContainersView = 1731,
        cmdidOBReserved1 = 1732,
        cmdidOBGroupMembersType = 1733,
        cmdidOBClearSearch = 1734,
        cmdidOBFilterToType = 1735,
        cmdidOBSortByBestMatch = 1736,
        cmdidOBSearchMRUList = 1737,
        cmdidOBViewOtherMembers = 1738,
        cmdidOBSearchCmd = 1739,
        cmdidOBGoToSearchCmd = 1740,
        cmdidOBShowExtensionMembers = 1741,
        cmdidOBUnused10 = 1742,
        cmdidOBUnused11 = 1743,
        cmdidOBUnused12 = 1744,
        cmdidOBUnused13 = 1745,
        cmdidOBUnused14 = 1746,
        cmdidOBUnused15 = 1747,
        cmdidOBUnused16 = 1748,
        cmdidOBUnused17 = 1749,
        cmdidOBUnused18 = 1750,
        cmdidOBUnused19 = 1751,
        cmdidOBUnused20 = 1752,
        cmdidOBUnused21 = 1753,
        cmdidOBUnused22 = 1754,
        cmdidOBUnused23 = 1755,
        cmdidOBUnused24 = 1756,
        cmdidOBUnused25 = 1757,
        cmdidOBUnused26 = 1758,
        cmdidOBUnused27 = 1759,
        //-------------------end of OB commands----------------------------------------------
        cmdidFullScreen2 = 1775,
        // find symbol results sorting command
        cmdidFSRSortObjectsAlpha = 1776,
        cmdidFSRSortByBestMatch = 1777,
        cmdidNavigateBack = 1800,
        cmdidNavigateForward = 1801,
        // Error correction commands (need to be consecutive)
        ECMD_CORRECTION_1 = 1900,
        ECMD_CORRECTION_2 = 1901,
        ECMD_CORRECTION_3 = 1902,
        ECMD_CORRECTION_4 = 1903,
        ECMD_CORRECTION_5 = 1904,
        ECMD_CORRECTION_6 = 1905,
        ECMD_CORRECTION_7 = 1906,
        ECMD_CORRECTION_8 = 1907,
        ECMD_CORRECTION_9 = 1908,
        ECMD_CORRECTION_10 = 1909,
        // Object Browser commands
        cmdidOBAddReference = 1914,
        // Edit.FindAllReferences
        cmdidFindReferences = 1915,
        // Code Definition View
        cmdidCodeDefView = 1926,
        cmdidCodeDefViewGoToPrev = 1927,
        cmdidCodeDefViewGoToNext = 1928,
        cmdidCodeDefViewEditDefinition = 1929,
        cmdidCodeDefViewChooseEncoding = 1930,
        // Class view
        //#define cmdidCVShowProjectReferences 1930
        cmdidViewInClassDiagram = 1931,
        //
        // Shareable commands from VSDesigner
        //
        ECMD_ADDDBTABLE = 1950,
        ECMD_ADDDATATABLE = 1951,
        ECMD_ADDFUNCTION = 1952,
        ECMD_ADDRELATION = 1953,
        ECMD_ADDKEY = 1954,
        ECMD_ADDCOLUMN = 1955,
        ECMD_CONVERT_DBTABLE = 1956,
        ECMD_CONVERT_DATATABLE = 1957,
        ECMD_GENERATE_DATABASE = 1958,
        ECMD_CONFIGURE_CONNECTIONS = 1959,
        ECMD_IMPORT_XMLSCHEMA = 1960,
        ECMD_SYNC_WITH_DATABASE = 1961,
        ECMD_CONFIGURE = 1962,
        ECMD_CREATE_DATAFORM = 1963,
        ECMD_CREATE_ENUM = 1964,
        ECMD_INSERT_FUNCTION = 1965,
        ECMD_EDIT_FUNCTION = 1966,
        ECMD_SET_PRIMARY_KEY = 1967,
        ECMD_INSERT_COLUMN = 1968,
        ECMD_AUTO_SIZE = 1969,
        ECMD_SHOW_RELATION_LABELS = 1970,
        cmdid_VSD_GenerateDataSet = 1971,
        cmdid_VSD_Preview = 1972,
        cmdid_VSD_ConfigureAdapter = 1973,
        cmdid_VSD_ViewDatasetSchema = 1974,
        cmdid_VSD_DatasetProperties = 1975,
        cmdid_VSD_ParameterizeForm = 1976,
        cmdid_VSD_AddChildForm = 1977,
        ECMD_EDITCONSTRAINT = 1978,
        ECMD_DELETECONSTRAINT = 1979,
        ECMD_EDITDATARELATION = 1980,
        cmdidCloseProject = 1982,
        cmdidReloadCommandBars = 1983,
        cmdidSolutionPlatform = 1990,
        cmdidSolutionPlatformGetList = 1991,
        // Initially used by DataSet Editor
        ECMD_DATAACCESSOR = 2000,
        ECMD_ADD_DATAACCESSOR = 2001,
        ECMD_QUERY = 2002,
        ECMD_ADD_QUERY = 2003,
        // Publish solution
        ECMD_PUBLISHSELECTION = 2005,
        ECMD_PUBLISHSLNCTX = 2006,
        ECMD_MSDEPLOYPUBLISHSLNCTX = 2007,
        // Call Browser
        cmdidCallBrowserShowCallsTo = 2010,
        cmdidCallBrowserShowCallsFrom = 2011,
        cmdidCallBrowserShowNewCallsTo = 2012,
        cmdidCallBrowserShowNewCallsFrom = 2013,
        cmdidCallBrowser1ShowCallsTo = 2014,
        cmdidCallBrowser2ShowCallsTo = 2015,
        cmdidCallBrowser3ShowCallsTo = 2016,
        cmdidCallBrowser4ShowCallsTo = 2017,
        cmdidCallBrowser5ShowCallsTo = 2018,
        cmdidCallBrowser6ShowCallsTo = 2019,
        cmdidCallBrowser7ShowCallsTo = 2020,
        cmdidCallBrowser8ShowCallsTo = 2021,
        cmdidCallBrowser9ShowCallsTo = 2022,
        cmdidCallBrowser10ShowCallsTo = 2023,
        cmdidCallBrowser11ShowCallsTo = 2024,
        cmdidCallBrowser12ShowCallsTo = 2025,
        cmdidCallBrowser13ShowCallsTo = 2026,
        cmdidCallBrowser14ShowCallsTo = 2027,
        cmdidCallBrowser15ShowCallsTo = 2028,
        cmdidCallBrowser16ShowCallsTo = 2029,
        cmdidCallBrowser1ShowCallsFrom = 2030,
        cmdidCallBrowser2ShowCallsFrom = 2031,
        cmdidCallBrowser3ShowCallsFrom = 2032,
        cmdidCallBrowser4ShowCallsFrom = 2033,
        cmdidCallBrowser5ShowCallsFrom = 2034,
        cmdidCallBrowser6ShowCallsFrom = 2035,
        cmdidCallBrowser7ShowCallsFrom = 2036,
        cmdidCallBrowser8ShowCallsFrom = 2037,
        cmdidCallBrowser9ShowCallsFrom = 2038,
        cmdidCallBrowser10ShowCallsFrom = 2039,
        cmdidCallBrowser11ShowCallsFrom = 2040,
        cmdidCallBrowser12ShowCallsFrom = 2041,
        cmdidCallBrowser13ShowCallsFrom = 2042,
        cmdidCallBrowser14ShowCallsFrom = 2043,
        cmdidCallBrowser15ShowCallsFrom = 2044,
        cmdidCallBrowser16ShowCallsFrom = 2045,
        cmdidCallBrowser1ShowFullNames = 2046,
        cmdidCallBrowser2ShowFullNames = 2047,
        cmdidCallBrowser3ShowFullNames = 2048,
        cmdidCallBrowser4ShowFullNames = 2049,
        cmdidCallBrowser5ShowFullNames = 2050,
        cmdidCallBrowser6ShowFullNames = 2051,
        cmdidCallBrowser7ShowFullNames = 2052,
        cmdidCallBrowser8ShowFullNames = 2053,
        cmdidCallBrowser9ShowFullNames = 2054,
        cmdidCallBrowser10ShowFullNames = 2055,
        cmdidCallBrowser11ShowFullNames = 2056,
        cmdidCallBrowser12ShowFullNames = 2057,
        cmdidCallBrowser13ShowFullNames = 2058,
        cmdidCallBrowser14ShowFullNames = 2059,
        cmdidCallBrowser15ShowFullNames = 2060,
        cmdidCallBrowser16ShowFullNames = 2061,
        cmdidCallBrowser1Settings = 2062,
        cmdidCallBrowser2Settings = 2063,
        cmdidCallBrowser3Settings = 2064,
        cmdidCallBrowser4Settings = 2065,
        cmdidCallBrowser5Settings = 2066,
        cmdidCallBrowser6Settings = 2067,
        cmdidCallBrowser7Settings = 2068,
        cmdidCallBrowser8Settings = 2069,
        cmdidCallBrowser9Settings = 2070,
        cmdidCallBrowser10Settings = 2071,
        cmdidCallBrowser11Settings = 2072,
        cmdidCallBrowser12Settings = 2073,
        cmdidCallBrowser13Settings = 2074,
        cmdidCallBrowser14Settings = 2075,
        cmdidCallBrowser15Settings = 2076,
        cmdidCallBrowser16Settings = 2077,
        cmdidCallBrowser1SortAlpha = 2078,
        cmdidCallBrowser2SortAlpha = 2079,
        cmdidCallBrowser3SortAlpha = 2080,
        cmdidCallBrowser4SortAlpha = 2081,
        cmdidCallBrowser5SortAlpha = 2082,
        cmdidCallBrowser6SortAlpha = 2083,
        cmdidCallBrowser7SortAlpha = 2084,
        cmdidCallBrowser8SortAlpha = 2085,
        cmdidCallBrowser9SortAlpha = 2086,
        cmdidCallBrowser10SortAlpha = 2087,
        cmdidCallBrowser11SortAlpha = 2088,
        cmdidCallBrowser12SortAlpha = 2089,
        cmdidCallBrowser13SortAlpha = 2090,
        cmdidCallBrowser14SortAlpha = 2091,
        cmdidCallBrowser15SortAlpha = 2092,
        cmdidCallBrowser16SortAlpha = 2093,
        cmdidCallBrowser1SortAccess = 2094,
        cmdidCallBrowser2SortAccess = 2095,
        cmdidCallBrowser3SortAccess = 2096,
        cmdidCallBrowser4SortAccess = 2097,
        cmdidCallBrowser5SortAccess = 2098,
        cmdidCallBrowser6SortAccess = 2099,
        cmdidCallBrowser7SortAccess = 2100,
        cmdidCallBrowser8SortAccess = 2101,
        cmdidCallBrowser9SortAccess = 2102,
        cmdidCallBrowser10SortAccess = 2103,
        cmdidCallBrowser11SortAccess = 2104,
        cmdidCallBrowser12SortAccess = 2105,
        cmdidCallBrowser13SortAccess = 2106,
        cmdidCallBrowser14SortAccess = 2107,
        cmdidCallBrowser15SortAccess = 2108,
        cmdidCallBrowser16SortAccess = 2109,
        cmdidCallBrowser1 = 2121,
        cmdidCallBrowser2 = 2122,
        cmdidCallBrowser3 = 2123,
        cmdidCallBrowser4 = 2124,
        cmdidCallBrowser5 = 2125,
        cmdidCallBrowser6 = 2126,
        cmdidCallBrowser7 = 2127,
        cmdidCallBrowser8 = 2128,
        cmdidCallBrowser9 = 2129,
        cmdidCallBrowser10 = 2130,
        cmdidCallBrowser11 = 2131,
        cmdidCallBrowser12 = 2132,
        cmdidCallBrowser13 = 2133,
        cmdidCallBrowser14 = 2134,
        cmdidCallBrowser15 = 2135,
        cmdidCallBrowser16 = 2136,
        cmdidCallBrowser17 = 2137,
        // Closed file undo
        cmdidGlobalUndo = 2138,
        cmdidGlobalRedo = 2139,
        // Call Browser Commands (No UI, Command window only).
        cmdidCallBrowserShowCallsToCmd = 2140,
        cmdidCallBrowserShowCallsFromCmd = 2141,
        cmdidCallBrowserShowNewCallsToCmd = 2142,
        cmdidCallBrowserShowNewCallsFromCmd = 2143,
        cmdidCallBrowser1Search = 2145,
        cmdidCallBrowser2Search = 2146,
        cmdidCallBrowser3Search = 2147,
        cmdidCallBrowser4Search = 2148,
        cmdidCallBrowser5Search = 2149,
        cmdidCallBrowser6Search = 2150,
        cmdidCallBrowser7Search = 2151,
        cmdidCallBrowser8Search = 2152,
        cmdidCallBrowser9Search = 2153,
        cmdidCallBrowser10Search = 2154,
        cmdidCallBrowser11Search = 2155,
        cmdidCallBrowser12Search = 2156,
        cmdidCallBrowser13Search = 2157,
        cmdidCallBrowser14Search = 2158,
        cmdidCallBrowser15Search = 2159,
        cmdidCallBrowser16Search = 2160,
        cmdidCallBrowser1Refresh = 2161,
        cmdidCallBrowser2Refresh = 2162,
        cmdidCallBrowser3Refresh = 2163,
        cmdidCallBrowser4Refresh = 2164,
        cmdidCallBrowser5Refresh = 2165,
        cmdidCallBrowser6Refresh = 2166,
        cmdidCallBrowser7Refresh = 2167,
        cmdidCallBrowser8Refresh = 2168,
        cmdidCallBrowser9Refresh = 2169,
        cmdidCallBrowser10Refresh = 2170,
        cmdidCallBrowser11Refresh = 2171,
        cmdidCallBrowser12Refresh = 2172,
        cmdidCallBrowser13Refresh = 2173,
        cmdidCallBrowser14Refresh = 2174,
        cmdidCallBrowser15Refresh = 2175,
        cmdidCallBrowser16Refresh = 2176,
        cmdidCallBrowser1SearchCombo = 2180,
        cmdidCallBrowser2SearchCombo = 2181,
        cmdidCallBrowser3SearchCombo = 2182,
        cmdidCallBrowser4SearchCombo = 2183,
        cmdidCallBrowser5SearchCombo = 2184,
        cmdidCallBrowser6SearchCombo = 2185,
        cmdidCallBrowser7SearchCombo = 2186,
        cmdidCallBrowser8SearchCombo = 2187,
        cmdidCallBrowser9SearchCombo = 2188,
        cmdidCallBrowser10SearchCombo = 2189,
        cmdidCallBrowser11SearchCombo = 2190,
        cmdidCallBrowser12SearchCombo = 2191,
        cmdidCallBrowser13SearchCombo = 2192,
        cmdidCallBrowser14SearchCombo = 2193,
        cmdidCallBrowser15SearchCombo = 2194,
        cmdidCallBrowser16SearchCombo = 2195,
        // Callbrowser SearchComboList commands start with 2215
        // Task List
        cmdidTaskListProviderCombo = 2200,
        cmdidTaskListProviderComboList = 2201,
        // User Task toolbar commands
        cmdidCreateUserTask = 2202,
        // Error List
        // Error List toolbar commands
        cmdidErrorListShowErrors = 2210,
        cmdidErrorListShowWarnings = 2211,
        cmdidErrorListShowMessages = 2212,
        // Product activation (registration)
        cmdidRegistration = 2214,
        // Callbrowser SearchComboList commands
        cmdidCallBrowser1SearchComboList = 2215,
        cmdidCallBrowser2SearchComboList = 2216,
        cmdidCallBrowser3SearchComboList = 2217,
        cmdidCallBrowser4SearchComboList = 2218,
        cmdidCallBrowser5SearchComboList = 2219,
        cmdidCallBrowser6SearchComboList = 2220,
        cmdidCallBrowser7SearchComboList = 2221,
        cmdidCallBrowser8SearchComboList = 2222,
        cmdidCallBrowser9SearchComboList = 2223,
        cmdidCallBrowser10SearchComboList = 2224,
        cmdidCallBrowser11SearchComboList = 2225,
        cmdidCallBrowser12SearchComboList = 2226,
        cmdidCallBrowser13SearchComboList = 2227,
        cmdidCallBrowser14SearchComboList = 2228,
        cmdidCallBrowser15SearchComboList = 2229,
        cmdidCallBrowser16SearchComboList = 2230,
        //Snippet window buttons
        cmdidSnippetProp = 2240,
        cmdidSnippetRef = 2241,
        cmdidSnippetRepl = 2242,
        //Start Page Command:
        cmdidStartPage = 2245,
        // More editor commands
        cmdidEditorLineFirstColumn = 2250,
        cmdidEditorLineFirstColumnExtend = 2251,
        // Server Explorer Menu commands
        cmdid_SE_ServerExplorer = 2260,
        cmdid_SE_DataExplorer = 2261,
        // Commands for Floating, Docking and Hiding documents
        cmdidDocumentFloat = 2270,
        // Call hierarchy
        cmdidContextMenuViewCallHierarchy = 2301,
        cmdidToggleConsumeFirstMode = 2303,
        // Highlight References commands
        cmdidNextHighlightedReference = 2400,
        cmdidPreviousHighlightedReference = 2401,
        //
        // Shareable commands from the VC resource editor (Ribbon editor toolbar)
        //
        ECMD_TESTRIBBON = 2504,
        ECMD_RIBBON_VM = 2505,
        ECMD_RIBBON_VM_GET_LIST = 2506,
        ECMD_RIBBON_ITEMS = 2507,
        ECMD_RIBBON_BUTTONS = 2508,
        // Regexp expression builder new commands
        cmdidWordChar = 2509,
        cmdidCharInRange = 2510,
        cmdidOneAndZeroOrOne = 2511,
        cmdidOneAndZeroOrMore = 2512,
        cmdidOneAndOneOrMore = 2513,
        cmdidQuantifier = 2514,
        cmdidBackreference = 2515,
        cmdidNamedBackreference = 2516,
        cmdidTaggedExp = 2517,
        cmdidNamedTaggedExp = 2518,
        cmdidDollarSubstitute = 2519,
        cmdidWholeMatch = 2520,
        cmdidLastTaggedExp = 2521,
        //"cmdidSpaceOrTabMap			2522 = ,"
        //"cmdidNumericCharacterMap	2523 = ,"
        //"cmdidCPPIdentifierMap		2524 = ,"
        //"cmdidQuotedStringMap		2525 = ,"
        //"cmdidHexadecimalNumberMap	2526 = ,"
        //"cmdidIntegersDecimalsMap	2527 = ,"
        cmdidBuildFullPDB = 2528,
        cmdidBuildFullPDBSolution = 2529,
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet10.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        //The command that returns all shell toolbars sorted lexographically by their text
        //
        // NOTE: The range between cmdidDynamicToolBarListFirst and cmdidDynamicToolBarListLast is reserved
        // for the dynamic toolbar list. Do not use command IDs in this range.
        cmdidDynamicToolBarListFirst = 1,
        cmdidDynamicToolBarListLast = 300,
        // Command for dropping window frame docking menu
        cmdidWindowFrameDockMenu = 500,
        // Commands for going to the next/previous tab in the document well
        cmdidDocumentTabNext = 600,
        cmdidDocumentTabPrevious = 601,
        //////////////////////////////////////////////////////////////////
        //
        // Command ids for navigate backward submenus. These replaces cmdidShellNavigate* commands
        //
        // There must be 33 ids between each one since these are dynamic start items and each one
        // can have up to 32 items.
        //
        //////////////////////////////////////////////////////////////////
        cmdidShellNavigate1First = 1000,
        cmdidShellNavigate2First = 1033,
        cmdidShellNavigate3First = 1066,
        cmdidShellNavigate4First = 1099,
        cmdidShellNavigate5First = 1132,
        cmdidShellNavigate6First = 1165,
        cmdidShellNavigate7First = 1198,
        cmdidShellNavigate8First = 1231,
        cmdidShellNavigate9First = 1264,
        cmdidShellNavigate10First = 1297,
        cmdidShellNavigate11First = 1330,
        cmdidShellNavigate12First = 1363,
        cmdidShellNavigate13First = 1396,
        cmdidShellNavigate14First = 1429,
        cmdidShellNavigate15First = 1462,
        cmdidShellNavigate16First = 1495,
        cmdidShellNavigate17First = 1528,
        cmdidShellNavigate18First = 1561,
        cmdidShellNavigate19First = 1594,
        cmdidShellNavigate20First = 1627,
        cmdidShellNavigate21First = 1660,
        cmdidShellNavigate22First = 1693,
        cmdidShellNavigate23First = 1726,
        cmdidShellNavigate24First = 1759,
        cmdidShellNavigate25First = 1792,
        cmdidShellNavigate26First = 1825,
        cmdidShellNavigate27First = 1858,
        cmdidShellNavigate28First = 1891,
        cmdidShellNavigate29First = 1924,
        cmdidShellNavigate30First = 1957,
        cmdidShellNavigate31First = 1990,
        cmdidShellNavigate32First = 2023,
        cmdidShellNavigateLast = 2055,
        // Command ID for ForceGC
        cmdidShellForceGC = 2090,
        //
        // Command ids for global zoom operations
        //
        cmdidViewZoomIn = 2100,
        cmdidViewZoomOut = 2101,
        // More outlining commands
        ECMD_OUTLN_EXPAND_ALL = 2500,
        ECMD_OUTLN_COLLAPSE_ALL = 2501,
        ECMD_OUTLN_EXPAND_CURRENT = 2502,
        ECMD_OUTLN_COLLAPSE_CURRENT = 2503,
        // Command ID for Extension Manager command
        cmdidExtensionManager = 3000,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet10 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet11.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        // Commands for document management
        cmdidFloatAll = 1,
        cmdidMoveAllToNext = 2,
        cmdidMoveAllToPrevious = 3,
        cmdidMultiSelect = 4,
        cmdidPaneNextTabAndMultiSelect = 5,
        cmdidPanePrevTabAndMultiSelect = 6,
        cmdidPinTab = 7,
        cmdidBringFloatingWindowsToFront = 8,
        cmdidPromoteTab = 9,
        cmdidMoveToMainTabWell = 10,
        //Commands for error/task list filtering
        cmdidToggleFilter = 11,
        cmdidFilterToCurrentProject = 12,
        cmdidFilterToCurrentDocument = 13,
        cmdidFilterToOpenDocuments = 14,
        //15-16 range reserved for cmdidHelpSelectPreference commands
        //Commands for activating the search controls
        cmdidWindowSearch = 17,
        cmdidGlobalSearch = 18,
        cmdidGlobalSearchBack = 19,
        cmdidSolutionExplorerSearch = 20,
        cmdidStartupProjectProperties = 21,
        cmdidCloseAllButPinned = 22,
        cmdidResolveFaultedProjects = 23,
        //Commands for Interactive scripting (F#/Roslyn)
        cmdidExecuteSelectionInInteractive = 24,
        cmdidExecuteLineInInteractive = 25,
        cmdidInteractiveSessionInterrupt = 26,
        cmdidInteractiveSessionRestart = 27,
        //unused 28
        cmdidSolutionExplorerCollapseAll = 29,
        cmdidSolutionExplorerBack = 30,
        cmdidSolutionExplorerHome = 31,
        // unused 32
        cmdidSolutionExplorerForward = 33,
        cmdidSolutionExplorerNewScopedWindow = 34,
        cmdidSolutionExplorerToggleSingleClickPreview = 35,
        cmdidSolutionExplorerSyncWithActiveDocument = 36,
        cmdidNewProjectFromTemplate = 37,
        cmdidSolutionExplorerScopeToThis = 38,
        cmdidSolutionExplorerFilterOpened = 39,
        cmdidSolutionExplorerFilterPendingChanges = 40,
        cmdidPasteAsLink = 41,
        // Used by the find manager to locate find targets
        cmdidLocateFindTarget = 42,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet11 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet12.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        cmdidShowUserNotificationsToolWindow = 1,
        cmdidOpenProjectFromScc = 2,
        cmdidShareProject = 3,
        cmdidPeekDefinition = 4,
        cmdidAccountSettings = 5,
        cmdidPeekNavigateForward = 6,
        cmdidPeekNavigateBackward = 7,
        cmdidRetargetProject = 8,
        cmdidRetargetProjectInstallComponent = 9,
        cmdidAddReferenceProjectOnly = 10,
        cmdidAddWebReferenceProjectOnly = 11,
        cmdidAddServiceReferenceProjectOnly = 12,
        cmdidAddReferenceNonProjectOnly = 13,
        cmdidAddWebReferenceNonProjectOnly = 14,
        cmdidAddServiceReferenceNonProjectOnly = 15,
        // Do not change the NavigateTo values (they were set to match when switching from a private to public release to prevent breaks)
        //"cmdidNavigateTo	 = 256,"
        cmdidMoveSelLinesUp = 258,
        cmdidMoveSelLinesDown = 259,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet12 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet14.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        cmdidShowQuickFixes = 1,
        cmdidShowRefactorings = 2,
        cmdidSmartBreakLine = 3,
        cmdidManageLayouts = 4,
        cmdidSaveLayout = 5,
        cmdidShowQuickFixesForPosition = 6,
        cmdidShowQuickFixesForPosition2 = 7,
        // Delete toolbar button commands for Find Results (FR) 1 & 2 tool windows
        cmdidDeleteFR1 = 10,
        cmdidDeleteFR2 = 20,
        cmdidErrorContextComboList = 30,
        cmdidErrorContextComboGetList = 31,
        cmdidErrorBuildContextComboList = 40,
        cmdidErrorBuildContextComboGetList = 41,
        cmdidErrorListClearFilters = 50,
        // The values 0x1000 to 0x1FFF are reserved for the Apply Window Layout's list
        // The first 9 commands are explicitly defined so they can be assigned key bindings
        cmdidWindowLayoutList0 = 0x1000,
        cmdidWindowLayoutList1 = 0x1001,
        cmdidWindowLayoutList2 = 0x1002,
        cmdidWindowLayoutList3 = 0x1003,
        cmdidWindowLayoutList4 = 0x1004,
        cmdidWindowLayoutList5 = 0x1005,
        cmdidWindowLayoutList6 = 0x1006,
        cmdidWindowLayoutList7 = 0x1007,
        cmdidWindowLayoutList8 = 0x1008,
        cmdidWindowLayoutList9 = 0x1009,
        cmdidWindowLayoutListFirst = cmdidWindowLayoutList0,
        cmdidWindowLayoutListDynamicFirst = 0x1010,
        cmdidWindowLayoutListLast = 0x1FFF,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet14 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet15.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        cmdidNavigateToFile = 1,
        cmdidNavigateToType = 2,
        cmdidNavigateToSymbol = 3,
        cmdidNavigateToMember = 4,
        cmdidNavigateToRecentFile = 5,
        // Please start after 25 or after to reserve a few for filtered NavigateTo commands.
        // Find All References preset groupings
        cmdidFindAllRefPresetGroupingComboList = 0x2A,
        cmdidFindAllRefPresetGroupingComboGetList = 0x2B,
        cmdidFindAllRefLockWindow = 0x2C,
        cmdidFindAllRefFlatList = 0x2D,
        cmdidRepeatFindAction = 0x2E,
        cmdidGetToolsAndFeatures = 0x3C,
        cmdidShowLineAnnotations = 0x4C,
        cmdidMoveToNextAnnotation = 0x4D,
        cmdidMoveToPreviousAnnotation = 0x4E,
        cmdidShowStructure = 0x4F,
        cmdidHelpAccessibility = 0x70,
        cmdidToggleAutoHideChannels = 0x100,
        cmdidEnableRestoreDocumentsOnSlnLoad = 0x200,
        cmdidDisableRestoreDocumentsOnSlnLoad = 0x201,
        cmdidCloseAllButToolWindows = 0x210,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet15 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet16.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        cmdidNewProject2 = 0x0001,
        cmdidDocumentTabsLeft = 0x0002,
        cmdidDocumentTabsTop = 0x0003,
        cmdidDocumentTabsRight = 0x0004,
        cmdidDocumentTabSettings = 0x0005,
        cmdidDocumentTabsGroupByProject = 0x0006,
        cmdidDocumentTabsGroupNone = 0x0007,
        cmdidDocumentTabsSortAlpha = 0x0008,
        cmdidDocumentTabsSortMroFirst = 0x0009,
        cmdidDocumentTabsSortMroLast = 0x000a,
        cmdidCopyRelativePath = 0x0080,
        cmdidEnableRestoreProjectHierarchyOnSlnLoad = 0x0100,
        cmdidDisableRestoreProjectHierarchyOnSlnLoad = 0x0101,
        cmdidEnableMinimalToolWindowLayout = 0x0102,
        cmdidDisableMinimalToolWindowLayout = 0x0103,
        // Dependencies tree commands
        cmdidAddAssemblyReference = 0x0200,
        cmdidAddComReference = 0x0201,
        cmdidAddProjectReference = 0x0202,
        cmdidAddSharedProjectReference = 0x0203,
        cmdidAddSdkReference = 0x0204,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet16 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form CMDSETID_StandardCommandSet17.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        cmdidSelectNoTabColor = 0x0002,
        cmdidSelectTabColor1 = 0x0003,
        cmdidSelectTabColor2 = 0x0004,
        cmdidSelectTabColor3 = 0x0005,
        cmdidSelectTabColor4 = 0x0006,
        cmdidSelectTabColor5 = 0x0007,
        cmdidSelectTabColor6 = 0x0008,
        cmdidSelectTabColor7 = 0x0009,
        cmdidSelectTabColor8 = 0x000A,
        cmdidSelectTabColor9 = 0x000B,
        cmdidSelectTabColor10 = 0x000C,
        cmdidSelectTabColor11 = 0x000D,
        cmdidSelectTabColor12 = 0x000E,
        cmdidSelectTabColor13 = 0x000F,
        cmdidSelectTabColor14 = 0x0010,
        cmdidSelectTabColor15 = 0x0011,
        cmdidSelectTabColor16 = 0x0012,
        //////////////////////////////////////////////////////////////////
        //
        // End CMDSETID_StandardCommandSet17 commands.
        //
        //////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form guidDataCmdId.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        icmdDesign = 0x3000,
        icmdDesignOn = 0x3001,
        icmdSEDesign = 0x3003,
        icmdNewDiagram = 0x3004,
        icmdNewTable = 0x3006,
        icmdNewDBItem = 0x300E,
        icmdNewTrigger = 0x3010,
        icmdDebug = 0x3012,
        icmdNewProcedure = 0x3013,
        icmdNewQuery = 0x3014,
        icmdRefreshLocal = 0x3015,
        icmdDbAddDataConnection = 0x3017,
        icmdDBDefDBRef = 0x3018,
        icmdRunCmd = 0x3019,
        icmdRunOn = 0x301A,
        icmdidNewDBRef = 0x301B,
        icmdidSetAsDef = 0x301C,
        icmdidCreateCmdFile = 0x301D,
        icmdCancel = 0x301E,
        icmdNewDatabase = 0x3020,
        icmdNewUser = 0x3021,
        icmdNewRole = 0x3022,
        icmdChangeLogin = 0x3023,
        icmdNewView = 0x3024,
        icmdModifyConnection = 0x3025,
        icmdDisconnect = 0x3026,
        icmdCopyScript = 0x3027,
        icmdAddSCC = 0x3028,
        icmdRemoveSCC = 0x3029,
        icmdGetLatest = 0x3030,
        icmdCheckOut = 0x3031,
        icmdCheckIn = 0x3032,
        icmdUndoCheckOut = 0x3033,
        icmdAddItemSCC = 0x3034,
        icmdNewPackageSpec = 0x3035,
        icmdNewPackageBody = 0x3036,
        icmdInsertSQL = 0x3037,
        icmdRunSelection = 0x3038,
        icmdUpdateScript = 0x3039,
        icmdCreateScript = 0x303A,
        icmdSECreateScript = 0x303B,
        icmdNewScript = 0x303C,
        icmdNewFunction = 0x303D,
        icmdNewTableFunction = 0x303E,
        icmdNewInlineFunction = 0x303F,
        icmdAddDiagram = 0x3040,
        icmdAddTable = 0x3041,
        icmdAddSynonym = 0x3042,
        icmdAddView = 0x3043,
        icmdAddProcedure = 0x3044,
        icmdAddFunction = 0x3045,
        icmdAddTableFunction = 0x3046,
        icmdAddInlineFunction = 0x3047,
        icmdAddPkgSpec = 0x3048,
        icmdAddPkgBody = 0x3049,
        icmdAddTrigger = 0x304A,
        icmdExportData = 0x304B,
        icmdDbnsVcsAdd = 0x304C,
        icmdDbnsVcsRemove = 0x304D,
        icmdDbnsVcsCheckout = 0x304E,
        icmdDbnsVcsUndoCheckout = 0x304F,
        icmdDbnsVcsCheckin = 0x3050,
        icmdSERetrieveData = 0x3060,
        icmdSEEditTextObject = 0x3061,
        icmdSERun = 0x3062,
        icmdSERunSelection = 0x3063,
        icmdDesignSQLBlock = 0x3064,
        icmdRegisterSQLInstance = 0x3065,
        icmdUnregisterSQLInstance = 0x3066,
        /////////////////////////////////////////////////////////
        //
        // Command Windows submenu commands 0x31xx
        //
        //
        // It would be nice to make the 3 commands below
        // group with the new related commands in VS 2005
        // but there are hard coded references to the original
        // values above.
        // Modifying the values above to those below
        // would require changes to those references
        // (in src\vsdesigner\..., and elsewhere)
        // #define cmdidCommandWindow 0x3100
        // #define cmdidCommandWindowMarkMode 0x3101
        // #define cmdidLogCommandWindow 0x3102
        cmdidCommandWindowSaveScript = 0x3106,
        cmdidCommandWindowRunScript = 0x3107,
        cmdidCommandWindowCursorUp = 0x3108,
        cmdidCommandWindowCursorDown = 0x3109,
        cmdidCommandWindowCursorLeft = 0x310A,
        cmdidCommandWindowCursorRight = 0x310B,
        cmdidCommandWindowHistoryUp = 0x310C,
        cmdidCommandWindowHistoryDown = 0x310D,
        // Command ids reserved for data driven implementation of data explorer.
        // used under guidDataCmdId
        // from datamenu.h
        icmdidCmdDTStart = 0x3500,
        icmdidCmdHeirarchyView0 = 0x3610,
        icmdidCmdHeirarchyView1 = 0x3611,
        icmdidCmdHeirarchyView2 = 0x3612,
        icmdidCmdHeirarchyView3 = 0x3613,
        icmdidCmdHeirarchyView4 = 0x3614,
        icmdidCmdHeirarchyView5 = 0x3615,
        icmdidCmdHeirarchyView6 = 0x3616,
        icmdidCmdHeirarchyView7 = 0x3617,
        icmdidCmdHeirarchyView8 = 0x3618,
        icmdidCmdModify = 0x3620,
        icmdidCmdClose = 0x3621,
        icmdidCmdDTLast = 0x36FF,
        // end of Command Windows submenu commands
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form guidDavDataCmdId.
        // NOTE that all these commands are shareable and may be used
        // in any appropriate menu.
        //
        //////////////////////////////////////////////////////////////////
        cmdidAddRelatedTables = 0x0001,
        cmdidLayoutDiagram = 0x0002,
        cmdidLayoutSelection = 0x0003,
        cmdidInsertColumn = 0x0004,
        cmdidDeleteColumn = 0x0005,
        cmdidNewTextAnnotation = 0x0006,
        cmdidShowRelLabels = 0x0007,
        cmdidViewPageBreaks = 0x0008,
        cmdidRecalcPageBreaks = 0x0009,
        cmdidViewUserDefined = 0x000a,
        cmdidGenerateQuery = 0x000b,
        cmdidDeleteFromDB = 0x000c,
        cmdidAutoSize = 0x000d,
        cmdidEditViewUserDefined = 0x000e,
        cmdidSetAnnotationFont = 0x000f,
        cmdidZoomPercent200 = 0x0010,
        cmdidZoomPercent150 = 0x0011,
        cmdidZoomPercent100 = 0x0012,
        cmdidZoomPercent75 = 0x0013,
        cmdidZoomPercent50 = 0x0014,
        cmdidZoomPercent25 = 0x0015,
        cmdidZoomPercent10 = 0x0016,
        cmdidZoomPercentSelection = 0x0017,
        cmdidZoomPercentFit = 0x0018,
        cmdidInsertQBERow = 0x0019,
        cmdidInsertCriteria = 0x0020,
        cmdidAddTableView = 0x0021,
        cmdidManageTriggers = 0x0022,
        cmdidManagePermissions = 0x0023,
        cmdidViewDependencies = 0x0024,
        cmdidGenerateSQLScript = 0x0025,
        cmdidVerifySQLSilent = 0x0026,
        cmdidAddTableViewForQRY = 0x0027,
        cmdidManageIndexesForQRY = 0x0028,
        cmdidViewFieldListQry = 0x0029,
        cmdidViewCollapsedQry = 0x002a,
        cmdidCopyDiagram = 0x002b,
        cmdidRemoveFromDiagram = 0x0033,
        // defined in davmenu.h
        // cmdidQryAddCTEBasic 0x002c
        // cmdidQryAddCTERecursive 0x002d
        // cmdidQryAddCTEMerged 0x002e
        // cmdidQryAddDerivedTable 0x002f
        // cmdidQryNavigate 0x0030
        // cmdidQryClear 0x0031
        // cmdidQryMerge 0x0032
        // Emacs editor emulator commands. They are in their
        // own group, guidEmacsCommandGroup, so they won't clash
        cmdidEmacsCharLeft = 1,
        cmdidEmacsCharRight = 2,
        cmdidEmacsLineUp = 3,
        cmdidEmacsLineDown = 4,
        cmdidEmacsLineEnd = 5,
        cmdidEmacsHome = 6,
        cmdidEmacsEnd = 7,
        cmdidEmacsDocumentStart = 8,
        cmdidEmacsWordLeft = 9,
        cmdidEmacsWordRight = 10,
        cmdidEmacsGoto = 11,
        cmdidEmacsWindowScrollUp = 12,
        cmdidEmacsWindowScrollDown = 13,
        cmdidEmacsWindowScrollToCenter = 14,
        cmdidEmacsWindowStart = 15,
        cmdidEmacsWindowEnd = 16,
        cmdidEmacsWindowLineToTop = 17,
        cmdidEmacsWindowSplitVertical = 18,
        cmdidEmacsWindowOther = 19,
        cmdidEmacsWindowCloseOther = 20,
        cmdidEmacsReturn = 21,
        cmdidEmacsReturnAndIndent = 22,
        cmdidEmacsLineOpen = 23,
        cmdidEmacsCharTranspose = 24,
        cmdidEmacsWordTranspose = 25,
        //#define cmdidEmacsBackspaceUntabify 26
        //#define cmdidEmacsBackspace 27
        //#define cmdidEmacsDelete 28
        cmdidEmacsWordUpperCase = 29,
        cmdidEmacsWordLowerCase = 30,
        cmdidEmacsWordCapitalize = 31,
        cmdidEmacsWordDeleteToEnd = 32,
        cmdidEmacsWordDeleteToStart = 33,
        cmdidEmacsLineCut = 34,
        //#define cmdidEmacsCutSelection 35
        //#define cmdidEmacsPaste 36
        cmdidEmacsPasteRotate = 37,
        //#define cmdidEmacsCopySelection 38
        cmdidEmacsSetMark = 39,
        cmdidEmacsPopMark = 40,
        cmdidEmacsSwapPointAndMark = 41,
        cmdidEmacsDeleteSelection = 42,
        cmdidEmacsFileOpen = 43,
        cmdidEmacsFileSave = 44,
        cmdidEmacsFileSaveAs = 45,
        cmdidEmacsFileSaveSome = 46,
        cmdidEmacsSearchIncremental = 47,
        cmdidEmacsSearchIncrementalBack = 48,
        cmdidEmacsFindReplace = 49,
        //#define cmdidEmacsUndo 50
        cmdidEmacsQuit = 51,
        cmdidEmacsUniversalArgument = 52,
        cmdidEmacsExtendedCommand = 53,
        cmdidEmacsStartKbdMacro = 54,
        cmdidEmacsEndKbdMacro = 55,
        cmdidEmacsExecuteKbdMacro = 56,
        //#define cmdidEmacsIndentLine 57
        cmdidEmacsQuotedInsert = 58,
        cmdidEmacsActivateRegion = 59,
        // Brief editor emulator commands. They are in their
        // own group, guidBriefCommandGroup, so they won't clash
        //#define cmdidBriefCharLeft 1
        //#define cmdidBriefCharRight 2
        //#define cmdidBriefLineUp 3
        //#define cmdidBriefLineDown 4
        cmdidBriefSelectColumn = 5,
        cmdidBriefLineIndent = 7,
        cmdidBriefBookmarks = 8,
        cmdidBriefSelectLine = 9,
        //#define cmdidBriefSelectionLowercase 10
        cmdidBriefSelectChar = 11,
        cmdidBriefSelectCharInclusive = 12,
        cmdidBriefLineUnindent = 13,
        cmdidBriefFilePrint = 14,
        cmdidBriefSelectSwapAnchor = 15,
        //#define cmdidBriefSelectionUppercase 16
        //#define cmdidBriefFileClose 17
        //#define cmdidBriefFileOpen
        //#define cmdidBriefWindowNext 18
        //#define cmdidBriefWindowPrevious 19
        cmdidBriefInsertFile = 20,
        //#define cmdidBriefHome 21
        //#define cmdidBriefDocumentEnd 22
        //#define cmdidBriefEnd 23
        //#define cmdidBriefWindowEnd 24
        cmdidBriefGoTo = 25,
        cmdidBriefWindowLeftEdge = 26,
        cmdidBriefWordRight = 27,
        //#define cmdidBriefPageDown 28
        //#define cmdidBriefPageUp 29
        cmdidBriefWordLeft = 30,
        cmdidBriefWindowRightEdge = 31,
        cmdidBriefWindowScrollUp = 32,
        cmdidBriefWindowScrollDown = 33,
        cmdidBriefWindowStart = 34,
        cmdidBriefLineDelete = 35,
        cmdidBriefWordDeleteToEnd = 36,
        cmdidBriefWordDeleteToStart = 37,
        cmdidBriefLineDeleteToStart = 38,
        cmdidBriefLineDeleteToEnd = 39,
        //#define cmdidBriefToggleOvertype 40
        cmdidBriefLineOpenBelow = 41,
        cmdidBriefInsertQuoted = 42,
        cmdidBriefFileExit = 43,
        cmdidBriefFileSave = 44,
        cmdidBriefFileSaveAllExit = 45,
        //#define cmdidBriefCopy 46
        //#define cmdidBriefCut 47
        //#define cmdidBriefPaste 48
        cmdidBriefFindToggleCaseSensitivity = 49,
        cmdidBriefSearchIncremental = 50,
        cmdidBriefFindToggleRegExpr = 51,
        cmdidBriefFindRepeat = 52,
        cmdidBriefFindPrev = 53,
        cmdidBriefFind = 54,
        cmdidBriefFindReplace = 55,
        cmdidBriefBrowse = 56,
        cmdidBriefGoToNextErrorTag = 57,
        cmdidBriefSetRepeatCount = 58,
        //#define cmdidBriefUndo 59
        //#define cmdidBriefRedo 60
        cmdidBriefWindowScrollToCenter = 61,
        cmdidBriefWindowSwitchPane = 62,
        cmdidBriefWindowSplit = 63,
        //#define cmdidBriefWindowDelete 64
        cmdidBriefWindowScrollToBottom = 65,
        cmdidBriefWindowScrollToTop = 66,
        cmdidBriefWindowMaximize = 67,
        cmdidBriefBackspace = 68,
        //#define cmdidBriefDelete 69
        cmdidBriefReturn = 70,
        cmdidBriefEscape = 71,
        cmdidBriefBookmarkDrop0 = 72,
        cmdidBriefBookmarkDrop1 = 73,
        cmdidBriefBookmarkDrop2 = 74,
        cmdidBriefBookmarkDrop3 = 75,
        cmdidBriefBookmarkDrop4 = 76,
        cmdidBriefBookmarkDrop5 = 77,
        cmdidBriefBookmarkDrop6 = 78,
        cmdidBriefBookmarkDrop7 = 79,
        cmdidBriefBookmarkDrop8 = 80,
        cmdidBriefBookmarkDrop9 = 81,
        //////////////////////////////////////////////////////////////////
        //
        // The following commands form Yukon projects.
        //
        //////////////////////////////////////////////////////////////////
        cmdidAddNewUDF = 0x0101,
        cmdidAddNewSProc = 0x0102,
        cmdidAddNewAggregarte = 0x0103,
        cmdidAddNewTrigger = 0x0104,
        cmdidAddNewUDT = 0x0105,
        cmdidSetDefaultDebugScript = 0x0106,
        cmdidStartDebugScript = 0x0107,
        cmdidAddNewDebugScript = 0x0108,
        cmdidPromptDatabaseConnection = 0x0201,
        //---------------------------------------------------
        //
        // Shareable commands for VS Enterprise team
        //
        cmdidAddToFavorites = 0x0001,
        cmdidAddNewFolder = 0x0002,
        cmdidStopTeamExplorerRefresh = 0x0003,
        cmdidAddDataboundMpp = 0x0004,
        cmdidAddDataboundXls = 0x0005,
        // End of shareable commands for VS Enterprise team
        //////////////////////////////////////////////////////////////////
        //
        // This command range is private to the EzMDI command set
        //
        //////////////////////////////////////////////////////////////////
        cmdidEzMDIFile1 = 0x0001,
        //////////////////////////////////////////////////////////////////
        //
        // Command ids for Server Explorer commands (guid_SE_CommandID group)
        //
        //////////////////////////////////////////////////////////////////
        cmdid_SE_ToolbarRefresh = 0x03004,
        cmdid_SE_ToolbarStopRefresh = 0x03005,
        cmdid_SE_AddToForm = 0x03009,
        cmdid_SE_AddConnection = 0x03100,
        cmdid_SE_AddServer = 0x03101,
        //////////////////////////////////////////////////////////////////
        //
        // Command ids for task list / error list commands (CLSID_VsTaskListPackage group)
        //
        //////////////////////////////////////////////////////////////////
        // These were used in Everett, but are no longer applicable in Whidbey. I don't want to re-use
        // them because it could cause unexpected behavior for third-party code which sends these
        // so I'll just comment them out.
        //#define cmdidTaskListFilterByCategoryUser 359
        //#define cmdidTaskListFilterByCategoryShortcut 360
        //#define cmdidTaskListFilterByCategoryHTML 361
        //#define cmdidTaskListFilterByCurrentFile 362
        //#define cmdidTaskListFilterByChecked 363
        //#define cmdidTaskListFilterByUnchecked 364
        //#define cmdidTaskListSortByDescription 365
        //#define cmdidTaskListSortByChecked 366
        //#define cmdidTaskListCustomView1 678
        //#define cmdidTaskListCustomView2 679
        //#define cmdidTaskListCustomView3 680
        //#define cmdidTaskListCustomView4 681
        //#define cmdidTaskListCustomView5 682
        //#define cmdidTaskListCustomView6 683
        //#define cmdidTaskListCustomView7 684
        //#define cmdidTaskListCustomView8 685
        //#define cmdidTaskListCustomView9 686
        //#define cmdidTaskListCustomView10 687
        //#define cmdidTaskListCustomView11 688
        //#define cmdidTaskListCustomView12 689
        //#define cmdidTaskListCustomView13 690
        //#define cmdidTaskListCustomView14 691
        //#define cmdidTaskListCustomView15 692
        //#define cmdidTaskListCustomView16 693
        //#define cmdidTaskListCustomView17 694
        //#define cmdidTaskListCustomView18 695
        //#define cmdidTaskListCustomView19 696
        //#define cmdidTaskListCustomView20 697
        //#define cmdidTaskListCustomView21 698
        //#define cmdidTaskListCustomView22 699
        //#define cmdidTaskListCustomView23 700
        //#define cmdidTaskListCustomView24 701
        //#define cmdidTaskListCustomView25 702
        //#define cmdidTaskListCustomView26 703
        //#define cmdidTaskListCustomView27 704
        //#define cmdidTaskListCustomView28 705
        //#define cmdidTaskListCustomView29 706
        //#define cmdidTaskListCustomView30 707
        //#define cmdidTaskListCustomView31 708
        //#define cmdidTaskListCustomView32 709
        //#define cmdidTaskListCustomView33 710
        //#define cmdidTaskListCustomView34 711
        //#define cmdidTaskListCustomView35 712
        //#define cmdidTaskListCustomView36 713
        //#define cmdidTaskListCustomView37 714
        //#define cmdidTaskListCustomView38 715
        //#define cmdidTaskListCustomView39 716
        //#define cmdidTaskListCustomView40 717
        //#define cmdidTaskListCustomView41 718
        //#define cmdidTaskListCustomView42 719
        //#define cmdidTaskListCustomView43 720
        //#define cmdidTaskListCustomView44 721
        //#define cmdidTaskListCustomView45 722
        //#define cmdidTaskListCustomView46 723
        //#define cmdidTaskListCustomView47 724
        //#define cmdidTaskListCustomView48 725
        //#define cmdidTaskListCustomView49 726
        //#define cmdidTaskListCustomView50 727 //not used on purpose, ends the list
        // Pre-Whidbey commands
        cmdidTaskListNextError = 357,
        cmdidTaskListPrevError = 358,
        cmdidTaskListTaskHelp = 598,
        // Whidbey commands
        cmdidErrorListNextError = 1,
        cmdidErrorListPrevError = 2,
        cmdidTaskListColumnToggle1 = 3,
        cmdidTaskListColumnToggle2 = 4,
        cmdidTaskListColumnToggle3 = 5,
        cmdidTaskListColumnToggle4 = 6,
        cmdidTaskListColumnToggle5 = 7,
        cmdidTaskListColumnToggle6 = 8,
        cmdidTaskListColumnToggle7 = 9,
        cmdidTaskListColumnToggle8 = 10,
        cmdidTaskListColumnToggle9 = 11,
        cmdidTaskListColumnToggle10 = 12,
        cmdidTaskListColumnToggle11 = 13,
        cmdidTaskListColumnToggle12 = 14,
        cmdidTaskListColumnToggle13 = 15,
        cmdidTaskListColumnToggle14 = 16,
        cmdidTaskListColumnToggle15 = 17,
        cmdidTaskListColumnToggle16 = 18,
        cmdidTaskListColumnToggle17 = 19,
        cmdidTaskListColumnToggle18 = 20,
        cmdidTaskListColumnToggle19 = 21,
        cmdidTaskListColumnToggle20 = 22,
        cmdidTaskListColumnToggle21 = 23,
        cmdidTaskListColumnToggle22 = 24,
        cmdidTaskListColumnToggle23 = 25,
        cmdidTaskListColumnToggle24 = 26,
        cmdidTaskListColumnToggle25 = 27,
        // Leave some space for the future, just in case...since the handling of the
        // cmdidTaskListColumnToggle* commands requires them to be in a contiguous range.
        cmdidTaskListColumnSort1 = 200,
        cmdidTaskListColumnSort2 = 201,
        cmdidTaskListColumnSort3 = 202,
        cmdidTaskListColumnSort4 = 203,
        cmdidTaskListColumnSort5 = 204,
        cmdidTaskListColumnSort6 = 205,
        cmdidTaskListColumnSort7 = 206,
        cmdidTaskListColumnSort8 = 207,
        cmdidTaskListColumnSort9 = 208,
        cmdidTaskListColumnSort10 = 209,
        cmdidTaskListColumnSort11 = 210,
        cmdidTaskListColumnSort12 = 211,
        cmdidTaskListColumnSort13 = 212,
        cmdidTaskListColumnSort14 = 213,
        cmdidTaskListColumnSort15 = 214,
        cmdidTaskListColumnSort16 = 215,
        cmdidTaskListColumnSort17 = 216,
        cmdidTaskListColumnSort18 = 217,
        cmdidTaskListColumnSort19 = 218,
        cmdidTaskListColumnSort20 = 219,
        cmdidTaskListColumnSort21 = 220,
        cmdidTaskListColumnSort22 = 221,
        cmdidTaskListColumnSort23 = 222,
        cmdidTaskListColumnSort24 = 223,
        cmdidTaskListColumnSort25 = 224,
        cmdidTaskListColumnGroup1 = 600,
        cmdidTaskListColumnGroup2 = 601,
        cmdidTaskListColumnGroup3 = 602,
        cmdidTaskListColumnGroup4 = 603,
        cmdidTaskListColumnGroup5 = 604,
        cmdidTaskListColumnGroup6 = 605,
        cmdidTaskListColumnGroup7 = 606,
        cmdidTaskListColumnGroup8 = 607,
        cmdidTaskListColumnGroup9 = 608,
        cmdidTaskListColumnGroup10 = 609,
        cmdidTaskListColumnGroup11 = 610,
        cmdidTaskListColumnGroup12 = 611,
        cmdidTaskListColumnGroup13 = 612,
        cmdidTaskListColumnGroup14 = 613,
        cmdidTaskListColumnGroup15 = 614,
        cmdidTaskListColumnGroup16 = 615,
        cmdidTaskListColumnGroup17 = 616,
        cmdidTaskListColumnGroup18 = 617,
        cmdidTaskListColumnGroup19 = 618,
        cmdidTaskListColumnGroup20 = 619,
        cmdidTaskListColumnGroup21 = 620,
        cmdidTaskListColumnGroup22 = 621,
        cmdidTaskListColumnGroup23 = 622,
        cmdidTaskListColumnGroup24 = 623,
        cmdidTaskListColumnGroup25 = 624,
        cmdidTaskListLockColumnWidths = 700,
        //////////////////////////////////////////////////////////////////
        //
        // Command ids for the ReferenceManager commands
        //
        //////////////////////////////////////////////////////////////////
        cmdidReferenceManagerRecentContextMenu = 0x1020,
        cmdidReferenceManagerRecentContextMenuGroup = 0x1021,
        cmdidClearRecentReferences = 0x100,
        cmdidRemoveFromRecentReferences = 0x200,
        cmdidOpenMultiWorkspace = 0x9999,
        //////////////////////////////////////////////////////////////////
        //
        // DwordIds for Expected Top Level Menus
        //
        //////////////////////////////////////////////////////////////////
        menuidAnalyzeTopLevelMenu = 0x1,
        menuidTestTopLevelMenu = 0x1,
        menuidQueryDesignerTopLevelMenu = 0x2,
        menuidXamarinTopLevelMenu = 0x1F,
        menuidDslToolsTopLevelMenu = 0x100,
        menuidXmlTopLevelMenu = 0x101,
        menuidResourcesTopLevelMenu = 0x105,
        menuidImageTopLevelMenu = 0x1F6,
        menuidTextTransformationTopLevelMenu = 0x302,
        menuidClassDiagramTopLevelMenu = 0x305,
        menuidDebugTopLevelMenu = 0x401,
        menuidWorkflowTopLevelMenu = 0x50A,
        menuidLayoutTopLevelMenu = 0x575,
        menuidTeamTopLevelMenu = 0x700,
        menuidGitTopLevelMenu = 0xF000,
        menuidLoadTestTopLevelMenu = 0x1003,
        menuidTableTopLevelMenu = 0x1039,
        menuidSqlTableDesignerTopLevelMenu = 0x1101,
        menuidTableDesignerTopLevelMenu = 0x1117,
        menuidXsdDesignerTopLevelMenu = 0x1160,
        menuidGraphViewTopLevelMenu = 0x1170,
        menuidPythonTopLevelMenu = 0x2000,
        menuidWorkflowDesignerTopLevelMenu = 0x2000,
        menuidDesignTopLevelMenu = 0x2001,
        menuidRToolsTopLevelMenu = 0x2100,
        menuidCMakeTopLevelMenu = 0x4020,
        menuidSqlTopLevelMenu = 0xC201,
        menuidArchitectureTopLevelMenu = 0x1000
    }
}
