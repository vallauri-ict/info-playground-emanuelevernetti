﻿
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
            this.dgvStoricoCancellazioni = new System.Windows.Forms.DataGridView();
            this.dgvStoricoAggiornamenti = new System.Windows.Forms.DataGridView();
            this.btnAggDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).BeginInit();
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
            this.dgvDriver.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowsDeletedDriver);
            // 
            // dgvStoricoCancellazioni
            // 
            this.dgvStoricoCancellazioni.AllowUserToAddRows = false;
            this.dgvStoricoCancellazioni.AllowUserToDeleteRows = false;
            this.dgvStoricoCancellazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoCancellazioni.Location = new System.Drawing.Point(413, 13);
            this.dgvStoricoCancellazioni.Name = "dgvStoricoCancellazioni";
            this.dgvStoricoCancellazioni.RowHeadersVisible = false;
            this.dgvStoricoCancellazioni.Size = new System.Drawing.Size(394, 204);
            this.dgvStoricoCancellazioni.TabIndex = 1;
            // 
            // dgvStoricoAggiornamenti
            // 
            this.dgvStoricoAggiornamenti.AllowUserToAddRows = false;
            this.dgvStoricoAggiornamenti.AllowUserToDeleteRows = false;
            this.dgvStoricoAggiornamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoricoAggiornamenti.Location = new System.Drawing.Point(13, 258);
            this.dgvStoricoAggiornamenti.Name = "dgvStoricoAggiornamenti";
            this.dgvStoricoAggiornamenti.RowHeadersVisible = false;
            this.dgvStoricoAggiornamenti.Size = new System.Drawing.Size(794, 204);
            this.dgvStoricoAggiornamenti.TabIndex = 2;
            // 
            // btnAggDB
            // 
            this.btnAggDB.Location = new System.Drawing.Point(13, 229);
            this.btnAggDB.Name = "btnAggDB";
            this.btnAggDB.Size = new System.Drawing.Size(394, 23);
            this.btnAggDB.TabIndex = 3;
            this.btnAggDB.Text = "AGGIORNA DB";
            this.btnAggDB.UseVisualStyleBackColor = true;
            this.btnAggDB.Click += new System.EventHandler(this.btnAggDB_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.btnAggDB);
            this.Controls.Add(this.dgvStoricoAggiornamenti);
            this.Controls.Add(this.dgvStoricoCancellazioni);
            this.Controls.Add(this.dgvDriver);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoCancellazioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoricoAggiornamenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridView dgvStoricoCancellazioni;
        private System.Windows.Forms.DataGridView dgvStoricoAggiornamenti;
        private System.Windows.Forms.Button btnAggDB;
    }
}

