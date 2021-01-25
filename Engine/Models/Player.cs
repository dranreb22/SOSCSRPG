using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private int _hitPoints;
        private string _class;
        private int _level;
        private int _experiencePoints;
        private int _gold;

        public string CharacterClass
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public string Name { get; set; }
        public int ExperiencePoints { 
            get { return _experiencePoints; }
            set 
            { 
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int Level {
            get { return _level; }
            set {
                _level = value;
                OnPropertyChanged("Level");
            } 
        }
        public int Gold {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
