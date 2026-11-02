using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PicoyPlaca
{
    public partial class AppConsulta : Form
    {
        public AppConsulta()
        {
            InitializeComponent();
            CargarRegistros();
        }

        private void AppConsulta_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        //LOGICA PARA VERIFICAR SI EL VEHICULO PUEDE O NO CIRCULAR

        private bool VerificarPicoYPlaca(string placa, DateTime fecha, int hora, int minutos)
        {
            int ultimoDigito = int.Parse(placa.Substring(placa.Length - 1));
            int diaSemana = (int)fecha.DayOfWeek;

            if (diaSemana == 0 || diaSemana == 6)
            {
                return true;
            }

            bool diaRestriccion = false;
            switch (diaSemana)
            {
                case 1: 
                    if (ultimoDigito == 1 || ultimoDigito == 2) diaRestriccion = true;
                    break;
                case 2: 
                    if (ultimoDigito == 3 || ultimoDigito == 4) diaRestriccion = true;
                    break;
                case 3: 
                    if (ultimoDigito == 5 || ultimoDigito == 6) diaRestriccion = true;
                    break;
                case 4: 
                    if (ultimoDigito == 7 || ultimoDigito == 8) diaRestriccion = true;
                    break;
                case 5: 
                    if (ultimoDigito == 9 || ultimoDigito == 0) diaRestriccion = true;
                    break;
            }

           
            bool enHorarioRestriccion = false;
          
            if (hora > 6 || (hora == 6 && minutos >= 0))
            {
                if (hora < 9 || (hora == 9 && minutos <= 30))
                {
                    enHorarioRestriccion = true;
                }
            }
           
            if (hora > 16 || (hora == 16 && minutos >= 0))
            {
                if (hora < 20 || (hora == 20 && minutos <= 0))
                {
                    enHorarioRestriccion = true;
                }
            }

            if (diaRestriccion && enHorarioRestriccion)
            {
                return false; 
            }

            return true;
        }

        //VERIFICA SI ES QUE LOS CAMPOS ESTAN COMPLETOS Y LLAMA AL METOFO PARA VERIFICAR SI EL VEHICULO PUEDE CIRCULAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;  
            DateTime fecha = dtpFecha.Value;  
            int hora = (int)nudHora.Value; 
            int minutos = (int)nudMinutos.Value; 

            
            if (string.IsNullOrWhiteSpace(placa))  
            {
                MessageBox.Show("Por favor, ingresa la placa del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            string placaPattern = @"^[A-Z]{3}-\d{4}$"; 
            if (!Regex.IsMatch(placa, placaPattern))
            {
                MessageBox.Show("La placa no tiene un formato válido. Debe ser 3 letras seguidas de un guion y 4 números (Ejemplo: ABC-1234).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hora == 0) 
            {
                MessageBox.Show("Por favor, selecciona una hora válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            if (fecha == DateTime.MinValue)  
            {
                MessageBox.Show("Por favor, selecciona una fecha válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            bool resultado = VerificarPicoYPlaca(placa, fecha, hora, minutos);

           
            MessageBox.Show(
                resultado ? "El vehículo puede circular." : "El vehículo NO puede circular.",
                "Resultado de la consulta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            
            GuardarResultado(placa, fecha, hora, minutos, resultado);

            
            CargarRegistros();
        }

        //GUARDA LOS DATOS DEL VEHICULO, LA FECHA, LA HORA Y SI PUEDE CIRCULAR O NO
        private void GuardarResultado(string placa, DateTime fecha, int hora, int minutos, bool resultado)
        {
            
            TimeSpan horaSpan = new TimeSpan(hora, minutos, 0);  

            string connectionString = ConfigurationManager.ConnectionStrings["PicoYPlacaDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO dbo.Prueba (Placa, Hora, Fecha, Resultado) VALUES (@Placa, @Hora, @Fecha, @Resultado)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Placa", placa);
                    cmd.Parameters.Add("@Hora", SqlDbType.Time).Value = horaSpan;  
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Resultado", resultado ? "Sí" : "No");

                    cmd.ExecuteNonQuery();
                }
            }
        }

       //LIMPIA LOS DATOS DEL FORMULARIO
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            txtPlaca.Clear();

            
            dtpFecha.Value = DateTime.Now;

           
            nudHora.Value = 0;

            
            nudMinutos.Value = 0;

           
            lblResultado.Text = "";
        }

        //CARGA LOS DATOS EN EL DATAGRID
        private void CargarRegistros()
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["PicoYPlacaDB"].ConnectionString;

           
            string query = "SELECT Placa, Hora, Fecha, Resultado FROM dbo.Prueba";

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); 

               
                dataGridConsulta.DataSource = dataTable;
            }
        }


    }
}