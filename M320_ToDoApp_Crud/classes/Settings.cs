using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_ToDoApp_Crud.classes{
    public static class Settings{
        #region Fields
        static List<ToDo> _toDoes = new List<ToDo>();
        #endregion
        #region Characteristics
        public static List<ToDo> ToDoes { get { return _toDoes; } set { _toDoes = value; } }
        #endregion
    }
}
