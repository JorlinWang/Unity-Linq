using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 筛选出指定类型的元素
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.oftype?view=netframework-4.6.1
/// </summary>

public class OfType : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		var members = typeof(string).GetMembers();
		var properties = members.OfType<System.Reflection.PropertyInfo>();
		foreach (var property in properties)
			Debug.Log(property);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
