using System.Collections.Generic;

namespace TrelloNet.Internal
{
    internal class Labels : ILabels
    {
        private readonly TrelloRestClient _restClient;

        internal Labels(TrelloRestClient restClient)
        {
            _restClient = restClient;
        }

        public Label WithId(string labelId)
        {
            return _restClient.Request<Label>(new LabelsWithIdRequest(labelId));
        }

        public IEnumerable<Label> ForBoard(IBoardId board, int limit = 50)
        {
            return _restClient.Request<List<Label>>(new LabelsForBoardRequest(board, limit));
        }

        public Label Add(NewLabel label)
        {
            return _restClient.Request<Label>(new LabelsAddRequest(label));
        }

        public Label Add(IBoardId board, Color color, string name)
        {
            return this.Add(new NewLabel(name, color, board));
        }

        public void ChangeName(ILabelId label, string name)
        {
            _restClient.Request(new LabelsChangeNameRequest(label, name));
        }

        public void ChangeColor(ILabelId label, Color color)
        {
            _restClient.Request(new LabelsChangeColorRequest(label, color));
        }

        public void Update(IUpdatableLabel label)
        {
            _restClient.Request(new LabelsUpdateRequest(label));
        }

        public void Remove(ILabelId label)
        {
            _restClient.Request(new LabelsDeleteRequest(label));
        }
    }
}