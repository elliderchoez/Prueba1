using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Input;

namespace Prueba1
{
    //Crear clase RelayCommand
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;
        //Constructor que ejecute el mismo con null
        public RelayCommand(Action<object> execute): this(execute,null)
        {
                
        }
        //Constructor para la ejecucion del comando
        public RelayCommand(Action<object> execute, Predicate<object> canExecute) 
        {
            if (execute == null) 
                throw new ArgumentException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }
        //Metodo que pide un parametro que determina que si puede o no puede ejecutar la accion
        public bool CanExecute(object parameter) 
        {
            return _canExecute == null ? true : _canExecute(parameter) ;        
        }
        //Metodo de 2 eventos que agrega o quita 
        public event EventHandler CanExecuteChanged 
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        
        }
        //metodo ejecutar
        public void Execute(object parameter) 
        {
            _execute(parameter);
        }
    }
}
