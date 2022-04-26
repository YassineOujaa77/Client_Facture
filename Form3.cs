using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace clent_facture
{
    public partial class Form3 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassine\Downloads\clent_facture\Gestion.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionDataSet4.InfoClients' table. You can move, or remove it, as needed.
            this.infoClientsTableAdapter.Fill(this.gestionDataSet4.InfoClients);

        }

        

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(metroComboBox1.Text);
            connection.Open();
            SqlDataAdapter dataadp = new SqlDataAdapter("SELECT InfoClients.ICE , InfoClients.IFC , InfoClients.ClientId ,Facture.FactureN,Facture.Designation , Facture.Quantite ,Facture.Prix ,Facture.[Reference] FROM Facture INNER JOIN InfoClients ON InfoClients.ClientId = Facture.[Client ID] AND Facture.RS = '" + metroComboBox1.Text + "';", connection);
            DataTable dta = new DataTable();
            dataadp.Fill(dta);
            foreach(DataRow row in dta.Rows )
            {
                factureNText.Text = row["FactureN"].ToString();
                DesignationText.Text = row["Designation"].ToString();
                QuantiteText.Text = row["Quantite"].ToString();
                PrixText.Text = row["Prix"].ToString();
                ReferenceText.Text = row["Reference"].ToString();
                IFclientText.Text = row["IFc"].ToString();
                ICEclientText.Text = row["ICE"].ToString();
                ClientIDText.Text = row["ClientId"].ToString(); 
            }

            connection.Close();
           

        }

        
    }
}
