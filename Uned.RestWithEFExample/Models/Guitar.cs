using System.Collections;
using System.Collections.Generic;

namespace Uned.RestWithEFExample.Models
{
    public class Guitar
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FilePath { get; set; }
        
        public string Description { get; set; }
        
        public int Year { get; set; }        

        public IList<GuitarHistory> History { get; set; }

        public bool IsActive { get; set; }
    }
}
