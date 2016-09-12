﻿using System;

namespace RedisMicroservices.Core.Domain
{
    public class SampleData: IDataModel
    {
        public Guid Id { get; set; }

        public string Version { get; set; }

        public string LanguageCode { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}