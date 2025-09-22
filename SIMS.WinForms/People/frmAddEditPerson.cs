using System;
using System.Windows.Forms;
using BusinessLogic;
using DVLD.WinForms.Utils;
using static BusinessLogic.clsParty;

namespace SIMS.WinForms.People
{
    public partial class frmAddEditPerson : Form
    {
        public event Action<clsPerson> SaveSuccess;
        protected virtual void OnSaveSuccess()
        {
            SaveSuccess?.Invoke(_Person);
        }

        public enMode FormMode;
        public enPartyType? PersonType;
        private clsPerson _Person;

        public frmAddEditPerson()
        {
            InitializeComponent();
            ctrAddEditPerson.AttachErrorProvider(errorProvider);
            _Person = null;
            PersonType = null;
            FormMode = enMode.Add;
        }

        public frmAddEditPerson(clsPerson person)
        {
            InitializeComponent();
            ctrAddEditPerson.AttachErrorProvider(errorProvider);
            _Person = person;
            PersonType = null;
            FormMode = enMode.Edit;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            if (FormMode is enMode.Add)
            {
                switch (PersonType)
                {
                    case enPartyType.Supplier:
                        this.Text = lblFormTitle.Text = "إضافة مورد جديد";
                        break;
                    case enPartyType.ContactPerson:
                        this.Text = lblFormTitle.Text = "إضافة جهة تواصل جديدة";
                        break;
                    default:
                        this.Text = lblFormTitle.Text = "إضافة شخص جديد";
                        break;
                }
            }
            else
            {
                switch (PersonType)
                {
                    case enPartyType.Supplier:
                        this.Text = lblFormTitle.Text = "تعديل بيانات مورد";
                        break;
                    case enPartyType.ContactPerson:
                        this.Text = lblFormTitle.Text = "تعديل بيانات جهة التواصل";
                        break;
                    default:
                        this.Text = lblFormTitle.Text = "تعديل بيانات شخص";
                        break;
                }
            }

            if (FormMode is enMode.Edit)
            {
                if (_Person is null)
                {

                    this.Close();
                    clsFormMessages.ShowError("خطأ: لم يتم العثور على الشخص.");
                    return;
                }

                ctrAddEditPerson.Person = _Person;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!clsFormValidation.IsDataValid(ctrAddEditPerson, errorProvider))
            {
                clsFormMessages.ShowInvalidDataError();
                return;
            }

            if (clsFormMessages.Confirm("هل أنت متأكد من أنك تريد الحفظ ؟"))
            {
                _Person = ctrAddEditPerson.Person;
                OnSaveSuccess();
                this.Close();
            }
        }

    }
}
