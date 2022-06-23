using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Proyecto.Properties;

namespace Proyecto
{
    public static class EjemplarDAO
    {
        public static List<Ejemplar> obtenerTodos(){
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion FROM EJEMPLAR, COLECCION WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }
    }
}