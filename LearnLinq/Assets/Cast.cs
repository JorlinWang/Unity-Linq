using System.Collections;
using System.Linq;
using UnityEngine;
/// <summary>
/// 将 IQueryable 的元素转换为指定的类型。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.cast?view=netframework-4.6.1
/// </summary>
public class Cast : MonoBehaviour
{
	class Pet
	{
		public string Name;
		public int Age;

		public override string ToString()
		{
			return string.Format("name: {0}, age: {1}", Name, Age);
		}
	}
	// Use this for initialization
	void Start()
	{
		ArrayList words = new ArrayList { "a", "b", "c" };
		var strs = words.Cast<string>();
		foreach (var str in strs)
			Debug.Log(str);
		var pets = strs.Select(str => new Pet { Name = str, Age = 1 });
		foreach (var pet in pets)
			Debug.Log(pet);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
