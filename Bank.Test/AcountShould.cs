using System;
using Bank;
using Moq;
using NUnit.Framework;

namespace Bank.Test
{
    public class AccountShould
    {

        [Test]
        public void account_should_call_console()
        {
            var outputConsole = new Mock<OutputConsole>();
            outputConsole.Setup(m => m.PrintLine()).Verifiable();
            
            var account = new Account(outputConsole.Object);

            account.PrintStatement();
            
            outputConsole.Verify(m => m.PrintLine(), Times.Once());
        }
    }

}