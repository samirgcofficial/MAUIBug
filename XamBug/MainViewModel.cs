
using System;
using System.Collections.ObjectModel;
using static XamBug.MainViewModel;

namespace XamBug
{
    public class MainViewModel : BindableObject
    {
        private ObservableCollection<Items> myitem;
        public ObservableCollection<Items> Myitems
        {
            get { return myitem; }
            set
            {
                myitem = value;
                OnPropertyChanged();
            }
        }
        public class Items
        {
            public string Message { get; set; }

        }
        public MainViewModel()
        {
            Myitems = new ObservableCollection<Items>();
            GetMessages();
          
        }

        private async void GetMessages()
        {
            //Let us suppose it takes 3 sec to get messages from api
        await Task.Delay(3000);
        Myitems = new ObservableCollection<Items>
        {
            new Items{Message = "A"},
            new Items{Message = "B"},
            new Items{Message = "C"},
            new Items{Message = "D"},
            new Items{Message = "E"},
            new Items{Message = "F"},
            new Items{Message = "G"},
            new Items{Message = "H"},
            new Items{Message = "I"},
            new Items{Message = "j"},
        };
        }
    }
}

