using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.unit.test
{
    [TestFixture]
    public class unittest
    {
        private Calculator uut_;
        [SetUp]
        public void Setup()
        {
            uut_ = new Calculator();
        }

        /**************************
         **************************
           TESTING ADD METHOD
         **************************
         **************************/

        [Test]
        public void add_2plus2is4()
        {
            Assert.That(uut_.Add(2, 2), Is.EqualTo(4));
        }

        [Test]
        public void add_m5plus2ism3()
        {
            Assert.That(uut_.Add(-5, 2), Is.EqualTo(-3));
        }

        [Test]
        public void add_5plus5isnot90()
        {
            Assert.That(uut_.Add(5,5), Is.Not.EqualTo(90));
        }

        /**************************
         **************************
           TESTING SUBTRACT METHOD
         **************************
         **************************/

        [Test]
        public void sub_5and3is2()
        {
            Assert.That(uut_.Subtract(5, 3), Is.EqualTo(2));
        }

        [Test]
        public void sub_m5a3ism2()
        {
            Assert.That(uut_.Subtract(-5, 3), Is.EqualTo(-8));
        }

        [Test]
        public void sub_m5am5isnotm100()
        {
            Assert.That(uut_.Subtract(-5,-5), Is.Not.EqualTo(-100));
        }

        /**************************
         **************************
           TESTING POWER METHOD
         **************************
         **************************/

        [Test]
        public void pow_5exp2is25()
        {
            Assert.That(uut_.Power(5, 2), Is.EqualTo(25));
        }

        [Test]
        public void pow_2exp2isnot25()
        {
            Assert.That(uut_.Power(2, 2), Is.Not.EqualTo(25));
        }

        [Test]
        public void pow_5exp10is9765625()
        {
            Assert.That(uut_.Power(5, 10), Is.EqualTo(9765625));
        }



        /**************************
         **************************
           TESTING MULTIPLY METHOD
         **************************
         **************************/

        [Test]
        public void mub_2t10i20()
        {
            Assert.That(uut_.Multiply(2, 10), Is.EqualTo(20));
        }

        [Test]
        public void mub_3t3i9()
        {
            Assert.That(uut_.Multiply(3,3), Is.EqualTo(9));
        }

        [Test]
        public void mub_3t3isnot99()
        {
            Assert.That(uut_.Multiply(3, 3), Is.Not.EqualTo(99));
        }

        /**************************
         **************************
           TESTING DIVIDE METHOD
         **************************
         **************************/

        [Test]
        public void Div_5divby10is0point5()
        {
            Assert.That(uut_.Divide(5, 10), Is.EqualTo(0.5));
        }

        [Test]
        public void Div_10divby10is1()
        {
            Assert.That(uut_.Divide(10,10), Is.EqualTo(1));
        }

        [Test]
        public void Div_5divby400isnot9()
        {
            Assert.That(uut_.Divide(5,400), Is.Not.EqualTo(9));
        }

        /**************************
         **************************
           TESTING DIVIDE EXCEPTIONS
         **************************
         **************************/

        [Test]
        public void Dividend0_AssertThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => uut_.Divide(0, 2));
        }

        [Test]
        public void Divisor0_AssertThrowException()
        {

            Assert.Throws<DivideByZeroException>(() => uut_.Divide(10, 0));
        }

        /**************************
         **************************
           TESTING POWER EXCEPTIONS
         **************************
         **************************/

        [Test]
        public void ExpIs2_AssertNoException()
        {
            Assert.DoesNotThrow(() => uut_.Power(2, 2));
        }

        [Test]
        public void ExpIs0_AssertThrowException()
        {
            Assert.Throws<Exception>(() => uut_.Power(5, 0));
        }

    }
}
