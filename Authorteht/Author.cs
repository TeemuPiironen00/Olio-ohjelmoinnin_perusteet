using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorteht
{
    internal class Author
    {
        public string name;
        public string birthDay;
        public Book book;


        internal Book? Book
        {
            get
            {
                return book;
            }
            set
            {
                book = value;
            }



        }


    }
}
