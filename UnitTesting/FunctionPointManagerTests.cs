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
            fps.Add(new FunctionPoint("1") { Name = "name1", Complexity = 0, Hours = 0 });
            fps.Add(new FunctionPoint("2") { Name = "name2", Complexity = 5, Hours = 5 });
            fps.Add(new FunctionPoint("3") { Name = "name3", Complexity = 10, Hours = 10 });
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
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
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
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
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
        [TestMethod()]
        public void Edit_Nominal_Edited()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = NominalLoad();
            List<FunctionPoint> fps = result.FunctionPoints;
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPoint fp = fps[0];
            fp.Name = "Updated Name";
            Result addedResult = new Result()
            {
                Error = "",
                FunctionPoints = result.FunctionPoints,
                Successful = true
            };
            mock.Setup(m => m.SaveFunctionPoints(result.FunctionPoints)).Returns(addedResult);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.EditFunctionPoint(fp);
            //Assert
            Assert.AreEqual("Updated Name", result2.FunctionPoints[0].Name);
        }
        [TestMethod()]
        public void Edit_Error_Error()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = ErrorLoad();
            List<FunctionPoint> fps = result.FunctionPoints;
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPoint fp = new FunctionPoint("1");
            fp.Name = "Updated Name";
            Result addedResult = new Result()
            {
                Error = "Error",
                FunctionPoints = result.FunctionPoints,
                Successful = false
            };
            mock.Setup(m => m.SaveFunctionPoints(result.FunctionPoints)).Returns(addedResult);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.EditFunctionPoint(fp);
            //Assert
            Assert.AreEqual(false, result2.Successful);
        }
        [TestMethod()]
        public void Delete_Nominal_Deleted()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = NominalLoad();
            List<FunctionPoint> fps = result.FunctionPoints;
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            Result addedResult = new Result()
            {
                Error = "",
                FunctionPoints = result.FunctionPoints,
                Successful = true
            };
            mock.Setup(m => m.SaveFunctionPoints(result.FunctionPoints)).Returns(addedResult);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.DeleteFunctionPoint("1");
            //Assert
            Assert.AreEqual(2, result2.FunctionPoints.Count);
        }
        [TestMethod()]
        public void Delete_Error_Error()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = ErrorLoad();
            List<FunctionPoint> fps = result.FunctionPoints;
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            Result addedResult = new Result()
            {
                Error = "Error",
                FunctionPoints = result.FunctionPoints,
                Successful = false
            };
            mock.Setup(m => m.SaveFunctionPoints(result.FunctionPoints)).Returns(addedResult);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.DeleteFunctionPoint("1");
            //Assert
            Assert.AreEqual(false, result2.Successful);
        }

        [TestMethod()]
        public void Gets_Nominal_Loaded()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = NominalLoad();
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.GetFunctionPoints("");
            //Assert
            Assert.AreEqual(3, result2.FunctionPoints.Count);
        }

        [TestMethod()]
        public void Gets_NominalByKeyword_Loaded()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = new Result()
            {
                Successful = true,
                Error = "",
                FunctionPoints = new List<FunctionPoint>()
                {
                    new FunctionPoint("1") { Name = "name1", Complexity = 0, Hours = 0 }
                }
            };
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.GetFunctionPoints("name1");
            //Assert
            Assert.AreEqual(1, result2.FunctionPoints.Count);
        }

        [TestMethod()]
        public void Gets_Error_Error()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = ErrorLoad();
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.GetFunctionPoints("");
            //Assert
            Assert.AreEqual(false, result2.Successful);
        }

        [TestMethod()]
        public void Get_Nominal_Loaded()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = NominalLoad();
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.GetFunctionPoints("");
            //Assert
            Assert.AreEqual("name1", result2.FunctionPoints[0].Name);
        }

        [TestMethod()]
        public void Get_Error_Error()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = ErrorLoad();
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.GetFunctionPoint("1");
            //Assert
            Assert.AreEqual(false, result2.Successful);
        }

        [TestMethod()]
        public void Get_NotFound_Empty()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = ErrorLoad();
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            //Act
            Result result2 = manager.GetFunctionPoint("99");
            //Assert
            Assert.AreEqual(0, result2.FunctionPoints.Count);
        }

        [TestMethod()]
        public void CalculateComplexity_Nominal_Calculated()
        {
            //Arrange
            FunctionPointManager manager = new FunctionPointManager(null);
            FunctionPoint fp = new FunctionPoint("")
            {
                Backup = 2,
                Communications = 2,
                Distributed = 2,
                Performance = 2,
                Heavily = 2,
                Entry = 2,
                Multiple = 2,
                Master = 2,
                Complex = 2,
                Internal = 2,
                Reusable = 2,
                Installation = 2,
                Organizations = 2,
                Ease = 2,
                NumInputs = 5,
                InputsWeightingFactor = 3,
                NumOutputs = 3,
                OutputsWeightingFactor = 4,
                NumProcesses = 2,
                ProcessesWeightingFactor = 3,
                NumFiles = 4,
                FilesWeightingFactor = 7,
                NumExternals = 1,
                ExternalsWeightingFactor = 5
            };
            //Act
            double complexity = manager.CalculateComplexity(fp);
            //Assert
            Assert.AreEqual(61.0, complexity, 1);
        }

        [TestMethod()]
        public void EstimateTime_Nominal_Estimated()
        {
            //Arrange
            var mock = new Mock<IFunctionPointFile>();
            Result result = NominalLoad();
            mock.Setup(m => m.GetFunctionPoints()).Returns(result);
            FunctionPointManager manager = new FunctionPointManager(mock.Object);
            FunctionPoint fp = new FunctionPoint("")
            {
                Backup = 2,
                Communications = 2,
                Distributed = 2,
                Performance = 2,
                Heavily = 2,
                Entry = 2,
                Multiple = 2,
                Master = 2,
                Complex = 2,
                Internal = 2,
                Reusable = 2,
                Installation = 2,
                Organizations = 2,
                Ease = 2,
                NumInputs = 5,
                InputsWeightingFactor = 3,
                NumOutputs = 3,
                OutputsWeightingFactor = 4,
                NumProcesses = 2,
                ProcessesWeightingFactor = 3,
                NumFiles = 4,
                FilesWeightingFactor = 7,
                NumExternals = 1,
                ExternalsWeightingFactor = 5
            };
            //Act
            double hours = manager.EstimateTime(fp);
            //Assert
            Assert.AreEqual(61.38, hours, 0.01);
        }
    }
}