using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 从序列的开头返回指定数量的相邻元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.take?view=netstandard-2.1
/// </summary>

public class Take : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 234,234,523,5,563};
		//取出最大的两个值
		foreach (var number in numbers.OrderByDescending(n => n).Take(2))
			Debug.Log(number);
		//输出结果为563，523
	}

	// Update is called once per frame
	void Update()
	{

	}
}
