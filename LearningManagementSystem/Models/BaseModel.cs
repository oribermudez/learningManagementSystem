using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    public partial class BaseModel : ObservableObject
    {
        private int id = 0;

        public int Id
        {
            get => id;
            set => id = value;

        }
    }
}
