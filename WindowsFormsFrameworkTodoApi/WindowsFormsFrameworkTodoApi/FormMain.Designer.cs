namespace WindowsFormsFrameworkTodoApi
{
    partial class FormMain
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
            this.labelCommandName = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.buttonSendRequest = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelMainFormName = new System.Windows.Forms.Label();
            this.panelServerAndCommand = new System.Windows.Forms.Panel();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonPut = new System.Windows.Forms.RadioButton();
            this.radioButtonPost = new System.Windows.Forms.RadioButton();
            this.radioButtonGet = new System.Windows.Forms.RadioButton();
            this.panelCommand = new System.Windows.Forms.Panel();
            this.richTextBoxCommand = new System.Windows.Forms.RichTextBox();
            this.labelSplitLineServer = new System.Windows.Forms.Label();
            this.labelServerName = new System.Windows.Forms.Label();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.panelAnswerText = new System.Windows.Forms.Panel();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelServerAndCommand.SuspendLayout();
            this.panelCommand.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.panelAnswerText.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCommandName
            // 
            this.labelCommandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCommandName.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.labelCommandName.Location = new System.Drawing.Point(-7, 154);
            this.labelCommandName.Name = "labelCommandName";
            this.labelCommandName.Size = new System.Drawing.Size(577, 33);
            this.labelCommandName.TabIndex = 2;
            this.labelCommandName.Text = "Команда";
            this.labelCommandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textBoxServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxServer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxServer.ForeColor = System.Drawing.Color.White;
            this.textBoxServer.Location = new System.Drawing.Point(13, 45);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(545, 25);
            this.textBoxServer.TabIndex = 3;
            this.textBoxServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxServer.WordWrap = false;
            // 
            // buttonSendRequest
            // 
            this.buttonSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.buttonSendRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSendRequest.FlatAppearance.BorderSize = 0;
            this.buttonSendRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.buttonSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendRequest.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSendRequest.Location = new System.Drawing.Point(0, 0);
            this.buttonSendRequest.Name = "buttonSendRequest";
            this.buttonSendRequest.Size = new System.Drawing.Size(571, 44);
            this.buttonSendRequest.TabIndex = 5;
            this.buttonSendRequest.Text = "Отправить запрос";
            this.buttonSendRequest.UseVisualStyleBackColor = false;
            this.buttonSendRequest.Click += new System.EventHandler(this.buttonSendRequest_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.labelMainFormName, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelServerAndCommand, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelAnswer, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(577, 858);
            this.tableLayoutPanelMain.TabIndex = 6;
            // 
            // labelMainFormName
            // 
            this.labelMainFormName.AutoSize = true;
            this.labelMainFormName.BackColor = System.Drawing.Color.Transparent;
            this.labelMainFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMainFormName.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainFormName.ForeColor = System.Drawing.Color.White;
            this.labelMainFormName.Location = new System.Drawing.Point(3, 0);
            this.labelMainFormName.Name = "labelMainFormName";
            this.labelMainFormName.Size = new System.Drawing.Size(571, 50);
            this.labelMainFormName.TabIndex = 7;
            this.labelMainFormName.Text = "Работа с проектом ToDoApi";
            this.labelMainFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelServerAndCommand
            // 
            this.panelServerAndCommand.BackColor = System.Drawing.Color.Transparent;
            this.panelServerAndCommand.Controls.Add(this.radioButtonDelete);
            this.panelServerAndCommand.Controls.Add(this.radioButtonPut);
            this.panelServerAndCommand.Controls.Add(this.radioButtonPost);
            this.panelServerAndCommand.Controls.Add(this.radioButtonGet);
            this.panelServerAndCommand.Controls.Add(this.panelCommand);
            this.panelServerAndCommand.Controls.Add(this.labelSplitLineServer);
            this.panelServerAndCommand.Controls.Add(this.labelCommandName);
            this.panelServerAndCommand.Controls.Add(this.labelServerName);
            this.panelServerAndCommand.Controls.Add(this.textBoxServer);
            this.panelServerAndCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelServerAndCommand.Location = new System.Drawing.Point(3, 53);
            this.panelServerAndCommand.Name = "panelServerAndCommand";
            this.panelServerAndCommand.Size = new System.Drawing.Size(571, 435);
            this.panelServerAndCommand.TabIndex = 0;
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.radioButtonDelete.Location = new System.Drawing.Point(395, 109);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(91, 28);
            this.radioButtonDelete.TabIndex = 15;
            this.radioButtonDelete.Text = "DELETE";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonPut
            // 
            this.radioButtonPut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonPut.AutoSize = true;
            this.radioButtonPut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.radioButtonPut.Location = new System.Drawing.Point(287, 109);
            this.radioButtonPut.Name = "radioButtonPut";
            this.radioButtonPut.Size = new System.Drawing.Size(64, 28);
            this.radioButtonPut.TabIndex = 14;
            this.radioButtonPut.Text = "PUT";
            this.radioButtonPut.UseVisualStyleBackColor = true;
            // 
            // radioButtonPost
            // 
            this.radioButtonPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonPost.AutoSize = true;
            this.radioButtonPost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.radioButtonPost.Location = new System.Drawing.Point(172, 109);
            this.radioButtonPost.Name = "radioButtonPost";
            this.radioButtonPost.Size = new System.Drawing.Size(73, 28);
            this.radioButtonPost.TabIndex = 13;
            this.radioButtonPost.Text = "POST";
            this.radioButtonPost.UseVisualStyleBackColor = true;
            // 
            // radioButtonGet
            // 
            this.radioButtonGet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonGet.AutoSize = true;
            this.radioButtonGet.Checked = true;
            this.radioButtonGet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.radioButtonGet.Location = new System.Drawing.Point(68, 109);
            this.radioButtonGet.Name = "radioButtonGet";
            this.radioButtonGet.Size = new System.Drawing.Size(64, 28);
            this.radioButtonGet.TabIndex = 12;
            this.radioButtonGet.TabStop = true;
            this.radioButtonGet.Text = "GET";
            this.radioButtonGet.UseVisualStyleBackColor = true;
            // 
            // panelCommand
            // 
            this.panelCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelCommand.Controls.Add(this.richTextBoxCommand);
            this.panelCommand.Location = new System.Drawing.Point(13, 205);
            this.panelCommand.Name = "panelCommand";
            this.panelCommand.Size = new System.Drawing.Size(545, 229);
            this.panelCommand.TabIndex = 11;
            // 
            // richTextBoxCommand
            // 
            this.richTextBoxCommand.AcceptsTab = true;
            this.richTextBoxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.richTextBoxCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCommand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCommand.ForeColor = System.Drawing.Color.White;
            this.richTextBoxCommand.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxCommand.Name = "richTextBoxCommand";
            this.richTextBoxCommand.Size = new System.Drawing.Size(540, 224);
            this.richTextBoxCommand.TabIndex = 0;
            this.richTextBoxCommand.Text = "";
            // 
            // labelSplitLineServer
            // 
            this.labelSplitLineServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSplitLineServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.labelSplitLineServer.Location = new System.Drawing.Point(6, 77);
            this.labelSplitLineServer.Name = "labelSplitLineServer";
            this.labelSplitLineServer.Size = new System.Drawing.Size(552, 2);
            this.labelSplitLineServer.TabIndex = 9;
            // 
            // labelServerName
            // 
            this.labelServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelServerName.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelServerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.labelServerName.Location = new System.Drawing.Point(-3, 0);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(577, 38);
            this.labelServerName.TabIndex = 8;
            this.labelServerName.Text = "Адрес сервера";
            this.labelServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAnswer
            // 
            this.panelAnswer.Controls.Add(this.panelAnswerText);
            this.panelAnswer.Controls.Add(this.labelAnswer);
            this.panelAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswer.Location = new System.Drawing.Point(3, 494);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(571, 311);
            this.panelAnswer.TabIndex = 1;
            // 
            // panelAnswerText
            // 
            this.panelAnswerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelAnswerText.Controls.Add(this.richTextBoxAnswer);
            this.panelAnswerText.Location = new System.Drawing.Point(13, 74);
            this.panelAnswerText.Name = "panelAnswerText";
            this.panelAnswerText.Size = new System.Drawing.Size(545, 223);
            this.panelAnswerText.TabIndex = 12;
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.AcceptsTab = true;
            this.richTextBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.richTextBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnswer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.richTextBoxAnswer.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(540, 218);
            this.richTextBoxAnswer.TabIndex = 0;
            this.richTextBoxAnswer.Text = "";
            // 
            // labelAnswer
            // 
            this.labelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswer.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.labelAnswer.Location = new System.Drawing.Point(1, 24);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(570, 36);
            this.labelAnswer.TabIndex = 9;
            this.labelAnswer.Text = "Ответ от сервера";
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSendRequest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 811);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 44);
            this.panel3.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 858);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelServerAndCommand.ResumeLayout(false);
            this.panelServerAndCommand.PerformLayout();
            this.panelCommand.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.panelAnswerText.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCommandName;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Button buttonSendRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelServerAndCommand;
        private System.Windows.Forms.Label labelMainFormName;
        private System.Windows.Forms.Panel panelAnswer;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelSplitLineServer;
        private System.Windows.Forms.Panel panelCommand;
        private System.Windows.Forms.RichTextBox richTextBoxCommand;
        private System.Windows.Forms.Panel panelAnswerText;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonPut;
        private System.Windows.Forms.RadioButton radioButtonPost;
        private System.Windows.Forms.RadioButton radioButtonGet;
    }
}

