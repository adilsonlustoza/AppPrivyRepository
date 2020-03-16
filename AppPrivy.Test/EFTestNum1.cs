using AppPrivy.InfraStructure.Contexto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;

namespace AppPrivy.Test
{
    [TestClass]
    public class EFTestNum1
    {
        private AppPrivyContext _context;


        [TestMethod]
        public void TesteConexao()
        {
            _context = new AppPrivyContext( new DbContextOptions<AppPrivyContext>());

            Assert.IsNotNull(_context,"Conta não foi debitada corretamente");
        }

    }

}
