﻿
namespace CapaVistaBancos
{
    partial class Mantenimiento_tipoMov
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
            this.tblmantenimientostipomovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new CapaVistaBancos.DataSet7();
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            this.tbl_mantenimientos_tipo_movimientoTableAdapter = new CapaVistaBancos.DataSet7TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tipoMov = new System.Windows.Forms.DataGridView();
            this.txt_idtras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_transexiten = new System.Windows.Forms.TextBox();
            this.btn_transa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoMov)).BeginInit();
            this.SuspendLayout();
            // 
            // tblmantenimientostipomovimientoBindingSource
            // 
            this.tblmantenimientostipomovimientoBindingSource.DataMember = "tbl_mantenimientos_tipo_movimiento";
            this.tblmantenimientostipomovimientoBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_salir_dispo
            // 
            this.btn_salir_dispo.AutoSize = true;
            this.btn_salir_dispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_salir_dispo.FlatAppearance.BorderSize = 0;
            this.btn_salir_dispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_dispo.Image = global::CapaVistaBancos.Properties.Resources.signin_login_in_log_icon_255971;
            this.btn_salir_dispo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir_dispo.Location = new System.Drawing.Point(984, -1);
            this.btn_salir_dispo.Name = "btn_salir_dispo";
            this.btn_salir_dispo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_salir_dispo.Size = new System.Drawing.Size(84, 39);
            this.btn_salir_dispo.TabIndex = 85;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // tbl_mantenimientos_tipo_movimientoTableAdapter
            // 
            this.tbl_mantenimientos_tipo_movimientoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "ID de transacción:";
            // 
            // dgv_tipoMov
            // 
            this.dgv_tipoMov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tipoMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoMov.GridColor = System.Drawing.Color.White;
            this.dgv_tipoMov.Location = new System.Drawing.Point(70, 373);
            this.dgv_tipoMov.Name = "dgv_tipoMov";
            this.dgv_tipoMov.RowHeadersWidth = 51;
            this.dgv_tipoMov.RowTemplate.Height = 24;
            this.dgv_tipoMov.Size = new System.Drawing.Size(927, 231);
            this.dgv_tipoMov.TabIndex = 94;
            this.dgv_tipoMov.Tag = "tbl_mantenimientos_tipo_movimiento";
            // 
            // txt_idtras
            // 
            this.txt_idtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idtras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idtras.Location = new System.Drawing.Point(278, 262);
            this.txt_idtras.Name = "txt_idtras";
            this.txt_idtras.Size = new System.Drawing.Size(199, 26);
            this.txt_idtras.TabIndex = 90;
            this.txt_idtras.Tag = "pk_movtm_id_transaccion";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Transacciones existentes:";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(105, 53);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 96;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Estado:";
            // 
            // txt_estado
            // 
            this.txt_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_estado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(787, 269);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(199, 26);
            this.txt_estado.TabIndex = 98;
            this.txt_estado.Tag = "movtm_status";
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged_1);
            // 
            // txt_transexiten
            // 
            this.txt_transexiten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_transexiten.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transexiten.Location = new System.Drawing.Point(278, 310);
            this.txt_transexiten.Name = "txt_transexiten";
            this.txt_transexiten.Size = new System.Drawing.Size(199, 26);
            this.txt_transexiten.TabIndex = 99;
            this.txt_transexiten.Tag = "movtm_transacciones_existentes";
            // 
            // btn_transa
            // 
            this.btn_transa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transa.Location = new System.Drawing.Point(483, 310);
            this.btn_transa.Name = "btn_transa";
            this.btn_transa.Size = new System.Drawing.Size(213, 26);
            this.btn_transa.TabIndex = 100;
            this.btn_transa.Text = "Transacciones existentes";
            this.btn_transa.UseVisualStyleBackColor = true;
            this.btn_transa.Click += new System.EventHandler(this.btn_transa_Click);
            // 
            // Mantenimiento_tipoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 756);
            this.Controls.Add(this.btn_transa);
            this.Controls.Add(this.txt_transexiten);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_tipoMov);
            this.Controls.Add(this.txt_idtras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mantenimiento_tipoMov";
            this.Text = "Mantenimiento de Tipo de movimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_tipoMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientostipomovimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_dispo;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource tblmantenimientostipomovimientoBindingSource;
        private DataSet7TableAdapters.tbl_mantenimientos_tipo_movimientoTableAdapter tbl_mantenimientos_tipo_movimientoTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tipoMov;
        private System.Windows.Forms.TextBox txt_idtras;
        private System.Windows.Forms.Label label4;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_transexiten;
        private System.Windows.Forms.Button btn_transa;
    }
}