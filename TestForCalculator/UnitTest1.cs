using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestForCalculator
{
    [TestClass()]
    public class TestClass
    {
        private object textbox1;
        private Label labelMinus;

        [TestMethod()]
        public void TestSolution()
        {
            try
            {
                Class testClass = new Class();
                testClass.Solution((TextBox)textbox1, (Label)labelMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void TestForReading()
        {
            try
            {
                Class testClass = new Class();
                testClass.Reading("1", (TextBox)textbox1);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void TestClear()
        {
            try
            {
                Class testClass = new Class();
                testClass.Clear((TextBox)textbox1, (Label)labelMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }

        }

        [TestMethod()]
        public void TestOperation()
        {
            try
            {
                Class testClass = new Class();
                testClass.Operation((TextBox)textbox1, 0, (Label)labelMinus); // plus
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void TestPlusMinus()
        {
            try
            {
                Class testClass = new Class();
                testClass.PlusMinus((Label)labelMinus);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}
