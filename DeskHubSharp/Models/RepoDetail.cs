
using DeskHubSharp.Models;

namespace DeskHubSharp
{
    public class RepoDetail
    {
        //public string Login { get; set; }
        //public string Password { get; set; }

        public Owner Owner { get; set; }

        public License License { get; set; }

        public Root Root { get; set; }
    }
}