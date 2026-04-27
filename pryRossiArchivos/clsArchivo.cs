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
            int total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                
            }
            datoLeido = AD.ReadLine();

            AD.Close();
            AD.Dispose();

            return total;
        }
        public Int32 TotalDeuda()
        {
            String datoLeido;
            Decimal total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cant++;
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total;
        }

    }
}
