using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhaNaval.Helpers
{
    public class Helper
    {
        public void AdicionarLinhas(DataGridView dataGrid)
        {
            for (int x = 0; x <= 9; x++)
                dataGrid.Rows.Add();
        }

        public void ColocarCor(DataGridView dataGrid,int x,int y,Color cor)
        {
            dataGrid.Rows[x].Cells[y].Style.BackColor = cor;
        }


        public void AlterarCores(bool vezJogador,Control controleIa,Control controlePlayer)
        {
            if (vezJogador == true)
            {
                controleIa.BackColor = Color.FromArgb(255,255,128);
                controlePlayer.BackColor = Color.FromArgb(64,64,64);
            }
            else
            {
                controleIa.BackColor = Color.FromArgb(64,64,64);
                controlePlayer.BackColor = Color.FromArgb(255,255,128);
            }                
        }
    }

}
