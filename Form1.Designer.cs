namespace INTERFACE_DE_APRENDIZADO
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button Andar_3;
        private System.Windows.Forms.Button Andar_2;
        private System.Windows.Forms.Button Andar_1;
        private System.Windows.Forms.Button Andar_0;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.ListBox Fila_De_Andares;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox Combo_Ports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Andar_3 = new System.Windows.Forms.Button();
            this.Andar_2 = new System.Windows.Forms.Button();
            this.Andar_1 = new System.Windows.Forms.Button();
            this.Andar_0 = new System.Windows.Forms.Button();
            this.Conectar = new System.Windows.Forms.Button();
            this.Fila_De_Andares = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Combo_Ports = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.painelAndares = new System.Windows.Forms.FlowLayoutPanel();
            this.painelConexao = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPort = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.painelAndares.SuspendLayout();
            this.painelConexao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Andar_3
            // 
            this.Andar_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.Andar_3.FlatAppearance.BorderSize = 0;
            this.Andar_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Andar_3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Andar_3.ForeColor = System.Drawing.Color.White;
            this.Andar_3.Location = new System.Drawing.Point(16, 208);
            this.Andar_3.Margin = new System.Windows.Forms.Padding(8);
            this.Andar_3.Name = "Andar_3";
            this.Andar_3.Size = new System.Drawing.Size(240, 48);
            this.Andar_3.TabIndex = 3;
            this.Andar_3.Text = "3º Andar";
            this.Andar_3.UseVisualStyleBackColor = false;
            this.Andar_3.Click += new System.EventHandler(this.Andar_3_Click);
            // 
            // Andar_2
            // 
            this.Andar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.Andar_2.FlatAppearance.BorderSize = 0;
            this.Andar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Andar_2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Andar_2.ForeColor = System.Drawing.Color.White;
            this.Andar_2.Location = new System.Drawing.Point(16, 144);
            this.Andar_2.Margin = new System.Windows.Forms.Padding(8);
            this.Andar_2.Name = "Andar_2";
            this.Andar_2.Size = new System.Drawing.Size(240, 48);
            this.Andar_2.TabIndex = 2;
            this.Andar_2.Text = "2º Andar";
            this.Andar_2.UseVisualStyleBackColor = false;
            this.Andar_2.Click += new System.EventHandler(this.Andar_2_Click);
            // 
            // Andar_1
            // 
            this.Andar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.Andar_1.FlatAppearance.BorderSize = 0;
            this.Andar_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Andar_1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Andar_1.ForeColor = System.Drawing.Color.White;
            this.Andar_1.Location = new System.Drawing.Point(16, 80);
            this.Andar_1.Margin = new System.Windows.Forms.Padding(8);
            this.Andar_1.Name = "Andar_1";
            this.Andar_1.Size = new System.Drawing.Size(240, 48);
            this.Andar_1.TabIndex = 1;
            this.Andar_1.Text = "1º Andar";
            this.Andar_1.UseVisualStyleBackColor = false;
            this.Andar_1.Click += new System.EventHandler(this.Andar_1_Click);
            // 
            // Andar_0
            // 
            this.Andar_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.Andar_0.FlatAppearance.BorderSize = 0;
            this.Andar_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Andar_0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Andar_0.ForeColor = System.Drawing.Color.White;
            this.Andar_0.Location = new System.Drawing.Point(16, 16);
            this.Andar_0.Margin = new System.Windows.Forms.Padding(8);
            this.Andar_0.Name = "Andar_0";
            this.Andar_0.Size = new System.Drawing.Size(240, 48);
            this.Andar_0.TabIndex = 0;
            this.Andar_0.Text = "Térreo (0)";
            this.Andar_0.UseVisualStyleBackColor = false;
            this.Andar_0.Click += new System.EventHandler(this.Andar_0_Click);
            // 
            // Conectar
            // 
            this.Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Conectar.FlatAppearance.BorderSize = 0;
            this.Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conectar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Conectar.ForeColor = System.Drawing.Color.White;
            this.Conectar.Location = new System.Drawing.Point(16, 106);
            this.Conectar.Margin = new System.Windows.Forms.Padding(8);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(180, 42);
            this.Conectar.TabIndex = 2;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = false;
            this.Conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // Fila_De_Andares
            // 
            this.Fila_De_Andares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fila_De_Andares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fila_De_Andares.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Fila_De_Andares.ItemHeight = 23;
            this.Fila_De_Andares.Location = new System.Drawing.Point(12, 37);
            this.Fila_De_Andares.Name = "Fila_De_Andares";
            this.Fila_De_Andares.Size = new System.Drawing.Size(271, 421);
            this.Fila_De_Andares.TabIndex = 0;
            // 
            // Combo_Ports
            // 
            this.Combo_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Ports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo_Ports.Location = new System.Drawing.Point(16, 59);
            this.Combo_Ports.Margin = new System.Windows.Forms.Padding(8);
            this.Combo_Ports.Name = "Combo_Ports";
            this.Combo_Ports.Size = new System.Drawing.Size(180, 31);
            this.Combo_Ports.TabIndex = 1;
            this.Combo_Ports.SelectedIndexChanged += new System.EventHandler(this.Combo_Ports_Selecionar_Porta_Serial);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.painelAndares);
            this.groupBox1.Controls.Add(this.painelConexao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox1.Size = new System.Drawing.Size(295, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controle de Andares";
            // 
            // painelAndares
            // 
            this.painelAndares.AutoScroll = true;
            this.painelAndares.Controls.Add(this.Andar_0);
            this.painelAndares.Controls.Add(this.Andar_1);
            this.painelAndares.Controls.Add(this.Andar_2);
            this.painelAndares.Controls.Add(this.Andar_3);
            this.painelAndares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelAndares.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.painelAndares.Location = new System.Drawing.Point(12, 201);
            this.painelAndares.Name = "painelAndares";
            this.painelAndares.Padding = new System.Windows.Forms.Padding(8);
            this.painelAndares.Size = new System.Drawing.Size(271, 257);
            this.painelAndares.TabIndex = 0;
            this.painelAndares.WrapContents = false;
            // 
            // painelConexao
            // 
            this.painelConexao.AutoSize = true;
            this.painelConexao.Controls.Add(this.lblPort);
            this.painelConexao.Controls.Add(this.Combo_Ports);
            this.painelConexao.Controls.Add(this.Conectar);
            this.painelConexao.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelConexao.Location = new System.Drawing.Point(12, 37);
            this.painelConexao.Name = "painelConexao";
            this.painelConexao.Padding = new System.Windows.Forms.Padding(8);
            this.painelConexao.Size = new System.Drawing.Size(271, 164);
            this.painelConexao.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPort.Location = new System.Drawing.Point(16, 20);
            this.lblPort.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(100, 23);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Porta Serial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Fila_De_Andares);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(316, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox2.Size = new System.Drawing.Size(295, 470);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fila de Andares Recebida";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(626, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Interface de Controle de Elevador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.painelAndares.ResumeLayout(false);
            this.painelConexao.ResumeLayout(false);
            this.painelConexao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.FlowLayoutPanel painelAndares;
        private System.Windows.Forms.FlowLayoutPanel painelConexao;
        private System.Windows.Forms.Label lblPort;
    }
}
