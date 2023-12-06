using Laboratorium_3___App.Controllers;
using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Laboratorium_9___Test
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;


        public ContactControllerTest()
        {

            _service = new MemoryContactService(new CurrentDateTimeProviderServices());
            _service.Add(new Contact() { Name = "Test1" });
            _service.Add(new Contact() { Name = "Test2" });
            _controller =  new ContactController(_service);


        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view =  result as ViewResult; 
            Assert.IsType<List<Contact>>(view.Model);
            List<Contact>? list = view.Model as List<Contact>;
            Assert.NotNull(list);
            Assert.Equal(2, list.Count);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailsTestForExsistingContacts(int id)
        {
            var result = _controller.Details(id);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            Assert.IsType<Contact>(view.Model);
            Contact? model = view.Model as Contact;
            Assert.NotNull(model);
            Assert.Equal(id, model.Id);

        }
        [Fact]
        public void DetailsTestForNonExistingContact()
        {
            var result = _controller.Details(3);
            Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public void CreateTest()
        {

            Contact model = new Contact { Name = "Test", Email = "test@wsei.pl", Phone = "12312312" };
            var prevCount = _service.FindAll().Count;
            var result = _controller.Create(model);
            Assert.Equal(prevCount + 1, _service.FindAll().Count);
        }

    }
}