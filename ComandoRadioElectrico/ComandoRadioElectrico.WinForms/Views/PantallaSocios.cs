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
        private void LoadComboBoxDocumentType()
        {
            //Se llamam a la fachada y se completa con la lista de tipos de documentos.
            cbDocumentType.DataSource = DocumentTypeFacade.GetAll();
        }

        /// <summary>
        /// Este metodo permite llenar el ComboBox de los Cobradores.
        /// </summary>
        private void LoadComboBoxOfficer()
        {
            IList<OfficerComboBoxAdapter> mListaRelleno = new List<OfficerComboBoxAdapter>();
            foreach (OfficerDTO officer in OfficerFacade.GetAllOfficer())
            {
                mListaRelleno.Add(new OfficerComboBoxAdapter
                {
                    Id = officer.Id,
                    Name = officer.FirstName + officer.LastName                  
                });
            }
            cbOfficer.DataSource = mListaRelleno;
        }

        private void LoadComboBoxDel()
        {
            IList<CollectDayComboBoxAdapter> mListaRellenoDel = new List<CollectDayComboBoxAdapter>();
            for (int indice = 1; indice <= 31; indice++)
            {
                mListaRellenoDel.Add(new CollectDayComboBoxAdapter { Id = indice });
            }
            cbDel.DataSource = mListaRellenoDel;
        }

        private void LoadComboBoxAl()
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
        private void LoadDataGridViewPartner()
        {
            IList<PartnerGridViewAdapter> mListaRelleno = new List<PartnerGridViewAdapter>();

            foreach (PartnerDTO partner in PartnerFacade.Search("", Convert.ToInt32(tbPage.Text) - 1).Result)
            {
                mListaRelleno.Add(new PartnerGridViewAdapter
                {
                    Id = partner.Id,
                    FirstName = partner.FirstName,
                    LastName = partner.LastName,
                    Document = partner.DocumentNumber,
                    Domicile = partner.Domicile
                });
            }
            DataGridViewPartner.DataSource = mListaRelleno;

        }

        /// <summary>
        /// Metodo que se ejecuta cuando se carga la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PantallaSocios_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxAl();
            this.LoadComboBoxDel();            
            this.LoadComboBoxDocumentType();
            this.LoadComboBoxOfficer();
            this.LoadDataGridViewPartner();
            this.cbQuotaRegime.SelectedIndex = 0;
        }

        /// <summary>
        /// Obtiene la fila seleccionada cuando se hace clic en el botón "Seleccionar" de la fila. Saca el Id
        /// de la fila y llama al metodo que carga los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewPartner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DataGridViewPartner.Columns[e.ColumnIndex].Name.Equals("Seleccionar"))
            {
                PartnerGridViewAdapter row = (PartnerGridViewAdapter)DataGridViewPartner.CurrentRow.DataBoundItem;
                LoadDateRowSelctDataGridView(row.Id);
                tbIdPartnerSelected.Text = row.Id.ToString();
            }
        }

        /// <summary>
        /// Buscar un socio y carga sus datos en la pantalla.
        /// </summary>
        /// <param name="pIdSocio"></param>
        private void LoadDateRowSelctDataGridView(int pIdSocio)
        {
            bNew.Visible = false;
            bRestore.Visible = true;
            bUpdate.Enabled = true;
            bCancel.Enabled = true;
            bDelete.Enabled = true;

            PartnerDTO mPartner = PartnerFacade.Get(pIdSocio);
            tbFirstName.Text = mPartner.FirstName;
            tbLastName.Text = mPartner.LastName;            
            tbCollectDomicile.Text = mPartner.CollectDomicile;
            mtDocumentNumber.Text = mPartner.DocumentNumber;
            tbDomicile.Text = mPartner.Domicile;
            tbStartDate.Text = mPartner.StarDate.ToString();
            tbTelephone.Text = mPartner.Telephone;
            tbValueQuota.Text = mPartner.ValueQuota.ToString();
            cbDocumentType.SelectedValue = mPartner.DocumentTypeId;
            cbQuotaRegime.SelectedIndex = mPartner.QuotaRegime - 1;
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
        private void CleanDataRowSelectDataGridView()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            LoadComboBoxAl();
            LoadComboBoxDel();
            tbCollectDomicile.Text = "";
            mtDocumentNumber.Text = "";
            tbDomicile.Text = "";
            tbStartDate.Text = "";
            tbTelephone.Text = "";
            tbValueQuota.Text = "";
            cbDocumentType.SelectedValue = 1;
            cbQuotaRegime.SelectedIndex = 0;
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
            CleanDataRowSelectDataGridView();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.CleanErrorElemnts();              
                OfficerDTO mOfficer = new OfficerDTO
                {
                    Id = Convert.ToInt32(cbOfficer.SelectedValue)
                };

                PartnerDTO mPartner = new PartnerDTO
                {
                    FirstName = tbFirstName.Text.ToString(),
                    LastName = tbLastName.Text,
                    DocumentTypeId = Convert.ToInt32(cbDocumentType.SelectedValue),
                    DocumentNumber = mtDocumentNumber.Text,
                    Domicile = tbDomicile.Text,
                    Telephone = tbTelephone.Text,
                    Officer = mOfficer,
                    ValueQuota = Convert.ToSingle(tbValueQuota.Text),
                    CollectDay = cbDel.SelectedValue.ToString() + "-" + cbAl.SelectedValue.ToString(),
                    CollectDomicile = tbCollectDomicile.Text,
                    QuotaRegime = Convert.ToInt32(cbQuotaRegime.SelectedItem.ToString()),
                    StarDate = DateTime.Today,
                    FinishDate = null
                };
                PartnerFacade.CreatePartner(mPartner);
                MessageBox.Show("Socio creado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CleanDataRowSelectDataGridView();
                this.LoadDataGridViewPartner();
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
                    CleanDataRowSelectDataGridView();
                    this.LoadDataGridViewPartner();
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
                OfficerDTO mOfficer = new OfficerDTO
                {
                    Id = Convert.ToInt32(cbOfficer.SelectedValue)
                };
                PartnerDTO mPartner = new PartnerDTO
                {
                    Id = Convert.ToInt32(tbIdPartnerSelected.Text),
                    FirstName = tbFirstName.Text.ToString(),
                    LastName = tbLastName.Text,
                    DocumentTypeId = Convert.ToInt32(cbDocumentType.SelectedValue),
                    DocumentNumber = mtDocumentNumber.Text,
                    Domicile = tbDomicile.Text,
                    Telephone = tbTelephone.Text,
                    Officer = mOfficer,
                    ValueQuota = Convert.ToSingle(tbValueQuota.Text),
                    QuotaRegime = Convert.ToInt32(cbQuotaRegime.SelectedItem.ToString()),
                    CollectDay = cbDel.SelectedValue.ToString() + "-" + cbAl.SelectedValue.ToString(),
                    CollectDomicile = tbCollectDomicile.Text,
                    StarDate = Convert.ToDateTime(tbStartDate.Text)
                };
                PartnerFacade.UpdatePartner(mPartner);
                this.CleanDataRowSelectDataGridView();
                this.LoadDataGridViewPartner();

                MessageBox.Show("Socio modificado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                labelMessaError.Text = "El formato ingresado es invalido";
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
            this.LoadDateRowSelctDataGridView(Convert.ToInt32(tbIdPartnerSelected.Text));
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
            IList<PartnerGridViewAdapter> mListaRelleno = new List<PartnerGridViewAdapter>();

            foreach (PartnerDTO partner in PartnerFacade.Search(tbSearch.Text.ToString(), 0).Result)
            {
                mListaRelleno.Add(new PartnerGridViewAdapter
                {
                    Id = partner.Id,
                    FirstName = partner.FirstName,
                    LastName = partner.LastName,
                    Document = partner.DocumentNumber,
                    Domicile = partner.Domicile
                });
            }
            DataGridViewPartner.DataSource = mListaRelleno;

        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPage.Text) == 1)
            {
                bBack.Enabled = true;
            }
            string mText = "";
            if (tbSearch.Text != string.Empty)
            {
                mText = tbSearch.Text;
            }

            tbPage.Text = (Convert.ToInt32(tbPage.Text) + 1).ToString();
            FindEntityResultDTO<PartnerDTO> mResult = PartnerFacade.Search(mText, Convert.ToInt32(tbPage.Text) - 1);
            IList<PartnerGridViewAdapter> mListaRelleno = new List<PartnerGridViewAdapter>();

            foreach (PartnerDTO partner in mResult.Result)
            {
                mListaRelleno.Add(new PartnerGridViewAdapter
                {
                    Id = partner.Id,
                    FirstName = partner.FirstName,
                    LastName = partner.LastName,
                    Document = partner.DocumentNumber,
                    Domicile = partner.Domicile
                });
            }
            DataGridViewPartner.DataSource = mListaRelleno;       
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPage.Text) - 1 == 1)
            {
                bBack.Enabled = false;
            }
            string mText = "";
            if (tbSearch.Text != string.Empty)
            {
                mText = tbSearch.Text;
            }
            tbPage.Text = (Convert.ToInt32(tbPage.Text) - 1).ToString();
            FindEntityResultDTO<PartnerDTO> mResult = PartnerFacade.Search(mText, Convert.ToInt32(tbPage.Text) - 1);
            IList<PartnerGridViewAdapter> mListaRelleno = new List<PartnerGridViewAdapter>();

            foreach (PartnerDTO partner in mResult.Result)
            {
                mListaRelleno.Add(new PartnerGridViewAdapter
                {
                    Id = partner.Id,
                    FirstName = partner.FirstName,
                    LastName = partner.LastName,
                    Document = partner.DocumentNumber,
                    Domicile = partner.Domicile
                });
            }
            DataGridViewPartner.DataSource = mListaRelleno;

            if (mResult.TotalRecords < 10)
            {
                bNext.Enabled = true;
            }
        }
    }
}
