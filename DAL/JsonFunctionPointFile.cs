using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class JsonFunctionPointFile: IFunctionPointFile
    {
        public string Path { get; set; }
        public JsonFunctionPointFile(string path)
        {
            Path = path;
        }

        public Result GetFunctionPoints(string keyword)
        {
            List<FunctionPoint> fps = new List<FunctionPoint>();
            try
            {
                //Get the file contents from the path
                string contents = "";
                using (TextReader reader = new StreamReader(Path))
                {
                    contents = reader.ReadToEnd();
                }
                //Deserialize the JSON
                List<FunctionPoint> rawFPs = JsonConvert.DeserializeObject<List<FunctionPoint>>(contents);
                //Loop through the results
                foreach (FunctionPoint fp in rawFPs)
                {
                    //If there is no keyword or the name of the record contains the keyword then
                    if (string.IsNullOrEmpty(keyword) || fp.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        //Add the record to the list
                        fps.Add(fp);
                    }
                }
                //Sort the list by complexity in ascending order
                fps = fps.OrderBy(fp => fp.Complexity).ToList();
                Result result = new Result()
                {
                    Error = "",
                    Successful = true,
                    FunctionPoints = fps
                };
                return result;
            }
            catch (Exception ex)
            {
                //Return the results with an error
                Result result = new Result()
                {
                    Error = ex.Message,
                    Successful = false,
                    FunctionPoints = fps
                };
                return result;
            }
        }

        public Result SaveFunctionPoints(List<FunctionPoint> functionPoints)
        {
            try
            {
                //Serialize the list to JSON
                string contents = JsonConvert.SerializeObject(functionPoints, Formatting.Indented);
                //Save the JSON to a file using the path
                using (TextWriter writer = new StreamWriter(Path, false))
                {
                    writer.Write(contents);
                }
                //Return a successful result
                Result result = new Result()
                {
                    Error = "",
                    Successful = true,
                    FunctionPoints = functionPoints
                };
                return result;
            }
            catch (Exception ex)
            {
                //Return the results with an error
                Result result = new Result()
                {
                    Error = ex.Message,
                    Successful = false,
                    FunctionPoints = functionPoints
                };
                return result;
            }
        }

        public Result GetFunctionPoint(string id)
        {
            List<FunctionPoint> fp = new List<FunctionPoint>();
            try
            {
                //Get the file contents from the path
                string contents = "";
                using (TextReader reader = new StreamReader(Path))
                {
                    contents = reader.ReadToEnd();
                }
                //Deserialize the JSON
                List<FunctionPoint> rawFPs = JsonConvert.DeserializeObject<List<FunctionPoint>>(contents);
                //Loop through the results
                foreach (FunctionPoint functionPoint in rawFPs)
                {
                    //If ID matches then
                    if (functionPoint.ID == id)
                    {
                        //Add the record to the list
                        fp.Add(functionPoint);
                        break;
                    }
                }
                //Return the results with a successful result
                Result result = new Result()
                {
                    Error = "",
                    Successful = true,
                    FunctionPoints = fp
                };
                return result;
            }
            catch (Exception ex)
            {
                //Return the results with an error
                Result result = new Result()
                {
                    Error = ex.Message,
                    Successful = false,
                    FunctionPoints = fp
                };
                return result;
            }
        }
    }
}
