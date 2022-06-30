using Xunit;

namespace Checkpoint44.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void CalculateBonusAndTaxTest()
        {
            int defaultBonus = 1000;
            int tax;

            Employee employee = new Employee("Gill", 42, 10);
            Assert.NotNull(employee);

            int bonus = employee.CalculateBonusAndTax(defaultBonus, out tax);

            Assert.Equal(defaultBonus, bonus);
            Assert.Equal(100, tax);
        }
    }
}