namespace TrelloNet.Internal
{
    internal class LabelsWithIdRequest : LabelsRequest
    {
        public LabelsWithIdRequest(string labelId)
            : base(labelId)
        {
        }
    }
}