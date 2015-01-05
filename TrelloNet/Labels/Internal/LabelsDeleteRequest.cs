using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsDeleteRequest : LabelsRequest
    {
        public LabelsDeleteRequest(ILabelId label)
            : base(label, method: Method.DELETE)
        {
        }
    }
}