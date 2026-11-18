using ActiveCampaignPlatform.API.Shared.Domain.Model.Events;
using Cortex.Mediator.Notifications;

namespace ActiveCampaignPlatform.API.Shared.Application.Internal.EventHandlers;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
}