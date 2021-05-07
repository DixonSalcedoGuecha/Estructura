
namespace VentaTienda.VISTA
{
    partial class BarraDeCarga
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
            this.tmrBarraProgreso = new System.Windows.Forms.Timer(this.components);
            this.brdProgresos = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tmrBarraProgreso
            // 
            this.tmrBarraProgreso.Tick += new System.EventHandler(this.tmrBarraProgreso_Tick);
            // 
            // brdProgresos
            // 
            this.brdProgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.brdProgresos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.brdProgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.brdProgresos.Location = new System.Drawing.Point(0, 0);
            this.brdProgresos.Name = "brdProgresos";
            this.brdProgresos.Size = new System.Drawing.Size(886, 82);
            this.brdProgresos.TabIndex = 0;
            this.brdProgresos.Click += new System.EventHandler(this.brdProgresos_Click);
            // 
            // BarraDeCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(886, 82);
            this.Controls.Add(this.brdProgresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarraDeCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarraDeCarga";
            this.Load += new System.EventHandler(this.BarraDeCarga_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrBarraProgreso;
        private System.Windows.Forms.ProgressBar brdProgresos;
    }
}