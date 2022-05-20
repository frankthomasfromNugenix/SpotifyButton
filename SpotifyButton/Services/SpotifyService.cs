using SpotifyButton.Models;

namespace SpotifyButton.Services
{
    public class SpotifyService
    {
        private readonly SpotifyCredentials cred;

        public SpotifyService(SpotifyCredentials cred)
        {
            this.cred = cred;

            Authorize();
        }

        public void AddSong(Song name)
        {
            throw new NotImplementedException();
        }

        private void Authorize()
        {
            throw new NotImplementedException();
        }
    }
}
