using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lesson2
{
	public class SerializeService
	{
		public JsonSerializerSettings settings = new()
		{
			TypeNameHandling = TypeNameHandling.All
		};

		public string Serialize<T>(T obj) where T : MySerializable
		{
			return JsonConvert.SerializeObject(obj, settings);
		}

		public MySerializable Deserialize<T>(string json) where T : MySerializable
		{
			var res = JsonConvert.DeserializeObject<MySerializable>(json, settings);
			return res;
		}
	}
}
