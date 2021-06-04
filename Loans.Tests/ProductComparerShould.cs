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
            //continue TRY CATCH 2/21
            //interpret code in TRY CATCH block
            //Defensive coding
            //why move commit transaction?
            //review of SQL notes
            //relational DBs
            //studied classes in c#
            //NUnit 3 review
            //more NUnit 3 
            //Querying data with T-SQL
            //more SQL review
            //code a long SQL
            // powerApps study
            //tutorial on SPs 
            //MS Power Apps
            //DB security notes
        }   //more auth notes
            //SQL practice notes
            //more SQL tomorrow
            //intermediate SQL statments
            //SQL intermediate quiz 2.0
            //worked on SQL
            //SQL injection
            //SP best practices
            //worked on RD cover letter
            //worked on ?s for RD
            //studied FKs and PKs in SQL
            //SQL JOINS
            //SQL joining tables without JOINS
            //SQL exercises
            //ORDER BY VS GROUP BY SQL
            //JOINS andd GROUP vs ORDER
            //aggregate functions
            //more SQL queries
            //more SQL practice
            //SQL sub-queries
            //more sub-query exercises
            //SQL flashcards
            //notes on GROUP BY vs ORDER BY   
            //SQL flashcards
            //studied SQL FCs and practice queries
            //SQL 2x ORDER BY
            //SQL flashcards/SELECTS
            //INNER JOIN/SELECT review
            //SQL flashcards
            //JOINS and MISC review
            //SQL for work
            //Self JOINS
            //SQL practice and Power Apps
            //more SQL tomorrow
            //Reporting Services Report Development
            // SSRS cont.
            //more SSRS
            //reconnect GitHub for test Report
            //SQL data sets
            //Report items
            //Data Regions
            //Matrix and Lists SSRDS
            //SSRDS rows and columns
            //working with Tablix
            //matrix vs tables
            //SSRS part 1
            //SQL review Order of Operations
            //SQL SSRS review
            //ORDER BY VS GROUP BY
            //AVG BETWEEN and ORDER BY
            //SQL #Temp Tables
            //Creating adjacent groups
            //Expressions SQL notes
            //Tablix row groups
            //matrices grouping
            //expressions
            //row groups expressions

    }
}
_
