using System.Linq;
using UnityEngine;
/// <summary>
/// 数据中任何元素满足条件
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.any?view=netframework-4.6.1
/// </summary>
public class Any : MonoBehaviour
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
		Debug.Log(pets.AsQueryable().Any());
		Debug.Log(pets.AsQueryable().Any(pet => pet.Age > 3));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
