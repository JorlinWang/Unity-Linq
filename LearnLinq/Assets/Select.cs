using System.Linq;
using UnityEngine;
/// <summary>
/// 遍历源表，将每个元素投影到新表中
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.select?view=netframework-4.6.1
/// </summary>
public class Select : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		var array = new string[] { "apple", "banana" };
		var query = array.AsQueryable().Select((string fruit, int index) => string.Format("index: {0}, fruit: {1}", index, fruit));
		foreach (var obj in query)
		{
			Debug.Log(obj);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
