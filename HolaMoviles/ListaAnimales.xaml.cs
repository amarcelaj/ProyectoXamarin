using System;
using System.Collections.ObjectModel;
using HolaMoviles.Servicios;
using Plugin.Connectivity;
using ProyectoXamarin.Clases;
using Xamarin.Forms;

namespace HolaMoviles
{
	public partial class ListaAnimales
    {
		public ApiService DataService { get; } = new ApiService();
		public ObservableCollection<object> Items { get; set; } = new ObservableCollection<object>();
		public Command AgregarCommand { get; set; }
		public Command RefrescarCommand { get; set; }

        public ListaAnimales()
		{
			BindingContext = this;

			AgregarCommand = new Command(() => {
				Items.Add(new Perro
				{
					Mensaje = $"Perro {(Items.Count + 1)}"
				}
				);
			});

			IsBusy = true;
			
			InitializeComponent();

			ListViewDatos.ItemSelected += ListViewDatos_ItemSelected;
		}

		void ListViewDatos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var selectedItem = e.SelectedItem;

			var perro = selectedItem as Perro;

			Navigation.PushAsync(
				new DetallePage(perro)
				);
		}		

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}
	}
}
