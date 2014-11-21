using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrownPeakPublic
{
  public static class JObjectExtensions
  {
    public static bool IsSuccessful(this JObject jObject)
    {
      return jObject["resultCode"] != null && jObject["resultCode"].ToString().Equals("conWS_Success");
    }
  }
}
