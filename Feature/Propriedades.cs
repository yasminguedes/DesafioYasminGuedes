using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafio.Feature
{
    public class Propriedades
    {
        public static object BuscaPropriedadesComPonto(DataGridView grid, DataGridViewCellFormattingEventArgs e)
        {
            if (grid.Rows[e.RowIndex].DataBoundItem != null && grid.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {
                return BuscarPropriedades(grid.Rows[e.RowIndex].DataBoundItem, grid.Columns[e.ColumnIndex].DataPropertyName);
            }
            return e.Value;
        }
        private static object BuscarPropriedades(object propriedade, string propriedadeName)
        {
            var retValue = "";
            if (propriedadeName.Contains("."))
            {
                PropertyInfo[] arrayPropriedades;
                string PropriedadeEsquerda;
                PropriedadeEsquerda = propriedadeName.Substring(0, propriedadeName.IndexOf(".", StringComparison.Ordinal));
                arrayPropriedades = propriedade.GetType().GetProperties();
                foreach (var informacoesPropriedade in arrayPropriedades)
                {
                    if (informacoesPropriedade.Name != PropriedadeEsquerda) continue;
                    retValue = (string)BuscarPropriedades(
                        informacoesPropriedade.GetValue(propriedade, null),
                        propriedadeName.Substring(propriedadeName.IndexOf(".", StringComparison.Ordinal) + 1));
                    break;
                }
            }
            else
            {
                Type TipoPropriedade;
                PropertyInfo propertyInfo;
                TipoPropriedade = propriedade.GetType();
                propertyInfo = TipoPropriedade.GetProperty(propriedadeName);
                if (propertyInfo != null) retValue = propertyInfo.GetValue(propriedade, null).ToString();
            }
            return retValue;
        }
    }
}
