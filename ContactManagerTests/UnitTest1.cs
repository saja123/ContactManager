
using ContactManager;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Xunit;

namespace ContactManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddContact()
        {
            // Arrange
            Program.contacts = new List<string>(); 

            // Act
            Program.AddContact("John Doe");

            // Assert
            Assert.Contains("John Doe", Program.contacts);
        }

        [Fact]
        public void TestAddDuplicateContact()
        {
            // Arrange
            Program.contacts = new List<string> { "John Doe" };

            // Act
            Program.AddContact("John Doe");

            // Assert
            Assert.Single(Program.contacts);
        }

        [Fact]
        public void TestAddEmptyContact()
        {
            // Arrange
            Program.contacts = new List<string>();

            // Act
            Program.AddContact("");

            // Assert
            Assert.Empty(Program.contacts);
        }

        [Fact]
        public void TestAddNullContact()
        {
            // Arrange
            Program.contacts = new List<string>();

            // Act
            Program.AddContact("");

            // Assert
            Assert.Empty(Program.contacts);
        }
    }
}