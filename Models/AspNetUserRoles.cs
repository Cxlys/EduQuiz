﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Models
{
    public partial class AspNetUserRoles
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(AspNetRoles.AspNetUserRoles))]
        public virtual AspNetRoles Role { get; set; }
    }
}

