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
using Ganss.Excel;
using MetroFramework.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace clent_facture
{
    public partial class Form2 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yassine\Downloads\clent_facture\Gestion.mdf;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }
        Boolean IsValideICE(String ice)
        {
            return ice.Length == 15 && ice.All(char.IsNumber);
        }

        Boolean IsValideIF(String IF)
        {
            return IF.Length <= 8 && IF.Length != 0 && IF.All(char.IsNumber);
        }

        Boolean IsValideRegCom(String RegCom)
        {
            return RegCom.Length <= 5 && RegCom.Length != 0 && RegCom.All(char.IsNumber);
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionDataSet3.InfoClients' table. You can move, or remove it, as needed.
            this.infoClientsTableAdapter3.Fill(this.gestionDataSet3.InfoClients);

            connection.Open();
            SqlDataAdapter dataadp = new SqlDataAdapter("SELECT * FROM InfoClients ;", connection);
            DataTable dta = new DataTable();
            dataadp.Fill(dta);
            DGV.DataSource = dta;



            connection.Close();
        }



        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (IsValideICE(iceText.Text))
            {
                if (IsValideIF(IFclientText.Text))
                {
                    if (IsValideRegCom(RegComText.Text))
                    {




                        connection.Open();

                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into InfoClients values('" + RSText.Text +
                                                                       "','" + IFclientText.Text +
                                                                       "','" + TypeSocieteText.Text +
                                                                       "','" + iceText.Text +
                                                                       "','" + RegComText.Text +
                                                                       "','" + NomRespoText.Text +
                                                                       "','" + PatenteText.Text +
                                                                       "','" + NomText.Text +
                                                                       "','" + PrenomText.Text +
                                                                       "','" + EmailText.Text +
                                                                       "','" + TelText.Text +
                                                                       "','" + AdresseText.Text +
                                                                       "','" + FaxText.Text +
                                                                       "','" + PortableText.Text +
                                                                       "','" + VilleText.Text +
                                                                       "','" + PaysText.Text +
                                                                       "')";

                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {

                                RSText.Clear();
                                IFclientText.Clear();
                                TypeSocieteText.Clear();
                                iceText.Clear();
                                RegComText.Clear();
                                NomRespoText.Clear();
                                PatenteText.Clear();
                                NomText.Clear();
                                PrenomText.Clear();
                                EmailText.Clear();
                                TelText.Clear();
                                AdresseText.Clear();
                                FaxText.Clear();
                                PortableText.Clear();
                                VilleText.Clear();
                                PaysText.Clear();

                                MessageBox.Show("Inseré avec success ");
                                connection.Close();
                                Form2_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Erreur");
                            }
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 2627)
                            {
                                // 2627 = violation contre unique contraint 
                                MessageBox.Show("Déja existe ! Merci de ressayer avec d'autre entree");
                                connection.Close();

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Registre de commerce doit être composé de 5 chiffre Maximum! ");
                    }
                }
                else
                {
                    MessageBox.Show("IF doit être composé de 8 chiffre Maximum! ");
                }
            }
            else
            {
                MessageBox.Show("ICE doit être composé de 15 chiffre ! ");
            }


        }

        private void Vider_Click(object sender, EventArgs e)
        {
            ClientIdText.Clear();
            RSText.Clear();
            IFclientText.Clear();
            TypeSocieteText.Clear();
            iceText.Clear();
            RegComText.Clear();
            NomRespoText.Clear();
            PatenteText.Clear();
            NomText.Clear();
            PrenomText.Clear();
            EmailText.Clear();
            TelText.Clear();
            AdresseText.Clear();
            FaxText.Clear();
            PortableText.Clear();
            VilleText.Clear();
            PaysText.Clear();
        }

        private void RechercheText_TextChanged(object sender, EventArgs e)
        {
            if (RechercheCombo.Text == "Nom Responsable")
            {
                SelectPourRecherche("NomRespo");

            }
            else if (RechercheCombo.Text == "Raison Sociale")
            {
                SelectPourRecherche("RS");
            }
            else if (RechercheCombo.Text == "Type de Societe")
            {
                SelectPourRecherche("TypeSociete");
            }
            else if (RechercheCombo.Text == "Nom")
            {
                SelectPourRecherche("Nom");
            }
            else if (RechercheCombo.Text == "Ville")
            {
                SelectPourRecherche("Ville");
            }
            else if (RechercheCombo.Text == "Pays")
            {
                SelectPourRecherche("Pays");
            }
        }

        void SelectPourRecherche(String colonne)
        {
            connection.Open();
            SqlDataAdapter dataadp = new SqlDataAdapter("SELECT * FROM InfoClients WHERE " + colonne + " LIKE '" + RechercheText.Text + "%';", connection);
            DataTable dta = new DataTable();
            dataadp.Fill(dta);
            DGV.DataSource = dta;
            connection.Close();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int selectedRow = DGV.SelectedRows[0].Index;
            int rowID = int.Parse(DGV.Rows[selectedRow].Cells["ClientId"].Value.ToString());
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update InfoClients set RS = '" + RSText.Text +
                                                           "',IFc ='" + IFclientText.Text +
                                                           "',TypeSociete ='" + TypeSocieteText.Text +
                                                           "',ICE ='" + iceText.Text +
                                                           "',RegCommerce ='" + RegComText.Text +
                                                           "',NomRespo ='" + NomRespoText.Text +
                                                           "',Patente ='" + PatenteText.Text +
                                                           "',Nom ='" + NomText.Text +
                                                           "',Prenom='" + PrenomText.Text +
                                                           "',Email='" + EmailText.Text +
                                                           "',Tel='" + TelText.Text +
                                                           "',Adresse='" + AdresseText.Text +
                                                           "',Fax='" + FaxText.Text +
                                                           "',Portable='" + PortableText.Text +
                                                           "',Ville='" + VilleText.Text +
                                                           "',Pays='" + PaysText.Text + "' WHERE ClientId='" + rowID + "';";

            cmd.ExecuteNonQuery();
            connection.Close();
            Form2_Load(sender, e);
        }



        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = 0;
            SelectedRow = e.RowIndex;
            if (SelectedRow != -1)
            {

                DataGridViewRow row = DGV.Rows[SelectedRow];


                RSText.Text = row.Cells["RS"].Value.ToString();
                IFclientText.Text = row.Cells["IFc"].Value.ToString();
                TypeSocieteText.Text = row.Cells["TypeSociete"].Value.ToString();
                iceText.Text = row.Cells["ICE"].Value.ToString();
                RegComText.Text = row.Cells["RegCommerce"].Value.ToString();
                NomRespoText.Text = row.Cells["NomRespo"].Value.ToString();
                PatenteText.Text = row.Cells["Patente"].Value.ToString();
                NomText.Text = row.Cells["Nom"].Value.ToString();
                PrenomText.Text = row.Cells["Prenom"].Value.ToString();
                EmailText.Text = row.Cells["Email"].Value.ToString();
                TelText.Text = row.Cells["Tel"].Value.ToString();
                AdresseText.Text = row.Cells["Adresse"].Value.ToString();
                FaxText.Text = row.Cells["Fax"].Value.ToString();
                PortableText.Text = row.Cells["Portable"].Value.ToString();
                VilleText.Text = row.Cells["Ville"].Value.ToString();
                PaysText.Text = row.Cells["Pays"].Value.ToString();

            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exporter_Click(object sender, EventArgs e)
        {










            connection.Close();
        }




    }
}





