
namespace _4_11_p
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_targetIP = new System.Windows.Forms.TextBox();
            this.textBox_targetPort = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.RedBtn = new System.Windows.Forms.RadioButton();
            this.GreenBtn = new System.Windows.Forms.RadioButton();
            this.BlueBtn = new System.Windows.Forms.RadioButton();
            this.BlackBtn = new System.Windows.Forms.RadioButton();
            this.WhiteBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "目標IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "目標Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "接收port";
            // 
            // textbox_targetIP
            // 
            this.textbox_targetIP.Location = new System.Drawing.Point(95, 33);
            this.textbox_targetIP.Name = "textbox_targetIP";
            this.textbox_targetIP.Size = new System.Drawing.Size(100, 22);
            this.textbox_targetIP.TabIndex = 4;
            // 
            // textBox_targetPort
            // 
            this.textBox_targetPort.Location = new System.Drawing.Point(320, 32);
            this.textBox_targetPort.Name = "textBox_targetPort";
            this.textBox_targetPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_targetPort.TabIndex = 5;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(541, 32);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(100, 22);
            this.textBox_port.TabIndex = 6;
            // 
            // RedBtn
            // 
            this.RedBtn.AutoSize = true;
            this.RedBtn.Location = new System.Drawing.Point(753, 115);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(35, 16);
            this.RedBtn.TabIndex = 7;
            this.RedBtn.TabStop = true;
            this.RedBtn.Text = "紅";
            this.RedBtn.UseVisualStyleBackColor = true;
            // 
            // GreenBtn
            // 
            this.GreenBtn.AutoSize = true;
            this.GreenBtn.Location = new System.Drawing.Point(753, 147);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(35, 16);
            this.GreenBtn.TabIndex = 8;
            this.GreenBtn.TabStop = true;
            this.GreenBtn.Text = "綠";
            this.GreenBtn.UseVisualStyleBackColor = true;
            // 
            // BlueBtn
            // 
            this.BlueBtn.AutoSize = true;
            this.BlueBtn.Location = new System.Drawing.Point(753, 179);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(35, 16);
            this.BlueBtn.TabIndex = 9;
            this.BlueBtn.TabStop = true;
            this.BlueBtn.Text = "藍";
            this.BlueBtn.UseVisualStyleBackColor = true;
            // 
            // BlackBtn
            // 
            this.BlackBtn.AutoSize = true;
            this.BlackBtn.Location = new System.Drawing.Point(753, 211);
            this.BlackBtn.Name = "BlackBtn";
            this.BlackBtn.Size = new System.Drawing.Size(35, 16);
            this.BlackBtn.TabIndex = 10;
            this.BlackBtn.TabStop = true;
            this.BlackBtn.Text = "黑";
            this.BlackBtn.UseVisualStyleBackColor = true;
            // 
            // WhiteBtn
            // 
            this.WhiteBtn.AutoSize = true;
            this.WhiteBtn.Location = new System.Drawing.Point(753, 243);
            this.WhiteBtn.Name = "WhiteBtn";
            this.WhiteBtn.Size = new System.Drawing.Size(35, 16);
            this.WhiteBtn.TabIndex = 11;
            this.WhiteBtn.TabStop = true;
            this.WhiteBtn.Text = "白";
            this.WhiteBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WhiteBtn);
            this.Controls.Add(this.BlackBtn);
            this.Controls.Add(this.BlueBtn);
            this.Controls.Add(this.GreenBtn);
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_targetPort);
            this.Controls.Add(this.textbox_targetIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_targetIP;
        private System.Windows.Forms.TextBox textBox_targetPort;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.RadioButton RedBtn;
        private System.Windows.Forms.RadioButton GreenBtn;
        private System.Windows.Forms.RadioButton BlueBtn;
        private System.Windows.Forms.RadioButton BlackBtn;
        private System.Windows.Forms.RadioButton WhiteBtn;
    }
}

