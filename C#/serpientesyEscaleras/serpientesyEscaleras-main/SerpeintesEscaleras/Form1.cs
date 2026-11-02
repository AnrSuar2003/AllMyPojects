using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SerpeintesEscaleras
{
    public partial class Form1 : Form
    {
        private int[] playerPositions = { 1, 1 }; // Posiciones iniciales de los jugadores
        private int currentPlayer = 0; // 0 -> Jugador 1, 1 -> Jugador 2
        private Random random = new Random();
        private Dictionary<int, int> specialTiles = new Dictionary<int, int>(); // Serpientes y escaleras

        public Form1()
        {
            InitializeComponent();
            CreateBoard();
            InitializeSpecialTiles();
            UpdatePlayerPositions();
        }

        // Crear el tablero con botones
        private void CreateBoard()
        {
            pnlBoard.Controls.Clear(); // Limpiar el panel antes de dibujar
            int size = 45; // Tamaño de cada celda
            bool leftToRight = true; // Dirección del recorrido en zigzag

            for (int row = 9; row >= 0; row--) // De arriba hacia abajo
            {
                for (int col = 0; col < 10; col++)
                {
                    int boardNumber = leftToRight ? (row * 10 + col + 1) : (row * 10 + (9 - col) + 1);

                    Button btn = new Button
                    {
                        Width = size,
                        Height = size,
                        Text = boardNumber.ToString(),
                        Location = new Point(col * size, (9 - row) * size),
                        BackColor = Color.White,
                        Tag = boardNumber
                    };

                    pnlBoard.Controls.Add(btn);

                    // Agregar las imágenes de las escaleras y serpientes
                  
                }
                leftToRight = !leftToRight; // Alternar dirección en zigzag
            }
        }

      

        // Inicializar las serpientes y escaleras
        private void InitializeSpecialTiles()
        {
            // Escaleras
            specialTiles[4] = 14;  // Casilla 4 -> Casilla 14
            specialTiles[9] = 31;  // Casilla 9 -> Casilla 31
            specialTiles[20] = 38; // Casilla 20 -> Casilla 38
            specialTiles[28] = 84; // Casilla 28 -> Casilla 84 (agregada una más)

            // Serpientes
            specialTiles[54] = 34; // Casilla 54 -> Casilla 34
            specialTiles[62] = 19; // Casilla 62 -> Casilla 19
            specialTiles[93] = 73; // Casilla 93 -> Casilla 73
            specialTiles[87] = 24; // Casilla 87 -> Casilla 24 (agregada una más)
        }

        // Lógica para el botón que lanza el dado
        private void btnRollDice_Click(object sender, EventArgs e)
        {

            int diceRoll = random.Next(1, 7); // Lanzar el dado (entre 1 y 6)
            MessageBox.Show($"Jugador {currentPlayer + 1} lanzó un {diceRoll}");

            MovePlayer(currentPlayer, diceRoll); // Mover al jugador según el dado
            UpdatePlayerPositions(); // Actualizar la visualización

            // Verificar si el jugador ha ganado
            if (playerPositions[currentPlayer] == 100)
            {
                MessageBox.Show($"¡Jugador {currentPlayer + 1} ha ganado!");
                btnRollDice.Enabled = false; // Deshabilitar el botón de tirar el dado
                return;
            }

            // Cambiar al siguiente jugador
            currentPlayer = (currentPlayer + 1) % 2;
            lblTurno.Text = $"Turno: Jugador {currentPlayer + 1}";
        }

        // Mover al jugador según el dado y las reglas de las serpientes y escaleras
        private void MovePlayer(int player, int steps)
        {
            int newPosition = playerPositions[player] + steps;

            // Si la nueva posición es mayor que 100, el jugador no se mueve
            if (newPosition > 100) return;

            // Verificar si el jugador cae en una serpiente o una escalera
            if (specialTiles.ContainsKey(newPosition))
            {
                int previousPosition = playerPositions[player];
                playerPositions[player] = specialTiles[newPosition]; // Mover al jugador a la nueva posición

                // Verificar si el jugador sube por una escalera o baja por una serpiente
                if (previousPosition < playerPositions[player])
                {
                    MessageBox.Show($"¡Jugador {player + 1} subió por una escalera a la casilla {playerPositions[player]}!");
                }
                else
                {
                    MessageBox.Show($"¡Jugador {player + 1} bajó por una serpiente a la casilla {playerPositions[player]}!");
                }
            }
            else
            {
                // Si no cayó en una serpiente o escalera, solo actualizamos la posición
                playerPositions[player] = newPosition;
            }
        }

        // Actualizar las posiciones de los jugadores en el tablero
        private void UpdatePlayerPositions()
        {
            foreach (Button btn in pnlBoard.Controls.OfType<Button>())
            {
                int boardNumber = (int)btn.Tag;
                btn.BackColor = Color.White; // Resetear el color de todas las casillas
            }

            // Pintar la casilla del Jugador 1
            Button player1Button = pnlBoard.Controls.OfType<Button>()
                .FirstOrDefault(b => (int)b.Tag == playerPositions[0]);
            if (player1Button != null) player1Button.BackColor = Color.Blue;

            // Pintar la casilla del Jugador 2
            Button player2Button = pnlBoard.Controls.OfType<Button>()
                .FirstOrDefault(b => (int)b.Tag == playerPositions[1]);
            if (player2Button != null) player2Button.BackColor = Color.Red;

            // Actualizar los labels de las posiciones
            lblPlayer1.Text = $"Jugador 1: Casilla {playerPositions[0]}";
            lblPlayer2.Text = $"Jugador 2: Casilla {playerPositions[1]}";
        }

        // Evento Load del formulario
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlBoard_cl(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Restablecer las posiciones de los jugadores a la casilla 1
            playerPositions = new int[] { 1, 1 };

            // Restablecer el turno al Jugador 1 (jugador 0)
            currentPlayer = 0;

            // Actualizar la visualización de las posiciones de los jugadores en el tablero
            UpdatePlayerPositions();

            // Habilitar nuevamente el botón de tirar el dado
            btnRollDice.Enabled = true;

            // Actualizar el texto del turno
            lblTurno.Text = "Turno: Jugador 1";

            // Opcional: Mostrar un mensaje indicando que el juego ha sido reiniciado
            MessageBox.Show("El juego ha sido reiniciado.");
        }
    }
}
