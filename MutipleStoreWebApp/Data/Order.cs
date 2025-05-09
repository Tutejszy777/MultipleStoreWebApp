﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MutipleStoreWebApp.Data.Static;

namespace MutipleStoreWebApp.Data
{

    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        public Status Status { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Total { get; set; }

        public Guid AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        public int StoreId { get; set; }
        public Store? Store { get; set; }


        public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual Invoice Invoice { get; set; }
    }
}
