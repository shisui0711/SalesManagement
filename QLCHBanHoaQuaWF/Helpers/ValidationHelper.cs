using QLCHWF.Views;
using System.ComponentModel.DataAnnotations;

namespace QLCHWF.Helpers;

public class ValidationHelper
{
    public static bool IsValid(object target, IValidateControl validateControl)
    {
        var errors = new List<ValidationResult>();
        bool isValid =
            Validator.TryValidateObject(target, new ValidationContext(target), errors, true);
        if (!isValid)
        {
            validateControl.ShowMessage(errors.First().ErrorMessage);
            validateControl.Focus(errors.SelectMany(x => x.MemberNames).First());
        }
        return isValid;
    }
}