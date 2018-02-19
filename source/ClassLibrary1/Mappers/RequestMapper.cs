﻿using System.Collections.Generic;
using ClassLibrary1.Model;

namespace ClassLibrary1.Mappers
{
    internal class RequestMapper
    {
        internal static Request Map(IDictionary<string, object> request)
        {
            if (request == null)
                return null;

            return new Request(ParameterMapper.Map(request["queryParameters"] as object[]), ParameterMapper.Map(request["headers"] as object[]),
                PayloadMapper.Map(request["payloads"] as object[]), ShapeMapper.Map(request["queryString"] as IDictionary<string, object>));
        }
    }
}