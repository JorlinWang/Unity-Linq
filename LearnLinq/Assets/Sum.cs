using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 计算数值序列的和。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.sum?view=netstandard-2.1
/// </summary>

public class Sum : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1,2,3,4};
		int?[] numbers2 = { 1, null, 3,4};
		Debug.Log("sum of numbers: " + numbers.Sum());
		Debug.Log("sum of numbers2: " + numbers2.Sum());
		Debug.Log("sum of double numbers2: " + numbers2.Sum(n => n * 2));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
