using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsAddRequest : RestRequest
    {
        public LabelsAddRequest(NewLabel label)
            : base("labels", Method.POST)
        {
            Guard.NotNull(label, "label");
            AddParameter("idBoard", label.IdBoard.GetBoardId());

            AddParameter("color", label.Color);

            Guard.RequiredTrelloString(label.Name, "name");
            AddParameter("name", label.Name);
        }

        public LabelsAddRequest(string boardId, Color color, string name)
            : this(new NewLabel(name, color, new BoardId(boardId)))
        {
        }
    }
}