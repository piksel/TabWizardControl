using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabWizardControl_Example
{
    public partial class FormExample : Form
    {
        public FormExample()
        {
            InitializeComponent();


            wizard.NextFunction(tpFoo, () => rbBar.Checked ? tpBar : rbBaz.Checked ? tpBaz : null);

            wizard.PreviousFunction(tpBaz, tpFoo);
            wizard.NextFunction(tpBaz, () => comboBox1.SelectedIndex >= 0);

            wizard.NextFunction(tpBar, () => checkBox2.Checked ? tpEnd : null);

            wizard.PreviousFunction(tpEnd, () => rbBar.Checked ? tpBar : rbBaz.Checked ? tpBaz : tpFoo);
        }

        private void tabWizardControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StateControlChanged(object sender, EventArgs e)
        {
            wizard.UpdateState();
        }

        private void wizard_PageChanged(object sender, EventArgs e)
        {
            Text = "TabWizardControl Example - " + wizard.Text;
        }

        private void wizard_LastButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
