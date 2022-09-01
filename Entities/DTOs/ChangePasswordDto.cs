﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ChangePasswordDto : IDto
    {
        public string UserEmail { get; set; }
        public string OldPass { get; set; }
        public string NewPass { get; set; }
    }
}
