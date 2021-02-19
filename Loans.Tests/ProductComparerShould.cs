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
            //**Below tests how many items in the list there are
            Assert.That(compare, Has.Exactly(1).Items);
            //was studying SQL
        }

        [Test]
        public void ReturnNotDuplicates()
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
            //**Below tests if list of items are unique**
            //Assert.That(compare, Is.Unique);
            //was studying SQL
            //figured out what "sut" is:
            //we are comparing a loan amount, the list of products
            //and class Product Comparer stored in "sut" and its' Loan Term property
            Assert.That(compare, Has.Exactly(1).Items);
            //^^How is 'compare' the list of products?^^
            //Answer: b/c new instance of ProductComparer ctor takes
            //two parameters: LoanAmt and list of products
            //both private fields, but accessible through public ctor
        }

        [Test]
        public void ReturnFirstProdCompare_WithPartialKnownExpectedVals()
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

            //'Has' is aka helper class
            Assert.That(compare, Has.Exactly(1)
                .Property("ProductName").EqualTo("a")
                    .And //called a 'modifier'
                .Property("InterestRate").EqualTo(1)
                    .And
                    //don't know where in LoanProduct does MonthlyRepayment
                    //come from
                    .Property("MonthlyRepayment").GreaterThanOrEqualTo(0));
            //was studying SPs in SQL
            //SP coursework tomorrow
            //SQL Server Functions
            //Output parameters SPs
            //ContactId
            //Output param notes
            //work more on SPs tomorrow
            //worked on chaining procedures
            //IF EXISTS clause
            //reviewed power apps
            //Adding business logic to SPs
            //notes for SP tomorrow
            //worked on SPs earlier; combine notes
            //SP notes on debugging
            //Troubleshooting notes
            //translated the SP for city and street
            //finished up PRINT statement section
            //Began TRY CATCH segment of course
        }


    }
}
