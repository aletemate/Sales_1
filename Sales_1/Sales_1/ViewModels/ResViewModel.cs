
namespace Sales_1.ViewModels
{
    using Common.Models;
    using GalaSoft.MvvmLight.Command;
    using Plugin.Media;
    using Plugin.Media.Abstractions;
    using Helpers;
    using Services;
    using System;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class ResViewModel : BaseViewModel
    {
        #region Attributes
        private Product product;

        
        #endregion

        #region Properties
        public Product Product
        {
            get { return this.product; }
            set { this.SetValue(ref this.product, value); }
        }
        
        
        #endregion

        #region Constructors
        public ResViewModel(Product product)
        {
            this.product = product;
        }
        #endregion


        #region Commands
       
        #endregion
    }
}
