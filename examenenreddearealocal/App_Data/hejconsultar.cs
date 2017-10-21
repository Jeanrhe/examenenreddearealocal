using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace clase77
{
    public class gsConsultar
    {
        conexion cn = new conexion();
        public DataTable extrae( string nombresp)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.cadena;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.cerrar();
            return dt;
        }

        public DataTable extrae(string nombresp, string nomparam, string valorparam)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.cadena;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(nomparam, SqlDbType.VarChar).Value = valorparam;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.cerrar();
            return dt;
        }


        public DataTable extrae(string nombresp, string nomparam, int valorparam)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.cadena;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(nomparam, SqlDbType.Int).Value = valorparam;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.cerrar();
            return dt;
        }


        public DataTable extrae(string nombresp, string nomparam1, string valorparam1, 
                                   string nomparam2, string valorparam2)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.Connection = cn.cadena;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(nomparam1, SqlDbType.VarChar).Value = valorparam1;
            cmd.Parameters.Add(nomparam2, SqlDbType.VarChar).Value = valorparam2;
            cmd.CommandText = nombresp;
            cn.conectar();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cn.cerrar();
            return dt;
        }


        public void rellenacombo(DropDownList cmb, string campover, string campovalor, string nombresp)
        {
            cmb.DataSource = extrae(nombresp);
            cmb.DataValueField = campovalor;
            cmb.DataTextField = campover;
            cmb.DataBind();
        }

    }
}