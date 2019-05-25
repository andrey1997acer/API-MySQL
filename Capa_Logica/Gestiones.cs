using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;

namespace Capa_Logica
{
    public class Gestiones
    {

        #region[ATRIBUTOS]
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        Conexion conn = new Conexion();

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Password { get => password; set => password = value; }
        public Conexion Conn { get => conn; set => conn = value; }
        public string Port { get => port; set => port = value; }
        #endregion

        #region [CONSTRUT]
        public Gestiones()
        {
           
        }
        #endregion

        #region [METODOS]
        public bool SetConnection(string server, string port, string database, string userId, string password)//Returns TRUE or FALSE if there is connection to the parameters sent to the database
        {
            this.Server = server;
            this.Port = port;
            this.Database = database;
            this.Uid = userId;
            this.Password = password;
            return Conn.SetConexion(Server, Port, Database, Uid, Password);
            
        } 
        public bool ConnectMySql() //Connects the database to the server after you establish the connection to SetConnection () and returns TRUE or FALSE if I succeed in the process.

        {

            return Conn.OpenConnection();


        }
        public bool DisconnectMySql()//Disconnects the database with the server and returns TRUE or FALSE if I succeed in the process.
        {

            return Conn.CloseConnection();


        }
        public bool GetStatusConnection()//Gets whether or not the database is connected to the server
        {
           return Conn.StatusConexion;
        }
        public string GetStringConnection()//Get the entire connection path in the that works on server
        {
            return Conn.GenerarStringConexion();
        }
        public DataSet GetQuery(string query)//Get a DataSet with the data that returns the query request
        {
             return Conn.Consulta(query);
            
            
        }
        public string SetQuery(string query)//Gets a string with the status of the query sent
        {
             return Conn.sentenciaSql(query);
        }
        public DataTable GetListProcedures()//Get the entire list of procedures from the current database
        {
            return Conn.ListaProcedimientos();
        }
        public DataTable GetListFunction()//Get the entire list of functions from the current database
        {
            return Conn.ListarFuncion();
        }
        public DataTable GetProceduralParameters(string Procedure)//Get all the information about the current procedure
        {
            return Conn.parametrosProcedimiento(Procedure);
        }
        public DataTable GetFunctionParameters(string function)//Get all the information about the current function
        {
            return Conn.GetParametrosFuncion(function);
        }
        public DataSet GetFunctionAndProcedures( string parent,string nameProcedures, string[] Parameter, string[] value,string[] dataType)//Gets the data from the query that the procedure or function order parameter is sent

        {
            return Conn.FunctionAndProcedures(parent, nameProcedures, Parameter, value,dataType);
        }
        public string GetFunctionStructure()//Gets the structure of the function
        {
            return Conn.StructureFunction();
        }
        public string GetProceduresStructure()//Gets the structure of the stored procedure
        {
            return Conn.estructuraProcedimiento();
        }
        #endregion

    }
}
