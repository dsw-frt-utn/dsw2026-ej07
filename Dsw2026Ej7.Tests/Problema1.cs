using Dsw.Ut2.Library;
using Dsw2026Ej7.App;


namespace Dsw2026Ej7.Tests
{
    [TestClass]
    public partial class ProblemaTest1 : ProblemaTestBase<Problema1>
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            Iniciar();
        }

        [TestMethod]
        public void Test1()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test2()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test3()
        {
            Evaluar();
        }
    }
}
