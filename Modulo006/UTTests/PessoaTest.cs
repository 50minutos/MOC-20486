using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace UTTests
{
    [TestClass]
    public class PessoaTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var c = new UT.Controllers.PessoaController();

            var v = c.Index();

            Assert.IsNotNull(v);
            Assert.IsInstanceOfType(v, typeof(ViewResult));
        }

        [TestMethod]
        public void TestEdit()
        {
            var c = new UT.Controllers.PessoaController();

            var v = c.Edit(1) as ViewResult;

            Assert.IsNotNull(v);
            Assert.AreEqual("ADAO", ((DBModel.Pessoa)v.ViewData.Model).PessoaNome);
        }
    }
}
