﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto.Properties;

namespace Proyecto
{
    public static class AreaDAO
    {
        public static Area FiltrarPorPiso(int idPiso)
        {
            Area biblioteca = new Area();
            string cadena = Resources.cadena_conexion;
            //Conexion a SQL
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT AREA.nombre_area, AREA.descripcion_area, PISO.numero_piso " +  
                               "FROM AREA INNER JOIN PERTENECE ON AREA.id_area = PERTENECE.id_area " + 
                               "INNER JOIN PISO ON PISO.id_piso = PERTENECE.id_piso WHERE PISO.id_piso = @idPiso ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPiso", idPiso);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        biblioteca.AreaID = Convert.ToInt32(reader["id_area"].ToString());
                        biblioteca.AreaNombre = reader["nombre_area"].ToString();
                        biblioteca.AreaDescripcion = reader["descripcion_area"].ToString();
                        biblioteca.AreaPiso = Convert.ToInt32(reader["numero_piso"].ToString());
                    }   }
                connection.Close();
                
            }
            return biblioteca;
            
        }
    }
}