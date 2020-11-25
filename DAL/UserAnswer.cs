using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAnswer
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idAnswer { get; set; }
        public DateTime DateTimes { get; set; }
    }
}
