using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _8QueensChessPuzzle
{
    public partial class Form1 : Form
    {
        private const int BoardSize = 8;
        private Button[,] boardButtons = new Button[BoardSize, BoardSize];
        private int selectedRow = -1;
        private int selectedCol = -1;
        private readonly Font queenFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);

        public Form1()
        {
            InitializeComponent();
            // allow form to receive key events
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.Resize += Form1_Resize;

            InitializeChessBoard();
            CenterBoard();
        }

        private void InitializeChessBoard()
        {
            int tile = 50;
            panel1.Controls.Clear();
            panel1.Size = new Size(BoardSize * tile, BoardSize * tile);

            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    var button = new Button();
                    int r = row, c = col;
                    button.Size = new Size(tile, tile);
                    button.Location = new Point(c * tile, r * tile);
                    button.BackColor = ((r + c) % 2 == 0) ? Color.White : Color.Black;
                    button.Margin = Padding.Empty;
                    button.Font = queenFont;
                    button.Text = string.Empty;
                    button.Tag = new Point(r, c);
                    button.Click += (s, e) => SelectCell(r, c);

                    boardButtons[r, c] = button;
                    panel1.Controls.Add(button);
                }
            }
        }

        private void SelectCell(int row, int col)
        {
            // Deselect previous
            if (selectedRow >= 0 && selectedCol >= 0)
            {
                var prev = boardButtons[selectedRow, selectedCol];
                // restore original color
                prev.BackColor = ((selectedRow + selectedCol) % 2 == 0) ? Color.White : Color.Black;
            }

            // Select new
            selectedRow = row;
            selectedCol = col;
            var btn = boardButtons[row, col];
            btn.BackColor = Color.LightBlue;
            btn.Focus();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterBoard();
        }

        private void CenterBoard()
        {
            if (panel1 == null) return;
            int x = Math.Max(0, (this.ClientSize.Width - panel1.Width) / 2);
            int y = Math.Max(0, (this.ClientSize.Height - panel1.Height) / 2);
            panel1.Location = new Point(x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (selectedRow < 0 || selectedCol < 0) return;

            var btn = boardButtons[selectedRow, selectedCol];

            if (e.KeyCode == Keys.Q)
            {
                // place queen if no conflict
                if (btn.Text == "Q") return; // already a queen

                if (HasConflict(selectedRow, selectedCol))
                {
                    MessageBox.Show("Cannot place queen here: conflicts with existing queen.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btn.Text = "Q";
                btn.ForeColor = Color.DarkRed;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                // remove queen
                if (btn.Text == "Q")
                {
                    btn.Text = string.Empty;
                    e.Handled = true;
                }
            }
        }

        private bool HasConflict(int row, int col)
        {
            for (int r = 0; r < BoardSize; r++)
            {
                for (int c = 0; c < BoardSize; c++)
                {
                    if (r == row && c == col) continue;
                    if (boardButtons[r, c].Text == "Q")
                    {
                        if (r == row) return true;
                        if (c == col) return true;
                        if (Math.Abs(r - row) == Math.Abs(c - col)) return true;
                    }
                }
            }
            return false;
        }

        // Designer event handlers referenced in Form1.Designer.cs
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure instruction labels show multiple lines and are visible
            try
            {
                lblHowTo.AutoSize = false;
                lblDidYouKnow.AutoSize = false;
                lblStart.AutoSize = false;
                label1.AutoSize = false;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                    // Make the title span the board width and sit above it
                    int lblHeight = 48;
                    label1.Size = new Size(panel1.Width, lblHeight);
                    int lblX = panel1.Left;
                    int lblY = Math.Max(8, panel1.Top - lblHeight - 8);
                    label1.Location = new Point(lblX, lblY);
                // Make sure these are in front so they aren't obscured by the board panel
                label1.BringToFront();
                // if instructions are inside panel2, bring that panel to front
                if (this.Controls.Contains(panel2)) panel2.BringToFront();
                instructionsPanel.BringToFront();

                // adjust layout so board and instructions don't overlap
                CenterBoard();
            }
            catch
            {
                // ignore if controls are not yet created
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // optional: custom panel painting
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoard();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // validate current placement for conflicts
            for (int r = 0; r < BoardSize; r++)
            {
                for (int c = 0; c < BoardSize; c++)
                {
                    if (boardButtons[r, c].Text == "Q")
                    {
                        if (HasConflict(r, c))
                        {
                            MessageBox.Show("There is a conflict in the current placement.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("No conflicts detected.", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // attempt to find a random valid solution by shuffling columns
            var rnd = new Random();
            int[] cols = new int[BoardSize];
            for (int i = 0; i < BoardSize; i++) cols[i] = i;

            for (int attempt = 0; attempt < 10000; attempt++)
            {
                // shuffle
                for (int i = BoardSize - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    var tmp = cols[i]; cols[i] = cols[j]; cols[j] = tmp;
                }

                // check diagonals
                bool ok = true;
                for (int r = 0; r < BoardSize && ok; r++)
                {
                    for (int r2 = r + 1; r2 < BoardSize; r2++)
                    {
                        if (Math.Abs(r - r2) == Math.Abs(cols[r] - cols[r2])) { ok = false; break; }
                    }
                }

                if (ok)
                {
                    ClearBoard();
                    for (int r = 0; r < BoardSize; r++)
                    {
                        boardButtons[r, cols[r]].Text = "Q";
                        boardButtons[r, cols[r]].ForeColor = Color.DarkRed;
                    }
                    MessageBox.Show("Random solution placed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Failed to find a random solution. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAutoSolve_Click(object sender, EventArgs e)
        {
            int startRow = (int)nudStartRow.Value;
            int startCol = (int)nudStartCol.Value;
            int[] cols = Enumerable.Repeat(-1, BoardSize).ToArray();
            bool useStart = startRow >= 1 && startRow <= 8 && startCol >= 1 && startCol <= 8;
            if (useStart)
            {
                cols[startRow - 1] = startCol - 1;
            }

            bool solved = SolveFromRow(0, cols);
            if (solved)
            {
                ClearBoard();
                for (int r = 0; r < BoardSize; r++)
                {
                    int c = cols[r];
                    if (c >= 0)
                    {
                        boardButtons[r, c].Text = "Q";
                        boardButtons[r, c].ForeColor = Color.DarkRed;
                    }
                }
                MessageBox.Show("Solution found and placed on the board.", "Solved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No solution found with the given starting position.", "No Solution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SolveFromRow(int row, int[] cols)
        {
            if (row == BoardSize) return true;

            if (cols[row] != -1)
            {
                // verify no conflicts with earlier rows
                for (int r = 0; r < row; r++)
                {
                    if (cols[r] == -1) continue;
                    if (cols[r] == cols[row]) return false;
                    if (Math.Abs(r - row) == Math.Abs(cols[r] - cols[row])) return false;
                }
                return SolveFromRow(row + 1, cols);
            }

            for (int c = 0; c < BoardSize; c++)
            {
                bool conflict = false;
                for (int r = 0; r < row; r++)
                {
                    if (cols[r] == -1) continue;
                    if (cols[r] == c || Math.Abs(r - row) == Math.Abs(cols[r] - c)) { conflict = true; break; }
                }
                if (conflict) continue;
                cols[row] = c;
                if (SolveFromRow(row + 1, cols)) return true;
                cols[row] = -1;
            }

            return false;
        }

        private void ClearBoard()
        {
            for (int r = 0; r < BoardSize; r++)
                for (int c = 0; c < BoardSize; c++)
                {
                    boardButtons[r, c].Text = string.Empty;
                }
        }
    }
}
