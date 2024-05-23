using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    sealed public class MenuItem
    {
        // ===============================
        // === Properties
        // ===============================

        public required int Id { get; set; }
        public required string Name { get; set; }
        public required float Price { get; set; }

        // ===============================
        // === Constructor
        // ===============================


        // ===============================
        // === Methods
        // ===============================

        /// <summary>
        /// Print the object with format Id: _, Name: _, Price: _
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"\\(Id: {Id}\\, Name: {Name}, Price: {Price})";
        }
    }
}
