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
        private struct RegClientes
        {
            public int Codigo;
            public string Nombre;
            public decimal Deuda;
            public decimal Limite;
        }

        //Declaración de indice
        public Int32 IND = 0;
        private RegClientes[] vecClientes = new RegClientes[100];

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //ABRIR
            StreamWriter AD = new StreamWriter(NombreArchivo, true); //Quiere decir que ya existen datos, que no los borre, sobreeescribe el archivo

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
        public void ListarDeudores(DataGridView Grilla)
        {        

            String datoLeido;
            string[] vecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();
            Grilla.Rows.Clear();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                if(Convert.ToDecimal(vecDatos[2]) > 0)
                {
                    Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[2], vecDatos[3]);                    
                }
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
        public void CargarVector()
        {
            String datoLeido;
            string[] vecDatos = new string[4];
            IND = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');
                vecClientes[IND].Codigo = Convert.ToInt32(vecDatos[0]);
                vecClientes[IND].Nombre = vecDatos[1];
                vecClientes[IND].Deuda = Convert.ToDecimal(vecDatos[2]);
                vecClientes[IND].Limite = Convert.ToDecimal(vecDatos[3]);
                IND++;
                datoLeido = AD.ReadLine();
              
            }
            AD.Close();
            AD.Dispose();
        }
        private void OrdenarVector()
        {
            RegClientes aux;
            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++) //
                {
                    if (vecClientes[i].Codigo > vecClientes[i + 1].Codigo)
                    {
                        aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = aux;
                    }
                }                
            }           
        }
        public void ReescribirArc()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false); //borra datos cargados y graba los nuevos pero de forma ordenada

            for (int i = 0; i < IND; i++)
            {
                AD.Write(vecClientes[i].Codigo);
                AD.Write(";");
                AD.Write(vecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(vecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(vecClientes[i].Limite);
            }

                //CERRAR
                AD.Close();
                AD.Dispose();
            }
      
        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArc();     
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
                cant++; //acumula la cantidad de clientes
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
      
        public void OrdenarPorCodigoAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Codigo > vecClientes[i + 1].Codigo)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        public void OrdenarPorCodigoDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Codigo < vecClientes[i + 1].Codigo)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorNombreAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Nombre.CompareTo(vecClientes[i + 1].Nombre) > 0)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

        public void OrdenarPorNombreDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Nombre.CompareTo(vecClientes[i + 1].Nombre) < 0)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorLimiteAscendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Limite > vecClientes[i + 1].Limite)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorLimiteDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Limite < vecClientes[i + 1].Limite)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }
        public void OrdenarPorDeudaAscendente()
        {
            Int32 C = 0;
    while (C < IND - 1)
    {
        Int32 i = 0;
        RegClientes Aux;
        while (i < IND - 1)
        {
            if (vecClientes[i].Deuda > vecClientes[i + 1].Deuda)
            {
                Aux = vecClientes[i];
                vecClientes[i] = vecClientes[i + 1];
                vecClientes[i + 1] = Aux;
            }
            i++;
        }
        C++;
    }
        }
        public void OrdenarPorDeudaDescendente()
        {
            Int32 C = 0;
            while (C < IND - 1)
            {
                Int32 i = 0;
                RegClientes Aux;
                while (i < IND - 1)
                {
                    if (vecClientes[i].Deuda < vecClientes[i + 1].Deuda)
                    {
                        Aux = vecClientes[i];
                        vecClientes[i] = vecClientes[i + 1];
                        vecClientes[i + 1] = Aux;
                    }
                    i++;
                }
                C++;
            }
        }

    }
}
