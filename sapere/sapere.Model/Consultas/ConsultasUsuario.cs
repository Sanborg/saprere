using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

public class ConsultasUsuario
{
    public static bool CadastrarUsuario(string nome, string email, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = new Usuario();
        string senhaCriptografada = Criptografia.CriptografarMD5Senha(senha);
        bool foiCadastrado = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  INSERT INTO Usuario (nome, email, senha, tipoUsuario)
                  VALUES (@nome,@email,@senha,@tipoUsuario)";
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
            comando.Parameters.AddWithValue("@tipoUsuario", "comum");
            var leitura = comando.ExecuteReader();

            foiCadastrado = true;



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

        return foiCadastrado;
    }
    public static Usuario BuscarDadosUsuario(string email, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        string senhaCriptografada = Criptografia.CriptografarMD5Senha(senha);
        Usuario usuario = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                SELECT * FROM Usuario WHERE email = @email AND senha = @senha;";
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                usuario = new Usuario();
                usuario.id = leitura.GetInt32("id");
                usuario.nome = leitura.GetString("nome");
                usuario.email = leitura.GetString("email");
                usuario.senha = leitura.GetString("senha");
                usuario.tipoUsuario = leitura.GetString("tipoUsuario");
                usuario.idade = leitura.GetInt32("idade");
                usuario.telefone = leitura.GetString("telefone");
                usuario.descricao = leitura.GetString("descricao");
                usuario.cursoDeGraduacao = leitura.GetString("cursoDeGraduacao");
                usuario.instituicaoEnsinoSuperior = leitura.GetString("instituicaoEnsinoSuperior");
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
        return usuario;
    }
    public static bool EditarPerfil(int id, string nome, string email)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiEditado = false;
        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  UPDATE Usuario SET nome = @nome, email = @email
                  WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
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
    public static bool TornarContribuinte(int id, string cpf, int idade, string telefone, string cursoDeGraduacao, string instituicaoEnsinoSuperior)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = new Usuario();
        bool tornouContribuinte = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  UPDATE Usuario SET cpf = @cpf, idade = @idade, telefone = @telefone, cursoDeGraduacao = @cursoDeGraduacao, instituicaoEnsinoSuperior = @instituicaoEnsinoSuperior, tipoUsuario = @tipoUsuario
                  WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@idade", idade);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@cursoDeGraduacao", cursoDeGraduacao);
            comando.Parameters.AddWithValue("@instituicaoEnsinoSuperior", instituicaoEnsinoSuperior);
            comando.Parameters.AddWithValue("@tipoUsuario", "contribuinte");
            var leitura = comando.ExecuteReader();

            tornouContribuinte = true;



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

        return tornouContribuinte;
    }
    public static bool InserirDescricao(int id, string descricao)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiInserido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  UPDATE Usuario SET descricao = @descricao
                  WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@descricao", descricao);
            var leitura = comando.ExecuteReader();
            foiInserido = true;




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

        return foiInserido;
    }
    public static bool AlterarSenha(string email, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        string senhaCriptografada = Criptografia.CriptografarMD5Senha(senha);
        bool foiAlterado = false;
        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  UPDATE Usuario SET senha = @senha
                  WHERE email = @email";
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
            var leitura = comando.ExecuteReader();
            foiAlterado = true;
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

        return foiAlterado;
    }
    public static bool VerificaExistenciaEmail(string email)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = null;
        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                  SELECT email from Usuario WHERE email = @email";
            comando.Parameters.AddWithValue("@email", email);
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                usuario = new Usuario();
                usuario.email = leitura.GetString("email");
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
        if(usuario != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
