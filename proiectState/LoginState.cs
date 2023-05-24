using LoginRegisterProiect;
using Newtonsoft.Json;
using ProtectionProxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;



namespace proiectState
{
    public class LoginState : IState
    {
        ProxyManager _proxyManager;
        string state;
        System.Windows.Forms.Label _label22;
        System.Windows.Forms.TextBox _textBoxCParola;
        System.Windows.Forms.TextBox _textBoxCUser;
        System.Windows.Forms.TextBox _textBoxCEmail;
        System.Windows.Forms.TextBox _textBoxCNumeReprezentant;
        System.Windows.Forms.TextBox _textBoxCCUI;
        System.Windows.Forms.TextBox _textBoxCNume;
        System.Windows.Forms.TextBox _textBoxSParola;
        System.Windows.Forms.TextBox _textBoxSUser;
        System.Windows.Forms.TextBox _textBoxSSpecializare;
        System.Windows.Forms.TextBox _textBoxSFacultate;
        System.Windows.Forms.TextBox _textBoxSTelefon;
        System.Windows.Forms.TextBox _textBoxSEmail;
        System.Windows.Forms.TextBox _textBoxSPrenume;
        System.Windows.Forms.TextBox _textBoxSNume;
        System.Windows.Forms.TextBox _textBoxPass;
        System.Windows.Forms.TextBox _textBoxUser;
        System.Windows.Forms.Label _label23;
        System.Windows.Forms.Label _label21;
        System.Windows.Forms.ComboBox _comboBoxSAn;
        System.Windows.Forms.TabControl _tabControl1;
        
