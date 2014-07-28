using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimeSheetTool
{
    public partial class MainForm : Form
    {
        private readonly String Company_Cost_Centre = "Company & Cost Centre";
        private readonly InvoiceSheetGenerator generator = new InvoiceSheetGenerator();
        private string fileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PopulateButton_Click(object sender, System.EventArgs e)
        {
            
            //date range to extract worked hours form time sheet db
            var start = dateFrom.Value;
            var end = dateTo.Value;

            //se the time from 0:00 to 23:59
            var from = new DateTime(start.Year, start.Month, start.Day, 0, 0, 0);
            var to = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);
            
            try
            {
                if (from == null || to == null || fileName == null || targetSheetName == null)
                {
                    MessageBox.Show(MainForm.ActiveForm, "Please enter dates and fileName");
                }
                else
                {
                    generator.GenerateInvoiceSheet(from, to, fileName, GetProjectList(), Company_Cost_Centre, targetSheetName.Text);
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

        private List<string> GetProjectList()
        {
            List<string> projects = new List<string>();
            projects.Add("'Trafigura Ecore Navison - 920.8827'");
            projects.Add("'Trafigura PUMA TMS - T2 116.058'");
            return projects;
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
