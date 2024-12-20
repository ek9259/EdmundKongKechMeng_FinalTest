namespace EdmundKongKechMeng_FinalTest.MobileApp.Views;

public partial class Question2Page : ContentPage
{
	public Question2Page()
	{
		InitializeComponent();
	}

    private void PhoneEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        // Validate phone number: only numeric and 10 characters
        PhoneErrorLabel.IsVisible = !IsPhoneNumberValid(e.NewTextValue);
        UpdateRegisterButtonState();
    }

    private void PasswordEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        // Validate password: length greater than 5
        PasswordErrorLabel.IsVisible = e.NewTextValue.Length <= 5;
        UpdateRegisterButtonState();
    }

    private void TermsAndConditionsCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        UpdateRegisterButtonState();
    }

    private void UpdateRegisterButtonState()
    {
        // Enable the register button if all validations pass
        bool isPhoneValid = !PhoneErrorLabel.IsVisible;
        bool isPasswordValid = !PasswordErrorLabel.IsVisible;
        bool isCheckboxChecked = TermsAndConditionsCheckbox.IsChecked;

        RegisterButton.IsEnabled = isPhoneValid && isPasswordValid && isCheckboxChecked;
        RegisterButton.BackgroundColor = RegisterButton.IsEnabled ? Colors.Blue : Colors.LightBlue;
    }

    private bool IsPhoneNumberValid(string phoneNumber)
    {
        // Check if the phone number contains only digits and is 10 characters long
        return !string.IsNullOrEmpty(phoneNumber) &&
               phoneNumber.Length == 10 &&
               long.TryParse(phoneNumber, out _);
    }

}