        Form1 _form;
        public LoginState(Form1 form)
        {
            _form = form;
        }
        public override Action CreeazaFereastra(Form1 form)
        {
            
            System.Windows.Forms.TabPage Login;
            
            System.Windows.Forms.TabPage registerUser;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button buttonLogin;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
             System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Button inregistrareStudent;
            System.Windows.Forms.Label label14;
            System.ComponentModel.BackgroundWorker backgroundWorker1;
            System.Windows.Forms.Button inregistrareCompanie;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
           
            
            
            
            

            _tabControl1 = new System.Windows.Forms.TabControl();
            Login = new System.Windows.Forms.TabPage();
            _label21 = new System.Windows.Forms.Label();
            buttonLogin = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            _textBoxPass = new System.Windows.Forms.TextBox();
            _textBoxUser = new System.Windows.Forms.TextBox();
            registerUser = new System.Windows.Forms.TabPage();
            _label23 = new System.Windows.Forms.Label();
            inregistrareStudent = new System.Windows.Forms.Button();
            _comboBoxSAn = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            _textBoxSParola = new System.Windows.Forms.TextBox();
            _textBoxSUser = new System.Windows.Forms.TextBox();
            _textBoxSSpecializare = new System.Windows.Forms.TextBox();
            _textBoxSFacultate = new System.Windows.Forms.TextBox();
            _textBoxSTelefon = new System.Windows.Forms.TextBox();
            _textBoxSEmail = new System.Windows.Forms.TextBox();
            _textBoxSPrenume = new System.Windows.Forms.TextBox();
            _textBoxSNume = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            _label22 = new System.Windows.Forms.Label();
            inregistrareCompanie = new System.Windows.Forms.Button();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            
            _textBoxCParola = new System.Windows.Forms.TextBox();
            _textBoxCUser = new System.Windows.Forms.TextBox();
            _textBoxCEmail = new System.Windows.Forms.TextBox();
            _textBoxCNumeReprezentant = new System.Windows.Forms.TextBox();
            _textBoxCCUI = new System.Windows.Forms.TextBox();
            _textBoxCNume = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            _tabControl1.SuspendLayout();
            Login.SuspendLayout();
            registerUser.SuspendLayout();
            tabPage1.SuspendLayout();
            
            // 
            // tabControl1
            // 
            _tabControl1.Controls.Add(Login);
            _tabControl1.Controls.Add(registerUser);
            _tabControl1.Controls.Add(tabPage1);
            _tabControl1.Location = new System.Drawing.Point(425, 275);
            _tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _tabControl1.BackColor = Color.Gray;
            _tabControl1.Name = "tabControl1";
            _tabControl1.SelectedIndex = 0;
            _tabControl1.Size = new System.Drawing.Size(450, 330);
            _tabControl1.TabIndex = 0;
            _tabControl1.Tag = "";
            // 
            // Login
            // 
            Login.Controls.Add(_label21);
            Login.Controls.Add(buttonLogin);
            Login.Controls.Add(label3);
            Login.Controls.Add(label2);
            Login.Controls.Add(label1);
            Login.Controls.Add(_textBoxPass);
            Login.Controls.Add(_textBoxUser);
            Login.Location = new System.Drawing.Point(4, 22);
            Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Login.Name = "Login";
            Login.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Login.Size = new System.Drawing.Size(445, 312);
            Login.TabIndex = 0;
            Login.Text = "Autentificare";
            Login.UseVisualStyleBackColor = true;
            form.Controls.Add(_tabControl1);
            // 
            // label21
            // 
            _label21.AutoSize = true;
            _label21.ForeColor = System.Drawing.Color.Red;
            _label21.Location = new System.Drawing.Point(206, 188);
            _label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            _label21.Name = "label21";
            _label21.Size = new System.Drawing.Size(13, 13);
            _label21.TabIndex = 6;
            _label21.Text = "  ";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new System.Drawing.Point(196, 210);
            buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(56, 19);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += new System.EventHandler(buttonLogin_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(192, 62);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 26);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(145, 145);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(145, 102);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // textBoxPass
            // 
            _textBoxPass.Location = new System.Drawing.Point(147, 161);
            _textBoxPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxPass.Name = "textBoxPass";
            _textBoxPass.Size = new System.Drawing.Size(154, 20);
            _textBoxPass.TabIndex = 1;
            _textBoxPass.UseSystemPasswordChar = true;
            // 
            // textBoxUser
            // 
            _textBoxUser.Location = new System.Drawing.Point(147, 117);
            _textBoxUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxUser.Name = "textBoxUser";
            _textBoxUser.Size = new System.Drawing.Size(154, 20);
            _textBoxUser.TabIndex = 0;
            // 
            // registerUser
            // 
            registerUser.Controls.Add(_label23);
            registerUser.Controls.Add(inregistrareStudent);
            registerUser.Controls.Add(_comboBoxSAn);
            registerUser.Controls.Add(label13);
            registerUser.Controls.Add(label12);
            registerUser.Controls.Add(label11);
            registerUser.Controls.Add(label10);
            registerUser.Controls.Add(label9);
            registerUser.Controls.Add(label8);
            registerUser.Controls.Add(label7);
            registerUser.Controls.Add(label6);
            registerUser.Controls.Add(label5);
            registerUser.Controls.Add(_textBoxSParola);
            registerUser.Controls.Add(_textBoxSUser);
            registerUser.Controls.Add(_textBoxSSpecializare);
            registerUser.Controls.Add(_textBoxSFacultate);
            registerUser.Controls.Add(_textBoxSTelefon);
            registerUser.Controls.Add(_textBoxSEmail);
            registerUser.Controls.Add(_textBoxSPrenume);
            registerUser.Controls.Add(_textBoxSNume);
            registerUser.Controls.Add(label4);
            registerUser.Location = new System.Drawing.Point(4, 22);
            registerUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            registerUser.Name = "registerUser";
            registerUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            registerUser.Size = new System.Drawing.Size(445, 312);
            registerUser.TabIndex = 1;
            registerUser.Text = "Inregistrare Student";
            registerUser.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            _label23.AutoSize = true;
            _label23.ForeColor = System.Drawing.Color.Red;
            _label23.Location = new System.Drawing.Point(280, 294);
            _label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            _label23.Name = "label23";
            _label23.Size = new System.Drawing.Size(41, 13);
            _label23.TabIndex = 21;
            _label23.Text = "label23";
            // 
            // inregistrareStudent
            // 
            inregistrareStudent.Location = new System.Drawing.Point(257, 269);
            inregistrareStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            inregistrareStudent.Name = "inregistrareStudent";
            inregistrareStudent.Size = new System.Drawing.Size(150, 19);
            inregistrareStudent.TabIndex = 20;
            inregistrareStudent.Text = "Inregistreaza-te";
            inregistrareStudent.UseVisualStyleBackColor = true;
            inregistrareStudent.Click += new System.EventHandler(inregistrareStudent_Click);
            // 
            // comboBoxSAn
            // 
            _comboBoxSAn.FormattingEnabled = true;
            _comboBoxSAn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "Master 1",
            "Master 2"});
            _comboBoxSAn.Location = new System.Drawing.Point(257, 110);
            _comboBoxSAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _comboBoxSAn.Name = "comboBoxSAn";
            _comboBoxSAn.Size = new System.Drawing.Size(151, 21);
            _comboBoxSAn.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(255, 147);
            label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(32, 13);
            label13.TabIndex = 18;
            label13.Text = "User:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(255, 200);
            label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(40, 13);
            label12.TabIndex = 17;
            label12.Text = "Parola:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(255, 96);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(54, 13);
            label11.TabIndex = 16;
            label11.Text = "An studiu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(255, 46);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(67, 13);
            label10.TabIndex = 15;
            label10.Text = "Specializare:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(31, 254);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 13);
            label9.TabIndex = 14;
            label9.Text = "Facultate:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(31, 200);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 13);
            label8.TabIndex = 13;
            label8.Text = "Nr. Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(31, 147);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(35, 13);
            label7.TabIndex = 12;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 96);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 13);
            label6.TabIndex = 11;
            label6.Text = "Prenume:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(31, 44);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 13);
            label5.TabIndex = 10;
            label5.Text = "Nume:";
            // 
            // textBoxSParola
            // 
            _textBoxSParola.Location = new System.Drawing.Point(257, 215);
            _textBoxSParola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSParola.Name = "textBoxSParola";
            _textBoxSParola.Size = new System.Drawing.Size(151, 20);
            _textBoxSParola.TabIndex = 8;
            _textBoxSParola.UseSystemPasswordChar = true;
            // 
            // textBoxSUser
            // 
            _textBoxSUser.Location = new System.Drawing.Point(257, 162);
            _textBoxSUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSUser.Name = "textBoxSUser";
            _textBoxSUser.Size = new System.Drawing.Size(151, 20);
            _textBoxSUser.TabIndex = 7;
            // 
            // textBoxSSpecializare
            // 
             _textBoxSSpecializare.Location = new System.Drawing.Point(257, 62);
            _textBoxSSpecializare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSSpecializare.Name = "textBoxSSpecializare";
            _textBoxSSpecializare.Size = new System.Drawing.Size(151, 20);
            _textBoxSSpecializare.TabIndex = 6;
            // 
            // textBoxSFacultate
            // 
            _textBoxSFacultate.Location = new System.Drawing.Point(31, 270);
            _textBoxSFacultate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSFacultate.Name = "textBoxSFacultate";
            _textBoxSFacultate.Size = new System.Drawing.Size(151, 20);
            _textBoxSFacultate.TabIndex = 5;
            // 
            // textBoxSTelefon
            // 
            _textBoxSTelefon.Location = new System.Drawing.Point(31, 215);
            _textBoxSTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSTelefon.Name = "textBoxSTelefon";
            _textBoxSTelefon.Size = new System.Drawing.Size(151, 20);
            _textBoxSTelefon.TabIndex = 4;
            // 
            // textBoxSEmail
            // 
            _textBoxSEmail.Location = new System.Drawing.Point(31, 162);
            _textBoxSEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSEmail.Name = "textBoxSEmail";
            _textBoxSEmail.Size = new System.Drawing.Size(151, 20);
            _textBoxSEmail.TabIndex = 3;
            // 
            // textBoxSPrenume
            // 
            _textBoxSPrenume.Location = new System.Drawing.Point(31, 111);
            _textBoxSPrenume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSPrenume.Name = "textBoxSPrenume";
            _textBoxSPrenume.Size = new System.Drawing.Size(151, 20);
            _textBoxSPrenume.TabIndex = 2;
            // 
            // textBoxSNume
            // 
            _textBoxSNume.Location = new System.Drawing.Point(31, 62);
            _textBoxSNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxSNume.Name = "textBoxSNume";
            _textBoxSNume.Size = new System.Drawing.Size(151, 20);
            _textBoxSNume.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(120, 11);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(222, 26);
            label4.TabIndex = 0;
            label4.Text = "Inregistrare Student";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(_label22);
            tabPage1.Controls.Add(inregistrareCompanie);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(_textBoxCParola);
            tabPage1.Controls.Add(_textBoxCUser);
            tabPage1.Controls.Add(_textBoxCEmail);
            tabPage1.Controls.Add(_textBoxCNumeReprezentant);
            tabPage1.Controls.Add(_textBoxCCUI);
            tabPage1.Controls.Add(_textBoxCNume);
            tabPage1.Controls.Add(label14);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tabPage1.Size = new System.Drawing.Size(445, 312);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Inregistrare Companie";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.BackColor = Color.Gray;
            Login.BackColor = Color.Gray;
            registerUser.BackColor = Color.Gray;
            form.BackColor = Color.FromArgb(100, 100, 100);
            // 
            // label22
            // 
            _label22.AutoSize = true;
            _label22.ForeColor = System.Drawing.Color.Red;
            _label22.Location = new System.Drawing.Point(308, 284);
            _label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            _label22.Name = "label22";
            _label22.Size = new System.Drawing.Size(41, 13);
            _label22.TabIndex = 15;
            _label22.Text = "label22";
            // 
            // inregistrareCompanie
            // 
            inregistrareCompanie.Location = new System.Drawing.Point(202, 280);
            inregistrareCompanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            inregistrareCompanie.Name = "inregistrareCompanie";
            inregistrareCompanie.Size = new System.Drawing.Size(56, 19);
            inregistrareCompanie.TabIndex = 14;
            inregistrareCompanie.Text = "Inregistreaza-te";
            inregistrareCompanie.UseVisualStyleBackColor = true;
            inregistrareCompanie.Click += new System.EventHandler(inregistrareCompanie_Click);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(152, 230);
            label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(40, 13);
            label20.TabIndex = 13;
            label20.Text = "Parola:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(152, 188);
            label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(32, 13);
            label19.TabIndex = 12;
            label19.Text = "User:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(242, 89);
            label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(35, 13);
            label18.TabIndex = 11;
            label18.Text = "Email:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(242, 139);
            label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(134, 13);
            label17.TabIndex = 10;
            label17.Text = "Nume Reprezentant Legal:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(58, 139);
            label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(28, 13);
            label16.TabIndex = 9;
            label16.Text = "CUI:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(58, 89);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(88, 13);
            label15.TabIndex = 8;
            label15.Text = "Nume Companie:";
            // 
            // textBoxCParola
            // 
            _textBoxCParola.Location = new System.Drawing.Point(154, 245);
            _textBoxCParola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxCParola.Name = "textBoxCParola";
            _textBoxCParola.Size = new System.Drawing.Size(152, 20);
            _textBoxCParola.TabIndex = 7;
            _textBoxCParola.UseSystemPasswordChar = true;
            // 
            // textBoxCUser
            // 
            _textBoxCUser.Location = new System.Drawing.Point(154, 203);
            _textBoxCUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxCUser.Name = "textBoxCUser";
            _textBoxCUser.Size = new System.Drawing.Size(152, 20);
            _textBoxCUser.TabIndex = 6;
            // 
            // textBoxCEmail
            // 
            _textBoxCEmail.Location = new System.Drawing.Point(244, 104);
            _textBoxCEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxCEmail.Name = "textBoxCEmail";
            _textBoxCEmail.Size = new System.Drawing.Size(152, 20);
            _textBoxCEmail.TabIndex = 5;
            // 
            // textBoxCNumeReprezentant
            // 
            _textBoxCNumeReprezentant.Location = new System.Drawing.Point(244, 154);
            _textBoxCNumeReprezentant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxCNumeReprezentant.Name = "textBoxCNumeReprezentant";
            _textBoxCNumeReprezentant.Size = new System.Drawing.Size(152, 20);
            _textBoxCNumeReprezentant.TabIndex = 4;
            // 
            // textBoxCCUI
            // 
            _textBoxCCUI.Location = new System.Drawing.Point(61, 154);
            _textBoxCCUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxCCUI.Name = "textBoxCCUI";
            _textBoxCCUI.Size = new System.Drawing.Size(152, 20);
            _textBoxCCUI.TabIndex = 3;
            // 
            // textBoxCNume
            // 
            _textBoxCNume.Location = new System.Drawing.Point(61, 104);
            _textBoxCNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            _textBoxCNume.Name = "textBoxCNume";
            _textBoxCNume.Size = new System.Drawing.Size(152, 20);
            _textBoxCNume.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(107, 11);
            label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(248, 26);
            label14.TabIndex = 1;
            label14.Text = "Inregistrare Companie";
            _proxyManager = new ProxyManager();
            return null;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                state = _proxyManager.Login(_textBoxUser.Text, Cryptography.HashString(_textBoxPass.Text));
                _label21.Text = "Autentificat ca " + _textBoxUser.Text + "\n Tip: " + _proxyManager.GetType();
                _form._firmeState = new FirmeState(_form);
                if (_proxyManager.GetType() == "firma")
                {
                    _tabControl1.Hide();
                    IState.SetState(_form._firmeState, () => _form._firmeState.CreeazaFereastra(_form));
                }
                else if (_proxyManager.GetType() == "student")
                {
                    _tabControl1.Hide();
                    IState.SetState(_form._utilizatoriState, () => _form._utilizatoriState.CreeazaFereastra(_form));

                }
            }
            catch (Exception ex)
            {
                _label21.Text = ex.Message;
            }
        }

        private void inregistrareStudent_Click(object sender, EventArgs e)
        {
            string name = _textBoxSNume.Text;
            string pre = _textBoxSPrenume.Text;
            string email = _textBoxSEmail.Text;
            string telefon = _textBoxSTelefon.Text;
            string fac = _textBoxSFacultate.Text;
            string spec = _textBoxSSpecializare.Text;
            string an = _comboBoxSAn.Text;
            string user = _textBoxSUser.Text;
            string pass = Cryptography.HashString(_textBoxSParola.Text);

            Student newS = new Student(name, pre, email, telefon, fac, spec, an, user, pass);

            bool success = _proxyManager.RegisterStudent(newS);

            if (success)
            {
                _label23.Text = "Succes!";
                _tabControl1.Hide();
                IState.SetState(_form._utilizatoriState, () => _form._utilizatoriState.CreeazaFereastra(_form));
            }
            else
            {
                _label23.Text = "Ceva a mers gresit!";
            }
        }

        private void inregistrareCompanie_Click(object sender, EventArgs e)
        {
            string name = _textBoxCNume.Text;
            string cui = _textBoxCCUI.Text;
            string email = _textBoxCEmail.Text;
            string reprezentant = _textBoxCNumeReprezentant.Text;
            string user = _textBoxCUser.Text;
            string pass = Cryptography.HashString(_textBoxCParola.Text);

            Firma newF = new Firma(name, cui, email, reprezentant, user, pass);

            bool success = _proxyManager.RegisterFirma(newF);

            if (success)
            {
                _label22.Text = "Succes!";
                _tabControl1.Hide();
                IState.SetState(_form._firmeState, () => _form._firmeState.CreeazaFereastra(_form));
            }
            else
            {
                _label22.Text = "Ceva a mers gresit!";
               
            }
        }




    }
}
