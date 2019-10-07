using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Btg.PocReserva.UI
{
    public partial class Form1 : Form
    {
        string user = "30213588889";
        string password = "Val090482";
        string url = @"https://associado.afpesp.org.br/json/Login.aspx";
        string urlFlexReserva = @"https://www.flexreserva.org.br/json/login.aspx";
        string urlDisponibilidade;
        CookieAwareWebClient client;
        List<string> lstIdReservas;
        Dictionary<int, string> reserva;

        public Form1()
        {
            InitializeComponent();

            lstIdReservas = new List<string>();
            for (int i = 0; i < 18; i++)
            {
                int id = 4001 + i;
                lstIdReservas.Add(id.ToString());
            }
            lstIdReservas.Add("4020");
            this.BackColor = Color.White;
            Application.DoEvents();
        }

        private void BtgLogin_Click(object sender, EventArgs e)
        {
            btnlimpar.PerformClick();
            client = new CookieAwareWebClient();
            NameValueCollection param = new NameValueCollection();
            param.Add("ma", "30213588889");
            param.Add("pwd", "Val090482");
            client.Login(urlFlexReserva, param);

            GetDisponibilidade(4014, new DateTime(2019, 12, 22), new DateTime(2020, 01, 31));

            // get toddos
            GetDisponibilidade();

            RetornarDisponibilidade();


            client.RetornarPeriodos();
            client.RetornaHoteis();
        }

        private void RetornarDisponibilidade()
        {
            NameValueCollection param = new NameValueCollection();
            string strDataChegada = new DateTime(2019, 12, 27).ToShortDateString();
            string _ = "1569254298528";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("strDataChegada", new DateTime(2019, 12, 27).ToShortDateString());
            dictionary.Add("_", "1569254298528");

            param.Add("strDataChegada", strDataChegada);
            param.Add("_", _);
            urlDisponibilidade =
                @"https://4005.afpesp.org.br/RetornaDisponibilidade?callback=RetornaDisponibilidade&strDataChegada=27%2F12%2F2019&_=1569270381462";

            client.HttpPostRequest(urlDisponibilidade, dictionary);
            client.Disponibilidade(urlDisponibilidade, param);
        }

        private void GetDisponibilidade()
        {
            NameValueCollection param = new NameValueCollection();
            string strDataChegada = new DateTime(2019, 12, 22).ToShortDateString();
            string _ = "1569254298528";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("strDataChegada", new DateTime(2019, 12, 22).ToShortDateString());
            dictionary.Add("_", "1569254298528");

            param.Add("strDataChegada", strDataChegada);
            param.Add("_", _);
            urlDisponibilidade = @"https://4001.afpesp.org.br/RetornaDisponibilidade?callback=RetornaDisponibilidade&strDataChegada=27%2F12%2F2019&_=1569254155737";

            dictionary = new Dictionary<string, string>();
            dictionary.Add("strDataChegada", new DateTime(2019, 12, 27).ToShortDateString());
            dictionary.Add("_", "1569254298528");

            bool RESULT = false;

            Debug.Print(new string('*', 80));
            Debug.Print("**   INICIADO A SUA PESQUISA **");
            Debug.Print(new string('*', 80));

            string res = "";
            while (!RESULT)
            {

                foreach (var item in lstIdReservas)
                {
                    url = string.Format(@"https://{0}.afpesp.org.br/RetornaDisponibilidade?callback=RetornaDisponibilidade&strDataChegada=27%2F12%2F2019&_=1569254155737", item);
                    res = client.Disponibilidade(url, param);

                    if (res == "4014")
                    {
                        this.BackColor = Color.Green;
                        Debug.Print(new string('*', 80));
                        Debug.Print("**   AAAAAAAAAAAAAAACHOUUUUUUUUUUUU **");
                        Debug.Print(new string('*', 80));

                        this.BackColor = Color.Green;
                        RESULT = true;
                        return;
                    }
                    else if (res != "" && res != "4017")
                    {
                        this.BackColor = Color.Yellow;
                        Application.DoEvents();
                    }
                }

                if (res != "4017")
                {
                    RESULT = false;
                }
                else
                    this.BackColor = Color.Red;

                Application.DoEvents();
            }

            Application.DoEvents();

        }

        private void GetDisponibilidade(int codUnidade, DateTime dataChegada, DateTime dataSaida)
        {
            NameValueCollection param = new NameValueCollection();
            string strDataChegada = new DateTime(2019, 12, 22).ToShortDateString();
            string _ = "1569254298528";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("strDataChegada", new DateTime(2019, 12, 22).ToShortDateString());
            dictionary.Add("_", "1569254298528");

            param.Add("strDataChegada", strDataChegada);
            param.Add("_", _);
            urlDisponibilidade =
                string.Format
                (
                    @"https://{0}.afpesp.org.br/RetornaDisponibilidade?callback=RetornaDisponibilidade&strDataChegada={1}%2F{2}%2F{3}&_=1569254155737",
                    codUnidade, dataChegada.Day, dataChegada.Month, dataChegada.Year
                );

            dictionary = new Dictionary<string, string>();
            dictionary.Add("strDataChegada", dataChegada.ToShortDateString());
            dictionary.Add("_", "1569254298528");

            bool RESULT = false;

            Debug.Print(new string('*', 80));
            Debug.Print("**   INICIADO A SUA PESQUISA **");
            Debug.Print(new string('*', 80));

            string res = "";
            while (!RESULT)
            {
                res = client.Disponibilidade(urlDisponibilidade, param);

                if (res == "4014")
                {
                    this.BackColor = Color.Green;
                    Debug.Print(new string('*', 80));
                    Debug.Print("**   AAAAAAAAAAAAAAACHOUUUUUUUUUUUU **");
                    Debug.Print(res);
                    Debug.Print(new string('*', 80));

                    this.BackColor = Color.Green;
                    RESULT = true;
                    Application.DoEvents();

                    return;
                }
                else if (res != "" && res != "4017")
                {
                    this.BackColor = Color.Yellow;
                    Debug.Print(res);
                    Application.DoEvents();
                }


                if (res != "4017")
                {
                    if (res != string.Empty)
                    {
                        Debug.Print(res);
                    }
                    RESULT = false;
                    Application.DoEvents();

                }
                else
                {
                    Debug.Print(res);
                    this.BackColor = Color.Red;
                    Application.DoEvents();

                }

                Application.DoEvents();
            }

            Application.DoEvents();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Application.DoEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected void Displaynotify()
        {
            try
            {
                notifyIcon1.Icon = new Icon(Path.GetFullPath(@"C:\Users\rodrigme\OneDrive - Banco BTG Pactual S.A\Desktop\sync.ico"));
                notifyIcon1.Text = "Export Datatable Utlity";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "RESERVA DE AFEPESP GARANTIDA";
                notifyIcon1.BalloonTipText = "Encontrado a reserva deseja, verifique!";
                notifyIcon1.ShowBalloonTip(1000);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Displaynotify(string text, bool iconVisible, string balloonTitle, string balloonText, int timeDisplayBalloon)
        {
            try
            {
                notifyIcon1.Icon = new Icon(Path.GetFullPath(@"C:\Users\rodrigme\OneDrive - Banco BTG Pactual S.A\Desktop\sync.ico"));
                notifyIcon1.Text = text;
                notifyIcon1.Visible = iconVisible;
                notifyIcon1.BalloonTipTitle = balloonTitle;
                notifyIcon1.BalloonTipText = balloonText;
                notifyIcon1.ShowBalloonTip(timeDisplayBalloon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = DateTime.UtcNow.ToLocalTime();
            string dateString = res.ToString();// "7/16/2008 8:32:45.126 AM";

            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(2019, 10, 3))).TotalSeconds;
            //Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;


            try
            {
                DateTime dateValue = DateTime.Parse(dateString);
                DateTimeOffset dateOffsetValue = DateTimeOffset.Parse(dateString);

                // Display Millisecond component alone.
                Debug.WriteLine("Millisecond component only: {0}",
                                  dateValue.ToString("fff"));
                Debug.WriteLine("Millisecond component only: {0}",
                                  dateOffsetValue.ToString("fff"));

                // Display Millisecond component with full date and time.
                Debug.WriteLine("Date and Time with Milliseconds: {0}",
                                  dateValue.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
                Debug.WriteLine("Date and Time with Milliseconds: {0}",
                                  dateOffsetValue.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));

                // Append millisecond pattern to current culture's full date time pattern
                string fullPattern = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
                fullPattern = Regex.Replace(fullPattern, "(:ss|:s)", "$1.fff");

                // Display Millisecond component with modified full date and time pattern.
                Debug.WriteLine("Modified full date time pattern: {0}",
                                  dateValue.ToString(fullPattern));
                Debug.WriteLine("Modified full date time pattern: {0}",
                                  dateOffsetValue.ToString(fullPattern));
            }
            catch (FormatException)
            {
                Debug.WriteLine("Unable to convert {0} to a date.", dateString);
            }

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarLocalSelecionadoHotel())
                {

                }
            }
            catch (Exception ex)
            {
                Displaynotify();
            }
        }

        private bool VerificarHotelSelecionado()
        {
            bool selecionado = false;
            reserva = new Dictionary<int, string>();

            try
            {
                if (gpbPraia.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbThermas.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbMontanha.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
                else if (gpbCircuito.Enabled)
                {
                    if (rbtAreado.Enabled)
                    {
                        reserva.Add(rbtAreado.TabIndex, rbtAreado.Text);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return true;
        }

        private bool VerificarLocalSelecionadoHotel()
        {
            bool selecionado = false;

            try
            {
                if (chkCampo.Enabled || chkCircuito.Enabled || chkMontanha.Enabled || chkPraia.Enabled || chkThermas.Enabled)
                {
                    if (VerificarHotelSelecionado())
                    {
                        selecionado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Displaynotify("Falha na localidade", true, "LOCAL A SER VERIFICADO", ex.Message, 2000);
            }

            return selecionado;
        }

        private void chkCampo_CheckedChanged(object sender, EventArgs e)
        {
            gpbCampo.Enabled = !gpbCampo.Enabled;
        }

        private void chkMontanha_CheckedChanged(object sender, EventArgs e)
        {
            gpbMontanha.Enabled = !gpbMontanha.Enabled;
        }

        private void chkCircuito_CheckedChanged(object sender, EventArgs e)
        {
            gpbCircuito.Enabled = !gpbCircuito.Enabled;
        }

        private void chkThermas_CheckedChanged(object sender, EventArgs e)
        {
            gpbThermas.Enabled = !gpbThermas.Enabled;
        }

        private void chkPraia_CheckedChanged(object sender, EventArgs e)
        {
            gpbPraia.Enabled = !gpbPraia.Enabled;
        }
    }
}
