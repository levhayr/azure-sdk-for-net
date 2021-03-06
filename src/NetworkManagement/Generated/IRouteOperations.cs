// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network
{
    /// <summary>
    /// The Network Management API includes operations for managing the routes
    /// for your subscription.
    /// </summary>
    public partial interface IRouteOperations
    {
        /// <summary>
        /// Set the specified route table for the provided subnet in the
        /// provided virtual network in this subscription.
        /// </summary>
        /// <param name='vnetName'>
        /// The name of the virtual network that contains the provided subnet.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet that the route table will be added to.
        /// </param>
        /// <param name='parameters'>
        /// The parameters necessary to add a route table to the provided
        /// subnet.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> AddRouteTableToSubnetAsync(string vnetName, string subnetName, AddRouteTableToSubnetParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Set the specified route table for the provided subnet in the
        /// provided virtual network in this subscription.
        /// </summary>
        /// <param name='vnetName'>
        /// The name of the virtual network that contains the provided subnet.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet that the route table will be added to.
        /// </param>
        /// <param name='parameters'>
        /// The parameters necessary to add a route table to the provided
        /// subnet.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginAddRouteTableToSubnetAsync(string vnetName, string subnetName, AddRouteTableToSubnetParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create the specified route table for this subscription.
        /// </summary>
        /// <param name='parameters'>
        /// The parameters necessary to create a new route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginCreateRouteTableAsync(CreateRouteTableParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Set the specified route for the provided table in this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table where the provided route will be set.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route that will be set on the provided route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginDeleteRouteAsync(string routeTableName, string routeName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the specified route table for this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginDeleteRouteTableAsync(string routeTableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Remove the route table from the provided subnet in the provided
        /// virtual network in this subscription.
        /// </summary>
        /// <param name='vnetName'>
        /// The name of the virtual network that contains the provided subnet.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet that the route table will be removed from.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginRemoveRouteTableFromSubnetAsync(string vnetName, string subnetName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Set the specified route for the provided table in this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table where the provided route will be set.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route that will be set on the provided route table.
        /// </param>
        /// <param name='parameters'>
        /// The parameters necessary to create a new route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginSetRouteAsync(string routeTableName, string routeName, SetRouteParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create the specified route table for this subscription.
        /// </summary>
        /// <param name='parameters'>
        /// The parameters necessary to create a new route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> CreateRouteTableAsync(CreateRouteTableParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Set the specified route for the provided table in this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table where the provided route will be set.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route that will be set on the provided route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteRouteAsync(string routeTableName, string routeName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the specified route table for this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteRouteTableAsync(string routeTableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the specified route table for this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table in this subscription to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GetRouteTableResponse> GetRouteTableAsync(string routeTableName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the specified route table for the provided subnet in the
        /// provided virtual network in this subscription.
        /// </summary>
        /// <param name='vnetName'>
        /// The name of the virtual network that contains the provided subnet.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GetRouteTableForSubnetResponse> GetRouteTableForSubnetAsync(string vnetName, string subnetName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the specified route table for this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table in this subscription to retrieve.
        /// </param>
        /// <param name='detailLevel'>
        /// The amount of detail about the requested route table that will be
        /// returned.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<GetRouteTableResponse> GetRouteTableWithDetailsAsync(string routeTableName, string detailLevel, CancellationToken cancellationToken);
        
        /// <summary>
        /// List the existing route tables for this subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<ListRouteTablesResponse> ListRouteTablesAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Remove the route table from the provided subnet in the provided
        /// virtual network in this subscription.
        /// </summary>
        /// <param name='vnetName'>
        /// The name of the virtual network that contains the provided subnet.
        /// </param>
        /// <param name='subnetName'>
        /// The name of the subnet that the route table will be removed from.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> RemoveRouteTableFromSubnetAsync(string vnetName, string subnetName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Set the specified route for the provided table in this subscription.
        /// </summary>
        /// <param name='routeTableName'>
        /// The name of the route table where the provided route will be set.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route that will be set on the provided route table.
        /// </param>
        /// <param name='parameters'>
        /// The parameters necessary to create a new route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> SetRouteAsync(string routeTableName, string routeName, SetRouteParameters parameters, CancellationToken cancellationToken);
    }
}
