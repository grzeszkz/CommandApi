using System;
using System.Collections.Generic;
using CommandApi.Models;
using Xunit;

namespace CommandApi.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };
        }
        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange

            //Act
            testCommand.HowTo = "Execute Unit Tests";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange

            //Act
            testCommand.Platform = "mstest";
            //Assert
            Assert.Equal("mstest", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange

            //Act
            testCommand.CommandLine = "dotnet test ccc";
            //Assert
            Assert.Equal("dotnet test ccc", testCommand.CommandLine);
        }
    }
}
