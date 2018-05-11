using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class GridTest
    {
        private DataStorage dataStorage;
        private readonly GridHandler GRID_HANDLER;
        private readonly int HEIGHT = 20;
        private readonly int WIDTH = 20;
        private readonly string USERNAME_OK = "pablo";
        private readonly string PASSWORD_OK = "pablo";
        private readonly string NAME_OK = "Pablo";
        private readonly string SURNAME_OK = "Pereira";
        private readonly DateTime DATE_OK = new DateTime(1997, 07, 24);
        private readonly string ID_OK = "5407935-1";
        private readonly int PHONE_OK = 093535851;
        private readonly string ADDRESS_OK = "Brasil 1744";

        public GridTest()
        {
            this.GRID_HANDLER = new GridHandler();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        [TestInitialize]
        public void TestCleanUp()
        {
            dataStorage.EmptyStorage();
        }

        [TestMethod]
        public void TestCreateGridWithoutParameters()
        {
            Grid grid = new Grid();
            Assert.IsNotNull(grid);
        }

        [TestMethod]
        public void TestCreateGridWithParameters()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            Assert.IsTrue(grid.Designer.Equals(designer) && grid.Client.Equals(client) && grid.Height.Equals(HEIGHT)
                && grid.Width.Equals(WIDTH));
            
        }

        [TestMethod]
        public void TestAddGrid() {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            GRID_HANDLER.Add(grid);
            Assert.IsTrue(dataStorage.Grids.Contains(grid));
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestGetGrid()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            GRID_HANDLER.Add(grid);
            Grid resultGrid = GRID_HANDLER.Get(client);
            Assert.AreEqual(grid, resultGrid);

        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestDeleteGrid()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            GRID_HANDLER.Add(grid);
            GRID_HANDLER.Delete(grid);
            Assert.IsFalse(dataStorage.Grids.Contains(grid));
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionController))]
        public void TestExistGrid()
        {
            Designer designer = new Designer(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, DATE_OK, null);
            Client client = new Client(USERNAME_OK, PASSWORD_OK, NAME_OK, SURNAME_OK, ID_OK, PHONE_OK, ADDRESS_OK, DATE_OK, null);
            Grid grid = new Grid(designer, client, HEIGHT, WIDTH);
            GRID_HANDLER.Add(grid);
            GRID_HANDLER.Exist(grid);
        }
        
    }
}
