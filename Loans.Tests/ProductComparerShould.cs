﻿using NUnit.Framework;
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
            //Report exrpressions
            //more SQL exrpressions
            //Aggregate functions
            //Conditional formatting
            //using expressions
            //report parameters
            //using parameters
            //linked reports
            //configuring a dril-through
            //parameters in expressions
            //cascading parameters
            //connecting a report to a query parameter
            //Reporting Services Report Development Fundamentals - Part 1
            //Intro to SQL
            //SELECT List wild cards
            //SQL DISTINCT keyword
            //WHERE clause and BOOLEANs
            //AND & OR Operators
            //SQL BETWEEN Operator
            //NULL, NOT NULL, IS, LIKE and IN Operators
            //SQL ORDER BY keyword
            //CTE (Common Table Expressions)
            //SET functions
            //GROUP BY intro
            //GROUP BY cont.
            //HAVING SET function; GROUP BY
            //HAVING keyword cont.
            //CROSS, INNER, OUTER, LEFT, RIGHT JOIN
            //OUTER and SELF JOINS
            //CREATE DB and Tables
            //DEMO CREATE DB, Tables and Columns
            //CREATE, DROP, ALTER Table
            //SQL Server Querying
            //SQL Querying Intro to Relational DBs
            //Table relationship types
            //Relational DB design
            //Orders and Products design
            //Using SELECT statements
            //WHERE and Predicate statements
            //JOIN statements and syntax
            //JOIN basics
            //LEFT, RIGHT, INNER JOINS
            //Sub-queries
            //GROUP BY
            //GROUP BY continued
            //HAVING vs WHERE
            //data rollups/grouping sets
            //ranking functions
            //PA getting started
            //PA Discoveries Dashboard
            //PA: Workspace panels, Ad hoc analysis and CMS 
            //PA Walkthrough: Grid drop zones, themes and runtime settings
            //PA Activity (part 1): Grid drop zones, themes and runtime settings
            //PA Activity (part 2): Grid drop zones, themes and runtime settings
            //PA Walkthrough: Combo charts
            //PA Walkthrough: Slicers and Lollipop charts part I
            //PA Walkthrough: Viewer Analyze Further / Discover Lite
            //PA Dashboard Walkthrough review
            //Filtering the displayed data
            //PS DISTINCT statement
            //PS Built In Functions: Date/Time
            //PS Data type conversions
            //PS Query Plans Index vs Scan
            //PS Query Hints
            //PS Modifying Data / Dynamic SQL
            //PS UPDATE Statements
            //PS DELETE Statements
            //PS MERGE Statements
            //PS MERGE and OUTPUT Statements
            //PS SSRS playbook
            //PS Designing and Implementing SQLTables and Views
            //PS Creating Tables Before Demo 1
            //YT #Temp tables
            //YT SQL Stored Procedures Pt.1
            //YT SQL Stored Procedures Pt.2
            //YT SQL Benefits of SPs
            //YT SQL Drawacks of SPs
            //YT SQL SSMS Pt.1
            //PS SQL Intro to T-SQL
            //PS SQL Intro:Group BY
            //PS SQL Intro: Having BY
            //PS SQL CTEs
            //PS SQL SSRS Headers
            //PS SQL Adding a Chart
            //PS SQL Using Parameters in a Report
            //MS Azure Explore Azure Compute Services
            //MS Azure Express Route Fundamentals
            //MS Explore Azure SQL Managed Instance

    }

}

