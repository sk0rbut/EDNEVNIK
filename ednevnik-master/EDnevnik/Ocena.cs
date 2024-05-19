using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EDnevnik
{
    public partial class Ocena : Form
    {
        DataTable dt_ocena;
        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmbGodinaPopulate();
            cmbProfesorPopulate();
            cmbGodina.Enabled = false;
            cmbOdeljenje.Enabled = false;
            cmbUcenik.Enabled = false;
            cmbOcena.Enabled = false;
            cmbOcena.Items.Add(1);
            cmbOcena.Items.Add(2);
            cmbOcena.Items.Add(3);
            cmbOcena.Items.Add(4);
            cmbOcena.Items.Add(5);
        }

        private void cmbGodinaPopulate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            cmbGodina.DataSource = dt_godina;
            cmbGodina.ValueMember = "id";
            cmbGodina.DisplayMember = "naziv";
            cmbGodina.SelectedValue = 2;
        }

        private void cmbGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbGodina.IsHandleCreated && cmbGodina.Focused)
            {
                cmbProfesorPopulate();
            }
        }

        private void cmbProfesorPopulate()
        {
            StringBuilder naredba = new StringBuilder("select osoba.id as id, ime+' '+prezime as naziv from osoba");
            naredba.Append(" join raspodela on osoba.id=nastavnik_id");
            naredba.Append(" where godina_id=" + cmbGodina.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_profesor = new DataTable();
            adapter.Fill(dt_profesor);
            cmbProfesor.DataSource = dt_profesor;
            cmbProfesor.ValueMember = "id";
            cmbProfesor.DisplayMember = "naziv";
            cmbProfesor.SelectedIndex = -1;
        }

        private void cmbProfesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProfesor.IsHandleCreated && cmbProfesor.Focused)
            {
                cmbPredmetPopulate();
                cmbPredmet.Enabled = true;
                cmbOdeljenje.Enabled = false;
                cmbOdeljenje.SelectedIndex = -1;
                cmbUcenik.Enabled = false;
                cmbUcenik.SelectedIndex = -1;
                cmbOcena.Enabled = false;
                cmbOcena.SelectedIndex = -1;
                dt_ocena = new DataTable();
                Grid_Ocene.DataSource = dt_ocena;
            }
        }

        private void cmbPredmetPopulate()
        {
            StringBuilder naredba = new StringBuilder("select distinct predmet.id as id, naziv from predmet");
            naredba.Append(" join raspodela on predmet.id=predmet_id");
            naredba.Append(" where godina_id=" + cmbGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id=" + cmbProfesor.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_predmet = new DataTable();
            adapter.Fill(dt_predmet);
            cmbPredmet.DataSource = dt_predmet;
            cmbPredmet.ValueMember = "id";
            cmbPredmet.DisplayMember = "naziv";
            cmbPredmet.SelectedIndex = -1;
        }

        private void cmbPredmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbPredmet.IsHandleCreated && cmbPredmet.Focused)
            {
                cmbOdeljenjePopulate();
                cmbOdeljenje.Enabled = true;
                cmbUcenik.Enabled = false;
                cmbUcenik.SelectedIndex = -1;
                cmbOcena.Enabled = false;
                cmbOcena.SelectedIndex = -1;
                dt_ocena = new DataTable();
                Grid_Ocene.DataSource = dt_ocena;
            }
        }

        private void cmbOdeljenjePopulate()
        {
            StringBuilder naredba = new StringBuilder("select distinct odeljenje.id as id, str(razred) + '-' + indeks as naziv from odeljenje");
            naredba.Append(" join raspodela on odeljenje.id=odeljenje_id");
            naredba.Append(" where raspodela.godina_id=" + cmbGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id=" + cmbProfesor.SelectedValue.ToString());
            naredba.Append(" and predmet_id=" + cmbPredmet.SelectedValue.ToString());
            //textBox2.Text = naredba.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            cmbOdeljenje.DataSource = dt_odeljenje;
            cmbOdeljenje.ValueMember = "id";
            cmbOdeljenje.DisplayMember = "naziv";
            cmbOdeljenje.SelectedIndex = -1;
        }

        private void cmbOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbOdeljenje.IsHandleCreated && cmbOdeljenje.Focused)
            {
                cmbUcenikPopulate();
                cmbUcenik.Enabled = true;
                cmbOcena.Enabled = true;
                GridPopulate();
                UcenikOcenaIdSet(0);
            }
        }

        private void cmbUcenikPopulate()
        {
            StringBuilder naredba = new StringBuilder("select osoba.id as id, ime + ' ' + prezime as naziv from osoba");
            naredba.Append(" join upisnica on osoba.id=osoba_id");
            naredba.Append(" where upisnica.odeljenje_id=" + cmbOdeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);
            cmbUcenik.DataSource = dt_ucenik;
            cmbUcenik.ValueMember = "id";
            cmbUcenik.DisplayMember = "naziv";
            cmbUcenik.SelectedIndex = -1;
        }

        private void GridPopulate()
        {
            StringBuilder naredba = new StringBuilder("select ocena.id as id, ime + ' ' + prezime as naziv, ocena, ucenik_id, datum from osoba");
            naredba.Append(" join ocena on osoba.id=ucenik_id");
            naredba.Append(" join raspodela on raspodela_id=raspodela.id");
            naredba.Append(" where raspodela_id=");
            naredba.Append(" (select id from raspodela");
            naredba.Append(" where godina_id=" + cmbGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id=" + cmbProfesor.SelectedValue.ToString());
            naredba.Append(" and predmet_id=" + cmbPredmet.SelectedValue.ToString());
            naredba.Append(" and odeljenje_id=" + cmbOdeljenje.SelectedValue.ToString() + ")");
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_ocena = new DataTable();
            adapter.Fill(dt_ocena);
            Grid_Ocene.DataSource = dt_ocena;
            Grid_Ocene.AllowUserToAddRows = false;
            Grid_Ocene.Columns["ucenik_id"].Visible = false;
        }

        private void Grid_Ocene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UcenikOcenaIdSet(e.RowIndex);
            }
        }

        private void UcenikOcenaIdSet(int broj_sloga)
        {
            cmbUcenik.SelectedValue = dt_ocena.Rows[broj_sloga]["ucenik_id"];
            cmbOcena.SelectedItem = dt_ocena.Rows[broj_sloga]["ocena"];
            txtId.Text = dt_ocena.Rows[broj_sloga]["id"].ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //insert
            StringBuilder naredba = new StringBuilder("select id from raspodela");
            naredba.Append(" where godina_id = " + cmbGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id = " + cmbProfesor.SelectedValue.ToString());
            naredba.Append(" and predmet_id = " + cmbPredmet.SelectedValue.ToString());
            naredba.Append(" and odeljenje_id = " + cmbOdeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;
            try
            {
                veza.Open();
                id_raspodele = (int)komanda.ExecuteScalar();
                veza.Close();
            }
            catch(Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (id_raspodele > 0)
            {
                naredba = new StringBuilder("insert into ocena(datum, raspodela_id, ucenik_id, ocena) values ('");
                DateTime datum = Datum.Value;
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(cmbUcenik.SelectedValue.ToString() + "', '");
                naredba.Append(cmbOcena.SelectedItem.ToString() + "')");
                komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch(Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
            GridPopulate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                DateTime datum = Datum.Value;
                StringBuilder naredba = new StringBuilder("update ocena set");
                naredba.Append(" ucenik_id = '" + cmbUcenik.SelectedValue.ToString() + "', ");
                naredba.Append(" ocena = '" + cmbOcena.SelectedItem.ToString() + "', ");
                naredba.Append(" datum = " + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append("where id = " + txtId.Text);
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
                GridPopulate();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                string naredba = "delete from ocena where id = " + txtId.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPopulate();
                    UcenikOcenaIdSet(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
