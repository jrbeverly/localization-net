namespace Localization.Prototype
{
    public sealed class LanguageTerm
    {
        public string Message { get; private set; }

        public LanguageTerm(string text)
        {
            Message = text;
        }

        public static LanguageTerm Format(string format, object[] objs)
        {
            return new LanguageTerm(string.Format(format, objs));
        }

        public override string ToString()
        {
            return Message;
        }

        public static implicit operator string(LanguageTerm term)
        {
            return term.Message;
        }
    }
}
