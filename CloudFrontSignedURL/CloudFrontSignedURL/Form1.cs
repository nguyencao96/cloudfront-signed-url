using Amazon.CloudFront;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudFrontSignedURL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 680;
            this.Height = 650;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetURLBtn_Click(object sender, EventArgs e)
        {
            String sURL = "Private key path is empty";
            String sFilePath = this.FileKeyTxt.Text;

            if (!String.IsNullOrEmpty(this.PrivateKeyTxt.Text))
            {
                FileInfo oPrivateKey = new FileInfo(this.PrivateKeyTxt.Text);
                if (oPrivateKey.Exists)
                {
                    try
                    {
                        if (this.SignedURLCbx.Checked)
                        {
                            if (this.CustomPolicyCbx.Checked)
                            {
                                sURL = AmazonCloudFrontUrlSigner.GetCustomSignedURL(
                                    AmazonCloudFrontUrlSigner.Protocol.https,
                                    this.DomainTxt.Text,
                                    oPrivateKey,
                                    this.FileKeyTxt.Text,
                                    this.AccessKeyIDTxt.Text,
                                    DateTime.Now.AddSeconds(Convert.ToInt32(this.ExpiredTxt.Text)),
                                    DateTime.Now.AddSeconds(Convert.ToInt32(this.ValidTxt.Text)),
                                    this.IPTxt.Text);
                            }
                            else
                            {
                                sURL = AmazonCloudFrontUrlSigner.GetCannedSignedURL(
                                    AmazonCloudFrontUrlSigner.Protocol.https,
                                    this.DomainTxt.Text,
                                    oPrivateKey,
                                    this.FileKeyTxt.Text,
                                    this.AccessKeyIDTxt.Text,
                                    DateTime.Now.AddSeconds(Convert.ToInt32(this.ExpiredTxt.Text)));
                            }
                        }
                        else
                        {                            
                            if (this.CustomPolicyCbx.Checked)
                            {
                                CookiesForCustomPolicy oCookie = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                                    AmazonCloudFrontCookieSigner.Protocols.Https, 
                                    this.DomainTxt.Text,
                                    oPrivateKey,
                                    this.FileKeyTxt.Text,
                                    this.AccessKeyIDTxt.Text,
                                    DateTime.Now.AddSeconds(Convert.ToInt32(this.ExpiredTxt.Text)),
                                    DateTime.Now.AddSeconds(Convert.ToInt32(this.ValidTxt.Text)),
                                    this.IPTxt.Text);

                                this.SignatureTxt.Text = oCookie.Signature.Value;
                                this.KeyPairIdTxt.Text = oCookie.KeyPairId.Value;
                                this.PolicyTxt.Text = oCookie.Policy.Value;
                            }
                            else
                            {
                                CookiesForCannedPolicy oCookiesForCannedPolicy = AmazonCloudFrontCookieSigner.GetCookiesForCannedPolicy(
                                    AmazonCloudFrontCookieSigner.Protocols.Https,
                                    this.DomainTxt.Text,
                                    oPrivateKey,
                                    this.FileKeyTxt.Text,
                                    this.AccessKeyIDTxt.Text,
                                    DateTime.Now.AddSeconds(Convert.ToInt32(this.ExpiredTxt.Text)));

                                this.SignatureTxt.Text = oCookiesForCannedPolicy.Signature.Value;
                                this.KeyPairIdTxt.Text = oCookiesForCannedPolicy.KeyPairId.Value;
                                this.PolicyTxt.Text = oCookiesForCannedPolicy.Expires.Value;
                            }
                        }
                        
                    }
                    catch (Exception oExp)
                    {
                        sURL = oExp.Message;
                    }
                    
                }
                else
                {
                    sURL = "File not found";
                }
                
            }            

            this.URLTxt.Text = sURL;            
        }

        private void CannedPolicyCbx_CheckedChanged(object sender, EventArgs e)
        {
            this.IPTxt.Enabled = this.CustomPolicyCbx.Checked;
            this.ValidTxt.Enabled = this.CustomPolicyCbx.Checked;
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.URLTxt.Text);
        }

        private void SignedURLCbx_CheckedChanged(object sender, EventArgs e)
        {
            this.URLTxt.Visible = this.SignedURLCbx.Checked;
            this.CopyURLBtn.Visible = this.SignedURLCbx.Checked;
            this.CookiePnl.Visible = !this.SignedURLCbx.Checked;
        }

        private void CopySignatureBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.SignatureTxt.Text);
        }

        private void CopyKPIBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.KeyPairIdTxt.Text);
        }

        private void CopyPolicyBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.PolicyTxt.Text);
        }
    }
}
