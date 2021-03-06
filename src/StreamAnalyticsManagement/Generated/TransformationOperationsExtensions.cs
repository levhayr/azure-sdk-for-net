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
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    public static partial class TransformationOperationsExtensions
    {
        /// <summary>
        /// Create or update a transformation for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a
        /// transformation for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the transformation create operation.
        /// </returns>
        public static TransformationCreateOrUpdateResponse CreateOrUpdate(this ITransformationOperations operations, string resourceGroupName, string jobName, TransformationCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITransformationOperations)s).CreateOrUpdateAsync(resourceGroupName, jobName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a transformation for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a
        /// transformation for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the transformation create operation.
        /// </returns>
        public static Task<TransformationCreateOrUpdateResponse> CreateOrUpdateAsync(this ITransformationOperations operations, string resourceGroupName, string jobName, TransformationCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, jobName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a transformation for a stream analytics job. The
        /// raw json content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='transformationName'>
        /// Required. The name of the transformation for the stream analytics
        /// job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a
        /// transformation for the stream analytics job. It is in json format.
        /// </param>
        /// <returns>
        /// The response of the transformation create operation.
        /// </returns>
        public static TransformationCreateOrUpdateResponse CreateOrUpdateWithRawJsonContent(this ITransformationOperations operations, string resourceGroupName, string jobName, string transformationName, TransformationCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITransformationOperations)s).CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, transformationName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a transformation for a stream analytics job. The
        /// raw json content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='transformationName'>
        /// Required. The name of the transformation for the stream analytics
        /// job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a
        /// transformation for the stream analytics job. It is in json format.
        /// </param>
        /// <returns>
        /// The response of the transformation create operation.
        /// </returns>
        public static Task<TransformationCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(this ITransformationOperations operations, string resourceGroupName, string jobName, string transformationName, TransformationCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, transformationName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the transformation for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='transformationName'>
        /// Required. The name of the transformation for the stream analytics
        /// job.
        /// </param>
        /// <returns>
        /// The response of the transformation get operation.
        /// </returns>
        public static TransformationsGetResponse Get(this ITransformationOperations operations, string resourceGroupName, string jobName, string transformationName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITransformationOperations)s).GetAsync(resourceGroupName, jobName, transformationName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the transformation for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='transformationName'>
        /// Required. The name of the transformation for the stream analytics
        /// job.
        /// </param>
        /// <returns>
        /// The response of the transformation get operation.
        /// </returns>
        public static Task<TransformationsGetResponse> GetAsync(this ITransformationOperations operations, string resourceGroupName, string jobName, string transformationName)
        {
            return operations.GetAsync(resourceGroupName, jobName, transformationName, CancellationToken.None);
        }
        
        /// <summary>
        /// Update an transformation for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='transformationName'>
        /// Required. The name of the transformation for the stream analytics
        /// job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to update an transformation for
        /// the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the transformation patch operation.
        /// </returns>
        public static TransformationPatchResponse Patch(this ITransformationOperations operations, string resourceGroupName, string jobName, string transformationName, TransformationPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITransformationOperations)s).PatchAsync(resourceGroupName, jobName, transformationName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update an transformation for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.ITransformationOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='transformationName'>
        /// Required. The name of the transformation for the stream analytics
        /// job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to update an transformation for
        /// the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the transformation patch operation.
        /// </returns>
        public static Task<TransformationPatchResponse> PatchAsync(this ITransformationOperations operations, string resourceGroupName, string jobName, string transformationName, TransformationPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, jobName, transformationName, parameters, CancellationToken.None);
        }
    }
}
