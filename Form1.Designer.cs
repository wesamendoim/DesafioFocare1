
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
            this.lstListaCliente = new System.Windows.Forms.ListView();
            this.ckbMasculino = new System.Windows.Forms.CheckBox();
            this.ckbFeminino = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstListaCliente
            // 
            this.lstListaCliente.HideSelection = false;
            this.lstListaCliente.Location = new System.Drawing.Point(354, 207);
            this.lstListaCliente.Name = "lstListaCliente";
            this.lstListaCliente.Size = new System.Drawing.Size(147, 388);
            this.lstListaCliente.TabIndex = 0;
            this.lstListaCliente.UseCompatibleStateImageBehavior = false;
            this.lstListaCliente.View = System.Windows.Forms.View.List;
            // 
            // ckbMasculino
            // 
            this.ckbMasculino.AutoSize = true;
            this.ckbMasculino.Location = new System.Drawing.Point(283, 150);
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
            this.ckbFeminino.Location = new System.Drawing.Point(555, 150);
            this.ckbFeminino.Name = "ckbFeminino";
            this.ckbFeminino.Size = new System.Drawing.Size(32, 17);
            this.ckbFeminino.TabIndex = 2;
            this.ckbFeminino.Text = "F";
            this.ckbFeminino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 650);
            this.Controls.Add(this.ckbFeminino);
            this.Controls.Add(this.ckbMasculino);
            this.Controls.Add(this.lstListaCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstListaCliente;
        private System.Windows.Forms.CheckBox ckbMasculino;
        private System.Windows.Forms.CheckBox ckbFeminino;
    }
}

