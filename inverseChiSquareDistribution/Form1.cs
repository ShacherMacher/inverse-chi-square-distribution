using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using inverseChiSquareDistribution;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using Word = Microsoft.Office.Interop.Word;

namespace distribution
{
    public partial class Form1 : Form
    {
        private List<double> analytics = new List<double>();
        private List<double> listInverse = new List<double>();
        private List<double> listNeimon = new List<double>();
        private List<double> listMetropolis = new List<double>();
        private int N;
        private double A, B, left, right, step, y, qMax, betta;
        private double a, aN, aM, aI;
        private double disp, dispN, dispM, dispI;
        private double sigma, sigmaN, sigmaM, sigmaI;
        Random rand = new Random();
        private int progress;
        private bool stop, pause;

        private List<double> answerInverse = new List<double>();
        private List<double> answerNeimon = new List<double>();
        private List<double> answerMetropolis = new List<double>();

        ManualResetEvent _busy = new ManualResetEvent(false);

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            A = (double)formA.Value;
            B = (double)formNiter.Value;
            N = (int)indexNfield.Value;
            betta = chart1.DataManipulator.Statistics.BetaFunction(A, B);
            if (formLeft.Value < formRight.Value)
            {
                left = (double)formLeft.Value;
                right = (double)formRight.Value;
            }
            else
            {
                right = (double)formLeft.Value;
                left = (double)formRight.Value;
            }

            step = (right - left) / (double)formStep.Value;
            progress = (int)N / 100;
            
            qMax = 0;
            progressBarMetropolis.Value = 0;
            progressBarNeymon.Value = 0;
            progressBarInverse.Value = 0;

            chart1.Series[0].Points.Clear();
            analytics.Clear();

            chart1.Series[1].Points.Clear();
            listNeimon.Clear();

            chart1.Series[2].Points.Clear();
            listMetropolis.Clear();

            chart1.Series[3].Points.Clear();
            listInverse.Clear();

            checkBoxNeymon.Checked = true;
            checkBoxMetropolis.Checked = true;
            checkBoxInverse.Checked = true;

            answerNeimon.Clear();
            answerMetropolis.Clear();
            answerInverse.Clear();

            dataGrid.Visible = true;
            checkBoxNeymon.Visible = true;
            checkBoxMetropolis.Visible = true;
            checkBoxInverse.Visible = true;

            Save.Enabled = false;

            PauseButton.BackColor = Color.FromArgb(192, 192, 0);
            StopButton.BackColor = Color.LightCoral;

            Start.Enabled = false;

            stop = false;
            StopButton.Enabled = true;

            pause = false;
            PauseButton.Enabled = true;

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Absolute(sender, e);
            Neymon(sender, e);
            Metropolis(sender, e);
            Inverse(sender, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBarNeymon.Value < 100)
                progressBarNeymon.Value += e.ProgressPercentage;
            else
            {
                if (progressBarMetropolis.Value < 100)
                    progressBarMetropolis.Value += e.ProgressPercentage;
                else
                {
                    if (progressBarInverse.Value < 100)
                        progressBarInverse.Value += e.ProgressPercentage;
                    toolStripProgressBar1.Value += e.ProgressPercentage;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Answer();

            stop = false;
            StopButton.Enabled = false;

            pause = false;
            PauseButton.Enabled = false;

            PauseButton.BackColor = Color.AliceBlue;
            StopButton.BackColor = Color.AliceBlue;
            Start.Enabled = true;

            Save.Visible = true;
            Save.Enabled = true;

            _busy.Reset();
        }
        
        private void Answer()
        {
            AnswerAbsolute();
            AnswerDiagram(chart1, 1, listNeimon, left, right, step, listNeimon.Count, answerNeimon);
            AnswerDiagram(chart1, 2, listMetropolis, left, right, step, listMetropolis.Count, answerMetropolis);
            AnswerDiagram(chart1, 3, listInverse, left, right, step, listInverse.Count, answerInverse);
            
            if (A > 1 && B > 1)
                a = (A - 1) / (A + B - 2);
            else
                a = 0;

            aN = Methods.Mean(listNeimon);
            aM = Methods.Mean(listMetropolis);
            aI = Methods.Mean(listInverse);

            disp = (A * B) / (Math.Pow(A + B, 2) * (A + B + 1));
            dispN = Methods.Dispersion(listNeimon, aN);
            dispM = Methods.Dispersion(listMetropolis, aM);
            dispI = Methods.Dispersion(listInverse, aI);
            
            sigma = Math.Sqrt(disp / N);
            sigmaN = Math.Sqrt(dispN / listNeimon.Count);
            sigmaM = Math.Sqrt(dispM / listMetropolis.Count);
            sigmaI = Math.Sqrt(dispI / listInverse.Count);
            
            AnswerGrig();
        }
        
        private void AnswerGrig()
        {
            dataGrid.RowCount = 4;

            dataGrid.Rows[0].SetValues("Absolute", a, disp, sigma);
            dataGrid.Rows[1].SetValues("Neymann", aN, dispN, sigmaN);
            dataGrid.Rows[2].SetValues("Metropolis", aM, dispM, sigmaM);
            dataGrid.Rows[3].SetValues("Inverse", aI, dispI, sigmaI);
        }
        
        private void Absolute(object sender, DoWorkEventArgs e)
        {
            double st = Math.Abs((right - left) / 100);
            for (var i = left; i < right; i += st)
            {
                y = Methods.Function(A, B, i, betta);
                analytics.Add(y);
                if (qMax < y) qMax = y;
            }
        }
        
        private void Neymon(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double xN;
            for (int i = 0; i < N; i++)
            {
                xN = Methods.MethodNeyman(A, B, qMax, left, right, betta); 
                listNeimon.Add(xN); 

                if (stop) break;
                if (pause) _busy.WaitOne(Timeout.Infinite);
                if (i % progress == 0) worker.ReportProgress(1);
            }

            listNeimon.Sort();
        }
        
        private void Metropolis(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double xM, delta;
            delta = (right - left); 
            xM = left + (right - left) * rand.NextDouble();

            for (int i = 0; i < N; i++)
            {
                if (stop) break;
                if (pause) _busy.WaitOne(Timeout.Infinite);
                if (i % progress == 0) worker.ReportProgress(1);

                xM = Methods.Metropolis(A, B, left, right, xM, delta, betta);

                if (i > 100 && xM > left && xM <= right)
                    listMetropolis.Add(xM);
            }

            listMetropolis.Sort();
        }

        
        private void Inverse(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < N; i++)
            {
                if (stop) break;
                if (pause) _busy.WaitOne(Timeout.Infinite);
                if (i % progress == 0) worker.ReportProgress(1);

                double inverse = Methods.Inverse(A, B); 
                if (inverse > left)
                    listInverse.Add(inverse); 
                else
                    i--; 
            }

            listInverse.Sort();
        }
        
