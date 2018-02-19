using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//Author: Erin Agobert
//Purpose: This model creates the order table

namespace Bangazon_WebApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public PaymentType PaymentType { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateTimeCreated = DateTime.Now;

        [Required]
        [DataType(DataType.DateTime)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DateTimeClosed;

    }
}
