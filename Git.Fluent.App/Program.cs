using System;
using System.Threading.Tasks;

namespace Git.Fluent.App
{
    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            Context context = new Context();
            IGit git = new Git();

            await git.Clone(context).Origin("git.fluent.app").Branch("master").Execute();

            await git.Checkout(context).Branch("develop").Force().Execute();

            await git.Fetch(context).All().Prune().Force().Execute();

            await git.Pull(context).All().Prune().Force().Execute();

            await git.Add(context).Pathspec("./src/*").Execute();

            await git.Status(context).Branch().Short().Execute();

            await git.Commit(context).Author("username").Message("initial project files").Execute();

            await git.Push(context).All().Remote("origin").Ref("develop").Force().Execute();

            await git.Log(context).Execute();

            Console.ReadKey();
        }
    }
}
