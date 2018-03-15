using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Collections.Generic;
using System.Linq;
using AnalysisTool;

namespace WindowsFormsApp6
{
    public partial class mainpage : MetroFramework.Forms.MetroForm
    {
      
        int difference;
        int powerb;
        int numericupdown;
        int checkCount = 0;
        TimeSpan globaltime;
        TimeSpan globaltime2;
        bool chunkingbool2 = false;
        List<double> movAvgPow4 = new List<double>();
        List<double> movAvg = new List<double>();
        List<double> movAvgPow4Slt = new List<double>();
        List<double> movAvgSlt = new List<double>();
        double speedTotalRange = 0;
        double speedMaximumRange = 0;
        double altitudeTotalRange = 0;
        double altitudeMaximumRange = 0;
        int heartRateTotalRange = 0;
        int heartRateMaximumRange = 0;
        int heartRateMinimumRange = 0;
        int powerTotalRange = 0;
        int powerMaximumRange = 0;
        decimal distanceTotalRange = 0;
        bool distanceCalculationFlagRange = false;
        bool chunkingbool;
        List<List<string>> data = new List<List<string>>();
        public static List<String> HRDATA1 = new List<String>();
        public static List<String> HRDATA2 = new List<String>();

        public static List<String> HRDATA1Compare = new List<String>();
        public static List<String> HRDATA2Compare = new List<String>();
        int startpoint;
        int endpoint;
        public static List<String> ParamDataa1 = new List<String>();
        public static List<String> ParamDataa2 = new List<String>();
        bool zoomin;
        public static List<TimeSpan> totalTime = new List<TimeSpan>();
        double movAvgCount;
        int pbl;
        int pbr;
        int pbi;
        int pbl2;
        int pbr2;
        int pbi2;
        int balance;
        int maxhr2;
            int minhr2;
        double avghr2;

        double avghr;
        int NP1;
        double FullLengthInSecs;
        double IF;
        int NP;
        double FTP;
        int EuroUsType;
        string version = "";
        string heartrate = "";
        string airpressure = "";
        string speed = "";
        string starttime = "";
        string length = "";
        string weight = "";
        public string pathglob;
        string USEURO = "";
        string pindex = "";
        string cadence = "";
        string altitude = "";
        string power = "";
        double minutes;
        double maxhr;
        double minhr;
        double avgpower;
        string[] splitter;
        double maxpower;
        double HRaverage;
        double maxheartratepercentage;
        double speedavg;
        int portionValue = 0;
        int tickBoxValue = 0;
        string cadence2 = "";
        string altitude2 = "";
        string power2 = "";
        double minutes2;
        string speed2;
        int numberofchunks;
        long PowerB, leftMask, PedIndMask;
        string PBbinary, leftBin, PiBin;
        public double lvalue, pvalue, rvalue;
        double left, pedindex, right;
        public double rows;
        public double[] Larray, Rarray, PIarray;
        bool bool1;
        TimeSpan lengthinhours;
        int count = 0;
        int count2 = 0;
        int interval = 0;
        PointPairList list = new PointPairList();
        PointPairList list2 = new PointPairList();
        PointPairList list3 = new PointPairList();
        PointPairList list4 = new PointPairList();
        PointPairList list5 = new PointPairList();

        PointPairList listCompare = new PointPairList();
        PointPairList list2Compare = new PointPairList();
        PointPairList list3Compare = new PointPairList();
        PointPairList list4Compare = new PointPairList();
        PointPairList list5Compare = new PointPairList();
        List<decimal> distanceList = new List<decimal>();
        List<int> list6 = new List<int>();
        List<int> list7 = new List<int>();
        List<int> list8 = new List<int>();

        List<int> list6Compare = new List<int>();
        List<int> list7Compare = new List<int>();
        List<int> list8Compare = new List<int>();

        decimal totalDistance;

        List<TimeSpan> TimeList = new List<TimeSpan>();
        List<TimeSpan> TimeList2 = new List<TimeSpan>();
        List<TimeSpan> TimeList3 = new List<TimeSpan>();
        List<TimeSpan> TimeList4 = new List<TimeSpan>();
        List<string> TimeList6 = new List<string>();
        List<int> HeartRateList = new List<int>();
        List<int> SpeedList = new List<int>();
        List<int> CadenceList = new List<int>();
        List<int> altitudeList = new List<int>();
        List<int> Powerlist = new List<int>();

        List<int> HeartRateListCompare = new List<int>();
        List<int> SpeedListCompare = new List<int>();
        List<int> CadenceListCompare = new List<int>();
        List<int> altitudeListCompare = new List<int>();
        List<int> PowerlistCompare = new List<int>();

        List<int> HeartRateListCompare2 = new List<int>();
        List<int> SpeedListCompare2 = new List<int>();
        List<int> CadenceListCompare2 = new List<int>();
        List<int> altitudeListCompare2 = new List<int>();
        List<int> PowerlistCompare2 = new List<int>();


        List<int> HeartRateListChunk = new List<int>();
        List<int> SpeedListChunk = new List<int>();
        List<int> CadenceListChunk = new List<int>();
        List<int> altitudeListChunk = new List<int>();
        List<int> PowerlistChunk = new List<int>();

        List<int> HeartRateListChunk2 = new List<int>();
        List<int> SpeedListChunk2 = new List<int>();
        List<int> CadenceListChunk2 = new List<int>();
        List<int> altitudeListChunk2 = new List<int>();
        List<int> PowerlistChunk2 = new List<int>();

        List<int> HeartRateList2 = new List<int>();
        List<int> SpeedList2 = new List<int>();
        List<int> CadenceList2 = new List<int>();
        List<int> altitudeList2 = new List<int>();
        List<int> Powerlist2 = new List<int>();

        int versionval;
        public string userName;
        string monitortype;
        decimal maxspeed;
        double altmax;
        bool SpeedOn;
        bool CadenceOn;
        bool AltitudeOn;
        bool PowerOn;
        bool Power2On;
        bool power3on;
        bool ccdata;
        bool USEUROon;
        bool AIRPOn;
        bool timepresent = false;
        bool heartratepresent = false;
        bool powerpresent = false;
        bool speedpresent = false;
        bool cadencepresent = false;
        bool altitpresent = false;
        double CadenceAverage;

        double avgpbl;
        double avgpbr;
        double avgpbi;
        string heartrate2;

        //avg 

        double avgpbl2;
        double avgpbr2;
        double avgpbi2;
        double CadenceAverage2;
        double avgpower2;
        double maxpower2;
        double maxspeed2;
        double speedavg2;
        double altmax2;
        double AltitAVG2;

        double AltitAVG;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt6 = new DataTable();
        int intcounter = 0;
       public int[] intervals = new int[20] { 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800, 0, 3800 };
        public mainpage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// finding the intervals within the data array intervals
        /// </summary>
        public void FindIntervals()
        {
            bool Over = false;
            int loc = 0;
            int timer = 0;
            int power;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                //Finds row number where is power over 150
                power = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                if (power > 150 && Over == false)
                {
                    if (loc < 20)
                    {
                        intervals[loc] = i;
                        loc++;
                        Over = true;
                    }
                }
                if (power < 150 && Over == true)
                {
                    if (timer > 29)
                    {
                        intervals[loc] = i;
                    }
                    if (timer < 29)
                    {
                        loc = loc - 2;
                    }
                    loc++;
                    Over = false;
                    timer = 0;
                }
                if (Over)
                {
                    timer++;
                }
            }
        }
   /// <summary>
   /// this is used to loop through the intervals.
   /// </summary>
        public void intervalpicker()
        {
            int high = 0;
            int low = 0;
            switch (intcounter)
            {
              
            }
            zedGraphControl1.GraphPane.XAxis.Scale.Min = Convert.ToDouble(low);
            zedGraphControl1.GraphPane.XAxis.Scale.Max = Convert.ToDouble(high);
            zedGraphControl1.Refresh();

            intervalbox.Text = Convert.ToString(intcounter);

        }

