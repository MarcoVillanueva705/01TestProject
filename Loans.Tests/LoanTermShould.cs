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

            //Arrange: set up test object(s), initialize test data, thing
            //we want to test
        }
        [Test]
        public void storeYears()
        {

            var sut = new LoanTerm(1);

            //Act: call method, set property, etc.

            //var numberOfMonths = sut.ToMonths();

            //Assert: compare returned value/end state with expected

            Assert.That(sut.Years, Is.EqualTo(12));
        }
        
    }
}
