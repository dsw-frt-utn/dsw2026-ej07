using Dsw.Ut2.Library;
using Dsw2026Ej7.App;

namespace Dsw2026Ej7.Tests
{
    [TestClass]
    public partial class ProblemasTest : EnsambladoTestBase
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            IniciarGeneral(typeof(Datos), Datos.Host);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [ClassCleanup]
        public static void Cleanup()
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            
        }
    }
}
