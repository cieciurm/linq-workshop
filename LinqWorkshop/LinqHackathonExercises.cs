using System.Collections.Generic;
using System.Linq;
using Xunit;
using Shouldly;

namespace LinqWorkshop
{
    public class LinqHackathonExercises
    {
        [Fact]
        public void Ex1_CalculateAverageLengthOfWords()
        {
            var words = new[] { "abaccca", "cbdessdsaasdzx", "adasdxczvvadaww" };

            var result = 0.0f; // Your solution goes here

            result.ShouldBe(12.0f);
        }

        [Fact]
        public void Ex2_ConcatenatesInArrayWithColonSeparator()
        {
            var stringArray = Enumerable.Range(1, 10).Select(x => x.ToString()).ToArray();

            var result = string.Empty; // Your solution goes here (No string.Join()!, no loops!)

            result.ShouldBe("1,2,3,4,5,6,7,8,9,10");
        }

        [Fact]
        public void Ex3_SelectAllDistinctCharactersFromWordListInAscendingOrder()
        {
            var words = new[] { "abaccca", "cbdessdsaasdzx", "adasdxczvvadaww" };

            var result = Enumerable.Empty<char>(); // Your solution goes here

            result.ShouldBe(new[] { 'a', 'b', 'c', 'd', 'e', 's', 'v', 'w', 'x', 'z' });
        }

        [Fact]
        public void Ex4_ForeachCharCountWordsThatStartsWithIt()
        {
            var words = new[] { "abaccca", "cbdessdsaasdzx", "adasdxczvvadaww", "isdfesdf", "i" };

            var result = new Dictionary<char, int>(); // Your solution goes here

            result['a'].ShouldBe(2);
            result['c'].ShouldBe(1);
            result['i'].ShouldBe(2);
            result['b'].ShouldBe(0);
            result['z'].ShouldBe(0);
        }

        [Fact]
        public void Ex5_SplitListInToListOfListEachContainingThreeSubsequentElements()
        {
            var chars = Enumerable.Range('a', 26).Select(c => (char)c);

            var result = new List<IEnumerable<char>>(); // Your solution goes here

            result[0].ShouldBe(new[] { 'a', 'b', 'c' });
            result[1].ShouldBe(new[] { 'd', 'e', 'f' });
            result[8].ShouldBe(new[] { 'y', 'z' });
        }


        [Fact]
        public void Ex6_CalculateCategoryAveragePrice()
        {
            var category = new[]
            {
                new {Name = "Sports", Id = 1},
                new {Name = "Cars", Id = 2},
                new {Name = "Merchandise", Id = 3},
            };
            var products = new[]
            {
                new {Name = "Porsche", Price = 10000, CategoryId = 2},
                new {Name = "Volvo", Price = 8000, CategoryId = 2},
                new {Name = "Mercedes", Price = 12000, CategoryId = 2},
                new {Name = "Scott Genius", Price = 2000, CategoryId = 1},
            };

            var result =
                new[] { new { Name = "Sports", Price = 0 } } // Your solution goes here
                    .ToDictionary(x => x.Name, x => x.Price);

            result["Sports"].ShouldBe(2000);
            result["Cars"].ShouldBe(10000);
            result["Merchandise"].ShouldBe(0);
        }

        [Fact]
        public void Ex7_CalculateTriangleSolutionNumberLessThen100()
        {
            // |{(a,b,c) | a^2+b^2=c^2 and 0 < a,b,c <= 100}| 

            var result = new[] { new { a = 3, b = 4, c = 5 } }; // Your solution goes here

            result.Count().ShouldBe(52);
        }

        [Fact]
        public void Ex8_CalculateFiftiethFibonacciNumber()
        {
            // F_0 = 0, F_1 = 1, F_2 = 1, ...

            var result = -1L; // Your solution goes here

            result.ShouldBe(12586269025L);
        }

        [Fact]
        public void Ex9_CalculatePolynomialValue()
        {
            var coefs = new[]
            {
                new {a = 2, p = 4},
                new {a = -5, p = 2},
                new {a = 4, p = 1},
                new {a = 1, p = 0},
            };
            var pt = 2;

            var result = 0; // Your solution goes here

            result.ShouldBe(21);
        }

        [Fact]
        public void Ex10_SelectGreatestProductFromGrid()
        {
            // select greatest product of four adjacent element in the grid( up, down, right,left, diagonally) 70600674
            var grid = new[,]
            {
                {08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08},
                {49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00},
                {81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65},
                {52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91},
                {22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80},
                {24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50},
                {32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70},
                {67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21},
                {24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72},
                {21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95},
                {78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92},
                {16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57},
                {86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58},
                {19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40},
                {04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66},
                {88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69},
                {04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36},
                {20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16},
                {20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54},
                {01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48},
            };

            var result = -1;

            result.ShouldBe(70600674);
        }
    }
}
