using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace MIS
{
    public  class Excel
    {

        _Application excel = new _Excel.Application();
        static Workbook wb;
        static Worksheet ws;
       // static string path =  @"C:\Users\Karthick B\source\repos\MIS\Master Data Base\Master Source Data.xlsm";
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Master Data Base\Master Source Data.xlsm");
        private Excel()
         {
            
            if (File.Exists(path) == true) {
                try { excel.Workbooks["Master Source Data"].Close(); } catch { }
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[1];
                excel.Visible = false;

                if( DateTime.Today.AddDays(1).ToString("d") == "Monday") { excel.Visible = true; }
                    
                
            }
            else
            {
               MessageBox.Show("Master Source Data missing in following menitoned path : "+ path  + " Kindly make sure before start Master Source data wether present or not!!!!");
 
            }

        }


        public static Excel obj;

        
        
        public static Excel Getobj()
        { if(obj == null)
            obj = new Excel();

            return obj;
        }

       
        public void Masterfileopendornot()
        {




        }






















         public  string Readcell(int i, int j)
         {
           string cell =  ws.Cells[i,j].Value2;   
            
            return (cell);
            

        }

        public double Readcelldouble(int i, int j)
        {


            double cell;

            try {  cell = ws.Cells[i, j].Value2; }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                cell =  -255;
            }
            return (cell);


        }


        public void Openexcelfile(string fpath, string fname)
        {

            
            excel.Workbooks.Open(fpath + "\\" + fname);

            excel.Visible = true;
            


        }

        public void Excelvisuable()
        {
            
            excel.Visible = true;



        }
        public void ExcelvisuableHide()
        {
            excel.Visible = false;
        }



        public void Writecell(int i, int j, string value)
        {
            
            ws.Cells[i, j].Value2 = value;

        }


        public void Save()
        {
            
            wb.Save();


        }
            
        public void Saveas(string fpath, string fname)
        {
            
            wb.SaveAs(fpath + "/" + fname);

        }

        public void Close()
        {
            excel.Application.DisplayAlerts = false;
            excel.Application.ScreenUpdating = false;
            Excel.obj = null;
            excel.Quit();

            
        }







        public void Masterdatabasclose()
        {

            wb.Close();
        }


        //Consolidation Code

        public void ExcelConsoliditon(string srcfile, string dstfile, int sheetnum ,int clumnub, string sample)
        {

            
            Workbook dst;
            Workbook src;
            Worksheet dstsheet;
            if(File.Exists(dstfile)== false)
            {
                File.Copy(sample, dstfile);
            }
            dst = excel.Workbooks.Open(dstfile);
            src= excel.Workbooks.Open(srcfile);
            dstsheet = dst.Worksheets[1];


            if (dstsheet.Range["A2"].Value2 == null)
            {
                dstsheet.Activate();
                dstsheet.Range["A2"].Select();
            }
            else
            {
                dstsheet.Activate();
                dstsheet.Range["A1"].Select();
                excel.ActiveCell.End[XlDirection.xlDown].Offset[1, 0].Select();

            }
            src.Activate();
            excel.ActiveWorkbook.Sheets[sheetnum].Activate();
            excel.ActiveSheet.Range["A1"].select();
            excel.ActiveSheet.usedrange.select();
            excel.Selection.copy();
            dstsheet.Activate();
            try { 
            excel.ActiveCell.PasteSpecial(XlPasteType.xlPasteAll);
            }
            catch
            {
                if(excel.ActiveWorkbook.Sheets.Count !=2) {
                    excel.ActiveWorkbook.Sheets.Add(After: excel.ActiveSheet);
                dstsheet.Activate();
                    excel.Range["A1"].Select();
                excel.Range[excel.ActiveCell, excel.ActiveCell.End[XlDirection.xlToRight]].Select();
                excel.Selection.copy();
                excel.ActiveWorkbook.Sheets[2].Activate();
                excel.ActiveSheet.Range["A1"].Select();
                excel.ActiveCell.PasteSpecial(XlPasteType.xlPasteAll);
                excel.Worksheets[2].Range["a2"].Select();

                }
                else {
                dst.Sheets[2].Activate();
                dst.ActiveSheet.Range["a1"].Select();
                excel.ActiveCell.End[XlDirection.xlDown].Offset[1, 0].Select();
                 
                }

                src.Activate();
                excel.ActiveWorkbook.Sheets[sheetnum].Range("A1").select();
                excel.ActiveSheet.usedrange.select();
                excel.Selection.copy();
                dst.Activate();
                excel.ActiveCell.PasteSpecial(XlPasteType.xlPasteAll);


            }
            
            excel.ActiveCell.EntireRow.Delete();
            excel.ActiveSheet.Range["A1"].Select();
            excel.ActiveCell.End[XlDirection.xlDown].Offset[0, clumnub-1].Select();
            excel.ActiveSheet.Range[excel.ActiveCell, excel.ActiveCell.End[XlDirection.xlUp].Offset[1, 0]].Value2 = ws.Cells[50, 4].Value2;
            src.Activate();
            excel.ActiveWorkbook.Close();
             
            dst.Save();
            dst.Close();


        }


        //Pending Removing from Completion Consolidation

        public void Pendingremoving(string dstfile)
        {

            Workbook dst1;
            excel.Workbooks.Open(dstfile);
            dst1 = excel.ActiveWorkbook;
            dst1.Activate();
            dst1.ActiveSheet.Range("A1").select();
            excel.ActiveSheet.Range(excel.ActiveCell, excel.ActiveCell.End[XlDirection.xlToRight]).Select();
            excel.ActiveSheet.Range(excel.Selection, excel.Selection.End[XlDirection.xlDown]).Select();
            excel.Selection.AutoFilter(3, "Pending");
            
            excel.Selection.Offset[1, 0].SpecialCells(XlCellType.xlCellTypeVisible).EntireRow.Delete();

           
            excel.Selection.AutoFilter();
                excel.ActiveSheet.Range("A1").Select();
            


            excel.ActiveWorkbook.Save();
            excel.ActiveWorkbook.Close();

        }




        //For Tracker Macros

        public void SourceDownload()
        {
            wb.Activate();
            excel.Run("file_download");

        }

       public void Filetransfer()
        {
            wb.Activate();
            excel.Run("file_transfer");
        }


        public void SourceFileRename()
        {
            wb.Activate();
            excel.Run("RenameFile");

        }
        public void Consolidation()
        {
            wb.Activate();
            excel.Run("consalidation1");

        }
        public void Completion()
        {

            try { 
            wb.Activate();
            excel.Run("Completion");
            }
            catch
            {
                wb.Activate();
                excel.Run("Completion");
            }
        }

        public void Saturdaydatychange()
        {
            try
            {
                wb.Activate();
                excel.Run("Saturdaydatychange");
            }
            catch
            {
                wb.Activate();
                excel.Run("Saturdaydatychange");
            }
        }
            public void Formating()
        {
            try{
                wb.Activate();

                excel.Run("Format");
            }
            catch
            {
                wb.Activate();

                excel.Run("Format");
            }

        }
        public void Exlcusion()
        {
            try { 
            wb.Activate();
            excel.Run("Exclsi");
            }
            catch
            {
                wb.Activate();
                excel.Run("Exclsi");
            }

        }





        //For Completion Macros
        public void CompletionPivot()
        {

            try
            {
                wb.Activate();
                excel.Run("CreatePivotTable");
            }
            catch
            {
                wb.Activate();
                excel.Run("CreatePivotTable");
            }



        }

        

        public void CompletionDates()
        {
            try
            {
                wb.Activate();
                excel.Run("completiondates");
            }
            catch
            {
                wb.Activate();
                excel.Run("completiondates");
            }
        }

        public void CompletionVlookup()
        {
            try
            {
                wb.Activate();
                excel.Run("vlookup");
            }
            catch
            {
                wb.Activate();
                excel.Run("vlookup");
            }

        }
        public void CompletionAdding()
        {
            try
            {
                wb.Activate();
                excel.Run("Addinginflow");
            }
            catch
            {
                wb.Activate();
                excel.Run("Addinginflow");
            }


        }

        public void CompletionFilesaving()
        {
            try
            {
                wb.Activate();
                excel.Run("savingcompletionFile");
            }
            catch
            {
                wb.Activate();
                excel.Run("savingcompletionFile");
            }

        }


        public void CodingTat()
        {
            try
            {
                wb.Activate();
                excel.Run("codingtat");
            }
            catch
            {
                wb.Activate();
                excel.Run("codingtat");
            }


        }

        public void v6filemacro()
        {
            try
            {
                wb.Activate();
                excel.Run("v6file");
            }
            catch
            {
                wb.Activate();
                excel.Run("v6file");
            }
        }


        //AR Backlog Macro

        public void FirstARBacklog()
        {
            try
            {
                wb.Activate();
                excel.Run("FirstARBacklog");
            }
            catch
            {
                wb.Activate();
                excel.Run("FirstARBacklog");
            }
        }

        public void AR_Compleiton()
        {
            try
            {
                wb.Activate();
                excel.Run("AR_Compleiton");
            }
            catch
            {
                wb.Activate();
                excel.Run("AR_Compleiton");
            }
        }



        public void file_transfer_AR()
        {
            try
            {
                wb.Activate();
                excel.Run("file_transfer_AR");
            }
            catch
            {
                wb.Activate();
                excel.Run("file_transfer_AR");
            }
        }

        public void RenameFile_AR()
        {
            try
            {
                wb.Activate();
                excel.Run("RenameFile_AR");
            }
            catch
            {
                wb.Activate();
                excel.Run("RenameFile_AR");
            }
        }

        public void AR()
        {
            try
            {
                wb.Activate();
                excel.Run("AR");
            }
            catch
            {
                wb.Activate();
                excel.Run("AR");
            }
        }
        public void split_AR()
        {
            try
            {
                wb.Activate();
                excel.Run("split_AR");
            }
            catch
            {
                wb.Activate();
                excel.Run("split_AR");
            }
        }

        public void GravisReport()
        {
            try
            {
                wb.Activate();
                excel.Run("GravisReport");
            }
            catch
            {
                wb.Activate();
                excel.Run("GravisReport");
            }
        }

        public void Summary()
        {
            try
            {
                wb.Activate();
                excel.Run("Summary");
            }
            catch
            {
                wb.Activate();
                excel.Run("Summary");
            }
        }

        public void Bmamwise()
        {
            try
            {
                wb.Activate();
                excel.Run("Bmamwise");
            }
            catch
            {
                wb.Activate();
                excel.Run("Bmamwise");
            }
        }

        public void primaryStatus()
        {
            try
            {
                wb.Activate();
                excel.Run("primaryStatus");
            }
            catch
            {
                wb.Activate();
                excel.Run("primaryStatus");
            }
        }

        public void SpineSumary()
        {
            try
            {
                wb.Activate();
                excel.Run("SpineSumary");
            }
            catch
            {
                wb.Activate();
                excel.Run("SpineSumary");
            }
        }
        public void Angel()
        {
            try
            {
                wb.Activate();
                excel.Run("Angel");
            }
            catch
            {
                wb.Activate();
                excel.Run("Angel");
            }
        }
        public void MedBar()
        {
            try
            {
                wb.Activate();
                excel.Run("MedBar");
            }
            catch
            {
                wb.Activate();
                excel.Run("MedBar");
            }
        }


        //app clear
        public void app_clear()
        {
            try
            {
                wb.Activate();
                excel.Run("Appclear1");
            }
            catch
            {
                wb.Activate();
                excel.Run("Appclear1");
            }
        }



        //Month ENd REport Macro

        public void monthendclear()
        {
            try
            {
                wb.Activate();
                excel.Run("monthendclear");
            }
            catch
            {
                wb.Activate();
                excel.Run("monthendclear");
            }
        }



        public void Daysheet_File_Finding()
        {
            try
            {
                wb.Activate();
                excel.Run("Daysheet_File_Finding");
            }
            catch
            {
                wb.Activate();
                excel.Run("Daysheet_File_Finding");
            }
        }


        public void LCF_File_Finding()
        {
            try
            {
                wb.Activate();
                excel.Run("LCF_File_Finding");
            }
            catch
            {
                wb.Activate();
                excel.Run("LCF_File_Finding");
            }
        }

        
        public void Aging_File_Finding()
        {
            try
            {
                wb.Activate();
                excel.Run("Aging_File_Finding");
            }
            catch
            {
                wb.Activate();
                excel.Run("Aging_File_Finding");
            }
        }
        
        public void ExtentionConvert()
        {
            try
            {
                wb.Activate();
                excel.Run("ExtentionConvert");
            }
            catch
            {
                wb.Activate();
                excel.Run("ExtentionConvert");
            }
        }
        public void LCF_File_Check()
        {
            try
            {
                wb.Activate();
                excel.Run("LCF_File_Check");
            }
            catch
            {
                wb.Activate();
                excel.Run("LCF_File_Check");
            }
        }
        public void Primarystatusfind()
        {
            try
            {
                wb.Activate();
                excel.Run("Primarystatusfind");
            }
            catch
            {
                wb.Activate();
                excel.Run("Primarystatusfind");
            }
        }



        public void Primarystatuslistbox()
        {
            try
            {
                wb.Activate();
                excel.Run("Primarystatuslistbox");
            }
            catch
            {
                wb.Activate();
                excel.Run("Primarystatuslistbox");
            }
        }


        public void KPI_Clear()
        {
            try
            {
                wb.Activate();
                excel.Run("KPI_Clear");
            }
            catch
            {
                wb.Activate();
                excel.Run("KPI_Clear");
            }


        }


        public void KPIDaysheet_name_Finding()
        {
            try
            {
                wb.Activate();
                excel.Run("Daysheet_name_Finding");
            }
            catch
            {
                wb.Activate();
                excel.Run("Daysheet_name_Finding");
            }


        }


        public void KPIchargefilecheck()
        {
            try
            {
                wb.Activate();
                excel.Run("KPIchargefilecheck");
            }
            catch
            {
                wb.Activate();
                excel.Run("KPIchargefilecheck");
            }


        }

        

        public void KPIBilledtime()
        {
            try
            {
                wb.Activate();
                excel.Run("Billedtime");
            }
            catch
            {
                wb.Activate();
                excel.Run("Billedtime");
            }


        }


        public void KPI_Paidin30days_Final()
        {
            try
            {
                wb.Activate();
                excel.Run("KPI_Paidin30days_Final");
            }
            catch
            {
                wb.Activate();
                excel.Run("KPI_Paidin30days_Final");
            }


        }

        public void KPI_ExtentionConvert()
        {
            try
            {
                wb.Activate();
                excel.Run("KPI_ExtentionConvert");
            }
            catch
            {
                wb.Activate();
                excel.Run("KPI_ExtentionConvert");
            }


        }



        public void KPICharge_name_Finding()
        {
            try
            {
                wb.Activate();
                excel.Run("Charge_name_Finding");
            }
            catch
            {
                wb.Activate();
                excel.Run("Charge_name_Finding");
            }


        }




        public void MonthEndReport()
        {
            try
            {
                wb.Activate();
                excel.Run("MonthEndReport");
            }
            catch
            {
                wb.Activate();
                excel.Run("MonthEndReport");
            }
        }







        public void Agingfind()
        {
            try
            {
                wb.Activate();
                excel.Run("Agingfind");
            }
            catch
            {
                wb.Activate();
                excel.Run("Agingfind");
            }
        }

        public void Daysheet_Alignment_Change()
        {
            try
            {
                wb.Activate();
                excel.Run("Daysheet_Alignment_Change");
            }
            catch
            {
                wb.Activate();
                excel.Run("Daysheet_Alignment_Change");
            }
        }





        public Array findingprimarystatus( int columnnumber)
        {

                Worksheet fps;
                var myList = new List<string>();
                wb.Sheets["Consolidated Primary status"].activate();
                fps = wb.ActiveSheet;
                for (int i = 2; fps.Cells[i, 2].value != null; i++)
                {

                    var na = fps.Cells[i, columnnumber].Value;
                    
                    myList.Add(Convert.ToString(na));
                    na = null;



                }
                var myArray = myList.ToArray();
                return myArray;



            
        }


        public void CGConsolidation()
        {

            try
            {
                wb.Activate();
                excel.Run("CGConsolidation");
            }
            catch
            {
                wb.Activate();
                excel.Run("CGConsolidation");
            }



        }







        }





    }

