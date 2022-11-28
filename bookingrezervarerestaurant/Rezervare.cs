using System;
using System.Collections.Generic;
using System.Text;

namespace prjbookingrezervarerestaurant.bookingrezervarerestaurant
{
	public class Rezervare
	{
		public int idrezervare;
		public int idclient;
		public DateTime datarezervarii;
		public DateTime dataexpirarii;
		public bool isExpired;
	}
}
