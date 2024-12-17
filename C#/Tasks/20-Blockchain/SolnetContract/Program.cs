using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solnet.Rpc;
using Solnet.Rpc.Models;
using Solnet.Wallet;

namespace SolnetContract
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a new wallet
            var mnemonic = new Mnemonic(WordList.English, WordCount.Twelve);
            var wallet = new Wallet(mnemonic);
            var account = wallet.Account;

            Console.WriteLine($"Public Key: {account.PublicKey.Key}");
            Console.WriteLine($"Private Key: {Convert.ToBase64String(account.PrivateKey.KeyBytes)}");
            Console.WriteLine($"Mnemonic: {mnemonic}");

            // Connect to the Solana DevNet cluster
            var rpcClient = ClientFactory.GetClient(Cluster.DevNet);

            // Get the account balance
            var balanceResult = await rpcClient.GetBalanceAsync(account.PublicKey);
            if (balanceResult.WasSuccessful)
            {
                Console.WriteLine($"Account Balance: {balanceResult.Result.Value} SOL");
            }
            else
            {
                Console.WriteLine($"Error retrieving balance: {balanceResult.Reason}");
            }
        }
    }
}
