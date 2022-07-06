public class UsersClient
{
    private HttpClient client;

    public UsersClient()
    {
        client = new HttpClient();
    }

    public async Task<string> GetInfo()
    {
        var response = await client.GetAsync(
            "https://www.google.com")
            .ConfigureAwait(false);
        var content = await response.Content.ReadAsStringAsync();

        return content;
    }
}