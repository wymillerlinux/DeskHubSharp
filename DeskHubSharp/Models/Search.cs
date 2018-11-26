using System.Collections.Generic;

namespace DeskHubSharp
{
    public class Search
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
            public string received_events_url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }
        }
        
        public class ItemsItem
        {
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
            public Owner owner { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string privates { get; set; }
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
            public int forks_count { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int open_issues_count { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string master_branch { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string default_branch { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public double score { get; set; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int total_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string incomplete_results { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
    }
}