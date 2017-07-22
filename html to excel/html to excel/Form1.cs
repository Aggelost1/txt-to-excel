using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace html_to_excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string txtFileName;
        string line;
        string nums;
        string cell;
        int r;
        int c;
        int pl;
        List<int> indxs = new List<int>();

        private string spaceSeperated(string a,int sp)
        {
            string c = a.Substring(0, sp);
            
            return c;
        }

       
        private void comaSeperatedStringToList(string s, List<int> l)
        {
            l.Clear();
            pl = s.IndexOf(",");
            while (pl != -1)
            {
                
                l.Add(Convert.ToInt32(s.Substring(0,pl)));
                s = s.Substring(pl + 1);
                pl = s.IndexOf(",");
            }
        }


        private void importButon_Click(object sender, EventArgs e)
        {


            if (openFileDialog2.ShowDialog() == DialogResult.OK)              
            {
                nums = indeces.Text;
                comaSeperatedStringToList(nums, indxs);
                r = 0;
                


                txtFileName = openFileDialog2.FileName;
                using (var fltxt = File.OpenText(@txtFileName))
                {
                     

                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    if (xlApp == null) { MessageBox.Show("Excel is not properly installed!!"); }
                    var xlsWorkbook = xlApp.Workbooks.Add();
                    var xlsWorksheet = xlsWorkbook.Worksheets.Item[1];
                    r = 0;
                    line = fltxt.ReadLine();
                    //indxs.Add(line.Length);
                    while (line != null)
                    {
                        r = r + 1;
                       
                        //  a = Regex.Replace(a, @".", String.Empty);
                        //  a = Regex.Replace(a, "/s*", @" ");
                        c = 0;
                        int k = 1;
                        foreach (int j in indxs )
                        {
                            if (j != 1)
                            {
                                c = c + 1;
                                int d = j -k;
                                xlsWorksheet.Cells[r, c] = line.Substring(0, d-1); ;
                                line = line.Substring(d );
                                k = j;
                            }
                        }

                       // MessageBox.Show(line);



                        line = fltxt.ReadLine();
                    }
                    xlsWorkbook.SaveAs(excelname.Text);

                }
            }

        }
    }
    
}
