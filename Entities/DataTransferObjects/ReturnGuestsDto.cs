﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ReturnGuestsDto
    {
        public Guid Id { get; set; }
        public User? guest { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
