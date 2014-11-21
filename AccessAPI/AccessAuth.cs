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
  public class AccessAuth
  {
    private cpHttpClient Client;
    public AccessAuth(cpHttpClient client)
    {
      Client = client;
    }

    public JObject AuthenticateWithCache(JObject request)
    {
      return process("AuthenticateWithCache", request);
    }

    public JObject Authenticate(JObject request)
    {
      return process("Authenticate", request);
    }

    public JObject Logout()
    {
      return process("Logout", new JObject());
    }

    private JObject process(string action, JObject postData)
    {
      Client.SetupAccessRequest("Auth", action, Newtonsoft.Json.JsonConvert.SerializeObject(postData).ToString());
      return JObject.Parse(Client.CaptureToJsonString());
    }
  }
}
