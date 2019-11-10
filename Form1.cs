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
        }

        private void findFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                FileProcess fileProcess = new FileProcess();
                knapsackModel = fileProcess.ReadFile(path);
            }
        }

        private void hillClimbingButton_Click(object sender, EventArgs e)
        {
            //new HillClimbing().HillClimbingMethod(knapsackModel);

            var Neighborhood = new Neighborhood();
            Neighborhood.InitNFlip(5);
            BitArray X = new RandomBitGeneration().GenerateBitArray(knapsackModel.N);
            while (Neighborhood.stop)
            {
                Neighborhood.GetNextNeighborhood(X);

            }
        }
    }
}
