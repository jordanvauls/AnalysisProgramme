using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalysisTool
{
    public partial class Form1 : Form
    {
        HRMFileReader HRMdata = new HRMFileReader();
            List<DateTime> fileDateList = new List<DateTime>();
            List<string[]> fileList = new List<string[]>();
        public Form1()
        {
         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear Old Lists
            fileDateList.Clear();
            fileList.Clear();

            // Load Directory
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            string[] files = Directory.GetFiles(fbd.SelectedPath);

            // Save Files and File Dates
            foreach (string file in files)
            {
                string[] line = File.ReadAllLines(file);
                HRMdata.read_file(line);
                monthCalendar1.AddBoldedDate(HRMdata.StartDateTime);
                DateTime s = HRMdata.StartDateTime;
                TimeSpan ts = new TimeSpan(0, 0, 0);
                s = s.Date + ts;
                fileDateList.Add(s);
                fileList.Add(line);
            }

            // Set Selected Date to Last Loaded File Date
            monthCalendar1.SelectionStart = HRMdata.StartDateTime;
            monthCalendar1.SelectionEnd = HRMdata.StartDateTime;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (fileDateList.Contains(e.Start))
            {
                int index = fileDateList.IndexOf(e.Start);
               // Cycle.instance.importHRMData(fileList[index]);
            }
        
    }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
