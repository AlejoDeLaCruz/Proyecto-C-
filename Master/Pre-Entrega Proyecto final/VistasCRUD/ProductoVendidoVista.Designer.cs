﻿namespace Pre_Entrega_Proyecto_final
{
    partial class ProductoVendidoVista
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
            AgregarButton = new Button();
            ModificarButton = new Button();
            EliminarButton = new Button();
            VolverButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(467, 27);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(87, 36);
            AgregarButton.TabIndex = 0;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // ModificarButton
            // 
            ModificarButton.Location = new Point(585, 27);
            ModificarButton.Name = "ModificarButton";
            ModificarButton.Size = new Size(87, 36);
            ModificarButton.TabIndex = 1;
            ModificarButton.Text = "Modificar";
            ModificarButton.UseVisualStyleBackColor = true;
            ModificarButton.Click += ModificarButton_Click;
            // 
            // EliminarButton
            // 
            EliminarButton.Location = new Point(701, 27);
            EliminarButton.Name = "EliminarButton";
            EliminarButton.Size = new Size(87, 36);
            EliminarButton.TabIndex = 2;
            EliminarButton.Text = "Eliminar";
            EliminarButton.UseVisualStyleBackColor = true;
            EliminarButton.Click += EliminarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(26, 27);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(87, 36);
            VolverButton.TabIndex = 3;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(762, 346);
            dataGridView1.TabIndex = 4;
            // 
            // ProductoVendidoVista
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(VolverButton);
            Controls.Add(EliminarButton);
            Controls.Add(ModificarButton);
            Controls.Add(AgregarButton);
            Name = "ProductoVendidoVista";
            Text = "ProductoVendidoVista";
            Load += ProductoVendidoVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AgregarButton;
        private Button ModificarButton;
        private Button EliminarButton;
        private Button VolverButton;
        private DataGridView dataGridView1;
    }
}