using Xunit;

namespace Checkpoint43.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void CalculateBonusAndTaxTest()
        {
            int defaultBonus = 1000;
            int tax = 0;

            Employee employee = new Employee("Gill", 42, 10);

            Assert.NotNull(employee);
            
            int bonus = employee.CalculateBonusAndTax(defaultBonus, ref tax);

            Assert.Equal(1000, bonus);
            Assert.Equal(100, tax);
        }
    }
}