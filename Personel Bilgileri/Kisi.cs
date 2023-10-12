using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Bilgileri
{
	internal class Kisi
	{
		
		public string PersonelID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DogumTarihi{ get; set; }
		public string Telephone { get; set; }
		public string Email { get; set; }
		public DateTime IseGirisTarihi { get; set; }
		public string Adress { get; set; }
		public string DosyaYolu { get; set; }
	}
}
