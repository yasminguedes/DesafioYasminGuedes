using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Promocao
    {
        public int IdPromocao { get; set; }
        public string NomePromocao { get; set; }
        public string StatusPromocao { get; set; }
        public double Desconto { get; set; }
        public DateTime InicioPromocao { get; set; }
        public DateTime TerminoPromocao { get; set; }
        public DayOfWeek DiaSemana { get; set; }
    }
}
