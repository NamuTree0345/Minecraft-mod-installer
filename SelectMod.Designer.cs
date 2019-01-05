namespace MCInstaller
{
    partial class SelectMod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMod));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomNPC = new System.Windows.Forms.CheckBox();
            this.KoreanChat = new System.Windows.Forms.CheckBox();
            this.MiniMap = new System.Windows.Forms.CheckBox();
            this.Optifine = new System.Windows.Forms.CheckBox();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "모드를 선텍하세요.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Optifine);
            this.groupBox1.Controls.Add(this.MiniMap);
            this.groupBox1.Controls.Add(this.KoreanChat);
            this.groupBox1.Controls.Add(this.CustomNPC);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "모드";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(165, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "설치";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomNPC
            // 
            this.CustomNPC.AutoSize = true;
            this.CustomNPC.Location = new System.Drawing.Point(19, 34);
            this.CustomNPC.Name = "CustomNPC";
            this.CustomNPC.Size = new System.Drawing.Size(118, 16);
            this.CustomNPC.TabIndex = 0;
            this.CustomNPC.Text = "커스텀 NPC 모드";
            this.CustomNPC.UseVisualStyleBackColor = true;
            // 
            // KoreanChat
            // 
            this.KoreanChat.AutoSize = true;
            this.KoreanChat.Location = new System.Drawing.Point(19, 85);
            this.KoreanChat.Name = "KoreanChat";
            this.KoreanChat.Size = new System.Drawing.Size(100, 16);
            this.KoreanChat.TabIndex = 1;
            this.KoreanChat.Text = "룻트 한글챗팅";
            this.KoreanChat.UseVisualStyleBackColor = true;
            // 
            // MiniMap
            // 
            this.MiniMap.AutoSize = true;
            this.MiniMap.Location = new System.Drawing.Point(19, 137);
            this.MiniMap.Name = "MiniMap";
            this.MiniMap.Size = new System.Drawing.Size(60, 16);
            this.MiniMap.TabIndex = 2;
            this.MiniMap.Text = "미니맵";
            this.MiniMap.UseVisualStyleBackColor = true;
            // 
            // Optifine
            // 
            this.Optifine.AutoSize = true;
            this.Optifine.Location = new System.Drawing.Point(19, 193);
            this.Optifine.Name = "Optifine";
            this.Optifine.Size = new System.Drawing.Size(214, 16);
            this.Optifine.TabIndex = 3;
            this.Optifine.Text = "옵티파인(은 링크만 열어줌 ㅋㅋㅋ)";
            this.Optifine.UseVisualStyleBackColor = true;
            // 
            // Loop
            // 
            this.Loop.Interval = 1;
            this.Loop.Tick += new System.EventHandler(this.Loop_Tick);
            // 
            // SelectMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectMod";
            this.Text = "모드 선텍";
            this.Load += new System.EventHandler(this.SelectMod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox KoreanChat;
        private System.Windows.Forms.CheckBox CustomNPC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Optifine;
        private System.Windows.Forms.Timer Loop;
        private System.Windows.Forms.CheckBox MiniMap;
    }
}