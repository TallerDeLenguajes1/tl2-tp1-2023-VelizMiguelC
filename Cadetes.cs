namespace EspacioDeCadeteria
{
    public class Cadetes{
        private int id;
        private string? nombre;
        private string? direccion;
        private int telefono;
        private List<Pedidos> pedido;

        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Pedidos> ListaPedidos { get => pedido; set => pedido = value; }

        void CreaPedido(int NroPedido,string?obs,string? nombre, string? direccion, int telefono, string? datosDeReferencia){
            Pedidos pedido=new Pedidos(NroPedido,obs,nombre,direccion,telefono, datosDeReferencia);
            ListaPedidos.Add(pedido);
        }
        }
    }   
