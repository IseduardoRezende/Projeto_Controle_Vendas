using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.model
{
    public class Helpers
    {
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctrFilho in ctrPai.Controls)
                {
                    if (ctrFilho is TabPage)
                    {
                        foreach (Control ctrTio in ctrFilho.Controls)
                        {
                            if (ctrTio is TextBox)
                            {
                                (ctrTio as TextBox).Text = string.Empty;                                                                                                                      
                            }
                            else if (ctrTio is MaskedTextBox)
                            {
                                (ctrTio as MaskedTextBox).Text = string.Empty;
                            }
                            else if (ctrTio is ComboBox)
                            {
                                (ctrTio as ComboBox).Text = string.Empty;
                            }                            
                        }
                    }
                }
            }
        }
    }
}
