using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace DowntownBoiseAssociation
{
    public enum comparison
    {
        Exists, DoesNotExist, Equals, GreaterThan, LessThan, DoesNotEqual, DoesNotExistOrBlank
    }

    //[XmlRoot()]
    public class RateRule : INotifyPropertyChanged
    {
        string _Name = string.Empty;
        comparison _Comparison;
        string _Value = string.Empty;

        [XmlAttribute()]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged("Name");
            }
        }

        [XmlAttribute()]
        public comparison Comparison
        {
            get
            {
                return _Comparison;
            }
            set
            {
                _Comparison = value;
                NotifyPropertyChanged("Comparison");
            }
        }

        [XmlAttribute()]
        public string Value {
            get { return _Value; }
            set
            {
                _Value = value;
                NotifyPropertyChanged("Value");
            }
        }

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
