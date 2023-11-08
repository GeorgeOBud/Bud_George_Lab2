using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bud_George_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }

    }
}
