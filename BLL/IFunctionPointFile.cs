using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IFunctionPointFile
    {
        Result GetFunctionPoints(string keyword);
        Result SaveFunctionPoints(List<FunctionPoint> functionPoints);
        Result GetFunctionPoint(string id);
    }
}
