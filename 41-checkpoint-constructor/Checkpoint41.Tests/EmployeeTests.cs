using Xunit;

namespace Checkpoint41.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void CreateEmployeeWithConstructorTest()
        {
            Employee employee = new Employee("Gill", 42, 10);
            Assert.NotNull(employee);
            Assert.Equal("Gill", employee.name);
            Assert.Equal(42, employee.age);
            Assert.Equal(10, employee.numberOfHoursWorked);
        }
    }
}