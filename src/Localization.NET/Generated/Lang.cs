using Localization.Prototype;

namespace Localization.NET.Generated
{
    public sealed class Lang
    {
        /// <summary>
        /// Generated language terms for the class <see cref="Localization.NET.MyApp"/>
        /// </summary>
        /// <remarks>
        /// Note: This is not currently generated, just a concept of how it would work if it were to be generated.
        /// </remarks>
        public sealed class MyApp : NET.MyApp.ILanguageTerms
        {
            public LanguageTerm Goodbye => new LanguageTerm("Goodbye! It was fun!");

            public LanguageTerm Hello => new LanguageTerm("Hello! Lets say hello to everything.");

            public LanguageTerm Count(int count)
            {
                return new LanguageTerm(string.Format("We need to greet {0} people.", count));
            }
        }

        /// <summary>
        /// Generated language terms for the class <see cref="Localization.NET.MyGreeter"/>
        /// </summary>
        /// <remarks>
        /// Note: This is not currently generated, just a concept of how it would work if it were to be generated.
        /// </remarks>
        public sealed class MyGreeter : NET.MyGreeter.ILanguageTerms
        {
            public LanguageTerm Hello(string name)
            {
                return new LanguageTerm(string.Format("Helllo {0}!", name));
            }
        }
    }
}
