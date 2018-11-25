namespace DeskHubSharp
{
    public class RepoDetail
    {
        public class Owner
        {
            /// <summary>
            /// 
            /// </summary>
            public string login { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string node_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string avatar_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gravatar_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string html_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string followers_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string following_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string gists_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string starred_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string subscriptions_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string organizations_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string repos_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string events_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string received_events_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string site_admin { get; set; }
        }
        
        public class License
        {
            /// <summary>
            /// 
            /// </summary>
            public string key { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string spdx_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string node_id { get; set; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string node_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string full_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string privates { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Owner owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string html_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fork { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string forks_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string keys_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string collaborators_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string teams_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hooks_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string issue_events_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string events_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string assignees_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string branches_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tags_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string blobs_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_tags_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_refs_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trees_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string statuses_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string languages_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stargazers_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contributors_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subscribers_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subscription_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commits_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_commits_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comments_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string issue_comment_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contents_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string compare_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string merges_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string archive_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string downloads_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string issues_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pulls_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string milestones_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string notifications_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string labels_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string releases_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string deployments_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string created_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string updated_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pushed_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string git_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ssh_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string clone_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string svn_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string homepage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int stargazers_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int watchers_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_issues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_projects { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_downloads { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_wiki { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string has_pages { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int forks_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mirror_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string archived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int open_issues_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public License license { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int forks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int open_issues { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int watchers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string default_branch { get; set; }
    }
}