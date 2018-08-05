namespace Wool.Test.Glossary.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GlossaryDBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
