using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Model.Tag;
using Unity.UOS.COSXML.Transfer;

namespace Unity.UOS.COSXML.Model.Bucket
{
    public sealed class ListBucketVersionsResult : CosDataResult<ListBucketVersions>
    {
        public ListBucketVersions listBucketVersions { 
            get {return _data; } 
        }
    }
}