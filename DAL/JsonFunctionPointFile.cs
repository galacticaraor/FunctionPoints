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

        public Result GetFunctionPoints()
        {
            List<FunctionPoint> fps = new List<FunctionPoint>();
            //If the path doesn’t exist then
            if (!File.Exists(Path))
            {
                //Return an empty list
                Result result = new Result()
                {
                    Error = "",
                    Successful = true,
                    FunctionPoints = fps
                };
                return result;
            }
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
    }
}
