using System;
using System.Collections.Generic;
using HolaMoviles.Servicios;
using ProyectoXamarin.Clases;
using Xamarin.Forms;

namespace HolaMoviles
{
	public partial class DetallePage : ContentPage
	{
		public DetallePage()
		{
			InitializeComponent();
		}

		public DetallePage(Perro perro) 
		{
            InitializeComponent();
		}
	}
}
