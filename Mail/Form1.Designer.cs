
namespace Mail
{
    partial class Form1
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.adressRecipient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.sendMessge = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listFileName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // adressRecipient
            // 
            this.adressRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressRecipient.Location = new System.Drawing.Point(18, 50);
            this.adressRecipient.Margin = new System.Windows.Forms.Padding(2);
            this.adressRecipient.Name = "adressRecipient";
            this.adressRecipient.Size = new System.Drawing.Size(255, 23);
            this.adressRecipient.TabIndex = 1;
            this.adressRecipient.Text = "somaisnotacoma@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Получатель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тема:";
            // 
            // subjectMessage
            // 
            this.subjectMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectMessage.Location = new System.Drawing.Point(18, 93);
            this.subjectMessage.Margin = new System.Windows.Forms.Padding(2);
            this.subjectMessage.Name = "subjectMessage";
            this.subjectMessage.Size = new System.Drawing.Size(660, 23);
            this.subjectMessage.TabIndex = 4;
            this.subjectMessage.Text = "тест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Текст:";
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMessage.Location = new System.Drawing.Point(18, 137);
            this.textMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(660, 195);
            this.textMessage.TabIndex = 6;
            this.textMessage.Text = "Если ты получил сообщение, то ты умничка";
            // 
            // sendMessge
            // 
            this.sendMessge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMessge.Location = new System.Drawing.Point(18, 400);
            this.sendMessge.Margin = new System.Windows.Forms.Padding(2);
            this.sendMessge.Name = "sendMessge";
            this.sendMessge.Size = new System.Drawing.Size(141, 23);
            this.sendMessge.TabIndex = 7;
            this.sendMessge.Text = "Отправить";
            this.sendMessge.UseVisualStyleBackColor = true;
            this.sendMessge.Click += new System.EventHandler(this.sendMessge_Click);
            // 
            // addFile
            // 
            this.addFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFile.Location = new System.Drawing.Point(18, 373);
            this.addFile.Margin = new System.Windows.Forms.Padding(2);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(141, 23);
            this.addFile.TabIndex = 9;
            this.addFile.Text = "Прикрепить";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(163, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прикрепленные файлы:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(18, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Авторизоваться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listFileName
            // 
            this.listFileName.FormattingEnabled = true;
            this.listFileName.Location = new System.Drawing.Point(334, 392);
            this.listFileName.Name = "listFileName";
            this.listFileName.Size = new System.Drawing.Size(344, 43);
            this.listFileName.TabIndex = 13;
            this.listFileName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.deleteItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.Controls.Add(this.listFileName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.sendMessge);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adressRecipient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Новое письмо";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox adressRecipient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button sendMessge;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listFileName;
    }
}

