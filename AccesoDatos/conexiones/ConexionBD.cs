using AccesoDatos.globales;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.conexiones
{
    public class ConexionBD
    {
        MySqlCommand cmd;
        public MySqlConnection con;
        String cadena = Globals.CadenaConexion;
        public Boolean conectar()
        {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = cadena;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void desconectar()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public MySqlDataReader ejecutarConsultaReader(string sql)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Boolean ejecutarConsultaBoolean(string sql)
        {
            try
            {
                cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Boolean beginTransaction()
        {
            try
            {
                string sql = "begin transaction;";
                if (ejecutarConsultaBoolean(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Boolean commitTransaction()
        {
            try
            {
                string sql = "commit transaction;";
                if (ejecutarConsultaBoolean(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Boolean rollbackTransaction()
        {
            try
            {
                string sql = "rollback transaction;";
                if (ejecutarConsultaBoolean(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
