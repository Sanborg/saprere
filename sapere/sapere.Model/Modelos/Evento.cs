using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Evento
{
    public int id { get; set; }
    public int idUsuarioCriador { get; set; }
    public int idUsuarioRespondente { get; set; }
    public string titulo { get; set; }
    public string descricao { get; set; }
    public string escopoDoEvento { get; set; }
    public string localDeVisualizacao { get; set; }
    public DateTime dataHoraVisualizacao { get; set; }
    public string link1 { get; set; }
    public string link2 { get; set; }
    public string link3 { get; set; }
    public string resposta { get; set; }
}
