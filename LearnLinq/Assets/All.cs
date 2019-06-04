using System.Linq;
using UnityEngine;
/// <summary>
/// 数据中所有元素满足条件
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.all?view=netframework-4.6.1
/// </summary>
public class All : MonoBehaviour
{
	class Pet
	{
		public string Name;
		public int Age;
	}
	// Use this for initialization
	void Start()
	{
		Pet[] pets = {
			new Pet{ Name = "a", Age = 1},
			new Pet{ Name = "b", Age = 2},
			new Pet{ Name = "c", Age = 3},
		};
		var query = pets.AsQueryable();
		var isTrue = query.All(pet => pet.Age > 0);
		Debug.Log(isTrue);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
