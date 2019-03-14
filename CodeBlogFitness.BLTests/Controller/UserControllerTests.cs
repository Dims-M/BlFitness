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
            // 1) Arrange
            var userName = Guid.NewGuid().ToString();
            var birthdate = DateTime.Now.AddYears(-18)  ; // дата рождения
            var weight = 90;
            var height = 190;
            var gender = "man";
            var controller = new UserController(userName); //получение контролера
            //Assert.Fail(); // Выбить ошибку при тесте.
           // controller.SetNewUserData(gender,birthdate,weight,height); // новый пользователь

            // 2) Act - непосрественное действие. Когда вызываем что то
            controller.SetNewUserData(gender,birthdate,weight,height); // новый пользователь
            var  controller2 = new UserController(userName);

            //3) Assert - Проверка того что получилось
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
           // Assert.AreEqual(userName, controller2.CurrentUser.BirthDate);
          //  Assert.AreEqual(userName, controller2.CurrentUser.Cender);
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