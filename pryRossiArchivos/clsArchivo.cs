using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryRossiArchivos
{
    internal class clsArchivo
    {
        public string NombreArchivo = "Clientes.csv";

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //ABRIR
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //Quiere decir que ya existen datos

            //CARGAR O LEER
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);

            //CERRAR
            AD.Close();
            AD.Dispose();
        }
        
        //Procedimiento para mostrar clientes en una grilla
        public void Listar(DataGridView Grilla)
        {
            String datoLeido;
            string[] vecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();
            Grilla.Rows.Clear();

            while (datoLeido != null) 
            {
                vecDatos = datoLeido.Split(';');

                Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        public Int32 CantClientes()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            int cant = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                
                cant++;
                datoLeido = AD.ReadLine();
            }
            
            AD.Close();
            AD.Dispose();

            return cant;
        }
        public Decimal TotalDeuda()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
            }
            datoLeido = AD.ReadLine();

            AD.Close();
            AD.Dispose();

            return total;
        }

        public Decimal Promedio()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            int cant = 0;
            Decimal promedio = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                if (cant > 0)
                {
                    promedio = Math.Round(total / Convert.ToDecimal(vecDatos[2]));//Redondea p/tener 2 decimales
                }
               
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total/cant;
        }

        public Int32 CantDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            int cantDeud = 0;          

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null && Convert.ToInt32(vecDatos[2]) > 0)
            {
                vecDatos = datoLeido.Split(';');
                cantDeud++;
                datoLeido = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();

            return cantDeud;
        }
        public Decimal PromDeudores()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            Decimal total = 0;
            int cant = 0;
            Decimal promedio = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                vecDatos = datoLeido.Split(';');
                total = total + Convert.ToDecimal(vecDatos[2]);
                if (cant > 0)
                {
                    promedio = Math.Round(total / Convert.ToDecimal(vecDatos[2]));//Redondea p/tener 2 decimales
                }

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / cant;
        }
        


    }
}
