namespace pico_placa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_consultar = new Button();
            txt_placa = new TextBox();
            lblreloj = new Label();
            tmrhora = new System.Windows.Forms.Timer(components);
            lblhora = new Label();
            label1 = new Label();
            calendario = new MonthCalendar();
            label2 = new Label();
            txtfecha = new TextBox();
            btnlimpiar = new Button();
            cmbxmodo = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_resultado = new Label();
            label4 = new Label();
            pctnopase = new PictureBox();
            pctpase = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctnopase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctpase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ButtonHighlight;
            btn_consultar.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_consultar.Location = new Point(326, 249);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(100, 40);
            btn_consultar.TabIndex = 0;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // txt_placa
            // 
            txt_placa.Location = new Point(98, 104);
            txt_placa.Name = "txt_placa";
            txt_placa.Size = new Size(198, 27);
            txt_placa.TabIndex = 1;
            txt_placa.KeyPress += txt_placa_KeyPress;
            // 
            // lblreloj
            // 
            lblreloj.BackColor = SystemColors.ButtonHighlight;
            lblreloj.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblreloj.Location = new Point(609, 3);
            lblreloj.Name = "lblreloj";
            lblreloj.Size = new Size(179, 28);
            lblreloj.TabIndex = 4;
            // 
            // tmrhora
            // 
            tmrhora.Enabled = true;
            tmrhora.Tick += tmrhora_Tick;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.BackColor = SystemColors.ButtonHighlight;
            lblhora.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblhora.Location = new Point(13, 140);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(49, 19);
            lblhora.TabIndex = 5;
            lblhora.Text = "Hora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 6;
            label1.Text = "Fecha";
            // 
            // calendario
            // 
            calendario.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calendario.Location = new Point(6, 199);
            calendario.Name = "calendario";
            calendario.SelectionRange = new SelectionRange(new DateTime(2023, 8, 1, 0, 0, 0, 0), new DateTime(2023, 8, 7, 0, 0, 0, 0));
            calendario.TabIndex = 7;
            calendario.DateSelected += calendario_DateSelected;
            calendario.DockChanged += calendario_DockChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 9;
            label2.Text = "Placa";
            // 
            // txtfecha
            // 
            txtfecha.Enabled = false;
            txtfecha.Location = new Point(98, 160);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(198, 27);
            txtfecha.TabIndex = 11;
            txtfecha.TextChanged += txthora_TextChanged;
            txtfecha.KeyPress += txtfecha_KeyPress;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = SystemColors.ButtonHighlight;
            btnlimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnlimpiar.FlatAppearance.BorderSize = 0;
            btnlimpiar.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiar.Location = new Point(326, 295);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(100, 40);
            btnlimpiar.TabIndex = 13;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // cmbxmodo
            // 
            cmbxmodo.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbxmodo.FormattingEnabled = true;
            cmbxmodo.Location = new Point(451, 132);
            cmbxmodo.Name = "cmbxmodo";
            cmbxmodo.Size = new Size(150, 27);
            cmbxmodo.TabIndex = 14;
            cmbxmodo.SelectedIndexChanged += cmbxmodo_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(98, 132);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(198, 27);
            maskedTextBox1.TabIndex = 16;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            maskedTextBox1.KeyPress += maskedTextBox1_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-5, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(860, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = Properties.Resources.MARDIS_PRINCIPAL;
            pictureBox2.Location = new Point(6, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // lbl_resultado
            // 
            lbl_resultado.BackColor = SystemColors.ButtonHighlight;
            lbl_resultado.BorderStyle = BorderStyle.FixedSingle;
            lbl_resultado.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_resultado.Location = new Point(326, 168);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(275, 69);
            lbl_resultado.TabIndex = 8;
            lbl_resultado.Text = "Información.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(326, 136);
            label4.Name = "label4";
            label4.Size = new Size(119, 19);
            label4.TabIndex = 20;
            label4.Text = "Modo de Uso";
            // 
            // pctnopase
            // 
            pctnopase.Image = (Image)resources.GetObject("pctnopase.Image");
            pctnopase.Location = new Point(605, 168);
            pctnopase.Name = "pctnopase";
            pctnopase.Size = new Size(58, 54);
            pctnopase.SizeMode = PictureBoxSizeMode.StretchImage;
            pctnopase.TabIndex = 21;
            pctnopase.TabStop = false;
            // 
            // pctpase
            // 
            pctpase.Image = (Image)resources.GetObject("pctpase.Image");
            pctpase.Location = new Point(605, 168);
            pctpase.Name = "pctpase";
            pctpase.Size = new Size(58, 54);
            pctpase.SizeMode = PictureBoxSizeMode.StretchImage;
            pctpase.TabIndex = 22;
            pctpase.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(244, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(323, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pctpase);
            Controls.Add(pctnopase);
            Controls.Add(label4);
            Controls.Add(lbl_resultado);
            Controls.Add(pictureBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(cmbxmodo);
            Controls.Add(btnlimpiar);
            Controls.Add(txtfecha);
            Controls.Add(label2);
            Controls.Add(calendario);
            Controls.Add(label1);
            Controls.Add(lblhora);
            Controls.Add(lblreloj);
            Controls.Add(txt_placa);
            Controls.Add(btn_consultar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Pico y Placa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctnopase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctpase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_consultar;
        private TextBox txt_placa;
        private Label lblreloj;
        private System.Windows.Forms.Timer tmrhora;
        private Label lblhora;
        private Label label1;
        private MonthCalendar calendario;
        private Label label2;
        private TextBox txtfecha;
        private Button btnlimpiar;
        private ComboBox cmbxmodo;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_resultado;
        private Label label4;
        private PictureBox pctnopase;
        private PictureBox pctpase;
        private PictureBox pictureBox3;
    }
}