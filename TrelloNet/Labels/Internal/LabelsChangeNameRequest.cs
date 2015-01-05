using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsChangeNameRequest : LabelsRequest
    {
        public LabelsChangeNameRequest(ILabelId label, string name)
            : base(label, "name", Method.PUT)
        {
            Guard.RequiredTrelloString(name, "name");
            this.AddValue(name);			
        }
    }
}