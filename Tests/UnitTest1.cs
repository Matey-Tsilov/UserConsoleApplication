using System.Reflection.Metadata;
using UserManagment.Classes;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void User_Payment_Is_Normal()
        {
            //Arrange
            User test = new User("Test", "test@gmail.com", "12345678");
            //Act
            int payment = test.DollersPerHour;
            //Assert
            Assert.Equal(5, payment);
        }
        [Fact]
        public void Upgraded_User_Pyament_Is_Normal()
        {
            UpgradedUser test2 = new("Matey", "matey@gmail.com", "123");
            int payment = test2.DollersPerHour;
            Assert.True(payment > 0);
        }
        [Fact]
        public void Premium_User_Pyament_Is_Normal()
        {
            UpgradedUser test2 = new("Matey", "matey@gmail.com", "123");
            int payment = test2.DollersPerHour;
            Assert.True(payment > 0);
        }
    }
}