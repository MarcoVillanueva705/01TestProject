using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Loans.Domain.Applications;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanTermShould
    {
        public void ReturnTermInMonths()
        {
            //sut = system under test
            //hiding default cnstrctr of 
            //LoanTerm causes red squiggly
            //see line 12 of LoanTerm.cs
            var sut = new LoanTerm(2);
        }
    }
}
