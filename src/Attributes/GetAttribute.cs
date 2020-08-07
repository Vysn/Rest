namespace Vysn.Rest.Attributes {
    internal sealed class GetAttribute : RouteAttribute {
        public GetAttribute(string path) : base(path) { }
    }
}