using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.utils
{
    public class FuncionesGenerales
    {
        public Boolean leerDatosConexion()
        {
            try
            {
                string directorio = System.AppDomain.CurrentDomain.BaseDirectory + "Datos.txt";
                string[] lines = System.IO.File.ReadAllLines(@directorio);
                string allLine = "";
                foreach (string line in lines)
                {
                    allLine = allLine + line;
                }
                string[] arr = allLine.Split('|');
                string servidor = arr[1];
                string baseDatos = arr[3];
                string usuario = arr[5];
                string clave = arr[7];
                string puerto = arr[9];
                
                string cadenaConexion = "server=" + servidor + ";" + "user id=" + usuario + ";" + "password=" + clave + ";" + "port=" + puerto + ";" + "database=" + baseDatos + ";";
                Globales.CADENA_CONEXION = cadenaConexion;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static string Encriptar(string cadenaEncriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaEncriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string DesEncriptar(string cadenaEncriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaEncriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
