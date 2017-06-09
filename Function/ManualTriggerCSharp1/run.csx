using System;

public static async Task Run(string input, ILogger log)
{
    log.LogInformation($"C# manually triggered function called with input: {input}");
}