        /// <summary>
        /// loads properties on form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            userName = Environment.UserName;
            //navigae to the director and create folder for values to be passed through if you dont already have it.
            Directory.CreateDirectory(@"C:\Users\" + userName + "\\AnalysisData\\Fav\\");
            //gets the directory info.
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\" + userName + "\\AnalysisData\\Fav\\");
            //creates the text file.
            FileInfo[] Files = dinfo.GetFiles("*.HRM");
            foreach (FileInfo file in Files)
            {
                string name = file.Name.Substring(0, file.Name.LastIndexOf(".HRM", StringComparison.OrdinalIgnoreCase));
                if (name.Equals(""))
                {
                    File.Delete(@"C:\Users\" + userName + "\\AnalysisData\\Fav\\.HRM");
                }
                else
                {
                    //adds the name into the combo box.
                    favouritesComboBox.Items.Add(name);
                }
            }
        }
        /// <summary>
        /// this is where the graph is loaded and the series are plotting.
        /// </summary>
        public void LoadGraph()
        {
            dataGridView1.DataSource = dt;
            dataGridView3.DataSource = dt2;
            dataGridView3.DataSource = dt2;


            //booleans for checking smode. turning datagrids off and on
            if (AltitudeOn == false)
            {
                dataGridView1.Columns[4].Visible = false;
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;

            }

            if (CadenceOn == false)
            {
                dataGridView1.Columns[3].Visible = false;
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
            if (PowerOn == false)
            {
                dataGridView1.Columns[5].Visible = false;
                checkBox2.Checked = false;

            }
            else
            {
                checkBox2.Checked = true;

            }

            if (SpeedOn == false)
            {
                checkBox4.Checked = false;
                dataGridView1.Columns[2].Visible = false;
            }
            else
            {
                checkBox4.Checked = true;
            }

            //graph pane initalise
            GraphPane myPane = zedGraphControl1.GraphPane;


            //clearing the controls


            //assigning the titles
            myPane.Title.Text = "Cycle Data Graph";
            myPane.XAxis.Title.Text = "Time In Seconds";
            myPane.YAxis.Title.Text = "Vaule";

            if (bool1 == true)
            {
                if (checkBox1.Checked == true)
                {
                    Color comparisonHeartCurveColour = Color.FromArgb(80, Color.Red);
                    LineItem teamACurve2 = myPane.AddCurve("HeartRate2",
                          listCompare, comparisonHeartCurveColour, SymbolType.None);
                    teamACurve2.Line.Width = 2.0F;
                    teamACurve2.Line.IsSmooth = true;
                    teamACurve2.Line.SmoothTension = 1F;
                }

                if (checkBox4.Checked == true)
                {
                    Color comparisonSpeedCurveColour = Color.FromArgb(80, Color.Blue);
                    LineItem teamBCurve2 = myPane.AddCurve("Speed2",
                          list2Compare, comparisonSpeedCurveColour, SymbolType.None);
                    teamBCurve2.Line.Width = 2.0F;
                    teamBCurve2.Line.IsSmooth = true;
                    teamBCurve2.Line.SmoothTension = 1F;
                }

                if (checkBox3.Checked == true)
                {
                    Color comparisonBlackCurveColour = Color.FromArgb(80, Color.Black);
                    LineItem teamcCurve2 = myPane.AddCurve("Altitude2",
                list3Compare, comparisonBlackCurveColour, SymbolType.None);
                    teamcCurve2.Line.Width = 2.0F;
                    teamcCurve2.Line.IsSmooth = true;
                    teamcCurve2.Line.SmoothTension = 1F;
                }

                if (checkBox5.Checked == true)
                {
                    Color comparisonGreenCurveColour = Color.FromArgb(80, Color.Green);
                    LineItem teamdCurve2 = myPane.AddCurve("Cadence2",
                list4Compare, comparisonGreenCurveColour, SymbolType.None);
                    teamdCurve2.Line.Width = 2.0F;
                    teamdCurve2.Line.IsSmooth = true;
                    teamdCurve2.Line.SmoothTension = 1F;
                }
                if (checkBox2.Checked == true)
                {
                    Color comparisonOrangeCurveColour = Color.FromArgb(80, Color.Orange);
                    LineItem teamECurve2 = myPane.AddCurve("Power2",
                 list5Compare, comparisonOrangeCurveColour, SymbolType.None);
                    teamECurve2.Line.Width = 4.0F;
                    teamECurve2.Line.IsSmooth = true;
                    teamECurve2.Line.SmoothTension = 1F;
                }
            }
            if (bool1 == false)
            {
                // checking if the check boxes are checked...
                if (checkBox1.Checked == true)
                {
               
                    LineItem teamACurve = myPane.AddCurve("HeartRate",
                          list, Color.Red, SymbolType.None);
                    teamACurve.Line.Width = 2.0F;
                    teamACurve.Line.IsSmooth = true;
                    teamACurve.Line.SmoothTension = 1F;
                }

                if (checkBox4.Checked == true)
                {
                    LineItem teamBCurve = myPane.AddCurve("Speed",
                          list2, Color.Blue, SymbolType.None);
                    teamBCurve.Line.Width = 2.0F;
                    teamBCurve.Line.IsSmooth = true;
                    teamBCurve.Line.SmoothTension = 1F;
                }

                if (checkBox3.Checked == true)
                {
                    LineItem teamcCurve = myPane.AddCurve("Altitude",
                list3, Color.Black, SymbolType.None);
                    teamcCurve.Line.Width = 2.0F;
                    teamcCurve.Line.IsSmooth = true;
                    teamcCurve.Line.SmoothTension = 1F;
                }

                if (checkBox5.Checked == true)
                {
                    LineItem teamdCurve = myPane.AddCurve("Cadence",
                list4, Color.Green, SymbolType.None);
                    teamdCurve.Line.Width = 2.0F;
                    teamdCurve.Line.IsSmooth = true;
                    teamdCurve.Line.SmoothTension = 1F;
                }
                if (checkBox2.Checked == true)
                {
                    LineItem teamECurve = myPane.AddCurve("Power",
                 list5, Color.Orange, SymbolType.None);
                    teamECurve.Line.Width = 4.0F;
                    teamECurve.Line.IsSmooth = true;
                    teamECurve.Line.SmoothTension = 1F;
                }
            }
            //taking the x axis and putting the last value as the max.
            myPane.XAxis.Scale.Max = list.LastOrDefault().X;

            //drawing the graph.
            intervalbox.Text = Convert.ToString(intcounter);
            FindIntervals();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
            dataGridView3.DataSource = dt2;
            bool1 = true;
        }
        public void CompareAnalyse()
        {
            dt3.Columns.Add("File", typeof(string));
            dt3.Columns.Add("Heart Rate (BPM)", typeof(string));
            dt3.Columns.Add("Interval Time (Seconds)", typeof(TimeSpan));
            dt3.Columns.Add("Speed", typeof(string));
            dt3.Columns.Add("Cadence (RPM)", typeof(string));
            dt3.Columns.Add("Altitude (M)", typeof(string));
            dt3.Columns.Add("Power (Watts)", typeof(string));
            //dt3.Columns.Add("Average Cadence", typeof(int));
            //dt3.Columns.Add("Average Altitude", typeof(int));
            //dt3.Columns.Add("Average Power", typeof(int));
            int count = 0;
            if (HeartRateList.Count() < HeartRateListCompare.Count())
            {
                count = HeartRateList.Count();
            }
            else
            {
                count = HeartRateListCompare.Count();
            }
            for (int i = 0; i < count; i++)
            {
                DataRow dr = dt3.NewRow();
                string balance = null;
                byte index = new byte();
                dr["File"] = "File1";
                dr["Heart Rate (BPM)"] = HeartRateList[i];
                dr["Interval Time (Seconds)"] = TimeList[i];
              
                if (SpeedOn)
                {
                    int HRspeed = Convert.ToInt32(SpeedList[i]) / 10;
                    string speedstring = HRspeed.ToString();
                    dr["Speed"] = speedstring;
                }
                if (CadenceOn == true)
                {
                    dr["Cadence (RPM)"] = CadenceList[i];
                }
                if (AltitudeOn == true)
                {
                    dr["Altitude (M)"] = altitudeList[i];
                }
                if (PowerOn == true)
                {
                    dr["Power (Watts)"] = Powerlist[i];
                }
                dt3.Rows.Add(dr);



                dr = dt3.NewRow();

                dr = dt3.NewRow();

                index = new byte();
                dr["File"] = "File2";
                dr["Heart Rate (BPM)"] = HeartRateListCompare[i];
                dr["Interval Time (Seconds)"] = TimeList2[i];
            
                   if (SpeedOn)
                    {
                        int HRspeed = Convert.ToInt32(SpeedListCompare[i]) / 10;

                        string speedstring = HRspeed.ToString();
                        dr["Speed"] = speedstring;
                    }
                if (CadenceOn == true)
                {
                    dr["Cadence (RPM)"] = CadenceListCompare[i];
                }
                if (AltitudeOn == true)
                    {
                   
                        dr["Altitude (M)"] = altitudeListCompare[i];
                    }
                    

                    if (PowerOn == true)
                    {
                        dr["Power (Watts)"] = PowerlistCompare[i];
                    }
                    dt3.Rows.Add(dr);


                dr = dt3.NewRow();

                dr = dt3.NewRow();
                dr["File"] = "+/-";
                int hrcompare1 = Convert.ToInt32((HeartRateList[i]));
                int hrcompare2 = Convert.ToInt32((HeartRateListCompare[i]));
                difference = hrcompare1 - hrcompare2;
                dr["Heart Rate (BPM)"] = difference;

                TimeSpan compaare = TimeList[i];
                TimeSpan compaare2 = TimeList2[i];

               TimeSpan difference2 = compaare - compaare2;
                dr["Interval Time (Seconds)"] = difference2.ToString();


                if(SpeedOn == true)
                {
                    int speedcompare1 = Convert.ToInt32((SpeedList[i]));
                    int speedcompare2 = Convert.ToInt32((SpeedListCompare[i]));

                    difference = speedcompare1 - speedcompare2;

                    dr["Speed"] = difference;
                }

                if (CadenceOn == true)
                {
                    int cadencecompare1 = Convert.ToInt32((CadenceList[i]));
                    int cadencecompare2 = Convert.ToInt32((CadenceListCompare[i]));

                    difference = cadencecompare1 - cadencecompare2;

                    dr["Cadence (RPM)"] = difference;
                }

                if (AltitudeOn == true)
                {
                    int altcompare1 = Convert.ToInt32((altitudeList[i]));
                    int altcompare2 = Convert.ToInt32((altitudeListCompare[i]));

                    difference = altcompare1 - altcompare2;

                    dr["Altitude (M)"] = difference;
                }

                if (PowerOn == true)
                {
                    int Powercompare1 = Convert.ToInt32((Powerlist[i]));
                    int Powerompare2 = Convert.ToInt32((PowerlistCompare[i]));

                    difference = Powercompare1 - Powerompare2;

                    dr["Power (Watts)"] = difference;
                }

                dt3.Rows.Add(dr);
            }


            dataGridView2.DataSource = dt3;

        }

        /// <summary>
        /// this is where the analysiso of the data takes place. also at the end a bool is used to compare data if the bool is true the comparison data is outputted to a datagridview.
        /// </summary>
        public void Analyse()
        {
            //nuke everything...
       
 
            listBox3.Items.Clear();


            //data table columns


            if (bool1 == true && chunkingbool == false && chunkingbool2 == false)
            {
                string[] lines2 = System.IO.File.ReadAllLines(pathglob);

                dt2.Columns.Add("Time", typeof(TimeSpan));
                dt2.Columns.Add("Average HeartRate", typeof(int));
                dt2.Columns.Add("Average Speed", typeof(int));
                dt2.Columns.Add("Average Cadence", typeof(int));
                dt2.Columns.Add("Average Altitude", typeof(int));
                dt2.Columns.Add("Average Power", typeof(int));
                // put the hr data into a list.
                List<String> HRDATA2 = File.ReadLines(pathglob)
                .SkipWhile(line => line != "[HRData]")
                .Skip(1)
                .TakeWhile(line => line != "")
                .ToList();

                listBox1.DataSource = HRDATA2;
                HRDATA2Compare = HRDATA2;
                

                List<String> ParamData2 = File.ReadLines(pathglob)
         .SkipWhile(line => line != "[Params]")
         .Skip(1)
         .TakeWhile(line => line != "")
         .ToList();
                listBox2.DataSource = ParamData2;

                // adding to list box
                listBox3.Items.Add("SMODE VALUES:");
                listBox3.Items.Add("---------------------");
                string[] Splitlength2;
               count = 0;
                TimeSpan time2 = TimeSpan.FromSeconds(count * interval);

                TimeList.Add(time2);
                globaltime2 = time2;
                #region parseparams
                //parsing through param data.
                foreach (var Param in ParamData2)
                {
                    //splitters.
                    splitter = Param.Split('=');
                    Splitlength2 = Param.Split(':');

                    //splitting by each section.
                    if (splitter[0] == "Monitor")
                    {
                        monitortype = splitter[1].ToString();
                    }

                    if (splitter[0] == "Version")
                    {
                        label3.Text = splitter[1].ToString();
                        versionval = Convert.ToInt32(label3.Text);
                    }
                    if (splitter[0] == "SMode")
                    {

                        //working out the smode.
                        label32.Text = splitter[1].ToString();
                        var collection2 = splitter[1].ToString().Select(c => Int32.Parse(c.ToString()));
                        for (int i = 0; i < collection2.Count(); i++)
                        {
                            if (i == 0)
                            {
                                int speed3 = Convert.ToInt32(collection2.ToList()[i]);
                                if (speed3 == 1)
                                {


                                    SpeedOn = true;
                                    listBox3.Items.Add("Speed : 1");
                                }
                                else
                                {
                                    SpeedOn = false;
                                    listBox3.Items.Add("Speed : 0");
                                }
                            }
                            if (i == 1)
                            {
                                if (bool1 == true)
                                {

                                }
                                else
                                {

                                }

                                int cadence2 = Convert.ToInt32(collection2.ToList()[i]);
                                if (cadence2 == 1)
                                {


                                    listBox3.Items.Add("Cadence : 1");
                                    CadenceOn = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Cadence : 0");
                                    CadenceOn = false;
                                }
                            }
                            if (i == 2)
                            {
                                int altitude = Convert.ToInt32(collection2.ToList()[i]);
                                if (altitude == 1)
                                {
                                    listBox3.Items.Add("Altitude : 1");
                                    AltitudeOn = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Altitude : 0");
                                    AltitudeOn = false;
                                }
                            }
                            if (i == 3)
                            {
                                int poweronint = Convert.ToInt32(collection2.ToList()[i]);
                                if (poweronint == 1)
                                {

                                    listBox3.Items.Add("Power : 1");
                                    PowerOn = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Power : 0");
                                    PowerOn = false;
                                }
                            }
                            if (i == 4)
                            {
                                int power2 = Convert.ToInt32(collection2.ToList()[i]);
                                if (power2 == 1)
                                {
                                    //dataGridView1.Columns.Add("Column", "Power Balance & Pedalling Index");

                                    dt.Columns.Add("Power Balancing Left/Right", typeof(string));


                                    listBox3.Items.Add("Power Left/Right Balance : 1");


                                    Power2On = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Power Left/Right Balance : 0");
                                    Power2On = false;
                                }
                            }
                            if (i == 5)
                            {
                                int power3 = Convert.ToInt32(collection2.ToList()[i]);
                                if (power3 == 1)
                                {

                                    dt.Columns.Add("Power Pedalling Index", typeof(int));
                                    //dataGridView1.Columns.Add("Column", "Power Pedalling Index");
                                    listBox3.Items.Add("Power Pedalling Index : 1");
                                    power3on = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Power Pedalling Index : 0");
                                    power3on = false;
                                }
                            }
                            if (i == 6)
                            {
                                int HRCCDATA = Convert.ToInt32(collection2.ToList()[i]);
                                if (HRCCDATA == 1)
                                {
                                    //dataGridView1.Columns.Add("Column", "HR/CC DATA");
                                    listBox3.Items.Add("HR/CC Data : 1");
                                    ccdata = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("HR/CC Data : 0");
                                    ccdata = false;
                                }
                            }
                            if (i == 7)
                            {
                                int USEURO = Convert.ToInt32(collection2.ToList()[i]);
                                if (USEURO == 1)
                                {
                                    //dataGridView1.Columns.Add("Column", "Speed (MPH");
                                    listBox3.Items.Add("US/EURO Unit : 1");
                                    USEUROon = true;
                                }
                                else
                                {
                                    //dataGridView1.Columns.Add("Column", "Speed (KMPH)");
                                    listBox3.Items.Add("US/EURO Unit : 0");
                                    USEUROon = false;
                                }
                            }
                            if (versionval == 107)
                            {
                                if (i == 8)
                                {
                                    int airp = Convert.ToInt32(collection2.ToList()[i]);
                                    if (airp == 1)
                                    {
                                        // dataGridView1.Columns.Add("Column", "Air Pressure");
                                        listBox3.Items.Add("Air Pressure : 1");
                                        AIRPOn = true;
                                    }
                                    else
                                    {
                                        listBox3.Items.Add("Air Pressure : 0");
                                        AIRPOn = false;
                                    }
                                }
                            }
                        }
                    }


                    if (splitter[0] == "MaxHR")
                    {
                        HeartRateData.Text = splitter[1].ToString();
                    }

                    if (splitter[0] == "StartTime")
                    {
                        label5.Text = splitter[1].ToString();
                    }

                    if (splitter[0] == "Length")
                    {
                        label7.Text = splitter[1].ToString();
                        lengthinhours = TimeSpan.Parse(label7.Text);



                    }

                    if (splitter[0] == "Interval")
                    {
                        label11.Text = splitter[1].ToString();
                        interval = Convert.ToInt32(label11.Text);
                    }
                    if (splitter[0] == "Date")
                    {
                        starttime = splitter[1].ToString();

                        DateTime theTime = DateTime.ParseExact(starttime,
                                      "yyyyMMdd",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None);

                        label9.Text = theTime.ToString();
                    }

                }
                #endregion
                //parsing the hrdata.

                for (int i = 0; i < HRDATA2.Count; i++)
                {
                   

                    count2++;
                    string[] splitter = HRDATA2[i].Split('\t');
                    heartrate2 = splitter[0].ToString();
                    HeartRateListCompare.Add(Convert.ToInt32(heartrate2));
                    listCompare.Add(Convert.ToDouble(count2), Convert.ToDouble(heartrate));
                    int columnindex = 1;

                    //creating the timespan.
                    TimeSpan time = TimeSpan.FromSeconds(count2 * interval);

                    TimeList2.Add(time);



                    DataRow dr2 = dt2.NewRow();

                    dr2[0] = time;
                    dr2[1] = heartrate;
                    if (SpeedOn == true)
                    {
                        speed2 = splitter[columnindex].ToString();
                        double SpeedKPH2 = Convert.ToInt32(speed2) / 10;
                        double SpeedMPH2 = SpeedKPH2 / 1.609;
                        if (kmph.Checked == true)
                        {
                            SpeedListCompare.Add(Convert.ToInt32(SpeedKPH2));
                            list2Compare.Add(Convert.ToDouble(count), Convert.ToInt32(SpeedKPH2));
                            label34.Text = "KM/H";
                            label35.Text = "Kilometers";
                            dr2[2] = SpeedKPH2;
                        }
                        else if (mph.Checked == true)
                        {
                            SpeedListCompare.Add(Convert.ToInt32(SpeedMPH2));
                            list2Compare.Add(Convert.ToDouble(count2), SpeedMPH2);
                            label34.Text = "MP/H";
                            label35.Text = "Miles";
                            dr2[2] = SpeedMPH2;
                        }

                        columnindex++;
                    }
                    if (CadenceOn == true)
                    {
                        cadence2 = splitter[columnindex].ToString();
                        CadenceListCompare.Add(Convert.ToInt32(splitter[columnindex]));
                        list4Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(cadence2));
                        columnindex++;
                        dr2[3] = cadence2;

                    }
                    if (AltitudeOn == true)
                    {
                        altitude2 = splitter[columnindex].ToString();

                        if (bool1 == true)
                        {
                            altitudeListCompare.Add(Convert.ToInt32(splitter[columnindex]));
                            list3Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(altitude));
                            columnindex++;
                            dr2[4] = altitude2;

                        }
                        if (PowerOn == true)
                        {
                            power2 = splitter[columnindex].ToString();


                            PowerlistCompare.Add(Convert.ToInt32(splitter[columnindex]));
                            list5Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(power2));

                            columnindex++;
                            dr2[5] = power2;
                        }
                        if (Power2On == true)
                        {
                            string powerbalance2 = splitter[columnindex].ToString();
                            int powerb2 = Convert.ToInt32(powerbalance2);
                            byte[] bytearray = BitConverter.GetBytes(powerb2);
                            pbl2 = bytearray[0];
                            pbr2 = 100 - bytearray[0];
                            pbi2 = bytearray[1];

                            list6Compare.Add(Convert.ToInt32(pbl2));
                            list7Compare.Add(Convert.ToInt32(pbr2));
                            list8Compare.Add(Convert.ToInt32(pbi2));

                            avgpbl = list6Compare.Average();
                            avgpbr = list7Compare.Average();
                            avgpbi = list8Compare.Average();


                            dr2[6] = pbl2 + "/" + pbr2;
                            columnindex++;
                        }
                        if (power3on == true)
                        {
                            dr2[7] = pbi2;
                            columnindex++;
                        }
                        if (ccdata == true)
                        {
                            columnindex++;
                        }
                        if (USEUROon == true)
                        {
                            mph.Checked = true;
                            columnindex++;
                        }

                        if (versionval == 107)
                        {
                            if (AIRPOn == true)
                            {

                            }
                        }
                        CadenceAverage2 = CadenceListCompare.Average();
                        avgpower2 = PowerlistCompare.Average();
                        maxpower2 = PowerlistCompare.Max();
                        maxspeed2 = (SpeedListCompare.Max());
                        speedavg2 = (SpeedListCompare.Average());
                        altmax2 = altitudeListCompare.Max();
                        AltitAVG2 = altitudeListCompare.Average();
                        //if (power3on == true)
                        //{
                        //    power = splitter[columnindex].ToString();
                        //    Powerlist.Add(Convert.ToInt32(splitter[columnindex]));
                        //    list5.Add(Convert.ToDouble(count), Convert.ToDouble(power));
                        //    columnindex++;

                        //}
                        dt2.Rows.Add(dr2);
                    }
                }

            }
          
         
            if (bool1 == false)
            {
                dt.Columns.Add("Time", typeof(TimeSpan));
                dt.Columns.Add("HeartRate", typeof(int));
                dt.Columns.Add("Speed", typeof(int));
                dt.Columns.Add("Cadence", typeof(int));
                dt.Columns.Add("Altitude", typeof(int));
                dt.Columns.Add("Power", typeof(int));
                //string and read all the lines
                string[] lines = System.IO.File.ReadAllLines(pathglob);


                // put the hr data into a list.
                List<String> HRDATA = File.ReadLines(pathglob)
                .SkipWhile(line => line != "[HRData]")
                .Skip(1)
                .TakeWhile(line => line != "")
                .ToList();

                listBox1.DataSource = HRDATA;

                HRDATA1 = HRDATA;


                //put param data into a list.

                List<String> ParamData = File.ReadLines(pathglob)
         .SkipWhile(line => line != "[Params]")
         .Skip(1)
         .TakeWhile(line => line != "")
         .ToList();
                listBox2.DataSource = ParamData;

                // adding to list box
                listBox3.Items.Add("SMODE VALUES:");
                listBox3.Items.Add("---------------------");
                string[] Splitlength;
                count2 = 0;

                #region parseparams
                //parsing through param data.
                foreach (var Param in ParamData)
                {
                    //splitters.


                    splitter = Param.Split('=');
                    Splitlength = Param.Split(':');

                    //splitting by each section.
                    if (splitter[0] == "Monitor")
                    {
                        monitortype = splitter[1].ToString();
                    }

                    if (splitter[0] == "Version")
                    {
                        label3.Text = splitter[1].ToString();
                        versionval = Convert.ToInt32(label3.Text);
                    }
                    if (splitter[0] == "SMode")
                    {

                        //working out the smode.
                        label32.Text = splitter[1].ToString();
                        var collection = splitter[1].ToString().Select(c => Int32.Parse(c.ToString()));
                        for (int i = 0; i < collection.Count(); i++)
                        {
                            if (i == 0)
                            {
                                int speed3 = Convert.ToInt32(collection.ToList()[i]);
                                if (speed3 == 1)
                                {


                                    SpeedOn = true;
                                    listBox3.Items.Add("Speed : 1");
                                }
                                else
                                {
                                    SpeedOn = false;
                                    listBox3.Items.Add("Speed : 0");
                                }
                            }
                            if (i == 1)
                            {
                                if (bool1 == true)
                                {

                                }
                                else
                                {

                                }

                                int cadence = Convert.ToInt32(collection.ToList()[i]);
                                if (cadence == 1)
                                {


                                    listBox3.Items.Add("Cadence : 1");
                                    CadenceOn = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Cadence : 0");
                                    CadenceOn = false;
                                }
                            }
                            if (i == 2)
                            {
                                int altitude = Convert.ToInt32(collection.ToList()[i]);
                                if (altitude == 1)
                                {
                                    listBox3.Items.Add("Altitude : 1");
                                    AltitudeOn = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Altitude : 0");
                                    AltitudeOn = false;
                                }
                            }
                            if (i == 3)
                            {
                                int poweronint = Convert.ToInt32(collection.ToList()[i]);
                                if (poweronint == 1)
                                {

                                    listBox3.Items.Add("Power : 1");
                                    PowerOn = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Power : 0");
                                    PowerOn = false;
                                }
                            }
                            if (i == 4)
                            {
                                int power2 = Convert.ToInt32(collection.ToList()[i]);
                                if (power2 == 1)
                                {
                                    //dataGridView1.Columns.Add("Column", "Power Balance & Pedalling Index");

                                    dt.Columns.Add("Power Balancing Left/Right", typeof(string));


                                    listBox3.Items.Add("Power Left/Right Balance : 1");


                                    Power2On = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Power Left/Right Balance : 0");
                                    Power2On = false;
                                }
                            }
                            if (i == 5)
                            {
                                int power3 = Convert.ToInt32(collection.ToList()[i]);
                                if (power3 == 1)
                                {

                                    dt.Columns.Add("Power Pedalling Index", typeof(int));
                                    //dataGridView1.Columns.Add("Column", "Power Pedalling Index");
                                    listBox3.Items.Add("Power Pedalling Index : 1");
                                    power3on = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("Power Pedalling Index : 0");
                                    power3on = false;
                                }
                            }
                            if (i == 6)
                            {
                                int HRCCDATA = Convert.ToInt32(collection.ToList()[i]);
                                if (HRCCDATA == 1)
                                {
                                    //dataGridView1.Columns.Add("Column", "HR/CC DATA");
                                    listBox3.Items.Add("HR/CC Data : 1");
                                    ccdata = true;
                                }
                                else
                                {
                                    listBox3.Items.Add("HR/CC Data : 0");
                                    ccdata = false;
                                }
                            }
                            if (i == 7)
                            {
                                int USEURO = Convert.ToInt32(collection.ToList()[i]);
                                if (USEURO == 1)
                                {
                                    //dataGridView1.Columns.Add("Column", "Speed (MPH");
                                    listBox3.Items.Add("US/EURO Unit : 1");
                                    USEUROon = true;
                                }
                                else
                                {
                                    //dataGridView1.Columns.Add("Column", "Speed (KMPH)");
                                    listBox3.Items.Add("US/EURO Unit : 0");
                                    USEUROon = false;
                                }
                            }
                            if (versionval == 107)
                            {
                                if (i == 8)
                                {
                                    int airp = Convert.ToInt32(collection.ToList()[i]);
                                    if (airp == 1)
                                    {
                                        // dataGridView1.Columns.Add("Column", "Air Pressure");
                                        listBox3.Items.Add("Air Pressure : 1");
                                        AIRPOn = true;
                                    }
                                    else
                                    {
                                        listBox3.Items.Add("Air Pressure : 0");
                                        AIRPOn = false;
                                    }
                                }
                            }
                        }
                    }


                    if (splitter[0] == "MaxHR")
                    {
                        HeartRateData.Text = splitter[1].ToString();
                    }

                    if (splitter[0] == "StartTime")
                    {
                        label5.Text = splitter[1].ToString();
                    }

                    if (splitter[0] == "Length")
                    {
                        label7.Text = splitter[1].ToString();
                        lengthinhours = TimeSpan.Parse(label7.Text);



                    }

                    if (splitter[0] == "Interval")
                    {
                        label11.Text = splitter[1].ToString();
                        interval = Convert.ToInt32(label11.Text);
                    }
                    if (splitter[0] == "Date")
                    {
                        starttime = splitter[1].ToString();

                        DateTime theTime = DateTime.ParseExact(starttime,
                                      "yyyyMMdd",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None);

                        label9.Text = theTime.ToString();
                    }

                }
                #endregion
                //parsing the hrdata.


                for (int i = 0; i < HRDATA.Count; i++)
                {

                    count++;
                    string[] splitter = HRDATA[i].Split('\t');
                    heartrate = splitter[0].ToString();
                    HeartRateList.Add(Convert.ToInt32(heartrate));
                    list.Add(Convert.ToDouble(count), Convert.ToDouble(heartrate));
                    int columnindex = 1;
               
                    //creating the timespan.
                    TimeSpan time = TimeSpan.FromSeconds(count * interval);

                    TimeList.Add(time);
                    string timeString = time.ToString(@"hh\:mm\:ss");
                    TimeList6.Add(timeString);
                    DataRow dr = dt.NewRow();
                  
                  
                        dr[0] = time;
                    

                    dr[1] = heartrate;
                    if (SpeedOn == true)
                    {
                        speed = splitter[columnindex].ToString();
                        distanceList.Add(Convert.ToInt32(speed) / 3600);

                        double SpeedKPH = Convert.ToInt32(speed) / 10;
                        double SpeedMPH = SpeedKPH / 1.609;

                        if (kmph.Checked == true)
                        {
                            if (bool1 == true)
                            {
                                SpeedListCompare.Add(Convert.ToInt32(SpeedKPH));
                                list2Compare.Add(Convert.ToDouble(count), Convert.ToInt32(SpeedKPH));
                            }
                            else
                            {

                                SpeedList.Add(Convert.ToInt32(SpeedKPH));
                                list2.Add(Convert.ToDouble(count), Convert.ToInt32(SpeedKPH));
                            }

                            label34.Text = "KM/H";
                            label35.Text = "Kilometers";
                            dr[2] = SpeedKPH;
                        }
                        else if (mph.Checked == true)
                        {
                            if (bool1 == true)
                            {
                                SpeedListCompare.Add(Convert.ToInt32(SpeedMPH));
                                list2Compare.Add(Convert.ToDouble(count), SpeedMPH);
                            }
                            else
                            {
                                SpeedList.Add(Convert.ToInt32(SpeedMPH));
                                list2.Add(Convert.ToDouble(count), SpeedMPH);
                            }
                            label34.Text = "MP/H";
                            label35.Text = "Miles";
                            dr[2] = SpeedMPH;
                        }

                        columnindex++;
                    }
                    if (CadenceOn == true)
                    {

                        cadence = splitter[columnindex].ToString();

                        if (bool1 == true)
                        {
                            CadenceListCompare.Add(Convert.ToInt32(splitter[columnindex]));
                            list4Compare.Add(Convert.ToDouble(count), Convert.ToDouble(cadence));

                        }
                        else
                        {
                            CadenceList.Add(Convert.ToInt32(splitter[columnindex]));
                            list4.Add(Convert.ToDouble(count), Convert.ToDouble(cadence));

                        }


                        columnindex++;
                        dr[3] = cadence;

                    }
                    if (AltitudeOn == true)
                    {
                        altitude = splitter[columnindex].ToString();

                        if (bool1 == true)
                        {
                            altitudeListCompare.Add(Convert.ToInt32(splitter[columnindex]));
                            list3Compare.Add(Convert.ToDouble(count), Convert.ToDouble(altitude));

                        }
                        else
                        {
                            altitudeList.Add(Convert.ToInt32(splitter[columnindex]));
                            list3.Add(Convert.ToDouble(count), Convert.ToDouble(altitude));
                        }


                        columnindex++;
                        dr[4] = altitude;

                    }
                    if (PowerOn == true)
                    {
                        power = splitter[columnindex].ToString();


                        if (bool1 == true)
                        {
                            PowerlistCompare.Add(Convert.ToInt32(splitter[columnindex]));
                            list5Compare.Add(Convert.ToDouble(count), Convert.ToDouble(power));
                        }
                        else
                        {
                            Powerlist.Add(Convert.ToInt32(splitter[columnindex]));
                            list5.Add(Convert.ToDouble(count), Convert.ToDouble(power));
                        }
                        columnindex++;
                        dr[5] = power;
                    }
                    if (Power2On == true)
                    {
                        string powerbalance = splitter[columnindex].ToString();
                        powerb = Convert.ToInt32(powerbalance);
                        byte[] bytearray = BitConverter.GetBytes(powerb);
                        pbl = bytearray[0];
                        pbr = 100 - bytearray[0];
                        pbi = bytearray[1];

                   
                            list6.Add(Convert.ToInt32(pbl));
                            list7.Add(Convert.ToInt32(pbr));
                            list8.Add(Convert.ToInt32(pbi));

                        avgpbl = list6.Average();
                        avgpbr = list7.Average();
                        avgpbi = list8.Average();


                        dr[6] = pbl + "/" + pbr;
                        columnindex++;
                    }
                    if (power3on == true)
                    {
                        dr[7] = pbi;
                        columnindex++;
                    }
                    if (ccdata == true)
                    {
                        columnindex++;
                    }
                    if (USEUROon == true)
                    {
                        mph.Checked = true;
                        columnindex++;
                    }

                    if (versionval == 107)
                    {
                        if (AIRPOn == true)
                        {

                        }
                    }

                    //if (power3on == true)
                    //{
                    //    power = splitter[columnindex].ToString();
                    //    Powerlist.Add(Convert.ToInt32(splitter[columnindex]));
                    //    list5.Add(Convert.ToDouble(count), Convert.ToDouble(power));
                    //    columnindex++;

                    //}
                    dt.Rows.Add(dr);
                }
                CadenceAverage = CadenceList.Average();
                avgpower = Powerlist.Average();
                maxpower = Powerlist.Max();
                maxspeed = (SpeedList.Max());
                speedavg = (SpeedList.Average());
                altmax = altitudeList.Max();
                AltitAVG = altitudeList.Average();
            }

