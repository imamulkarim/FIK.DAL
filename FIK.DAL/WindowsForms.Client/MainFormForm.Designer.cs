namespace WindowsForms.Client
{
    partial class MainFormForm
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
            this.btnSingleAll = new System.Windows.Forms.Button();
            this.btnSingleSelective = new System.Windows.Forms.Button();
            this.dgvStudentData = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdateSingleAll = new System.Windows.Forms.Button();
            this.btnCompositeInsetUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadStockAndRcv = new System.Windows.Forms.Button();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSingleAll
            // 
            this.btnSingleAll.Location = new System.Drawing.Point(30, 37);
            this.btnSingleAll.Name = "btnSingleAll";
            this.btnSingleAll.Size = new System.Drawing.Size(178, 90);
            this.btnSingleAll.TabIndex = 0;
            this.btnSingleAll.Text = "Insert Single Data All Property";
            this.btnSingleAll.UseVisualStyleBackColor = true;
            this.btnSingleAll.Click += new System.EventHandler(this.btnSingleAll_Click);
            // 
            // btnSingleSelective
            // 
            this.btnSingleSelective.Location = new System.Drawing.Point(30, 147);
            this.btnSingleSelective.Name = "btnSingleSelective";
            this.btnSingleSelective.Size = new System.Drawing.Size(178, 90);
            this.btnSingleSelective.TabIndex = 1;
            this.btnSingleSelective.Text = "Single Data Selective Property";
            this.btnSingleSelective.UseVisualStyleBackColor = true;
            this.btnSingleSelective.Click += new System.EventHandler(this.btnSingleSelective_Click);
            // 
            // dgvStudentData
            // 
            this.dgvStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData.Location = new System.Drawing.Point(372, 37);
            this.dgvStudentData.Name = "dgvStudentData";
            this.dgvStudentData.Size = new System.Drawing.Size(615, 249);
            this.dgvStudentData.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(372, 292);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(615, 34);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdateSingleAll
            // 
            this.btnUpdateSingleAll.Location = new System.Drawing.Point(30, 254);
            this.btnUpdateSingleAll.Name = "btnUpdateSingleAll";
            this.btnUpdateSingleAll.Size = new System.Drawing.Size(178, 90);
            this.btnUpdateSingleAll.TabIndex = 4;
            this.btnUpdateSingleAll.Text = "Update Single Data All Property";
            this.btnUpdateSingleAll.UseVisualStyleBackColor = true;
            this.btnUpdateSingleAll.Click += new System.EventHandler(this.btnUpdateSingleAll_Click);
            // 
            // btnCompositeInsetUpdate
            // 
            this.btnCompositeInsetUpdate.Location = new System.Drawing.Point(29, 43);
            this.btnCompositeInsetUpdate.Name = "btnCompositeInsetUpdate";
            this.btnCompositeInsetUpdate.Size = new System.Drawing.Size(178, 90);
            this.btnCompositeInsetUpdate.TabIndex = 5;
            this.btnCompositeInsetUpdate.Text = "Composite Model  Insert /Update\r\n";
            this.btnCompositeInsetUpdate.UseVisualStyleBackColor = true;
            this.btnCompositeInsetUpdate.Click += new System.EventHandler(this.btnCompositeInsetUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSingleAll);
            this.panel1.Controls.Add(this.btnSingleSelective);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnUpdateSingleAll);
            this.panel1.Controls.Add(this.dgvStudentData);
            this.panel1.Location = new System.Drawing.Point(56, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 362);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sample Test Student Data";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLoadStockAndRcv);
            this.panel2.Controls.Add(this.dgvPurchase);
            this.panel2.Controls.Add(this.dgvStock);
            this.panel2.Controls.Add(this.btnCompositeInsetUpdate);
            this.panel2.Location = new System.Drawing.Point(26, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 326);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sample Test Purchase Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sample Test Stock Data";
            // 
            // btnLoadStockAndRcv
            // 
            this.btnLoadStockAndRcv.Location = new System.Drawing.Point(373, 286);
            this.btnLoadStockAndRcv.Name = "btnLoadStockAndRcv";
            this.btnLoadStockAndRcv.Size = new System.Drawing.Size(615, 34);
            this.btnLoadStockAndRcv.TabIndex = 8;
            this.btnLoadStockAndRcv.Text = "Load";
            this.btnLoadStockAndRcv.UseVisualStyleBackColor = true;
            this.btnLoadStockAndRcv.Click += new System.EventHandler(this.btnLoadStockAndRcv_Click);
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Location = new System.Drawing.Point(682, 43);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.Size = new System.Drawing.Size(404, 239);
            this.dgvPurchase.TabIndex = 7;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(266, 43);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(404, 239);
            this.dgvStock.TabIndex = 6;
            // 
            // MainFormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainFormForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSingleAll;
        private System.Windows.Forms.Button btnSingleSelective;
        private System.Windows.Forms.DataGridView dgvStudentData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdateSingleAll;
        private System.Windows.Forms.Button btnCompositeInsetUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadStockAndRcv;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

