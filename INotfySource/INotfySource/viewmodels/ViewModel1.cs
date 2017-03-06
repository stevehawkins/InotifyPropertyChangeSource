﻿using INotfySource.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace INotfySource.viewmodels
{
    public class ViewModel1:BaseModel
    {
        private Person _person;
        public ViewModel1()
        {
            // set some default here for example
            _person = new Person
            {
                Age = 21,
                FirstName = "Steve",
                LastName = "Hawkins"
            };
        }

        public int Age
        {
            get { return _person.Age; }
            set {
                _person.Age = value;
                OnPropertyChanged("Age");
                OnPropertyChanged("UserInfo");
            }
        }

        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                _person.FirstName = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("UserInfo");
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("UserInfo");
            }
        }

        public string UserInfo
        {
            get { return _person.PersonInfo(); }
        }
   }
}
