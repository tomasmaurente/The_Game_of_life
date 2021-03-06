using System.Text;

/*
    Clase que crea un string que representa el tablero.
    Esta clase no se definió como metodo de tablero ya que de querer cambiar el metodo de impresion, o agregarle algun tipo de mesaje, 
    el metodo imprimir debería cambiar, creando asi otro razón de cambio en tablero. Para seguir con el patrón SRP, creamos la clase Imprimir.
*/

namespace PII_Game_Of_Life
{
    public class Imprimir
    {
        public static string TableroToString(Tablero nuevaTabla)
        {
            int width = nuevaTabla.Width;
            int height = nuevaTabla.Heigth;

            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(nuevaTabla.SaberValorPosicion(x,y))
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return (s.ToString());
        }
    }
}