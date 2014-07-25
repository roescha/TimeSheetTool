using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetTool.helpers;

namespace TimeSheetTool
{
    public partial class MainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form));
        private readonly InvoiceSheetGenerator populator = new InvoiceSheetGenerator();
        private string fileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PopulateButton_Click(object sender, System.EventArgs e)
        {
            
            var start = dateFrom.Value;
            var end = dateTo.Value;
            var from = new DateTime(start.Year, start.Month, start.Day, 0, 0, 0);
            var to = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);
           // var fileName = "C:\\development\\dotnet\\SpreadSheetTool\\SpreadSheetTool\\test_doc.xlsx"; ;
            try
            {
                if (from == null || to == null || fileName == null)
                {
                    MessageBox.Show(MainForm.ActiveForm, "Please enter dates and fileName");
                }
                else
                {
                    populator.GenerateInvoiceSheet(from, to, fileName, getProjectList(), "Company & Cost Centre", "Output");
                    MessageBox.Show(MainForm.ActiveForm, "Completed task.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed: " + ex.Message);
                Console.WriteLine("Actioin failed: " + ex);
            }
        }

        private void FileSelectionButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open Excel File";
            openDialog.Filter = "EXCEL FILES |*.xlsx";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
            }
        }

        private List<string> getProjectList()
        {
            List<string> projects = new List<string>();
            projects.Add("'Trafigura Ecore Navison - 920.8827'");
            projects.Add("'Trafigura PUMA TMS - T2 116.058'");
            return projects;
        }
    }
}
