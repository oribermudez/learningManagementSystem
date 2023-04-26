using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    /// <summary>
    /// Abstract class
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
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
