﻿using Microsoft.EntityFrameworkCore;

namespace PnP.Scanning.Core.Storage
{
    [Index(new string[] { nameof(ScanId), nameof(SiteUrl), nameof(WebUrl), nameof(ListId), nameof(ContentTypeId), nameof(FieldId) }, IsUnique = true)]
    internal sealed class SyntexContentTypeField: BaseScanResult
    {
        public Guid ListId { get; set; }

        public string ContentTypeId { get; set; }

        public Guid FieldId { get; set; }

        public string InternalName { get; set; }

        public string Name { get; set; }

        public string TypeAsString { get; set; }

        public bool Required  { get; set; }

        public bool Hidden { get; set; }

        public Guid TermSetId { get; set; }
    }
}
