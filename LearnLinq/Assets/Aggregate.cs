using System.Linq;
using UnityEngine;
/// <summary>
/// 遍历表中所有数据,可附加初始值，可指定返回类型
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.aggregate?view=netframework-4.6.1
/// </summary>
public class Aggregate : MonoBehaviour
{
	private void Start()
	{
		string[] fruits = new string[] { "apple", "banana" };
		var longest = fruits.AsQueryable().Aggregate(fruits[0], (cur, next) => next.Length > cur.Length ? next : cur);
		Debug.Log(longest);
	}
}