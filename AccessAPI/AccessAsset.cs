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
  public class AccessAsset
  {
    private cpHttpClient Client;
    public AccessAsset(cpHttpClient client)
    {
      Client = client;
    }

    public JObject Read(int id)
    {
      return process("Read/" + id.ToString(), new JObject());
    }

    public JObject Paged(JObject request)
    {
      return process("Paged", request);
    }

    public JObject Create(JObject request)
    {
      return process("Create", request);
    }

    public JObject Update(JObject request)
    {
      return process("Update", request);
    }

    public JObject Delete(int id)
    {
      return process("Delete/" + id.ToString(), new JObject());
    }

    public JObject Undelete(int id)
    {
      return process("Undelete/" + id.ToString(), new JObject());
    }

    public JObject Rename(JObject request)
    {
      return process("Rename", request);
    }

    public JObject Route(JObject request)
    {
      return process("Route", request);
    }

    public JObject Branch(int id)
    {
      return process("Branch/" + id.ToString(), new JObject());
    }

    public JObject Fields(int id)
    {
      return process("Fields/" + id.ToString(), new JObject());
    }

    public JObject Upload(JObject request)
    {
      return process("Upload", request);
    }

    public JObject Attach(JObject request)
    {
      return process("Attach", request);
    }

    public JObject ExecuteWorkflowCommand(JObject request)
    {
      return process("ExecuteWorkflowCommand", request);
    }

    public JObject Exists(JObject request)
    {
      return process("Exists", request);
    }

    private JObject process(string action, JObject postData)
    {
      Client.SetupAccessRequest("Asset", action, Newtonsoft.Json.JsonConvert.SerializeObject(postData).ToString());
      return JObject.Parse(Client.CaptureToJsonString());
    }
  }
}
