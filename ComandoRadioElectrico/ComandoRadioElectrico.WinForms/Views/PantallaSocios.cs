using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComandoRadioElectrico.WinForms.Facade;
using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.WinForms.Adapter;
using System.Linq;
using System.ComponentModel;
using System.Text.RegularExpressions;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.WinForms.Utils;

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
            cbTipoDocumento.DataSource = DocumentTypeFacade.GetAll();
        }

        /// <summary>
        /// Este metodo permite llenar el ComboBox de los Cobradores.
        /// </summary>
        private void LlenarComboBoxCobradores()
        {
            IList<OfficerComboBoxAdapter> mListaRelleno = new List<OfficerComboBoxAdapter>();
            foreach (OfficerDTO officer in OfficerFacade.GetAllOfficer())
            {
                mListaRelleno.Add(new OfficerComboBoxAdapter
                {
                    Id = officer.Id,
                    FirstName = officer.Person.FirstName
                });
            }
            cbOfficer.DataSource = mListaRelleno;
        }

        private void LlenarComboBoxDel()
        {
            IList<CollectDayComboBoxAdapter> mListaRellenoDel = new List<CollectDayComboBoxAdapter>();
            for (int indice = 1; indice <= 31; indice++)
            {
                mListaRellenoDel.Add(new CollectDayComboBoxAdapter { Id = indice });
            }
            cbDel.DataSource = mListaRellenoDel;
        }

        private void LlenarComboBoxAl()
        {
            IList<CollectDayComboBoxAdapter> mListaRellenoAl = new List<CollectDayComboBoxAdapter>();
            for (int indice = 1; indice <= 31; indice++)
            {
                mListaRellenoAl.Add(new CollectDayComboBoxAdapter{Id = indice});
            }
            cbAl.SelectedValue = mListaRellenoAl;
        }

        /// <summary>
        /// Este metodo obtiene todos los socios y los carga en el DataGridView, para ello utiliza un modelo
        /// especial "PartnerGridViewAdapter" que solo tiene los datos necesarios para el DataGridView.
        /// </summary>
        private void CargarDataGridViewSocios()
        {
            IList<PartnerGridViewAdapter> mListaRelleno = new List<PartnerGridViewAdapter>();
            foreach (PartnerDTO partner in PartnerFacade.GetAll())
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
            this.LlenarComboBoxAl();
            this.LlenarComboBoxDel();            
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
                CargarDatosFilaSelccionadaDataGridView(row.Id);
                tbIdPartnerSelected.Text = row.Id.ToString();
            }
        }

        /// <summary>
        /// Buscar un socio y carga sus datos en la pantalla.
        /// </summary>
        /// <param name="pIdSocio"></param>
        private void CargarDatosFilaSelccionadaDataGridView(int pIdSocio)
        {
            bNew.Visible = false;
            bRestore.Visible = true;
            bUpdate.Enabled = true;
            bCancel.Enabled = true;
            bDelete.Enabled = true;

            PartnerDTO mPartner = PartnerFacade.Get(pIdSocio);
            tbFirstName.Text = mPartner.Person.FirstName;
            tbLastName.Text = mPartner.Person.LastName;            
            tbCollectDomicile.Text = mPartner.CollectDomicile;
            mtDocumentNumber.Text = mPartner.Person.DocumentNumber;
            tbDomicile.Text = mPartner.Person.Domicile;
            tbStartDate.Text = mPartner.StarDate.ToString();
            tbTelephone.Text = mPartner.Person.Telephone;
            tbValueQuota.Text = mPartner.ValueQuota.ToString();
            cbTipoDocumento.SelectedValue = mPartner.Person.DocumentTypeId;
            for (int indice = 0; indice< mPartner.CollectDay.Length;indice++)
            {
                if(mPartner.CollectDay[indice].Equals('-'))
                {
                    cbDel.SelectedValue = Convert.ToInt32(mPartner.CollectDay.Substring(0, indice));
                    cbAl.SelectedValue = Convert.ToInt32(mPartner.CollectDay.Substring(indice + 1, mPartner.CollectDay.Length - indice -1));
                    break;
                }
            }
            
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
            LlenarComboBoxAl();
            LlenarComboBoxDel();
            tbCollectDomicile.Text = "";
            mtDocumentNumber.Text = "";
            tbDomicile.Text = "";
            tbStartDate.Text = "";
            tbTelephone.Text = "";
            tbValueQuota.Text = "";
            cbTipoDocumento.SelectedValue = 1;
            tbValueQuota.Text = Convert.ToString(0);
            this.CleanErrorElemnts();
            tbIdPartnerSelected.Text = "";
        }

        /// <summary>
        /// Oculta todos los elementos relacionados con los mensajes de error.
        /// </summary>
        private void CleanErrorElemnts()
        {
            ValueQuotaError.Visible = false;
            TelephoneError.Visible = false;
            CollectDomicileError.Visible = false;
            DomicileError.Visible = false;
            DocumentNumberError.Visible = false;
            LastNameError.Visible = false;
            FirstNameError.Visible = false;
            labelMessaError.Visible = false;
            CollectDomicileError.Visible = false;
        }

        /// <summary>
        /// Evento del boton canclear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            bNew.Visible = true;
            bRestore.Visible = false;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
            CleanDatosFilaSeleccionadaDataGridView();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrorElemnts();
                PersonDTO mPerson = new PersonDTO
                {
                    FirstName = tbFirstName.Text.ToString(),
                    LastName = tbLastName.Text,
                    DocumentTypeId = Convert.ToInt32(cbTipoDocumento.SelectedValue),
                    DocumentNumber = mtDocumentNumber.Text,
                    Domicile = tbDomicile.Text,
                    Telephone = tbTelephone.Text
                };
                OfficerDTO mOfficer = new OfficerDTO
                {
                    Id = Convert.ToInt32(cbOfficer.SelectedValue)
                };


                PartnerDTO mPartner = new PartnerDTO
                {
                    Person = mPerson,
                    Officer = mOfficer,
                    ValueQuota = Convert.ToSingle(tbValueQuota.Text),
                    CollectDay = cbDel.SelectedValue.ToString() + "-" + cbAl.SelectedValue.ToString(),
                    CollectDomicile = tbCollectDomicile.Text,
                    StarDate = DateTime.Today,
                    FinishDate = null
                };
                PartnerFacade.CreatePartner(mPartner);
                MessageBox.Show("Socio creado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CleanDatosFilaSeleccionadaDataGridView();
                this.CargarDataGridViewSocios();
            }
            catch (BusinessException exception)
            {
                if (tbFirstName.Text == "")
                {
                    FirstNameError.Visible = true;
                }
                if (tbLastName.Text == "")
                {
                    LastNameError.Visible = true;
                }
                if (mtDocumentNumber.Text.Length == 10)
                {
                    for (int indice = 0; indice < mtDocumentNumber.Text.Length; indice++)
                    {
                        if (mtDocumentNumber.Text[indice] == ' ')
                        {
                            DocumentNumberError.Visible = true;
                            indice = mtDocumentNumber.Text.Length;
                        }
                    }
                }
                else
                {
                    DocumentNumberError.Visible = true;
                }
                if (tbDomicile.Text == "")
                {
                    DomicileError.Visible = true;
                }
                if (tbTelephone.Text == "")
                {
                    TelephoneError.Visible = true;
                }
                if (tbValueQuota.Text == "")
                {
                    ValueQuotaError.Visible = true;
                }
                if (tbCollectDomicile.Text == "")
                {
                    CollectDomicileError.Visible = true;
                }
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
            catch (NullReferenceException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
            catch (FormatException)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = "El formato ingresado es invalidoa";
            }
            catch (InvalidFormatException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
            catch (PartnerException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
                DocumentNumberError.Visible = true;
            }
            catch (QuotaException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
                ValueQuotaError.Visible = true;
            }
            catch (Exception exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
        }

        private void cbDel_SelectedValueChanged(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(cbDel.SelectedValue);
            IList<CollectDayComboBoxAdapter> mListaRellenoAl = new List<CollectDayComboBoxAdapter>();
            for (int ind = 1; ind <= 31; ind++)
            {
                mListaRellenoAl.Add(new CollectDayComboBoxAdapter { Id = ind });
            }
            cbAl.DataSource = mListaRellenoAl.Where(x => x.Id >= indice).ToList();            
        }

        private void tbValueQuota_KeyPress(object sender, KeyPressEventArgs e)
        {            
            e.Handled = Miscellaneous.ValidateAmount(e);
            if (e.KeyChar == ('.'))
            {
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void tbTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Miscellaneous.ValidateTelephone(e);
            if (e.KeyChar == ('(') && tbTelephone.Text.Contains('('))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (')') && tbTelephone.Text.Contains(')'))
            {
                e.Handled = true;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea dar de baja este socio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PartnerFacade.DeletePartner(Convert.ToInt32(tbIdPartnerSelected.Text));
                    CleanDatosFilaSeleccionadaDataGridView();
                    this.CargarDataGridViewSocios();
                    MessageBox.Show("Socio eliminada satisfactoriamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (PartnerException exception) 
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }

        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PersonDTO mPerson = new PersonDTO
                {
                    FirstName = tbFirstName.Text.ToString(),
                    LastName = tbLastName.Text,
                    DocumentTypeId = Convert.ToInt32(cbTipoDocumento.SelectedValue),
                    DocumentNumber = mtDocumentNumber.Text,
                    Domicile = tbDomicile.Text,
                    Telephone = tbTelephone.Text
                };
                OfficerDTO mOfficer = new OfficerDTO
                {
                    Id = Convert.ToInt32(cbOfficer.SelectedValue)
                };
                PartnerDTO mPartner = new PartnerDTO
                {
                    Id = Convert.ToInt32(tbIdPartnerSelected.Text),
                    Person = mPerson,
                    Officer = mOfficer,
                    ValueQuota = Convert.ToSingle(tbValueQuota.Text),
                    CollectDay = cbDel.SelectedValue.ToString() + "-" + cbAl.SelectedValue.ToString(),
                    CollectDomicile = tbCollectDomicile.Text,
                };
                PartnerFacade.UpdatePartner(mPartner);
                this.CleanDatosFilaSeleccionadaDataGridView();
                this.CargarDataGridViewSocios();

                MessageBox.Show("Socio modifcado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BusinessException exception)
            {
                if (tbFirstName.Text == "")
                {
                    FirstNameError.Visible = true;
                }
                if (tbLastName.Text == "")
                {
                    LastNameError.Visible = true;
                }
                if (mtDocumentNumber.Text.Length == 10)
                {
                    for (int indice = 0; indice < mtDocumentNumber.Text.Length; indice++)
                    {
                        if (mtDocumentNumber.Text[indice] == ' ')
                        {
                            DocumentNumberError.Visible = true;
                            indice = mtDocumentNumber.Text.Length;
                        }
                    }
                }
                else
                {
                    DocumentNumberError.Visible = true;
                }
                if (tbDomicile.Text == "")
                {
                    DomicileError.Visible = true;
                }
                if (tbTelephone.Text == "")
                {
                    TelephoneError.Visible = true;
                }
                if (tbValueQuota.Text == "")
                {
                    ValueQuotaError.Visible = true;
                }
                if (tbCollectDomicile.Text == "")
                {
                    CollectDomicileError.Visible = true;
                }
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
            catch (NullReferenceException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
            catch (FormatException)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = "El formato ingresado es invalidoa";
            }
            catch (InvalidFormatException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
            catch (PartnerException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
                DocumentNumberError.Visible = true;
            }
            catch (QuotaException exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
                ValueQuotaError.Visible = true;
            }
            catch (Exception exception)
            {
                labelMessaError.Visible = true;
                labelMessaError.Text = exception.Message;
            }
        }

        private void bRestore_Click(object sender, EventArgs e)
        {
            this.CargarDatosFilaSelccionadaDataGridView(Convert.ToInt32(tbIdPartnerSelected.Text));
        }        
    }
}