            if (chunkingbool == true)
            {

                for (int i = 0; i < numberofchunks; i++)
                {


                    count2++;
                    string[] splitter = HRDATA2[i].Split('\t');
                    heartrate2 = splitter[0].ToString();
                    HeartRateListChunk.Add(Convert.ToInt32(heartrate2));
                    listCompare.Add(Convert.ToDouble(count2), Convert.ToDouble(heartrate));
                    int columnindex = 1;

                    //creating the timespan.
                    TimeSpan time = TimeSpan.FromSeconds(count2 * interval);

                    TimeList2.Add(time);





                    if (SpeedOn == true)
                    {
                        speed2 = splitter[columnindex].ToString();
                        double SpeedKPH2 = Convert.ToInt32(speed2) / 10;
                        double SpeedMPH2 = SpeedKPH2 / 1.609;
                        if (kmph.Checked == true)
                        {
                            SpeedListChunk.Add(Convert.ToInt32(SpeedKPH2));
                            list2Compare.Add(Convert.ToDouble(count), Convert.ToInt32(SpeedKPH2));
                            label34.Text = "KM/H";
                            label35.Text = "Kilometers";

                        }
                        else if (mph.Checked == true)
                        {
                            SpeedListChunk.Add(Convert.ToInt32(SpeedMPH2));
                            list2Compare.Add(Convert.ToDouble(count2), SpeedMPH2);
                            label34.Text = "MP/H";
                            label35.Text = "Miles";

                        }

                        columnindex++;
                    }
                    if (CadenceOn == true)
                    {
                        cadence2 = splitter[columnindex].ToString();
                        CadenceListChunk.Add(Convert.ToInt32(splitter[columnindex]));
                        list4Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(cadence2));
                        columnindex++;


                    }
                    if (AltitudeOn == true)
                    {
                        altitude2 = splitter[columnindex].ToString();

                        if (bool1 == true)
                        {
                            altitudeListChunk.Add(Convert.ToInt32(splitter[columnindex]));
                            list3Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(altitude));
                            columnindex++;


                        }
                        if (PowerOn == true)
                        {
                            power2 = splitter[columnindex].ToString();


                            PowerlistChunk.Add(Convert.ToInt32(splitter[columnindex]));
                            list5Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(power2));

                            columnindex++;

                        }
                        if (Power2On == true)
                        {
                            string powerbalance2 = splitter[columnindex].ToString();
                            int powerb2 = Convert.ToInt32(powerbalance2);
                            byte[] bytearray = BitConverter.GetBytes(powerb2);
                            pbl2 = bytearray[0];
                            pbr2 = 100 - bytearray[0];
                            pbi2 = bytearray[1];

                            list6Compare.Add(Convert.ToInt32(pbl2));
                            list7Compare.Add(Convert.ToInt32(pbr2));
                            list8Compare.Add(Convert.ToInt32(pbi2));

                            avgpbl = list6Compare.Average();
                            avgpbr = list7Compare.Average();
                            avgpbi = list8Compare.Average();



                            columnindex++;
                        }
                        if (power3on == true)
                        {

                            columnindex++;
                        }
                        if (ccdata == true)
                        {
                            columnindex++;
                        }
                        if (USEUROon == true)
                        {
                            mph.Checked = true;
                            columnindex++;
                        }

