using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget4
{
    internal class Record
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private int money;
        public int Money { get { return money; } set { money = value; } }
        public bool IsIncome { get; set; }
        public DateTime Date;
        public Record(string name, string type, int money, DateTime date) 
        {
            this.Name = name;
            this.Type = type;
            this.Money= money;
            IsIncome = false;
            this.Date = date;

        }
    }
}
