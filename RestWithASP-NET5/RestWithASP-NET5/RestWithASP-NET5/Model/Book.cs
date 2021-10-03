using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5.Model
{
	[Table("books")]
	public class Book
	{
		[Column("id")]
		public int Id { get; set; }
		[Column("author")]
        public string Author { get; set; }
		[Column("launch_date")]
        public DateTime LaunchDate { get; set; }
		[Column("price")]
		public decimal Price { get; set; }
	}
}
