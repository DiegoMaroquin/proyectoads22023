﻿
namespace CapaVistaBancos
{
    partial class Mantenimiento_agregar_cuenta
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
            this.tblmonedabancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new CapaVistaBancos.DataSet4();
            this.tblmantenimientosagregarbancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new CapaVistaBancos.DataSet5();
            this.tblmantenimientosagregarcuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new CapaVistaBancos.DataSet6();
            this.tbl_monedabancoTableAdapter = new CapaVistaBancos.DataSet4TableAdapters.tbl_monedabancoTableAdapter();
            this.tbl_mantenimientos_agregar_bancosTableAdapter = new CapaVistaBancos.DataSet5TableAdapters.tbl_mantenimientos_agregar_bancosTableAdapter();
            this.tbl_mantenimientos_agregar_cuentaTableAdapter = new CapaVistaBancos.DataSet6TableAdapters.tbl_mantenimientos_agregar_cuentaTableAdapter();
            this.txt_numcuenta = new System.Windows.Forms.TextBox();
            this.dgv_agCuentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_alias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_id_agCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tipocuenta = new System.Windows.Forms.TextBox();
            this.txt_sect_banco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tipo_mon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMonedaexistente = new System.Windows.Forms.Button();
            this.btn_bancoexistente = new System.Windows.Forms.Button();
            this.btn_salir_dispo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonedabancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarbancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarcuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tblmonedabancoBindingSource
            // 
            this.tblmonedabancoBindingSource.DataMember = "tbl_monedabanco";
            this.tblmonedabancoBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientosagregarbancosBindingSource
            // 
            this.tblmantenimientosagregarbancosBindingSource.DataMember = "tbl_mantenimientos_agregar_bancos";
            this.tblmantenimientosagregarbancosBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmantenimientosagregarcuentaBindingSource
            // 
            this.tblmantenimientosagregarcuentaBindingSource.DataMember = "tbl_mantenimientos_agregar_cuenta";
            this.tblmantenimientosagregarcuentaBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_monedabancoTableAdapter
            // 
            this.tbl_monedabancoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_mantenimientos_agregar_bancosTableAdapter
            // 
            this.tbl_mantenimientos_agregar_bancosTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_mantenimientos_agregar_cuentaTableAdapter
            // 
            this.tbl_mantenimientos_agregar_cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // txt_numcuenta
            // 
            this.txt_numcuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numcuenta.Location = new System.Drawing.Point(255, 268);
            this.txt_numcuenta.Name = "txt_numcuenta";
            this.txt_numcuenta.Size = new System.Drawing.Size(169, 26);
            this.txt_numcuenta.TabIndex = 91;
            this.txt_numcuenta.Tag = "manac_numero_de_cuenta";
            // 
            // dgv_agCuentas
            // 
            this.dgv_agCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agCuentas.Location = new System.Drawing.Point(63, 393);
            this.dgv_agCuentas.Name = "dgv_agCuentas";
            this.dgv_agCuentas.RowHeadersWidth = 51;
            this.dgv_agCuentas.RowTemplate.Height = 24;
            this.dgv_agCuentas.Size = new System.Drawing.Size(951, 238);
            this.dgv_agCuentas.TabIndex = 97;
            this.dgv_agCuentas.Tag = "tbl_mantenimientos_agregar_cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Número de cuenta:";
            // 
            // txt_alias
            // 
            this.txt_alias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_alias.Location = new System.Drawing.Point(760, 265);
            this.txt_alias.Name = "txt_alias";
            this.txt_alias.Size = new System.Drawing.Size(169, 26);
            this.txt_alias.TabIndex = 90;
            this.txt_alias.Tag = "manac_alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Alias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(135, 27);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(765, 187);
            this.navegador1.TabIndex = 98;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_id_agCuenta
            // 
            this.txt_id_agCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_agCuenta.Location = new System.Drawing.Point(255, 231);
            this.txt_id_agCuenta.Name = "txt_id_agCuenta";
            this.txt_id_agCuenta.Size = new System.Drawing.Size(169, 26);
            this.txt_id_agCuenta.TabIndex = 100;
            this.txt_id_agCuenta.Tag = "pk_manac_id_cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 99;
            this.label4.Text = "Id cuenta:";
            // 
            // txt_tipocuenta
            // 
            this.txt_tipocuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipocuenta.Location = new System.Drawing.Point(760, 231);
            this.txt_tipocuenta.Name = "txt_tipocuenta";
            this.txt_tipocuenta.Size = new System.Drawing.Size(169, 26);
            this.txt_tipocuenta.TabIndex = 102;
            this.txt_tipocuenta.Tag = "manac_tipo_de_cuenta";
            // 
            // txt_sect_banco
            // 
            this.txt_sect_banco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sect_banco.Location = new System.Drawing.Point(253, 336);
            this.txt_sect_banco.Name = "txt_sect_banco";
            this.txt_sect_banco.Size = new System.Drawing.Size(169, 26);
            this.txt_sect_banco.TabIndex = 105;
            this.txt_sect_banco.Tag = "fk_manac_selec_banco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 106;
            this.label9.Text = "Escriba Banco:";
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(760, 303);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(169, 26);
            this.txt_estado.TabIndex = 107;
            this.txt_estado.Tag = "manac_status";
            this.txt_estado.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "Estado:";
            // 
            // txt_tipo_mon
            // 
            this.txt_tipo_mon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_mon.Location = new System.Drawing.Point(255, 304);
            this.txt_tipo_mon.Name = "txt_tipo_mon";
            this.txt_tipo_mon.Size = new System.Drawing.Size(169, 26);
            this.txt_tipo_mon.TabIndex = 101;
            this.txt_tipo_mon.Tag = "fk_manac_tipo_de_moneda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 103;
            this.label7.Text = "Escriba tipo de moneda:";
            // 
            // btnMonedaexistente
            // 
            this.btnMonedaexistente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonedaexistente.Location = new System.Drawing.Point(430, 306);
            this.btnMonedaexistente.Name = "btnMonedaexistente";
            this.btnMonedaexistente.Size = new System.Drawing.Size(163, 25);
            this.btnMonedaexistente.TabIndex = 109;
            this.btnMonedaexistente.Text = "Monedas Existentes";
            this.btnMonedaexistente.UseVisualStyleBackColor = true;
            this.btnMonedaexistente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_bancoexistente
            // 
            this.btn_bancoexistente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bancoexistente.Location = new System.Drawing.Point(428, 333);
            this.btn_bancoexistente.Name = "btn_bancoexistente";
            this.btn_bancoexistente.Size = new System.Drawing.Size(156, 26);
            this.btn_bancoexistente.TabIndex = 111;
            this.btn_bancoexistente.Text = "Bancos existentes";
            this.btn_bancoexistente.UseVisualStyleBackColor = true;
            this.btn_bancoexistente.Click += new System.EventHandler(this.button3_Click);
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
            this.btn_salir_dispo.TabIndex = 86;
            this.btn_salir_dispo.Text = "Salir";
            this.btn_salir_dispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir_dispo.UseVisualStyleBackColor = false;
            this.btn_salir_dispo.Click += new System.EventHandler(this.btn_salir_dispo_Click);
            // 
            // Mantenimiento_agregar_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1069, 803);
            this.Controls.Add(this.btn_bancoexistente);
            this.Controls.Add(this.btnMonedaexistente);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_sect_banco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tipocuenta);
            this.Controls.Add(this.txt_tipo_mon);
            this.Controls.Add(this.txt_id_agCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_numcuenta);
            this.Controls.Add(this.dgv_agCuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_alias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir_dispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1069, 803);
            this.MinimumSize = new System.Drawing.Size(888, 659);
            this.Name = "Mantenimiento_agregar_cuenta";
            this.Text = "Mantenimiento Agregar Cuenta";
            this.Load += new System.EventHandler(this.Mantenimiento_agregar_cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblmonedabancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarbancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmantenimientosagregarcuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir_dispo;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource tblmonedabancoBindingSource;
        private DataSet4TableAdapters.tbl_monedabancoTableAdapter tbl_monedabancoTableAdapter;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource tblmantenimientosagregarbancosBindingSource;
        private DataSet5TableAdapters.tbl_mantenimientos_agregar_bancosTableAdapter tbl_mantenimientos_agregar_bancosTableAdapter;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource tblmantenimientosagregarcuentaBindingSource;
        private DataSet6TableAdapters.tbl_mantenimientos_agregar_cuentaTableAdapter tbl_mantenimientos_agregar_cuentaTableAdapter;
        private System.Windows.Forms.TextBox txt_numcuenta;
        private System.Windows.Forms.DataGridView dgv_agCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_alias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_id_agCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tipocuenta;
        private System.Windows.Forms.TextBox txt_sect_banco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tipo_mon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMonedaexistente;
        private System.Windows.Forms.Button btn_bancoexistente;
    }
}