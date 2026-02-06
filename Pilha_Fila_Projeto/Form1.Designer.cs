namespace Pilha_Fila_Projeto
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
            lbxPilha = new ListBox();
            lbxFila = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtPilha = new TextBox();
            txtFila = new TextBox();
            btnAddPilha = new Button();
            btnRemovePilha = new Button();
            btnRemoveFila = new Button();
            btnAddFila = new Button();
            SuspendLayout();
            // 
            // lbxPilha
            // 
            lbxPilha.Font = new Font("Segoe UI", 15F);
            lbxPilha.FormattingEnabled = true;
            lbxPilha.ItemHeight = 28;
            lbxPilha.Location = new Point(12, 66);
            lbxPilha.Name = "lbxPilha";
            lbxPilha.Size = new Size(263, 228);
            lbxPilha.TabIndex = 0;
            // 
            // lbxFila
            // 
            lbxFila.Font = new Font("Segoe UI", 15F);
            lbxFila.FormattingEnabled = true;
            lbxFila.ItemHeight = 28;
            lbxFila.Location = new Point(331, 66);
            lbxFila.Name = "lbxFila";
            lbxFila.Size = new Size(263, 228);
            lbxFila.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 2;
            label1.Text = "Pilha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(331, 18);
            label2.Name = "label2";
            label2.Size = new Size(50, 32);
            label2.TabIndex = 3;
            label2.Text = "Fila";
            // 
            // txtPilha
            // 
            txtPilha.Font = new Font("Segoe UI", 14F);
            txtPilha.Location = new Point(14, 315);
            txtPilha.Name = "txtPilha";
            txtPilha.Size = new Size(111, 32);
            txtPilha.TabIndex = 4;
            // 
            // txtFila
            // 
            txtFila.Font = new Font("Segoe UI", 14F);
            txtFila.Location = new Point(331, 315);
            txtFila.Name = "txtFila";
            txtFila.Size = new Size(111, 32);
            txtFila.TabIndex = 5;
            // 
            // btnAddPilha
            // 
            btnAddPilha.Font = new Font("Segoe UI", 14F);
            btnAddPilha.Location = new Point(170, 315);
            btnAddPilha.Name = "btnAddPilha";
            btnAddPilha.Size = new Size(48, 37);
            btnAddPilha.TabIndex = 6;
            btnAddPilha.Text = "+";
            btnAddPilha.UseVisualStyleBackColor = true;
            btnAddPilha.Click += btnAddPilha_Click;
            // 
            // btnRemovePilha
            // 
            btnRemovePilha.Font = new Font("Segoe UI", 14F);
            btnRemovePilha.Location = new Point(227, 315);
            btnRemovePilha.Name = "btnRemovePilha";
            btnRemovePilha.Size = new Size(48, 37);
            btnRemovePilha.TabIndex = 7;
            btnRemovePilha.Text = "-";
            btnRemovePilha.UseVisualStyleBackColor = true;
            btnRemovePilha.Click += btnRemovePilha_Click;
            // 
            // btnRemoveFila
            // 
            btnRemoveFila.Font = new Font("Segoe UI", 14F);
            btnRemoveFila.Location = new Point(547, 315);
            btnRemoveFila.Name = "btnRemoveFila";
            btnRemoveFila.Size = new Size(48, 37);
            btnRemoveFila.TabIndex = 9;
            btnRemoveFila.Text = "-";
            btnRemoveFila.UseVisualStyleBackColor = true;
            btnRemoveFila.Click += btnRemoveFila_Click;
            // 
            // btnAddFila
            // 
            btnAddFila.Font = new Font("Segoe UI", 14F);
            btnAddFila.Location = new Point(490, 315);
            btnAddFila.Name = "btnAddFila";
            btnAddFila.Size = new Size(48, 37);
            btnAddFila.TabIndex = 8;
            btnAddFila.Text = "+";
            btnAddFila.UseVisualStyleBackColor = true;
            btnAddFila.Click += btnAddFila_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 395);
            Controls.Add(btnRemoveFila);
            Controls.Add(btnAddFila);
            Controls.Add(btnRemovePilha);
            Controls.Add(btnAddPilha);
            Controls.Add(txtFila);
            Controls.Add(txtPilha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxFila);
            Controls.Add(lbxPilha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxPilha;
        private ListBox lbxFila;
        private Label label1;
        private Label label2;
        private TextBox txtPilha;
        private TextBox txtFila;
        private Button btnAddPilha;
        private Button btnRemovePilha;
        private Button btnRemoveFila;
        private Button btnAddFila;
    }
}
