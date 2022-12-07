using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

public class ConsultasEvento
{
    public static bool CriarEvento(string idUsuarioCriador, string titulo, string descricao, string escopoDoEvento, string localDeVisualizacao, DateTime dataHoraVisualizacao)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = new Usuario();
        bool foiCriado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  INSERT INTO Usuario (idUsuarioCriador, titulo, descricao, escopoDoEvento, localDeVisualizacao, dataHoraVisualizacao)
                  VALUES (@idUsuarioCriador,@titulo,@descricao,@escopoDoEvento,@localDeVisualizacao,@dataHoraVisualizacao)";
            comando.Parameters.AddWithValue("@idUsuarioCriador", idUsuarioCriador);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@escopoDoEvento", escopoDoEvento);
            comando.Parameters.AddWithValue("@localDeVisualizacao", localDeVisualizacao);
            comando.Parameters.AddWithValue("@dataHoraVisualizacao", dataHoraVisualizacao);
            var leitura = comando.ExecuteReader();

            foiCriado = true;



        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return foiCriado;
    }
    public static Evento BuscarEvento(string titulo)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Evento evento = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                SELECT * FROM Usuario WHERE titulo = @titulo;";
            comando.Parameters.AddWithValue("@titulo", titulo);
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                evento = new Evento();
                evento.id = leitura.GetInt32("id");
                evento.idUsuarioCriador = leitura.GetInt32("idUsuarioCriador");
                evento.idUsuarioRespondente = leitura.GetInt32("idUsuarioRespondente");
                evento.titulo = leitura.GetString("titulo");
                evento.descricao = leitura.GetString("descricao");
                evento.escopoDoEvento = leitura.GetString("escopoDoEvento");
                evento.descricao = leitura.GetString("descricao");
                evento.localDeVisualizacao = leitura.GetString("localDeVisualizacao");
                evento.dataHoraVisualizacao = leitura.GetDateTime("dataHoraVisualizacao");
                evento.link1 = leitura.GetString("link1");
                evento.link2 = leitura.GetString("link2");
                evento.link3 = leitura.GetString("link3");
                evento.resposta = leitura.GetString("resposta");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return evento;
    }
    public static bool ResponderEvento(int id, int idUsuarioRespondente, string resposta, string link1 = "", string link2 = "", string link3 = "")
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiRespondido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  UPDATE Evento SET idUsuarioRespondente = @idUsuarioRespondente, resposta = @resposta, link1 = @link1, link2 = @link2, link3 = @link3
                  WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@idUsuarioRespondente", idUsuarioRespondente);
            comando.Parameters.AddWithValue("@resposta", resposta);
            comando.Parameters.AddWithValue("@link1", link1);
            comando.Parameters.AddWithValue("@link2", link2);
            comando.Parameters.AddWithValue("@link3", link3);
            var leitura = comando.ExecuteReader();
            foiRespondido = true;




        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return foiRespondido;
    }
    public static bool ExcluirEvento(int id)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiExcluido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                DELETE FROM Evento WHERE id = @id;";
            comando.Parameters.AddWithValue("@id", id);
            var leitura = comando.ExecuteReader();
            foiExcluido = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return foiExcluido;
    }
    public static Evento VisualizarEventosReportados(int idUsuarioCriador)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Evento evento = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                SELECT * FROM Usuario WHERE idUsuarioCriador = @idUsuarioCriador;";
            comando.Parameters.AddWithValue("@idUsuarioCriador", idUsuarioCriador);
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                evento = new Evento();
                evento.id = leitura.GetInt32("id");
                evento.idUsuarioCriador = leitura.GetInt32("idUsuarioCriador");
                evento.idUsuarioRespondente = leitura.GetInt32("idUsuarioRespondente");
                evento.titulo = leitura.GetString("titulo");
                evento.descricao = leitura.GetString("descricao");
                evento.escopoDoEvento = leitura.GetString("escopoDoEvento");
                evento.descricao = leitura.GetString("descricao");
                evento.localDeVisualizacao = leitura.GetString("localDeVisualizacao");
                evento.dataHoraVisualizacao = leitura.GetDateTime("dataHoraVisualizacao");
                evento.link1 = leitura.GetString("link1");
                evento.link2 = leitura.GetString("link2");
                evento.link3 = leitura.GetString("link3");
                evento.resposta = leitura.GetString("resposta");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return evento;
    }
    public static Evento VisualizarEventosRespondidos(int idUsuarioRespondente)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Evento evento = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                SELECT * FROM Usuario WHERE idUsuarioRespondente = @idUsuarioRespondente;";
            comando.Parameters.AddWithValue("@idUsuarioRespondente", idUsuarioRespondente);
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                evento = new Evento();
                evento.id = leitura.GetInt32("id");
                evento.idUsuarioCriador = leitura.GetInt32("idUsuarioCriador");
                evento.idUsuarioRespondente = leitura.GetInt32("idUsuarioRespondente");
                evento.titulo = leitura.GetString("titulo");
                evento.descricao = leitura.GetString("descricao");
                evento.escopoDoEvento = leitura.GetString("escopoDoEvento");
                evento.descricao = leitura.GetString("descricao");
                evento.localDeVisualizacao = leitura.GetString("localDeVisualizacao");
                evento.dataHoraVisualizacao = leitura.GetDateTime("dataHoraVisualizacao");
                evento.link1 = leitura.GetString("link1");
                evento.link2 = leitura.GetString("link2");
                evento.link3 = leitura.GetString("link3");
                evento.resposta = leitura.GetString("resposta");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return evento;
    }
}

