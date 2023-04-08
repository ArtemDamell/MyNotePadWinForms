namespace MyNotePad
{
    partial class NotePad_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad_General));
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_general = new System.Windows.Forms.TextBox();
            this.open_fd = new System.Windows.Forms.OpenFileDialog();
            this.save_fd = new System.Windows.Forms.SaveFileDialog();
            this.text_pattern = new System.Windows.Forms.TextBox();
            this.text_replace = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.label_serchEach = new System.Windows.Forms.Label();
            this.label_replaceEach = new System.Windows.Forms.Label();
            this.label_operation = new System.Windows.Forms.Label();
            this.label_operationStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 60);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(93, 12);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 60);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_general
            // 
            this.textBox_general.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_general.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_general.Location = new System.Drawing.Point(12, 78);
            this.textBox_general.Multiline = true;
            this.textBox_general.Name = "textBox_general";
            this.textBox_general.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_general.Size = new System.Drawing.Size(855, 452);
            this.textBox_general.TabIndex = 2;
            this.textBox_general.WordWrap = false;
            // 
            // open_fd
            // 
            this.open_fd.FileName = "openFileDialog1";
            // 
            // text_pattern
            // 
            this.text_pattern.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_pattern.Location = new System.Drawing.Point(180, 52);
            this.text_pattern.Name = "text_pattern";
            this.text_pattern.Size = new System.Drawing.Size(100, 23);
            this.text_pattern.TabIndex = 3;
            // 
            // text_replace
            // 
            this.text_replace.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_replace.Location = new System.Drawing.Point(286, 52);
            this.text_replace.Name = "text_replace";
            this.text_replace.Size = new System.Drawing.Size(100, 23);
            this.text_replace.TabIndex = 4;
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(392, 52);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(71, 23);
            this.button_replace.TabIndex = 5;
            this.button_replace.Text = "Replace";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // label_serchEach
            // 
            this.label_serchEach.AutoSize = true;
            this.label_serchEach.Location = new System.Drawing.Point(193, 36);
            this.label_serchEach.Name = "label_serchEach";
            this.label_serchEach.Size = new System.Drawing.Size(68, 13);
            this.label_serchEach.TabIndex = 6;
            this.label_serchEach.Text = "Search each";
            // 
            // label_replaceEach
            // 
            this.label_replaceEach.AutoSize = true;
            this.label_replaceEach.Location = new System.Drawing.Point(298, 36);
            this.label_replaceEach.Name = "label_replaceEach";
            this.label_replaceEach.Size = new System.Drawing.Size(74, 13);
            this.label_replaceEach.TabIndex = 7;
            this.label_replaceEach.Text = "Replace each";
            // 
            // label_operation
            // 
            this.label_operation.AutoSize = true;
            this.label_operation.Location = new System.Drawing.Point(12, 566);
            this.label_operation.Name = "label_operation";
            this.label_operation.Size = new System.Drawing.Size(80, 13);
            this.label_operation.TabIndex = 8;
            this.label_operation.Text = "Last operation: ";
            // 
            // label_operationStatus
            // 
            this.label_operationStatus.AutoSize = true;
            this.label_operationStatus.Location = new System.Drawing.Point(90, 566);
            this.label_operationStatus.Name = "label_operationStatus";
            this.label_operationStatus.Size = new System.Drawing.Size(10, 13);
            this.label_operationStatus.TabIndex = 9;
            this.label_operationStatus.Text = "-";
            // 
            // NotePad_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 607);
            this.Controls.Add(this.label_operationStatus);
            this.Controls.Add(this.label_operation);
            this.Controls.Add(this.label_replaceEach);
            this.Controls.Add(this.label_serchEach);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.text_replace);
            this.Controls.Add(this.text_pattern);
            this.Controls.Add(this.textBox_general);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(895, 645);
            this.Name = "NotePad_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Notepad --";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_general;
        private System.Windows.Forms.OpenFileDialog open_fd;
        private System.Windows.Forms.SaveFileDialog save_fd;
        private System.Windows.Forms.TextBox text_pattern;
        private System.Windows.Forms.TextBox text_replace;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Label label_serchEach;
        private System.Windows.Forms.Label label_replaceEach;
        private System.Windows.Forms.Label label_operation;
        private System.Windows.Forms.Label label_operationStatus;
    }
}

