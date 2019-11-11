using KnapsackProblem.Methods;
using KnapsackProblem.Models;
using KnapsackProblem.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string path = "C:\\Users\\User\\Downloads\\test.in";
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
            var resultModel = new HillClimbing().FirstAscendHillClimbingMethod(knapsackModel);
            textBoxResultC.Text = Convert.ToString(resultModel.ResultC);
            textBoxResultW.Text = Convert.ToString(resultModel.ResultW);
            listBoxSelectedItems.Items.Clear();
            if (checkBoxShowFull.Checked)
            {
                listBoxSelectedItems.Items.Add("cost\tweight");
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
                ser1.Points.AddXY(pair.Key.ToString(), pair.Value);
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
    }
}
