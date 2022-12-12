using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class cEvento
{
    public static bool CriarEvento(int idUsuarioCriador, string titulo, string descricao, string escopoDoEvento, string localDeVisualizacao, DateTime dataHoraVisualizacao)
    {
        return ConsultasEvento.CriarEvento(idUsuarioCriador, titulo, descricao, escopoDoEvento, localDeVisualizacao, dataHoraVisualizacao);
    }
    public static Evento BuscarEvento(string titulo)
    {
        return ConsultasEvento.BuscarEvento(titulo);
    }
    public static bool ResponderEvento(int id, int idUsuarioRespondente, string titulo, string resposta, string link1 = "", string link2 = "", string link3 = "")
    {
        return ConsultasEvento.ResponderEvento(id, idUsuarioRespondente, titulo, resposta, link1, link2, link3);
    }
    public static bool ExcluirEvento(int id)
    {
        return ConsultasEvento.ExcluirEvento(id);
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
