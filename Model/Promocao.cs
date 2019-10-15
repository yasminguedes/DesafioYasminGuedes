using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesafio.Model
{
    public class Promocao
    {
        public int idPromocao { get; set; }
        public string nomePromocao { get; set; }
        public string statusPromocao { get; set; }
        public double desconto { get; set; }
        public DateTime inicioPromocao { get; set; }
        public DateTime terminoPromocao { get; set; }
        public DayOfWeek diaSemana { get; set; }
    }
}
