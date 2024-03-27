﻿using Microsoft.EntityFrameworkCore;

namespace PnP.Scanning.Core.Storage
{
    [Index(nameof(ScanId), [nameof(Key)], IsUnique = true)]
    internal sealed class Cache
    {
        public Guid ScanId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
