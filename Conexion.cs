using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Procesadora
{
    class Conexion
    {
        public Conexion()//PARA INICIAR LA CONECION Y PODER EJECUTAR COMANDOS
        {
            myConnection.Close();
            myConnection.Open();
        }
        SqlConnection myConnection = new SqlConnection("user id=sa; password=sa; Data Source=localhost; Trusted_Connection=yes; database=PROCESADORA;");
        public String Conectar()
        {
            String estado;
            try
            {
                myConnection.Close();
                myConnection.Open();
                estado = "Conectado";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                estado = "Desconectado";
            }
            return estado;
        }
        public Boolean Insert(String Tabla, String Columnas, String Valores)
        {
            Boolean resultado;
            try
            {
                String SQL = "Insert into " + Tabla + "(" + Columnas + ") values (" + Valores + ")" ;
                SqlCommand myCommand = new SqlCommand(SQL, myConnection);
                myCommand.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                resultado = false;
            }

            return resultado;
        }
        public Boolean Update(String Tabla, String Cambios)
        {
            Boolean resultado;
            try
            {
                String SQL = "Update " + Tabla + " set " + Cambios;
                SqlCommand myCommand = new SqlCommand(SQL, myConnection);
                myCommand.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                resultado = false;
            }
            return resultado;
        }
        public Boolean Update(String Tabla, String Cambios, String Condicion)
        {
            Boolean resultado;
            try
            {
                String SQL = "Update " + Tabla + " set " + Cambios + " where " + Condicion;
                SqlCommand myCommand = new SqlCommand(SQL, myConnection);
                myCommand.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                resultado = false;
            }
            return resultado;
        }
        public Boolean Delete(String Tabla)
        {
            Boolean resultado;
            try
            {
                String SQL = "Delete from " + Tabla;
                SqlCommand myCommand = new SqlCommand(SQL, myConnection);
                myCommand.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                resultado = false;
            }
            return resultado;
        }
        public Boolean Delete(String Tabla, String Condicion)
        {
            Boolean resultado;
            try
            {
                String SQL = "Delete from " + Tabla + " where " + Condicion;
                SqlCommand myCommand = new SqlCommand(SQL, myConnection);
                myCommand.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                resultado = false;
            }
            return resultado;
        }
        public DataTable Select(String Valores, String Tabla, String Condicion)
        {

            DataTable table = new DataTable();
            try
            {
                String SQL = "Select " + Valores + " from " + Tabla + " where " + Condicion;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, myConnection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                table.Clear();
            }
            return table;
        }
        public DataTable Select(String Valores, String Tabla)
        {
            DataTable table = new DataTable();
            try
            {
                String SQL = "Select " + Valores + " from " + Tabla;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, myConnection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                table.Clear();
            }
            return table;
        }
        public DataTable Select(String SQL)
        {
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, myConnection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                table.Clear();
            }
            return table;
        }
        public String Select1Valor(String SQL)
        {
            DataTable table = new DataTable();
            String Resultado;
            try
            {
                SqlCommand cmd = new SqlCommand(SQL, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                Resultado = table.Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                table.Clear();
                Resultado = "ERROR";
            }
            return Resultado;
        }
        public DataTable SelectTEST(String SQL)
        {
            DataTable table = new DataTable();
            String Resultado;
            try
            {
                SqlCommand cmd = new SqlCommand(SQL, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
                Resultado = table.Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                table.Clear();
                Resultado = "";
            }
            return table;//Resultado;
        }
    }
}
