using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGC.Helppers
{
    internal class Dados
    {
        public string NomeDocente { get; set; }
        public string Nivel { get; set; }
        public string Disciplina { get; set; }
        public string Curso { get; set; }
        public int CargaHoraria { get; set; }
        public string Observacao { get; set; }
        public static string horas { get; set; }
        public int TotalCargaHoraria { get; set; }
        public DateTime dataHoje = DateTime.Now;

        // Formatar a data no formato "24 de junho de 2024"
        //string dataFormatada = dataHoje.ToString("dd 'de' MMMM 'de' yyyy");

    }

}
