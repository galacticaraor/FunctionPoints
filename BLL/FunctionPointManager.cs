using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class FunctionPointManager
    {
        private readonly IFunctionPointFile _file;
        public FunctionPointManager(IFunctionPointFile file)
        {
            _file = file;
        }

        public Result AddFunctionPoint(FunctionPoint fp)
        {
            Result result = _file.GetFunctionPoints("");
            //If the call was successful then
            if (result.Successful)
            {
                List<FunctionPoint> fps = result.FunctionPoints;
                //Add the function point record to the collection
                fps.Add(fp);
                result = _file.SaveFunctionPoints(fps);
            }
            //Return the result
            return result;
        }

        public Result EditFunctionPoint(FunctionPoint fp)
        {
            Result result = _file.GetFunctionPoints("");
            //If the call was successful then
            if (result.Successful)
            {
                //Loop through the records
                List<FunctionPoint> fps = result.FunctionPoints;
                foreach (FunctionPoint existingFP in fps)
                {
                    //If a match was found then
                    if (existingFP.ID == fp.ID)
                    {
                        //Update the object in the collection
                        FunctionPoint found = fps.Find(f => f.ID == existingFP.ID);
                        break;
                    }
                }
                result = _file.SaveFunctionPoints(fps);
            }
            return result;
        }

        public Result DeleteFunctionPoint(string id)
        {
            Result result = _file.GetFunctionPoints("");
            //If the call was successful then
            if (result.Successful)
            {
                //Delete the record with the ID
                List<FunctionPoint> fps = result.FunctionPoints;
                fps.RemoveAll(f => f.ID == id);
                result = _file.SaveFunctionPoints(fps);
            }
            return result;
        }

        public Result GetFunctionPoints(string keyword)
        {
            return _file.GetFunctionPoints(keyword);
        }

        public Result GetFunctionPoint(string id)
        {
            return _file.GetFunctionPoint(id);
        }

        public double CalculateComplexity(FunctionPoint fp)
        {
            double complexity = 0;
            double totalCount = (fp.NumInputs * fp.InputsWeightingFactor) +
                                (fp.NumOutputs * fp.OutputsWeightingFactor) +
                                (fp.NumProcesses * fp.ProcessesWeightingFactor) +
                                (fp.NumFiles * fp.FilesWeightingFactor) +
                                (fp.NumExternals * fp.ExternalsWeightingFactor);
            int totalFactors = fp.Backup + fp.Communications + fp.Distributed + fp.Performance +
                               fp.Heavily + fp.Entry + fp.Multiple + fp.Master + fp.Complex +
                               fp.Internal + fp.Reusable + fp.Installation + fp.Organizations + fp.Ease;
            complexity = totalCount * (0.65 + (0.01 * totalFactors));
            return complexity;
        }

        public double EstimateTime(FunctionPoint fp)
        {
            List<FunctionPoint> fps = _file.GetFunctionPoints("").FunctionPoints;
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            double complexity = CalculateComplexity(fp);
            //If fp.Complexity<the first complexity then
            if (complexity <= fps.Min(f => f.Complexity))
            {
                //Use (0, 0) and the first function point
                FunctionPoint firstFP = fps.OrderBy(f => f.Complexity).First();
                x1 = 0;
                y1 = 0;
                x2 = firstFP.Complexity;
                y2 = firstFP.Hours;
            }
            //Else if fp.Complexity>the last complexity then
            else if (complexity >= fps.Max(f => f.Complexity))
            {
                //Use the last 2 function points
                List<FunctionPoint> orderedFPs = fps.OrderBy(f => f.Complexity).ToList();
                x1 = orderedFPs[orderedFPs.Count - 2].Complexity;
                y1 = orderedFPs[orderedFPs.Count - 2].Hours;
                x2 = orderedFPs[orderedFPs.Count - 1].Complexity;
                y2 = orderedFPs[orderedFPs.Count - 1].Hours;
            }
            else
            {
                //Loop through the function point history
                foreach (FunctionPoint point in fps.OrderBy(f => f.Complexity))
                {
                    //If fp.Complexity > current complexity but less than the next complexity in the function point history then
                    if (complexity > point.Complexity)
                    {
                        //Get the complexity and hours from this point and the next
                        x1 = point.Complexity;
                        y1 = point.Hours;
                        FunctionPoint nextPoint = fps.OrderBy(f => f.Complexity).First(f => f.Complexity > point.Complexity);
                        x2 = nextPoint.Complexity;
                        y2 = nextPoint.Hours;
                        break;
                    }
                }
            }
            double m = (y2 - y1) / (x2 - x1);
            double hours = y1 + m * (complexity - x1);
            return hours;
        }
    }
}
