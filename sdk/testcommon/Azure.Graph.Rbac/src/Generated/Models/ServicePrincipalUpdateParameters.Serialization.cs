// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class ServicePrincipalUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (AccountEnabled != null)
            {
                writer.WritePropertyName("accountEnabled");
                writer.WriteBooleanValue(AccountEnabled.Value);
            }
            if (AppRoleAssignmentRequired != null)
            {
                writer.WritePropertyName("appRoleAssignmentRequired");
                writer.WriteBooleanValue(AppRoleAssignmentRequired.Value);
            }
            if (KeyCredentials != null)
            {
                writer.WritePropertyName("keyCredentials");
                writer.WriteStartArray();
                foreach (var item in KeyCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PasswordCredentials != null)
            {
                writer.WritePropertyName("passwordCredentials");
                writer.WriteStartArray();
                foreach (var item in PasswordCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ServicePrincipalType != null)
            {
                writer.WritePropertyName("servicePrincipalType");
                writer.WriteStringValue(ServicePrincipalType);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
