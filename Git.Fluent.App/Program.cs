using System;
using System.Threading;
using System.Threading.Tasks;

namespace Git.Fluent.App
{
    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            // NOTE: this can be pre-initialized inside a shell
            var git = Git.New();
            var cts = new CancellationTokenSource();

            await git.Clone("git.fluent.app").Origin("git.fluent.app").Branch("master").Build().ExecuteAsync(cts.Token);

            await git.Checkout().Branch("develop").Force().Build().ExecuteAsync(cts.Token);

            await git.Fetch().All().Prune().Force().Build().ExecuteAsync(cts.Token);

            await git.Pull().All().Prune().Force().Build().ExecuteAsync(cts.Token);

            await git.Add("./src/*").Build().ExecuteAsync(cts.Token);

            await git.Status("./*").Branch().Short().Build().ExecuteAsync(cts.Token);

            await git.Commit().Author("username").Message("initial project files").Build().ExecuteAsync(cts.Token);

            await git.Push().All().Remote("origin").Ref("develop").Force().Build().ExecuteAsync(cts.Token);

            await git.Log().Build().ExecuteAsync(cts.Token);

            Console.ReadKey();
        }
    }
}
