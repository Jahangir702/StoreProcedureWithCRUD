﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using R54_M10_Class_09_Work_01.Models;

namespace R54_M10_Class_09_Work_01.ViewModels.Input
{
    public class ProductInputModel
    {
        public int ProductId { get; set; }
        [Required, StringLength(50)]
        public string ProductName { get; set; } = default!;
        [Required, EnumDataType(typeof(Size))]
        public Size Size { get; set; } = default!;
        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required, StringLength(40)]
        public string Picture { get; set; } = default!;

        public bool OnSale { get; set; }
        public List<Sale> Sales { get; set; } = new List<Sale>();
    }
}
