using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        // Definici�n del grafo
        Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>()
        {
            { "Ahuachap�n", new List<string>{ "Sonsonate", "Santa Ana" } },
            { "Santa Ana", new List<string>{ "Ahuachap�n", "Sonsonate", "Chalatenango", "La Libertad" } },
            { "Sonsonate", new List<string>{ "Ahuachap�n", "Santa Ana", "La Libertad" } },
            { "Chalatenango", new List<string>{ "Santa Ana", "Cuscatl�n", "Caba�as", "San Salvador", "La Libertad" } },
            { "Cuscatl�n", new List<string>{ "Chalatenango", "Caba�as", "San Salvador", "La Paz", "San Vicente" } },
            { "Caba�as", new List<string>{ "Chalatenango", "Cuscatl�n", "San Vicente" } },
            { "San Salvador", new List<string>{ "Cuscatl�n", "La Libertad", "Chalatenango", "La Paz" } },
            { "La Libertad", new List<string>{ "Sonsonate", "San Salvador", "La Paz" } },
            { "La Paz", new List<string>{ "San Salvador", "Cuscatl�n", "San Vicente" } },
            { "San Vicente", new List<string>{ "Caba�as", "La Paz", "Usulut�n", "San Miguel", "Cuscatl�n" } },
            { "Usulut�n", new List<string>{ "San Vicente", "San Miguel" } },
            { "San Miguel", new List<string>{ "Usulut�n", "Moraz�n", "La Uni�n", "San Vicente" } },
            { "Moraz�n", new List<string>{ "San Miguel", "La Uni�n" } },
            { "La Uni�n", new List<string>{ "San Miguel", "Moraz�n" } }
        };

        Dictionary<Tuple<string, string>, int> distancias = new Dictionary<Tuple<string, string>, int>()
        {
            { Tuple.Create("Ahuachap�n", "Sonsonate"), 50 },
            { Tuple.Create("Sonsonate", "Ahuachap�n"), 50 },
            { Tuple.Create("Ahuachap�n", "Santa Ana"), 30 },
            { Tuple.Create("Santa Ana", "Ahuachap�n"), 30 },
            { Tuple.Create("Sonsonate", "Santa Ana"), 25 },
            { Tuple.Create("Santa Ana", "Sonsonate"), 25 },
            { Tuple.Create("Sonsonate", "La Libertad"), 70 },
            { Tuple.Create("La Libertad", "Sonsonate"), 70 },
            { Tuple.Create("Santa Ana", "Chalatenango"), 40 },
            { Tuple.Create("Chalatenango", "Santa Ana"), 40 },
            { Tuple.Create("Chalatenango", "Cuscatl�n"), 60 },
            { Tuple.Create("Chalatenango", "Sonsonate"), 85 },
            { Tuple.Create("Chalatenango", "La Libertad"), 85 },
            { Tuple.Create("San Salvador", "Caba�as"), 45 },
            { Tuple.Create("Cuscatl�n", "Chalatenango"), 60 },
            { Tuple.Create("Chalatenango", "Caba�as"), 50 },
            { Tuple.Create("Caba�as", "Chalatenango"), 50 },
            { Tuple.Create("Cuscatl�n", "Caba�as"), 35 },
            { Tuple.Create("Caba�as", "Cuscatl�n"), 35 },
            { Tuple.Create("Cuscatl�n", "San Salvador"), 20 },
            { Tuple.Create("San Salvador", "Cuscatl�n"), 20 },
            { Tuple.Create("Cuscatl�n", "La Paz"), 50 },
            { Tuple.Create("La Paz", "Cuscatl�n"), 50 },
            { Tuple.Create("Cuscatl�n", "San Vicente"), 25 },
            { Tuple.Create("Caba�as", "San Vicente"), 55 },
            { Tuple.Create("San Vicente", "Caba�as"), 55 },
            { Tuple.Create("San Salvador", "La Libertad"), 15 },
            { Tuple.Create("La Libertad", "San Salvador"), 15 },
            { Tuple.Create("San Vicente", "La Paz"), 45 },
            { Tuple.Create("La Paz", "San Vicente"), 45 },
            { Tuple.Create("San Vicente", "Usulut�n"), 65 },
            { Tuple.Create("Usulut�n", "San Vicente"), 65 },
            { Tuple.Create("La Paz", "Usulut�n"), 75 },
            { Tuple.Create("Usulut�n", "La Paz"), 75 },
            { Tuple.Create("Usulut�n", "San Miguel"), 85 },
            { Tuple.Create("San Miguel", "Usulut�n"), 85 },
            { Tuple.Create("San Miguel", "Moraz�n"), 70 },
            { Tuple.Create("Moraz�n", "San Miguel"), 70 },
            { Tuple.Create("San Miguel", "La Uni�n"), 90 },
            { Tuple.Create("La Uni�n", "San Miguel"), 90 },
            { Tuple.Create("Moraz�n", "La Uni�n"), 60 },
            { Tuple.Create("La Uni�n", "Moraz�n"), 60 },
            { Tuple.Create("San Salvador", "Chalatenango"), 35 },
            { Tuple.Create("Chalatenango", "San Salvador"), 35 },
            { Tuple.Create("San Salvador", "La Paz"), 45 },
            { Tuple.Create("La Paz", "San Salvador"), 45 },
            { Tuple.Create("San Salvador", "San Vicente"), 60 },
            { Tuple.Create("San Vicente", "San Salvador"), 60 },
            { Tuple.Create("San Vicente", "Moraz�n"), 80 },
            { Tuple.Create("Moraz�n", "San Vicente"), 80 }
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

            // Verificar si se encontr� el control
            if (controles.Length > 0 && controles[0] is Label label)
            {
                // Retornar el punto medio del label
                return new Point(label.Left + label.Width / 2, label.Top + label.Height / 2);
            }
            else
            {
                // Manejar el caso en que no se encontr� el control
                throw new Exception("No se encontr� el control con el nombre: " + controlName);
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

                    // Dibujar la l�nea
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

                    // Calcular la posici�n para el texto de la distancia
                    Point puntoMedio = new Point((puntoInicial.X + puntoFinal.X) / 2, (puntoInicial.Y + puntoFinal.Y) / 2);

                    // Obtener la distancia del diccionario
                    int distancia;
                    if (distancias.TryGetValue(Tuple.Create(inicio, fin), out distancia) || distancias.TryGetValue(Tuple.Create(fin, inicio), out distancia))
                    {
                        // Dibujar la distancia en el punto medio de la l�nea
                        g.DrawString(distancia.ToString() + " km", new Font("Arial", 10), Brushes.Black, puntoMedio);
                    }
                    else
                    {
                        // Manejar el caso en que la distancia no est� definida (opcional)
                        g.DrawString("N/A", new Font("Arial", 10), Brushes.Black, puntoMedio);
                    }
                }
            }
        }

        // Funci�n para realizar la b�squeda en anchura (BFS)
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

        // Funci�n para realizar la b�squeda en profundidad (DFS)
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
