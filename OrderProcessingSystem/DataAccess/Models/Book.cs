using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public bool IsActive { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
