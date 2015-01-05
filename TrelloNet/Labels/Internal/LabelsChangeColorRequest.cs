using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsChangeColorRequest : LabelsRequest
    {
        public LabelsChangeColorRequest(ILabelId label, Color color)
            : base(label, "color", Method.PUT)
        {
            this.AddValue(color);			
        }
    }
}