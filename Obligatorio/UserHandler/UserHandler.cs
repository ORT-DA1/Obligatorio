using Domain;

namespace Logic
{
    public class UserHandler
    {
        private static void ApplyValidations(User user)
        {
            DataValidation.NameAndSurnameValidate(user.Name, user.Surname);
        }
    }
}
