using AutoMapper;
using Microsoft.Bot.Connector;
using TeamsTalentMgmtAppV3.Models.DatabaseContext;
using TeamsTalentMgmtAppV3.Models.Extensions;

namespace TeamsTalentMgmtAppV3.TypeConverters
{
    public class PositionToThumbnailCardTypeConverter : ITypeConverter<Position, ThumbnailCard>
    {
        public ThumbnailCard Convert(Position position, ThumbnailCard card, ResolutionContext _)
        {
            if (position is null)
            {
                return null;
            }

            if (card is null)
            {
                card = new ThumbnailCard();
            }

            card.Title = $"{position.Title} / {position.PositionExternalId}";
            card.Text = $"Hiring manager: {position.HiringManager.Name} | {position.Location.GetLocationString()}";
            
            return card;
        }
    }
}