using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Parties;
using BusinessLogic.Suppliers;

namespace SIMS.WinForms.Suppliers
{
    public partial class ctrSupplierInfo : UserControl
    {
        public ctrSupplierInfo()
        {
            InitializeComponent();
        }

        private clsSupplier _Supplier;
        public clsSupplier Supplier
        {
            get
            {
                return _Supplier;
            }
            set
            {
                if (value is null)
                {
                    return;
                }

                _Supplier = value;
                lblNotes.Text = string.IsNullOrEmpty(_Supplier.Notes) ? "N/A" : _Supplier.Notes;

                switch (_Supplier.PartyInfo.PartyCategory)
                {
                    case clsParty.enPartyCategory.Person:
                        ctrOrganizationInfo.Visible = false;
                        ctrPersonInfo.Visible = true;
                        ctrPersonInfo.Person = _Supplier.PartyInfo as clsPerson;
                        lblNotesTitle.Location = new Point(lblNotesTitle.Location.X, 245);
                        lblNotes.Location = new Point(lblNotes.Location.X, 245);
                        this.Size = new Size(this.Width, 265);
                        break;
                    case clsParty.enPartyCategory.Organization:
                        ctrPersonInfo.Visible = false;
                        ctrOrganizationInfo.Visible = true;
                        ctrOrganizationInfo.Organization = _Supplier.PartyInfo as clsOrganization;
                        lblNotesTitle.Location = new Point(lblNotesTitle.Location.X, 180); 
                        lblNotes.Location = new Point(lblNotes.Location.X, 180);
                        this.Size = new Size(this.Width, 200);
                        break;
                    default:
                        this.Visible = false;
                        break;
                }
            }
        }

    }
}
