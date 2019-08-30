namespace OneCommandGenerator
{
    partial class OneCommandGenerator
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
            this.lstCmds = new System.Windows.Forms.ListBox();
            this.addCmd = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.rmvAll = new System.Windows.Forms.Button();
            this.rmvSlcd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.command = new System.Windows.Forms.TextBox();
            this.edtCmd = new System.Windows.Forms.Button();
            this.cmdsLabel = new System.Windows.Forms.Label();
            this.opnCmdFile = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstCmds
            // 
            this.lstCmds.FormattingEnabled = true;
            this.lstCmds.Location = new System.Drawing.Point(12, 25);
            this.lstCmds.Name = "lstCmds";
            this.lstCmds.Size = new System.Drawing.Size(307, 160);
            this.lstCmds.TabIndex = 0;
            // 
            // addCmd
            // 
            this.addCmd.Location = new System.Drawing.Point(61, 276);
            this.addCmd.Name = "addCmd";
            this.addCmd.Size = new System.Drawing.Size(101, 23);
            this.addCmd.TabIndex = 1;
            this.addCmd.Text = "Add Command";
            this.addCmd.UseVisualStyleBackColor = true;
            this.addCmd.Click += new System.EventHandler(this.addCmd_Click);
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.generate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.generate.Location = new System.Drawing.Point(93, 334);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(140, 42);
            this.generate.TabIndex = 3;
            this.generate.Text = "Generate!";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // rmvAll
            // 
            this.rmvAll.Location = new System.Drawing.Point(168, 305);
            this.rmvAll.Name = "rmvAll";
            this.rmvAll.Size = new System.Drawing.Size(101, 23);
            this.rmvAll.TabIndex = 4;
            this.rmvAll.Text = "Remove All";
            this.rmvAll.UseVisualStyleBackColor = true;
            this.rmvAll.Click += new System.EventHandler(this.rmvAll_Click);
            // 
            // rmvSlcd
            // 
            this.rmvSlcd.Location = new System.Drawing.Point(61, 305);
            this.rmvSlcd.Name = "rmvSlcd";
            this.rmvSlcd.Size = new System.Drawing.Size(101, 23);
            this.rmvSlcd.TabIndex = 5;
            this.rmvSlcd.Text = "Remove Selected";
            this.rmvSlcd.UseVisualStyleBackColor = true;
            this.rmvSlcd.Click += new System.EventHandler(this.rmvSlcd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Command:";
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(83, 218);
            this.command.MaxLength = 2147483647;
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(166, 20);
            this.command.TabIndex = 8;
            // 
            // edtCmd
            // 
            this.edtCmd.Location = new System.Drawing.Point(168, 276);
            this.edtCmd.Name = "edtCmd";
            this.edtCmd.Size = new System.Drawing.Size(101, 23);
            this.edtCmd.TabIndex = 14;
            this.edtCmd.Text = "Edit Command";
            this.edtCmd.UseVisualStyleBackColor = true;
            this.edtCmd.Click += new System.EventHandler(this.edtCmd_Click);
            // 
            // cmdsLabel
            // 
            this.cmdsLabel.AutoSize = true;
            this.cmdsLabel.Location = new System.Drawing.Point(131, 9);
            this.cmdsLabel.Name = "cmdsLabel";
            this.cmdsLabel.Size = new System.Drawing.Size(62, 13);
            this.cmdsLabel.TabIndex = 15;
            this.cmdsLabel.Text = "Commands:";
            // 
            // opnCmdFile
            // 
            this.opnCmdFile.Location = new System.Drawing.Point(98, 244);
            this.opnCmdFile.Name = "opnCmdFile";
            this.opnCmdFile.Size = new System.Drawing.Size(127, 23);
            this.opnCmdFile.TabIndex = 16;
            this.opnCmdFile.Text = "Open commands file";
            this.opnCmdFile.UseVisualStyleBackColor = true;
            this.opnCmdFile.Click += new System.EventHandler(this.opnCmdFile_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "cmdFile";
            // 
            // OneCommandGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 387);
            this.Controls.Add(this.opnCmdFile);
            this.Controls.Add(this.cmdsLabel);
            this.Controls.Add(this.edtCmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.command);
            this.Controls.Add(this.rmvSlcd);
            this.Controls.Add(this.rmvAll);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.addCmd);
            this.Controls.Add(this.lstCmds);
            this.Name = "OneCommandGenerator";
            this.Text = "FallingSand tower generator ~Duckozaur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCmds;
        private System.Windows.Forms.Button addCmd;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button rmvAll;
        private System.Windows.Forms.Button rmvSlcd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button edtCmd;
        private System.Windows.Forms.Label cmdsLabel;
        private System.Windows.Forms.Button opnCmdFile;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

