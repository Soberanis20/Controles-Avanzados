﻿namespace ControlesAvanzados
{
    partial class Archivo
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
            label1 = new Label();
            listadoVentas = new FlowLayoutPanel();
            selectorDepartamento = new ListBox();
            comboBoxAnios = new ComboBox();
            comboBoxMeses = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Nuevo Archivo";
            // 
            // listadoVentas
            // 
            listadoVentas.AutoScroll = true;
            listadoVentas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            listadoVentas.Location = new Point(267, 49);
            listadoVentas.Margin = new Padding(3, 2, 3, 2);
            listadoVentas.Name = "listadoVentas";
            listadoVentas.Size = new Size(554, 465);
            listadoVentas.TabIndex = 1;
            listadoVentas.ControlAdded += panelAdd;
            // 
            // selectorDepartamento
            // 
            selectorDepartamento.FormattingEnabled = true;
            selectorDepartamento.ItemHeight = 15;
            selectorDepartamento.Location = new Point(28, 207);
            selectorDepartamento.Margin = new Padding(3, 2, 3, 2);
            selectorDepartamento.Name = "selectorDepartamento";
            selectorDepartamento.SelectionMode = SelectionMode.MultiSimple;
            selectorDepartamento.Size = new Size(217, 124);
            selectorDepartamento.TabIndex = 3;
            selectorDepartamento.SelectedValueChanged += selectorDepartamento_SelectedValueChanged;
            // 
            // comboBoxAnios
            // 
            comboBoxAnios.FormattingEnabled = true;
            comboBoxAnios.Location = new Point(28, 75);
            comboBoxAnios.Margin = new Padding(3, 2, 3, 2);
            comboBoxAnios.Name = "comboBoxAnios";
            comboBoxAnios.Size = new Size(216, 23);
            comboBoxAnios.TabIndex = 4;
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(31, 141);
            comboBoxMeses.Margin = new Padding(3, 2, 3, 2);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(214, 23);
            comboBoxMeses.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 181);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 6;
            label2.Text = "Seleccionar Depatamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 54);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 7;
            label3.Text = "Seleccionar Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 117);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 8;
            label4.Text = "Seleccionar Mes";
            // 
            // Archivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 525);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMeses);
            Controls.Add(comboBoxAnios);
            Controls.Add(selectorDepartamento);
            Controls.Add(listadoVentas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Archivo";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel listadoVentas;
        private ListBox selectorDepartamento;
        private ComboBox comboBoxAnios;
        private ComboBox comboBoxMeses;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}