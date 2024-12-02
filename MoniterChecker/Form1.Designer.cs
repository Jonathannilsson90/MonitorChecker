namespace MoniterChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TbxScreenOne = new TextBox();
            label1 = new Label();
            BtnCheck = new Button();
            BtnExit = new Button();
            TbxGeneralInfo = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // TbxScreenOne
            // 
            TbxScreenOne.Location = new Point(17, 228);
            TbxScreenOne.Multiline = true;
            TbxScreenOne.Name = "TbxScreenOne";
            TbxScreenOne.ReadOnly = true;
            TbxScreenOne.Size = new Size(301, 161);
            TbxScreenOne.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 200);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Screen 1:";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(17, 395);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(75, 23);
            BtnCheck.TabIndex = 2;
            BtnCheck.Text = "Check";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(243, 395);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // TbxGeneralInfo
            // 
            TbxGeneralInfo.Location = new Point(17, 32);
            TbxGeneralInfo.Multiline = true;
            TbxGeneralInfo.Name = "TbxGeneralInfo";
            TbxGeneralInfo.ReadOnly = true;
            TbxGeneralInfo.Size = new Size(301, 151);
            TbxGeneralInfo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 537);
            Controls.Add(label2);
            Controls.Add(TbxGeneralInfo);
            Controls.Add(BtnExit);
            Controls.Add(BtnCheck);
            Controls.Add(label1);
            Controls.Add(TbxScreenOne);
            Name = "Form1";
            Text = "MoniterChecker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbxScreenOne;
        private Label label1;
        private Button BtnCheck;
        private Button BtnExit;
        private TextBox TbxGeneralInfo;
        private Label label2;
    }
}
