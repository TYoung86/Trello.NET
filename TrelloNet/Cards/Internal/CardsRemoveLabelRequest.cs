using RestSharp;

namespace TrelloNet.Internal
{
    internal class CardsRemoveLabelRequest : CardsRequest
    {
        public CardsRemoveLabelRequest(ICardId card, Color color)
            : base(card, "labels/{color}", Method.DELETE)
        {
            Guard.NotNull(color, "color");

            AddParameter("color", color.ColorName, ParameterType.UrlSegment);
        }

        public CardsRemoveLabelRequest(ICardId card, ILabelId labelId)
            : base(card, "idLabels", Method.DELETE)
        {
            AddParameter("value", labelId.GetLabelId());
        }
    }
}