namespace CloudFrontSignedURL
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DomainTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileKeyTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrivateKeyTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccessKeyIDTxt = new System.Windows.Forms.TextBox();
            this.CannedPolicyCbx = new System.Windows.Forms.RadioButton();
            this.CustomPolicyCbx = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ValidTxt = new System.Windows.Forms.TextBox();
            this.ExpiredTxt = new System.Windows.Forms.TextBox();
            this.IPTxt = new System.Windows.Forms.TextBox();
            this.GetURLBtn = new System.Windows.Forms.Button();
            this.URLTxt = new System.Windows.Forms.RichTextBox();
            this.CopyURLBtn = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SignedURLCbx = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CookiePnl = new System.Windows.Forms.Panel();
            this.SignatureLbl = new System.Windows.Forms.Label();
            this.SignatureTxt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.KeyPairIdTxt = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CopySignatureBtn = new System.Windows.Forms.Button();
            this.CopyKPIBtn = new System.Windows.Forms.Button();
            this.CopyPolicyBtn = new System.Windows.Forms.Button();
            this.PolicyTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CookiePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Private key";
            // 
            // DomainTxt
            // 
            this.DomainTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainTxt.ForeColor = System.Drawing.Color.Black;
            this.DomainTxt.Location = new System.Drawing.Point(267, 54);
            this.DomainTxt.Name = "DomainTxt";
            this.DomainTxt.Size = new System.Drawing.Size(1096, 51);
            this.DomainTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access key ID";
            // 
            // FileKeyTxt
            // 
            this.FileKeyTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileKeyTxt.ForeColor = System.Drawing.Color.Black;
            this.FileKeyTxt.Location = new System.Drawing.Point(267, 128);
            this.FileKeyTxt.Name = "FileKeyTxt";
            this.FileKeyTxt.Size = new System.Drawing.Size(1096, 51);
            this.FileKeyTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domain";
            // 
            // PrivateKeyTxt
            // 
            this.PrivateKeyTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateKeyTxt.ForeColor = System.Drawing.Color.Black;
            this.PrivateKeyTxt.Location = new System.Drawing.Point(267, 283);
            this.PrivateKeyTxt.Name = "PrivateKeyTxt";
            this.PrivateKeyTxt.Size = new System.Drawing.Size(1096, 51);
            this.PrivateKeyTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "File path";
            // 
            // AccessKeyIDTxt
            // 
            this.AccessKeyIDTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessKeyIDTxt.ForeColor = System.Drawing.Color.Black;
            this.AccessKeyIDTxt.Location = new System.Drawing.Point(267, 205);
            this.AccessKeyIDTxt.Name = "AccessKeyIDTxt";
            this.AccessKeyIDTxt.Size = new System.Drawing.Size(1096, 51);
            this.AccessKeyIDTxt.TabIndex = 7;
            // 
            // CannedPolicyCbx
            // 
            this.CannedPolicyCbx.AutoSize = true;
            this.CannedPolicyCbx.Checked = true;
            this.CannedPolicyCbx.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CannedPolicyCbx.ForeColor = System.Drawing.Color.White;
            this.CannedPolicyCbx.Location = new System.Drawing.Point(32, 127);
            this.CannedPolicyCbx.Name = "CannedPolicyCbx";
            this.CannedPolicyCbx.Size = new System.Drawing.Size(215, 47);
            this.CannedPolicyCbx.TabIndex = 10;
            this.CannedPolicyCbx.TabStop = true;
            this.CannedPolicyCbx.Text = "Canned Policy";
            this.CannedPolicyCbx.UseVisualStyleBackColor = true;
            this.CannedPolicyCbx.CheckedChanged += new System.EventHandler(this.CannedPolicyCbx_CheckedChanged);
            // 
            // CustomPolicyCbx
            // 
            this.CustomPolicyCbx.AutoSize = true;
            this.CustomPolicyCbx.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPolicyCbx.ForeColor = System.Drawing.Color.White;
            this.CustomPolicyCbx.Location = new System.Drawing.Point(32, 56);
            this.CustomPolicyCbx.Name = "CustomPolicyCbx";
            this.CustomPolicyCbx.Size = new System.Drawing.Size(216, 47);
            this.CustomPolicyCbx.TabIndex = 11;
            this.CustomPolicyCbx.TabStop = true;
            this.CustomPolicyCbx.Text = "Custom Policy";
            this.CustomPolicyCbx.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 43);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valid in";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(64, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 43);
            this.label7.TabIndex = 13;
            this.label7.Text = "Expired in";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(64, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 43);
            this.label8.TabIndex = 14;
            this.label8.Text = "IP ";
            // 
            // ValidTxt
            // 
            this.ValidTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidTxt.ForeColor = System.Drawing.Color.Black;
            this.ValidTxt.Location = new System.Drawing.Point(267, 457);
            this.ValidTxt.Name = "ValidTxt";
            this.ValidTxt.Size = new System.Drawing.Size(403, 51);
            this.ValidTxt.TabIndex = 15;
            // 
            // ExpiredTxt
            // 
            this.ExpiredTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiredTxt.ForeColor = System.Drawing.Color.Black;
            this.ExpiredTxt.Location = new System.Drawing.Point(267, 535);
            this.ExpiredTxt.Name = "ExpiredTxt";
            this.ExpiredTxt.Size = new System.Drawing.Size(403, 51);
            this.ExpiredTxt.TabIndex = 16;
            // 
            // IPTxt
            // 
            this.IPTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTxt.ForeColor = System.Drawing.Color.Black;
            this.IPTxt.Location = new System.Drawing.Point(267, 379);
            this.IPTxt.Name = "IPTxt";
            this.IPTxt.Size = new System.Drawing.Size(403, 51);
            this.IPTxt.TabIndex = 17;
            // 
            // GetURLBtn
            // 
            this.GetURLBtn.BackColor = System.Drawing.Color.Gray;
            this.GetURLBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetURLBtn.ForeColor = System.Drawing.Color.White;
            this.GetURLBtn.Location = new System.Drawing.Point(54, 647);
            this.GetURLBtn.Name = "GetURLBtn";
            this.GetURLBtn.Size = new System.Drawing.Size(159, 69);
            this.GetURLBtn.TabIndex = 18;
            this.GetURLBtn.Text = "Get URL";
            this.GetURLBtn.UseVisualStyleBackColor = false;
            this.GetURLBtn.Click += new System.EventHandler(this.GetURLBtn_Click);
            // 
            // URLTxt
            // 
            this.URLTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTxt.Location = new System.Drawing.Point(267, 647);
            this.URLTxt.Name = "URLTxt";
            this.URLTxt.Size = new System.Drawing.Size(1167, 414);
            this.URLTxt.TabIndex = 20;
            this.URLTxt.Text = "";
            // 
            // CopyURLBtn
            // 
            this.CopyURLBtn.BackColor = System.Drawing.Color.Gray;
            this.CopyURLBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyURLBtn.ForeColor = System.Drawing.Color.White;
            this.CopyURLBtn.Location = new System.Drawing.Point(55, 743);
            this.CopyURLBtn.Name = "CopyURLBtn";
            this.CopyURLBtn.Size = new System.Drawing.Size(159, 69);
            this.CopyURLBtn.TabIndex = 21;
            this.CopyURLBtn.Text = "Copy";
            this.CopyURLBtn.UseVisualStyleBackColor = false;
            this.CopyURLBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(37, 127);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(215, 47);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Signed Cookie";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // SignedURLCbx
            // 
            this.SignedURLCbx.AutoSize = true;
            this.SignedURLCbx.Checked = true;
            this.SignedURLCbx.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignedURLCbx.ForeColor = System.Drawing.Color.White;
            this.SignedURLCbx.Location = new System.Drawing.Point(37, 56);
            this.SignedURLCbx.Name = "SignedURLCbx";
            this.SignedURLCbx.Size = new System.Drawing.Size(181, 47);
            this.SignedURLCbx.TabIndex = 22;
            this.SignedURLCbx.TabStop = true;
            this.SignedURLCbx.Text = "Signed URL";
            this.SignedURLCbx.UseVisualStyleBackColor = true;
            this.SignedURLCbx.CheckedChanged += new System.EventHandler(this.SignedURLCbx_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomPolicyCbx);
            this.groupBox1.Controls.Add(this.CannedPolicyCbx);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(735, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 222);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Policy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SignedURLCbx);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1070, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 222);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "URL";
            // 
            // CookiePnl
            // 
            this.CookiePnl.Controls.Add(this.PolicyTxt);
            this.CookiePnl.Controls.Add(this.CopyPolicyBtn);
            this.CookiePnl.Controls.Add(this.CopyKPIBtn);
            this.CookiePnl.Controls.Add(this.CopySignatureBtn);
            this.CookiePnl.Controls.Add(this.label9);
            this.CookiePnl.Controls.Add(this.KeyPairIdTxt);
            this.CookiePnl.Controls.Add(this.label5);
            this.CookiePnl.Controls.Add(this.SignatureTxt);
            this.CookiePnl.Controls.Add(this.SignatureLbl);
            this.CookiePnl.Location = new System.Drawing.Point(220, 615);
            this.CookiePnl.Name = "CookiePnl";
            this.CookiePnl.Size = new System.Drawing.Size(1120, 466);
            this.CookiePnl.TabIndex = 26;
            this.CookiePnl.Visible = false;
            // 
            // SignatureLbl
            // 
            this.SignatureLbl.AutoSize = true;
            this.SignatureLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureLbl.ForeColor = System.Drawing.Color.White;
            this.SignatureLbl.Location = new System.Drawing.Point(30, 44);
            this.SignatureLbl.Name = "SignatureLbl";
            this.SignatureLbl.Size = new System.Drawing.Size(135, 43);
            this.SignatureLbl.TabIndex = 27;
            this.SignatureLbl.Text = "Signature";
            // 
            // SignatureTxt
            // 
            this.SignatureTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureTxt.Location = new System.Drawing.Point(239, 31);
            this.SignatureTxt.Name = "SignatureTxt";
            this.SignatureTxt.Size = new System.Drawing.Size(674, 122);
            this.SignatureTxt.TabIndex = 27;
            this.SignatureTxt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 43);
            this.label5.TabIndex = 28;
            this.label5.Text = "KeyPairId";
            // 
            // KeyPairIdTxt
            // 
            this.KeyPairIdTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPairIdTxt.Location = new System.Drawing.Point(239, 176);
            this.KeyPairIdTxt.Name = "KeyPairIdTxt";
            this.KeyPairIdTxt.Size = new System.Drawing.Size(674, 56);
            this.KeyPairIdTxt.TabIndex = 29;
            this.KeyPairIdTxt.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 43);
            this.label9.TabIndex = 30;
            this.label9.Text = "Policy/Expires";
            // 
            // CopySignatureBtn
            // 
            this.CopySignatureBtn.BackColor = System.Drawing.Color.Gray;
            this.CopySignatureBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopySignatureBtn.ForeColor = System.Drawing.Color.White;
            this.CopySignatureBtn.Location = new System.Drawing.Point(949, 68);
            this.CopySignatureBtn.Name = "CopySignatureBtn";
            this.CopySignatureBtn.Size = new System.Drawing.Size(147, 69);
            this.CopySignatureBtn.TabIndex = 27;
            this.CopySignatureBtn.Text = "Copy";
            this.CopySignatureBtn.UseVisualStyleBackColor = false;
            this.CopySignatureBtn.Click += new System.EventHandler(this.CopySignatureBtn_Click);
            // 
            // CopyKPIBtn
            // 
            this.CopyKPIBtn.BackColor = System.Drawing.Color.Gray;
            this.CopyKPIBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyKPIBtn.ForeColor = System.Drawing.Color.White;
            this.CopyKPIBtn.Location = new System.Drawing.Point(949, 174);
            this.CopyKPIBtn.Name = "CopyKPIBtn";
            this.CopyKPIBtn.Size = new System.Drawing.Size(147, 69);
            this.CopyKPIBtn.TabIndex = 32;
            this.CopyKPIBtn.Text = "Copy";
            this.CopyKPIBtn.UseVisualStyleBackColor = false;
            this.CopyKPIBtn.Click += new System.EventHandler(this.CopyKPIBtn_Click);
            // 
            // CopyPolicyBtn
            // 
            this.CopyPolicyBtn.BackColor = System.Drawing.Color.Gray;
            this.CopyPolicyBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPolicyBtn.ForeColor = System.Drawing.Color.White;
            this.CopyPolicyBtn.Location = new System.Drawing.Point(949, 288);
            this.CopyPolicyBtn.Name = "CopyPolicyBtn";
            this.CopyPolicyBtn.Size = new System.Drawing.Size(147, 69);
            this.CopyPolicyBtn.TabIndex = 33;
            this.CopyPolicyBtn.Text = "Copy";
            this.CopyPolicyBtn.UseVisualStyleBackColor = false;
            this.CopyPolicyBtn.Click += new System.EventHandler(this.CopyPolicyBtn_Click);
            // 
            // PolicyTxt
            // 
            this.PolicyTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolicyTxt.Location = new System.Drawing.Point(239, 258);
            this.PolicyTxt.Name = "PolicyTxt";
            this.PolicyTxt.Size = new System.Drawing.Size(674, 122);
            this.PolicyTxt.TabIndex = 34;
            this.PolicyTxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1505, 1135);
            this.Controls.Add(this.CookiePnl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CopyURLBtn);
            this.Controls.Add(this.URLTxt);
            this.Controls.Add(this.GetURLBtn);
            this.Controls.Add(this.IPTxt);
            this.Controls.Add(this.ExpiredTxt);
            this.Controls.Add(this.ValidTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AccessKeyIDTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrivateKeyTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileKeyTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DomainTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloudFront Signed URL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CookiePnl.ResumeLayout(false);
            this.CookiePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DomainTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileKeyTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrivateKeyTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccessKeyIDTxt;
        private System.Windows.Forms.RadioButton CannedPolicyCbx;
        private System.Windows.Forms.RadioButton CustomPolicyCbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ValidTxt;
        private System.Windows.Forms.TextBox ExpiredTxt;
        private System.Windows.Forms.TextBox IPTxt;
        private System.Windows.Forms.Button GetURLBtn;
        private System.Windows.Forms.RichTextBox URLTxt;
        private System.Windows.Forms.Button CopyURLBtn;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton SignedURLCbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel CookiePnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox SignatureTxt;
        private System.Windows.Forms.Label SignatureLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox KeyPairIdTxt;
        private System.Windows.Forms.Button CopyPolicyBtn;
        private System.Windows.Forms.Button CopyKPIBtn;
        private System.Windows.Forms.Button CopySignatureBtn;
        private System.Windows.Forms.RichTextBox PolicyTxt;
    }
}

