using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace testForms
{
    class notaCompra
    {
        public TimeUuid idNota { get; set; }
        public string nomCliente { get; set; }
        public string nomEmpresa { get; set; }
        public List<string> objetos { get; set; }
        public List<decimal> costo { get; set; }
        public decimal montoFinal { get; set; }
        public LocalDate fechaGenerada { get; set; }
    }
}
