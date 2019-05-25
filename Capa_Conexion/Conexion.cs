using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Capa_Conexion
{

    public class Conexion
    {
        #region [ATRIBUTOS]
        ExceptionSQL validation;
        //Declaramos los atributos como private solo accesible desde
        //los métodos de las clase
        private MySqlConnection connection;

        bool statusConexion = false;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        string connectionString;
         
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Password { get => password; set => password = value; }
        public string Port { get => port; set => port = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public MySqlConnection Connection { get => connection; set => connection = value; }
        public bool StatusConexion { get => statusConexion; set => statusConexion = value; }
        internal ExceptionSQL Validation { get => validation; set => validation = value; }

        #endregion

        #region[CONSTRUT]
        public Conexion()
        {
            Validation = new ExceptionSQL();
        }
        #endregion

        #region METODOS
        public bool SetConexion(string server,string port, string database, string uid, string password )
        {
            try
            {
                this.Server = server;
                this.Port = port;
                this.Database = database;
                this.Uid = uid;
                this.Password = password;



                ConnectionString = "SERVER=" + Server + ";" + "PORT=" + Port + ";" + "DATABASE=" +
                Database + ";" + "UID=" + Uid + ";" + "PASSWORD=" + Password + ";";


                Connection = new MySqlConnection();
                Connection.ConnectionString = ConnectionString;
                if (OpenConnection())
                {
                    CloseConnection();
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (MySqlException e)
            {
                Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));

                return false;
            }
           

        }
        public string StructureFunction()
        {
            return "CREATE FUNCTION `new_function` ()" +
                "\r\nRETURNS INTEGER DETERMINISTIC" +
                "\r\nBEGIN" +
                "\r\n\r\nRETURN 1;" +
                "\r\nEND ";
        }
        public string estructuraProcedimiento()
        {
            return "CREATE PROCEDURE `new_procedure` ()" +
                "\r\nBEGIN" +
                "\r\n\r\nEND";
        }
        public DataTable ListarFuncion()
        {
            if (statusConexion != false)
            {
                MySqlCommand cm;
                MySqlDataAdapter da;
                DataTable ds;
                
                try
                {

                    string cadenaConsulta = "SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES " +
                        "WHERE ROUTINE_TYPE = 'FUNCTION' AND ROUTINE_SCHEMA = '" + Database + "'ORDER BY ROUTINE_NAME ";
                    cm = new MySqlCommand();
                    cm.CommandText = cadenaConsulta;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Connection;

                    da = new MySqlDataAdapter(cm);

                    ds = new DataTable();
                    da.Fill(ds);
                    return ds;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));

                    return null;
                }
            }
            else
            {
                return null;
            }

            
        }
        public DataTable ListaProcedimientos()
        {
            if (statusConexion != false)
            {
                MySqlCommand cm;
                MySqlDataAdapter da;
                DataTable ds;
                try
                {

                    string cadenaConsulta = "SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES " +
                        "WHERE ROUTINE_TYPE = 'PROCEDURE' AND ROUTINE_SCHEMA = '" + Database + "'ORDER BY ROUTINE_NAME ";
                    cm = new MySqlCommand();
                    cm.CommandText = cadenaConsulta;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Connection;

                    da = new MySqlDataAdapter(cm);

                    ds = new DataTable();
                    da.Fill(ds);
                    return ds;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));

                    return null;
                }
            }
            else
            {
                return null;
            }

        }
        public DataTable parametrosProcedimiento(string procedimiento)
        {
            if (statusConexion != false)
            {
                
                try
                {
                    MySqlCommand cm;
                    MySqlDataAdapter da;
                    DataTable ds;
                    string cadenaConsulta = "SHOW CREATE PROCEDURE " + procedimiento.ToString();
                    cm = new MySqlCommand();
                    cm.CommandText = cadenaConsulta;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Connection;

                    da = new MySqlDataAdapter(cm);

                    ds = new DataTable();
                    da.Fill(ds);
                    return ds;



                }
                catch (MySqlException e)
                {
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));

                    return null;
                }
            }
            else
            {
                return null;
            }

        }
        public DataTable GetParametrosFuncion(string procedimiento)
        {
            if (statusConexion != false)
            {

                try
                {
                    MySqlCommand cm;
                    MySqlDataAdapter da;
                    DataTable ds;
                    string cadenaConsulta = "SHOW CREATE FUNCTION " + procedimiento.ToString();
                    cm = new MySqlCommand();
                    cm.CommandText = cadenaConsulta;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Connection;

                    da = new MySqlDataAdapter(cm);

                    ds = new DataTable();
                    da.Fill(ds);
                    return ds;



                }
                catch (MySqlException e)
                {
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));

                    return null;
                    
                }
            }
            else
            {
                return null;
            }
        }
        public DataSet FunctionAndProcedures(string Parent,  string NombreProceso, string[] columParametro, string[] columValor, string[] tipodato)
        {
            if (Parent.ToUpper() == "PROCEDIMIENTO")
            {
                return spProcedures(NombreProceso, columParametro, columValor, tipodato);
            }
            else 
            {
                return fcFunction(NombreProceso, columParametro, columValor, tipodato);
            }


        } 
        public DataSet spProcedures(string NombreStoreProcedure, string[] columParametro,string [] columValor, string[] tipo)
        {
            if (statusConexion != false)
            {
                try
                {

                    MySqlCommand cm;
                    MySqlDataAdapter da;
                    DataSet ds;

                    cm = new MySqlCommand(NombreStoreProcedure, Connection);
                    cm.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < columParametro.Length; i++)
                    {

                        if (tipo[i].ToUpper() == "INT")
                        {
                            Console.WriteLine(tipo[i]);
                            cm.Parameters.AddWithValue(columParametro[i], int.Parse(columValor[i]));
                        }

                        else if (tipo[i].ToUpper() == "DOUBLE" || tipo[i].ToUpper() == "double")
                        {
                            Console.WriteLine(tipo[i]);
                            cm.Parameters.AddWithValue(columParametro[i], double.Parse(columValor[i]));

                        }
                        else if (tipo[i].ToUpper() == "FLOAT" || tipo[i].ToUpper() == "float")
                        {
                            Console.WriteLine(tipo[i]);
                            cm.Parameters.AddWithValue(columParametro[i], float.Parse(columValor[i]));

                        }
                        else if (tipo[i].ToUpper() == "CHAR")
                        {
                            Console.WriteLine(tipo[i]);
                            cm.Parameters.AddWithValue(columParametro[i], char.Parse(columValor[i]));

                        }
                        else if (tipo[i].ToUpper() == "VARCHAR")
                        {
                            Console.WriteLine(tipo[i]);
                            cm.Parameters.AddWithValue(columParametro[i], columValor[i]);

                        }
                        else if (tipo[i].ToUpper() == "DATETIME")
                        {
                            Console.WriteLine(tipo[i]);
                            cm.Parameters.AddWithValue(columParametro[i], DateTime.Parse(columValor[i]));

                        }



                    }
                    da = new MySqlDataAdapter(cm);
                    if (da != null)
                    {
                        ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                    else
                    {
                        return null;

                    }
                }catch(MySqlException e)
                {
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public DataSet fcFunction(string NombreFuncion, string[] columParametro, string[] columValor, string[] tipo)
        {
            if (statusConexion != false)
            {

                try
                {
                    MySqlCommand cm;
                    MySqlDataAdapter da;
                    DataSet ds;
                    string cadenaConsulta = "";
                    string [] medios = columValor;

                    cm = new MySqlCommand();
                    for (int i = 0; i < columParametro.Length; i++)
                    {
                       
                             if (tipo[i].ToUpper() == "VARCHAR")
                            {
                                
                                medios[i] = "'" + columValor[i] + "'";

                            }
                            else
                            {
                                medios[i]= columValor[i];
                            }
                        
                    }
                    cadenaConsulta = "SELECT " + NombreFuncion + "(";
                    for (int i = 0; i < medios.Length; i++)
                    {
                        if ((i+1) == medios.Length)
                        { cadenaConsulta +=  medios[i]; }
                        else
                        { cadenaConsulta +=  " " +medios[i]+","; }
                  
                    }
                    cadenaConsulta += ")";
                    Console.WriteLine(cadenaConsulta);

                    cm.CommandText = cadenaConsulta;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Connection;

                    da = new MySqlDataAdapter(cm);

                    ds = new DataSet();
                    da.Fill(ds);
                    return ds;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));
                    return null;
                }

            }
            else
            {
                return null;
            }

            
        }
        public string GenerarStringConexion()
        {
            return ConnectionString;
        }
        public bool OpenConnection()
        {
            try
            {
                this.Connection.Open();
                Console.WriteLine("Conexion conectada.");
                StatusConexion = true;
                return true;
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.HResult.ToString());
                Console.WriteLine(ex.Source.ToString());
                Console.WriteLine(ex.Message.ToString());
               
                // Console.WriteLine(Validation.ErrorSqlHresult(ex.HResult.ToString()));
                ConnectionString = "";
                StatusConexion = false;
                return false;
                
            }

        }
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                this.Connection.Close();
                Console.WriteLine("Conexion Desconectada.");
                ConnectionString = "";
                StatusConexion = false;
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));
                return false;
            }

        }
        public string sentenciaSql(string consulta)
        {
            if (statusConexion != false)
            {
                try
                {
                    MySqlCommand cm = Connection.CreateCommand();
                    cm.CommandText = consulta;
                    cm.CommandType = CommandType.Text;
                    cm.ExecuteNonQuery();
                    return "Sentecia Exitosa";

                }
                catch (MySqlException e)
                {
                   
                    Console.WriteLine(Validation.ErrorSQL(e.Number.ToString()));
                    return Validation.ErrorSQL(e.Number.ToString());
                }
            }
            else
            {
                return "Base de datos no conectada";
            }
        }
        public DataSet Consulta(string cadenaConsulta)
        {
            if (statusConexion != false)
            {
                
                try
                {
                    MySqlCommand cm;
                    MySqlDataAdapter da;
                    DataSet ds;

                    cm = new MySqlCommand();
                    cm.CommandText = cadenaConsulta;
                    cm.CommandType = CommandType.Text;
                    cm.Connection = Connection;

                    da = new MySqlDataAdapter(cm);

                    ds = new DataSet();
                    da.Fill(ds);
                    return ds;

                }
                catch (MySqlException)
                {
                    return null;
                }

            }
            else
            {
                return null;
            }

        }
        public bool StatusConnection()
        {
            return StatusConexion;
        }


        #endregion
    }
}
