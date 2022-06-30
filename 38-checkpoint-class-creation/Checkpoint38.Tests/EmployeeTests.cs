using Xunit;

namespace Checkpoint38.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void EmployeeTest()
        {
            Employee employee = new Employee();

            Assert.NotNull(employee);
        }
    }
}