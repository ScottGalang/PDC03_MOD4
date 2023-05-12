using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();
            SetupData();
            listView.ItemsSource = contacts;
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Scott Galang",
                Age = 20,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Kat Galang",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Katzera Galang",
                Age = 22,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Zera Galang",
                Age = 23,
                Occupation = "Student",
                Country = "Philippines"

            });

            contacts.Add(new Contacts
            {
                Name = "Rylee Galang",
                Age = 24,
                Occupation = "Tester",
                Country = "Philippines"

            });
        }
    }
}