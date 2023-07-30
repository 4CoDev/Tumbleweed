using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Subscription.Scalar;

public sealed class Value<T> : Subscription.Any<T>
{
	public Value
	(Tumbleweed.Scalar.Immutable.Any<Subscription.Any<T>> scalar
	)
	{
		this.scalar = scalar;
	}

	public void Unsubscribe(System::Object key) =>
		scalar.Value.Unsubscribe(key);

	public void Subscribe(System::Object key, T reaction) =>
		scalar.Value.Subscribe(key, reaction);

	private readonly Tumbleweed.Scalar.Immutable.Any<Subscription.Any<T>> scalar;
}