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

            await git.Checkout(context).Execute();
            await git.Fetch(context).All().Prune().Force().Execute();
            await git.Pull(context).Execute();
            await git.Add(context).Execute();
            await git.Status(context).Execute();
            await git.Commit(context).Execute();
            await git.Push(context).Execute();
            await git.Log(context).Execute();

            Console.ReadKey();
        }
    }
}
