﻿namespace SIVAG_BACKEND.Models
{
    public class API_Respones<T>
    {
            public T? data { get; set; }
            public string? Message { get; set; }
            public int StatusCode { get; set; }
    }
}