using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.IO;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.POIFS;
using NPOI.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.POIFS.FileSystem;

namespace Goering.Utility.Utils
{
    public class Report
    {

        private string templateFilePath = ""; // 模板路径
        private string outFilePath = ""; // 生成Excel路径
        private HSSFWorkbook workbook = null; // WorkBook对象
        private HSSFSheet sheet = null; // Sheet对象
        private HSSFRow row = null; // Row对象
        private char[] splite = new char[] { ',' };
        /// <summary>
        /// 生成文件的默认路径，建议在初始化时设定
        /// </summary>
        public static string DefaultFilePath = "";

        private HSSFCellStyle TextStyle;
        private HSSFCellStyle DateTimeStyle;

        /// <summary>
        /// 获取生成文件路径
        /// </summary>
        /// <returns></returns>
        public string GetOutFilePath()
        {
            return outFilePath;
        }
        /// <summary>
        /// 设定生成文件的路径
        /// </summary>
        /// <param name="outFilePath">路径</param>
        public void SetOutFilePath(string outFilePath)
        {
            this.outFilePath = outFilePath;
        }

        /// <summary>
        /// 将workbook,sheet,row开放出来,主要用在Report不能提供想要功能,而POI支持时,可使用POI来完成.
        /// </summary>
        /// <returns></returns>
        public HSSFWorkbook GetWorkbook()
        {
            return workbook;
        }

        /// <summary>
        /// 得到当前Sheet
        /// </summary>
        /// <returns></returns>
        public HSSFSheet GetSheet()
        {
            return sheet;
        }

        /// <summary>
        /// 依据序号得到Sheet
        /// </summary>
        /// <param name="sheetNum">序号</param>
        /// <returns></returns>
        public HSSFSheet GetSheet(int sheetNum)
        {
            return (HSSFSheet)workbook.GetSheetAt(sheetNum);
        }

        /// <summary>
        /// 依据表格名称得到Sheet
        /// </summary>
        /// <param name="sheetName">表格名称</param>
        /// <returns></returns>
        public HSSFSheet GetSheet(string sheetName)
        {
            return (HSSFSheet)workbook.GetSheet(sheetName);
        }
        /// <summary>
        /// 增加表格
        /// </summary>
        /// <param name="sheetName">表格名称</param>
        /// <returns></returns>
        public HSSFSheet AddSheet(string sheetName)
        {
            sheet = (HSSFSheet)workbook.CreateSheet(sheetName);
            return sheet;
        }
        /// <summary>
        /// 增加表格
        /// </summary>
        /// <returns></returns>
        public HSSFSheet AddSheet()
        {
            sheet = (HSSFSheet)workbook.CreateSheet();
            return sheet;
        }
        /// <summary>
        /// 获取行
        /// </summary>
        /// <param name="rowNum">行号</param>
        /// <returns></returns>
        public HSSFRow GetRow(int rowNum)
        {
            row = (HSSFRow)sheet.GetRow(rowNum);
            if (row == null)
            {
                sheet.CreateRow(rowNum);
                row = (HSSFRow)sheet.GetRow(rowNum);
            }
            return row;
        }
        /// <summary>
        /// 获取单元格
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <returns></returns>
        public HSSFCell GetCell(int rowNum, int columnNum)
        {
            HSSFRow row = GetRow(rowNum);
            if (row.GetCell(columnNum) == null)
            {
                row.CreateCell(columnNum);
            }

            return (HSSFCell)row.GetCell(columnNum);
        }

        /// <summary>
        /// 有模板生成Excel
        /// </summary>
        /// <param name="templateFilePath">模板路径</param>
        /// <param name="outFilePath">保存Excel路径</param>
        public Report(string templateFilePath, string outFilePath)
        {
            this.templateFilePath = templateFilePath;
            this.outFilePath = outFilePath;
            POIFSFileSystem fs = new POIFSFileSystem(File.OpenRead(templateFilePath));
            workbook = new HSSFWorkbook(fs);
            sheet = (HSSFSheet)workbook.GetSheetAt(0);
            InitStyle();
        }