        private void AnswerAbsolute()
        {
            var j = 0;
            double st = Math.Abs(right - left) / 100;
            for (var i = left; i < right; i += st)
            {
                chart1.Series[0].Points.AddXY(i, analytics[j]);
                j++;
            }
        }
        
        private void AnswerDiagram(Chart chartX, int series, List<double> listX, double leftX, double rightX,
            double stepX, double nX, List<double> myList)
        {
            var a = 0;
            var j = 0;
            for (var i = leftX; i < rightX; i += stepX)
            {
                double k = 0;
                if (j == listX.Count) continue;
                for (j = a; j < listX.Count; j++)
                {
                    if (listX[j] < i + stepX)
                        k++;
                    else
                    {
                        a = j;
                        break;
                    }
                }

                if (k != 0)
                {
                    k /= stepX * nX;
                    chartX.Series[series].Points.AddXY(i + stepX / 2, k);
                    myList.Add(k);
                }
            }
        }

        private void checkBoxNeymon_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxNeymon.Checked)
                chart1.Series[1].Enabled = false;
            else
                chart1.Series[1].Enabled = true;
        }

        private void checkBoxMetropolis_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMetropolis.Checked)
                chart1.Series[2].Enabled = false;
            else
                chart1.Series[2].Enabled = true;
        }

        private void checkBoxInverse_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxInverse.Checked)
                chart1.Series[3].Enabled = false;
            else
                chart1.Series[3].Enabled = true;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormDistribution dist = new FormDistribution();
            dist.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.Show();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (!pause)
            {
                pause = true;
                PauseButton.Text = @"Resume";
            }

            else
            {
                _busy.Set();
                pause = false;
                PauseButton.Text = @"Pause";
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stop = true;
        }


        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = @"Open MSOffice Doc File";
            theDialog.Filter = @"MSOffice Doc files|*.doc";


            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string tempDirectory = AppDomain.CurrentDomain.BaseDirectory + "tempChart.png";
                chart1.SaveImage(tempDirectory, ChartImageFormat.Png);
                string text = "Вхідні параметри:" +
                              "\nv = " + A +
                              "\nk = " + B +
                              "\nN = " + N +
                              "\nX from " + left + " to " + right;

                if (dataGrid.Rows.Count != 0)
                {
                    var RowCount = dataGrid.Rows.Count;
                    var ColumnCount = dataGrid.Columns.Count;
                    var DataArray = new object[RowCount + 1, ColumnCount + 1];
                    
                    for (var c = 0; c <= ColumnCount - 1; c++)
                    {
                        for (var r = 0; r <= RowCount - 1; r++)
                        {
                            DataArray[r, c] = dataGrid.Rows[r].Cells[c].Value;
                        }
                    }

                    var app = new Word.Application();
                    var oDoc = app.Documents.Add();

                    oDoc.Application.Visible = false;

                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;

                    var oParagraph = oDoc.Paragraphs.Add();
                    var parRange = oParagraph.Range;
                    parRange.Font.Name = "Times New Roman";
                    parRange.Font.Size = 14;
                    parRange.Text = text;
                    parRange.InsertParagraphAfter();
                    var chartParagraph = oDoc.Paragraphs.Add();
                    chartParagraph.Range.InlineShapes.AddPicture(tempDirectory);

                    var tableParagraph = oDoc.Paragraphs.Add();
                    dynamic oRange = tableParagraph.Range;
                    var oTemp = "";
                    for (var r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            oTemp = oTemp + DataArray[r, c] + "\t";
                        }
                    }

                    oRange.Text = oTemp;

                    var Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    var ApplyBorders = true;
                    var AutoFit = true;
                    var AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                        Type.Missing, Type.Missing, ref ApplyBorders,
                        Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    for (var c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Font.Name = "Times New Roman";
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGrid.Columns[c].HeaderText;
                    }

                    oDoc.SaveAs(theDialog.FileName);
                    oDoc.Close(System.Reflection.Missing.Value);
                    app.Quit(System.Reflection.Missing.Value);
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Введіть значення v, k, N, Х, де N – кількість ітерацій, Х – носій функції, Стовпчики – кількість стовпців на діаграмі. 
Потім натисніть 'Start', щоб розпочати роботу програми.");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // FormAbout about = new FormAbout();
            // about.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}