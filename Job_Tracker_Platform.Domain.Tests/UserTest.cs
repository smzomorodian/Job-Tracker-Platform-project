using Job_Tracker_Platform.Domain.Models;

namespace Job_Tracker_Platform.Domain.Tests
{
    public class UserTest
    {
        [Fact]
        public void Constructor_Should_Create_User_When_Data_Is_Valid()
        {
            var user = new User(
                       Guid.NewGuid(),
                       "Ali",
                       "Ahmadi",
                       new DateTime(2000, 1, 1));

            Assert.NotNull(user);

            Assert.Equal("Ali", user.FirstName);

            Assert.Equal("Ahmadi", user.LastName);
        }
        [Fact]
        public void Constructor_Should_Exeption_User_When_Firstname_Is_Null()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new User(
                    Guid.NewGuid(),
                    "",
                    "Ahmadi",
                    new DateTime(2000, 1, 1));
            });
        }
        [Fact]
        public void Constructor_Should_Exeption_User_When_Lastname_Is_Null()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new User(
                    Guid.NewGuid(),
                    "Ali",
                    "",
                    new DateTime(2000, 1, 1));
            });
        }
        [Fact]
        public void Constructor_Should_Update_User_When_Data_Is_Valid()
        {
            var user = new User(
            Guid.NewGuid(),
            "Ali",
            "Ahmadi",
            new DateTime(2000, 1, 1));

            user.updateuser(
            "Reza",
            "Mohammadi",
            new DateTime(1998, 5, 10));


            Assert.Equal("Reza", user.FirstName);
            Assert.Equal("Mohammadi", user.LastName);
            Assert.Equal(new DateTime(1998, 5, 10), user.DateOfBirth);

        }
        [Fact]
        public void UpdateUser_Should_Update_User_When_Firstname_Is_Null()
        {
            var user = new User(
                        Guid.NewGuid(),
                        "Ali",
                        "Ahmadi",
                        new DateTime(2000, 1, 1));
            Assert.Throws<ArgumentException>(() =>
            {
                user.updateuser(
                            "",
                            "Mohammadi",
                            new DateTime(1998, 5, 10));
            });
        }
        [Fact]
        public void UpdateUser_Should_Update_User_When_Lastname_Is_Null()
        {
            var user = new User(
                        Guid.NewGuid(),
                        "Ali",
                        "Ahmadi",
                        new DateTime(2000, 1, 1));
            Assert.Throws<ArgumentException>(() =>
            {
                user.updateuser(
                            "Reza",
                            "",
                            new DateTime(1998, 5, 10));
            });
        }
    }
}