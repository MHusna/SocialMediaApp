﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Collections
    {
        [Key]
        public int CollectionId { get; set; }

        [StringLength(30)]
        public string CollectionName { get; set; }

        public DateTime CreationTime { get; set; }

        //SavedCollections ile ilişkilenecek.
        public ICollection<SavedCollection> SavedCollections { get; set; }
    }
}