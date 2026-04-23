using Dsw.Ut2.Library;

namespace Dsw2026Ej7.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DswUt2Manager.Iniciar(typeof(Datos), Datos.Host);
        }
    }
}
