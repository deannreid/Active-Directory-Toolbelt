using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class PSExecutorTests
    {


        public PSExecutorTests()
        {

        }

        private PSExecutor CreatePSExecutor()
        {
            return new PSExecutor();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var pSExecutor = this.CreatePSExecutor();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
