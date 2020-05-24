using System;
using System.Diagnostics;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of Table.
	/// </summary>
	public class Table
	{
		private int id;
		private bool available;
		private bool discount;
		private bool finished;
		private string userClient;
		private string userEmployee;
		private string methodPayment;
		private int hours;
		private int minutes;
		private Stopwatch timeElapsed;
		double total;
		private DataBase database;
		
		public Table(int _id)
		{
			id = _id;
			available = true;
			discount = false;
			finished = false;
			hours = 0;
			minutes = 0;
			timeElapsed = new Stopwatch();
			database = new DataBase();
		}
		public int GetId()
		{
			return id;
		}
		public bool IsAvailable()
		{
			return available;
		}
		public bool IsDiscount()
		{
			return discount;
		}
		public void BeginGame(int _hours, int _minutes, string _userClient, string _methodPayment, bool _discount)
		{
			available = false;
			hours = _hours;
			minutes = _minutes;
			userClient = _userClient;
			methodPayment = _methodPayment;
			discount = _discount;
			
			timeElapsed.Start();
		}
		public void Clear()
		{
			available = true;
			discount = false;
			finished = false;
			hours = 0;
			minutes = 0;
			methodPayment = "";
			
			userClient = "";
			userEmployee = "";
		}
		public void SetEmployee(string _employee)
		{
			userEmployee = _employee;
		}
		public string CalculateTimeElapsed()
		{
			string time = "";
			if (timeElapsed.Elapsed.Hours < 10)
				time += '0';
			time += timeElapsed.Elapsed.Hours.ToString() + ':';
			if (timeElapsed.Elapsed.Minutes < 10)
				time += '0';
			time += timeElapsed.Elapsed.Minutes.ToString() + ':';
			if (timeElapsed.Elapsed.Seconds < 10) 
				time += '0';
			time += timeElapsed.Elapsed.Seconds.ToString();
			return time;
		}
		public string CalculateTimeRemaining()
		{
			string time = "";
			var t = new TimeSpan(hours, minutes, 1);
			t = t.Subtract(timeElapsed.Elapsed);
			
			if(t.Hours <= 0 && t.Minutes <= 0 && t.Seconds <= 0){
				return "00:00:00";
			}
			
			if (t.Hours < 10)
				time += '0';
			time += t.Hours.ToString() + ':';
			if (t.Minutes < 10)
				time += '0';
			time += t.Minutes.ToString() + ':';
			if (t.Seconds < 10) 
				time += '0';
			time += t.Seconds.ToString();
			return time;
		}
		public string CalculateCost()
		{
			total = database.GetPriceTable();
			double mul = ((double)timeElapsed.Elapsed.Minutes * 55)/60;
			total *= (double)timeElapsed.Elapsed.Hours;
			total += mul;
			total = Math.Round(total, 2);
			return '$' + total.ToString();
		}
		public void Stop()
		{
			timeElapsed.Reset();
		}
		public bool IsFinished()
		{
			return finished;
		}
		public void SetFinished()
		{
			finished = true;
		}
		public void SaveRegisterInDB()
		{
			database.InsertTable(userEmployee, userClient, CalculateTimeElapsed(), float.Parse(CalculateCost().Substring(1)), methodPayment);
			if (database.VerifyExistenceString(userClient, "CLAVE", "clientes")) {
				database.UpdateHrsClient(userClient, int.Parse(CalculateTimeElapsed().Substring(0,2)));
			}
		}
	}
}
