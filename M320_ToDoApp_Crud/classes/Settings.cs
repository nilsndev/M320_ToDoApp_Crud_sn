using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_ToDoApp_Crud.classes{
    internal class Settings{
        #region Fields
        List<ToDo> _toDoes = new List<ToDo>();
        #endregion
        #region Characteristics
        public List<ToDo> ToDoes { get { return _toDoes; } set { _toDoes = value; } }
        #endregion
    }
}