        /// <summary>
        /// 有模板生成Excel
        /// </summary>
        /// <param name="templateFilePath">模板路径</param>
        public Report(string templateFilePath)
        {
            DateTime now = DateTime.Now;
            this.templateFilePath = templateFilePath;
            this.outFilePath = DefaultFilePath + "\\" + now.Ticks.ToString() + ".xls";
            POIFSFileSystem fs = new POIFSFileSystem(File.OpenRead(templateFilePath));
            workbook = new HSSFWorkbook(fs);
            sheet = (HSSFSheet)workbook.GetSheetAt(0);
            InitStyle();
        }

        /// <summary>
        /// 无模板生成Excel,生成的文件放在当前目录下
        /// </summary>
        public Report()
        {
            DateTime now = DateTime.Now;
            this.outFilePath = DefaultFilePath + "\\" + now.Ticks.ToString() + ".xls";
            workbook = new HSSFWorkbook();
            sheet = (HSSFSheet)workbook.CreateSheet();
            InitStyle();
        }

        private void InitStyle()
        {
            HSSFDataFormat format = workbook.CreateDataFormat() as HSSFDataFormat;
            TextStyle = workbook.CreateCellStyle() as HSSFCellStyle;
            DateTimeStyle = workbook.CreateCellStyle() as HSSFCellStyle;
            TextStyle.DataFormat = format.GetFormat("Text");
            DateTimeStyle.DataFormat = format.GetFormat("yyyy-mm-dd");
        }

        /// <summary>
        /// 保存Excel
        /// </summary>
        public void Save()
        {
            FileStream fileOut = File.OpenWrite(outFilePath);
            workbook.Write(fileOut);
            fileOut.Close();
        }

        /// <summary>
        /// 保存Excel
        /// </summary>
        /// <param name="outFilePath">保存路径</param>
        public void Save(string outFilePath)
        {
            this.outFilePath = outFilePath;
            Save();
        }

        /// <summary>
        /// 填单元格内容
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="value">值</param>
        public void SetCellValue(int rowNum, int columnNum, Object value)
        {
            if (value == null)
                return;

            HSSFCell cell = GetCell(rowNum, columnNum);

            switch (value.GetType().ToString())
            {
                case "System.String"://字符串类型
                    cell.CellStyle = TextStyle;//格式化显示
                    cell.SetCellValue(value.ToString());
                    break;
                case "System.DateTime"://日期类型
                    DateTime dateV;
                    DateTime.TryParse(value.ToString(), out dateV);
                    cell.CellStyle = DateTimeStyle;//格式化显示
                    cell.SetCellValue(dateV);
                    break;
                case "System.Boolean"://布尔型
                    bool boolV = false;
                    bool.TryParse(value.ToString(), out boolV);
                    cell.SetCellValue(boolV);
                    break;
                case "System.Int16"://整型
                case "System.Int32":
                case "System.Int64":
                case "System.Byte":
                    int intV = 0;
                    int.TryParse(value.ToString(), out intV);
                    cell.SetCellValue(intV);
                    break;
                case "System.Decimal"://浮点型
                case "System.Double":
                    double doubV = 0;
                    double.TryParse(value.ToString(), out doubV);
                    cell.SetCellValue(doubV);
                    break;
                case "System.DBNull"://空值处理
                    cell.SetCellValue("");
                    break;
                default:
                    cell.SetCellValue("");
                    break;
            }
        }

        /// <summary>
        /// 获取单元格内容
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <returns>对象</returns>
        public Object GetValue(int rowNum, int columnNum)
        {
            row = (HSSFRow)sheet.GetRow(rowNum);
            if (row == null)
                return null;
            HSSFCell cell = (HSSFCell)row.GetCell(columnNum);
            if (cell == null)
                return null;

            switch (cell.CellType)
            {
                case CellType.String:
                    return cell.RichStringCellValue;
                case CellType.Numeric:
                    if (DateUtil.IsCellDateFormatted(cell))
                    {
                        return cell.DateCellValue;
                    }
                    else
                    {
                        return cell.NumericCellValue;
                    }
                case CellType.Boolean:
                    return cell.BooleanCellValue;
                case CellType.Formula:
                    return cell.CellFormula;
                default:
                    return null;
            }
        }

