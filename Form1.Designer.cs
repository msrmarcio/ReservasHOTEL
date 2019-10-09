namespace Btg.PocReserva.UI
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
            this.components = new System.ComponentModel.Container();
            this.BtgLogin = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gpbCampo = new System.Windows.Forms.GroupBox();
            this.rbtAvare = new System.Windows.Forms.RadioButton();
            this.rbtAreado = new System.Windows.Forms.RadioButton();
            this.gpbPraia = new System.Windows.Forms.GroupBox();
            this.btnMaresias = new System.Windows.Forms.RadioButton();
            this.btnGuaruja = new System.Windows.Forms.RadioButton();
            this.btnUbatuba = new System.Windows.Forms.RadioButton();
            this.btnItanhaem = new System.Windows.Forms.RadioButton();
            this.btnCaragua = new System.Windows.Forms.RadioButton();
            this.gpbThermas = new System.Windows.Forms.GroupBox();
            this.rbtIbira = new System.Windows.Forms.RadioButton();
            this.rbtSaoPedro = new System.Windows.Forms.RadioButton();
            this.gpbMontanha = new System.Windows.Forms.GroupBox();
            this.btnPocos = new System.Windows.Forms.RadioButton();
            this.btnCampos = new System.Windows.Forms.RadioButton();
            this.btnSaha = new System.Windows.Forms.RadioButton();
            this.btnMonte = new System.Windows.Forms.RadioButton();
            this.btnAppenzell = new System.Windows.Forms.RadioButton();
            this.gpbCircuito = new System.Windows.Forms.GroupBox();
            this.btnSocorro = new System.Windows.Forms.RadioButton();
            this.btnLindoia = new System.Windows.Forms.RadioButton();
            this.btnSerra = new System.Windows.Forms.RadioButton();
            this.btnAmapro = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkPraia = new System.Windows.Forms.CheckBox();
            this.chkThermas = new System.Windows.Forms.CheckBox();
            this.chkCircuito = new System.Windows.Forms.CheckBox();
            this.chkMontanha = new System.Windows.Forms.CheckBox();
            this.chkCampo = new System.Windows.Forms.CheckBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.pnlFuncoes = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gpbCampo.SuspendLayout();
            this.gpbPraia.SuspendLayout();
            this.gpbThermas.SuspendLayout();
            this.gpbMontanha.SuspendLayout();
            this.gpbCircuito.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtgLogin
            // 
            this.BtgLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtgLogin.FlatAppearance.BorderSize = 0;
            this.BtgLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtgLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtgLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtgLogin.Location = new System.Drawing.Point(3, 1);
            this.BtgLogin.Name = "BtgLogin";
            this.BtgLogin.Size = new System.Drawing.Size(190, 53);
            this.BtgLogin.TabIndex = 0;
            this.BtgLogin.Text = "Authentication";
            this.BtgLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtgLogin.UseVisualStyleBackColor = false;
            this.BtgLogin.Click += new System.EventHandler(this.BtgLogin_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnlimpar.FlatAppearance.BorderSize = 0;
            this.btnlimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Location = new System.Drawing.Point(3, 54);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(190, 53);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "SUCESSO";
            this.notifyIcon1.Visible = true;
            // 
            // gpbCampo
            // 
            this.gpbCampo.Controls.Add(this.rbtAvare);
            this.gpbCampo.Controls.Add(this.rbtAreado);
            this.gpbCampo.Enabled = false;
            this.gpbCampo.Location = new System.Drawing.Point(175, 245);
            this.gpbCampo.Name = "gpbCampo";
            this.gpbCampo.Size = new System.Drawing.Size(152, 73);
            this.gpbCampo.TabIndex = 2;
            this.gpbCampo.TabStop = false;
            this.gpbCampo.Text = "CAMPO";
            // 
            // rbtAvare
            // 
            this.rbtAvare.AutoSize = true;
            this.rbtAvare.Location = new System.Drawing.Point(7, 43);
            this.rbtAvare.Name = "rbtAvare";
            this.rbtAvare.Size = new System.Drawing.Size(53, 17);
            this.rbtAvare.TabIndex = 1;
            this.rbtAvare.TabStop = true;
            this.rbtAvare.Text = "Avaré";
            this.rbtAvare.UseVisualStyleBackColor = true;
            // 
            // rbtAreado
            // 
            this.rbtAreado.AutoSize = true;
            this.rbtAreado.Location = new System.Drawing.Point(7, 20);
            this.rbtAreado.Name = "rbtAreado";
            this.rbtAreado.Size = new System.Drawing.Size(59, 17);
            this.rbtAreado.TabIndex = 0;
            this.rbtAreado.TabStop = true;
            this.rbtAreado.Tag = "https://4001.afpesp.org.br/RetornaDisponibilidade?callback=RetornaDisponibilidade" +
    "&strDataChegada=30%2F01%2F2020&_=1570136172167";
            this.rbtAreado.Text = "Areado";
            this.rbtAreado.UseVisualStyleBackColor = true;
            // 
            // gpbPraia
            // 
            this.gpbPraia.Controls.Add(this.btnMaresias);
            this.gpbPraia.Controls.Add(this.btnGuaruja);
            this.gpbPraia.Controls.Add(this.btnUbatuba);
            this.gpbPraia.Controls.Add(this.btnItanhaem);
            this.gpbPraia.Controls.Add(this.btnCaragua);
            this.gpbPraia.Enabled = false;
            this.gpbPraia.Location = new System.Drawing.Point(12, 77);
            this.gpbPraia.Name = "gpbPraia";
            this.gpbPraia.Size = new System.Drawing.Size(152, 136);
            this.gpbPraia.TabIndex = 3;
            this.gpbPraia.TabStop = false;
            this.gpbPraia.Text = "PRAIA";
            // 
            // btnMaresias
            // 
            this.btnMaresias.AutoSize = true;
            this.btnMaresias.Location = new System.Drawing.Point(7, 111);
            this.btnMaresias.Name = "btnMaresias";
            this.btnMaresias.Size = new System.Drawing.Size(67, 17);
            this.btnMaresias.TabIndex = 6;
            this.btnMaresias.TabStop = true;
            this.btnMaresias.Text = "Maresias";
            this.btnMaresias.UseVisualStyleBackColor = true;
            // 
            // btnGuaruja
            // 
            this.btnGuaruja.AutoSize = true;
            this.btnGuaruja.Location = new System.Drawing.Point(7, 88);
            this.btnGuaruja.Name = "btnGuaruja";
            this.btnGuaruja.Size = new System.Drawing.Size(62, 17);
            this.btnGuaruja.TabIndex = 5;
            this.btnGuaruja.TabStop = true;
            this.btnGuaruja.Text = "Guaruja";
            this.btnGuaruja.UseVisualStyleBackColor = true;
            // 
            // btnUbatuba
            // 
            this.btnUbatuba.AutoSize = true;
            this.btnUbatuba.Location = new System.Drawing.Point(7, 65);
            this.btnUbatuba.Name = "btnUbatuba";
            this.btnUbatuba.Size = new System.Drawing.Size(66, 17);
            this.btnUbatuba.TabIndex = 4;
            this.btnUbatuba.TabStop = true;
            this.btnUbatuba.Text = "Ubatuba";
            this.btnUbatuba.UseVisualStyleBackColor = true;
            // 
            // btnItanhaem
            // 
            this.btnItanhaem.AutoSize = true;
            this.btnItanhaem.Location = new System.Drawing.Point(6, 42);
            this.btnItanhaem.Name = "btnItanhaem";
            this.btnItanhaem.Size = new System.Drawing.Size(69, 17);
            this.btnItanhaem.TabIndex = 3;
            this.btnItanhaem.TabStop = true;
            this.btnItanhaem.Text = "Itanhaem";
            this.btnItanhaem.UseVisualStyleBackColor = true;
            // 
            // btnCaragua
            // 
            this.btnCaragua.AutoSize = true;
            this.btnCaragua.Location = new System.Drawing.Point(6, 19);
            this.btnCaragua.Name = "btnCaragua";
            this.btnCaragua.Size = new System.Drawing.Size(65, 17);
            this.btnCaragua.TabIndex = 2;
            this.btnCaragua.TabStop = true;
            this.btnCaragua.Text = "Caragua";
            this.btnCaragua.UseVisualStyleBackColor = true;
            // 
            // gpbThermas
            // 
            this.gpbThermas.Controls.Add(this.rbtIbira);
            this.gpbThermas.Controls.Add(this.rbtSaoPedro);
            this.gpbThermas.Enabled = false;
            this.gpbThermas.Location = new System.Drawing.Point(12, 219);
            this.gpbThermas.Name = "gpbThermas";
            this.gpbThermas.Size = new System.Drawing.Size(152, 79);
            this.gpbThermas.TabIndex = 4;
            this.gpbThermas.TabStop = false;
            this.gpbThermas.Text = "THERMAS";
            // 
            // rbtIbira
            // 
            this.rbtIbira.AutoSize = true;
            this.rbtIbira.Location = new System.Drawing.Point(6, 42);
            this.rbtIbira.Name = "rbtIbira";
            this.rbtIbira.Size = new System.Drawing.Size(45, 17);
            this.rbtIbira.TabIndex = 3;
            this.rbtIbira.TabStop = true;
            this.rbtIbira.Text = "Ibira";
            this.rbtIbira.UseVisualStyleBackColor = true;
            // 
            // rbtSaoPedro
            // 
            this.rbtSaoPedro.AutoSize = true;
            this.rbtSaoPedro.Location = new System.Drawing.Point(6, 19);
            this.rbtSaoPedro.Name = "rbtSaoPedro";
            this.rbtSaoPedro.Size = new System.Drawing.Size(75, 17);
            this.rbtSaoPedro.TabIndex = 2;
            this.rbtSaoPedro.TabStop = true;
            this.rbtSaoPedro.Text = "Sao Pedro";
            this.rbtSaoPedro.UseVisualStyleBackColor = true;
            // 
            // gpbMontanha
            // 
            this.gpbMontanha.Controls.Add(this.btnPocos);
            this.gpbMontanha.Controls.Add(this.btnCampos);
            this.gpbMontanha.Controls.Add(this.btnSaha);
            this.gpbMontanha.Controls.Add(this.btnMonte);
            this.gpbMontanha.Controls.Add(this.btnAppenzell);
            this.gpbMontanha.Enabled = false;
            this.gpbMontanha.Location = new System.Drawing.Point(333, 77);
            this.gpbMontanha.Name = "gpbMontanha";
            this.gpbMontanha.Size = new System.Drawing.Size(146, 141);
            this.gpbMontanha.TabIndex = 6;
            this.gpbMontanha.TabStop = false;
            this.gpbMontanha.Text = "MONTANHA";
            // 
            // btnPocos
            // 
            this.btnPocos.AutoSize = true;
            this.btnPocos.Location = new System.Drawing.Point(6, 112);
            this.btnPocos.Name = "btnPocos";
            this.btnPocos.Size = new System.Drawing.Size(105, 17);
            this.btnPocos.TabIndex = 8;
            this.btnPocos.Text = "Poços de Caldas";
            this.btnPocos.UseVisualStyleBackColor = true;
            // 
            // btnCampos
            // 
            this.btnCampos.AutoSize = true;
            this.btnCampos.Location = new System.Drawing.Point(6, 89);
            this.btnCampos.Name = "btnCampos";
            this.btnCampos.Size = new System.Drawing.Size(98, 17);
            this.btnCampos.TabIndex = 7;
            this.btnCampos.Text = "Campos Jordao";
            this.btnCampos.UseVisualStyleBackColor = true;
            // 
            // btnSaha
            // 
            this.btnSaha.AutoSize = true;
            this.btnSaha.Location = new System.Drawing.Point(6, 66);
            this.btnSaha.Name = "btnSaha";
            this.btnSaha.Size = new System.Drawing.Size(50, 17);
            this.btnSaha.TabIndex = 6;
            this.btnSaha.Text = "Saha";
            this.btnSaha.UseVisualStyleBackColor = true;
            // 
            // btnMonte
            // 
            this.btnMonte.AutoSize = true;
            this.btnMonte.Location = new System.Drawing.Point(6, 43);
            this.btnMonte.Name = "btnMonte";
            this.btnMonte.Size = new System.Drawing.Size(86, 17);
            this.btnMonte.TabIndex = 3;
            this.btnMonte.Text = "Monte Verde";
            this.btnMonte.UseVisualStyleBackColor = true;
            // 
            // btnAppenzell
            // 
            this.btnAppenzell.AutoSize = true;
            this.btnAppenzell.Location = new System.Drawing.Point(6, 19);
            this.btnAppenzell.Name = "btnAppenzell";
            this.btnAppenzell.Size = new System.Drawing.Size(71, 17);
            this.btnAppenzell.TabIndex = 2;
            this.btnAppenzell.Text = "Appenzell";
            this.btnAppenzell.UseVisualStyleBackColor = true;
            // 
            // gpbCircuito
            // 
            this.gpbCircuito.Controls.Add(this.btnSocorro);
            this.gpbCircuito.Controls.Add(this.btnLindoia);
            this.gpbCircuito.Controls.Add(this.btnSerra);
            this.gpbCircuito.Controls.Add(this.btnAmapro);
            this.gpbCircuito.Enabled = false;
            this.gpbCircuito.Location = new System.Drawing.Point(175, 77);
            this.gpbCircuito.Name = "gpbCircuito";
            this.gpbCircuito.Size = new System.Drawing.Size(152, 162);
            this.gpbCircuito.TabIndex = 5;
            this.gpbCircuito.TabStop = false;
            this.gpbCircuito.Text = "CIRCUITO DAS AGUAS";
            // 
            // btnSocorro
            // 
            this.btnSocorro.AutoSize = true;
            this.btnSocorro.Location = new System.Drawing.Point(7, 91);
            this.btnSocorro.Name = "btnSocorro";
            this.btnSocorro.Size = new System.Drawing.Size(62, 17);
            this.btnSocorro.TabIndex = 5;
            this.btnSocorro.TabStop = true;
            this.btnSocorro.Text = "Socorro";
            this.btnSocorro.UseVisualStyleBackColor = true;
            // 
            // btnLindoia
            // 
            this.btnLindoia.AutoSize = true;
            this.btnLindoia.Location = new System.Drawing.Point(7, 68);
            this.btnLindoia.Name = "btnLindoia";
            this.btnLindoia.Size = new System.Drawing.Size(59, 17);
            this.btnLindoia.TabIndex = 4;
            this.btnLindoia.TabStop = true;
            this.btnLindoia.Text = "Lindoia";
            this.btnLindoia.UseVisualStyleBackColor = true;
            // 
            // btnSerra
            // 
            this.btnSerra.AutoSize = true;
            this.btnSerra.Location = new System.Drawing.Point(7, 45);
            this.btnSerra.Name = "btnSerra";
            this.btnSerra.Size = new System.Drawing.Size(82, 17);
            this.btnSerra.TabIndex = 3;
            this.btnSerra.TabStop = true;
            this.btnSerra.Text = "Serra Negra";
            this.btnSerra.UseVisualStyleBackColor = true;
            // 
            // btnAmapro
            // 
            this.btnAmapro.AutoSize = true;
            this.btnAmapro.Location = new System.Drawing.Point(7, 22);
            this.btnAmapro.Name = "btnAmapro";
            this.btnAmapro.Size = new System.Drawing.Size(61, 17);
            this.btnAmapro.TabIndex = 2;
            this.btnAmapro.TabStop = true;
            this.btnAmapro.Text = "Amparo";
            this.btnAmapro.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkPraia);
            this.groupBox4.Controls.Add(this.chkThermas);
            this.groupBox4.Controls.Add(this.chkCircuito);
            this.groupBox4.Controls.Add(this.chkMontanha);
            this.groupBox4.Controls.Add(this.chkCampo);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 56);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LOCALIDADE";
            // 
            // chkPraia
            // 
            this.chkPraia.AutoSize = true;
            this.chkPraia.Location = new System.Drawing.Point(401, 22);
            this.chkPraia.Name = "chkPraia";
            this.chkPraia.Size = new System.Drawing.Size(58, 17);
            this.chkPraia.TabIndex = 4;
            this.chkPraia.Text = "PRAIA";
            this.chkPraia.UseVisualStyleBackColor = true;
            this.chkPraia.CheckedChanged += new System.EventHandler(this.chkPraia_CheckedChanged);
            // 
            // chkThermas
            // 
            this.chkThermas.AutoSize = true;
            this.chkThermas.Location = new System.Drawing.Point(316, 22);
            this.chkThermas.Name = "chkThermas";
            this.chkThermas.Size = new System.Drawing.Size(79, 17);
            this.chkThermas.TabIndex = 3;
            this.chkThermas.Text = "THERMAS";
            this.chkThermas.UseVisualStyleBackColor = true;
            this.chkThermas.CheckedChanged += new System.EventHandler(this.chkThermas_CheckedChanged);
            // 
            // chkCircuito
            // 
            this.chkCircuito.AutoSize = true;
            this.chkCircuito.Location = new System.Drawing.Point(193, 22);
            this.chkCircuito.Name = "chkCircuito";
            this.chkCircuito.Size = new System.Drawing.Size(117, 17);
            this.chkCircuito.TabIndex = 2;
            this.chkCircuito.Text = "CIRCUITO AGUAS";
            this.chkCircuito.UseVisualStyleBackColor = true;
            this.chkCircuito.CheckedChanged += new System.EventHandler(this.chkCircuito_CheckedChanged);
            // 
            // chkMontanha
            // 
            this.chkMontanha.AutoSize = true;
            this.chkMontanha.Location = new System.Drawing.Point(89, 22);
            this.chkMontanha.Name = "chkMontanha";
            this.chkMontanha.Size = new System.Drawing.Size(88, 17);
            this.chkMontanha.TabIndex = 1;
            this.chkMontanha.Text = "MONTANHA";
            this.chkMontanha.UseVisualStyleBackColor = true;
            this.chkMontanha.CheckedChanged += new System.EventHandler(this.chkMontanha_CheckedChanged);
            // 
            // chkCampo
            // 
            this.chkCampo.AutoSize = true;
            this.chkCampo.Location = new System.Drawing.Point(3, 22);
            this.chkCampo.Name = "chkCampo";
            this.chkCampo.Size = new System.Drawing.Size(64, 17);
            this.chkCampo.TabIndex = 0;
            this.chkCampo.Text = "CAMPO";
            this.chkCampo.UseVisualStyleBackColor = true;
            this.chkCampo.CheckedChanged += new System.EventHandler(this.chkCampo_CheckedChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Location = new System.Drawing.Point(3, 107);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(190, 53);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // pnlFuncoes
            // 
            this.pnlFuncoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFuncoes.Controls.Add(this.BtgLogin);
            this.pnlFuncoes.Controls.Add(this.btnReservar);
            this.pnlFuncoes.Controls.Add(this.btnlimpar);
            this.pnlFuncoes.Location = new System.Drawing.Point(484, 148);
            this.pnlFuncoes.Name = "pnlFuncoes";
            this.pnlFuncoes.Size = new System.Drawing.Size(200, 170);
            this.pnlFuncoes.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(486, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "USUARIO";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(484, 77);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(189, 26);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.Text = "Val090482";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(486, 57);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 13);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Text = "SENHA";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(484, 28);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(189, 26);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.Text = "30213588889";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 324);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlFuncoes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gpbThermas);
            this.Controls.Add(this.gpbMontanha);
            this.Controls.Add(this.gpbPraia);
            this.Controls.Add(this.gpbCircuito);
            this.Controls.Add(this.gpbCampo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCampo.ResumeLayout(false);
            this.gpbCampo.PerformLayout();
            this.gpbPraia.ResumeLayout(false);
            this.gpbPraia.PerformLayout();
            this.gpbThermas.ResumeLayout(false);
            this.gpbThermas.PerformLayout();
            this.gpbMontanha.ResumeLayout(false);
            this.gpbMontanha.PerformLayout();
            this.gpbCircuito.ResumeLayout(false);
            this.gpbCircuito.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtgLogin;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox gpbCampo;
        private System.Windows.Forms.RadioButton rbtAvare;
        private System.Windows.Forms.RadioButton rbtAreado;
        private System.Windows.Forms.GroupBox gpbPraia;
        private System.Windows.Forms.RadioButton btnMaresias;
        private System.Windows.Forms.RadioButton btnGuaruja;
        private System.Windows.Forms.RadioButton btnUbatuba;
        private System.Windows.Forms.RadioButton btnItanhaem;
        private System.Windows.Forms.RadioButton btnCaragua;
        private System.Windows.Forms.GroupBox gpbThermas;
        private System.Windows.Forms.RadioButton rbtIbira;
        private System.Windows.Forms.RadioButton rbtSaoPedro;
        private System.Windows.Forms.GroupBox gpbMontanha;
        private System.Windows.Forms.RadioButton btnMonte;
        private System.Windows.Forms.RadioButton btnAppenzell;
        private System.Windows.Forms.GroupBox gpbCircuito;
        private System.Windows.Forms.RadioButton btnSocorro;
        private System.Windows.Forms.RadioButton btnLindoia;
        private System.Windows.Forms.RadioButton btnSerra;
        private System.Windows.Forms.RadioButton btnAmapro;
        private System.Windows.Forms.RadioButton btnPocos;
        private System.Windows.Forms.RadioButton btnCampos;
        private System.Windows.Forms.RadioButton btnSaha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkPraia;
        private System.Windows.Forms.CheckBox chkThermas;
        private System.Windows.Forms.CheckBox chkCircuito;
        private System.Windows.Forms.CheckBox chkMontanha;
        private System.Windows.Forms.CheckBox chkCampo;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Panel pnlFuncoes;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

