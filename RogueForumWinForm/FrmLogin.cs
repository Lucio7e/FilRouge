
using RogueForumDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueForumWinForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //L'utilisateur en cours devient égal à l'utilisateur renvoyé par ma méthode
           frmMain.CurrentUser = Controller.Login(txtBoxUsername.Text, txtBoxPwd.Text);
            if (frmMain.CurrentUser != null)
            {
                //La variable IsConnected qui est dans mon FrmMain prend la valeur true
                frmMain.IsConnected = true;
                frmMain.IsModo = frmMain.CurrentUser.IsModo;
                this.Close();
            }
            else
            {
                 frmMain.IsConnected = false;
                MessageBox.Show("Login ou mot de passe incorrect", "Erreur d'identification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnMDPPerdu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxMail.Text))
            {
                MessageBox.Show(Properties.Resources.MsgBoxMailText, Properties.Resources.MsgBoxMailTitre);
                txtBoxMail.Focus();
            }else
            {
                if (Controller.GetUserByLoginMail(txtBoxUsername.Text, txtBoxMail.Text))
                {
                    EnvoiMail();
                    txtBoxMail.Clear();
                }
                else
                {
                    MessageBox.Show("Aucune combinaison Login/Mail ne correspond, merci de saisir un login et un mail valide");
                }
               
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            btnMDPPerdu.Enabled = !string.IsNullOrWhiteSpace(txtBoxUsername.Text);

            btnConnect.Enabled = !string.IsNullOrWhiteSpace(txtBoxUsername.Text) && !string.IsNullOrWhiteSpace(txtBoxPwd.Text);
        }

        private void txtBoxPwd_TextChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = !string.IsNullOrWhiteSpace(txtBoxUsername.Text) && !string.IsNullOrWhiteSpace(txtBoxPwd.Text);
        }
        
        private void EnvoiMail()
        {
            string caracteres = "azertyuiopqsdfghjklmwxcvbn";
            Random selAlea = new Random();
            string sel = "";
            for (int i = 0; i < 8; i++) // 8 caracteres
            {
                int majOrMin = selAlea.Next(2);
                string carac = caracteres[selAlea.Next(0, caracteres.Length)].ToString();
                if (majOrMin == 0)
                {
                    sel += carac.ToUpper(); // Maj
                }
                else
                {
                    sel += carac.ToLower(); //Min
                }
            }
            string body = string.Format(Properties.Resources.BodyMail, sel);
           
            MailMessage mail = new MailMessage("Administrateur@Forum.com", txtBoxMail.Text, "Mot de passe perdu", body);
            SmtpClient client = new SmtpClient(Properties.Settings.Default.SMTP,int.Parse(Properties.Settings.Default.PortSMTP));
            client.Credentials = new NetworkCredential(Properties.Settings.Default.InfoMail, Properties.Settings.Default.InfoMailMdp);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                client.Send(mail);
                //Controller.ChangeMdp(txtBoxUsername.Text, sel);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Impossible d'envoyer le mail " + ex.ToString(), "Erreur");
            }
            MessageBox.Show(Properties.Resources.MsgBoxEnvoiMail);
            Cursor.Current = Cursors.Default;
        }
    }
}
