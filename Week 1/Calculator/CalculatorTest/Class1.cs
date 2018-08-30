using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    [TestFixture]
    public class CalcTest
    {

       

        [Test]
        public void Add_Add2and4_Returns6()
        {
            uut_ = new Methods.Calculator();
            Assert.That(uut_.Add(2, 4), is.EqualTo(6));

        }
    }

   
}