        /// <summary>
        /// 填充标题
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="value">用","分隔开的字符串,如"员工工号,姓名,身份证,部门"</param>
        public void FillTitle(int rowNum, int columnNum, string value)
        {
            string[] titles = value.Split(splite);
            if (titles.Length > 256)
                throw new Exception("titles > 256");
            foreach (string temp in titles)
            {
                SetCellValue(rowNum, columnNum++, temp);
            }
        }

        /// <summary>
        /// 填充对象列表
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="lstObject">对象列表</param>
        /// <param name="propertys">属性列表</param>
        public void FillCellWithObjectList(int rowNum, int columnNum, string titles, List<Object> lstObject, string propertys)
        {
            string[] temp = propertys.Split(splite);
            int tempNum = 0;

            if (lstObject.Count() > 65534)
                throw new Exception("size > 65535");

            if (titles != "" && titles != null)
            {
                FillTitle(rowNum++, columnNum, titles);
            }

            foreach (Object obj in lstObject)
            {
                tempNum = columnNum;
                foreach (string property in temp)
                {
                    SetCellValue(rowNum, tempNum++, obj.GetType().GetProperty(property).GetValue(obj, null));
                }
                rowNum++;
            }
        }
        /// <summary>
        /// 填充对象列表
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="lstObject">对象列表</param>
        /// <param name="propertys">属性列表</param>
        /// <param name="begin">开始记录</param>
        /// <param name="end">结束记录</param>
        public void FillCellWithObjectList(int rowNum, int columnNum, List<Object> lstObject, string propertys, int begin, int end)
        {
            string[] temp = propertys.Split(splite);
            int tempNum = 0;

            if (end - begin <= 0)
                return;

            if (end - begin + 1 > 65534)
                throw new Exception("size > 65535");

            for (int i = begin; i <= end; i++)
            {
                Object obj = lstObject[i];
                tempNum = columnNum;
                foreach (string property in temp)
                {
                    SetCellValue(rowNum, tempNum++, obj.GetType().GetProperty(property).GetValue(obj, null));
                }
                rowNum++;
            }
        }

