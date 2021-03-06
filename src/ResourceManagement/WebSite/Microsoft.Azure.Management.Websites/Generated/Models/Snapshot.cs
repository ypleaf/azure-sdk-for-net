// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A snapshot of a web app
    /// </summary>
    [JsonTransformation]
    public partial class Snapshot : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot() { }

        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot(string name, string location, string id = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DateTime? time = default(DateTime?))
            : base(name, location, id, kind, type, tags)
        {
            Time = time;
        }

        /// <summary>
        /// The time the snapshot was taken
        /// </summary>
        [JsonProperty(PropertyName = "properties.time")]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
