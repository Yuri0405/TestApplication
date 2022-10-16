using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TestApplication.Models
{
    public class Folder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public int? RootFolderId { get; set; }
        public string Name { get; set; }
    }
}
