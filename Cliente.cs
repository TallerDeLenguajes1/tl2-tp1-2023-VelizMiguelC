namespace EspacioDeCadeteria
{
    public class Cliente{
        private string nombre;
        private string direccion;
        private int telefono;
        private string datosDeReferencia;

        public Cliente(string nombre, string direccion, int telefono, string datosDeReferencia)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            DatosDeReferencia = datosDeReferencia;
        }

        public string Nombre { get => nombre; set => nombre = value; } 
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string DatosDeReferencia { get => datosDeReferencia; set => datosDeReferencia = value; }
        }
    }   
