
namespace esercizioTriggerCorrezione
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
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.btnES1 = new System.Windows.Forms.Button();
            this.btnES2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.AllowUserToOrderColumns = true;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Location = new System.Drawing.Point(13, 13);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.Size = new System.Drawing.Size(394, 204);
            this.dgvDriver.TabIndex = 0;
            // 
            // btnES1
            // 
            this.btnES1.Location = new System.Drawing.Point(13, 223);
            this.btnES1.Name = "btnES1";
            this.btnES1.Size = new System.Drawing.Size(197, 23);
            this.btnES1.TabIndex = 3;
            this.btnES1.Text = "Esegui funzione 1";
            this.btnES1.UseVisualStyleBackColor = true;
            this.btnES1.Click += new System.EventHandler(this.btnES1_Click);
            // 
            // btnES2
            // 
            this.btnES2.Location = new System.Drawing.Point(210, 223);
            this.btnES2.Name = "btnES2";
            this.btnES2.Size = new System.Drawing.Size(197, 23);
            this.btnES2.TabIndex = 4;
            this.btnES2.Text = "Esegui funzione 2";
            this.btnES2.UseVisualStyleBackColor = true;
            this.btnES2.Click += new System.EventHandler(this.btnES2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.btnES2);
            this.Controls.Add(this.btnES1);
            this.Controls.Add(this.dgvDriver);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.Button btnES1;
        private System.Windows.Forms.Button btnES2;
    }
}

