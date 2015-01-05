using RestSharp;

namespace TrelloNet.Internal
{
    internal class CardsAddLabelRequest : CardsRequest
    {
        public CardsAddLabelRequest(ICardId card, Color color)
            : base(card, "labels", Method.POST)
        {
            Guard.NotNull(color, "color");

            this.AddValue(color.ColorName);
        }

        public CardsAddLabelRequest(ICardId card, ILabelId labelId)
            : base(card, "idLabels", Method.POST)
        {
            AddParameter("value", labelId.GetLabelId());
        }
    }
}