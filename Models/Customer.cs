﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHangCore.Models
{
    public class Customer
    {
        [Display(Name = "Mã")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên!")]
        [MaxLength(50)]
        [Display(Name = "Tên")]
        public string Ten { get; set; }

        [StringLength(10, ErrorMessage = "Số điện thoại gồm 10 chữ số!", MinimumLength = 10)]
        [RegularExpression(@"[0][0-9]*", ErrorMessage = "Số điện thoại bắt đầu bằng số 0, chỉ chứa 10 chữ số!")]
        [Display(Name = "Số điện thoại")]
        [Remote(action: "KiemTraSDT", controller: "Customers", AdditionalFields = nameof(ID))]
        public string SDT { get; set; }

        public List<Order> Orders { get; set; }
    }
}