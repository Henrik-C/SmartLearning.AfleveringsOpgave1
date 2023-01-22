using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartLearning.AfleveringsOpgave1.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
    }
}





