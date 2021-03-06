using System;

namespace Task6
{
    class Address
    {
        private uint index;

        public uint Index
        {
            get { return index; }
            set { index = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string appartment;

        public string Appartment
        {
            get { return appartment; }
            set { appartment = value; }
        }

        public void Print()
        {
            Console.WriteLine($"{index}, {country}, {city}, {street}, house {house}, app. {appartment}");
        }

        //public Address(uint index , string country , string city , string street , string house , string appartment)
        //{
        //    this.index = index;
        //    this.country = country;
        //    this.city = city;
        //    this.street = street;
        //    this.house = house;
        //    this.appartment = appartment;
        //}
    }
}
