﻿using Lime.Protocol;
using Lime.Transport.Http.Storage;

namespace Lime.Transport.Http.Processors
{
    public sealed class GetNotificationsHttpProcessor : GetEnvelopesHttpProcessor<Notification>
    {
        #region Constructor

        public GetNotificationsHttpProcessor(IEnvelopeStorage<Notification> notificationStorage)
            : base(notificationStorage, Constants.NOTIFICATIONS_PATH)
        {

        }

        #endregion
    }
}