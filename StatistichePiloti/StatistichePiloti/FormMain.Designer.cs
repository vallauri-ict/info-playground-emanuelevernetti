
namespace StatistichePiloti
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcedure = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(131, 11);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(75, 23);
            this.btnProcedure.TabIndex = 0;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 329);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnProcedure);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.TextBox txtID;
    }
}

