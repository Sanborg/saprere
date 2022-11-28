using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static bool CadastrarUsuario(string nome, string senha, string tipoUsuario)
    {
        return ConsultasUsuario.CadastrarUsuario(nome, senha, tipoUsuario);
    }
    public static Usuario BuscarDadosUsuario(string email, string senha)
    {
        return ConsultasUsuario.BuscarDadosUsuario(email, senha);
    }
    public static bool EditaPerfilUsuarioComum(int id, string nome, string senha)
    {
        return ConsultasUsuario.EditaPerfilUsuarioComum(id, nome, senha);
    }
    public static bool EditaPerfilUsuarioContribuidor(int id, string cpf, string nome, string senha, string telefone)
    {
        return ConsultasUsuario.EditaPerfilUsuarioContribuidor(id, cpf, nome, senha, telefone);
    }
    public static bool ExcluirUsuario(int id)
    {
        return ConsultasUsuario.ExcluirUsuario(id);
    }
    public static bool TornarContribuinte(int id, string cpf, int idade, string telefone, string cursoDeGraduacao, string instituicaoEnsinoSuperior, string tipoUsuario, string fotoDiploma = "")
    {
        return ConsultasUsuario.TornarContribuinte(id, cpf, idade, telefone, cursoDeGraduacao, instituicaoEnsinoSuperior, tipoUsuario, fotoDiploma);
    }
    public static bool InserirDescricao(int id, string descricao)
    {
        return ConsultasUsuario.InserirDescricao(id, descricao);
    }
    public static bool AlterarSenha(int id, string senha)
    {
        return ConsultasUsuario.AlterarSenha(id, senha);
    }
}
