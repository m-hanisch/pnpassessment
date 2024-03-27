﻿using Microsoft.EntityFrameworkCore;

namespace PnP.Scanning.Core.Storage
{
    [Index(nameof(ScanId), [nameof(SiteUrl), nameof(WebUrl), nameof(ListId), nameof(ContentTypeId)], IsUnique = true)]
    [Index(nameof(ScanId), [nameof(ContentTypeId)])]
    internal sealed class SyntexContentType: BaseScanResult
    {
        public Guid ListId { get; set; }

        public string ContentTypeId { get; set; }

        public string ListContentTypeId { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }

        public bool Hidden { get; set; }

        public string DocumentTemplate { get; set; }

        public int FieldCount { get; set; }

        public int ItemCount { get; set; }
    }
}
