using System.Threading.Tasks;
using System.Collections.Generic;

namespace TrelloNet.Internal
{
    internal class AsyncLabels : IAsyncLabels
    {
        private readonly TrelloRestClient _restClient;

        internal AsyncLabels(TrelloRestClient restClient)
        {
            _restClient = restClient;
        }

        public Task<Label> WithId(string labelId)
        {
            return _restClient.RequestAsync<Label>(new LabelsWithIdRequest(labelId));
        }

        public Task<IEnumerable<Label>> ForBoard(IBoardId board, int limit = 50)
        {
            return _restClient.RequestListAsync<Label>(new LabelsForBoardRequest(board, limit));
        }

        public Task<Label> Add(NewLabel label)
        {
            return _restClient.RequestAsync<Label>(new LabelsAddRequest(label));
        }

        public Task<Label> Add(IBoardId board, Color color, string name)
        {
            return this.Add(new NewLabel(name, color, board));
        }

        public Task ChangeName(ILabelId label, string name)
        {
            return _restClient.RequestAsync(new LabelsChangeNameRequest(label, name));
        }

        public Task ChangeColor(ILabelId label, Color color)
        {
            return _restClient.RequestAsync(new LabelsChangeColorRequest(label, color));
        }

        public Task Update(IUpdatableLabel label)
        {
            return _restClient.RequestAsync(new LabelsUpdateRequest(label));
        }

        public Task Remove(ILabelId label)
        {
            return _restClient.RequestAsync(new LabelsDeleteRequest(label));
        }
    }
}