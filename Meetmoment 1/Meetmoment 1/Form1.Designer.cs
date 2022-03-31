using System.Windows.Forms;

namespace Meetmoment_1
{
    partial class Form1

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>  ///
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vlak = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pjn = new System.Windows.Forms.TextBox();
            this.opslaanknop = new System.Windows.Forms.Button();
            this.beoordelingAntwoord = new System.Windows.Forms.ComboBox();
            this.BeoordelingspuntLabel = new System.Windows.Forms.Label();
            this.terug = new System.Windows.Forms.Button();
            this.verder = new System.Windows.Forms.Button();
            this.vlak.SuspendLayout();
            this.SuspendLayout();
            // 
            // vlak
            // 
            this.vlak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlak.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vlak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vlak.Controls.Add(this.label1);
            this.vlak.Controls.Add(this.pjn);
            this.vlak.Controls.Add(this.opslaanknop);
            this.vlak.Controls.Add(this.beoordelingAntwoord);
            this.vlak.Controls.Add(this.BeoordelingspuntLabel);
            this.vlak.Controls.Add(this.terug);
            this.vlak.Controls.Add(this.verder);
            this.vlak.Location = new System.Drawing.Point(214, 96);
            this.vlak.Name = "vlak";
            this.vlak.Size = new System.Drawing.Size(350, 223);
            this.vlak.TabIndex = 0;
            this.vlak.Paint += new System.Windows.Forms.PaintEventHandler(this.vlak_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "projectnaam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // projectnaam
            // 
            this.pjn.Location = new System.Drawing.Point(121, 98);
            this.pjn.Name = "projectnaam";
            this.pjn.Size = new System.Drawing.Size(125, 27);
            this.pjn.TabIndex = 6;
            this.pjn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.pjn.Leave += new System.EventHandler(this.projectnaam_Leave);
            // 
            // opslaanknop
            // 
            this.opslaanknop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.opslaanknop.BackColor = System.Drawing.Color.Silver;
            this.opslaanknop.Location = new System.Drawing.Point(251, 154);
            this.opslaanknop.Name = "opslaanknop";
            this.opslaanknop.Size = new System.Drawing.Size(94, 29);
            this.opslaanknop.TabIndex = 5;
            this.opslaanknop.Text = "opslaan";
            this.opslaanknop.UseVisualStyleBackColor = false;
            this.opslaanknop.Visible = false;
            this.opslaanknop.Click += new System.EventHandler(this.opslaanknop_Click);
            // 
            // beoordelingAntwoord
            // 
            this.beoordelingAntwoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.beoordelingAntwoord.FormattingEnabled = true;
            this.beoordelingAntwoord.Items.AddRange(new object[] {
            "O",
            "V",
            "G"});
            this.beoordelingAntwoord.Location = new System.Drawing.Point(251, 38);
            this.beoordelingAntwoord.Name = "beoordelingAntwoord";
            this.beoordelingAntwoord.Size = new System.Drawing.Size(59, 28);
            this.beoordelingAntwoord.TabIndex = 4;
            this.beoordelingAntwoord.Text = "kies";
            this.beoordelingAntwoord.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BeoordelingspuntLabel
            // 
            this.BeoordelingspuntLabel.AutoSize = true;
            this.BeoordelingspuntLabel.Location = new System.Drawing.Point(10, 38);
            this.BeoordelingspuntLabel.Name = "BeoordelingspuntLabel";
            this.BeoordelingspuntLabel.Size = new System.Drawing.Size(87, 20);
            this.BeoordelingspuntLabel.TabIndex = 3;
            this.BeoordelingspuntLabel.Text = "klantgericht";
            this.BeoordelingspuntLabel.Click += new System.EventHandler(this.BeoordelingspuntLabel_Click);
            // 
            // terug
            // 
            this.terug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.terug.BackColor = System.Drawing.Color.Silver;
            this.terug.Location = new System.Drawing.Point(3, 189);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(94, 29);
            this.terug.TabIndex = 2;
            this.terug.Text = "terug";
            this.terug.UseVisualStyleBackColor = false;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // verder
            // 
            this.verder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.verder.BackColor = System.Drawing.Color.Silver;
            this.verder.Location = new System.Drawing.Point(251, 189);
            this.verder.Name = "verder";
            this.verder.Size = new System.Drawing.Size(94, 29);
            this.verder.TabIndex = 1;
            this.verder.Text = "verder";
            this.verder.UseVisualStyleBackColor = false;
            this.verder.Click += new System.EventHandler(this.verder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vlak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vlak.ResumeLayout(false);
            this.vlak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel vlak;
        private System.Windows.Forms.Button verder;
        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.ComboBox beoordelingAntwoord;
        private System.Windows.Forms.Label BeoordelingspuntLabel;
        private Button opslaanknop;
        private TextBox textBox1;
        private Label label1;
        private TextBox pjn;
    }
}


