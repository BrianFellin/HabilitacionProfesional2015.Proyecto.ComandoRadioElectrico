using ComandoRadioElectrico.Core.DTO;
using ComandoRadioElectrico.WinForms.Adapter;
using ComandoRadioElectrico.WinForms.Facade;
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
            FindEntityResultDTO<OfficerDTO> mResult = OfficerFacade.Search("", Convert.ToInt32(tbPage.Text) - 1);            
            IList<OfficerGridViewAdapter> mListaRelleno = new List<OfficerGridViewAdapter>();
            foreach (OfficerDTO mOfficer in mResult.Result)
            {
                mListaRelleno.Add(new OfficerGridViewAdapter
                {
                    Id = mOfficer.Id,
                    FirstName = mOfficer.Person.FirstName,
                    LastName = mOfficer.Person.LastName,
                    Document = mOfficer.Person.DocumentNumber,
                    Domicile = mOfficer.Person.Domicile,
                    Codigo = mOfficer.Code
                    
                });
            }
            dgOfficer.DataSource = mListaRelleno;
        }
    }
}
