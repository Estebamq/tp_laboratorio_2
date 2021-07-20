
namespace Presentation
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnMateriaPrima = new System.Windows.Forms.Button();
            this.btnConstruir = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Transparent;
            this.pnlControl.Controls.Add(this.btnAyuda);
            this.pnlControl.Controls.Add(this.btnInforme);
            this.pnlControl.Controls.Add(this.btnMateriaPrima);
            this.pnlControl.Controls.Add(this.btnConstruir);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 389);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(943, 123);
            this.pnlControl.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.BackgroundImage = global::Presentation.Properties.Resources.btnAyuda1;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Location = new System.Drawing.Point(887, 60);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(42, 40);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.Transparent;
            this.btnInforme.BackgroundImage = global::Presentation.Properties.Resources.btnInforme;
            this.btnInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.ForeColor = System.Drawing.Color.Transparent;
            this.btnInforme.Location = new System.Drawing.Point(541, 6);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(117, 98);
            this.btnInforme.TabIndex = 8;
            this.btnInforme.Text = "Informes";
            this.btnInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnMateriaPrima
            // 
            this.btnMateriaPrima.BackColor = System.Drawing.Color.Transparent;
            this.btnMateriaPrima.BackgroundImage = global::Presentation.Properties.Resources.btnMateriaPrima;
            this.btnMateriaPrima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMateriaPrima.FlatAppearance.BorderSize = 0;
            this.btnMateriaPrima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnMateriaPrima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriaPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriaPrima.ForeColor = System.Drawing.Color.Transparent;
            this.btnMateriaPrima.Location = new System.Drawing.Point(380, 6);
            this.btnMateriaPrima.Name = "btnMateriaPrima";
            this.btnMateriaPrima.Size = new System.Drawing.Size(155, 98);
            this.btnMateriaPrima.TabIndex = 7;
            this.btnMateriaPrima.Text = "Materia Prima";
            this.btnMateriaPrima.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMateriaPrima.UseVisualStyleBackColor = false;
            this.btnMateriaPrima.Click += new System.EventHandler(this.btnMateriaPrima_Click);
            // 
            // btnConstruir
            // 
            this.btnConstruir.BackColor = System.Drawing.Color.Transparent;
            this.btnConstruir.BackgroundImage = global::Presentation.Properties.Resources.btnConstruir;
            this.btnConstruir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConstruir.FlatAppearance.BorderSize = 0;
            this.btnConstruir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnConstruir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConstruir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstruir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstruir.ForeColor = System.Drawing.Color.Transparent;
            this.btnConstruir.Location = new System.Drawing.Point(257, 6);
            this.btnConstruir.Name = "btnConstruir";
            this.btnConstruir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConstruir.Size = new System.Drawing.Size(117, 98);
            this.btnConstruir.TabIndex = 2;
            this.btnConstruir.Text = "Construir";
            this.btnConstruir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConstruir.UseVisualStyleBackColor = false;
            this.btnConstruir.Click += new System.EventHandler(this.btnConstruir_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Transparent;
            this.pnl.Controls.Add(this.btnClose1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(943, 52);
            this.pnl.TabIndex = 1;
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.Color.Transparent;
            this.btnClose1.BackgroundImage = global::Presentation.Properties.Resources.btnClose;
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose1.FlatAppearance.BorderSize = 0;
            this.btnClose1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnClose1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose1.Location = new System.Drawing.Point(899, 9);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(30, 31);
            this.btnClose1.TabIndex = 1;
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Presentation.Properties.Resources.backgroundMetalQui;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 512);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pnlControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnMateriaPrima;
        private System.Windows.Forms.Button btnConstruir;
        private System.Windows.Forms.Button btnAyuda;
    }
}

