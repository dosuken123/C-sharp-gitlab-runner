using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_gitlab_runner.network
{
    class GitLab
    {
        public GitLab(string url)
        {
            URL = url;
        }

        public bool UpdateJobStatus()
        {
            Console.WriteLine("URL is " + URL);

            return true;
        }

        public string URL { get; set; }
    }
}
