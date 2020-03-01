using AppPrivy.InfraStructure.Contexto;
using AppPrivy.InfraStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;

namespace AppPrivy.Test
{
    [TestClass]
    public class EFTestNum1
    {
        private DoacaoMaisContext _context;


        [TestMethod]
        public void TesteConexao()
        {
            _context = new DoacaoMaisContext( new DbContextOptions<DoacaoMaisContext>());

            Assert.IsNotNull(_context,"Conta não foi debitada corretamente");
        }

    }

}
