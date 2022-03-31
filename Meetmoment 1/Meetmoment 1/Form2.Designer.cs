
namespace Meetmoment_1
{
    partial class Form2
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
            this.resultatenlistview = new System.Windows.Forms.ListView();
            this.planning = new System.Windows.Forms.ColumnHeader();
            this.process = new System.Windows.Forms.ColumnHeader();
            this.klantgericht = new System.Windows.Forms.ColumnHeader();
            this.standup = new System.Windows.Forms.ColumnHeader();
            this.beroepscompententie = new System.Windows.Forms.ColumnHeader();
            this.samenwerking = new System.Windows.Forms.ColumnHeader();
            this.beroepshouding = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // resultatenlistview
            // 
            this.resultatenlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.planning,
            this.process,
            this.klantgericht,
            this.standup,
            this.beroepscompententie,
            this.samenwerking,
            this.beroepshouding});
            this.resultatenlistview.HideSelection = false;
            this.resultatenlistview.Location = new System.Drawing.Point(80, 73);
            this.resultatenlistview.Name = "resultatenlistview";
            this.resultatenlistview.Size = new System.Drawing.Size(1353, 319);
            this.resultatenlistview.TabIndex = 0;
            this.resultatenlistview.UseCompatibleStateImageBehavior = false;
            this.resultatenlistview.View = System.Windows.Forms.View.Details;
            // 
            // planning
            // 
            this.planning.Text = "planning";
            this.planning.Width = 150;
            // 
            // process
            // 
            this.process.Text = "process";
            this.process.Width = 150;
            // 
            // klantgericht
            // 
            this.klantgericht.Text = "klantgericht";
            this.klantgericht.Width = 150;
            // 
            // standup
            // 
            this.standup.Text = "standup";
            this.standup.Width = 150;
            // 
            // beroepscompententie
            // 
            this.beroepscompententie.Text = "beroepscompententie";
            this.beroepscompententie.Width = 300;
            // 
            // samenwerking
            // 
            this.samenwerking.Text = "samenwerking";
            this.samenwerking.Width = 200;
            // 
            // beroepshouding
            // 
            this.beroepshouding.Text = "beroepshouding";
            this.beroepshouding.Width = 250;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 672);
            this.Controls.Add(this.resultatenlistview);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView resultatenlistview;
        private System.Windows.Forms.ColumnHeader planning;
        private System.Windows.Forms.ColumnHeader process;
        private System.Windows.Forms.ColumnHeader klantgericht;
        private System.Windows.Forms.ColumnHeader standup;
        private System.Windows.Forms.ColumnHeader beroepscompententie;
        private System.Windows.Forms.ColumnHeader samenwerking;
        private System.Windows.Forms.ColumnHeader beroepshouding;
    }
}