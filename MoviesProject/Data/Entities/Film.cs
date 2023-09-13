using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesProject.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public DateTime DOB { get;set; }
        public string Description { get; set; }

        [ForeignKey("Producers")]
        public int ProducerId { get; set; }
        public Producers Producers { get; set; }

     }
}
