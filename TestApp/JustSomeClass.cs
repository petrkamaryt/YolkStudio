namespace TestApp
{
    public class JustSomeClass
    {
        private readonly ISquid squid;

        public JustSomeClass(ISquid squid)
        {
            this.squid = squid;
        }

        public void SomeMethod()
        {
            squid.DoSomething();
        }
    }
}