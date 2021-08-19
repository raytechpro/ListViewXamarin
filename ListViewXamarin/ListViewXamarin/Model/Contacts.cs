﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Contacts : INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        private ImageSource image;
        private string contactType;
        private bool visibility;

        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
        }

        public Contacts()
        {

        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }
        
        public string ContactType
        {
            get { return contactType; }
            set
            {
                if (contactType != value)
                {
                    contactType = value;
                    this.RaisedOnPropertyChanged("ContactType");
                }
            }
        }
        
        public bool Visibility
        {
            get { return visibility; }
            set
            {
                if (visibility != value)
                {
                    visibility = value;
                    this.RaisedOnPropertyChanged("Visibility");
                }
            }
        }

        public ImageSource ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
