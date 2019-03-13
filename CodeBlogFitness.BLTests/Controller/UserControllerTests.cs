using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
       
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveTest()
        {
           // Assert.Fail();

            //Правило 3 А
            // 1) Arrange  - oбьявление
            var userName = Guid.NewGuid().ToString(); // имя пользователя в случайно наборе параметров(для тестирования)
           

            // 2) Act - непосрественное действие. Когда вызываем что то
            var controller = new UserController(userName);

            //3) Assert - Проверка того что получилось
            // сравниваем 2 обьекта. То что пришло а качестве 1го параметра и "этолонный" из аригиналного класса
            Assert.AreEqual(userName, controller.CurrentUser.Name); 

        }
    }
}