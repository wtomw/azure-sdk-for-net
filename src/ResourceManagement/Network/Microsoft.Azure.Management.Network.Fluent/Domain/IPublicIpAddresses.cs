// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure.Management.Network.Fluent.PublicIPAddress.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// Entry point to public IP address management.
    /// </summary>
    public interface IPublicIPAddresses  :
        ISupportsListing<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsCreating<PublicIPAddress.Definition.IBlank>,
        ISupportsDeletingById,
        ISupportsListingByResourceGroup<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsGettingByResourceGroup<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsGettingById<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsDeletingByResourceGroup,
        ISupportsBatchCreation<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        ISupportsBatchDeletion,
        IHasManager<Microsoft.Azure.Management.Network.Fluent.INetworkManager>,
        IHasInner<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddressesOperations>
    {
    }
}