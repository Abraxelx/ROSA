using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROSA.Util
{
    class JsonUtil
    {

        public static string GetJsonObjectForCode( String content,String deserializedValue,String arrayValue,String objectValue)
        {
            
            String value = "";
            Dictionary<string, object> deserialized = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);

            JToken entireJson = JToken.Parse(deserialized[deserializedValue].ToString());
            JArray inner = entireJson[arrayValue].Value<JArray>();

            foreach (JObject cont in inner.Children<JObject>())
            {
                foreach (JProperty prop in cont.Properties())
                {
                    if (objectValue.Equals(prop.Name))
                        value = (string)prop.Value;


                }
            }

            return value;

        }

    }
}
