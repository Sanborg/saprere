using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class cEvento
{
    public static bool CriarEvento(string idUsuarioCriador, string titulo, string descricao, string escopoDoEvento, string localDeVisualizacao, DateTime dataHoraVisualizacao, string imagem = "", string video = "", string audio = "")
    {
        return ConsultasEvento.CriarEvento(idUsuarioCriador, titulo, descricao, escopoDoEvento, localDeVisualizacao, dataHoraVisualizacao, imagem, video, audio);
    }
    public static Evento BuscarEvento(string titulo)
    {
        return ConsultasEvento.BuscarEvento(titulo);
    }
    public static bool ResponderEvento(int id, int idUsuarioRespondente, string resposta, string link1 = "", string link2 = "", string link3 = "")
    {
        return ConsultasEvento.ResponderEvento(id, idUsuarioRespondente, resposta, link1, link2, link3);
    }
    public static bool ExcluirUsuario(int id)
    {
        return ConsultasEvento.ExcluirUsuario(id);
    }
    public static Evento VisualizarEventosReportados(int idUsuarioCriador)
    {
        return ConsultasEvento.VisualizarEventosReportados(idUsuarioCriador);
    }
    public static Evento VisualizarEventosRespondidos(int idUsuarioRespondente)
    {
        return ConsultasEvento.VisualizarEventosRespondidos(idUsuarioRespondente);
    }
}
