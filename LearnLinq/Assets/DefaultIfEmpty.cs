using System.Linq;
using UnityEngine;
/// <summary>
/// 返回指定序列中的元素；如果序列为空，则返回单一实例集合中的类型参数的默认值。
/// DefaultIfEmpty<TSource>(IQueryable<TSource>) 
/// 返回指定序列中的元素；如果序列为空，则返回单一实例集合中的指定值。
/// DefaultIfEmpty<TSource>(IQueryable<TSource>, TSource) 
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.defaultifempty?view=netframework-4.6.1
/// </summary>
public class DefaultIfEmpty : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3 };
		var result = numbers.Where(number => number > 3).DefaultIfEmpty(1);
		foreach (var i in result)
			Debug.Log(i);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
