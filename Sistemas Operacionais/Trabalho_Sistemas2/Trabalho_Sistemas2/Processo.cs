using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Sistemas2 {
    public  class Processo {
        public string NumProcesso { get; set; }
        public int Tempo { get; set; }       

        public object this[string propertyName] {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
