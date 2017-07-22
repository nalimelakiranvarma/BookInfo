﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookInfo
{
    class Book
    {
        
        private string name;
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

        public Book(string name, double price, int qty)
        {
            this.name = name;
            this.price = price;
            this.qty = qty;
        }

        public string GetName()
        {
            return this.name;
        }

        public Author[] GetAuthors()
        {
            return this.authors;

        }

        public Date GetPublicationDate()
        {
            return this.publication;
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
            return String.Format("");
        }

        
    }

}
