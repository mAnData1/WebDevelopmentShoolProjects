using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Enities
{
    public class BaseEnity
    {
        [Key]
        public int Id { get; set; }
    }
}
