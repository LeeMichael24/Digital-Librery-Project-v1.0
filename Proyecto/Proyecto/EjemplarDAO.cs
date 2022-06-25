using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Proyecto.Properties;

namespace Proyecto
{
    public static class EjemplarDAO
    {
        public static List<Ejemplar> obtenerTodos(){
            string cadena = Resources.cadena_conexion;
            List<Ejemplar> lista = new List<Ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena)){
                string query = "SELECT EJEMPLAR.id_ejemplar, EJEMPLAR.nombre, COLECCION.nombre_coleccion, AUTOR.nombre_autor, PALABRACLAVE.palabra " +
                "FROM EJEMPLAR, COLECCION, AUTOR, PALABRACLAVE WHERE EJEMPLAR.id_coleccion = COLECCION.id_coleccion AND EJEMPLAR.id_autor = AUTOR.id_autor " +
                "AND EJEMPLAR.id_ejemplar = PALABRACLAVE.id_ejemplar";
                
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader()){
                    while (reader.Read()){
                        Ejemplar Eje = new Ejemplar();
                        Eje.id = Convert.ToInt32(reader["id_ejemplar"].ToString());
                        Eje.nombre = reader["nombre"].ToString();
                        Eje.coleccion = reader["nombre_coleccion"].ToString();
                        Eje.autor = reader["nombre_autor"].ToString();
                        Eje.pClave = reader["palabra"].ToString();
                        lista.Add(Eje);
                    }   
                }
                connection.Close();
            }
            return lista;
        }

        public static List<Ejemplar> buscarTitulo(string unTitulo)
        {
            return obtenerTodos()
                .Where(o => o.nombre.Contains(unTitulo))
                .ToList();
        }
        
        public static List<Ejemplar> buscarAutor(string unAutor)
        {
            return obtenerTodos()
                .Where(o => o.autor.Contains(unAutor))
                .ToList();
        }
        
        public static List<Ejemplar> buscarpClave(string unaPalabra)
        {
            return obtenerTodos()
                .Where(o => o.pClave.Contains(unaPalabra))
                .ToList();
        }
    }
}