namespace GestaoStock
{
    partial class Form_Adicionar_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Adicionar_User));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckb_admin = new System.Windows.Forms.CheckBox();
            this.txt_readdpass = new System.Windows.Forms.TextBox();
            this.txt_addpass = new System.Windows.Forms.TextBox();
            this.txt_adduser = new System.Windows.Forms.TextBox();
            this.btn_addlimpar = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_addcancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Pessoal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tel.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(80, 80);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 2;
            this.txt_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tel_KeyDown);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(80, 50);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(199, 20);
            this.txt_email.TabIndex = 1;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(80, 20);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(199, 20);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nome_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ckb_admin);
            this.groupBox2.Controls.Add(this.txt_readdpass);
            this.groupBox2.Controls.Add(this.txt_addpass);
            this.groupBox2.Controls.Add(this.txt_adduser);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username:";
            // 
            // ckb_admin
            // 
            this.ckb_admin.AutoSize = true;
            this.ckb_admin.Location = new System.Drawing.Point(80, 110);
            this.ckb_admin.Name = "ckb_admin";
            this.ckb_admin.Size = new System.Drawing.Size(55, 17);
            this.ckb_admin.TabIndex = 3;
            this.ckb_admin.Text = "Admin";
            this.ckb_admin.UseVisualStyleBackColor = true;
            // 
            // txt_readdpass
            // 
            this.txt_readdpass.Location = new System.Drawing.Point(80, 80);
            this.txt_readdpass.Name = "txt_readdpass";
            this.txt_readdpass.PasswordChar = '*';
            this.txt_readdpass.Size = new System.Drawing.Size(100, 20);
            this.txt_readdpass.TabIndex = 2;
            this.txt_readdpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_readdpass_KeyDown);
            // 
            // txt_addpass
            // 
            this.txt_addpass.Location = new System.Drawing.Point(80, 50);
            this.txt_addpass.Name = "txt_addpass";
            this.txt_addpass.PasswordChar = '*';
            this.txt_addpass.Size = new System.Drawing.Size(100, 20);
            this.txt_addpass.TabIndex = 1;
            this.txt_addpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_addpass_KeyDown);
            // 
            // txt_adduser
            // 
            this.txt_adduser.Location = new System.Drawing.Point(80, 20);
            this.txt_adduser.Name = "txt_adduser";
            this.txt_adduser.Size = new System.Drawing.Size(100, 20);
            this.txt_adduser.TabIndex = 0;
            this.txt_adduser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_adduser_KeyDown);
            // 
            // btn_addlimpar
            // 
            this.btn_addlimpar.Location = new System.Drawing.Point(35, 318);
            this.btn_addlimpar.Name = "btn_addlimpar";
            this.btn_addlimpar.Size = new System.Drawing.Size(75, 23);
            this.btn_addlimpar.TabIndex = 2;
            this.btn_addlimpar.Text = "Limpar";
            this.btn_addlimpar.UseVisualStyleBackColor = true;
            this.btn_addlimpar.Click += new System.EventHandler(this.btn_addlimpar_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(117, 318);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_addcancelar
            // 
            this.btn_addcancelar.Location = new System.Drawing.Point(200, 318);
            this.btn_addcancelar.Name = "btn_addcancelar";
            this.btn_addcancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_addcancelar.TabIndex = 4;
            this.btn_addcancelar.Text = "Cancelar";
            this.btn_addcancelar.UseVisualStyleBackColor = true;
            this.btn_addcancelar.Click += new System.EventHandler(this.btn_addcancelar_Click);
            // 
            // Form_Adicionar_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.btn_addcancelar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_addlimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Adicionar_User";
            this.Text = "Form_Adicionar_User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_admin;
        private System.Windows.Forms.TextBox txt_readdpass;
        private System.Windows.Forms.TextBox txt_addpass;
        private System.Windows.Forms.TextBox txt_adduser;
        private System.Windows.Forms.Button btn_addlimpar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_addcancelar;
    }
}