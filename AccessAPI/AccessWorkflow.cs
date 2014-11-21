using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CrownPeakPublic.AccessAPI
{
  /// <summary>
  /// Pass the Client property from a AccessSession object into the constructor.
  /// </summary>
  public class AccessWorkflow
  {
    private cpHttpClient Client;
    public AccessWorkflow(cpHttpClient client)
    {
      Client = client;
    }

    public JObject Read()
    {
      return process("Read", new JObject());
    }

    public JObject Read(int id)
    {
      return process("Read/" + id.ToString(), new JObject());
    }

    private JObject process(string action, JObject postData)
    {
      Client.SetupAccessRequest("Workflow", action, Newtonsoft.Json.JsonConvert.SerializeObject(postData).ToString());
      return JObject.Parse(Client.CaptureToJsonString());
    }
  }
}
