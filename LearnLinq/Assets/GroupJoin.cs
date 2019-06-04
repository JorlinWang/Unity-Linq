using System.Linq;
using UnityEngine;
/// <summary>
/// 基于键值等同性对两个序列的元素进行关联，并对结果进行分组。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.groupjoin?view=netframework-4.6.1
/// </summary>
public class GroupJoin : MonoBehaviour
{
	class Person
	{
		public string name;
	}
	class Pet
	{
		public string name;
		public Person owner;
	}
	private void Start()
	{
		Person[] persons = {
			new Person{ name = "a"},
			new Person{ name = "b"}
		};
		Pet[] pets = {
			new Pet{ name = "d1", owner = persons[0]},
			new Pet{ name = "d2", owner = persons[1]},
			new Pet{ name = "d3", owner = persons[1]},
		};

		var query = persons.GroupJoin(
			pets,
			person => person,
			pet => pet.owner,
			(person, petCollection) =>
			new
			{
				OwnerName = person.name,
				Pets = petCollection.Select(pet => pet.name)
			}
			);
		foreach (var obj in query)
		{
			Debug.Log(obj.OwnerName);
			foreach (var pet in obj.Pets)
				Debug.Log("\t" + pet);
		}
	}
}