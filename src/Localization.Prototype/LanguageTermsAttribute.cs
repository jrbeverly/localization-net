using System;

namespace Localization.Prototype
{
    [AttributeUsage(AttributeTargets.Interface)]
    public sealed class LanguageTermsAttribute : Attribute
    {
        public string DisplayName;

        public LanguageTermsAttribute(string name)
        {
            DisplayName = name;
        }
    }
}
