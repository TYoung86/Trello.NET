using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsUpdateRequest : LabelsRequest
    {
        public LabelsUpdateRequest(IUpdatableLabel label)
            : base(label.Id, method: Method.PUT)
        {
            Guard.RequiredTrelloString(label.Name, "name");

            AddParameter("name", label.Name);
            AddParameter("color", label.Color);
        }
    }
}