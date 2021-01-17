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
            //You may also add custom Throw Error Messages
            Assert.That(sut.ToMonths(), Is.EqualTo(12), "Months should be 12 * Number of Years!");  //Assert

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
        [Test]
        public void RespectValueEquality()
        {
            var a = new LoanTerm(1);
            var b = new LoanTerm(1);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void RespectValueInequality()
        {
            var a = new LoanTerm(2);
            var b = new LoanTerm(3);

            Assert.That(a, Is.Not.EqualTo(b));
       
        }
        
        //Constraint Model of Assertions (Newer)
        //Assert.That(sut.Years, Is.EqualTo(1));
        //Assert.That(test result, constraint instance);
        //Asserting on Equality

        [Test]
        public void RefEqualExample()
        {
            var a = new LoanTerm(1);
            var b = a;
            var c = new LoanTerm(1);

        //SameAs method points to references, not values.
        //The below passes
           Assert.That(a, Is.SameAs(b));
           Assert.That(b, Is.Not.SameAs(c));
        //the below fails
        //Assert.That(b, Is.SameAs(c));


            //Is.EqualTo would pass because LoanTerm
            //overrides the EqualsTo method

            //SameAs method only going to compare
            //references, and that's why it fails
        }
    }
}
