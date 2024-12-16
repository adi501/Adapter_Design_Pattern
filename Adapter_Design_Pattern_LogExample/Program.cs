using Adapter_Design_Pattern_LogExample.Adapter;
using Adapter_Design_Pattern_LogExample.Expected;
using Adapter_Design_Pattern_LogExample.External_Service;


// Ref : https://medium.com/@anderson.buenogod/how-to-use-the-adapter-design-pattern-in-c-net-8-for-system-integration-932d3f0748d5


ExternalLogService externalLogService = new ExternalLogService();
ILogTarget logAdapter = new LogAdapter(externalLogService);

logAdapter.LogInfo("This is an informational message.");
logAdapter.LogError("This is an error message.");



Console.ReadLine();
