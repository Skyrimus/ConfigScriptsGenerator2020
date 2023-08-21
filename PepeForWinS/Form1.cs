﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Diagnostics;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.CodeDom;

namespace PepeForWinS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(1075, 550);
        }
        public int group, chislo, itog, q;
        public string pepe,Hydra, NAME_USER, IP_ADDRESS, IP_SERVER, MASK, GATEWAY, HOSTNAME, NETWORK, LASTBYTE, DOMAINNAME, REVERS_IP, NAME_POOL, LOW_RANGE, HIGE_RANGE, MASK255, NETBIOS, DOMAIN_NAME_FULL, NAME_GROUP, SERVER_NAME_FULL, SERVER_DOT_SPLIT, USER_NAME, COUNT, USER_NAME2, USER_NAME3, PASSWORD, zaglyshkaq, zaglyshka1q, NAME_POLISY, text, memory, pepememory;
        private static readonly string[] Scopes = { DriveService.Scope.Drive };
        private const string ApplicationName = "PepeSoft";
        private const string FolderId = "12S8KdEPIuKl73B4RJT1wi90HCKdfyB2i";
        private const string _fileName = "test";
        private readonly string _filePath = Directory.GetCurrentDirectory() + @"\Pepe.sh";
        private const string _contentType = "application/x-sh";
        const string CheckSum = "ONDO";
        //---------------------------------------------------------------------------------------------------
        //Main methods and other
        //---------------------------------------------------------------------------------------------------
        private void EXIT(object sender, EventArgs e)
        {
            Application.Exit();
        }//exit
        private static string UTF8ToWin1251(string sourceStr)
        {
            Encoding utf8 = Encoding.UTF8;
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            byte[] utf8Bytes = utf8.GetBytes(sourceStr);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
            return win1251.GetString(win1251Bytes);
        }//generate file
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SendMessageFromSocket(11000);
            }
            catch { }
        }//TCP Client
        public void SendMessageFromSocket(int port)
        {
            // Буфер для входящих данных
            byte[] bytes = new byte[1024];
            // Соединяемся с удаленным устройством
            // Устанавливаем удаленную точку для сокета
            string host = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);
            string message = "1" + host + "\\" + ipAddr + "\\" + CheckSum;
            byte[] msg = Encoding.UTF8.GetBytes(message);
            // Отправляем данные через сокет
            sender.Send(msg);

            string data = null;
            int bytesRec = sender.Receive(bytes);
            data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
            if (data == "Start self_destruction")
            {
                string input = "Ты попал на забаненую ветку. Введи имя ветки + силовые коды через \\  чтобы разлочить приложение. имя ветки: "+CheckSum;
                ShowInputDialog(ref input);
                label40.Text = "Силовые коды: АКТИВНЫ";
                label40.ForeColor = Color.Red;
                if (input != "ONDO\\PEPE\\HYDRA\\RISE")
                {
                    ProcessStartInfo Info = new ProcessStartInfo
                    {
                        Arguments = "/C choice /C Y /N /D Y /T 3 & Del /q " +
                              AppDomain.CurrentDomain.BaseDirectory,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd"
                    };
                    Process.Start(Info);
                    Application.Exit();
                }
            }
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }//TCP Sender\Listener
        private static DialogResult ShowInputDialog(ref string input)
        {
            Size size = new Size(400, 100);
            Form inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = size,
                Text = "ACHTUNG"
            };

            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            Button okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            inputBox.AcceptButton = okButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
        private void DebianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wwwww(groupBox2);
        }//menu Debian
        private void WindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wwwww(groupBox1);
        }//menu Windows
        private void Wwww (GroupBox groupBox)
        {
            groupBox.Visible = true;
            groupBox.BringToFront();
            groupBox.Location = new Point(200, 27);
        }//right menu
        private void Wwwww(GroupBox groupBox)
        {
            groupBox.Visible = true;
            groupBox.BringToFront();
            groupBox.Location = new Point(12, 27);
        }//left menu
        private void Stats(string message, int counter = 0)
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            Socket gooto = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            gooto.Connect(ipEndPoint);
            if (counter!=0)
            {
                message += counter;
            }
            else { message += "1";}
            byte[] msg = Encoding.UTF8.GetBytes(message);
            gooto.Send(msg);
            gooto.Shutdown(SocketShutdown.Both);
            gooto.Close();
        }//statistic sender
        //---------------------------------------------------------------------------------------------------
        //Group11(Main configurate server)
        //---------------------------------------------------------------------------------------------------
        private void Button6_Click(object sender, EventArgs e)
        {
            Wwww(groupBox11);
        }//group11
        private void Button15_Click(object sender, EventArgs e)
        {
            Wwww(groupBox111);
        }//group111
        private void Button13_Click(object sender, EventArgs e)
        {
            Wwww(groupBox112);
        }//group112
        private void Button14_Click(object sender, EventArgs e)
        {
            Wwww(groupBox113);
        }//group113
        private void Button19_Click(object sender, EventArgs e)
        {
            IP_SERVER = textBox1.Text;
            MASK = textBox2.Text;
            GATEWAY = textBox3.Text;
            HOSTNAME = textBox7.Text;
            NETWORK = textBox5.Text;
            LASTBYTE = textBox6.Text;
            NETBIOS = textBox4.Text;
            string[] revers_ip = IP_SERVER.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Resize(ref revers_ip, revers_ip.Length - 1);
            textBox8.Text = revers_ip[2] + "." + revers_ip[1] +"."+ revers_ip[0];
            if (!string.IsNullOrEmpty(IP_SERVER)
                && !string.IsNullOrEmpty(MASK)
                && !string.IsNullOrEmpty(GATEWAY)
                && !string.IsNullOrEmpty(HOSTNAME)
                && !string.IsNullOrEmpty(NETWORK)
                && !string.IsNullOrEmpty(LASTBYTE)
                && !string.IsNullOrEmpty(NETBIOS)) { checkBox1.Checked = true; checkBox1.ForeColor = Color.Lime; }
            if (checkBox1.Checked
                && checkBox2.Checked
                && checkBox3.Checked) { button16.Enabled = true; }
            groupBox11.Visible = true;
            groupBox11.BringToFront();
            groupBox11.Location = new Point(200, 27);
        }//GENERATE GROUP 11 part 1
        private void Button1_Click(object sender, EventArgs e)
        {
            DOMAINNAME = textBox9.Text;
            REVERS_IP = textBox8.Text;
            if (!string.IsNullOrEmpty(DOMAINNAME) && !string.IsNullOrEmpty(REVERS_IP)) { checkBox2.Checked = true; checkBox2.ForeColor = Color.Lime; }
            if (checkBox1.Checked
                && checkBox2.Checked
                && checkBox3.Checked) { button16.Enabled = true; }
            groupBox11.Visible = true;
            groupBox11.BringToFront();
            groupBox11.Location = new Point(200, 27);
        }//GENERATE GROUP 11 part 2
        private void Button12_Click(object sender, EventArgs e)
        {
            NAME_POOL = textBox13.Text;
            LOW_RANGE = textBox12.Text;
            HIGE_RANGE = textBox11.Text;
            MASK255 = textBox10.Text;
            if (!string.IsNullOrEmpty(NAME_POOL)
                && !string.IsNullOrEmpty(LOW_RANGE)
                && !string.IsNullOrEmpty(HIGE_RANGE)
                && !string.IsNullOrEmpty(MASK255)) { checkBox3.Checked = true; checkBox3.ForeColor = Color.Lime; }
            if (checkBox1.Checked
                && checkBox2.Checked
                && checkBox3.Checked) { button16.Enabled = true; }
            groupBox11.Visible = true;
            groupBox11.BringToFront();
            groupBox11.Location = new Point(200, 27);
        }//GENERATE GROUP 11 part 3
        private void Button16_Click(object sender, EventArgs e)
        {
            Stats("2");
            string Memory = "param ([int] $Stage)\n" +
                "function one\n" +
                "{\n" +
                "$action = New-ScheduledTaskAction -Execute 'Powershell.exe' -Argument '" + Environment.CurrentDirectory + "\\test.ps1 -Stage 2'\n" +
                "$trigger = New-ScheduledTaskTrigger -AtLogon\n" +
                "Register-ScheduledTask -Action $action -Trigger $trigger -TaskName \"PEPETEST1\"\n" +
                "New-NetIPAddress -InterfaceIndex 12 -IPAddress " + IP_SERVER + " –PrefixLength " + MASK + " -DefaultGateway " + GATEWAY + "\n" +
                "Set-DnsClientServerAddress -InterfaceIndex 12 -ServerAddresses " + IP_SERVER + ", " + IP_SERVER + "\n" +
                "Rename-Computer -NewName " + HOSTNAME + " -Force\nRestart-Computer -Force\n" +
                "}\n" +
                "function two \n" +
                "{" +
                "$action = New-ScheduledTaskAction -Execute 'Powershell.exe' -Argument '" + Environment.CurrentDirectory + "\\test.ps1 -Stage 3'\n" +
                "$trigger = New-ScheduledTaskTrigger -AtLogon\n" +
                "Register-ScheduledTask -Action $action -Trigger $trigger -TaskName \"PEPETEST2\"\n" +
                "Unregister-ScheduledTask -TaskName \"PEPETEST1\" -Confirm:$false\n" +
                "Import-Module ServerManager\n" +
                "Add-WindowsFeature –Name AD-Domain-Services –IncludeAllSubFeature –IncludeManagementTools\n" +
                "Import-Module ADDSDeployment\n" +
                "Install-ADDSForest -CreateDnsDelegation:$false -DatabasePath \"C:\\Windows\\NTDS\" -DomainMode \"Win2012\" -DomainName \"" + DOMAINNAME + "\" -DomainNetbiosName " + NETBIOS + " -ForestMode \"Win2012\" -InstallDns:$true -LogPath \"C:\\Windows\\NTDS\" -NoRebootOnCompletion:$false -SysvolPath \"C:\\Windows\\SYSVOL\" -Force:$true -SafeModeAdministratorPassword (convertto-securestring Windows1 -asplaintext -force)\n" +
                "}\n" +
                "function three \n" +
                "{\n" +
                "Unregister-ScheduledTask -TaskName \"PEPETEST2\" -Confirm:$false\n" +
                "Set-ExecutionPolicy Restricted\n" +
                "Add-DnsServerPrimaryZone -DynamicUpdate NonsecureAndSecure -NetworkId '" + NETWORK + "/" + MASK + "' -ReplicationScope Domain\n" +
                "Add-DnsServerResourceRecordPtr -Name \"" + LASTBYTE + "\" -ZoneName \"" + REVERS_IP + ".in-addr.arpa\" -AgeRecord -PtrDomainName \"$env:COMPUTERNAME." + DOMAINNAME + "\"\n" +
                "Import-Module ServerManager\n" +
                "Add-WindowsFeature –Name DHCP –IncludeManagementTools\n" +
                "Add-DHCPServerSecurityGroup -ComputerName $env:COMPUTERNAME\n" +
                "Restart-Service dhcpserver\nAdd-DhcpServerInDC -DnsName $env:COMPUTERNAME -IPAddress " + IP_SERVER + "\n" +
                "$User = \"$env:USERDOMAIN\\$env:USERNAME\"\n" +
                "$PWord = ConvertTo-SecureString -String Windows1 -AsPlainText -Force\n" +
                "$Credential = New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $User, $PWord\n" +
                "Set-DHCPServerDnsCredential -ComputerName $env:COMPUTERNAME -Credential $Credential\nAdd-DHCPServerv4Scope -Name " + NAME_POOL + " -StartRange " + LOW_RANGE + " -EndRange " + HIGE_RANGE + " -SubnetMask " + MASK255 + " -State Active\n" +
                "Set-DHCPServerv4OptionValue -ComputerName $env:COMPUTERNAME -DnsServer " + IP_SERVER + " -DnsDomain " + DOMAINNAME + " -Router " + GATEWAY + "\n" +
                "Set-DHCPServerv4OptionValue -ComputerName $env:COMPUTERNAME -ScopeId " + NETWORK + " -DnsServer " + IP_SERVER + " -DnsDomain " + DOMAINNAME + " -Router " + GATEWAY + "\n" +
                "Restart-Computer -Force\n" +
                "}\n" +
                "if($Stage -eq 1) \n" +
                "{\n" +
                "one\n" +
                "}\n" +
                "if($Stage -eq 2) \n" +
                "{\n" +
                "two\n" +
                "}\n" +
                "if($Stage -eq 3) \n" +
                "{\n" +
                "three\n" +
                "}\n";
            try
            {
                using (FileStream fs = File.Create("test.ps1"))
                {
                    Encoding win1251 = Encoding.GetEncoding(1251);
                    string info = UTF8ToWin1251(Memory);
                    using (var sr = new StreamWriter(fs, win1251))
                    {
                        sr.Write(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            DialogResult = MessageBox.Show("Готово! Скрипты сгенерированы в папке с программой, Спасибо за использование PEPESOFT.");
            Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", "Set-ExecutionPolicy Bypass -Forse");
            Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe", " -executionpolicy Bypass -File " + Environment.CurrentDirectory + "\\test.ps1 -Stage 1");
        }//GENERATE GROUP 11 part ALL
        //---------------------------------------------------------------------------------------------------
        //Group12(Configurate User(Many))
        //---------------------------------------------------------------------------------------------------
        private void Button8_Click(object sender, EventArgs e)
        {
            Wwww(groupBox12);
        }//group12
        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            group++;
            if (group % 2 == 1)
            {
                label23.Visible = true;
                label8.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
            }
            else
            {
                label23.Visible = false;
                label8.Visible = false;
                textBox18.Visible = false;
                textBox19.Visible = false;
            }
        }//checked group_user
        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            chislo++;
            if (chislo % 2 == 1)
            {
                label24.Visible = true;
                textBox21.Visible = true;
            }
            else
            {
                label24.Visible = false;
                textBox21.Visible = false;
                textBox21.Text = "1";
            }
        }//how many user generate
        private void Button2_Click(object sender, EventArgs e)
        {
            Stats("3", Convert.ToInt32(COUNT));
            DOMAIN_NAME_FULL = textBox20.Text;
            NAME_GROUP = textBox18.Text;
            SERVER_NAME_FULL = textBox19.Text + "." + DOMAIN_NAME_FULL;
            USER_NAME = textBox17.Text;
            COUNT = textBox21.Text;
            USER_NAME2 = textBox16.Text;
            USER_NAME3 = textBox15.Text;
            PASSWORD = textBox14.Text;
            string[] words = DOMAIN_NAME_FULL.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                words[0] = "DC=" + words[0];
                SERVER_DOT_SPLIT = words[0];
                words[1] = ",DC=" + words[1];
                SERVER_DOT_SPLIT += words[1];
                words[2] = ",DC=" + words[2];
                SERVER_DOT_SPLIT += words[2];
                words[3] = ",DC=" + words[3];
                SERVER_DOT_SPLIT += words[3];
                words[4] = ",DC=" + words[4];
                SERVER_DOT_SPLIT += words[4];
                words[5] = ",DC=" + words[5];
                SERVER_DOT_SPLIT += words[5];
            }
            catch
            {
                string zaglyshka = "New-ADOrganizationalUnit -Name:\"" + NAME_GROUP + "\" -Path:\"" + SERVER_DOT_SPLIT + "\" -ProtectedFromAccidentalDeletion:$true -Server:\"" + SERVER_NAME_FULL + "\"\n";
                string zaglyshka1 = NAME_GROUP?.Length == 0
                    ? "$org=\"" + SERVER_DOT_SPLIT + "\";\n$username=\"" + USER_NAME3 + "\";\n$count=1.." + COUNT + ";\nforeach ($i in $count)\n{{New-AdUser -Name \"" + USER_NAME3 + "$i\" -GivenName \"" + USER_NAME3 + "$i\" -Surname \"" + USER_NAME2 + "$i\" -SamAccountName \"" + USER_NAME + "$i\" -UserPrincipalName \"" + USER_NAME + "$i@" + DOMAIN_NAME_FULL + "\" -Path $org -Enabled $True -ChangePasswordAtLogon $true -AccountPassword (ConvertTo-SecureString \"" + PASSWORD + "\" -AsPlainText -force) -passThru }}"
                    : "$org=\"OU=" + NAME_GROUP + "," + SERVER_DOT_SPLIT + "\"" +
                      "\n$username=\"" + USER_NAME3 + "\"" +
                      "\n$count=1.." + COUNT +
                      "\nforeach ($i in $count)\n{New-AdUser -Name \"" + USER_NAME3 + "$i\" -GivenName \"" + USER_NAME3 + "$i\" -Surname \"" + USER_NAME2 + "$i\" -SamAccountName \"" + USER_NAME + "$i\" -UserPrincipalName \"" + USER_NAME + "$i@" + DOMAIN_NAME_FULL + "\" -Path $org -Enabled $True -ChangePasswordAtLogon $true -AccountPassword (ConvertTo-SecureString \"" + PASSWORD + "\" -AsPlainText -force) -passThru }";

                string zaglyshkaqq = zaglyshka + zaglyshka1;

                        try
                        {
                            using (FileStream fs = File.Create("user.ps1"))
                            {
                                Encoding win1251 = Encoding.GetEncoding(1251);
                                string info = UTF8ToWin1251(zaglyshkaqq);
                                using (var sr = new StreamWriter(fs, win1251))
                                {
                                    sr.Write(info);
                                }
                            }
                        }
                        catch {}
            }
        }//generate group user and\or user(one\more)
        //---------------------------------------------------------------------------------------------------
        //Group13(Configurate User(unique))
        //---------------------------------------------------------------------------------------------------
        private void Button9_Click(object sender, EventArgs e)
        {
            Wwww(groupBox13);
            q = 1;
        }//group13
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            group++;
            if (group % 2 == 1)
            {
                label31.Visible = true;
                label25.Visible = true;
                textBox26.Visible = true;
                textBox27.Visible = true;
            }
            else
            {
                label31.Visible = false;
                label25.Visible = false;
                textBox26.Visible = false;
                textBox27.Visible = false;
            }
        }//checked group
        public void Button11_Click(object sender, EventArgs e)
        {
            DOMAIN_NAME_FULL = textBox28.Text;
            if (!checkBox7.Checked)
            { NAME_GROUP = textBox26.Text; }
            SERVER_NAME_FULL = textBox27.Text + "." + DOMAIN_NAME_FULL;
            USER_NAME = textBox25.Text;
            USER_NAME2 = textBox24.Text;
            USER_NAME3 = textBox23.Text;
            PASSWORD = textBox22.Text;

            string[] words = DOMAIN_NAME_FULL.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                words[0] = "DC=" + words[0];
                SERVER_DOT_SPLIT = words[0];
                words[1] = ",DC=" + words[1];
                SERVER_DOT_SPLIT += words[1];
                words[2] = ",DC=" + words[2];
                SERVER_DOT_SPLIT += words[2];
                words[3] = ",DC=" + words[3];
                SERVER_DOT_SPLIT += words[3];
                words[4] = ",DC=" + words[4];
                SERVER_DOT_SPLIT += words[4];
                words[5] = ",DC=" + words[5];
                SERVER_DOT_SPLIT += words[5];
            }
            catch
            {
                if (checkBox4.Checked)
                {
                        zaglyshkaq = zaglyshkaq + "New-ADOrganizationalUnit -Name:\"" + NAME_GROUP + "\" -Path:\"" + SERVER_DOT_SPLIT + "\" -ProtectedFromAccidentalDeletion:$true -Server:\"" + SERVER_NAME_FULL + "\"\n";
                }
                zaglyshka1q = zaglyshkaq?.Length == 0
                    ? zaglyshka1q + "$org=\"" + SERVER_DOT_SPLIT + "\";\n$username=\"" + USER_NAME3 + "\";\n$count=1;\nforeach ($i in $count)\n{New-AdUser -Name \"" + USER_NAME3 + "\" -GivenName \"" + USER_NAME3 + "\" -Surname \"" + USER_NAME2 + "\" -SamAccountName \"" + USER_NAME + "\" -UserPrincipalName \"" + USER_NAME + "@" + DOMAIN_NAME_FULL + "\" -Path $org -Enabled $True -ChangePasswordAtLogon $true -AccountPassword (ConvertTo-SecureString \"" + PASSWORD + "\" -AsPlainText -force) -passThru }"
                    : zaglyshka1q + "$org=\"OU=" + NAME_GROUP + "," + SERVER_DOT_SPLIT + "\"" +
                      "\n$username=\"" + USER_NAME3 + "\"" +
                      "\n$count=1" +
                      "\nforeach ($i in $count)\n{New-AdUser -Name \"" + USER_NAME3 + "\" -GivenName \"" + USER_NAME3 + "\" -Surname \"" + USER_NAME2 + "\" -SamAccountName \"" + USER_NAME + "\" -UserPrincipalName \"" + USER_NAME + "@" + DOMAIN_NAME_FULL + "\" -Path $org -Enabled $True -ChangePasswordAtLogon $true -AccountPassword (ConvertTo-SecureString \"" + PASSWORD + "\" -AsPlainText -force) -passThru }\n";
            }
            textBox28.Text = textBox26.Text = textBox27.Text = textBox25.Text = textBox24.Text = textBox23.Text = textBox22.Text = PASSWORD = USER_NAME3= USER_NAME2=USER_NAME= SERVER_NAME_FULL= DOMAIN_NAME_FULL="";
            label32.Text= "Всего сгенерируется пользователей: "+q++;
            checkBox7.Visible = true;
        }//memory user
        public void Button7_Click(object sender, EventArgs e)
        {
            Stats("3", Convert.ToInt32(q));
            string zaglyshkaqq= zaglyshkaq + zaglyshka1q;
            try
            {
                using (FileStream fs = File.Create("user.ps1"))
                {
                    Encoding win1251 = Encoding.GetEncoding(1251);
                    string info = UTF8ToWin1251(zaglyshkaqq);
                    using (var sr = new StreamWriter(fs, win1251))
                    {
                        sr.Write(info);
                    }
                }
            }
            catch { }
        }//generate user
        //---------------------------------------------------------------------------------------------------
        //Group14(Configuration GPO)
        //---------------------------------------------------------------------------------------------------
        private void Button10_Click(object sender, EventArgs e)
        {
            Wwww(groupBox14);
        }//group14
        private void Button21_Click(object sender, EventArgs e)
        {
            DOMAIN_NAME_FULL = textBox29.Text;
            NAME_POLISY = textBox31.Text;
            NAME_GROUP = textBox30.Text;

            string[] words = DOMAIN_NAME_FULL.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                words[0] = "OU=" + NAME_GROUP + ",DC=" + words[0];
                SERVER_DOT_SPLIT = words[0];
                words[1] = ",DC=" + words[1];
                SERVER_DOT_SPLIT += words[1];
                words[2] = ",DC=" + words[2];
                SERVER_DOT_SPLIT += words[2];
                words[3] = ",DC=" + words[3];
                SERVER_DOT_SPLIT += words[3];
                words[4] = ",DC=" + words[4];
                SERVER_DOT_SPLIT += words[4];
                words[5] = ",DC=" + words[5];
                SERVER_DOT_SPLIT += words[5];
            }
            catch
            {
                text = "New-GPO -Name \"" + NAME_POLISY + "\" | New-GPLink -Target \"" + SERVER_DOT_SPLIT + "\"\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Policies\\Microsoft\\Windows\\System\" -ValueName DisableCMD -Type DWord -Value 1\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" -ValueName NoRun -Type DWord -Value 1\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" -ValueName DisableRegistryTools -Type DWord -Value 1\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" -ValueName NoControlPanel -Type DWord -Value 1\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" -ValueName ScreenSaveActive -Type String -Value 0\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\ActiveDesktop\" -ValueName NoChangingWallPaper -Type DWord -Value 1\nSet-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" -ValueName EnableFirstLogonAnimation  -Type DWord -Value 0";
                using (FileStream fs = File.Create("polisy.ps1"))
                {
                    Encoding win1251 = Encoding.GetEncoding(1251);
                    string info = UTF8ToWin1251(text);
                    using (var sr = new StreamWriter(fs, win1251))
                    {
                        sr.Write(info);
                    }
                }
            }
        }//using all GPO
        private void Button20_Click(object sender, EventArgs e)
        {
            Stats("4");
            DOMAIN_NAME_FULL = textBox29.Text;
            NAME_POLISY = textBox31.Text;
            NAME_GROUP = textBox30.Text;

            string[] words = DOMAIN_NAME_FULL.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                words[0] = "OU=" + NAME_GROUP + ",DC=" + words[0];
                SERVER_DOT_SPLIT = words[0];
                words[1] = ",DC=" + words[1];
                SERVER_DOT_SPLIT += words[1];
                words[2] = ",DC=" + words[2];
                SERVER_DOT_SPLIT += words[2];
                words[3] = ",DC=" + words[3];
                SERVER_DOT_SPLIT += words[3];
                words[4] = ",DC=" + words[4];
                SERVER_DOT_SPLIT += words[4];
                words[5] = ",DC=" + words[5];
                SERVER_DOT_SPLIT += words[5];
            }
            catch
            {
                text = "New-GPO -Name \"" + NAME_POLISY + "\" | New-GPLink -Target \"" + SERVER_DOT_SPLIT + "\"\n";
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Policies\\Microsoft\\Windows\\System\" -ValueName DisableCMD -Type DWord -Value 1\n"; }
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" -ValueName NoRun -Type DWord -Value 1\n"; }
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" -ValueName DisableRegistryTools -Type DWord -Value 1\n"; }
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" -ValueName NoControlPanel -Type DWord -Value 1\n"; }
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" -ValueName ScreenSaveActive -Type String -Value 0\n"; }
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\ActiveDesktop\" -ValueName NoChangingWallPaper -Type DWord -Value 1\n"; }
                if (checkBox8.Checked)
                { text += "Set-GPRegistryValue -Name \"" + NAME_POLISY + "\" -Key \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" -ValueName EnableFirstLogonAnimation  -Type DWord -Value 0\n"; }
                using (FileStream fs = File.Create("polisy.ps1"))
                {
                    Encoding win1251 = Encoding.GetEncoding(1251);
                    string info = UTF8ToWin1251(text);
                    using (var sr = new StreamWriter(fs, win1251))
                    {
                        sr.Write(info);
                    }
                }
            }
        }//using selective GPO
        //---------------------------------------------------------------------------------------------------
        //Group15(Install application)
        //---------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------
        //Group21(Install Samba & etc)
        //---------------------------------------------------------------------------------------------------
        private void Button24_Click(object sender, EventArgs e)
        {
            Wwww(groupBox21);
        }//group21
        private void Button27_Click(object sender, EventArgs e)
        {
            Stats("2");
            try
            {
                using (FileStream fs = File.Create("Pepe.sh"))
                {
                    Pepegoto();
                    Encoding win1251 = Encoding.GetEncoding(1251);
                    string info = UTF8ToWin1251(Hydra);
                    using (var sr = new StreamWriter(fs, win1251))
                    {
                        sr.Write(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            UserCredential credential = GetUserCredential();
            DriveService service = GetDriveServise(credential);
            UploadFileToDrive(service, _fileName, _filePath, _contentType);
        }//create and upload file bash to google drive
        static private DriveService GetDriveServise(UserCredential credential)
        {
            return new DriveService(
                new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });
        }
        static private UserCredential GetUserCredential()
        {
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string creadPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                creadPath = Path.Combine(creadPath, "driveApiCredentials", "drive-credentials.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "User",
                    CancellationToken.None,
                    new FileDataStore(creadPath, true)).Result;
            }
        }
        private static string UploadFileToDrive(DriveService service, string fileName, string filePath, string contentType)
        {
            var fileMatadata = new Google.Apis.Drive.v3.Data.File
            {
                Name = fileName,
                Parents = new List<string> { FolderId }
            };
            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMatadata, stream, contentType);
                request.Upload();
            }
            var file = request.ResponseBody;
            return file.Id;
        }
        public void Pepegoto()
        {
            DOMAIN_NAME_FULL = textBox32.Text;
            IP_ADDRESS = textBox33.Text;
            NAME_USER = textBox34.Text;
            string[] words = DOMAIN_NAME_FULL.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            string WORKGROUP = words[0].ToUpper(new CultureInfo("en-US", false));
            DOMAIN_NAME_FULL = DOMAIN_NAME_FULL.ToUpper(new CultureInfo("en-US", false));
            Hydra = "#!/bin/bash\nadusername='" + NAME_USER + "'\nip='" + IP_ADDRESS + "'\ndomain='" + words[0] + "'\nworkgroup='" + WORKGROUP + "'\nrealm='" + DOMAIN_NAME_FULL + "'\napt update\napt install net-tools -y\napt install postfix dovecot-dev -y\napt install krb5-user samba winbind -y\nrm -rf /etc/resolv.conf\necho -e \"domain $domain\\nsearch $domain\\nnameserver $ip\" > /etc/resolv.conf\nsed - i 's/WORKGROUP/'$workgroup'/' / etc / samba / smb.conf\nsed -i '/Networking/a realm = '$realm'' /etc/samba/smb.conf\nsed -i 's/standalone server/member server/' /etc/samba/smb.conf\necho '**************************************'\necho 'Vvedite parol ot uchetki Active Directory'\necho '**************************************'\nnet ads join -U $adusername -D $realm\necho ''\necho '**************************************'\necho 'Informaciya o Domene'\necho '**************************************'\nnet ads info";
        }//Bash file internals
        //---------------------------------------------------------------------------------------------------
        //Admin panel?
        //---------------------------------------------------------------------------------------------------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                memory += "H";
            }
            if (e.KeyCode == Keys.Y)
            {
                memory += "Y";
            }
            if (e.KeyCode == Keys.D)
            {
                memory += "D";
            }
            if (e.KeyCode == Keys.R)
            {
                memory += "R";
            }
            if (e.KeyCode == Keys.A)
            {
                memory += "A";
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                memory += "_";
            }
            if (e.KeyCode != Keys.H && e.KeyCode != Keys.Y && e.KeyCode != Keys.D && e.KeyCode != Keys.R && e.KeyCode != Keys.A && e.KeyCode != Keys.OemMinus)
            {
                memory = "";
            }
            if (memory == "HYDRA_")
            {
               pEPEGAToolStripMenuItem.Visible = true;
            }
        }//Visible Admin Panel
        private void PEPEGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wwwww(groupBox4);
        }//Admin panel
        private void Button28_Click(object sender, EventArgs e)
        {
            Wwww(groupBox41);
            string data = null;
            byte[] bytes = new byte[1024];
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
            Socket gooto = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            gooto.Connect(ipEndPoint);
            byte[] msg = Encoding.UTF8.GetBytes("0");
            gooto.Send(msg);
            int bytesRec = gooto.Receive(bytes);
            data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
            gooto.Shutdown(SocketShutdown.Both);
            gooto.Close();
            string[] words = data.Split(new char[] { '\\' });
            label45.Text = words[0];
            label46.Text = words[1];
            label47.Text = words[2];
        }//Statistic
        public void Button26_Click(object sender, EventArgs e)
        {
            Wwww(groupBox42);
            label41.Text = CheckSum;
            
            if (label40.Text == "label40") 
            { 
                label40.Text = "Силовые коды: Неактивны";
                label40.ForeColor = Color.Green;
            }

            
        }//Protected code
        private void Button29_Click(object sender, EventArgs e)
        {
            Wwww(groupBox43);
        }//Just pepe shelter
    }
}