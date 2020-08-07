using System;

namespace Vysn.Rest.Attributes {
    [AttributeUsage(AttributeTargets.Method)]
    internal class RouteAttribute : Attribute {
        /// <summary>
        /// 
        /// </summary>
        public string Path { get; }

        public RouteAttribute(string path) {
            Path = path;
        }
    }
}