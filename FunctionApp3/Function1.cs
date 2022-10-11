using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ClassLibrary1;

namespace FunctionApp3
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            Test me = new Test();
            log.LogInformation(me.ret().ToString());
        }
    }
}
