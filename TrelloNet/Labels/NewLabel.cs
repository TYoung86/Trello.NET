using TrelloNet.Internal;

namespace TrelloNet
{
    public class NewLabel
    {
        /// <summary>
        /// A string with a length from 1 to 16384 (required).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A valid label color or null
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Id of the board that the label should be added to (required).
        /// </summary>
        public IBoardId IdBoard { get; set; }

        /// <param name="name">A string with a length from 1 to 16384.</param>
        /// <param name="color">A valid label color or null.</param>
        /// <param name="board">Id of the board that the list should be added to.</param>
        public NewLabel(string name, Color color, IBoardId board)
        {
            Guard.NotNull(board, "board");

            Name = name;
            Color = color;
            IdBoard = board;
        }
    }
}