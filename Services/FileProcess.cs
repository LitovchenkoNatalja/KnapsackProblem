using KnapsackProblem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem.Services
{
    public class FileProcess
    {
        public KnapsackModel ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            KnapsackModel model = new KnapsackModel();
            model.N = Convert.ToInt32(lines[0]);
            model.C = Convert.ToDouble(lines[lines.Length - 1]);
            for (int i = 1; i < lines.Length - 1; i++)
            {
                var splitedLine = lines[i].Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                var tupel = new Tuple<double, double>(Convert.ToDouble(splitedLine[1]), Convert.ToDouble(splitedLine[2]));
                if (model.Items == null)
                {
                    model.Items = new List<Tuple<double, double>>(){ tupel };
                }
                else
                {
                    model.Items.Add(tupel);
                }
            }
            return model;
        }

        public void WriteFile(BitArray X, TotalModel model, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var b in X)
            {
                sb.Append((bool)b ? "1" : "0");
            }
            sb.ToString();
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\User\Downloads\"+ fileName + ".txt", true))
            {
                file.WriteLine(sb);
                file.WriteLine(model.TotalCost + "\t" + model.TotalWeight);
            }
        }
    }
}
