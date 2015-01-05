using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsRequest : RestRequest
    {
        public LabelsRequest(ILabelId label, string resource = "", Method method = Method.GET)
            : base("labels/{labelId}/" + resource, method)
        {
            Guard.NotNull(label, "label");
            AddParameter("labelId", label.GetLabelId(), ParameterType.UrlSegment);
        }

        public LabelsRequest(string labelId, string resource = "", Method method = Method.GET)
            : this(new LabelId(labelId), resource, method)
        {
        }
    }
}