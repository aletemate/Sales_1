
namespace Sales_1.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Sales_1.Views;
    using Xamarin.Forms;

    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }
        public AddProductViewModel AddProduct { get; set; }
        public EditProductViewModel EditProduct  { get; set; }
        public LoginViewModel Login { get; set; }
        public ResViewModel Res { get; set; }

        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }

        public MainViewModel()
        {
            instance = this;
           // this.Products = new ProductsViewModel();
        }

       

        public ICommand AddProductCommand
        {
            get
            {

                return new RelayCommand(GoToAddProduct);
            }
        }


        private async void GoToAddProduct()
        {
            this.AddProduct = new AddProductViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AddProductPage());
        }
    }
}
