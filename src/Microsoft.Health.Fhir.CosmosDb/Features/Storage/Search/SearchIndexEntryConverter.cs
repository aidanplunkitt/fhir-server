﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using System.Collections.Concurrent;
using Microsoft.Health.Fhir.Core.Features.Search;
using Microsoft.Health.Fhir.CosmosDb.Features.Search;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Health.Fhir.CosmosDb.Features.Storage.Search
{
    public class SearchIndexEntryConverter : JsonConverter
    {
        private static readonly ConcurrentQueue<SearchIndexEntryJObjectGenerator> CachedGenerators = new ConcurrentQueue<SearchIndexEntryJObjectGenerator>();

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(SearchIndexEntry);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // We don't currently support reading the search index from the Cosmos DB.
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var searchIndexEntry = (SearchIndexEntry)value;

            // Cached the object generator for reuse.
            if (!CachedGenerators.TryDequeue(out SearchIndexEntryJObjectGenerator generator))
            {
                generator = new SearchIndexEntryJObjectGenerator();
            }

            JObject generatedObj;

            try
            {
                searchIndexEntry.Value.AcceptVisitor(generator);

                generatedObj = generator.Output;
            }
            finally
            {
                generator.Reset();

                CachedGenerators.Enqueue(generator);
            }

            generatedObj.AddFirst(
                new JProperty(SearchValueConstants.ParamName, searchIndexEntry.SearchParameter.Name));

            generatedObj.WriteTo(writer);
        }
    }
}
