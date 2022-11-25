using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

public class ConsultasEvento
{
    public static bool CriarEvento(string idUsuarioCriador, string titulo, string descricao, string escopoDoEvento, string localDeVisualizacao, DateTime dataHoraVisualizacao, string imagem = "", string video = "", string audio = "")
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = new Usuario();
        bool foiCriado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  INSERT INTO Usuario (idUsuarioCriador, titulo, descricao, escopoDoEvento, imagem, video, audio, localDeVisualizacao, dataHoraVisualizacao)
                  VALUES (@idUsuarioCriador,@titulo,@descricao,@escopoDoEvento,@imagem,@video,@audio,@localDeVisualizacao,@dataHoraVisualizacao)";
            comando.Parameters.AddWithValue("@idUsuarioCriador", idUsuarioCriador);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@escopoDoEvento", escopoDoEvento);
            comando.Parameters.AddWithValue("@localDeVisualizacao", localDeVisualizacao);
            comando.Parameters.AddWithValue("@dataHoraVisualizacao", dataHoraVisualizacao);
            comando.Parameters.AddWithValue("@imagem", imagem);
            comando.Parameters.AddWithValue("@video", video);
            comando.Parameters.AddWithValue("@audio", audio);
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
                evento.imagem = leitura.GetString("imagem");
                evento.video = leitura.GetString("video");
                evento.audio = leitura.GetString("audio");
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
    public static bool ResponderEvento(int id, string nome, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiEditado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  UPDATE Usuario SET nome = @nome, senha = @senha
                  WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@senha", senha);
            var leitura = comando.ExecuteReader();
            foiEditado = true;




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

        return foiEditado;
    }
    public static bool ExcluirUsuario(int id)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiExcluido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                DELETE FROM Usuario WHERE id = @id;";
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
}

