﻿using prmToolkit.NotificationPattern;
using System;

namespace Saipher.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
