
namespace Registro_Usuario
{
    partial class frmInventario
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
            this.dgwInventario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SALIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwInventario
            // 
            this.dgwInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInventario.Location = new System.Drawing.Point(0, 102);
            this.dgwInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwInventario.Name = "dgwInventario";
            this.dgwInventario.RowHeadersWidth = 51;
            this.dgwInventario.Size = new System.Drawing.Size(1083, 594);
            this.dgwInventario.TabIndex = 0;
            this.dgwInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInventario_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.SALIR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 103);
            this.panel1.TabIndex = 1;
            // 
            // SALIR
            // 
            this.SALIR.BackColor = System.Drawing.Color.Maroon;
            this.SALIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SALIR.Location = new System.Drawing.Point(884, 18);
            this.SALIR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(140, 52);
            this.SALIR.TabIndex = 1;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = false;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO PRODUCTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1083, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwInventario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgwInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SALIR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}