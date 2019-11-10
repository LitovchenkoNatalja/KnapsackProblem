using KnapsackProblem.Models;
using System;
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
            model.C = Convert.ToInt32(lines[lines.Length - 1]);
            for (int i = 1; i < lines.Length - 1; i++)
            {
                var splitedLine = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var tupel = new Tuple<int, int>(Convert.ToInt32(splitedLine[1]), Convert.ToInt32(splitedLine[2]));
                if (model.Items == null)
                {
                    model.Items = new List<Tuple<int, int>>(){ tupel };
                }
                else
                {
                    model.Items.Add(tupel);
                }
            }
            return model;
        }
    }
}
