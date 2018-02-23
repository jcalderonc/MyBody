using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;


namespace MyBody
{
    
    public class BaseDatos
    {
        SQLiteConnection Conexion = new SQLiteConnection();
        SQLiteDataAdapter Adaptador = new SQLiteDataAdapter();
        SQLiteCommand Comando = new SQLiteCommand();
        
        public DataTable Buffer = new DataTable();
        public int RegistrosInvolucrados;
        public string Instruccion;

        public BaseDatos()
        {
            Conexion = new SQLiteConnection("Data Source=" + MyBody.Default.SQLLiteFile + ";Version=3;");
        }
        public bool Conectar()
        {
            try
            {
                if (Conexion.State != ConnectionState.Open)
                { Conexion.Open(); }
                return Conexion.State == ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }
        public bool Consultar()
        {
            try
            {
                Buffer = new DataTable();
                Adaptador = new SQLiteDataAdapter(Instruccion, Conexion);
                Adaptador.Fill(Buffer);
                return Buffer.Rows.Count > 0;
            }
            catch
            {
                return false;
            }
        }
        public bool Ejecutar()
        {
            try
            {
                Comando = new SQLiteCommand(Instruccion, Conexion);
                if (Comando.Connection.State != ConnectionState.Open)
                {
                    Comando.Connection.Open();
                }
                RegistrosInvolucrados = Comando.ExecuteNonQuery();
                Comando.Connection.Close();
                return RegistrosInvolucrados > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
