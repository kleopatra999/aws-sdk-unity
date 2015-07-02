//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleNotificationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetPlatformApplicationAttributes Request Marshaller
    /// </summary>       
    public class SetPlatformApplicationAttributesRequestMarshaller : IMarshaller<IRequest, SetPlatformApplicationAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetPlatformApplicationAttributesRequest)input);
        }
    
        public IRequest Marshall(SetPlatformApplicationAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleNotificationService");
            request.Parameters.Add("Action", "SetPlatformApplicationAttributes");
            request.Parameters.Add("Version", "2010-03-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttributes())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.Attributes.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.Attributes.TryGetValue(key, out value);
                        request.Parameters.Add("Attributes" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("Attributes" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetPlatformApplicationArn())
                {
                    request.Parameters.Add("PlatformApplicationArn", StringUtils.FromString(publicRequest.PlatformApplicationArn));
                }
            }
            return request;
        }
    }
}