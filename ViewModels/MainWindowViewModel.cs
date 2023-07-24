using Prueba1.CAL;
using Prueba1.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace Prueba1.ViewModels
{
    //El patron MVVM primero va las variable, propiedades, comandos, eventos y metodos 
    public class MainWindowViewModel : ViewModelBase
    {
        //propiedades que van hacer interaccion contra la vista
        #region Properties

        private List<Materias> materias;

        public List<Materias> Materias 
        {
            get 
            {
                return materias; 
            }
            set 
            {
                if (materias == value) 
                {
                    return;
                }
                materias = value;
                OnPropertyChanged("Materias");
            }
        
        }
        #endregion

        #region Commands
        //Comando para mapear y se escribe como se muestra en el MainWindow
        private ICommand materiasCommand;
        //Comando que vamos a invocar en la vista 
        public ICommand MateriasCommand 
        {
            get
            {
                if (materiasCommand == null) 
                {
                    //MateriasCommandExecute es el metodo que se va invocar
                    materiasCommand = new RelayCommand(param => this.MateriasCommandExecute(), null);
                }
                return materiasCommand;
            }

        }

        #endregion


        public MainWindowViewModel() 
        {
        
        }
        //Metodo que se va a realizar 
        private void MateriasCommandExecute()
        {
            var materiaService = new MateriaService();

            var result = materiaService.GetMaterias();

            Materias = new List<Materias>(result);
        }
    }
}
