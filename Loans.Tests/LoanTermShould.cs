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
            //why is this accessing constructor?
            var sut = new LoanTerm(12);

            //Act: call method, set property, etc.

            //var numberOfMonths = sut.ToMonths();

            //Assert: compare returned value/end state with expected

            Assert.That(sut.Years, Is.EqualTo(12));
           
            //Signs of good tests:
            //Fast - We want immediate feedback on system functionality
            //Repeatable - Result should always be the same w/same circum.
            //Isolated - Should not require another test run before it
            //Trustworthy - trust test results
            //Valuable - writing for sake of it, or getting value?
        }
        
    }
}
