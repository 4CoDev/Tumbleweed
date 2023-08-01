using List = Tumbleweed.Event.Listening.List;
using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Listening.List.Scalar;

public sealed class Value<T> : List::Any<T>
{
	public Value
	(
		Immutable::Any<List::Any<T>> scalar
	)
	{
		this.scalar = scalar;
	}

	public void Unsubscribe(System::Object key) =>
		scalar.Value.Unsubscribe(key);

	public void Subscribe(System::Object key, T reaction) =>
		scalar.Value.Subscribe(key, reaction);

	private readonly Immutable::Any<List::Any<T>> scalar;
}