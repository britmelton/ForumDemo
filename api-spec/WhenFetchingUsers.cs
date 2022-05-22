namespace Api.Spec
{//only testing api
    [Collection("storage")]
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
