using System;
using System.Collections.Generic;
using System.Text;

namespace prjbookingrezervarerestaurant.bookingrezervarerestaurant
{
	public class Restaurant
	{
		public Locatie locatia;
		public List < Masa > mese;
		public List <Persoana> proprietari;
		public List <Persoana > personal;
		public Dimension dimensiune;
		public List <Rezervare> listaderezervari;
		public string denumire;
		public List <Reteta> meniu;

		public void makeReservation()
		{
			throw new NotImplementedException();
		}

		public void deleteReservation()
		{
			throw new NotImplementedException();
		}

		public void alert()
		{
			throw new NotImplementedException();
		}
	}
}
