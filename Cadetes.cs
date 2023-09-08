namespace EspacioDeCadeteria
{
    public class Cadetes{
        private int id;
        private string? nombre;
        private string? direccion;
        private int telefono;
        private List<Pedidos> pedido;

        public Cadetes(global::System.Int32 id, global::System.String nombre, global::System.String direccion, global::System.Int32 telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ListaPedidos = new List<Pedidos>();
        }

        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Pedidos> ListaPedidos { get => pedido; set => pedido = value; }

        void TomarPedido(Pedidos ped){
            
        }
        }
    }   
