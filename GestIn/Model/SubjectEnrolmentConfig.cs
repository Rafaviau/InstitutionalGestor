﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GestIn.Model
{
    [Keyless]
    [Table("SubjectEnrolmentConfig")]
    public partial class SubjectEnrolmentConfig
    {
        public int Id { get; set; }
        public DateTime SubjectEnrolmentStartDate { get; set; }
        public DateTime? SubjectEnrolmentCloseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [StringLength(50)]
        public string LastModificationBy { get; set; } = null!;
    }
}
