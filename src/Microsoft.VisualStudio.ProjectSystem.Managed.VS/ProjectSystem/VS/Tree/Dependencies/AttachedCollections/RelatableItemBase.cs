﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using Microsoft.Internal.VisualStudio.PlatformUI;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Tree.Dependencies.AttachedCollections
{
    /// <summary>
    /// Base class for <see cref="IRelatableItem"/> implementations. Derives from <see cref="AttachedCollectionItemBase"/>
    /// to include common patterns for attached items.
    /// </summary>
    public abstract partial class RelatableItemBase : AttachedCollectionItemBase, IRelatableItem
    {
        private AggregateContainsRelationCollection? _containsCollection;

        protected RelatableItemBase(string name)
            : base(name)
        {
        }

        public abstract object Identity { get; }

        protected override IContextMenuController? ContextMenuController => DefaultContextMenuController.Instance;

        AggregateContainsRelationCollection? IRelatableItem.ContainsCollection => _containsCollection;

        AggregateContainedByRelationCollection? IRelatableItem.ContainedByCollection { get; set; }

        bool IRelatableItem.TryGetOrCreateContainsCollection(
            IRelationProvider relationProvider,
            [NotNullWhen(returnValue: true)] out AggregateContainsRelationCollection? relationCollection)
        {
            if (_containsCollection == null && AggregateContainsRelationCollection.TryCreate(this, relationProvider, out AggregateContainsRelationCollection? collection))
            {
                _containsCollection = collection;
            }

            relationCollection = _containsCollection;
            return relationCollection != null;
        }

        bool IRelatableItem.TryGetProjectNode(IProjectTree targetRootNode, IRelatableItem item, [NotNullWhen(returnValue: true)] out IProjectTree? projectTree)
        {
            return TryGetProjectNode(targetRootNode, item, out projectTree);
        }

        protected virtual bool TryGetProjectNode(IProjectTree targetRootNode, IRelatableItem item, [NotNullWhen(returnValue: true)] out IProjectTree? projectTree)
        {
            projectTree = null;
            return false;
        }
    }
}
