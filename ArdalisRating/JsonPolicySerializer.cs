using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {   
        public Policy GetPolicyFromJsonString(string PolicyJsonString)
        {
            return JsonConvert.DeserializeObject<Policy>(PolicyJsonString);
        }
    }
}
