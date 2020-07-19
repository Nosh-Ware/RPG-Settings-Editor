using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RPG.ini_Editor
{
    public partial class Form1 : Form
    {
        string fileDat = String.Empty;
        string OGGameTitle = String.Empty;

        string iniFind(string inputdata, string lookfor)
        {
            if (inputdata.IndexOf(lookfor) == -1)
            {
                return String.Empty;
            }
            lookfor += "=";
            int length = inputdata.IndexOf("\n", inputdata.IndexOf(lookfor) + lookfor.Length) - (inputdata.IndexOf(lookfor) + lookfor.Length);
            if (length > 0)
            {
                return inputdata.Substring(inputdata.IndexOf(lookfor) + lookfor.Length, length);
            }
            else
            {
                return inputdata.Substring(inputdata.IndexOf(lookfor) + lookfor.Length);
            }
        }

        string iniFind(string inputdata, string lookfor, int length)
        {
            if (inputdata.IndexOf(lookfor) == -1)
            {
                return String.Empty;
            }
            lookfor += "=";
            return inputdata.Substring(inputdata.IndexOf(lookfor) + lookfor.Length, length);
        }

        string iniReplace(string inputdata, string lookfor, string replacewith)
        {
            if (inputdata.IndexOf(lookfor) == -1 || replacewith == String.Empty)
            {
                return inputdata;
            }

            if (inputdata.IndexOf("\n", inputdata.IndexOf(lookfor + "=")) != -1)
            {
                inputdata = inputdata.Remove(inputdata.IndexOf(lookfor + "=") + lookfor.Length + 1, inputdata.IndexOf("\n", inputdata.IndexOf(lookfor + "=")) - (inputdata.IndexOf(lookfor + "=") + lookfor.Length + 1));
            }
            else
            {
                inputdata = inputdata.Remove(inputdata.IndexOf(lookfor + "=") + lookfor.Length + 1);
            }

            return inputdata.Insert(inputdata.IndexOf(lookfor + "=") + lookfor.Length + 1, replacewith);
        }

        string iniRemoveKey(string inputdata, string lookfor)
        {
            if (inputdata.IndexOf(lookfor + "=") == -1)
            {
                return inputdata;
            }
            if (inputdata.IndexOf("\n", inputdata.IndexOf(lookfor + "=")) != -1){
                return inputdata.Remove(inputdata.IndexOf(lookfor + "="), inputdata.IndexOf("\n", inputdata.IndexOf(lookfor + "=")) - inputdata.IndexOf(lookfor + "=") + 1);
            }
            else
            {
                return inputdata.Remove(inputdata.IndexOf(lookfor + "="));
            }
        }

        bool iniSectionExist(string inputdata, string section) {
            return inputdata.IndexOf("[" + section + "]") != -1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDia(object sender, EventArgs e)
        {
            FolderDia.ShowDialog();
            txtFolderLocation.Text = FolderDia.SelectedPath;
            if (txtFolderLocation.Text != String.Empty)
            {
                OpenFile(sender, e);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                fileDat = File.ReadAllText(txtFolderLocation.Text + "\\RPG_RT.ini");

                txtGameTitle.Text = iniFind(fileDat, "GameTitle");
                OGGameTitle = txtGameTitle.Text;

                txtKnownVersion.Text = iniFind(fileDat, "KnownVersion");

                if (iniFind(fileDat, "FullPackageFlag") != String.Empty && Convert.ToInt32(iniFind(fileDat, "FullPackageFlag", 1)) == 1)
                {
                    chkFullPackageFlag.Checked = true;
                }
                else
                {
                    chkFullPackageFlag.Checked = false;
                }

                switch (iniFind(fileDat, "Encoding"))
                {
                    case "1252":
                        dropEncoding.SelectedIndex = 0;
                        break;

                    case "1251":
                        dropEncoding.SelectedIndex = 1;
                        break;

                    case "1250":
                        dropEncoding.SelectedIndex = 2;
                        break;

                    case "932":
                        dropEncoding.SelectedIndex = 3;
                        break;

                    case "950":
                        dropEncoding.SelectedIndex = 4;
                        break;

                    default:
                        dropEncoding.SelectedIndex = 5;
                        break;
                }

                if (File.Exists(txtFolderLocation.Text + "\\" + txtGameTitle.Text.Replace(' ', '_') + ".r3proj"))
                {
                    txtLastEditorVer.Enabled = true;
                    label5.Enabled = true;
                    txtLastEditorVer.Text = File.ReadAllText(txtFolderLocation.Text + "\\" + txtGameTitle.Text.Replace(' ', '_') + ".r3proj");
                }
                else
                {
                    txtLastEditorVer.Enabled = false;
                    label5.Enabled = false;
                    txtLastEditorVer.Text = "Couldn't find " + txtFolderLocation.Text + "\\" + txtGameTitle.Text.Replace(' ', '_') + ".r3proj";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error from " + ex.Source + " is: " + ex.Message);
                MessageBox.Show("Error from " + ex.Source + " is: " + ex.Message, "Error");
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            try
            {
                if (fileDat.IndexOf("[RPG_RT]") == -1) {
                    throw new Exception("Non RPG Maker file opened");
                }

                if (txtGameTitle.Text != String.Empty)
                {
                    if (fileDat.IndexOf("GameTitle=") != -1)
                    {
                        fileDat = iniReplace(fileDat, "GameTitle", txtGameTitle.Text);
                    }
                    else
                    {
                        fileDat = fileDat.Insert(fileDat.IndexOf("\n") + 1, "\nGameTitle=" + txtGameTitle.Text + "\n");
                    }
                }
                else
                {
                    fileDat = iniRemoveKey(fileDat, "GameTitle");
                }

                if (txtKnownVersion.Text != String.Empty)
                {
                    if (fileDat.IndexOf("KnownVersion=") != -1)
                    {
                        fileDat = iniReplace(fileDat, "KnownVersion", txtKnownVersion.Text);
                    }
                    else
                    {
                        fileDat = fileDat.Insert(fileDat.IndexOf("\n") + 1, "KnownVersion=" + txtKnownVersion.Text + "\n");
                    }
                }
                else
                {
                    fileDat = iniRemoveKey(fileDat, "KnownVersion");
                }

                if (chkFullPackageFlag.Checked)
                {
                    if (fileDat.IndexOf("FullPackageFlag=") != -1)
                    {
                        fileDat = iniReplace(fileDat, "FullPackageFlag", "1");
                    }
                    else
                    {
                        fileDat = fileDat.Insert(fileDat.IndexOf("\n") + 1, "FullPackageFlag=1\n");
                    }
                }
                else
                {
                    fileDat = iniRemoveKey(fileDat, "FullPackageFlag");
                }

                if (fileDat.IndexOf("[EasyRPG]") == -1)
                {
                    fileDat += "\n\n[EasyRPG]\n";
                }

                switch (dropEncoding.SelectedIndex)
                {
                    case 0:
                        if (fileDat.IndexOf("Encoding=") != -1)
                        {
                            fileDat = iniReplace(fileDat, "Encoding", "1252");
                        }
                        else
                        {
                            fileDat = fileDat.Insert(fileDat.IndexOf("[EasyRPG]\n") + 10, "Encoding=1252");
                        }
                    break;

                    case 1:
                        if (fileDat.IndexOf("Encoding=") != -1)
                        {
                            fileDat = iniReplace(fileDat, "Encoding", "1251");
                        }
                        else
                        {
                            fileDat = fileDat.Insert(fileDat.IndexOf("[EasyRPG]\n") + 10, "Encoding=1251");
                        }
                    break;

                    case 2:
                        if (fileDat.IndexOf("Encoding=") != -1)
                        {
                            fileDat = iniReplace(fileDat, "Encoding", "1250");
                        }
                        else
                        {
                            fileDat = fileDat.Insert(fileDat.IndexOf("[EasyRPG]\n") + 10, "Encoding=1250");
                        }
                    break;

                    case 3:
                        if (fileDat.IndexOf("Encoding=") != -1)
                        {
                            fileDat = iniReplace(fileDat, "Encoding", "932");
                        }
                        else
                        {
                            fileDat = fileDat.Insert(fileDat.IndexOf("[EasyRPG]\n") + 10, "Encoding=932");
                        }
                    break;
                        
                    case 4:
                        if (fileDat.IndexOf("Encoding=") != -1)
                        {
                            fileDat = iniReplace(fileDat, "Encoding", "950");
                        }
                        else
                        {
                            fileDat = fileDat.Insert(fileDat.IndexOf("[EasyRPG]\n") + 10, "Encoding=950");
                        }
                    break;
                        
                    case 5:
                    default:
                        if (iniSectionExist(fileDat, "EasyRPG")){
                            if (fileDat.Substring(fileDat.IndexOf("\n[EasyRPG]") - 1, 1) == "\n")
                            {
                                fileDat = fileDat.Remove(fileDat.IndexOf("\n[EasyRPG]") - 1);
                            }
                            else
                            {
                                fileDat = fileDat.Remove(fileDat.IndexOf("\n[EasyRPG]"));
                            }
                        }
                    break;
                }

                File.WriteAllText(txtFolderLocation.Text + "\\RPG_RT.ini", fileDat);

                if (txtLastEditorVer.Enabled && txtLastEditorVer.Text != String.Empty && txtGameTitle.Text != String.Empty)
                {
                    File.WriteAllText(txtFolderLocation.Text + "\\" + txtGameTitle.Text.Replace(' ', '_') + ".r3proj", txtLastEditorVer.Text);

                    if (txtGameTitle.Text != OGGameTitle && File.Exists(txtFolderLocation.Text + "\\" + OGGameTitle.Replace(' ', '_') + ".r3proj"))
                    {
                        File.Delete(txtFolderLocation.Text + "\\" + OGGameTitle.Replace(' ', '_') + ".r3proj");
                    }
                }
        }
            catch (Exception ex)
            {
                Console.WriteLine("Error from " + ex.Source + " is: " + ex.Message);
                MessageBox.Show("Error from " + ex.Source + " is: " + ex.Message, "Error");
            }
}

        private void DonateLink(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.patreon.com/noshware?fan_landing=true");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
