using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.Core.Exceptions;
using ComandoRadioElectrico.WinForms.Facade;
using ComandoRadioElectrico.WinForms.Utils;
using System;
using System.Windows.Forms;

namespace ComandoRadioElectrico.WinForms.Views
{
    public partial class PantallaCuentas : Form
    {
        public PantallaCuentas()
        {
            InitializeComponent();
        }

        private void PantallaCuentas_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAccountantAccount();
                LoadCbAccountType();
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

        private void LoadAccountantAccount()
        {
            FindEntityResultDTO<AccountantAccountDTO> mResult = AccountantAccountFacade.Search("", Convert.ToInt32(tbPage.Text)-1);
            dgAccountantAccount.DataSource = mResult.Result;
        }

        private void LoadCbAccountType()
        {
            cbAccountType.DataSource = AccountTypeFacade.GetAll();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valido que solo se ingresen numeros
            e.Handled = Miscellaneous.ValidateAmount(e);           
            //Si se ingresa "," la cambio por "." ya que los decimales se separan por "."
           if (e.KeyChar == (',')){
             e.Handled = true;
             SendKeys.Send(".");   
           }
         }        
      
        private void bNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearErrors();
                AccountantAccountDTO mAccountantAccount = new AccountantAccountDTO
                {
                    Name = tbName.Text,
                    Code = tbCode.Text,
                    AccountTypeId = Convert.ToInt32(cbAccountType.SelectedValue),
                    Description = tbDescription.Text,
                    Amount = Convert.ToSingle(tbAmount.Text)
                };
                AccountantAccountFacade.CreateAccountantAccount(mAccountantAccount);
                MessageBox.Show("Cuenta creada satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Recargo la lista de cuentas contables
                LoadAccountantAccount();                
                CleanScreen();
            }            
            catch (BusinessException ex)
            {
                if (tbCode.Text == string.Empty)
                {
                    codeError.Visible = true;
                }
                else
                {
                    if (tbName.Text == string.Empty)
                    {
                        nameError.Visible = true;
                    }
                    else
                    {
                        if (tbAmount.Text == string.Empty)
                        {
                            amountError.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
            catch (FormatException)
            {
                labelError.Visible = true;
            }
            catch (DataBaseException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult mAnswer = MessageBox.Show("¿Está seguro que desea eliminar dicha cuenta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mAnswer == DialogResult.Yes)
                {
                    DeletedEntityDTO mDeletedEntity = new DeletedEntityDTO
                    {
                        Id = Convert.ToInt32(tbId.Text)
                    };

                    AccountantAccountFacade.DeleteAccountantAccount(mDeletedEntity);

                    MessageBox.Show("Cuenta eliminada satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Recargo la lista de cuentas contables
                    LoadAccountantAccount();
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
                AccountantAccountDTO mAccountantAccount = new AccountantAccountDTO
                {
                    Id = Convert.ToInt32(tbId.Text),
                    Name = tbName.Text,
                    Code = tbCode.Text,
                    AccountTypeId = Convert.ToInt32(cbAccountType.SelectedValue),
                    Description = tbDescription.Text,
                    Amount = Convert.ToSingle(tbAmount.Text)
                };

              AccountantAccountFacade.UpdateAccountantAccount(mAccountantAccount);

              MessageBox.Show("Cuenta modificada satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //Recargo la lista de cuentas contables
              LoadAccountantAccount();
              CleanScreen();
            }
            catch (FormatException ex)
            {
                if (tbAmount.Text != string.Empty)
                {
                    labelError.Visible = true;
                }
            }
            catch (BusinessException ex)
            {
                if (tbCode.Text == string.Empty)
                {
                    codeError.Visible = true;
                }
                else
                {
                    if (tbName.Text == string.Empty)
                    {
                        nameError.Visible = true;
                    }
                    else
                    {
                        if (tbAmount.Text == string.Empty)
                        {
                            amountError.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (DataBaseException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgAccountantAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgAccountantAccount.Columns[e.ColumnIndex].Name.Equals("Selection"))
            {
                if (dgAccountantAccount.RowCount > 0)
                {                    
                    bUpdate.Enabled = true;
                    bDelete.Enabled = true;
                    bCancel.Enabled = true;
                    tbAmount.Enabled = false;
                    bNew.Enabled = false;
                    CleanScreen();                                        
                    AccountantAccountDTO row = (AccountantAccountDTO)dgAccountantAccount.CurrentRow.DataBoundItem;

                    tbId.Text = Convert.ToString(row.Id);
                    tbName.Text = row.Name;
                    tbDescription.Text = row.Description;
                    tbCode.Text = row.Code;
                    tbAmount.Text = Convert.ToString(row.Amount);
                    cbAccountType.SelectedValue = row.AccountTypeId;

                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            CleanScreen();
            bNew.Enabled = true;
            bDelete.Enabled = false;
            bUpdate.Enabled = false;
            bCancel.Enabled = false;
            tbAmount.Enabled = true;
        }     

        private void CleanScreen()
        {            
            tbId.Text = String.Empty;
            tbAmount.Text = String.Empty;
            tbCode.Text = String.Empty;
            tbDescription.Text = String.Empty;
            tbName.Text = String.Empty;
            ClearErrors();
        }

        private void ClearErrors()
        {
            labelError.Visible = false;
            codeError.Visible = false;
            nameError.Visible = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            FindEntityResultDTO<AccountantAccountDTO> mResult = AccountantAccountFacade.Search(tbSearch.Text.ToString(),0);
            dgAccountantAccount.DataSource = mResult.Result;

        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPage.Text) == 1)
            {
                bBack.Enabled = true;
            }
            string mText = "";
            if (tbSearch.Text != string.Empty){
                mText = tbSearch.Text;
            }

            tbPage.Text = (Convert.ToInt32(tbPage.Text) + 1).ToString();
            FindEntityResultDTO<AccountantAccountDTO> mResult = AccountantAccountFacade.Search(mText, Convert.ToInt32(tbPage.Text)-1);
            dgAccountantAccount.DataSource = mResult.Result;            
            if (mResult.TotalRecords < 10)
            {
                bNext.Enabled = false;
            }

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPage.Text)- 1 == 1)
            {
                bBack.Enabled = false;
            }
            string mText = "";
            if (tbSearch.Text != string.Empty)
            {
                mText = tbSearch.Text;
            }
            tbPage.Text = (Convert.ToInt32(tbPage.Text) - 1).ToString();
            FindEntityResultDTO<AccountantAccountDTO> mResult = AccountantAccountFacade.Search(mText, Convert.ToInt32(tbPage.Text)-1);
            dgAccountantAccount.DataSource = mResult.Result;
            
            if (mResult.TotalRecords < 10)
            {
                bNext.Enabled = true;
            }
            
        }
    }
}
