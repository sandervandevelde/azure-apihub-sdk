﻿using System;
using Newtonsoft.Json;

namespace Microfoft.Azure.ApiHub.Sdk.Management.Entities
{
    public class ArmEnvelope<T> where T : class
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public T Properties { get; set; }
    }
}