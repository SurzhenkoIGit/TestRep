namespace DialogResult
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddProd = new System.Windows.Forms.Button();
            this.btn_ChangeProd = new System.Windows.Forms.Button();
            this.btn_Prod = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cb_Have = new System.Windows.Forms.ComboBox();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_AddProd
            // 
            this.btn_AddProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddProd.Location = new System.Drawing.Point(0, 291);
            this.btn_AddProd.Name = "btn_AddProd";
            this.btn_AddProd.Size = new System.Drawing.Size(467, 23);
            this.btn_AddProd.TabIndex = 1;
            this.btn_AddProd.Text = "Добавить товар";
            this.btn_AddProd.UseVisualStyleBackColor = true;
            this.btn_AddProd.Click += new System.EventHandler(this.btn_AddProd_Click);
            // 
            // btn_ChangeProd
            // 
            this.btn_ChangeProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeProd.Location = new System.Drawing.Point(0, 320);
            this.btn_ChangeProd.Name = "btn_ChangeProd";
            this.btn_ChangeProd.Size = new System.Drawing.Size(467, 23);
            this.btn_ChangeProd.TabIndex = 2;
            this.btn_ChangeProd.Text = "Редактировать товар";
            this.btn_ChangeProd.UseVisualStyleBackColor = true;
            this.btn_ChangeProd.Click += new System.EventHandler(this.btn_ChangeProd_Click);
            // 
            // btn_Prod
            // 
            this.btn_Prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Prod.Location = new System.Drawing.Point(0, 349);
            this.btn_Prod.Name = "btn_Prod";
            this.btn_Prod.Size = new System.Drawing.Size(467, 23);
            this.btn_Prod.TabIndex = 3;
            this.btn_Prod.Text = "Товар";
            this.btn_Prod.UseVisualStyleBackColor = true;
            this.btn_Prod.Click += new System.EventHandler(this.btn_Prod_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.Location = new System.Drawing.Point(0, 378);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(467, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cb_Have
            // 
            this.cb_Have.FormattingEnabled = true;
            this.cb_Have.Location = new System.Drawing.Point(0, 231);
            this.cb_Have.Name = "cb_Have";
            this.cb_Have.Size = new System.Drawing.Size(168, 21);
            this.cb_Have.TabIndex = 5;
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Sum.Location = new System.Drawing.Point(312, 231);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(131, 42);
            this.lbl_Sum.TabIndex = 7;
            this.lbl_Sum.Text = "0,00 руб";
            this.lbl_Sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(467, 225);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 411);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_Sum);
            this.Controls.Add(this.cb_Have);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Prod);
            this.Controls.Add(this.btn_ChangeProd);
            this.Controls.Add(this.btn_AddProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddProd;
        private System.Windows.Forms.Button btn_ChangeProd;
        private System.Windows.Forms.Button btn_Prod;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox cb_Have;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.ListView listView1;
    }
}

