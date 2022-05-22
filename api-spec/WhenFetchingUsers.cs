namespace Api.Spec
{//only testing api
    public class WhenFetchingUsers : WebApiFixture
    {
        public WhenFetchingUsers(IntegrationTestingFactory<Program> factory)
            : base(factory, "users")
        {
        }

        [Fact]
        public void ThenAllUsersReturned()
        {


        }
    }
}
