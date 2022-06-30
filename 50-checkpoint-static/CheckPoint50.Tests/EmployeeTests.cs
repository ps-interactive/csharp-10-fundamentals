using Xunit;

namespace CheckPoint50.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void UpdateBonusPercentageTest()
        {
            Assert.Equal(0.15, Employee.bonusPercentage);

            Employee.UpdateBonusPercentage(0.17);

            Assert.Equal(0.17, Employee.bonusPercentage);
        }
    }
}