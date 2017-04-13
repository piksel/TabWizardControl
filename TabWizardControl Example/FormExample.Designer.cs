namespace TabWizardControl_Example
{
    partial class FormExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wizard = new Piksel.Controls.TabWizard.TabWizardControl();
            this.tbIntro = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tpFoo = new System.Windows.Forms.TabPage();
            this.rbBaz = new System.Windows.Forms.RadioButton();
            this.rbBar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tpBar = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpBaz = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpEnd = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.wizard.SuspendLayout();
            this.tbIntro.SuspendLayout();
            this.tpFoo.SuspendLayout();
            this.tpBar.SuspendLayout();
            this.tpBaz.SuspendLayout();
            this.tpEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrevious.Location = new System.Drawing.Point(12, 337);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(116, 39);
            this.bPrevious.TabIndex = 1;
            this.bPrevious.Text = "&Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.Location = new System.Drawing.Point(482, 337);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(116, 39);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "&Next";
            this.bNext.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.wizard);
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // wizard
            // 
            this.wizard.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.wizard.Controls.Add(this.tbIntro);
            this.wizard.Controls.Add(this.tpFoo);
            this.wizard.Controls.Add(this.tpBar);
            this.wizard.Controls.Add(this.tpBaz);
            this.wizard.Controls.Add(this.tpEnd);
            this.wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard.Location = new System.Drawing.Point(3, 16);
            this.wizard.Name = "wizard";
            this.wizard.NextButton = this.bNext;
            this.wizard.NextButtonLastText = "Close";
            this.wizard.PreviousButton = this.bPrevious;
            this.wizard.SelectedIndex = 0;
            this.wizard.Size = new System.Drawing.Size(609, 316);
            this.wizard.TabIndex = 0;
            this.wizard.Text = null;
            this.wizard.PageChanged += new System.EventHandler(this.wizard_PageChanged);
            this.wizard.LastButtonClicked += new System.EventHandler(this.wizard_LastButtonClicked);
            // 
            // tbIntro
            // 
            this.tbIntro.Controls.Add(this.label4);
            this.tbIntro.Location = new System.Drawing.Point(4, 22);
            this.tbIntro.Name = "tbIntro";
            this.tbIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tbIntro.Size = new System.Drawing.Size(601, 290);
            this.tbIntro.TabIndex = 3;
            this.tbIntro.Text = "Intro";
            this.tbIntro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 65);
            this.label4.TabIndex = 2;
            this.label4.Text = "Intro";
            // 
            // tpFoo
            // 
            this.tpFoo.Controls.Add(this.rbBaz);
            this.tpFoo.Controls.Add(this.rbBar);
            this.tpFoo.Controls.Add(this.label1);
            this.tpFoo.Location = new System.Drawing.Point(4, 22);
            this.tpFoo.Name = "tpFoo";
            this.tpFoo.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoo.Size = new System.Drawing.Size(601, 290);
            this.tpFoo.TabIndex = 0;
            this.tpFoo.Text = "Foo Page";
            this.tpFoo.UseVisualStyleBackColor = true;
            // 
            // rbBaz
            // 
            this.rbBaz.AutoSize = true;
            this.rbBaz.Location = new System.Drawing.Point(17, 94);
            this.rbBaz.Name = "rbBaz";
            this.rbBaz.Size = new System.Drawing.Size(72, 17);
            this.rbBaz.TabIndex = 3;
            this.rbBaz.Text = "Go to Baz";
            this.rbBaz.UseVisualStyleBackColor = true;
            this.rbBaz.CheckedChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // rbBar
            // 
            this.rbBar.AutoSize = true;
            this.rbBar.Location = new System.Drawing.Point(17, 71);
            this.rbBar.Name = "rbBar";
            this.rbBar.Size = new System.Drawing.Size(70, 17);
            this.rbBar.TabIndex = 2;
            this.rbBar.Text = "Go to Bar";
            this.rbBar.UseVisualStyleBackColor = true;
            this.rbBar.CheckedChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foo";
            // 
            // tpBar
            // 
            this.tpBar.Controls.Add(this.checkBox2);
            this.tpBar.Controls.Add(this.label2);
            this.tpBar.Location = new System.Drawing.Point(4, 22);
            this.tpBar.Name = "tpBar";
            this.tpBar.Padding = new System.Windows.Forms.Padding(3);
            this.tpBar.Size = new System.Drawing.Size(601, 290);
            this.tpBar.TabIndex = 1;
            this.tpBar.Text = "Bar Page";
            this.tpBar.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Enable proceeding";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bar";
            // 
            // tpBaz
            // 
            this.tpBaz.Controls.Add(this.label6);
            this.tpBaz.Controls.Add(this.comboBox1);
            this.tpBaz.Controls.Add(this.label3);
            this.tpBaz.Location = new System.Drawing.Point(4, 22);
            this.tpBaz.Name = "tpBaz";
            this.tpBaz.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaz.Size = new System.Drawing.Size(601, 290);
            this.tpBaz.TabIndex = 2;
            this.tpBaz.Text = "Baz Page";
            this.tpBaz.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Choose a value:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.comboBox1.Location = new System.Drawing.Point(17, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 65);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baz";
            // 
            // tpEnd
            // 
            this.tpEnd.Controls.Add(this.label5);
            this.tpEnd.Location = new System.Drawing.Point(4, 22);
            this.tpEnd.Name = "tpEnd";
            this.tpEnd.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnd.Size = new System.Drawing.Size(601, 290);
            this.tpEnd.TabIndex = 4;
            this.tpEnd.Text = "End";
            this.tpEnd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 65);
            this.label5.TabIndex = 2;
            this.label5.Text = "End";
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(426, 427);
            this.Name = "FormExample";
            this.Text = "TabWizardControl Example";
            this.groupBox1.ResumeLayout(false);
            this.wizard.ResumeLayout(false);
            this.tbIntro.ResumeLayout(false);
            this.tbIntro.PerformLayout();
            this.tpFoo.ResumeLayout(false);
            this.tpFoo.PerformLayout();
            this.tpBar.ResumeLayout(false);
            this.tpBar.PerformLayout();
            this.tpBaz.ResumeLayout(false);
            this.tpBaz.PerformLayout();
            this.tpEnd.ResumeLayout(false);
            this.tpEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Piksel.Controls.TabWizard.TabWizardControl wizard;
        private System.Windows.Forms.TabPage tpFoo;
        private System.Windows.Forms.TabPage tpBar;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tpBaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tbIntro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBaz;
        private System.Windows.Forms.RadioButton rbBar;
        private System.Windows.Forms.TabPage tpEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}

