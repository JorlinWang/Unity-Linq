using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 基于谓词筛选值序列。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.where?view=netstandard-2.1
/// </summary>
public class Where : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1,2,3,4,5};
		foreach (var number in numbers.Where(number => number < 3))
			Debug.Log(number);
		foreach (var number in numbers.Where((number, index) => number * index < 3))
			Debug.LogFormat("value:{0}", number);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
