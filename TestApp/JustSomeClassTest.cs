using NUnit.Framework;
using NSubstitute;

namespace TestApp
{
    [TestFixture]
    public class JustSomeClassTest
    {
        [Test]
        public void SomeMethod_CallsDoSomethingOnce()
        {
            var stub = Substitute.For<ISquid>();
            var cls = new JustSomeClass(stub);

            cls.SomeMethod();

            stub.Received(1).DoSomething();
        }
    }
}