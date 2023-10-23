
namespace DesafioFocare1
{
    partial class Form1
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
            this.ckbMasculino = new System.Windows.Forms.CheckBox();
            this.ckbFeminino = new System.Windows.Forms.CheckBox();
            this.lstListaClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ckbMasculino
            // 
            this.ckbMasculino.AutoSize = true;
            this.ckbMasculino.Location = new System.Drawing.Point(226, 119);
            this.ckbMasculino.Name = "ckbMasculino";
            this.ckbMasculino.Size = new System.Drawing.Size(35, 17);
            this.ckbMasculino.TabIndex = 1;
            this.ckbMasculino.Text = "M";
            this.ckbMasculino.UseVisualStyleBackColor = true;
            this.ckbMasculino.CheckedChanged += new System.EventHandler(this.ckbMasculino_CheckedChanged);
            // 
            // ckbFeminino
            // 
            this.ckbFeminino.AutoSize = true;
            this.ckbFeminino.Location = new System.Drawing.Point(498, 119);
            this.ckbFeminino.Name = "ckbFeminino";
            this.ckbFeminino.Size = new System.Drawing.Size(32, 17);
            this.ckbFeminino.TabIndex = 2;
            this.ckbFeminino.Text = "F";
            this.ckbFeminino.UseVisualStyleBackColor = true;
            // 
            // lstListaClientes
            // 
            this.lstListaClientes.GridLines = true;
            this.lstListaClientes.HideSelection = false;
            this.lstListaClientes.Location = new System.Drawing.Point(226, 168);
            this.lstListaClientes.Name = "lstListaClientes";
            this.lstListaClientes.Size = new System.Drawing.Size(304, 411);
            this.lstListaClientes.TabIndex = 3;
            this.lstListaClientes.UseCompatibleStateImageBehavior = false;
            this.lstListaClientes.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 671);
            this.Controls.Add(this.lstListaClientes);
            this.Controls.Add(this.ckbFeminino);
            this.Controls.Add(this.ckbMasculino);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbMasculino;
        private System.Windows.Forms.CheckBox ckbFeminino;
        private System.Windows.Forms.ListView lstListaClientes;
    }
}

