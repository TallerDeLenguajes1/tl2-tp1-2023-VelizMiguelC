using System.Security.Cryptography.X509Certificates;

namespace EspacioDeCadeteria
{
    public enum Estado{
        Cancelado,
        Entregado,
        EnPreparacion
    }
    public class Cadeteria{
        private string? nombre;
        private int telefono;
        private int numeradorPedidos;
        private List<Cadetes> cadeteros;
        
        public Cadeteria(global::System.String? nombre, global::System.Int32 telefono, global::System.Int32 numeradorPedidos, List<Cadetes> cadeteros)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.numeradorPedidos = numeradorPedidos;
            this.cadeteros = cadeteros;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Cadetes> Cadeteros { get => cadeteros; set => cadeteros = value; }
        public void CrearPedido(int idCadete,string?obs,string? nombre, string? direccion, int telefono, string? datosDeReferencia){
            foreach (Cadetes cadete in cadeteros){
                if (cadete.Id==idCadete){
                cadete.CreaPedido(numeradorPedidos,obs, nombre, direccion, telefono, datosDeReferencia);

                }
                }
        
        }
        public void MoverPedido(int idCadete1,int idCadete2,int NroPedido){
            Pedidos Pedaux;
            foreach (Cadetes Cadete in cadeteros)
            {
                if (Cadete.Id==idCadete1)
                {
                    foreach (Pedidos Ped in Cadete.ListaPedidos)
                    {
                        if (Ped.NroPedido==NroPedido)
                        {
                            Pedaux=Ped;
                        }
                        
                    }
                }
            }
        }
    }
    }   
