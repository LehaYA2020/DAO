namespace DAO_Project
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.textBoxConclusion = new System.Windows.Forms.TextBox();
            this.bttnConcl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(266, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(471, 44);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(173, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(216, 130);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 3;
            this.bttnAdd.Text = "Добавить";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // textBoxConclusion
            // 
            this.textBoxConclusion.Location = new System.Drawing.Point(374, 173);
            this.textBoxConclusion.Multiline = true;
            this.textBoxConclusion.Name = "textBoxConclusion";
            this.textBoxConclusion.Size = new System.Drawing.Size(363, 239);
            this.textBoxConclusion.TabIndex = 4;
            // 
            // bttnConcl
            // 
            this.bttnConcl.Location = new System.Drawing.Point(216, 173);
            this.bttnConcl.Name = "bttnConcl";
            this.bttnConcl.Size = new System.Drawing.Size(75, 23);
            this.bttnConcl.TabIndex = 5;
            this.bttnConcl.Text = "Показать";
            this.bttnConcl.UseVisualStyleBackColor = true;
            this.bttnConcl.Click += new System.EventHandler(this.bttnConcl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnConcl);
            this.Controls.Add(this.textBoxConclusion);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.TextBox textBoxConclusion;
        private System.Windows.Forms.Button bttnConcl;
    }
}

