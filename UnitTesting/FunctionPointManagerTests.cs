using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace BLL.Tests
{
    [TestClass()]
    public class FunctionPointManagerTests
    {
        private Result NominalLoad()
        {
            List<FunctionPoint> fps = new List<FunctionPoint>();
            fps.Add(new FunctionPoint("1") { Name = "name1" });
            fps.Add(new FunctionPoint("2") { Name = "name2" });
            fps.Add(new FunctionPoint("3") { Name = "name3" });
            Result result = new Result()
            {
                Error = "",
                FunctionPoints = fps,
                Successful = true
            };
            return result;
        }

        private Result ErrorLoad()
        {
            List<FunctionPoint> fps = new List<FunctionPoint>();
            Result result = new Result()
            {
                Error = "Error",
                FunctionPoints = fps,
                Successful = false
            };
            return result;
        }

        [TestMethod()]
        public void Add_Nominal_Added()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = NominalLoad();
            mock.Setup(m => m.GetFunctionPoints("")).Returns(result);
            List<FunctionPoint> fps = result.FunctionPoints;
            Result addedResult = new Result()
            {
                Error = "",
                FunctionPoints = fps,
                Successful = true
            };
            mock.Setup(m => m.SaveFunctionPoints(result.FunctionPoints)).Returns(addedResult);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.AddFunctionPoint(new FunctionPoint("4") { Name = "name4" });
            //Assert
            Assert.AreEqual(4, result2.FunctionPoints.Count);
        }

        [TestMethod()]
        public void Add_Error_Error()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = ErrorLoad();
            mock.Setup(m => m.GetFunctionPoints("")).Returns(result);
            List<FunctionPoint> fps = result.FunctionPoints;
            Result addedResult = new Result()
            {
                Error = "",
                FunctionPoints = fps,
                Successful = false
            };
            mock.Setup(m => m.SaveFunctionPoints(result.FunctionPoints)).Returns(addedResult);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.AddFunctionPoint(new FunctionPoint("4") { Name = "name4" });
            //Assert
            Assert.AreEqual(false, result2.Successful);
        }
    }
}