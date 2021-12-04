using Newtonsoft.Json.Linq;

namespace Sandruve.Github
{
    class GithubParser
    {
        public static string GetLatestReleaseVersion()
        {
            JArray array = Utils.ParseURL("https://api.github.com/repos/owoPeef/Sandruve/tags");
            JObject latestVersionObject = (JObject)array[0];
            string latestVersion = (string)latestVersionObject["name"];
            return latestVersion;
        }

        public static bool IsNewVersionAvailable()
        {
            string latestVersion = Program.version;
            string latestGithubVersion = GetLatestReleaseVersion();
            if (latestGithubVersion != latestVersion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
