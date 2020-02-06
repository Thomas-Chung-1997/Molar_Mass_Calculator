namespace Molar_Mass_Calculator
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_SortByName = new System.Windows.Forms.Button();
            this.btn_SortBySymbol = new System.Windows.Forms.Button();
            this.btn_SortByAtomic = new System.Windows.Forms.Button();
            this.tbx_ChemicalFormula = new System.Windows.Forms.TextBox();
            this.dgv_Elements = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MolarMass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Elements)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SortByName
            // 
            this.btn_SortByName.Location = new System.Drawing.Point(13, 13);
            this.btn_SortByName.Name = "btn_SortByName";
            this.btn_SortByName.Size = new System.Drawing.Size(168, 23);
            this.btn_SortByName.TabIndex = 0;
            this.btn_SortByName.Text = "Sort By Name";
            this.btn_SortByName.UseVisualStyleBackColor = true;
            this.btn_SortByName.Click += new System.EventHandler(this.btn_SortByName_Click);
            // 
            // btn_SortBySymbol
            // 
            this.btn_SortBySymbol.Location = new System.Drawing.Point(13, 42);
            this.btn_SortBySymbol.Name = "btn_SortBySymbol";
            this.btn_SortBySymbol.Size = new System.Drawing.Size(168, 23);
            this.btn_SortBySymbol.TabIndex = 1;
            this.btn_SortBySymbol.Text = "Sort By Character Symbol";
            this.btn_SortBySymbol.UseVisualStyleBackColor = true;
            this.btn_SortBySymbol.Click += new System.EventHandler(this.btn_SortBySymbol_Click);
            // 
            // btn_SortByAtomic
            // 
            this.btn_SortByAtomic.Location = new System.Drawing.Point(12, 71);
            this.btn_SortByAtomic.Name = "btn_SortByAtomic";
            this.btn_SortByAtomic.Size = new System.Drawing.Size(168, 23);
            this.btn_SortByAtomic.TabIndex = 2;
            this.btn_SortByAtomic.Text = "Sort By Atomic Number";
            this.btn_SortByAtomic.UseVisualStyleBackColor = true;
            this.btn_SortByAtomic.Click += new System.EventHandler(this.btn_SortByAtomic_Click);
            // 
            // tbx_ChemicalFormula
            // 
            this.tbx_ChemicalFormula.Location = new System.Drawing.Point(108, 418);
            this.tbx_ChemicalFormula.Name = "tbx_ChemicalFormula";
            this.tbx_ChemicalFormula.Size = new System.Drawing.Size(276, 20);
            this.tbx_ChemicalFormula.TabIndex = 3;
            this.tbx_ChemicalFormula.TextChanged += new System.EventHandler(this.tbx_ChemicalFormula_TextChanged);
            // 
            // dgv_Elements
            // 
            this.dgv_Elements.AllowUserToAddRows = false;
            this.dgv_Elements.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_Elements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Elements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Elements.Location = new System.Drawing.Point(188, 13);
            this.dgv_Elements.Name = "dgv_Elements";
            this.dgv_Elements.RowHeadersVisible = false;
            this.dgv_Elements.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_Elements.Size = new System.Drawing.Size(422, 399);
            this.dgv_Elements.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chemical Formula";
            // 
            // lbl_MolarMass
            // 
            this.lbl_MolarMass.AutoSize = true;
            this.lbl_MolarMass.Location = new System.Drawing.Point(390, 421);
            this.lbl_MolarMass.Name = "lbl_MolarMass";
            this.lbl_MolarMass.Size = new System.Drawing.Size(172, 13);
            this.lbl_MolarMass.TabIndex = 6;
            this.lbl_MolarMass.Text = "Approx Molar Mass :  0.0000gr/mol";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.lbl_MolarMass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Elements);
            this.Controls.Add(this.tbx_ChemicalFormula);
            this.Controls.Add(this.btn_SortByAtomic);
            this.Controls.Add(this.btn_SortBySymbol);
            this.Controls.Add(this.btn_SortByName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Molar Mass Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Elements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SortByName;
        private System.Windows.Forms.Button btn_SortBySymbol;
        private System.Windows.Forms.Button btn_SortByAtomic;
        private System.Windows.Forms.TextBox tbx_ChemicalFormula;
        private System.Windows.Forms.DataGridView dgv_Elements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MolarMass;
    }
}

