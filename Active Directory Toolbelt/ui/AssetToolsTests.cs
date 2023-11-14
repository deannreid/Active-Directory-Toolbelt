using Active_Directory_Toolbelt.ui;
using FakeItEasy;
using System;
using Xunit;

namespace Active_Directory_Toolbelt.ui
{
    public class AssetToolsTests
    {


        public AssetToolsTests()
        {

        }

        private AssetTools CreateAssetTools()
        {
            return new AssetTools();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var assetTools = this.CreateAssetTools();

            // Act


            // Assert
            Assert.True(false);
        }
    }
}
