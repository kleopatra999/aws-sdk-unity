//
// Copyright 2014-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//
// Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
// You may not use this file except in compliance with the License.
// A copy of the License is located in the "license" file accompanying this file.
// See the License for the specific language governing permissions and limitations under the License.
//
//

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request deletion of the lifecycle configuration on a bucket. 
    /// </summary>
    /// <remarks>
    /// <para>
    /// Amazon S3 removes all the lifecycle configuration rules in the lifecycle subresource associated with the bucket. 
    /// Your objects never expire, and Amazon S3 no longer automatically deletes any objects on the basis of rules contained 
    /// in the deleted lifecycle configuration.
    /// </para>
    /// <para>
    /// To use this operation, you must have permission to perform the s3:PutLifecycleConfiguration action. By default, the 
    /// bucket owner has this permission and the bucket owner can grant this permission to others.
    /// </para>
    /// <para>
    /// There is usually some time lag before lifecycle configuration deletion is fully propagated to all the Amazon S3 systems.
    /// </para>
    /// </remarks>
    public partial class DeleteLifecycleConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;

        /// <summary>
        /// The name of the bucket on which the lifecycle configuration is to be deleted.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

    }
}
    