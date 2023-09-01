using System.Security.Cryptography.X509Certificates;

namespace EspacioDeCadeteria
{
    public enum Estado{
        Cancelado,
        Preparacion,
        Entregado,
        EnEnvio
    }
    public class Cadeteria{
        private string? nombre;
        private int telefono;
        private int numeradorPedidos;
        private List<Cadetes> cadeteros;

        public string? Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Cadetes> Cadeteros { get => cadeteros; set => cadeteros = value; }
        public void CrearPedido(int idCadete,string?obs,string? nombre, string? direccion, int telefono, string? datosDeReferencia){
            foreach (Cadetes cadete in cadeteros){
                if (cadete.Id==idCadete){
                cadete.CreaPedido(numeradorPedidos,obs, nombre, direccion, telefono, datosDeReferencia);

                }
                }
        ;
        }
    }
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
    public class Pedidos{
        private int nroPedido;
        private string observacion;
        private Cliente cli;
        private Estado estadoDePedido;

        

        public int NroPedido { get => nroPedido; set => nroPedido = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public Cliente Cli { get => cli; set => cli = value; }
        public Estado EstadoDePedido { get => estadoDePedido; set => estadoDePedido = value; }
        public Pedidos(int nroPedido, string observacion,string? nombre, string? direccion, int telefono, string? datosDeReferencia)
        {
            var ClientePed=new Cliente(nombre,direccion, telefono,datosDeReferencia);
            NroPedido = nroPedido;
            Observacion = observacion;
            Cli = ClientePed;
            EstadoDePedido = Estado.Preparacion;
        }
    }
    public class Cliente{
        private string? nombre;
        private string? direccion;
        private int telefono;
        private string? datosDeReferencia;

        public Cliente(string? nombre, string? direccion, int telefono, string? datosDeReferencia)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            DatosDeReferencia = datosDeReferencia;
        }

        public string? Nombre { get => nombre; set => nombre = value; } //hola
        public string? Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string? DatosDeReferencia { get => datosDeReferencia; set => datosDeReferencia = value; }
        }
    }   
}