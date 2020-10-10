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
            this.userId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.textBoxConclusion = new System.Windows.Forms.TextBox();
            this.bttnConcl = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(136, 44);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(31, 20);
            this.userId.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(173, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(374, 44);
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
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(571, 44);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(144, 20);
            this.textBoxNumber.TabIndex = 6;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(216, 226);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(75, 23);
            this.bttnUpdate.TabIndex = 7;
            this.bttnUpdate.Text = "Обновить";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnRemove
            // 
            this.bttnRemove.Location = new System.Drawing.Point(216, 197);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(75, 23);
            this.bttnRemove.TabIndex = 8;
            this.bttnRemove.Text = "Delete";
            this.bttnRemove.UseVisualStyleBackColor = true;
            this.bttnRemove.Click += new System.EventHandler(this.bttnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnRemove);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.bttnConcl);
            this.Controls.Add(this.textBoxConclusion);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.userId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.TextBox textBoxConclusion;
        private System.Windows.Forms.Button bttnConcl;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnRemove;
    }
}

