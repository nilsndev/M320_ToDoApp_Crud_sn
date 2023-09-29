using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_ToDoApp_Crud.classes{
    internal class ToDo{
        #region Fields
        DateTime _expiryDate; //Fälligkeitsdatum
        string _name;
        #endregion
        #region Characteristics
        public DateTime ExpiryDate { get{ return _expiryDate; } set { _expiryDate = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        #endregion
    }
}