        /// <summary>
        /// 填充对象数组
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="objectArray">对象数组</param>
        public void FillCellWithObjectArray(int rowNum, int columnNum, Object[][] objectArray)
        {
            int rowCount, columnCount;

            if (objectArray == null)
                return;

            rowCount = objectArray.Length;
            if (rowCount > 65534)
                throw new Exception("row size > 65535");

            if (rowCount <= 0)
            {
                throw new Exception("row size <= 0");
            }

            columnCount = objectArray[0].Length;
            if (columnCount > 255)
                throw new Exception("column size > 256");

            for (int iRow = 0; iRow < rowCount; iRow++)
            {
                for (int iCol = 0; iCol < columnCount; iCol++)
                {
                    SetCellValue(rowNum + iRow, columnNum + iCol, objectArray[iRow][iCol]);
                }
            }
        }
        /// <summary>
        /// 填充对象数组
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="objectArray">对象数组</param>
        /// <param name="begin">开始行</param>
        /// <param name="end">结束行</param>
        public void FillCellWithObjectArray(int rowNum, int columnNum, Object[][] objectArray, int begin, int end)
        {
            int rowCount, columnCount;

            if (objectArray == null)
                return;

            rowCount = end - begin + 1;
            if (rowCount > 65534)
                throw new Exception("row size > 65535");

            if (rowCount <= 0)
            {
                throw new Exception("row size <= 0");
            }

            columnCount = objectArray[0].Length;
            if (columnCount > 255)
                throw new Exception("column size > 256");

            for (int iRow = begin; iRow <= end; iRow++)
            {
                for (int iCol = 0; iCol < columnCount; iCol++)
                {
                    SetCellValue(rowNum + iRow, columnNum + iCol, objectArray[iRow][iCol]);
                }
            }
        }
        /// <summary>
        /// 按表格内容生成Excel
        /// </summary>
        /// <param name="dtSource">表格</param>
        /// <param name="columns">选择的列</param>
        /// <param name="titles">表头</param>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        public void ExportFromTable(DataTable dtSource, string columns, string titles, int rowNum, int columnNum)
        {
            if (dtSource == null)
                return;
            FillTitle(rowNum, columnNum, titles);
            rowNum++;
            ExportFromTable(dtSource, columns, rowNum, columnNum);
        }
        /// <summary>
        /// 按表格内容生成Excel
        /// </summary>
        /// <param name="dtSource">表格</param>
        /// <param name="Columns">选择的列</param>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum"></param>
        public void ExportFromTable(DataTable dtSource, string Columns, int rowNum, int columnNum)
        {
            if (dtSource == null)
                return;
            int rowCount = dtSource.Rows.Count;
            if (rowCount <= 0)
                return;

            if (rowCount > 65534)
                throw new Exception("row size > 65535");
            string[] columns = Columns.Split(splite);
            foreach (DataRow row in dtSource.Rows)
            {
                int iAdd = 0;
                foreach (string column in columns)
                {
                    SetCellValue(rowNum, columnNum + iAdd, row[column]);
                    iAdd++;
                }
                rowNum++;
            }
        }
        /// <summary>
        /// 按表格内容生成Excel
        /// </summary>
        /// <param name="dtSource">表格</param>
        /// <param name="Columns">选择的列</param>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="begin">开始行</param>
        /// <param name="end">结束行</param>
        public void ExportFromTable(DataTable dtSource, string Columns, int rowNum, int columnNum, int begin, int end)
        {
            if (dtSource == null)
                return;
            int rowCount = end - begin + 1;
            if (rowCount <= 0)
                return;
            if (rowCount > 65534)
                throw new Exception("row size > 65535");
            string[] columns = Columns.Split(splite);
            for (int i = begin; i <= end; i++)
            {
                DataRow row = dtSource.Rows[i];
                int iAdd = 0;
                foreach (string column in columns)
                {
                    SetCellValue(rowNum, columnNum + iAdd, row[column]);
                    iAdd++;
                }
                rowNum++;
            }
        }
        /// <summary>
        /// 设置单元格公式
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="formulastring">公式</param>
        public void SetCellFormula(int rowNum, int columnNum, string formulastring)
        {
            HSSFCell cell = GetCell(rowNum, columnNum);
            cell.SetCellFormula(formulastring);
        }

        /// <summary>
        /// 合并单元格
        /// </summary>
        /// <param name="firstRow">开始行</param>
        /// <param name="lastRow">结束行</param>
        /// <param name="firstColumn">开始列</param>
        /// <param name="lastColumn">结束列</param>
        public void MergingCells(int firstRow, int lastRow, int firstColumn, int lastColumn)
        {
            sheet.AddMergedRegion(new CellRangeAddress(firstRow, lastRow, firstColumn, lastColumn));
        }

        /// <summary>
        /// 设置单元格边框
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        /// <param name="style">边框样式</param>
        public void SetCellBorder(int rowNum, int columnNum, HSSFCellStyle style)
        {
            HSSFCell cell = GetCell(rowNum, columnNum);
            cell.CellStyle = style;
        }

        /// <summary>
        /// 居中
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        public void SetCenter(int rowNum, int columnNum)
        {
            HSSFCell cell = GetCell(rowNum, columnNum);
            HSSFCellStyle style = (HSSFCellStyle)cell.CellStyle;
            if (style == null)
                style = (HSSFCellStyle)workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            cell.CellStyle = style;
        }

        /// <summary>
        /// 设置会计样式,小数们为2
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        public void SetAccountantStyle(int rowNum, int columnNum)
        {
            HSSFCell cell = GetCell(rowNum, columnNum);
            HSSFCellStyle style = (HSSFCellStyle)workbook.CreateCellStyle();
            HSSFDataFormat format = (HSSFDataFormat)workbook.CreateDataFormat();
            style.DataFormat = format.GetFormat("_ * #,##0.00_ ;_ * -#,##0.00_ ;_ * \"-\"??_ ;_ @_ ");
            cell.CellStyle = style;
        }

