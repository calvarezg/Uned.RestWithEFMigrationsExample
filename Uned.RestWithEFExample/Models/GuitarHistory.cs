using System;

namespace Uned.RestWithEFExample.Models
{
    public class GuitarHistory
    {
        public int Id { get; set; }

        public DateTime Date { get; private set; }

        public HistoryType Type { get; private set; }

        public string Description { get; set; }

        public Guitar Guitar { get; set; }

        public GuitarHistory(HistoryType type)
        {
            Type = type;
            Date = DateTime.Now;
        }
    }
}