using System;

namespace Localization.Prototype
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public sealed class LangTermAttribute : Attribute
    {
        public string Namespace;

        public LangTermAttribute(string name)
        {
            Namespace = name;
        }
    }
}
