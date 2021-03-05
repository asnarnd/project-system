﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System;
using Microsoft.VisualStudio.ProjectSystem.Properties;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Query
{
    /// <summary>
    /// An implementation of <see cref="IProjectPropertiesContext"/> for use in the
    /// Project Query API implementation.
    /// </summary>
    /// <remarks>
    /// The point here is to capture the context for a part of a query execution in a
    /// manner that can be passed from one provider to another and is also suitable as a
    /// key into a cache (such as the <see cref="IPropertyPageQueryCache"/>).
    /// </remarks>
    internal sealed class QueryProjectPropertiesContext : IProjectPropertiesContext, IEquatable<QueryProjectPropertiesContext>
    {
        public static readonly QueryProjectPropertiesContext ProjectFile = new(isProjectFile: true, file: string.Empty, itemType: null, itemName: null);

        public QueryProjectPropertiesContext(bool isProjectFile, string file, string? itemType, string? itemName)
        {
            IsProjectFile = isProjectFile;
            File = file;
            ItemType = itemType;
            ItemName = itemName;
        }

        public bool IsProjectFile { get; }

        public string File { get; }

        public string? ItemType { get; }

        public string? ItemName { get; }

        public bool Equals(QueryProjectPropertiesContext? other)
        {
            return other is not null
                && IsProjectFile == other.IsProjectFile
                && StringComparers.Paths.Equals(File, other.File)
                && StringComparers.ItemTypes.Equals(ItemType, other.ItemType)
                && StringComparers.ItemNames.Equals(ItemName, other.ItemName);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as QueryProjectPropertiesContext);
        }

        public override int GetHashCode()
        {
            int hashCode = IsProjectFile.GetHashCode();
            hashCode = (hashCode * -1521134295) + StringComparers.Paths.GetHashCode(File);
            
            if (ItemType is not null)
            {
                hashCode = (hashCode * -1521134295) + StringComparers.ItemTypes.GetHashCode(ItemType);
            }
            
            if (ItemName is not null)
            {
                hashCode = (hashCode * -1521134295) + StringComparers.ItemNames.GetHashCode(ItemName);
            }

            return hashCode;
        }
    }
}
