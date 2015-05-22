﻿using System;
using System.Collections.Generic;

namespace TechTalk.SpecFlow.Assist.ValueRetrievers
{
    public class NullableLongValueRetriever : IValueRetriever
    {
        private readonly Func<string, long> longValueRetriever = v => new LongValueRetriever().GetValue(v);

        public NullableLongValueRetriever(Func<string, long> longValueRetriever = null)
        {
            if (longValueRetriever != null)
                this.longValueRetriever = longValueRetriever;
        }

        public long? GetValue(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            return longValueRetriever(value);
        }

        public object ExtractValueFromRow(TableRow row, Type targetType)
        {
            return GetValue(row[1]);
        }

        public IEnumerable<Type> TypesForWhichIRetrieveValues()
        {
            return new Type[]{ typeof(long?) };
        }
    }
}