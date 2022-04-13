## ElimarSoft.com.VSIX-Template
#### Insert your commandds in any of Visual Studio Menus


* This is my actual Template to develop VSIX extensions
+ An Excel file with plain old VBA macros is used to generate the VSCommandTable.vsct file
+ All ID references are updated by the program, just modify the excel file and then execute the VBA macro

|ScreenShots|
|-
|Solution Context Menu|Main Menu
|![image](https://user-images.githubusercontent.com/18607754/163107690-2a20f0b8-b6ce-493d-8a7a-ec37034c43d2.png)
|Main Menu
|![image](https://user-images.githubusercontent.com/18607754/163108522-ff20eafc-a2b3-40c7-9353-d44fc28035e5.png)|
|Editor Context Menu
|![image](https://user-images.githubusercontent.com/18607754/163110639-7d578206-3c4c-4b2c-8b83-531f65e6c24b.png)
|Excel File
|![image](https://user-images.githubusercontent.com/18607754/163099322-de1b04a5-a4cb-49c3-85a3-3c723d34b7fa.png "Excel Table")
|My extensions
|![image](https://user-images.githubusercontent.com/18607754/163117037-53919c83-8bd4-4099-8a1d-3ab51ada4991.png)


|Here I share the extensions that I have programmed for personal use|->|
|-|-
|Insert Braces|Just for that|
|Remove Braces|Just for that|
|Delete Blank Lines|Just for that|
|Fill Region|I use this when you need to duplicate code changing variable names, like rows to columns|
|Select Fill Region|This is to select the code to be duplicated|
|Select Fill Region|This is to select the code to be duplicated|

## Code example for Fill Region
+ Select the code to be duplicated (Click Extensions Select Fill Region)
+ Regions will be generated
+ The first region will include two identical commented rows.
+ Make required replacements in second line
+ (Click Extensions Fill Region)


            #region -> ElimarSoft.com.Block
            //*******************************************************************************************************************
            // DataBlock,0,RowDataClass,r,rows,height,rowHeight,verSep,totalHeight,top
            // DataBlock,1,ColDataClass,c,cols,width,colWidth,horSep,totalWidth,left
            //*******************************************************************************************************************
            #region -> ElimarSoft.com.Source
            for (int i = 0; i < rows.Length; i++)
            {
                RowDataClass r = rows[i];
                r.height = rowHeight + r.offset;
                if (r.height < 0)
                {
                    if (i > 0) rows[i - 1].offset += r.height;
                    r.height = 0;
                    r.offset = -rowHeight;
                }
            }
            rows[0].top = verSep;
            for (int i = 0; i < rows.Length - 1; i++) rows[i + 1].top = rows[i].top + rows[i].height + verSep;

            rows[rows.Length - 1].height = totalHeight - rows[rows.Length - 1].top - verSep;
            #endregion ElimarSoft.com.Source
            //*******************************************************************************************************************
            #region -> ElimarSoft.com.Result
            for (int i = 0; i < cols.Length; i++)
            {
                ColDataClass c = cols[i];
                c.width = colWidth + c.offset;
                if (c.width < 0)
                {
                    if (i > 0) cols[i - 1].offset += c.width;
                    c.width = 0;
                    c.offset = -colWidth;
                }
            }
            cols[0].left = horSep;
            for (int i = 0; i < cols.Length - 1; i++) cols[i + 1].left = cols[i].left + cols[i].width + horSep;

            cols[cols.Length - 1].width = totalWidth - cols[cols.Length - 1].left - horSep;

            // This code has been automatically generated based on text substitution of previous block
            // These Tags have been omitted,i,Length,offset
            #endregion ElimarSoft.com.Result
            #endregion ElimarSoft.com.Block




