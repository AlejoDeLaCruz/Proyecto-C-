﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Desafio_2.Models;
using System.Data;

namespace Desafio_2.DataBaseAccess
{
    internal class UsuarioDataAccess
    {
        // METODO OBTENER USUARIO
        public static List<Usuario> ObtenerUsuario(int idUsuario)
        {
            List<Usuario> lista = new List<Usuario>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Usuario WHERE Id=@idUsuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idUsuario";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                lista.Add(usuario);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO LISTAR USUARIO
        public static List<Usuario> ListarUsuario(int idUsuario)
        {
            List<Usuario> lista = new List<Usuario>();

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "SELECT * FROM Usuario ";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "idUsuario";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = idUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                lista.Add(usuario);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        //METODO CREAR USUARIO
        public static void CrearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                        "VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                }
                conexion.Close();
            }
        }

        //METODO MODIFICAR USUARIO
        public static void ModificarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "UPDATE Usuario" +
                        "SET Nombre = @Nombre" +
                        ", Apellido = @Apellido" +
                        ", NombreUsuario = @NombreUsuario" +
                        ", Contraseña = @Contraseña" +
                        ", Mail = @Mail" +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                }
                conexion.Close();
            }
        }

        //METODO ELIMINAR USUARIO
        public static void EliminarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=ProyectoCSharp;Trusted_connection=True;";

            var query = "DELETE FROM Usuario WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                }
                conexion.Close();
            }
        }
    }
}

