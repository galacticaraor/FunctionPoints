using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Result
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public List<FunctionPoint> FunctionPoints { get; set; }
        public Result()
        {
            Successful = true;
            Error = string.Empty;
            FunctionPoints = new List<FunctionPoint>();
        }
    }
}
