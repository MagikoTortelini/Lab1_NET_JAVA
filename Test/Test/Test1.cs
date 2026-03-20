using Lab1;

namespace Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Test_Count()
        {
            List<int> sizes = new List<int>() { 10, 20,30,40,50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n,1);
                Assert.AreEqual(n,problem.items.Count());


            }
        }
        [TestMethod]
        public void Test_not_fitting()
        {
            Problem problem = new Problem(10, 1);
            var wynik = problem.Solve(0);
            Assert.AreEqual(0, wynik.items_number.Count());
        }
        [TestMethod]
        public void Test_selected_result()
        {
            Problem problem = new Problem(10, 3);
            var wynik = problem.Solve(20);
            Assert.AreEqual(49, wynik.value_sum);
            Assert.AreEqual(19, wynik.weight_sum);
        }
        [TestMethod]
        public void Test_at_least_one()
        {
            Problem problem = new Problem(10, 3);
            var wynik = problem.Solve(2);
            Assert.AreEqual(1, wynik.items_number.Count());
           
        }
        [TestMethod]
        public void Test_take_all()
        {
            Problem problem = new Problem(10, 3);
            int total_weight = problem.items.Sum(i => i.weight);
            int total_value = problem.items.Sum(i => i.value);
            var wynik = problem.Solve(100000);
            Assert.AreEqual(total_value, wynik.value_sum);
            Assert.AreEqual(total_weight, wynik.weight_sum);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]  
        public void Test_empty()
        {
            Problem problem = new Problem(0, 3);
            

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_negative_items()
        {
            Problem problem = new Problem(-1, 3);


        }

    }

}
