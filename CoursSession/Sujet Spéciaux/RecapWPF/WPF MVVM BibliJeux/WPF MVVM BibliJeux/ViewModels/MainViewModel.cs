using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WPF_MVVM_BibliJeux.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
       

        public class Games : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            private Games _selectedGames;
            private string name;

            public string Name
            {
                get { return this.name; }
                set
                {
                    if (this.name != value)
                    {
                        this.name = value;
                        this.NotifyPropertyChanged("Name");
                    }
                }
            }
            private string desc;

            public string Desc
            {
                get { return this.desc; }
                set
                {
                    if (this.desc != value)
                    {
                        this.desc = value;
                        this.NotifyPropertyChanged("Desc");
                    }
                }
            }
            private string editor;

            public string Editor
            {
                get { return this.editor; }
                set
                {
                    if (this.editor != value)
                    {
                        this.editor = value;
                        this.NotifyPropertyChanged("Editor");
                    }
                }
            }
            private string year;

            public string Year
            {
                get { return this.year; }
                set
                {
                    if (this.year != value)
                    {
                        this.year = value;
                        this.NotifyPropertyChanged("Year");
                    }
                }
            }

            private string console;

            public string Console
            {
                get { return this.console; }
                set
                {
                    if (this.console != value)
                    {
                        this.console = value;
                        this.NotifyPropertyChanged("Console");
                    }
                }
            }

            private string rating;

            public string Rating
            {
                get { return this.rating; }
                set
                {
                    if (this.rating != value)
                    {
                        this.rating = value;
                        this.NotifyPropertyChanged("Rating");
                    }
                }
            }

            public Games()
            {
                Year = "Entrez l'année";
                Name = "Title";
                Editor = "Editeur";
                Desc = "Description";

            }

            public Games SelectGames
            {
                get => _selectedGames;
                set
                {
                    _selectedGames = value;
                    OnPropertyChanged();
                }
            }

            private void NotifyPropertyChanged(string v)
            {
                throw new NotImplementedException();
            }
        }

        private ObservableCollection<Games> _games = new ObservableCollection<Games>();
        public ObservableCollection<Games> _Games
        {
            get => _games;
            set
            {
                _games = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            _Games.Add(new Games() {Name = "ArkSurvival", Editor = "Grr Grr.inc", Desc="t-rex and monkeys", Year="2017"  });
        }
        
    }
}