using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Text;
using Loans.Domain.Applications;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanTermShould
    {
        [Test]
        public void ReturnTermInMonths()
        {
            //sut = system under test
            //hiding default cnstrctr of 
            //LoanTerm causes red squiggly
            //see line 12 of LoanTerm.cs
            LoanTerm sut = new LoanTerm(2); //Arrange

            //constraint model of assertions
            //Assert.That(test result, constraint instance)
            Assert.That(sut.ToMonths(), Is.EqualTo(24));  //Assert
        }
    }
}
