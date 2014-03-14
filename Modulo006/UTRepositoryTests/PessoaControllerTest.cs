using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTRepository.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using UTRepository.Models;

namespace UTRepositoryTests
{
    [TestClass]
    public class PessoaControllerTest
    {
        InMemoryPessoaRepository db = new InMemoryPessoaRepository();

        [TestMethod]
        public void TestIndex()
        {
            var c = new PessoaController(db);

            var v = c.Index();

            Assert.IsNotNull(v);

            var vr = v as ViewResult;

            Assert.IsNotNull(vr);

            var model = vr.ViewData.Model as List<Pessoa>;

            CollectionAssert.Contains(model, db.Get(1));
            CollectionAssert.Contains(model, db.Get(2));
        }
        [TestMethod]
        public void TestEdit()
        {
            var c = new PessoaController(db);

            var v = c.Edit(1) as ViewResult;

            Assert.IsNotNull(v);

            var model = v.ViewData.Model as Pessoa;

            Assert.AreEqual("adao", model.PessoaNome);
        }

        [TestMethod]
        public void TestProcessEdit() //dados inválidos
        {
            var c = new PessoaController(db);

            c.ModelState.AddModelError("", "erro para teste");

            var v = c.Edit(db.Get(1)) as ViewResult;

            Assert.IsNotNull(v);
            Assert.AreEqual("Edit", v.ViewName);
        }
    }
}