        /// <summary>
        /// 设置会计样式,小数位为0
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="columnNum">列</param>
        public void SetAccountantZeroStyle(int rowNum, int columnNum)
        {
            HSSFCell cell = GetCell(rowNum, columnNum);
            HSSFCellStyle style = (HSSFCellStyle)workbook.CreateCellStyle();
            HSSFDataFormat format = (HSSFDataFormat)workbook.CreateDataFormat();
            style.DataFormat = format.GetFormat("_ * #,##0_ ;_ * -#,##0_ ;_ * \"-\"??_ ;_ @_ ");
            cell.CellStyle = style;
        }

        /// <summary>
        /// 设置区域边框样式
        /// </summary>
        /// <param name="firstRow">开始行</param>
        /// <param name="lastRow">结束行</param>
        /// <param name="firstColumn">开始列</param>
        /// <param name="lastColumn">结束列</param>
        /// <param name="style">边框样式</param>
        public void SetBorder(int firstRow, int lastRow, int firstColumn, int lastColumn, HSSFCellStyle style)
        {
            int temp = 0;
            if (firstRow > lastRow)
            {
                temp = firstRow;
                firstRow = lastRow;
                lastRow = temp;
            }

            if (firstColumn > lastColumn)
            {
                temp = firstColumn;
                firstColumn = lastColumn;
                lastColumn = temp;
            }

            if (firstRow < 0 || lastRow > 65534 || firstColumn < 0 || lastColumn > 65534)
            {
                return;
            }

            for (int iAdd = firstRow; iAdd <= lastRow; iAdd++)
            {
                for (int jAdd = firstColumn; jAdd <= lastColumn; jAdd++)
                {
                    SetCellBorder(iAdd, jAdd, style);
                }
            }
        }

        /// <summary>
        /// 使用默认样式设置区域边框
        /// </summary>
        /// <param name="firstRow">开始行</param>
        /// <param name="lastRow">结束行</param>
        /// <param name="firstColumn">开始列</param>
        /// <param name="lastColumn">结束列</param>
        public void SetBorder(int firstRow, int lastRow, int firstColumn, int lastColumn)
        {
            HSSFCellStyle style = (HSSFCellStyle)workbook.CreateCellStyle();
            style.BorderBottom = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;

            SetBorder(firstRow, lastRow, firstColumn, lastColumn, style);
        }

        /// <summary>
        /// 设置列宽
        /// </summary>
        /// <param name="columnNum">列</param>
        /// <param name="width">宽度</param>
        public void SetColumnWidth(int columnNum, int width)
        {
            sheet.SetColumnWidth(columnNum, width);
        }

        /// <summary>
        /// 设置行高
        /// </summary>
        /// <param name="rowNum">行</param>
        /// <param name="height">高度</param>
        public void SetRowHeight(int rowNum, short height)
        {
            GetRow(rowNum).Height = height;
        }

        /// <summary>
        /// 自动列宽
        /// </summary>
        /// <param name="columnNum">宽度</param>
        public void AutoColumnWidth(int columnNum)
        {
            sheet.AutoSizeColumn(columnNum);
        }

        /// <summary>
        /// 自动列宽
        /// </summary>
        /// <param name="firstColumn">开始列</param>
        /// <param name="lastColumn">结束列</param>
        public void AutoColumnWidth(int firstColumn, int lastColumn)
        {
            int temp = 0;
            if (firstColumn > lastColumn)
            {
                temp = firstColumn;
                firstColumn = lastColumn;
                lastColumn = temp;
            }

            for (int iAdd = firstColumn; iAdd < lastColumn; iAdd++)
            {
                AutoColumnWidth(iAdd);
            }
        }

        /// <summary>
        /// 设置冻结窗格
        /// </summary>
        /// <param name="colsplit">冻结列</param>
        /// <param name="rowsplit">冻结行</param>
        /// <param name="leftmostcolum">右侧首列序号</param>
        /// <param name="toprow">下侧首列行号</param>
        public void SetFreezePane(int colsplit, int rowsplit, int leftmostcolum, int toprow)
        {
            sheet.CreateFreezePane(colsplit, rowsplit, leftmostcolum, toprow);
        }
    }
}
