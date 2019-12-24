using KnapsackProblem.Methods;
using KnapsackProblem.Models;
using KnapsackProblem.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KnapsackProblem
{
    public partial class Form1 : Form
    {
        KnapsackModel knapsackModel;

        public Form1()
        {
            InitializeComponent();
        }

        private void defaultFileButton_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\User\\Downloads\\StartTest.in";
            FileProcess fileProcess = new FileProcess();
            knapsackModel = fileProcess.ReadFile(path);
            textBoxN.Text = Convert.ToString(knapsackModel.N);
            textBoxTotalC.Text = Convert.ToString(knapsackModel.C);
        }

        private void findFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                FileProcess fileProcess = new FileProcess();
                knapsackModel = fileProcess.ReadFile(path);
                textBoxN.Text = Convert.ToString(knapsackModel.N);
                textBoxTotalC.Text = Convert.ToString(knapsackModel.C);
            }
        }

        private void FAHillClimbingButton_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\User\Downloads\ResultFAHillClimbing.txt");

            double alpha = Convert.ToDouble(textBox11.Text);
            var resultModel = new HillClimbing().NewFirstAscendHillClimbingMethod(knapsackModel, alpha);
            textBoxResultC.Text = Convert.ToString(resultModel.ResultC);
            textBoxResultW.Text = Convert.ToString(resultModel.ResultW);
            listBoxSelectedItems.Items.Clear();
            if (checkBoxShowFull.Checked)
            {
                listBoxSelectedItems.Items.Add("cost\t\tweight");
                for (int i = 0; i < resultModel.X.Length; i++)
                {
                    if (resultModel.X[i] == true)
                        listBoxSelectedItems.Items.Add(knapsackModel.Items[i].Item1 + "\t" + knapsackModel.Items[i].Item2);
                }
            }
        }

        private void MultiStartHillClimbingButton_Click(object sender, EventArgs e)
        {
            var maxAttemt = Convert.ToInt32(textBoxMaxAttemps.Text);
            var objDetails = checkBoxObjDetails.Checked;

            var resultModel = new HillClimbing().MultiStartHillClimbingMethod(knapsackModel, maxAttemt, objDetails);
            Series ser1 = new Series("Attempts statistics");
            chart1.Series.Clear();
            foreach (var pair in resultModel.AttemptStatistics)
            {
                ser1.Points.AddXY(pair.Key.ToString(), pair.Value.ToString());
            }
            chart1.Series.Add(ser1);
            chart1.ChartAreas[0].AxisX.Interval = 1;
            textBoxDelta.Text = Convert.ToString(resultModel.Delta);

            if (objDetails)
            {
                chart2.Series.Clear();
                Series ser2 = new Series("Objective");
                ser2.ChartType = SeriesChartType.Line;

                chart2.ChartAreas["Area1"].AxisX.ScaleView.Zoom(0, 50);
                chart2.ChartAreas["Area1"].AxisX.Interval = 1;

                for (int i =0; i< resultModel.ObjectivesDetails.Count; i++)
                {
                    for (int j = 0; j < resultModel.ObjectivesDetails[i].Count; j++)
                    {
                        ser2.Points.AddXY(j.ToString(), resultModel.ObjectivesDetails[i][j]);
                    }
                }

                chart2.Series.Add(ser2);
            }
        }

        private void HillClimbingButton_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\User\Downloads\ResultHillClimbing.txt");

            var resultModel = new HillClimbing().HillClimbingMethod(knapsackModel);
            textBoxResultC2.Text = Convert.ToString(resultModel.ResultC);
            textBoxResultW2.Text = Convert.ToString(resultModel.ResultW);
            listBoxSelectedItems2.Items.Clear();
            if (checkBoxShowFull2.Checked)
            {
                listBoxSelectedItems2.Items.Add("cost\t\tweight");
                for (int i = 0; i < resultModel.X.Length; i++)
                {
                    if (resultModel.X[i] == true)
                        listBoxSelectedItems2.Items.Add(knapsackModel.Items[i].Item1 + "\t" + knapsackModel.Items[i].Item2);
                }
            }
        }

        private void SameInitValuebutton_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\User\Downloads\ResultFAHillClimbing.txt");

            var hill = new HillClimbing(knapsackModel);

            File.Delete(@"C:\Users\User\Downloads\ResultHillClimbing.txt");

            var resultModel = hill.HillClimbingMethod(knapsackModel);
            textBoxResultC2.Text = Convert.ToString(resultModel.ResultC);
            textBoxResultW2.Text = Convert.ToString(resultModel.ResultW);
            listBoxSelectedItems2.Items.Clear();
            if (checkBoxShowFull2.Checked)
            {
                listBoxSelectedItems2.Items.Add("cost\t\tweight");
                for (int i = 0; i < resultModel.X.Length; i++)
                {
                    if (resultModel.X[i] == true)
                        listBoxSelectedItems2.Items.Add(knapsackModel.Items[i].Item1 + "\t" + knapsackModel.Items[i].Item2);
                }
            }

            resultModel = hill.FirstAscendHillClimbingMethod(knapsackModel);
            textBoxResultC.Text = Convert.ToString(resultModel.ResultC);
            textBoxResultW.Text = Convert.ToString(resultModel.ResultW);
            listBoxSelectedItems.Items.Clear();
            if (checkBoxShowFull.Checked)
            {
                listBoxSelectedItems.Items.Add("cost\t\tweight");
                for (int i = 0; i < resultModel.X.Length; i++)
                {
                    if (resultModel.X[i] == true)
                        listBoxSelectedItems.Items.Add(knapsackModel.Items[i].Item1 + "\t" + knapsackModel.Items[i].Item2);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\User\Downloads\Genetic.txt");

            var n = Convert.ToInt32(textBox1.Text);
            var rate = Convert.ToInt32(textBox2.Text);
            var k = radioButton4.Checked ? 4 : 8;
            var iterNum = Convert.ToInt32(textBox3.Text);
            var result = new GeneticAlgorithm().GeneticAlgorithmMethod(knapsackModel, n, k, rate, iterNum);

            textBox4.Text = Convert.ToString(result.ResultC);
            textBox5.Text = Convert.ToString(result.ResultW);
            listBox1.Items.Clear();

            var sb = new StringBuilder();

            for (int i = 0; i < result.X.Count; i++)
            {
                char c = result.X[i] ? '1' : '0';
                sb.Append(c);
            }
            listBox1.Items.Add(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var att = Convert.ToInt32(textBox6.Text);
            var n = Convert.ToInt32(textBox1.Text);
            var rate = Convert.ToInt32(textBox2.Text);
            var k = radioButton4.Checked ? 4 : 8;
            var iterNum = Convert.ToInt32(textBox3.Text);
            Series ser3 = new Series("Attempts statistics");
            chart3.Series.Clear();

            SortedDictionary<double, double> dict = new SortedDictionary<double, double>();

            for (int i = 0; i < att; i++)
            {
                var result = new GeneticAlgorithm().GeneticAlgorithmMethod(knapsackModel, n, k, rate, iterNum);
                if (!dict.ContainsKey(result.ResultC))
                {
                    dict.Add(result.ResultC, 1);
                }
                else
                {
                    dict[result.ResultC] += 1;
                }
            }
            foreach (var pair in dict)
            {
                ser3.Points.AddXY(pair.Key.ToString(), pair.Value.ToString());
            }

            chart3.Series.Add(ser3);
            chart3.ChartAreas[0].AxisX.Interval = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\User\Downloads\ResultVariableDepth.txt");

            var Region = Convert.ToInt32(textBox10.Text);

            var result = new VariableDepthSearch().VariableDepthSearchMethod(knapsackModel, Region);

            textBox9.Text = Convert.ToString(result.ResultC);
            textBox8.Text = Convert.ToString(result.ResultW);
            listBox2.Items.Clear();

            var sb = new StringBuilder();

            for (int i = 0; i < result.X.Count; i++)
            {
                char c = result.X[i] ? '1' : '0';
                sb.Append(c);
            }
            listBox2.Items.Add(sb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var att = Convert.ToInt32(textBox7.Text);
            var Region = Convert.ToInt32(textBox10.Text);
            Series ser3 = new Series("Attempts statistics");
            chart4.Series.Clear();

            SortedDictionary<double, double> dict = new SortedDictionary<double, double>();

            for (int i = 0; i < att; i++)
            {
                var result = new VariableDepthSearch().VariableDepthSearchMethod(knapsackModel, Region);
                if (!dict.ContainsKey(result.ResultC))
                {
                    dict.Add(result.ResultC, 1);
                }
                else
                {
                    dict[result.ResultC] += 1;
                }
            }
            foreach (var pair in dict)
            {
                ser3.Points.AddXY(pair.Key.ToString(), pair.Value.ToString());
            }

            chart4.Series.Add(ser3);
            chart4.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
