using System;
using Vysn.Rest.Attributes.Enums;

namespace Vysn.Rest.Attributes {
    internal sealed class RouteAttribute : Attribute {
        public HttpType Type { get; }
        public string Path { get; }

        public RouteAttribute(HttpType httpType, string path) {
            Type = httpType;
            Path = path;
        }
    }
}