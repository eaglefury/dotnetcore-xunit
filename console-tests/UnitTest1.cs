using System;
using sample_console_app;
using Xunit;

namespace console_tests {
    public class UnitTest1 {
        [Fact]
        public void TestForUserMessage () {
            User user = new User ("gk", 5);
            var userMessage = user.getUserDetails ();
            Console.WriteLine (userMessage);
            Assert.True (userMessage.Contains ("gk"));
        }
    }
}