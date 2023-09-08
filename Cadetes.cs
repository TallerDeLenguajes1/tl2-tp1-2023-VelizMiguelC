using System.Linq;
namespace EspacioDeCadeteria
{
    public class Cadetes{
        private int id;
        private string nombre;
        private string direccion;
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
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Pedidos> ListaPedidos { get => pedido; set => pedido = value; }

        public void TomarPedido(Pedidos ped){
            ListaPedidos.Add(ped);
        }
        public Pedidos QuitarPedido(int NumPed){
            var pedido=ListaPedidos.FirstOrDefault(p=>p.NroPedido==NumPed);
            ListaPedidos.Remove(pedido);
            return pedido;
        }
        public float JornalACobrar(){
            return CantidadDePedidos(1)*500;
        }

        public int CantidadDePedidos(int op){
            int cant=0;
            switch (op)
            {
                case 1:
                cant=ListaPedidos.Count(p=>p.EstadoDePedido==Estado.Entregado);
                break;
                case 2:
                cant=ListaPedidos.Count(p=>p.EstadoDePedido==Estado.EnPreparacion);
                break;
                case 3:
                cant=ListaPedidos.Count(p=>p.EstadoDePedido==Estado.Cancelado);
                break;
                default:
                cant=ListaPedidos.Count();
                break;
            }
            return cant;
        }
    
    }
    }   
