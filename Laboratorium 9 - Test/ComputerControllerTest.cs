using Laboratorium_3___App.Controllers;
using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_9___Test
{
    public class ComputerControllerTest
    {
        private ComputerController _controller;
        private IComputerService _service;

        public ComputerControllerTest()
        {
            _service = new MemoryComputerService();
            _controller = new ComputerController(_service);
        }

        [Fact]
        public void Index_ReturnsViewResult_WithListOfComputers()
        {
          
            _service.Add(new Computer { Id = 1, Name = "Test1" });
            _service.Add(new Computer { Id = 2, Name = "Test2" });

         
            var result = _controller.Index();

  
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Computer>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

      

        [Fact]
        public void CreateTest()
        {
            
            var model = new Computer { Id = 1, Name = "Test", Processor = "Test Computer" };

           
            var result = _controller.Create(model);

       
            Assert.IsType<RedirectToActionResult>(result);
            Assert.Single(_service.FindAll()); 
        }
        [Fact]
        public void Update_Test()
        {
            
            var computer = new Computer { Id = 1, Name = "Test", Processor = "Test Computer" };
            _service.Add(computer);

            
            var result = _controller.Update(1);

            
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Computer>(viewResult.ViewData.Model);
            Assert.Equal(1, model.Id);
        }

        [Fact]
        public void Update_Post_Test()
        {
           
            var computer = new Computer { Id = 1, Name = "Test", Processor = "Test Computer" };
            _service.Add(computer);

          
            var result = _controller.Update(new Computer { Id = 1, Name = "UpdatedTest", Processor = "Updated Computer" });

         
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);

            
            var updatedComputer = _service.FindById(1);
            Assert.NotNull(updatedComputer);
            Assert.Equal("UpdatedTest", updatedComputer.Name);
            Assert.Equal("Updated Computer", updatedComputer.Processor);
        }
        [Fact]
        public void Delete_Test()
        {
           
            var computer = new Computer { Id = 1, Name = "Test", Processor = "Test Computer" };
            _service.Add(computer);

           
            var result = _controller.Delete(1);

          
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Computer>(viewResult.ViewData.Model);
            Assert.Equal(1, model.Id);
        }



    }
}
