using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Storage.From;

public sealed class Dictionary : Any
{
	public Dictionary
	(
		IDictionary<System::Object, System::Object> dictionary
	)
	{
		this.dictionary = dictionary;
	}

	public Nullable.Any<System::Object> ValueWith(System::Object key)
	{
		System::Boolean existing = dictionary.TryGetValue(
			key,
			out System::Object? value);
		return new Nullable.With.Members<System::Object>(value!, existing);
	}

	public void Add(System::Object key, System::Object value) =>
		dictionary.Add(key, value);

	public void RemoveBy(System::Object key) =>
		dictionary.Remove(key);

	private readonly IDictionary<System::Object, System::Object> dictionary;
}