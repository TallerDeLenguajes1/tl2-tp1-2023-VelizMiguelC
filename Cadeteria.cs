using System.Security.Cryptography.X509Certificates;

namespace EspacioDeCadeteria
{
    public enum Estado{
        Cancelado,
        Entregado,
        EnPreparacion
    }
    public class Cadeteria{
        private string nombre;
        private int telefono;
        private int numeradorPedidos;
        private List<Cadetes> cadeteros;
        
        public Cadeteria(global::System.String nombre, global::System.Int32 telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.NumeradorPedidos = 0;
            this.cadeteros = new List<Cadetes>();
            this.NumeradorPedidos=0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Cadetes> Cadeteros { get => cadeteros; set => cadeteros = value; }
        public int NumeradorPedidos { get => numeradorPedidos; set => numeradorPedidos = value; }

        public Pedidos TomarPedido(string observacion,string nombre, string direccion, int telefono, string datosDeReferencia){
            NumeradorPedidos++;
            var cliente=new Cliente(nombre, direccion,telefono,datosDeReferencia);
            var Pedido=new Pedidos(NumeradorPedidos,observacion, cliente);
            return Pedido;
        }
        public void AsignarPedido(int id,Pedidos ped){
            var cad= Cadeteros.FirstOrDefault(p=>p.Id==id);
            cad.ListaPedidos.Add(ped);
        }        
        public void MoverPedido(int idCadete,int NroPedido){
            Pedidos Pedaux=null;
            foreach (Cadetes Cadete in cadeteros)
            {
                if (Cadete.Id!=idCadete)
                {
                    Pedaux=Cadete.QuitarPedido(NumeradorPedidos);
                }
                if (Pedaux != null)
                {
                    foreach (var cad in Cadeteros)
                    {
                        cad.ListaPedidos.Add(Pedaux);
                    }
                }

            }
        }
    public float PedPromedioCad(){
        int pedidos = 0;
        foreach (var c in Cadeteros)
        {
            pedidos += c.CantidadDePedidos(0); 
        }
        return pedidos/Cadeteros.Count();
    }
    public float TotalaPagar(){
        float monto=0;
        foreach (var cad in Cadeteros){
            monto = monto + cad.JornalACobrar();
        }
        return monto;
    }
    }
}
