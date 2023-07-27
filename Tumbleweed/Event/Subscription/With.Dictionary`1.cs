using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Subscription.With;

public sealed class Dictionary<T> : Any<T>
{
	public Dictionary(IDictionary<System::Object, T> dictionary) =>
		this.dictionary = dictionary;
	
	public void Unsubscribe(System::Object key) =>
		dictionary.Remove(key);

	public void Subscribe(System::Object key, T reaction) =>
		dictionary.Add(key, reaction);

	private readonly IDictionary<System::Object, T> dictionary;
}