/*
 Time: 04:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of DataBase.
	/// </summary>
	public class DataBase
	{
		private MySqlConnection conection = new MySqlConnection("server=localhost;password=;database=billar;User Id=root");
		private MySqlDataReader read;
		private MySqlCommand command;
		
		public DataBase()
		{
			command = new MySqlCommand();			
		}
		
		public MySqlConnection OpenConnection()
		{
			if(conection.State == ConnectionState.Closed)
				conection.Open();
			
			return conection;
		}
		public MySqlConnection CloseConnection()
		{
			if(conection.State == ConnectionState.Open)
				conection.Close();
			
			return conection;
		}
		public DataTable Show(String entity){
			var table2 = new DataTable();
			string line = "Select * From " + entity;
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			return table2;
		}
		public DataTable ShowCatalogPrices()
		{
			var table2 = new DataTable();
			string line = "select productos.ID, productos.NOMBRE, productos.CONTENIDO_NET, productos.MARCA, catalogoPrecio.PRECIO from productos inner join catalogoPrecio on productos.ID = catalogoPrecio.ID";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			return table2;
		}
		public void InsertClient(string key, string name, string lname, int totalhrs, int dischrs){
			command.Connection = OpenConnection();
			command.CommandText = "insert into clientes values ('"+key+"', '"+name+"', '"+lname+"', "+totalhrs+","+dischrs+")";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void InsertEmployee(string user, string key, string name, string lname, string phone, string pos){
			command.Connection = OpenConnection();
			command.CommandText = "insert into trabajadores values ('"+user+"', '"+key+"', '"+name+"', '"+lname+"','"+phone+"','"+pos+"')";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void InsertDiscount(string name, int free, int needed){
			command.Connection = OpenConnection();
			command.CommandText = "insert into horasdescuento values (NULL,'"+name+"',"+free+","+needed+")";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void InsertSale(string pay, string worker, int idprod, float price, int size){
			command.Connection = OpenConnection();
			command.CommandText = "insert into ventas values (NULL, current_date(), '"+pay+"', '"+worker+"', "+idprod+", "+price+", "+size+")";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void InsertProduct(string name, string contnet, string marca, float price)
		{
			//insertar producto
			command.Connection = OpenConnection();
			command.CommandText = "insert into productos values (NULL, '"+name+"', '"+contnet+"', '"+marca+"')";
			command.ExecuteNonQuery();
			CloseConnection();
			
			//insertar catalogo de precio
			command.Connection = OpenConnection();
			command.CommandText = "insert into catalogoPrecio values (NULL, "+price+")";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public bool VerifyExistenceString(string pkey, string attribute, string entity){
			command.Connection = OpenConnection();
			command.CommandText = "select * from "+entity+" where "+attribute+" = '"+pkey+"'";
			read = command.ExecuteReader();
			if(read.Read()){
				CloseConnection();
				return true;
			}
			CloseConnection();
			return false;
		}
		public bool VerifyExistenceInt(int pkey, string entity){
			command.Connection = OpenConnection();
			command.CommandText = "select * from "+entity+" where ID = "+pkey+"";
			read = command.ExecuteReader();
			if(read.Read()){
				CloseConnection();
				return true;
			}
			CloseConnection();
			return false;
		}
		public bool VerifyEmpVent(string usuario){ //verifica si un empleado tiene ventas asociadas
		
			command.Connection = OpenConnection();
			command.CommandText = "select * from trabajadores where USUARIO in (select TRABAJADOR from ventas where TRABAJADOR = '"+usuario+"')";
			read = command.ExecuteReader();
			if(read.Read()){
				CloseConnection();
				return true;
			}
			CloseConnection();
			return false;
		}
		public bool VerifyProdVent(int id) //verifica si un producto tiene ventas asociadas
		{
			command.Connection = OpenConnection();
			command.CommandText = "select * from ventas where PRODUCTO = "+id+"";
			read = command.ExecuteReader();
			if(read.Read()){
				CloseConnection();
				return true;
			}
			CloseConnection();
			return false;
		}
		public bool VerifyLogin(string usuario, string clave){
			command.Connection = OpenConnection();
			command.CommandText = "select * from trabajadores where USUARIO = '"+usuario+"' and CLAVE = '"+clave+"'";
			read = command.ExecuteReader();
			if(read.Read()){
				CloseConnection();
				return true;
			}
			CloseConnection();
			return false;
		}
		public bool VerifyLoginAdmin(string usuario, string clave){
			command.Connection = OpenConnection();
			command.CommandText = "select * from trabajadores where USUARIO = '"+usuario+"' and CLAVE = '"+clave+"' and POSICION = 'ADMINISTRADOR'";
			read = command.ExecuteReader();
			if(read.Read()){
				CloseConnection();
				return true;
			}
			CloseConnection();
			return false;
		}
		public float GetPriceProduct(int id)
		{
			float price;
			command.Connection = OpenConnection();
			command.CommandText = "select PRECIO from catalogoprecio where ID = "+id+"";
			read = command.ExecuteReader();
			if(read.Read()){
				price = float.Parse(read.GetString(0));
				CloseConnection();
				return price;
			}
			CloseConnection();
			return 0;
		}
		public void EditClient(string realk, string key, string name, string lname, int totalhrs, int dischrs)
		{
			command.Connection = OpenConnection();
			command.CommandText = "update clientes set CLAVE= '"+key+"', NOMBRE='"+name+"', APELLIDO='"+lname+"', HORAS_TOTALES= "+totalhrs+", HORAS_DESCUENTOS="+dischrs+" where CLAVE='"+realk+"'";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void EditEmployee(string real, string user, string key, string name, string lname, string phone, string pos)
		{
			command.Connection = OpenConnection();
			command.CommandText = "update trabajadores set USUARIO= '"+user+"', CLAVE='"+key+"', NOMBRE='"+name+"', APELLIDO= '"+lname+"', TELEFONO='"+phone+"', POSICION='"+pos+"' where USUARIO='"+real+"'";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void EditDiscount(int id, string name, int free, int needed){
			command.Connection = OpenConnection();
			command.CommandText = "update horasdescuento set NOMBRE= '"+name+"', HORAS_REGALO="+free+", HORAS_REQUERIDAS="+needed+" where ID= "+id+"";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void EditProduct(int id, string name, string contnet, string brand)
		{
			command.Connection = OpenConnection();
			command.CommandText = "update productos set NOMBRE = '"+name+"', CONTENIDO_NET = '"+contnet+"', MARCA = '"+brand+"' where ID = "+id+"";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void EditCatalogPrice(int id, float price)
		{
			command.Connection = OpenConnection();
			command.CommandText = "update catalogoPrecio set PRECIO = "+price+" where ID = "+id+"";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void DeleteString(string pkey, string attribute, string entity)
		{
			command.Connection = OpenConnection();
			command.CommandText = "delete from "+entity+" where "+attribute+" = '"+pkey+"' ";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void DeleteInt(int pkey, string entity)
		{
			command.Connection = OpenConnection();
			command.CommandText = "delete from "+entity+" where ID = "+pkey+"";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void DeleteEverything(string entity)
		{
			command.Connection = OpenConnection();
			command.CommandText = "delete from "+entity+"";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		
		
		public int GetNumTables()
		{
			var table2 = new DataTable();
			string line = "Select num From mesas where ID = 1";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			return int.Parse(table2.Rows[0][0].ToString());
		}
		public void PushTable()
		{
			var table2 = new DataTable();
			int value;
			
			string line = "Select num From mesas where ID = 1";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			
			value = int.Parse(table2.Rows[0][0].ToString());
			value ++;
			
			command.Connection = OpenConnection();
			command.CommandText = "update mesas set num = "+value+" where ID = 1";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public void PopTable()
		{
			var table2 = new DataTable();
			int value;
			
			string line = "Select num From mesas where ID = 1";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			
			value = int.Parse(table2.Rows[0][0].ToString());
			value --;
			
			command.Connection = OpenConnection();
			command.CommandText = "update mesas set num = "+value+" where ID = 1";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		
		
		
		public void InsertTable(string employee, string client, string time, float total, string method)
		{
			command.Connection = OpenConnection();
			command.CommandText = "insert into rentamesas values (NULL, '"+employee+"', '"+client+"', '"+time+"', current_date(), "+total+" , '"+method+"')";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		public float GetPriceTable()
		{
			var table2 = new DataTable();
			float value;
			
			string line = "Select PRECIO From catalogoPrecio where ID = 5";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			
			if(table2.Rows.Count > 0){
				value = float.Parse(table2.Rows[0][0].ToString());
			}
			else{
				value = 55;
			}
			
			return value;
		}
		public void UpdateHrsClient(string userclient, int hrs)
		{
			var table2 = new DataTable();
			int hrstotales, hrsdescuento;
			
			string line = "Select HORAS_TOTALES, HORAS_DESCUENTOS From clientes where CLAVE = '"+userclient+"'";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			
			hrstotales = int.Parse(table2.Rows[0][0].ToString());
			hrsdescuento = int.Parse(table2.Rows[0][1].ToString());
			hrstotales += hrs;
			hrsdescuento += hrs;
			
			command.Connection = OpenConnection();
			command.CommandText = "update clientes set HORAS_TOTALES = "+hrstotales+", HORAS_DESCUENTOS = "+hrsdescuento+" where CLAVE = '"+userclient+"'";
			command.ExecuteNonQuery();
			CloseConnection();
		}
		
		
		public int UpdateHrsDiscount(string userClient, string idDiscount)
		{
			var table2 = new DataTable();
			var	table3 = new DataTable();
			int hrsdescuentoC;
			int hrsrequD, hrsdescuentoD;
			
			string line = "select HORAS_DESCUENTOS From clientes where CLAVE = '"+userClient+"'";
			command.Connection = OpenConnection();
			command.CommandText = line;
			read = command.ExecuteReader();
			table2.Load(read);
			CloseConnection();
			hrsdescuentoC = int.Parse(table2.Rows[0][0].ToString());
			
			command.Connection = OpenConnection();
			command.CommandText = "select HORAS_REGALO, HORAS_REQUERIDAS from horasdescuento where ID = "+idDiscount+"";
			read = command.ExecuteReader();
			table3.Load(read);
			CloseConnection();
			hrsdescuentoD = int.Parse(table3.Rows[0][0].ToString());
			hrsrequD = int.Parse(table3.Rows[0][1].ToString());
			
			if (hrsdescuentoC >= hrsrequD) {
				hrsdescuentoC -= hrsrequD;
				
				command.Connection = OpenConnection();
				command.CommandText = "update clientes set HORAS_DESCUENTOS = "+hrsdescuentoC+" where CLAVE = '"+userClient+"'";
				command.ExecuteNonQuery();
				CloseConnection();
				
				return hrsdescuentoD;
			}
			return 0;
		}
	}
}
