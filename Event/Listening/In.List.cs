using Listening = Tumbleweed.Event.Listening;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Listening.In;

public sealed class List<T> : Listening::Envelope<T>
{
	public List
	(
		Listening::List.Any<T> list,
		System::Object key,
		T reaction
	) : base
	(
		new Listening::With.Members<T>(
			new Listening::Unsubscribe<T>(list, key),
			new Listening::Subscribe<T>(list, key, reaction))
	)
	{
	}
}