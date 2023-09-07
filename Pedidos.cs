namespace EspacioDeCadeteria
{
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
            EstadoDePedido = Estado.EnPreparacion;
        }
    }
    }   
