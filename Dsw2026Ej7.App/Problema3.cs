using Dsw.Ut2;
using Dsw.Ut2.Library.Attributes;
using Dsw.Ut2.Library.Data;

namespace Dsw2026Ej7.App;
/*
 * Problema N° 4
 * Cantidad de Pruebas: 5
 * 
 * Se desea programar un método público de un bot para Counter Strike 1.6
 * Debe nombrarse "Boom", recibir un Bomb y retornar un string.
 *
 * El parámetro Bomb representa una granada, que al explotar genera una excepción.
 * Existen 3 tipos de granada, Flash, Smoke y Hand. Cada una al estallar genera su propio 
 * tipo de excepción con un mensaje particular (FlashException, SmokeException y HandException)
 * CADA TIPO TIENE SU PROPIO MENSAJE.
 * 
 * Deberá explotarse la granada con el método disponible en Bomb y retornar
 * una cadena de la forma {tipoGranada}-{mensajeDeExplosion}
 * 
 * Tener en cuenta que una granada puede no explotar.
 * 
 * Los tipos necesarios se encuentran en la librería.
 * 
 * Aclaraciones:
 *   - El mensaje específico después del guión es el que contiene la excepción
 *   - Si una granada no explota, retornar una cadena vacía.
 *
 * Ayuda: El método GetType de la clase Object devuelve el tipo de un objeto, con éste se puede
 *        saber el nombre de una clase.
*/
[Code("C6A6542B-411A-459E-8961-D8502D46D0D0")]
[EstadoTest(TestEstado.EnPrueba)]
public class Problema3 : ProblemaBase
{
}