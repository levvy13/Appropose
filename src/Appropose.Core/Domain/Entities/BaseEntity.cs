﻿using Newtonsoft.Json;

namespace Appropose.Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        [JsonProperty(PropertyName = "id")]
        public virtual string Id { get; set; }
    }
}
