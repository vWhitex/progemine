using System;
using System.Collections.Generic;

namespace CalculatorLib
{
    public class Calculator
    {
        private List<string> list = new List<string>();
        // Võtab vastu nupuvajutusi
        public void KeyPress(char key)
        {
            if(key.ToString() == "C")
            {
                list.Clear();
            }

            else if(key.ToString() == "D") { list.RemoveAt(list.Count - 1); }

            else
            {
                list.Add(key.ToString());
                try
                {
                    var dataTable = new System.Data.DataTable();
                    var result = dataTable.Compute(string.Join("", list), "");
                    this._result = Convert.ToDecimal(result);
                }
                catch(Exception ex)
                { 
                }
            }

        }

        private decimal _result { get; set; }

        // Tagastab tulemuse
        public decimal Result
        {
            get
            { 
                return _result;
            }
        }
    }
}
