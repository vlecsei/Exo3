using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo3
{
    public partial class FRM_Exo3 : Form
    {
        public FRM_Exo3()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            this.Cbx_Source.Items.Clear();
            this.Cbx_Source.Items.AddRange(new string[]
            {
                "Allemagne", "Japon", "Portugal", "Grèce", "France", "Belgique"
            });
            this.Btn_Ajoute.Enabled = false;
            this.Btn_Supprime.Enabled = false;
            this.Btn_Bas.Enabled = false;
            this.Btn_Haut.Enabled = false;
        }


        private void Cbx_Source_DropDown(object sender, EventArgs e)
        {
            if (this.Cbx_Source.Text != "")
            {
                if (!(this.Cbx_Source.Items.Contains(this.Cbx_Source.Text)))
                {
                    if (!(this.Lbx_Cible.Items.Contains(this.Cbx_Source.Text)))
                    {
                            this.Cbx_Source.Items.Add(this.Cbx_Source.Text);
                            this.Btn_Ajoute.Enabled = true;
                    }
                }
            }
           
        }

        private void Cbx_Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Btn_Ajoute.Enabled = true;
        }

        private void Btn_Ajoute_Click(object sender, EventArgs e)
        {
            this.Lbx_Cible.Items.Add(this.Cbx_Source.SelectedItem);
            this.Cbx_Source.Items.Remove(this.Cbx_Source.SelectedItem);
            this.Cbx_Source.ResetText();
            this.Btn_Ajoute.Enabled = false;

            if (this.Cbx_Source.Items.Count == 0)
            {
                this.Btn_Ajoute_Tout.Enabled = false;
            }
            this.Btn_Supprime_Tout.Enabled = true;
        }

        private void Btn_Ajoute_Tout_Click(object sender, EventArgs e)
        {
            foreach(object element in this.Cbx_Source.Items)
            {
                this.Lbx_Cible.Items.Add(element);
            }
            this.Cbx_Source.Items.Clear();
            this.Cbx_Source.ResetText();
            this.Btn_Ajoute.Enabled = false;
            this.Btn_Ajoute_Tout.Enabled = false;
            this.Btn_Supprime_Tout.Enabled = true;
        }


        private void Lbx_Cible_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Btn_Supprime.Enabled = true;
            if (this.Lbx_Cible.SelectedIndex == 0)
            {
                this.Btn_Haut.Enabled = false;
                this.Btn_Bas.Enabled = true;
            }
            else if (this.Lbx_Cible.SelectedIndex == this.Lbx_Cible.Items.Count - 1)
                   {
                       this.Btn_Bas.Enabled = false;
                        this.Btn_Haut.Enabled = true;
                    }
                else
                {
                    this.Btn_Haut.Enabled = true;
                    this.Btn_Bas.Enabled = true;
                }
           
          
                
        }


        private void Lbx_Cible_Leave(object sender, EventArgs e)
        {
            this.Btn_Haut.Enabled = false;
            this.Btn_Bas.Enabled = false;
        }

        private void Btn_Supprime_Click(object sender, EventArgs e)
        {
           
            this.Cbx_Source.Items.Add(this.Lbx_Cible.SelectedItem);
            this.Lbx_Cible.Items.Remove(this.Lbx_Cible.SelectedItem);
            this.Btn_Supprime.Enabled = false;
            
        }

        private void Btn_Supprime_Tout_Click(object sender, EventArgs e)
        {
            foreach(object element in this.Lbx_Cible.Items)
            {
                this.Cbx_Source.Items.Add(element);
            }
            this.Lbx_Cible.Items.Clear();
            this.Btn_Supprime.Enabled = false;
            this.Btn_Supprime_Tout.Enabled = false;
            this.Btn_Ajoute_Tout.Enabled = true;
        }

        private void Btn_Bas_Click(object sender, EventArgs e)
        {
            object temp;

            if (this.Lbx_Cible.SelectedIndex != this.Lbx_Cible.Items.Count - 1)
            {
                temp = this.Lbx_Cible.SelectedItem;
                this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex] = this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex +1];
                this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex + 1] = temp;
                this.Lbx_Cible.SelectedItem = this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex +1];
            }

            
        }

        private void Btn_Haut_Click(object sender, EventArgs e)
        {
            object temp;

            if (this.Lbx_Cible.SelectedIndex != 0)
            {
                temp = this.Lbx_Cible.SelectedItem;
                this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex] = this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex - 1];
                this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex - 1] = temp;
                this.Lbx_Cible.SelectedItem = this.Lbx_Cible.Items[this.Lbx_Cible.SelectedIndex - 1];
            }
        }

        
    }
}
