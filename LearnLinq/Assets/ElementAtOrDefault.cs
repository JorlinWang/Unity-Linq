using System.Linq;
using UnityEngine;

/// <summary>
/// 返回序列中指定索引处的元素；如果索引超出范围，则返回默认值。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.elementatordefault?view=netframework-4.6.1
/// </summary>
public class ElementAtOrDefault : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		string[] names = { "a", "b" };
		string name = names.ElementAtOrDefault(3);
		Debug.Log(name ?? "NONE AT THIS INDEX");
	}

	// Update is called once per frame
	void Update()
	{

	}
}
