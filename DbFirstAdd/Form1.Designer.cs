namespace DbFirstAdd
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
            dtwSuplier = new DataGridView();
            btnDelate = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            lblName = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)dtwSuplier).BeginInit();
            SuspendLayout();
            // 
            // dtwSuplier
            // 
            dtwSuplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtwSuplier.Location = new Point(3, 144);
            dtwSuplier.Name = "dtwSuplier";
            dtwSuplier.Size = new Size(796, 310);
            dtwSuplier.TabIndex = 0;
            dtwSuplier.CellClick += dtwSuplier_CellClick;
            dtwSuplier.CellContentClick += dtwSuplier_CellContentClick;
            // 
            // btnDelate
            // 
            btnDelate.Location = new Point(12, 69);
            btnDelate.Name = "btnDelate";
            btnDelate.Size = new Size(119, 44);
            btnDelate.TabIndex = 1;
            btnDelate.Text = "DELETE";
            btnDelate.UseVisualStyleBackColor = true;
            btnDelate.Click += btnDelate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(387, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(154, 23);
            txtName.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(387, 90);
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 23);
            txtId.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(311, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(311, 90);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(btnDelate);
            Controls.Add(dtwSuplier);
            Name = "Form1";
            Text = "C";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtwSuplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtwSuplier;
        private Button btnDelate;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblName;
        private Label lblId;
    }
}
