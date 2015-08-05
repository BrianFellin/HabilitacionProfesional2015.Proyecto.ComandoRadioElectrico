using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.WinForms.Adapter;
using ComandoRadioElectrico.WinForms.Facade;
using ComandoRadioElectrico.WinForms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandoRadioElectrico.WinForms.Views
{
    public partial class PantallaCobradores : Form
    {
        public PantallaCobradores()
        {
            InitializeComponent();
        }

        private void PantallaCobradores_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCBDocumentType();
                LoadDGOfficer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCBDocumentType()
        {
            cbDocumentType.DataSource = DocumentTypeFacade.GetAll();
        }

        private void LoadDGOfficer()
        {
            FindEntityResultDTO<OfficerDTO> mResult = OfficerFacade.Search("", 0);

            dgOfficer.DataSource = mResult.Result;
        }
        
        private void bCancel_Click(object sender, EventArgs e)
        {
            CleanScreen();
            bNew.Enabled = true;
            bDelete.Enabled = false;
            bUpdate.Enabled = false;
            bCancel.Enabled = false;
            cbDocumentType.SelectedValue = 1;
        }

        private void CleanScreen()
        {
            tbId.Text = String.Empty;
            tbFirstName.Text = String.Empty;
            tbLastName.Text = String.Empty;
            tbDomicile.Text = String.Empty;
            tbDocumentNumber.Text = String.Empty;
            tbPhone.Text = String.Empty;
            tbDomicile.Text = String.Empty;
            tbDateIn.Text = String.Empty;
            tbDateLower.Text = String.Empty;
            cbDocumentType.SelectedValue = 1;
            ClearErrors();
        }

        private void ClearErrors()
        {
        //    labelError.Visible = false;
         //   codeError.Visible = false;
         //   nameError.Visible = false;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearErrors();  
                OfficerDTO mOfficer = new OfficerDTO
                {                    
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    DocumentNumber = tbDocumentNumber.Text,
                    DocumentTypeId = Convert.ToInt32(cbDocumentType.SelectedValue),
                    Domicile = tbDomicile.Text,
                    Telephone = tbPhone.Text,
                    StartDate = DateTime.Today,
                    FinishDate = null
                };
                OfficerFacade.CreateOfficer(mOfficer);
                MessageBox.Show("Cobrador creado satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Recargo la lista de cuentas contables
                LoadDGOfficer();
                CleanScreen();
            }
            catch (BusinessException ex)
            {
                //if ( .Text == string.Empty)
                //{
                //    codeError.Visible = true;
                //}
                //else
                //{
                //    if (tbName.Text == string.Empty)
                //    {
                //        nameError.Visible = true;
                //    }
                //    else
                //    {
                //        if (tbAmount.Text == string.Empty)
                //        {
                //            amountError.Visible = true;
                //        }
                //        else
                //        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       // }
                  //  }

                //}
            }
           // catch (FormatException)
           // {
               // labelError.Visible = true;
           // }
            catch (DataBaseException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mAnswer = MessageBox.Show("¿Está seguro que desea eliminar dicho cobrador?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mAnswer == DialogResult.Yes)
                {
                    DeletedEntityDTO mDeletedEntity = new DeletedEntityDTO
                    {
                        Id = Convert.ToInt32(tbId.Text)
                    };

                   // OfficerFacade.DeleteOfficer(mDeletedEntity);

                    MessageBox.Show("Cobrador dado de baja satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Recargo la lista de cobrador
                    LoadDGOfficer();
                }
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataBaseException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ClearErrors();
                OfficerDTO mOfficer = new OfficerDTO
                {
                    Id = Convert.ToInt32(tbId.Text),
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    DocumentNumber = tbDocumentNumber.Text,
                    DocumentTypeId = Convert.ToInt32(cbDocumentType.SelectedValue),
                    Domicile = tbDomicile.Text,
                    Telephone = tbPhone.Text,
                    StartDate = Convert.ToDateTime(tbDateIn.Text)
                };

                OfficerFacade.UpdateOfficer(mOfficer);

                MessageBox.Show("Cobrador modificado satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Recargo la lista de cobradores
                LoadDGOfficer();
                CleanScreen();
            }
            //catch (FormatException ex)
            //{
            //    if (tbAmount.Text != string.Empty)
            //    {
            //        labelError.Visible = true;
            //    }
            //}
            catch (BusinessException ex)
            {
            //    if (tbCode.Text == string.Empty)
            //    {
            //        codeError.Visible = true;
            //    }
            //    else
            //    {
            //        if (tbName.Text == string.Empty)
            //        {
            //            nameError.Visible = true;
            //        }
            //        else
            //        {
            //            if (tbAmount.Text == string.Empty)
            //            {
            //                amountError.Visible = true;
            //            }
            //            else
            //            {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  //      }
                 //   }

                //}
            }
            catch (DataBaseException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void dgOfficer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgOfficer.Columns[e.ColumnIndex].Name.Equals("Selection"))
            {
                if (dgOfficer.RowCount > 0)
                {
                    bUpdate.Enabled = true;
                    bDelete.Enabled = true;
                    bCancel.Enabled = true;
                    bNew.Enabled = false;
                    CleanScreen();
                    OfficerDTO mRow = (OfficerDTO) dgOfficer.CurrentRow.DataBoundItem;

                    tbId.Text = Convert.ToString(mRow.Id);
                    tbFirstName.Text = mRow.FirstName;
                    tbDocumentNumber.Text = mRow.DocumentNumber;
                    tbLastName.Text = mRow.LastName;
                    tbDomicile.Text = mRow.Domicile;
                    tbPhone.Text = mRow.Telephone;
                    tbDateIn.Text = Convert.ToString(mRow.StartDate);
                    cbDocumentType.SelectedValue = mRow.DocumentTypeId;
                }
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valido que solo se ingresen numeros
            e.Handled = Miscellaneous.ValidateTelephone(e);
        }      
    }
}
