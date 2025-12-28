using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CatogeryId { get; set; }
        public string CatogeryName { get; set; }

        public bool Status { get; set; }

    }
}
