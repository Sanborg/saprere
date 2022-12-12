using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static bool CadastrarUsuario(string nome, string email, string senha)
    {
        return ConsultasUsuario.CadastrarUsuario(nome, email, senha);
    }
    public static Usuario BuscarDadosUsuario(string email, string senha)
    {
        return ConsultasUsuario.BuscarDadosUsuario(email, senha);
    }
    public static bool EditarPerfil(int id, string nome, string email)
    {
        return ConsultasUsuario.EditarPerfil(id, nome, email);
    } 
    public static bool ExcluirUsuario(int id)
    {
        return ConsultasUsuario.ExcluirUsuario(id);
    }
    public static bool TornarContribuinte(int id, string cpf, int idade, string telefone, string cursoDeGraduacao, string instituicaoEnsinoSuperior)
    {
        return ConsultasUsuario.TornarContribuinte(id, cpf, idade, telefone, cursoDeGraduacao, instituicaoEnsinoSuperior);
    }
    public static bool InserirDescricao(int id, string descricao)
    {
        return ConsultasUsuario.InserirDescricao(id, descricao);
    }
    public static bool AlterarSenha(string email, string senha)
    {
        return ConsultasUsuario.AlterarSenha(email, senha);
    }
    public static bool VerificaExistenciaEmail(string email)
    {
        return ConsultasUsuario.VerificaExistenciaEmail(email);
    }
}
