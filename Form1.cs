using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pico_placa
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ToolTip errorToolTip;
        private string lastValidText = string.Empty;
        private const string DateFormat = "dd/MM/yyyy";
        public Form1()
        {
            InitializeComponent();
            errorToolTip = new System.Windows.Forms.ToolTip();
            // Agrega las opciones al ComboBox
            cmbxmodo.Items.Add("Manual");
            cmbxmodo.Items.Add("Automático");

            // Selecciona una opción por defecto
            cmbxmodo.SelectedIndex = 0;
            pctnopase.Visible = false;
            pctpase.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string respuesta = "si";
            TimeSpan tiempoInicioManana = new TimeSpan(6, 0, 0); // 06:00 AM
            TimeSpan tiempoFinManana = new TimeSpan(9, 30, 0); // 09:30 AM
            TimeSpan tiempoInicioTarde = new TimeSpan(16, 0, 0); // 04:00 PM
            TimeSpan tiempoFinTarde = new TimeSpan(20, 0, 0); // 08:00 PM
            string placa = txt_placa.Text.ToUpper(); // Convertir a mayúsculas para asegurar consistencia
            string fechaTexto = txtfecha.Text.Trim();
            string horaTexto = maskedTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(fechaTexto) || string.IsNullOrEmpty(horaTexto))
            {
                MessageBox.Show("Faltan Parámetros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int lastDigit = int.Parse(placa.Substring(placa.Length - 1)); // Última cifra de la placa

                DateTime fecha = DateTime.ParseExact(fechaTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DayOfWeek diaSemana = fecha.DayOfWeek;

                TimeSpan hora = DateTime.ParseExact(horaTexto, "HH:mm", CultureInfo.InvariantCulture).TimeOfDay;

                string resultado = "Tiene libre circulación."; // Mensaje por defecto
                pctnopase.Visible = false;
                pctpase.Visible = true;
                switch (diaSemana)
                {
                    case DayOfWeek.Monday:
                        if ((lastDigit == 1 || lastDigit == 2) && ((hora >= tiempoInicioManana && hora <= tiempoFinManana) || (hora >= tiempoInicioTarde && hora <= tiempoFinTarde)))
                            resultado = "No puede circular  se encuentra durante del horario restringido.";
                        respuesta = "no";
                        pctnopase.Visible = true;
                        pctpase.Visible = false;
                        break;
                    case DayOfWeek.Tuesday:
                        if ((lastDigit == 3 || lastDigit == 4) && ((hora >= tiempoInicioManana && hora <= tiempoFinManana) || (hora >= tiempoInicioTarde && hora <= tiempoFinTarde)))
                            resultado = "No puede circular  se encuentra durante del horario restringido";
                        respuesta = "no";
                        pctnopase.Visible = true;
                        pctpase.Visible = false;
                        break;
                    case DayOfWeek.Wednesday:
                        if ((lastDigit == 5 || lastDigit == 6) && ((hora >= tiempoInicioManana && hora <= tiempoFinManana) || (hora >= tiempoInicioTarde && hora <= tiempoFinTarde)))
                            resultado = "No puede circular  se encuentra durante del horario restringido";
                        respuesta = "no";
                        pctnopase.Visible = true;
                        pctpase.Visible = false;
                        break;
                    case DayOfWeek.Thursday:
                        if ((lastDigit == 7 || lastDigit == 8) && ((hora >= tiempoInicioManana && hora <= tiempoFinManana) || (hora >= tiempoInicioTarde && hora <= tiempoFinTarde)))
                            resultado = "No puede circular  se encuentra durante del horario restringido";
                        respuesta = "no";
                        pctnopase.Visible = true;
                        pctpase.Visible = false;
                        break;
                    case DayOfWeek.Friday:
                        if ((lastDigit == 9 || lastDigit == 0) && ((hora >= tiempoInicioManana && hora <= tiempoFinManana) || (hora >= tiempoInicioTarde && hora <= tiempoFinTarde)))
                            resultado = "No puede circular  se encuentra durante del horario restringido";
                        respuesta = "no";
                        pctnopase.Visible = true;
                        pctpase.Visible = false;
                        break;
                    case DayOfWeek.Sunday:
                        resultado = "Fin de Semana libre circulación.";
                        pctnopase.Visible = false;
                        pctpase.Visible = true;
                        break;
                    default:
                        pctnopase.Visible = false;
                        pctpase.Visible = true;
                        break;
                }

                lbl_resultado.Text = resultado;
                if (resultado == "Tiene libre circulación.")
                {
                    pctnopase.Visible = false;
                    pctpase.Visible = true;
                    respuesta = "si";
                }
                placa Placa = new placa();
                Placa.Placa_Auto = txt_placa.Text;
                Placa.fecha = txtfecha.Text;
                Placa.hora = maskedTextBox1.Text;
                Placa.respuesta = respuesta;

                int resul = placaDAL.agregar(Placa);
                if (resul > 0)
                {
                    MessageBox.Show("Datos Guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudieron guardar los datos correctamente", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void tmrhora_Tick(object sender, EventArgs e)
        {
            lblreloj.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void calendario_DockChanged(object sender, EventArgs e)
        {

        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (cmbxmodo.Text == "Manual")
            {
                txtfecha.Text = calendario.SelectionStart.ToString("dd/MM/yyyy");
            }

        }

        private void lbxmanualautomatico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxmanualautomatico_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void cmbxmodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbxmodo.SelectedItem.ToString();

            if (opcionSeleccionada == "Manual")
            {
                calendario.Enabled = true;
                maskedTextBox1.Enabled = true;
                calendario.Visible = true;

                txtfecha.Enabled = false;

            }
            else if (opcionSeleccionada == "Automático")
            {
                calendario.Enabled = false;
                maskedTextBox1.Enabled = false;
                txtfecha.Enabled = false;
                txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                maskedTextBox1.Text = DateTime.Now.ToString("HH:mm");
                calendario.Visible = false;

            }
        }

        private void txt_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                errorToolTip.Show("Solo se permiten letras y números.", txt_placa, 0, -20, 2000);
                return;
            }

            string currentText = txt_placa.Text;

            if (currentText.Length < 3 && char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (currentText.Length == 3 && (char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
            }
            else if (currentText.Length > 3 && currentText.Length < 8 && char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorToolTip.Show("Formato de placa inválido.", txt_placa, 0, -20, 2000);
            }

            if (txt_placa.Text.Length >= 7 && e.KeyChar != '\b')
            {
                e.Handled = true;

                errorToolTip.Show("Máximo 7 caracteres.", txt_placa, 0, -20, 2000);
                return;
            }
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            // Evitar que se ingresen más "/" después de los primeros dos caracteres o los primeros cinco caracteres
            if (e.KeyChar == '/' && (txtfecha.Text.Length == 2 || txtfecha.Text.Length == 5))
            {
                e.Handled = true;
                return;
            }

            // Permitir solo dos dígitos para el día
            if (char.IsDigit(e.KeyChar) && txtfecha.Text.Length < 10)
            {
                if (txtfecha.Text.Length == 2 || txtfecha.Text.Length == 5)
                {
                    txtfecha.Text += "/";
                    txtfecha.SelectionStart = txtfecha.Text.Length;
                }
            }

            // Validar la fecha ingresada
            if (txtfecha.Text.Length == 10)
            {
                if (!DateTime.TryParseExact(txtfecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    // Mostrar un mensaje de error si la fecha no es válida
                    MessageBox.Show("La fecha ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfecha.Text = ""; // Limpiar el campo de fecha
                }
            }
            if (txtfecha.Text.Length == 10)
            {
                if (!DateTime.TryParseExact(txtfecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    // Mostrar un mensaje de error si la fecha no es válida
                    MessageBox.Show("La fecha ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfecha.Text = ""; // Limpiar el campo de fecha
                }
            }
        }

        private void txthora_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txthora_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el carácter no es un dígito ni un carácter de control (backspace), ignorarlo
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
                return;
            }

            // Evitar que se ingresen más de cinco caracteres en total (hh:mm)
            if (maskedTextBox1.Text.Length >= 5 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Si se intenta ingresar ":" después de la segunda posición o después de ":" existente
            if (e.KeyChar == ':' && (maskedTextBox1.Text.Length == 2 || maskedTextBox1.Text.Length == 3))
            {
                if (maskedTextBox1.Text.Length == 3 && maskedTextBox1.Text[2] == ':')
                {
                    e.Handled = true;
                    return;
                }
                if (maskedTextBox1.SelectionStart == 2)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length > 0)
            {
                // Validar el rango de horas (00:00 a 23:59) y agregar ":" automáticamente
                if (maskedTextBox1.Text.Length > 5)
                {
                    maskedTextBox1.Text = maskedTextBox1.Text.Substring(0, 5);
                }
                else if (maskedTextBox1.Text.Length == 2 && !maskedTextBox1.Text.Contains(":"))
                {
                    maskedTextBox1.Text = maskedTextBox1.Text + ":";
                    maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
                }
                else if (maskedTextBox1.Text.Length == 5 && maskedTextBox1.Text.Contains(":"))
                {
                    string[] partesHora = maskedTextBox1.Text.Split(':');
                    if (partesHora.Length == 2)
                    {
                        if (!int.TryParse(partesHora[0], out int horas) || !int.TryParse(partesHora[1], out int minutos) || horas < 0 || horas > 23 || minutos < 0 || minutos > 59)
                        {
                            MessageBox.Show("Hora fuera del rango válido (00:00 - 23:59).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            maskedTextBox1.Text = "";
                        }
                    }
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txt_placa.Text = "";
            maskedTextBox1.Text = "";
            lbl_resultado.Text = "Información.";
            pctnopase.Visible = false;
            pctpase.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}