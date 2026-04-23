using Dsw.Ut2;
using Dsw.Ut2.Library.Attributes;

namespace Dsw2026Ej7.App;

/*
 * Problema N° 2
 * Cantidad de Pruebas: 10
 * 
 * Crear un método público "CalcularArea" que reciba 3 parámetros y retorne dos valores.
 *  
 * El primer parámetro es un número y obligatorio.
 * El segúndo también es número pero opcional.
 * El tercero es del tipo character y opcional, representa el tipo de figura. Por defecto es 'C'.
 * Los valores posibles son: 'C' para círculo, 'T' para triángulo y 'R' para rectángulo.
 * Los dos parámetros numéricos incluyen los valores necesarios para calcular el área.
 * 
 * El primer valor de retorno es una cadena de caracteres que indica el nombre de la figura.
 * El segundo valor de retorno es un número que representa el área de la figura.
 * 
 * El método debe calcular el área según la figura recibida 
 * 
 * Si alguno de los valores numéricos es 0 o menor, debe retornar 0 como valor del área y "Error" como nombre de la figura.
 * En caso de que no se reconozca el tipo de figura, debe retornar -1 como valor del área y "Error" como nombre de la figura.
 * Para los datos numéricos usar un tipo de dato punto flotante de 128 bits.
 * 
 * IMPORTANTE: El cálculo del área de cada figura se debe realizar en un método anidado al método "CalcularArea".
*/
[Code("FB5B2A84-4697-45BF-9A28-A20BBB642B13")]
[EstadoTest(TestEstado.EnPrueba)]
public class Problema2 : ProblemaBase
{
}
