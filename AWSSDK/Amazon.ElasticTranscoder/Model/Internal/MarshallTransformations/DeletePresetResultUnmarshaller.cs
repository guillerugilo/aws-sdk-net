/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DeletePresetResultUnmarshaller
      /// </summary>
      internal class DeletePresetResultUnmarshaller : IUnmarshaller<DeletePresetResult, XmlUnmarshallerContext>, IUnmarshaller<DeletePresetResult, JsonUnmarshallerContext>
      {
        DeletePresetResult IUnmarshaller<DeletePresetResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DeletePresetResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            DeletePresetResult deletePresetResult = new DeletePresetResult();
          

            return deletePresetResult;
        }

        private static DeletePresetResultUnmarshaller instance;
        public static DeletePresetResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DeletePresetResultUnmarshaller();
            return instance;
        }
    }
}
  
