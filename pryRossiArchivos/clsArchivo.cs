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
        public bool ExisteCodigo(string cod)
        {
            string datoLeido;
            string[] vecDatos;
            bool encontrado = false;

            // Verificamos si el archivo existe antes de intentar leerlo
            if (File.Exists(NombreArchivo))
            {
                StreamReader AD = new StreamReader(NombreArchivo);
                datoLeido = AD.ReadLine();

                while (datoLeido != null)
                {
                    vecDatos = datoLeido.Split(';');
                    // Comparamos el código del archivo con el que queremos ingresar
                    if (vecDatos[0] == cod)
                    {
                        encontrado = true;
                        break; // Si lo encuentra, sale del bucle
                    }
                    datoLeido = AD.ReadLine();
                }
                AD.Close();
                AD.Dispose();
            }
            return encontrado;
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
                datoLeido = AD.ReadLine();
            }
          

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
                    promedio = Math.Round(total / cant);//Redondea p/tener 2 decimales
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
            string[] vecDatos;
            int cantDeud = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                // Primero separas los datos, luego comparas
                if (Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    cantDeud++;
                }
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
                    promedio = Math.Round(total / cant);//Redondea p/tener 2 decimales
                }

                datoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total / cant;
        }
        
        public void GenerarReporte()
        {
            
            String datoLeido;
            string[] vecDatos = new string[4];

            //Abrir
            StreamWriter Reporte = new StreamWriter("Reporte.csv", false, Encoding.UTF8);
            Reporte.WriteLine("LISTADO DE CLIENTES");
            Reporte.WriteLine("\n");
            Reporte.WriteLine("Código; Nombre; Deuda; Límite");


            StreamReader AD = new StreamReader(NombreArchivo);

            //Leer
            datoLeido = AD.ReadLine();
           
            Int32 cant = 0;
            Decimal total = 0;
            Decimal promedio = 0;

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';'); //Pasamoslalinea a un vector, cada vez que vea un punto y coma va a separar la celda (lo corta)      
                Reporte.Write(vecDatos[0]); ;
                Reporte.Write(";");
                Reporte.Write(vecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(vecDatos[2]);
                Reporte.Write(";");
                Reporte.WriteLine(vecDatos[3]);

                datoLeido = AD.ReadLine();
                cant++; //acumulala cantidad de clientes
                total = total + Convert.ToDecimal(vecDatos[2]);
                promedio = Math.Round(total / cant);
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

            Reporte.WriteLine(";");
            Reporte.Write("Total Deudas:;;");
            Reporte.WriteLine(total);
            Reporte.Write("Cantidad de Clientes:;;");
            Reporte.WriteLine(cant);
            Reporte.Write("Promedio deudas:;;");
            Reporte.WriteLine(promedio);

            //Cerrar
            Reporte.Close();
            Reporte.Dispose();
        }


    }
}
