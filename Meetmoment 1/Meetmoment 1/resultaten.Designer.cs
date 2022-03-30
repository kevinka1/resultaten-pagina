
namespace Meetmoment_1
{
    partial class resultaten
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.UitslagenListView = new System.Windows.Forms.ListView();
            this.Process = new System.Windows.Forms.ColumnHeader();
            this.Planning = new System.Windows.Forms.ColumnHeader();
            this.klantgericht = new System.Windows.Forms.ColumnHeader();
            this.standupp = new System.Windows.Forms.ColumnHeader();
            this.samenwerking = new System.Windows.Forms.ColumnHeader();
            this.beroepscompetentie = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 12;
            // 
            // UitslagenListView
            // 
            this.UitslagenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Process,
            this.Planning,
            this.klantgericht,
            this.standupp,
            this.samenwerking,
            this.beroepscompetentie});
            this.UitslagenListView.HideSelection = false;
            this.UitslagenListView.Location = new System.Drawing.Point(198, 117);
            this.UitslagenListView.Name = "UitslagenListView";
            this.UitslagenListView.Size = new System.Drawing.Size(1221, 194);
            this.UitslagenListView.TabIndex = 26;
            this.UitslagenListView.UseCompatibleStateImageBehavior = false;
            this.UitslagenListView.View = System.Windows.Forms.View.Details;
            this.UitslagenListView.SelectedIndexChanged += new System.EventHandler(this.UitslagenListView_SelectedIndexChanged);
            // 
            // Process
            // 
            this.Process.Text = "Process";
            this.Process.Width = 150;
            // 
            // Planning
            // 
            this.Planning.Text = "Planning";
            this.Planning.Width = 150;
            // 
            // klantgericht
            // 
            this.klantgericht.Text = "klantgericht";
            this.klantgericht.Width = 150;
            // 
            // standupp
            // 
            this.standupp.Text = "standupp";
            this.standupp.Width = 150;
            // 
            // samenwerking
            // 
            this.samenwerking.Text = "samenwerking";
            this.samenwerking.Width = 150;
            // 
            // beroepscompetentie
            // 
            this.beroepscompetentie.Text = "beroepscompetientie";
            this.beroepscompetentie.Width = 250;
            // 
            // resultaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 774);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "resultaten";
            this.Text = "resultaten";
            this.Load += new System.EventHandler(this.resultaten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.ListView UitslagenListView;
        private System.Windows.Forms.ColumnHeader Process;
        private System.Windows.Forms.ColumnHeader Planning;
        private System.Windows.Forms.ColumnHeader klantgericht;
        private System.Windows.Forms.ColumnHeader standupp;
        private System.Windows.Forms.ColumnHeader samenwerking;
        private System.Windows.Forms.ColumnHeader beroepscompetentie;
    }
}