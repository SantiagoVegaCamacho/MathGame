namespace MathGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlInicio = new Panel();
            lblTitulo = new Label();
            rbIndividual = new RadioButton();
            rbDos = new RadioButton();
            txtJ1 = new TextBox();
            txtJ2 = new TextBox();
            lblErrorInicio = new Label();
            btnJugar = new Button();
            btnVerRanking = new Button();
            pnlJuego = new Panel();
            lblTurno = new Label();
            lblInfo = new Label();
            lblProblema = new Label();
            txtRespuesta = new TextBox();
            btnResponder = new Button();
            lblFeedback = new Label();
            pnlResultados = new Panel();
            lblGanador = new Label();
            lstRanking = new ListBox();
            btnMenu = new Button();
            pnlInicio.SuspendLayout();
            pnlJuego.SuspendLayout();
            pnlResultados.SuspendLayout();
            SuspendLayout();
            //
            // pnlInicio
            //
            pnlInicio.Controls.Add(lblTitulo);
            pnlInicio.Controls.Add(rbIndividual);
            pnlInicio.Controls.Add(rbDos);
            pnlInicio.Controls.Add(txtJ1);
            pnlInicio.Controls.Add(txtJ2);
            pnlInicio.Controls.Add(lblErrorInicio);
            pnlInicio.Controls.Add(btnJugar);
            pnlInicio.Controls.Add(btnVerRanking);
            pnlInicio.Dock = DockStyle.Fill;
            pnlInicio.Location = new Point(0, 0);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(400, 330);
            pnlInicio.TabIndex = 0;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(40, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reto Matemático";
            //
            // rbIndividual
            //
            rbIndividual.AutoSize = true;
            rbIndividual.Checked = true;
            rbIndividual.Location = new Point(40, 70);
            rbIndividual.Name = "rbIndividual";
            rbIndividual.Size = new Size(80, 19);
            rbIndividual.TabIndex = 1;
            rbIndividual.TabStop = true;
            rbIndividual.Text = "Individual";
            //
            // rbDos
            //
            rbDos.AutoSize = true;
            rbDos.Location = new Point(180, 70);
            rbDos.Name = "rbDos";
            rbDos.Size = new Size(105, 19);
            rbDos.TabIndex = 2;
            rbDos.Text = "Dos jugadores";
            rbDos.CheckedChanged += rbDos_CheckedChanged;
            //
            // txtJ1
            //
            txtJ1.Location = new Point(40, 125);
            txtJ1.Name = "txtJ1";
            txtJ1.PlaceholderText = "Jugador 1";
            txtJ1.Size = new Size(220, 23);
            txtJ1.TabIndex = 3;
            //
            // txtJ2
            //
            txtJ2.Enabled = false;
            txtJ2.Location = new Point(40, 160);
            txtJ2.Name = "txtJ2";
            txtJ2.PlaceholderText = "Jugador 2";
            txtJ2.Size = new Size(220, 23);
            txtJ2.TabIndex = 4;
            //
            // lblErrorInicio
            //
            lblErrorInicio.AutoSize = true;
            lblErrorInicio.ForeColor = Color.Firebrick;
            lblErrorInicio.Location = new Point(40, 195);
            lblErrorInicio.Name = "lblErrorInicio";
            lblErrorInicio.Size = new Size(0, 15);
            lblErrorInicio.TabIndex = 5;
            //
            // btnJugar
            //
            btnJugar.Location = new Point(40, 230);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(100, 34);
            btnJugar.TabIndex = 6;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            //
            // btnVerRanking
            //
            btnVerRanking.Location = new Point(150, 230);
            btnVerRanking.Name = "btnVerRanking";
            btnVerRanking.Size = new Size(110, 34);
            btnVerRanking.TabIndex = 7;
            btnVerRanking.Text = "Ver ranking";
            btnVerRanking.UseVisualStyleBackColor = true;
            btnVerRanking.Click += btnVerRanking_Click;
            //
            // pnlJuego
            //
            pnlJuego.Controls.Add(lblTurno);
            pnlJuego.Controls.Add(lblInfo);
            pnlJuego.Controls.Add(lblProblema);
            pnlJuego.Controls.Add(txtRespuesta);
            pnlJuego.Controls.Add(btnResponder);
            pnlJuego.Controls.Add(lblFeedback);
            pnlJuego.Dock = DockStyle.Fill;
            pnlJuego.Location = new Point(0, 0);
            pnlJuego.Name = "pnlJuego";
            pnlJuego.Size = new Size(400, 330);
            pnlJuego.TabIndex = 1;
            pnlJuego.Visible = false;
            //
            // lblTurno
            //
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurno.Location = new Point(30, 20);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(100, 25);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno de:";
            //
            // lblInfo
            //
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(30, 55);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(30, 15);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Info";
            //
            // lblProblema
            //
            lblProblema.AutoSize = true;
            lblProblema.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblProblema.Location = new Point(30, 100);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(200, 51);
            lblProblema.TabIndex = 2;
            lblProblema.Text = "1 + 1 = ?";
            //
            // txtRespuesta
            //
            txtRespuesta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtRespuesta.Location = new Point(30, 180);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(160, 32);
            txtRespuesta.TabIndex = 3;
            //
            // btnResponder
            //
            btnResponder.Location = new Point(200, 178);
            btnResponder.Name = "btnResponder";
            btnResponder.Size = new Size(100, 34);
            btnResponder.TabIndex = 4;
            btnResponder.Text = "Responder";
            btnResponder.UseVisualStyleBackColor = true;
            btnResponder.Click += btnResponder_Click;
            //
            // lblFeedback
            //
            lblFeedback.AutoSize = true;
            lblFeedback.Location = new Point(30, 230);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(0, 15);
            lblFeedback.TabIndex = 5;
            //
            // pnlResultados
            //
            pnlResultados.Controls.Add(lblGanador);
            pnlResultados.Controls.Add(lstRanking);
            pnlResultados.Controls.Add(btnMenu);
            pnlResultados.Dock = DockStyle.Fill;
            pnlResultados.Location = new Point(0, 0);
            pnlResultados.Name = "pnlResultados";
            pnlResultados.Size = new Size(400, 330);
            pnlResultados.TabIndex = 2;
            pnlResultados.Visible = false;
            //
            // lblGanador
            //
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanador.Location = new Point(30, 20);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(100, 25);
            lblGanador.TabIndex = 0;
            lblGanador.Text = "Resultado";
            //
            // lstRanking
            //
            lstRanking.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstRanking.FormattingEnabled = true;
            lstRanking.ItemHeight = 15;
            lstRanking.Location = new Point(30, 70);
            lstRanking.Name = "lstRanking";
            lstRanking.Size = new Size(320, 169);
            lstRanking.TabIndex = 1;
            //
            // btnMenu
            //
            btnMenu.Location = new Point(30, 265);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(130, 34);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Volver al menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 330);
            Controls.Add(pnlInicio);
            Controls.Add(pnlJuego);
            Controls.Add(pnlResultados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reto Matemático";
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            pnlJuego.ResumeLayout(false);
            pnlJuego.PerformLayout();
            pnlResultados.ResumeLayout(false);
            pnlResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInicio;
        private Label lblTitulo;
        private RadioButton rbIndividual;
        private RadioButton rbDos;
        private TextBox txtJ1;
        private TextBox txtJ2;
        private Label lblErrorInicio;
        private Button btnJugar;
        private Button btnVerRanking;
        private Panel pnlJuego;
        private Label lblTurno;
        private Label lblInfo;
        private Label lblProblema;
        private TextBox txtRespuesta;
        private Button btnResponder;
        private Label lblFeedback;
        private Panel pnlResultados;
        private Label lblGanador;
        private ListBox lstRanking;
        private Button btnMenu;
    }
}