                        if (versionval == 107)
                        {
                            if (AIRPOn == true)
                            {

                            }
                        }

                        //if (power3on == true)
                        //{
                        //    power = splitter[columnindex].ToString();
                        //    Powerlist.Add(Convert.ToInt32(splitter[columnindex]));
                        //    list5.Add(Convert.ToDouble(count), Convert.ToDouble(power));
                        //    columnindex++;

                        //}


                    }

                }
                DataRow dr4 = dt4.NewRow();

                dr4["Number of Chunks"] = "Chunk =" + Convert.ToInt32(count);
                dr4["Average HeartRate"] = HeartRateListChunk.Average();
                dr4["Average Speed"] = SpeedListChunk.Average();
                dr4["Average Cadence"] = CadenceListChunk.Average();
                dr4["Average Altitude"] = altitudeListChunk.Average();
                dr4["Average Power"] = PowerlistChunk.Average();



                dt4.Rows.Add(dr4);
                chunkingbool = false;
            }

            int comparisonHr = 0;
            int comparisonspeed = 0;
            int comparisonaltit = 0;
            int comparisonpower = 0;
            int comparisoncad = 0;

            if (chunkingbool2 == true )
            {

                for (int i = 0; i < numberofchunks; i++)
                {


                    count2++;
                    string[] splitter = HRDATA2[i].Split('\t');
                    heartrate2 = splitter[0].ToString();
                    HeartRateListChunk2.Add(Convert.ToInt32(heartrate2));
                    listCompare.Add(Convert.ToDouble(count2), Convert.ToDouble(heartrate));
                    int columnindex = 1;

                    //creating the timespan.
                    TimeSpan time = TimeSpan.FromSeconds(count2 * interval);

                    TimeList2.Add(time);





                    if (SpeedOn == true)
                    {
                        speed2 = splitter[columnindex].ToString();
                        double SpeedKPH2 = Convert.ToInt32(speed2) / 10;
                        double SpeedMPH2 = SpeedKPH2 / 1.609;
                        if (kmph.Checked == true)
                        {
                            SpeedListChunk2.Add(Convert.ToInt32(SpeedKPH2));
                            list2Compare.Add(Convert.ToDouble(count), Convert.ToInt32(SpeedKPH2));
                            label34.Text = "KM/H";
                            label35.Text = "Kilometers";

                        }
                        else if (mph.Checked == true)
                        {
                            SpeedListChunk2.Add(Convert.ToInt32(SpeedMPH2));
                            list2Compare.Add(Convert.ToDouble(count2), SpeedMPH2);
                            label34.Text = "MP/H";
                            label35.Text = "Miles";

                        }

                        columnindex++;
                    }
                    if (CadenceOn == true)
                    {
                        cadence2 = splitter[columnindex].ToString();
                        CadenceListChunk2.Add(Convert.ToInt32(splitter[columnindex]));
                        list4Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(cadence2));
                        columnindex++;


                    }
                    if (AltitudeOn == true)
                    {
                        altitude2 = splitter[columnindex].ToString();

                        if (bool1 == true)
                        {
                            altitudeListChunk2.Add(Convert.ToInt32(splitter[columnindex]));
                            list3Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(altitude));
                            columnindex++;


                        }
                        if (PowerOn == true)
                        {
                            power2 = splitter[columnindex].ToString();


                            PowerlistChunk2.Add(Convert.ToInt32(splitter[columnindex]));
                            list5Compare.Add(Convert.ToDouble(count2), Convert.ToDouble(power2));

                            columnindex++;

                        }
                        if (Power2On == true)
                        {
                            string powerbalance2 = splitter[columnindex].ToString();
                            int powerb2 = Convert.ToInt32(powerbalance2);
                            byte[] bytearray = BitConverter.GetBytes(powerb2);
                            pbl2 = bytearray[0];
                            pbr2 = 100 - bytearray[0];
                            pbi2 = bytearray[1];

                            list6Compare.Add(Convert.ToInt32(pbl2));
                            list7Compare.Add(Convert.ToInt32(pbr2));
                            list8Compare.Add(Convert.ToInt32(pbi2));

                            avgpbl = list6Compare.Average();
                            avgpbr = list7Compare.Average();
                            avgpbi = list8Compare.Average();



                            columnindex++;
                        }
                        if (power3on == true)
                        {

                            columnindex++;
                        }
                        if (ccdata == true)
                        {
                            columnindex++;
                        }
                        if (USEUROon == true)
                        {
                            mph.Checked = true;
                            columnindex++;
                        }

                        if (versionval == 107)
                        {
                            if (AIRPOn == true)
                            {

                            }
                        }

                        //if (power3on == true)
                        //{
                        //    power = splitter[columnindex].ToString();
                        //    Powerlist.Add(Convert.ToInt32(splitter[columnindex]));
                        //    list5.Add(Convert.ToDouble(count), Convert.ToDouble(power));
                        //    columnindex++;

                        //}


                    }

                }
                DataRow dr5 = dt5.NewRow();

                dr5["Number of Chunks"] = "Chunk =" + Convert.ToInt32(count);
                dr5["Average HeartRate"] = HeartRateListChunk2.Average();
                comparisonHr = Convert.ToInt32(HeartRateListChunk2.Average());
                dr5["Average Speed"] = SpeedListChunk2.Average();
                comparisonspeed = Convert.ToInt32(SpeedListChunk2.Average());
                dr5["Average Cadence"] = CadenceListChunk2.Average();
                comparisoncad = Convert.ToInt32(CadenceListChunk2.Average());
                dr5["Average Altitude"] = altitudeListChunk2.Average();
                comparisonaltit = Convert.ToInt32(altitudeListChunk2.Average());
                dr5["Average Power"] = PowerlistChunk2.Average();
                comparisonpower = Convert.ToInt32(PowerlistChunk2.Average());


                dt5.Rows.Add(dr5);



                //DataGridViewRow rowOriginalFile = dataGridView4.Rows[i];



            }

            HeartRateList2 = HeartRateList;
            SpeedList2 = SpeedList;
            CadenceList2 = CadenceList;
            altitudeList2 = altitudeList;
            Powerlist2 = Powerlist;

            HeartRateListCompare2 = HeartRateListCompare;
            SpeedListCompare2 = SpeedListCompare;
            CadenceListCompare2 = CadenceListCompare;
            altitudeListCompare2 = altitudeListCompare;
            PowerlistCompare2 = PowerlistCompare;
            TimeList3 = TimeList;
            TimeList4 = TimeList2;
        
            sumcalcs();
           
            if (chunkingbool == false && chunkingbool2 == false)
            {
                LoadGraph();
            }

            if (chunkingbool2 == true)
            {
                int currentRow = count;
                DataGridViewRow firstRow = dataGridView4.Rows[currentRow - 1];


                int hrDif = (Convert.ToInt32(firstRow.Cells[1].Value)) - comparisonHr;
                int Speeddif = (Convert.ToInt32(firstRow.Cells[1].Value)) - comparisonspeed;

                int cadencedif = (Convert.ToInt32(firstRow.Cells[1].Value)) - comparisoncad;
                int altitudedif = (Convert.ToInt32(firstRow.Cells[1].Value)) - comparisonaltit;
                int powerdif = (Convert.ToInt32(firstRow.Cells[1].Value)) - comparisonpower;
                DataRow dr5 = dt5.NewRow();

                dr5["Number of Chunks"] = "Dif";
                dr5["Average HeartRate"] = hrDif;
                dr5["Average Speed"] = Speeddif;
                dr5["Average Cadence"] = cadencedif;
                dr5["Average Altitude"] = altitudedif;
                dr5["Average Power"] = powerdif;

                dt5.Rows.Add(dr5);
            }

        }

        /// <summary>
        ///  chunking of the first file happens here.
        /// </summary>
        private void chunking()
        {
            altitudeListChunk.Clear();
            HeartRateListChunk.Clear();
            PowerlistChunk.Clear();
            CadenceListChunk.Clear();
            altitudeListChunk.Clear();



            dt4.Clear();
            dt4.Columns.Clear();
            count = 0;
            DataRow dr = dt4.NewRow();
            numberofchunks = Convert.ToInt32(numericUpDown3.Value);
            int numberofrecords = HRDATA1.Count;
            numberofrecords -= (numberofrecords % numberofchunks);
            int difference = numberofrecords / numberofchunks;
            List<List<string>> Chunks = new List<List<string>>();


            dt4.Columns.Add("Number of Chunks", typeof(string));
            dt4.Columns.Add("Average HeartRate", typeof(int));
            dt4.Columns.Add("Average Speed", typeof(int));
            dt4.Columns.Add("Average Cadence", typeof(int));
            dt4.Columns.Add("Average Altitude", typeof(int));
            dt4.Columns.Add("Average Power", typeof(int));


            for (int i = 0; i < numberofrecords; i += difference)
            {
                List<string> currentchunk = new List<string>();
                for (int j = i; j < i + difference; j++)
                {
                    currentchunk.Add(HRDATA1[j]);
                }
                Chunks.Add(currentchunk);
            }

            List<List<string>> data = new List<List<string>>();

            foreach (var chunk in Chunks)
            {

                count++;
                Console.WriteLine(count);
                chunkingbool = true;
                data.Add(chunk);
                HRDATA2 = chunk;
                Analyse();

            }

            dataGridView4.DataSource = dt4;
            chunkingbool = false;
        }
        /// <summary>
        /// chunking of second file.
        /// </summary>
        private void chunking2() { 
            altitudeListChunk2.Clear();
            HeartRateListChunk2.Clear();
            PowerlistChunk2.Clear();
            CadenceListChunk2.Clear();
            altitudeListChunk2.Clear();


            if (HeartRateListCompare.Count > 0)
            {

                dt5.Clear();
                dt5.Columns.Clear();
                count = 0;
                DataRow dr2 = dt5.NewRow();
                numberofchunks = Convert.ToInt32(numericUpDown3.Value);
                int numberofrecords = HRDATA2Compare.Count;
                numberofrecords -= (numberofrecords % numberofchunks);
                int difference = numberofrecords / numberofchunks;
                List<List<string>> Chunks = new List<List<string>>();


                dt5.Columns.Add("Number of Chunks", typeof(string));
                dt5.Columns.Add("Average HeartRate", typeof(int));
                dt5.Columns.Add("Average Speed", typeof(int));
                dt5.Columns.Add("Average Cadence", typeof(int));
                dt5.Columns.Add("Average Altitude", typeof(int));
                dt5.Columns.Add("Average Power", typeof(int));


                for (int i = 0; i < numberofrecords; i += difference)
                {
                    List<string> currentchunk = new List<string>();
                    for (int j = i; j < i + difference; j++)
                    {
                        currentchunk.Add(HRDATA2Compare[j]);
                    }
                    Chunks.Add(currentchunk);
                }

                List<List<string>> data2 = new List<List<string>>();

                foreach (var chunk in Chunks)
                {

                    count++;
                    Console.WriteLine(count);
                    chunkingbool2 = true;
                    data.Add(chunk);
                    HRDATA2 = chunk;
                    Analyse();

                }

                dataGridView5.DataSource = dt5;
                chunkingbool2 = false;
            }
        }

        /// <summary>
        /// summary of the calculations outputs into textboxes and averages.
        /// </summary>
        private void sumcalcs()
            {


            try
            {
                if (HeartRateListCompare.Count > 0 )
                {

                    maxhr2 = HeartRateListCompare.Max();
                    minhr2 = HeartRateListCompare.Min();
                    avghr2 = HeartRateListCompare.Average();

                    AltitAVG2 = altitudeListCompare.Average();
                    altmax2 = altitudeListCompare.Max();

                    maxpower2 = PowerlistCompare.Max();
                    avgpower2 = PowerlistCompare.Average();

                    CadenceAverage2 = CadenceListCompare.Average();
                    decimal Cadencemax2 = CadenceListCompare.Max();


                    label78.Text = Convert.ToString(Math.Round(CadenceAverage2));
                    label76.Text = Convert.ToString(Math.Round(Cadencemax2));
                    label89.Text = minhr2.ToString();
                    label90.Text = maxhr2.ToString();
                    label91.Text = avghr2.ToString();
                    label80.Text = Convert.ToString(Math.Round(altmax2));
                    label82.Text = Convert.ToString(Math.Round(AltitAVG2));
                    label85.Text = Convert.ToString(Math.Round(maxpower2));
                    label87.Text = Convert.ToString(Math.Round(avgpower2));
                    PBLeft.Text = Convert.ToString(Math.Round(Convert.ToDecimal(avgpbl2)));
                    PBRight.Text = Convert.ToString(Math.Round(Convert.ToDecimal(avgpbr2)));
                    PILabel.Text = Convert.ToString(Math.Round(Convert.ToDecimal(avgpbi2)));
                    Decimal HRaverage3 = Math.Round(Convert.ToDecimal(avghr));
                    Decimal speedavg3 = Math.Round(Convert.ToDecimal(speedavg));
                    Decimal AltitAVG3 = Math.Round(Convert.ToDecimal(AltitAVG));
                    double hours2 = lengthinhours.TotalHours;
                    minutes = lengthinhours.TotalMinutes;
                    FullLengthInSecs = lengthinhours.TotalSeconds;
                    totalDistance = Convert.ToDecimal(speedavg) * Convert.ToDecimal(hours2);
                    label31.Text = Convert.ToString(Math.Round(totalDistance));
                    label18.Text = Convert.ToString(HRaverage3);
                    label19.Text = Convert.ToString(AltitAVG3);
                    label20.Text = Convert.ToString(speedavg3);
                    label21.Text = Convert.ToString(Math.Round(maxhr));
                    label22.Text = Convert.ToString(Math.Round(minhr));
                    label23.Text = Convert.ToString(Math.Round(maxspeed));
                    label25.Text = Convert.ToString(Math.Round(avgpower));
                    label26.Text = Convert.ToString(Math.Round(maxpower));
                    label28.Text = Convert.ToString(Math.Round(altmax));
                }


               if (HeartRateList.Count > 0) { 
                    //getting max heart rate.
                    maxhr = HeartRateList.Max();
                  
                    avghr = HeartRateList.Average();
                     minhr = HeartRateList.Min();

                    maxpower = Powerlist.Max();
                    avgpower = Powerlist.Average();

                    altmax = altitudeList.Max();
                    AltitAVG = altitudeList.Average();

                    CadenceAverage = CadenceList.Average();
                    decimal Cadencemax = CadenceList.Max();

                    //doing the calculations.
                    label74.Text = Convert.ToString(Math.Round(CadenceAverage));
                    label72.Text = Convert.ToString(Math.Round(Cadencemax));
                    label63.Text = Convert.ToString(Math.Round(maxpower));
                    label65.Text = Convert.ToString(Math.Round(avgpower));
                    label68.Text = Convert.ToString(Math.Round(altmax));
                    label70.Text = Convert.ToString(Math.Round(AltitAVG));
                    label57.Text = minhr.ToString();
                    label58.Text = maxhr.ToString();
                    label59.Text = avghr.ToString();
                    PBLeft.Text = Convert.ToString(Math.Round(Convert.ToDecimal(avgpbl)));
                    PBRight.Text = Convert.ToString(Math.Round(Convert.ToDecimal(avgpbr)));
                    PILabel.Text = Convert.ToString(Math.Round(Convert.ToDecimal(avgpbi)));
                    Decimal HRaverage2 = Math.Round(Convert.ToDecimal(avghr));
                    Decimal speedavg2 = Math.Round(Convert.ToDecimal(speedavg));
                    Decimal AltitAVG2 = Math.Round(Convert.ToDecimal(AltitAVG));
                    double hours = lengthinhours.TotalHours;
                    minutes = lengthinhours.TotalMinutes;
                    FullLengthInSecs = lengthinhours.TotalSeconds;
                    totalDistance = Convert.ToDecimal(speedavg) * Convert.ToDecimal(hours);
                    label31.Text = Convert.ToString(Math.Round(totalDistance));
                    label18.Text = Convert.ToString(HRaverage2);
                    label19.Text = Convert.ToString(AltitAVG2);
                    label20.Text = Convert.ToString(speedavg2);
                    label21.Text = Convert.ToString(Math.Round(maxhr));
                    label22.Text = Convert.ToString(Math.Round(minhr));
                    label23.Text = Convert.ToString(Math.Round(maxspeed));
                    label25.Text = Convert.ToString(Math.Round(avgpower));
                    label26.Text = Convert.ToString(Math.Round(maxpower));
                    label28.Text = Convert.ToString(Math.Round(altmax));
                    //monitors values to get the model.
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                int Monitorval = Convert.ToInt32(monitortype);
                if (Monitorval == 1) { label37.Text = "Model: " + "Polar Sport Tester / Vantage XL"; }
                if (Monitorval == 2) { label37.Text = "Model: " + "Polar Vantage NV (VNV)"; }
                if (Monitorval == 3) { label37.Text = "Model: " + "Polar Accurex Plus"; }
                if (Monitorval == 4) { label37.Text = "Model: " + "Polar XTrainer Plus"; }
                if (Monitorval == 6) { label37.Text = "Model: " + "Polar S520"; }
                if (Monitorval == 7) { label37.Text = "Model: " + "Polar Coach"; }
                if (Monitorval == 8) { label37.Text = "Model: " + "Polar S210"; }
                if (Monitorval == 9) { label37.Text = "Model: " + "Polar S410"; }
                if (Monitorval == 10) { label37.Text = "Model: " + "Polar S610 / S610i"; }
                if (Monitorval == 12) { label37.Text = "Model: " + "Polar S710 / S710i / S720i"; }
                if (Monitorval == 13) { label37.Text = "Model: " + "Polar S810 / S810i"; }
                if (Monitorval == 15) { label37.Text = "Model: " + "Polar E600"; }
                if (Monitorval == 20) { label37.Text = "Model: " + "Polar AXN500"; }
                if (Monitorval == 21) { label37.Text = "Model: " + "Polar AXN700"; }
                if (Monitorval == 22) { label37.Text = "Model: " + "Polar S625X / S725X"; }
                if (Monitorval == 23) { label37.Text = "Model: " + "Polar S725"; }
                if (Monitorval == 33) { label37.Text = "Model: " + "Polar CS400"; }
                if (Monitorval == 34) { label37.Text = "Model: " + "Polar CS600X"; }
                if (Monitorval == 35) { label37.Text = "Model: " + "Polar CS600"; }
                if (Monitorval == 36) { label37.Text = "Model: " + "Polar RS400"; }
                if (Monitorval == 37) { label37.Text = "Model: " + "Polar RS800"; }
                if (Monitorval == 38) { label37.Text = "Model: " + "Polar RS800X"; }

            }
        /// <summary>
        /// creates the normalised power.
        /// </summary>
            public void getNP()
            {
               int value = Powerlist.Count();
                // movAvgCount = value;
                //  MessageBox.Show(value.ToString());

                for (int x = 0; x < value; x++)
                {
                    double movingAverage30 = 0;
                    for (int j = 0; j < 30; j++)
                    {
                        int index = x + j;
                        index %= value;
                        movingAverage30 += Convert.ToDouble(Powerlist[index]);
                    }

                    movingAverage30 /= 30;

                    double movAvgPow = Math.Pow(movingAverage30, 4);
                    movAvgPow4.Add(movAvgPow);
                    movAvg.Add(movingAverage30);

                }
                movAvgCount = movAvgPow4.Count();
                if (movAvgPow4 != null)
                {
                    double movAvgPow4Sum = movAvgPow4.Sum();
                    double power = movAvgPow4Sum / movAvgCount;
                    double normalizationPower = Math.Round(Math.Pow(power, 1.0 / 4), 2);
                    double movingAverageSum = movAvg.Sum();
                    double movingAverageValue = movingAverageSum / movAvgCount; // moving average value 
                    labelnp.Visible = true;                                         // movingAverageGlobal = movingAverageValue;  
                    labelnp.Text = normalizationPower.ToString();
                    // ftp value 
                    double ftpData = Convert.ToDouble(ftpbox.Text);

                    double ifGlobal = normalizationPower / ftpData;
                    labelif.Visible = true;
                    labelif.Text = ifGlobal.ToString();

                    // for tss 



                    double tssGlobalOne = normalizationPower * ifGlobal * FullLengthInSecs; // sec value left  
                    double tssGlobalTwo = ftpData * 3600;
                    double tssGlobalThree = tssGlobalOne / tssGlobalTwo;
                    double tssGlobalFour = tssGlobalThree * 100;
                    double tssGlobal = tssGlobalFour;
                    labeltss.Visible = true;
                    labeltss.Text = tssGlobal.ToString();
                }
            }
        /// <summary>
        /// loads the zed graph.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void zedGraphControl1_Load(object sender, EventArgs e)
            {

            }
        /// <summary>
        /// opening the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void button1_Click(object sender, EventArgs e)
            {
                //opening the file.
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Open Text File";
                theDialog.Filter = "HRM files (*.HRM)|*.HRM|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                theDialog.InitialDirectory = @"C:\";
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = theDialog.FileName;
                    pathglob = path;
                    Analyse();

                }

            }

    
        /// <summary>
        /// turning off and on graph proeprties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

                Analyse();
            }
        
            /// <summary>
            /// changing the metrics to KMP/h
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void kmph_CheckedChanged(object sender, EventArgs e)
            {
                dt.Clear();
                Analyse();
            }
            /// <summary>
            /// changing the metrics to mph
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void mph_CheckedChanged(object sender, EventArgs e)
            {
                dt.Clear();
                Analyse();
            }

            private void checkBox2_CheckedChanged(object sender, EventArgs e)
            {
                LoadGraph();
            }

            private void checkBox3_CheckedChanged(object sender, EventArgs e)
            {
                LoadGraph();
            }

            private void checkBox4_CheckedChanged(object sender, EventArgs e)
            {
                LoadGraph();
            }

            private void checkBox5_CheckedChanged(object sender, EventArgs e)
            {
                LoadGraph();
            }
            /// <summary>
            /// numeric up down used for ftp
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {

                //calculations for the hr avg
                double HRavgPERCENT = Math.Round(HRaverage / (Convert.ToDouble(numericUpDown1.Value)) * 100, 2);
                double HRMINPERCENT = Math.Round(minhr / (Convert.ToDouble(numericUpDown1.Value)) * 100, 2);
                double HRmaxPERCENT = Math.Round(maxhr / (Convert.ToDouble(numericUpDown1.Value)) * 100, 2);
                label41.Text = HRavgPERCENT.ToString() + "%";
                label42.Text = HRmaxPERCENT.ToString() + "%";
                label43.Text = HRMINPERCENT.ToString() + "%";
            }

            double xaxismax;
            double yaxismax;

            double yaxismin;
            double xaxismin;
        /// <summary>
        /// gets the y and x axis max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
            private bool zedGraphControl1_MouseDownEvent(ZedGraphControl sender, MouseEventArgs e)
            {
                yaxismax = sender.GraphPane.XAxis.Scale.Max;
                xaxismax = sender.GraphPane.YAxis.Scale.Max;

                yaxismin = sender.GraphPane.YAxis.Scale.Min;
                yaxismin = sender.GraphPane.XAxis.Scale.Min;

                zoomin = true;


                return false;
            }
        /// <summary>
        /// this is how the averages are recreated the params old state and new state are used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="oldState"></param>
        /// <param name="newState"></param>
            private void zedGraphControl1_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
            {
        

                startpoint = (int)sender.GraphPane.XAxis.Scale.Min;
                endpoint = (int)sender.GraphPane.XAxis.Scale.Max;

                difference = endpoint - startpoint;
            

            if (HeartRateList2.Count > startpoint && HeartRateList2.Count >= endpoint)
                {
                    zoomin = true;
                    List<int> HRLIST = HeartRateList2.ToList();
                    List<int> updateheartrate;
                    if (startpoint < 0)
                    {
                        startpoint = System.Math.Abs(startpoint);
                    }
                    updateheartrate = HRLIST.GetRange(startpoint, difference);
                    HeartRateList = updateheartrate.ToList();
                    if (SpeedOn)
                    {
                        List<int> speedlist = SpeedList2.ToList();
                        List<int> speedupdate;
                        speedupdate = speedlist.GetRange(startpoint, difference);
                        SpeedList = speedupdate.ToList();
                    }


                    if (AltitudeOn)
                    {
                        List<int> altlist = altitudeList2.ToList();
                        List<int> altupdate;
                        altupdate = altlist.GetRange(startpoint, difference);
                        altitudeList = altupdate.ToList();
                    }



                    if (CadenceOn)
                    {
                        List<int> cadencelist = CadenceList2.ToList();
                        List<int> cadenceupdate;
                        cadenceupdate = cadencelist.GetRange(startpoint, difference);
                        CadenceList = cadenceupdate.ToList();
                    }



                    if (PowerOn)
                    {
                        List<int> powerlist = Powerlist2.ToList();
                        List<int> powerupdate;
                        powerupdate = powerlist.GetRange(startpoint, difference);
                        Powerlist = powerupdate.ToList();
                    }
                }


            if (HeartRateListCompare2.Count > startpoint && HeartRateListCompare2.Count >= endpoint)
            {
                zoomin = true;
                List<int> HRLIST = HeartRateListCompare2.ToList();
                List<int> updateheartrate;
                if (startpoint < 0)
                {
                    startpoint = System.Math.Abs(startpoint);
                }

                updateheartrate = HRLIST.GetRange(startpoint, difference);
                HeartRateListCompare = updateheartrate.ToList();
                if (SpeedOn)
                {
                    List<int> speedlist = SpeedListCompare2.ToList();
                    List<int> speedupdate;
                    speedupdate = speedlist.GetRange(startpoint, difference);
                    SpeedListCompare = speedupdate.ToList();
                }


                if (AltitudeOn)
                {
                    List<int> altlist = altitudeListCompare2.ToList();
                    List<int> altupdate;
                    altupdate = altlist.GetRange(startpoint, difference);
                    altitudeListCompare = altupdate.ToList();
                }



                if (CadenceOn)
                {
                    List<int> cadencelist = CadenceListCompare2.ToList();
                    List<int> cadenceupdate;
                    cadenceupdate = cadencelist.GetRange(startpoint, difference);
                    CadenceListCompare = cadenceupdate.ToList();
                }



                if (PowerOn)
                {
                    List<int> powerlist = PowerlistCompare2.ToList();
                    List<int> powerupdate;
                    powerupdate = powerlist.GetRange(startpoint, difference);
                    PowerlistCompare = powerupdate.ToList();
                }
            }
         

            sumcalcs();
            }
        /// <summary>
        /// this is used in the chunking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void numericUpDown3_ValueChanged(object sender, EventArgs e)
            {

            }
        /// <summary>
        /// compare analysis button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void button4_Click(object sender, EventArgs e)
            {

            // Split(HeartRateList, (int) numericUpDown3.Value);
            CompareAnalyse();

            }

            private void checkBox7_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox7.Checked == true)
                {
                    dataGridView2.Visible = true;
          
                zedGraphControl1.Visible = false ;
                dataGridView3.Visible = false;
                }
                else
                {
                dataGridView3.Visible = false;
                dataGridView2.Visible = false;
                zedGraphControl1.Visible = true;
            }
            }
        /// <summary>
        ///  this is the point value comparison method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pane"></param>
        /// <param name="curve"></param>
        /// <param name="iPt"></param>
        /// <returns></returns>
        private string ZedGraphControl1_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {

            string tooltip = null;
            if (curve.Label.Text == "Altitude2")
            {
                if (curve.NPts > iPt)
                {

                    if (list5Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Altitude")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Altitude /" + cve[iPt].Y + "Altitude " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Altitude");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Altitude");
                    }




                }

            }
            if (curve.Label.Text == "Altitude")
            {
                if (curve.NPts > iPt)
                {

                    if (list5Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Altitude2")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Altitude /" + cve[iPt].Y + "Altitude " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Altitude");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Altitude");
                    }




                }

            }
            if (curve.Label.Text == "Speed")
            {
                if (curve.NPts > iPt)
                {

                    if (list4Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Speed2")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Speed /" + cve[iPt].Y + "Speed " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Speed");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Speed");
                    }




                }

            }
            if (curve.Label.Text == "Speed2")
            {
                if (curve.NPts > iPt)
                {

                    if (list4Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Speed")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Speed /" + cve[iPt].Y + "Speed " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Speed");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Speed");
                    }




                }

            }
            if (curve.Label.Text == "Power")
            {
                if (curve.NPts > iPt)
                {

                    if (list3Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Power2")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Power /" + cve[iPt].Y + "Power " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Power");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Power");
                    }




                }

            }
            if (curve.Label.Text == "Power2")
            {
                if (curve.NPts > iPt)
                {

                    if (list3Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Power")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Power /" + cve[iPt].Y + "Power " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Power");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Power");
                    }




                }

            }
            if (curve.Label.Text == "Cadence")
            {
                if (curve.NPts > iPt)
                {

                    if (list2Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Cadence2")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Cadence /" + cve[iPt].Y + "Cadence " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Cadence");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Cadence");
                    }




                }

            }
            if (curve.Label.Text == "Cadence2")
            {
                if (curve.NPts > iPt)
                {

                    if (list2Compare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "Cadence")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "Cadence /" + cve[iPt].Y + "Cadence " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Cadence");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "Cadence");
                    }




                }

            }
            if (curve.Label.Text == "HeartRate")
            {
                if (curve.NPts > iPt)
                {

                    if (listCompare.Count>0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "HeartRate2")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "bpm /" + cve[iPt].Y + "bpm " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "bpm");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "bpm");
                    }




                }

            }
            if (curve.Label.Text == "HeartRate2")
            {
                if (curve.NPts > iPt)
                {

                    if (listCompare.Count > 0)
                    {
                        foreach (CurveItem cve in pane.CurveList)
                        {
                            if (cve.Label.Text == "HeartRate")
                            {
                                if (cve.NPts > iPt)
                                {
                                    double remainder = curve[iPt].Y - cve[iPt].Y;
                                    string difference = null;
                                    if (remainder < 0)
                                    {
                                        difference = remainder.ToString();
                                    }
                                    else
                                    {
                                        difference = "+" + remainder.ToString();
                                    }

                                    tooltip = String.Format(curve.Label.Text + "/" + cve.Label.Text + curve[iPt].Y + "bpm /" + cve[iPt].Y + "bpm " + difference);
                                    break;
                                }
                                else
                                {
                                    tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "bpm");
                                }

                            }

                        }
                    }
                    else
                    {
                        tooltip = String.Format(curve.Label.Text + ": " + curve[iPt].Y + "bpm");
                    }




                }

            }




            return tooltip;
        }

        private void favouritesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this populates the compare dgv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            CompareAnalyse();
        }
        /// <summary>
        /// this runs the chunking for the first file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            chunking();
     
        }
        private void button7_Click(object sender, EventArgs e)
        {
            chunking2();
        }
        /// <summary>
        /// used in calculating the normalised power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
            {
                //calculations for the ftp
                double FTPAVGPERCENT = Math.Round(avgpower / (Convert.ToDouble(numericUpDown2.Value)) * 100, 2);
                double FTPMAXPERCENT = Math.Round(maxpower / (Convert.ToDouble(numericUpDown2.Value)) * 100, 2);

                label45.Text = FTPAVGPERCENT.ToString() + "%";
                label47.Text = FTPMAXPERCENT.ToString() + "%";

            }

        /// <summary>
        /// brings datagridview to the front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void checkBox6_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox6.Checked == true)
                {
                    dataGridView1.Visible = true;
                dataGridView1.BringToFront();
            }
                else
                {
                    dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                zedGraphControl1.Visible = true;
            }
            }

        /// <summary>
        /// changes interval to the next.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void intervalfwd_Click(object sender, EventArgs e)
            {
                intcounter++;
                if (intcounter > 10)
                {
                    intcounter = 10;
                }
                zedGraphControl1.AxisChange();
                intervalpicker();
            }
        /// <summary>
        /// changes interval back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

            private void intervalbck_Click(object sender, EventArgs e)
            {
                intcounter--;
                if (intcounter == 0 || intcounter < 0)
                {
                    intcounter = 1;
                }
                intervalpicker();
            }
        /// <summary>
        /// chooses the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void button2_Click(object sender, EventArgs e)
            {
                //reads text file which variables will be passed through

                //creates array and splits the entries by empty spaces.
                try
                {
                    pathglob = (@"C:\Users\" + userName + "\\AnalysisData\\Fav\\" + favouritesComboBox.SelectedItem + ".HRM");
                    Analyse();
                }
                catch
                {
                    MessageBox.Show("Choose a Valid Files Location");
                }
            }
        /// <summary>
        /// save the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void button3_Click(object sender, EventArgs e)
            {
                try
                {
                    string content = listBox1.Text + listBox2.Text;
                    string path = @"C:\Users\" + userName + "\\AnalysisData\\Fav\\test.hrm";
                    File.WriteAllText(path, content);
                    MessageBox.Show("Your day has been saved!");
                }
                catch (Exception etc)
                {
                    MessageBox.Show("An error Ocurred: " + etc.Message);
                }
            }
        /// <summary>
        /// tts button also calculates normalised power.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void tssbtn_Click(object sender, EventArgs e)
            {
            getNP();
            }
        }
    }


