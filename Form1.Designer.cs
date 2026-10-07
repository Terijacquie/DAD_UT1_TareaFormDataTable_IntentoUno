namespace DAD_UT1_TareaFormDataTable_IntentoUno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            cbCategoria = new ComboBox();
            cbEquipo = new ComboBox();
            dgvTabla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(523, 242);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(500, 66);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(151, 28);
            cbCategoria.TabIndex = 2;
            cbCategoria.Text = "Categoria";
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // cbEquipo
            // 
            cbEquipo.FormattingEnabled = true;
            cbEquipo.Location = new Point(500, 152);
            cbEquipo.Name = "cbEquipo";
            cbEquipo.Size = new Size(151, 28);
            cbEquipo.TabIndex = 3;
            cbEquipo.Text = "Equipo";
            // 
            // dgvTabla
            // 
            dgvTabla.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.GridColor = SystemColors.InactiveCaption;
            dgvTabla.Location = new Point(12, 12);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.RowHeadersWidth = 51;
            dgvTabla.Size = new Size(373, 426);
            dgvTabla.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(cbEquipo);
            Controls.Add(cbCategoria);
            Controls.Add(btnAdd);
            Controls.Add(dgvTabla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private ComboBox cbCategoria;
        private ComboBox cbEquipo;
        private DataGridView dgvTabla;
    }
}
