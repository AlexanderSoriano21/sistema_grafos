using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        // Definición del grafo
        Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>()
        {
            { "Ahuachapán", new List<string>{ "Sonsonate", "Santa Ana" } },
            { "Santa Ana", new List<string>{ "Ahuachapán", "Sonsonate", "Chalatenango", "La Libertad" } },
            { "Sonsonate", new List<string>{ "Ahuachapán", "Santa Ana", "La Libertad" } },
            { "Chalatenango", new List<string>{ "Santa Ana", "Cuscatlán", "Cabañas", "San Salvador", "La Libertad" } },
            { "Cuscatlán", new List<string>{ "Chalatenango", "Cabañas", "San Salvador", "La Paz", "San Vicente" } },
            { "Cabañas", new List<string>{ "Chalatenango", "Cuscatlán", "San Vicente" } },
            { "San Salvador", new List<string>{ "Cuscatlán", "La Libertad", "Chalatenango", "La Paz" } },
            { "La Libertad", new List<string>{ "Sonsonate", "San Salvador", "La Paz" } },
            { "La Paz", new List<string>{ "San Salvador", "Cuscatlán", "San Vicente" } },
            { "San Vicente", new List<string>{ "Cabañas", "La Paz", "Usulután", "San Miguel", "Cuscatlán" } },
            { "Usulután", new List<string>{ "San Vicente", "San Miguel" } },
            { "San Miguel", new List<string>{ "Usulután", "Morazán", "La Unión", "San Vicente" } },
            { "Morazán", new List<string>{ "San Miguel", "La Unión" } },
            { "La Unión", new List<string>{ "San Miguel", "Morazán" } }
        };

        Dictionary<Tuple<string, string>, int> distancias = new Dictionary<Tuple<string, string>, int>()
        {
            { Tuple.Create("Ahuachapán", "Sonsonate"), 50 },
            { Tuple.Create("Sonsonate", "Ahuachapán"), 50 },
            { Tuple.Create("Ahuachapán", "Santa Ana"), 30 },
            { Tuple.Create("Santa Ana", "Ahuachapán"), 30 },
            { Tuple.Create("Sonsonate", "Santa Ana"), 25 },
            { Tuple.Create("Santa Ana", "Sonsonate"), 25 },
            { Tuple.Create("Sonsonate", "La Libertad"), 70 },
            { Tuple.Create("La Libertad", "Sonsonate"), 70 },
            { Tuple.Create("Santa Ana", "Chalatenango"), 40 },
            { Tuple.Create("Chalatenango", "Santa Ana"), 40 },
            { Tuple.Create("Chalatenango", "Cuscatlán"), 60 },
            { Tuple.Create("Chalatenango", "Sonsonate"), 85 },
            { Tuple.Create("Chalatenango", "La Libertad"), 85 },
            { Tuple.Create("San Salvador", "Cabañas"), 45 },
            { Tuple.Create("Cuscatlán", "Chalatenango"), 60 },
            { Tuple.Create("Chalatenango", "Cabañas"), 50 },
            { Tuple.Create("Cabañas", "Chalatenango"), 50 },
            { Tuple.Create("Cuscatlán", "Cabañas"), 35 },
            { Tuple.Create("Cabañas", "Cuscatlán"), 35 },
            { Tuple.Create("Cuscatlán", "San Salvador"), 20 },
            { Tuple.Create("San Salvador", "Cuscatlán"), 20 },
            { Tuple.Create("Cuscatlán", "La Paz"), 50 },
            { Tuple.Create("La Paz", "Cuscatlán"), 50 },
            { Tuple.Create("Cuscatlán", "San Vicente"), 25 },
            { Tuple.Create("Cabañas", "San Vicente"), 55 },
            { Tuple.Create("San Vicente", "Cabañas"), 55 },
            { Tuple.Create("San Salvador", "La Libertad"), 15 },
            { Tuple.Create("La Libertad", "San Salvador"), 15 },
            { Tuple.Create("San Vicente", "La Paz"), 45 },
            { Tuple.Create("La Paz", "San Vicente"), 45 },
            { Tuple.Create("San Vicente", "Usulután"), 65 },
            { Tuple.Create("Usulután", "San Vicente"), 65 },
            { Tuple.Create("La Paz", "Usulután"), 75 },
            { Tuple.Create("Usulután", "La Paz"), 75 },
            { Tuple.Create("Usulután", "San Miguel"), 85 },
            { Tuple.Create("San Miguel", "Usulután"), 85 },
            { Tuple.Create("San Miguel", "Morazán"), 70 },
            { Tuple.Create("Morazán", "San Miguel"), 70 },
            { Tuple.Create("San Miguel", "La Unión"), 90 },
            { Tuple.Create("La Unión", "San Miguel"), 90 },
            { Tuple.Create("Morazán", "La Unión"), 60 },
            { Tuple.Create("La Unión", "Morazán"), 60 },
            { Tuple.Create("San Salvador", "Chalatenango"), 35 },
            { Tuple.Create("Chalatenango", "San Salvador"), 35 },
            { Tuple.Create("San Salvador", "La Paz"), 45 },
            { Tuple.Create("La Paz", "San Salvador"), 45 },
            { Tuple.Create("San Salvador", "San Vicente"), 60 },
            { Tuple.Create("San Vicente", "San Salvador"), 60 },
            { Tuple.Create("San Vicente", "Morazán"), 80 },
            { Tuple.Create("Morazán", "San Vicente"), 80 }
        };

        public Form1()
        {
            InitializeComponent();
            cmbDepartamento.SelectedIndex = 0;
        }

        private Point ObtenerPosicionLabel(string departamento)
        {
            // Generar el nombre del control basado en el departamento
            string controlName = "lbl" + departamento.Replace(" ", "");

            // Buscar el control
            Control[] controles = this.Controls.Find(controlName, true);

            // Verificar si se encontró el control
            if (controles.Length > 0 && controles[0] is Label label)
            {
                // Retornar el punto medio del label
                return new Point(label.Left + label.Width / 2, label.Top + label.Height / 2);
            }
            else
            {
                // Manejar el caso en que no se encontró el control
                throw new Exception("No se encontró el control con el nombre: " + controlName);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string departamentoSeleccionado = cmbDepartamento.SelectedItem.ToString();
            List<string> adyacentes = grafo[departamentoSeleccionado];

            using (Graphics g = panel1.CreateGraphics())
            {
                foreach (string adyacente in adyacentes)
                {
                    // Obtener las posiciones de los labels
                    Point puntoInicial = ObtenerPosicionLabel(departamentoSeleccionado);
                    Point puntoFinal = ObtenerPosicionLabel(adyacente);

                    // Dibujar la línea
                    g.DrawLine(Pens.Blue, puntoInicial, puntoFinal);
                }
            }
        }

        private void btnAnchura_Click(object sender, EventArgs e)
        {
            string departamentoSeleccionado = cmbDepartamento.SelectedItem.ToString();
            List<string> recorrido = BFS(departamentoSeleccionado);
            DibujarRecorrido(recorrido);
        }

        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            string departamentoSeleccionado = cmbDepartamento.SelectedItem.ToString();
            List<string> recorrido = DFS(departamentoSeleccionado);
            DibujarRecorrido(recorrido);
        }

        private void DibujarRecorrido(List<string> recorrido)
        {
            // Limpiar las conexiones previas
            panel1.Invalidate();
            panel1.Update(); // Asegura que el panel se refresque

            using (Graphics g = panel1.CreateGraphics())
            {
                for (int i = 0; i < recorrido.Count - 1; i++)
                {
                    string inicio = recorrido[i];
                    string fin = recorrido[i + 1];

                    Point puntoInicial = ObtenerPosicionLabel(inicio);
                    Point puntoFinal = ObtenerPosicionLabel(fin);

                    g.DrawLine(Pens.Blue, puntoInicial, puntoFinal);

                    // Calcular la posición para el texto de la distancia
                    Point puntoMedio = new Point((puntoInicial.X + puntoFinal.X) / 2, (puntoInicial.Y + puntoFinal.Y) / 2);

                    // Obtener la distancia del diccionario
                    int distancia;
                    if (distancias.TryGetValue(Tuple.Create(inicio, fin), out distancia) || distancias.TryGetValue(Tuple.Create(fin, inicio), out distancia))
                    {
                        // Dibujar la distancia en el punto medio de la línea
                        g.DrawString(distancia.ToString() + " km", new Font("Arial", 10), Brushes.Black, puntoMedio);
                    }
                    else
                    {
                        // Manejar el caso en que la distancia no esté definida (opcional)
                        g.DrawString("N/A", new Font("Arial", 10), Brushes.Black, puntoMedio);
                    }
                }
            }
        }

        // Función para realizar la búsqueda en anchura (BFS)
        private List<string> BFS(string startNode)
        {
            List<string> visited = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                string node = queue.Dequeue();
                foreach (string neighbor in grafo[node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return visited;
        }

        // Función para realizar la búsqueda en profundidad (DFS)
        private List<string> DFS(string startNode)
        {
            List<string> visited = new List<string>();
            Stack<string> stack = new Stack<string>();

            stack.Push(startNode);
            visited.Add(startNode);

            while (stack.Count > 0)
            {
                string node = stack.Pop();
                foreach (string neighbor in grafo[node])
                {
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return visited;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
