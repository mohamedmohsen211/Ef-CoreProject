using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DAL.Entites
{

        //[Keyless]        
    public class user_pass
    {
        [Key]
        public int ID { get; set; }
        public string username { get;set; }
        
        public string password { get; set; }

    }
}
