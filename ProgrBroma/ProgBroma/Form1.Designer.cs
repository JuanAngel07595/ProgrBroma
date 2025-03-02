namespace ProgBroma
{
    partial class Form1
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
            this.btnbroma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbroma
            // 
            this.btnbroma.Location = new System.Drawing.Point(376, 298);
            this.btnbroma.Margin = new System.Windows.Forms.Padding(4);
            this.btnbroma.Name = "btnbroma";
            this.btnbroma.Size = new System.Drawing.Size(196, 89);
            this.btnbroma.TabIndex = 1;
            this.btnbroma.Text = "Clickea Soldado";
            this.btnbroma.UseVisualStyleBackColor = true;
            this.btnbroma.Click += new System.EventHandler(this.btnbroma_Click);
            this.btnbroma.MouseEnter += new System.EventHandler(this.btnbroma_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProgBroma.Properties.Resources.imgmilyardas;
            this.ClientSize = new System.Drawing.Size(921, 551);
            this.Controls.Add(this.btnbroma);
            this.Name = "Form1";
            this.Text = "Backsoldado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbroma;
    }
}

