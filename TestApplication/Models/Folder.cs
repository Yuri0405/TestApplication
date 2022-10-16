using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.Models
{
    public partial class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? RootFolderId { get; set; }
    }
}
