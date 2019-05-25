using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Conexion
{
    class ExceptionSQL
    {


        public string ErrorSQL(string code)
        {
            if (code == "1062")
            {
                return "Error la cedula se encuentra repetida.";
            }
            else if(code == "1054")
            {
                return "Error de sintaxis, verifique la cadena enviada.";
            }
            else if (code == "1146")
            {
                return "Error de sintaxis, no existe el nombre de la tabla.";
            }
            else if (code == "1064")
            {
                return "Error de sintaxis, en el Comando.";
            }
            else if (code == "1072")
            {
                return "Error de sintaxis, parametro mal escrito.";
            }
            else if (code == "1286")
            {
                return "Error de sintaxis, motor de almacenamiento mal escrito";
            }
            else if (code == "1004")
            {
                return "Error, No se puede crear archivo";
            }
            else

            {
                return "ERROR " + code;
            }
            
        }
        public string ErrorSqlHresult(string Hresult)
        {
            if(Hresult == "-2147467259")
            {
                return "Error, No existe el puerto especifico";
            }
            else
            {
                return "Error " + Hresult; 
            }
            
        }
    }
}
