using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XmlEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Load Button
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML文件|*.xml";
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                LoadXML(file.FileName.ToString());
            }
        }

        // Save Button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML文件|*.xml";
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                SaveXML(file.FileName.ToString());
            }
        }

        private void LoadXML(string path)
        {
            XmlTextBox.Clear();
            XmlTextBox.Text = DecrtyptLoadXML(path);
        }

        private void SaveXML(string path) {
            EncrtyptSaveXML(path);
        }

        //保存加密文件
        private void EncrtyptSaveXML(string xmlpath)
        {
            string xmlData = XmlTextBox.Text;
            string xxx = Encrypt(xmlData);
            StreamWriter writer;
            writer = File.CreateText(xmlpath);
            writer.Write(xxx);
            writer.Close();
        }

        //读取加密文件
        public string DecrtyptLoadXML(string xmlpath) {
            StreamReader sReader = File.OpenText(xmlpath);
            string xmlData = sReader.ReadToEnd();
            sReader.Close();
            string xxx = Decrypt(xmlData);
            return xxx;
        }

        //加密
        private string Encrypt(string toE)
        {
            if (KeyBox.Text != "")
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(KeyBox.Text);
                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = rDel.CreateEncryptor();
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toE);
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            else
                return toE;
        }

        //解密
        private string Decrypt(string toD)
        {
            if (KeyBox.Text != "")
            {
                //加密和解密采用相同的key,具体值自己填，但是必须为32位
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(KeyBox.Text);
                RijndaelManaged rDel = new RijndaelManaged();
                try
                {
                    rDel.Key = keyArray;
                }
                catch
                {
                    return "密钥长度错误";
                }
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] toEncryptArray;
                byte[] resultArray;
                try
                {
                    toEncryptArray = Convert.FromBase64String(toD);
                    resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                }
                catch
                {
                    return "密钥错误";
                }

                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            else
                return toD;
        }

        
    }
}
