using Localization.NET.Generated;
using Localization.Prototype;
using System;

namespace Localization.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyApp app = new MyApp();
            app.Startup();
        }
    }

    public class MyApp
    {
        private MyGreeter _greeter;
        private ILanguageTerms _languageTerms;

        public MyApp()
        {
            _languageTerms = new Lang.MyApp();
            _greeter = new MyGreeter();
        }

        public void Startup()
        {
            var names = new string[] { "bill", "stacy", "sammy" };

            Console.WriteLine(_languageTerms.Hello);
            Console.WriteLine(_languageTerms.Count(names.Length));
            foreach (var people in names)
            {
                _greeter.SayHello(people);
            }

            Console.WriteLine(_languageTerms.Goodbye);
            Console.ReadKey();
        }

        /// <summary>
        /// Language Terms for the Console Interface <see cref="Localization.NET.MyApp"/>.
        /// </summary>
        [LanguageTerms("myapp")]
        public interface ILanguageTerms
        {
            [LangTerm("goodbye")]
            LanguageTerm Goodbye { get; }

            [LangTerm("hello")]
            LanguageTerm Hello { get; }

            [LangTerm("counts")]
            LanguageTerm Count(int count);

        }
    }

    public class MyGreeter
    {
        private ILanguageTerms _languageTerms;

        public MyGreeter()
        {
            _languageTerms = new Lang.MyGreeter();
        }

        public void SayHello(string name)
        {
            Console.WriteLine(_languageTerms.Hello(name));
        }

        /// <summary>
        /// Language Terms for the Console Interface <see cref="Localization.NET.MyApp"/>.
        /// </summary>
        [LanguageTerms("myapp.greeter")]
        public interface ILanguageTerms
        {
            [LangTerm("hello")]
            LanguageTerm Hello(string name);

        }
    }
}
