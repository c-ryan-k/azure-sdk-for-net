// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    internal partial class CopyResult
    {
        internal static CopyResult DeserializeCopyResult(JsonElement element)
        {
            Guid modelId = default;
            IReadOnlyList<FormRecognizerError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"))
                {
                    modelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                        }
                    }
                    errors = array;
                    continue;
                }
            }
            return new CopyResult(modelId, errors);
        }
    }
}
