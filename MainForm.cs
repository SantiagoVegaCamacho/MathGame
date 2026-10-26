namespace MathGame;

public partial class MainForm : Form
{
    Juego juego = new Juego();

    public MainForm()
    {
        InitializeComponent();
        AcceptButton = btnJugar;
    }

    
    void Mostrar(Panel p)
    {
        pnlInicio.Visible = (p == pnlInicio);
        pnlJuego.Visible = (p == pnlJuego);
        pnlResultados.Visible = (p == pnlResultados);

        if (p == pnlInicio) AcceptButton = btnJugar;
        if (p == pnlJuego) AcceptButton = btnResponder;
        if (p == pnlResultados) AcceptButton = btnMenu;
    }

    
    void ActualizarJuego()
    {
        int t = juego.Turno;
        lblTurno.Text = "Turno de: " + juego.Nombres[t];
        lblInfo.Text = "Nivel " + juego.Nivel + "  |  Vidas: " + juego.Vidas[t] + "  |  Puntos: " + juego.Puntos[t];
        lblProblema.Text = juego.Pregunta;
        txtRespuesta.Clear();
        txtRespuesta.Focus();
    }

    void MostrarRanking()
    {
        lstRanking.Items.Clear();
        string[] lineas = juego.TextoRanking();
        if (lineas.Length == 0)
            lstRanking.Items.Add("(sin partidas todavía)");
        for (int i = 0; i < lineas.Length; i++)
            lstRanking.Items.Add(lineas[i]);
    }

    
    private void rbDos_CheckedChanged(object sender, EventArgs e)
    {
        txtJ2.Enabled = rbDos.Checked;
    }

    private void btnJugar_Click(object sender, EventArgs e)
    {
        string n1 = txtJ1.Text.Trim();
        string n2 = txtJ2.Text.Trim();
        int cantidad = rbDos.Checked ? 2 : 1;

        if (n1 == "" || (cantidad == 2 && n2 == ""))
        {
            lblErrorInicio.Text = "Escribe el nombre de cada jugador.";
            return;
        }
        if (cantidad == 2 && n1.ToLower() == n2.ToLower())
        {
            lblErrorInicio.Text = "Los nombres deben ser distintos.";
            return;
        }

        lblErrorInicio.Text = "";
        lblFeedback.Text = "";
        juego.Iniciar(n1, n2, cantidad);
        ActualizarJuego();
        Mostrar(pnlJuego);
    }

    private void btnVerRanking_Click(object sender, EventArgs e)
    {
        lblGanador.Text = "Clasificación de la sesión";
        MostrarRanking();
        Mostrar(pnlResultados);
    }

    private void btnResponder_Click(object sender, EventArgs e)
    {
        int r = juego.Responder(txtRespuesta.Text);

        if (r == 0)
        {
            lblFeedback.ForeColor = Color.DarkOrange;
            lblFeedback.Text = "Escribe un número entero.";
            txtRespuesta.SelectAll();
            txtRespuesta.Focus();
            return;
        }

        if (r == 1)
        {
            lblFeedback.ForeColor = Color.SeaGreen;
            lblFeedback.Text = juego.SubioNivel ? "¡Correcto! ¡Subiste de nivel!" : "¡Correcto!";
        }
        else
        {
            lblFeedback.ForeColor = Color.Firebrick;
            lblFeedback.Text = "Incorrecto.";
        }

        if (juego.Terminada())
        {
            juego.GuardarEnRanking();

            if (juego.Jugadores == 1)
                lblGanador.Text = "Fin: " + juego.Puntos[0] + " puntos (tu mejor: " + juego.MejorPuntaje(juego.Nombres[0]) + ")";
            else if (juego.Ganador() == -1)
                lblGanador.Text = "¡Empate!";
            else
                lblGanador.Text = "¡Gana " + juego.Nombres[juego.Ganador()] + "!";

            MostrarRanking();
            Mostrar(pnlResultados);
        }
        else
        {
            ActualizarJuego();
        }
    }

    private void btnMenu_Click(object sender, EventArgs e)
    {
        Mostrar(pnlInicio);
    }
}
