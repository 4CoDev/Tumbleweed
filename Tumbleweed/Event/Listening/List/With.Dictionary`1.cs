using List = Tumbleweed.Event.Listening.List;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Listening.List.With;

public sealed class Dictionary<T> : List::Any<T>
{
	public Dictionary(IDictionary<System::Object, T> dictionary) =>
		this.dictionary = dictionary;
	
	public void Unsubscribe(System::Object key) =>
		dictionary.Remove(key);

	public void Subscribe(System::Object key, T reaction)
	{
		dictionary.Add(key, reaction);
	}

	private readonly IDictionary<System::Object, T> dictionary;
}