using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComandoRadioElectrico.WinForms.Facade;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.WinForms.Adapter;
using System.Linq;
using System.ComponentModel;

namespace ComandoRadioElectrico.WinForms.Views
{
    public partial class PantallaSocios : Form
    {
        public PantallaSocios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este metodo permite llenar el ComboBox de los tipos de documentos.
        /// </summary>
        private void LlenarComboBoxTipoDocumento()
        {
            //Se llamam a la fachada y se completa con la lista de tipos de documentos.
            cbTipoDocumento.DataSource = DocumentTypeService.GetInstance.GetAll();
        }

        /// <summary>
        /// Este metodo permite llenar el ComboBox de los Cobradores.
        /// </summary>
        private void LlenarComboBoxCobradores()
        {
            IList<OfficerComboBoxAdapter> mListaRelleno = new List<OfficerComboBoxAdapter>();
            foreach (OfficerDTO officer in OfficerService.GetInstance.GetAllOfficer())
            {
                mListaRelleno.Add(new OfficerComboBoxAdapter
                {
                    Id = officer.Id,
                    FirstName = officer.Person.FirstName                  
                });
            }
            cbOfficer.DataSource = mListaRelleno;
        }

        /// <summary>
        /// Este metodo obtiene todos los socios y los carga en el DataGridView, para ello utiliza un modelo
        /// especial "PartnerGridViewAdapter" que solo tiene los datos necesarios para el DataGridView.
        /// </summary>
        private void CargarDataGridViewSocios()
        {
            IList<PartnerGridViewAdapter> mListaRelleno = new List<PartnerGridViewAdapter>();
            foreach (PartnerDTO partner in PartnerService.GetInstance.GetAll())
            {
                mListaRelleno.Add(new PartnerGridViewAdapter
                {
                    Id = partner.Id,
                    FirstName = partner.Person.FirstName,
                    LastName = partner.Person.LastName,
                    Document = partner.Person.DocumentNumber,
                    Domicile = partner.Person.Domicile                    
                });
            }
            DataGridViewSocios.DataSource = mListaRelleno;//.OrderBy(o => o.FirstName).ToList();

        }

        /// <summary>
        /// Metodo que se ejecuta cuando se carga la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PantallaSocios_Load(object sender, EventArgs e)
        {

            this.LlenarComboBoxTipoDocumento();            
            this.LlenarComboBoxCobradores();
            this.CargarDataGridViewSocios();
        }

        /// <summary>
        /// Obtiene la fila seleccionada cuando se hace clic en el botón "Seleccionar" de la fila. Saca el Id
        /// de la fila y llama al metodo que carga los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                 
            if (this.DataGridViewSocios.Columns[e.ColumnIndex].Name.Equals("Seleccionar"))
            {
                PartnerGridViewAdapter row = (PartnerGridViewAdapter)DataGridViewSocios.CurrentRow.DataBoundItem;
                //CleanDatosFilaSeleccionadaDataGridView();
                CargarDatosFilaSelccionadaDataGridView(row.Id);
            }
        }

        /// <summary>
        /// Buscar un socio y carga sus datos en la pantalla.
        /// </summary>
        /// <param name="pIdSocio"></param>
        private void CargarDatosFilaSelccionadaDataGridView(int pIdSocio)
        {
            bNew.Enabled = false;
            bUpdate.Enabled = true;
            bCancel.Enabled = true;
            bDelete.Enabled = true;

            PartnerDTO mPartner = PartnerService.GetInstance.Get(pIdSocio);
            tbFirstName.Text = mPartner.Person.FirstName;
            tbLastName.Text = mPartner.Person.LastName;
            tbCollectDay.Text = Convert.ToString(mPartner.CollectDay.Date);
            tbCollectDomicile.Text = mPartner.CollectDomicile;
            tbDocumentNamber.Text = mPartner.Person.DocumentNumber;
            tbDomicile.Text = mPartner.Person.Domicile;
            tbStartDate.Text = mPartner.StarDate.ToString();
            tbTelephone.Text = mPartner.Person.Telephone;
            tbValueQuota.Text = mPartner.ValueQuota.ToString();
            cbTipoDocumento.SelectedValue = mPartner.Person.DocumentTypeId;
            cbOfficer.SelectedValue = mPartner.Officer.Id;
        }

        /// <summary>
        /// Este metodo permite vaciar todos los TextBox que tienen datos que fueron cargados 
        /// o al seleccionar una fila del DataGridView.
        /// </summary>
        private void CleanDatosFilaSeleccionadaDataGridView()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbCollectDay.Text = "";
            tbCollectDomicile.Text = "";
            tbDocumentNamber.Text = "";
            tbDomicile.Text = "";
            tbStartDate.Text = "";
            tbTelephone.Text = "";
            tbValueQuota.Text = "";
            cbTipoDocumento.SelectedValue = 1;
        }

        /// <summary>
        /// Evento del boton canclear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            bNew.Enabled = true;
            bUpdate.Enabled = false;
            bCancel.Enabled = false;
            bDelete.Enabled = false;
            //CleanDatosFilaSeleccionadaDataGridView();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            PersonDTO mPerson = new PersonDTO{
                //OJO ACÁ Id debe obtenerce 
                Id = 6,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                DocumentTypeId = Convert.ToInt32(cbTipoDocumento.SelectedValue),
                DocumentNumber = tbDocumentNamber.Text,
                Domicile = tbDomicile.Text,
                Telephone = tbTelephone.Text
            };
            OfficerDTO mOfficer = new OfficerDTO{
                Id=Convert.ToInt32(cbOfficer.SelectedValue)
            };
            PartnerDTO mPartner = new PartnerDTO
            {
                Person = mPerson,
                Officer = mOfficer,
                ValueQuota = Convert.ToDouble(tbValueQuota.Text),
                CollectDay = DateTime.Today.Date,
                CollectDomicile = tbCollectDomicile.Text,
                StarDate = DateTime.Today.Date,
                FinishDate = DateTime.Today.Date
            };

            PartnerService.GetInstance.CreatePartner(mPartner);
            this.CleanDatosFilaSeleccionadaDataGridView();
            this.CargarDataGridViewSocios();
        }


    }
}
