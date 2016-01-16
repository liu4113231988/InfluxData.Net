﻿using InfluxData.Net.InfluxDb.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfluxData.Net.InfluxDb.ResponseParsers
{
    public interface ICqResponseParser
    {
        IEnumerable<ContinuousQuery> GetContinuousQueries(string dbName, IEnumerable<Serie> series);
    }
}