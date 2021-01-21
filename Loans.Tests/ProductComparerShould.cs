using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
//using directive for LoanProduct
using Loans.Domain.Applications;

namespace Loans.Tests
{
    public class ProductComparerShould
    {
        [Test]
        public void ReturnCorrectNumberOfComparisons()
        {
            var products = new List<LoanProduct>()
            {
            
                //we expect one product in the 
                //comparison output
            new LoanProduct(1, "a", 1)
            };
            //ProductComparer has a number of params to provide
            //in the constructor; 200K decimal literal (hence the 'm')
            var sut = new ProductComparer(new LoanAmount("USD", 200_000m), products);


            List<MonthlyRepaymentComparison> compare = sut.CompareMonthlyRepayments(new LoanTerm(30));

            //the Has helper class
            //var sut has 'products' list passed as param
            Assert.That(compare, Has.Exactly(1).Items);
        }
    }
}
