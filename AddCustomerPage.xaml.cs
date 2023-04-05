namespace SalesPro;

public partial class AddCustomerPage : ContentPage
{
	public AddCustomerPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

            Fname.Text = "";
            Lname.Text = "";
            Addr.Text = "";
            Pnum.Text = "";
            Picker.Date = DateTime.Now;
            YN.Text = "";
            notes.Text = "";
            await DisplayAlert("Customer Added", "You have successfully added a new customer.", "OK");

		}
		catch (Exception ex) 
		{
			await DisplayAlert("Error", ex.Message, "OK");
		}
		
    }
}