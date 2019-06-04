using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 升序排序
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.orderby?view=netframework-4.6.1
/// </summary>

public class OrderBy : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 45, 23, 52, 3, 5234, 234, 23, 5, 2 };
		var query = numbers.OrderBy(number => number);
		foreach (var number in query)
			Debug.Log(number);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
