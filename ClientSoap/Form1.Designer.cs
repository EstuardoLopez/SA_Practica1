namespace ClientSoap
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAccion = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkAccion = new System.Windows.Forms.CheckBox();
            this.pgrBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(129, 15);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(452, 26);
            this.TxtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // BtnAccion
            // 
            this.BtnAccion.Location = new System.Drawing.Point(608, 18);
            this.BtnAccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAccion.Name = "BtnAccion";
            this.BtnAccion.Size = new System.Drawing.Size(148, 67);
            this.BtnAccion.TabIndex = 2;
            this.BtnAccion.Text = "Buscar";
            this.BtnAccion.UseVisualStyleBackColor = true;
            this.BtnAccion.Click += new System.EventHandler(this.BtnAccion_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(129, 63);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(452, 26);
            this.TxtCantidad.TabIndex = 3;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(26, 63);
            this.LblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(73, 20);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(30, 131);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(737, 156);
            this.TxtResult.TabIndex = 6;
            // 
            // ChkAccion
            // 
            this.ChkAccion.AutoSize = true;
            this.ChkAccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAccion.Location = new System.Drawing.Point(626, 93);
            this.ChkAccion.Name = "ChkAccion";
            this.ChkAccion.Size = new System.Drawing.Size(105, 17);
            this.ChkAccion.TabIndex = 7;
            this.ChkAccion.Text = "Habilitar Guardar";
            this.ChkAccion.UseVisualStyleBackColor = true;
            this.ChkAccion.CheckedChanged += new System.EventHandler(this.ChkAccion_CheckedChanged);
            // 
            // pgrBar
            // 
            this.pgrBar.Location = new System.Drawing.Point(-2, 295);
            this.pgrBar.Name = "pgrBar";
            this.pgrBar.Size = new System.Drawing.Size(796, 23);
            this.pgrBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 311);
            this.Controls.Add(this.pgrBar);
            this.Controls.Add(this.ChkAccion);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BtnAccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAccion;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox ChkAccion;
        private System.Windows.Forms.ProgressBar pgrBar;
    }
}

