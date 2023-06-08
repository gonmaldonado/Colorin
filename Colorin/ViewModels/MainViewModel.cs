using Colorin.Helpers;
using Colorin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Colorin.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _objective;
        private int _score;
        private string _color;
        private int _level;
        private ICommand _sendSelection0;
        private ICommand _sendSelection1;
        private ICommand _sendSelection2;
        private ICommand _sendSelection3;
        private ICommand _sendSelection4;
        private ICommand _sendSelection5;
        private ICommand _sendSelection6;
        private ICommand _sendSelection7;
        private ICommand _sendSelection8;
        private ICommand _selectionLevel1;
        private ICommand _selectionLevel2;
        private ICommand _selectionLevel3;
        Models.Domain.Partida partida = new Models.Domain.Partida();
        Models.Domain.Move movimiento = new Models.Domain.Move();
        private readonly MainModel _model = new MainModel();


        public string Color
        {
            get {
                movimiento = _model.MakeMove(Level);
                _objective = movimiento.Objective;
                _color = movimiento.Color;
                return _color; }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }
        public int Level
        {
            get
            { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged("Score");
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //Rojo
        public ICommand SendSelectionRojoCommand
        {
            get { return _sendSelection0 ?? (_sendSelection0 = new RelayCommand(SendSelectionRojoExecute)); }

        }
        public void SendSelectionRojoExecute(object parameter)
        {
            partida.Selection = 0;
            partida = _model.MakeMatch(partida,movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Azul
        public ICommand SendSelectionAzulCommand
        {
            get { return _sendSelection1 ?? (_sendSelection1 = new RelayCommand(SendSelectionAzulExecute)); }

        }
        public void SendSelectionAzulExecute(object parameter)
        {
            partida.Selection = 1;
            partida = _model.MakeMatch(partida,movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Verde
        public ICommand SendSelectionVerdeCommand
        {
            get { return _sendSelection2 ?? (_sendSelection2 = new RelayCommand(SendSelectionVerdeExecute)); }

        }
        public void SendSelectionVerdeExecute(object parameter)
        {
            partida.Selection = 2;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Violeta
        public ICommand SendSelectionVioletaCommand
        {
            get { return _sendSelection3 ?? (_sendSelection3 = new RelayCommand(SendSelectionVioletaExecute)); }

        }
        public void SendSelectionVioletaExecute(object parameter)
        {
            partida.Selection = 3;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Amarillo
        public ICommand SendSelectionAmarilloCommand
        {
            get { return _sendSelection4 ?? (_sendSelection4 = new RelayCommand(SendSelectionAmarilloExecute)); }

        }
        public void SendSelectionAmarilloExecute(object parameter)
        {
            partida.Selection = 4;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Gris
        public ICommand SendSelectionGrisCommand
        {
            get { return _sendSelection5 ?? (_sendSelection5 = new RelayCommand(SendSelectionGrisExecute)); }

        }
        public void SendSelectionGrisExecute(object parameter)
        {
            partida.Selection = 5;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Negro
        public ICommand SendSelectionNegroCommand
        {
            get { return _sendSelection6 ?? (_sendSelection6 = new RelayCommand(SendSelectionNegroExecute)); }

        }
        public void SendSelectionNegroExecute(object parameter)
        {
            partida.Selection = 6;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Blanco
        public ICommand SendSelectionBlancoCommand
        {
            get { return _sendSelection7 ?? (_sendSelection7 = new RelayCommand(SendSelectionBlancoExecute)); }

        }
        public void SendSelectionBlancoExecute(object parameter)
        {
            partida.Selection = 7;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Naranja
        public ICommand SendSelectionNaranjaCommand
        {
            get { return _sendSelection8 ?? (_sendSelection8 = new RelayCommand(SendSelectionNaranjaExecute)); }

        }
        public void SendSelectionNaranjaExecute(object parameter)
        {
            partida.Selection = 8;
            partida = _model.MakeMatch(partida, movimiento);
            Score = partida.Score;
            movimiento = _model.MakeMove(Level);
            Color = movimiento.Color;
        }
        //Nivel1
        public ICommand SelectionLevelCommand1
        {
            get { return _selectionLevel1 ?? (_selectionLevel1 = new RelayCommand(SelectionLevel1)); }

        }
        public void SelectionLevel1(object parameter)
        {
            Level= 1;

        }
        //Nivel2
        public ICommand SelectionLevelCommand2
        {
            get { return _selectionLevel2 ?? (_selectionLevel2 = new RelayCommand(SelectionLevel2)); }

        }
        public void SelectionLevel2(object parameter)
        {
            Level = 2;

        }
        //Nivel3
        public ICommand SelectionLevelCommand3
        {
            get { return _selectionLevel3 ?? (_selectionLevel3 = new RelayCommand(SelectionLevel3)); }

        }
        public void SelectionLevel3(object parameter)
        {
            Level = 3;

        }

    }
}
