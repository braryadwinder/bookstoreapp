using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstoreapp
{
    public class Book
    {
        private String name;
        private Author[] authors;
        private double price;
        private Date publication;
        private int qty = 0;

        public Book(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public Book(string name,Author[] authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public String GetName()
        {
            return this.name;
        }

        public Author[] GetAuthors()
        {
            return this.authors;

        }

        public Date GetPublicationDate()
        {
            return this.Date;
        }

        public void SetPublicationDate(Date date)
        {

        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public int GetQty()
        {
            return this.qty;
        }

        public void SetQty(int qty)
        {
            this.qty = qty;
        }

        public string toString()
        {
            return string.Format("");
        }

        public Author[] GetAuthorsNames()
        {
            return this.Author;
        }
    }
}