using System;
using System.Windows.Input;
using Microsoft.Maui; using Microsoft.Maui.Controls;

namespace MauiPOC.View
{
    public partial class WorkingWithMapsPage : ContentPage
    {
        public ICommand NavigateCommand { get; set; }

        public WorkingWithMapsPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }
    }
}