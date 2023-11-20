using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Restaurante
{
    public partial class Evaluacion : Form
    {
        string atencion, comida, precio;

        public Evaluacion()
        {
            InitializeComponent();
        }

        private void rbAtencion1_CheckedChanged(object sender, EventArgs e)
        {
            atencion = "Muy mala";
        }

        private void rbAtencion2_CheckedChanged(object sender, EventArgs e)
        {
            atencion = "Mala";
        }

        private void rbAtencion3_CheckedChanged(object sender, EventArgs e)
        {
            atencion = "Normal";
        }

        private void rbAtencion4_CheckedChanged(object sender, EventArgs e)
        {
            atencion = "Buena";
        }

        private void rbAtencion5_CheckedChanged(object sender, EventArgs e)
        {
            atencion = "Muy buena";
        }

        private void rbComida1_CheckedChanged(object sender, EventArgs e)
        {
            comida = "Muy mala";
        }

        private void rbComida2_CheckedChanged(object sender, EventArgs e)
        {
            comida = "Mala";
        }

        private void rbComida3_CheckedChanged(object sender, EventArgs e)
        {
            comida = "Normal";
        }

        private void rbComida4_CheckedChanged(object sender, EventArgs e)
        {
            comida = "Buena";
        }

        private void rbComida5_CheckedChanged(object sender, EventArgs e)
        {
            comida = "Muy buena";
        }

        private void rbPrecio1_CheckedChanged(object sender, EventArgs e)
        {
            precio = "Muy inconforme";
        }

        private void rbPrecio2_CheckedChanged(object sender, EventArgs e)
        {
            precio = "Inconforme";
        }

        private void rbPrecio3_CheckedChanged(object sender, EventArgs e)
        {
            precio = "Normal";
        }

        private void rbPrecio4_CheckedChanged(object sender, EventArgs e)
        {
            precio = "Conforme";
        }

        private void rbPrecio5_CheckedChanged(object sender, EventArgs e)
        {
            precio = "Muy conforme";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            /*"Evaluacion anonima \n " +
                             "Atencion: " + atencion + "\n" +
                             "Comida: " + comida + "\n" +
                             "Precios: " + precio + "\n" +
                             "Comentarios adicionales: " + txbComentarios.Texts + "\n" + 
                             "Por favor, revisar con atencion las evaluaciones y tomar medidas en base a los resultados generales";*/
            string body = @"<style>
                            h1{color:darkorange;}
                            h3{color:dodgerblue}
                            </style>
                            <h1>Mojo Evaluaciones anonimas</h1><br>                           
                            <h3> Atencion: " + atencion + "<br>" +
                            "Comida: " + comida + "<br>" +
                            "Precios: " + precio + "<br>" +
                            "Comentarios: " + txbComentarios.Texts + "</h3><br>" +
                            "<h4>Por favor, revisar con atencion las evaluaciones y tomar medidas en base a los resultados generales</h4>";
            string mensaje = EnviarCorreo("gabrod2706@gmail.com", "MojoDojo Eats - Evaluacion", body);
            MessageBox.Show(mensaje);
            txbComentarios.Texts = "";
        }

        string EnviarCorreo(string destinatario, string asunto, string body)
        {
            string mensaje = "Error al enviar el correo, por favor intente de nuevo";
            string from = "mojodojoeats.nr@outlook.com";
            string displayName = "MojoDojo Eats";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(destinatario);

                //Construccion del correo
                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new NetworkCredential(from, "MojoDojo.241123");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                mensaje = "Evaluacion enviada exitosamente. Gracias por sus comentarios!";
            }
            catch (Exception ex)
            {
                mensaje = "Por favor verifica tu conexion a internet e intenta nuevamente.";
            }
            return mensaje;
        }
    }
}
