using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FunctionPoint
    {
        public string ID { get; internal set; }
        public string Name { get; set; }
        public int NumInputs { get; set; }
        public int InputsWeightingFactor { get; set; }
        public int NumOutputs { get; set; }
        public int OutputsWeightingFactor { get; set; }
        public int NumProcesses { get; set; }
        public int ProcessesWeightingFactor { get; set; }
        public int NumFiles { get; set; }
        public int FilesWeightingFactor { get; set; }
        public int NumExternals { get; set; }
        public int ExternalsWeightingFactor { get; set; }
        public int Backup { get; set; }
        public int Communications { get; set; }
        public int Distributed { get; set; }
        public int Performance { get; set; }
        public int Heavily { get; set; }
        public int Entry { get; set; }
        public int Multiple { get; set; }
        public int Master { get; set; }
        public int Complex { get; set; }
        public int Internal { get; set; }
        public int Reusable { get; set; }
        public int Installation { get; set; }
        public int Organizations { get; set; }
        public int Ease { get; set; }
        public double Complexity { get; set; }
        public double Hours { get; set; }
        public FunctionPoint(string id)
        {
            ID = id;
            NumInputs = 0;
            InputsWeightingFactor = 3;
            NumOutputs = 0;
            OutputsWeightingFactor = 4;
            NumProcesses = 0;
            ProcessesWeightingFactor = 3;
            NumFiles = 0;
            FilesWeightingFactor = 7;
            NumExternals = 0;
            ExternalsWeightingFactor = 5;
            Backup = 0;
            Communications = 0;
            Distributed = 0;
            Performance = 0;
            Heavily = 0;
            Entry = 0;
            Multiple = 0;
            Master = 0;
            Complex = 0;
            Internal = 0;
            Reusable = 0;
            Installation = 0;
            Organizations = 0;
            Ease = 0;
            Complexity = 0;
            Hours = 0;
        }
    }
}
