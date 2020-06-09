using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("sataliteSpawnParent", "satalitePrefab", "spawnedAmount")]
	public class ES3UserType_SpawnManager : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_SpawnManager() : base(typeof(SpawnManager)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (SpawnManager)obj;
			
			writer.WritePropertyByRef("sataliteSpawnParent", instance.sataliteSpawnParent);
			writer.WritePropertyByRef("satalitePrefab", instance.satalitePrefab);
			writer.WritePrivateField("spawnedAmount", instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (SpawnManager)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "sataliteSpawnParent":
						instance.sataliteSpawnParent = reader.Read<UnityEngine.Transform>(ES3UserType_Transform.Instance);
						break;
					case "satalitePrefab":
						instance.satalitePrefab = reader.Read<UnityEngine.GameObject>(ES3Type_GameObject.Instance);
						break;
					case "spawnedAmount":
					reader.SetPrivateField("spawnedAmount", reader.Read<System.Int32>(), instance);
					break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_SpawnManagerArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_SpawnManagerArray() : base(typeof(SpawnManager[]), ES3UserType_SpawnManager.Instance)
		{
			Instance = this;
		}
	}
}