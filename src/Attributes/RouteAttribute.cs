using System;
using Vysn.Rest.Attributes.Enums;

namespace Vysn.Rest.Attributes {
    [AttributeUsage(AttributeTargets.Method)]
    internal sealed class RouteAttribute : Attribute {
        /// <summary>
        /// 
        /// </summary>
        public HttpType Type { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Path { get; }

        public RouteAttribute(HttpType httpType, string path) {
            Type = httpType;
            Path = path;
        }
    }
}