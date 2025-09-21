using System.Collections.Generic;

namespace BusinessLogic
{
    public class clsValidationResult
    {
        public bool IsValid { get; set; }
        public List<clsValidationError> Errors { get; }

        public clsValidationResult()
        {
            IsValid = true;
            Errors = new List<clsValidationError>();
        }

        public void AddError(string FieldName, string errorMessage)
        {
            IsValid = false;
            Errors.Add(new clsValidationError(FieldName, errorMessage));
        }

        public List<string> ConvertErrorsListToStringList()
        {
            List<string> errorsList = new List<string>();

            foreach (clsValidationError error in Errors)
            {
                errorsList.Add(error.FieldName + " : " + error.ErrorMessage);
            }

            return errorsList;
        }

        public class clsValidationError
        {
            public string FieldName { get; set; }
            public string ErrorMessage { get; set; }

            public clsValidationError(string fieldName, string errorMessage)
            {
                FieldName = fieldName;
                ErrorMessage = errorMessage;
            }
        }

    }
}
