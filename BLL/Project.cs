using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Project
    {
        public int NumInputs { get; set; }
        public int InputComplexity { get; set; }
        public int NumOutputs { get; set; }
        public int OutputComplexity { get; set; }
        public int NumProcesses { get; set; }
        public int ProcessComplexity { get; set; }
        public int NumFiles { get; set; }
        public int FileComplexity { get; set; }
        public int NumExternalFiles { get; set; }
        public int ExternalFileComplexity { get; set; }
        public int Backup { get; set; }
        public int Communication { get; set; }
        public int Distributed { get; set; }
        public int Performance { get; set; }
        public int HeavilyUsed { get; set; }
        public int OnlineDataEntry { get; set; }
        public int MultipleScreens { get; set; }
        public int MasterFiles { get; set; }
        public int IOComplex { get; set; }
        public int ProcessingComplex { get; set; }
        public int Reusable { get; set; }
        public int Installation { get; set; }
        public int MultipleOrganizations { get; set; }
        public int UserFrinedly { get; set; }
        public int NumHours { get; set; }
        public Project()
        {

        }
    }
}
