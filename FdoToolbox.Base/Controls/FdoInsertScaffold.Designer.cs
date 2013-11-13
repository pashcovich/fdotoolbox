namespace FdoToolbox.Base.Controls
{
    partial class FdoInsertScaffold
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTargetClass = new System.Windows.Forms.Label();
            this.chkUseTransaction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProperties
            // 
            this.grdProperties.AllowUserToAddRows = false;
            this.grdProperties.AllowUserToDeleteRows = false;
            this.grdProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.Location = new System.Drawing.Point(20, 37);
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.Size = new System.Drawing.Size(555, 370);
            this.grdProperties.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(419, 413);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(500, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert into:";
            // 
            // lblTargetClass
            // 
            this.lblTargetClass.AutoSize = true;
            this.lblTargetClass.Location = new System.Drawing.Point(79, 10);
            this.lblTargetClass.Name = "lblTargetClass";
            this.lblTargetClass.Size = new System.Drawing.Size(0, 13);
            this.lblTargetClass.TabIndex = 4;
            // 
            // chkUseTransaction
            // 
            this.chkUseTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUseTransaction.AutoSize = true;
            this.chkUseTransaction.Location = new System.Drawing.Point(20, 419);
            this.chkUseTransaction.Name = "chkUseTransaction";
            this.chkUseTransaction.Size = new System.Drawing.Size(104, 17);
            this.chkUseTransaction.TabIndex = 5;
            this.chkUseTransaction.Text = "Use Transaction";
            this.chkUseTransaction.UseVisualStyleBackColor = true;
            // 
            // FdoInsertScaffold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkUseTransaction);
            this.Controls.Add(this.lblTargetClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grdProperties);
            this.Name = "FdoInsertScaffold";
            this.Size = new System.Drawing.Size(596, 449);
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTargetClass;
        private System.Windows.Forms.CheckBox chkUseTransaction;
    }
}
