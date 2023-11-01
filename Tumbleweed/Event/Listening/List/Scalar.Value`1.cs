using List = Tumbleweed.Event.Listening.List;
using Property = Tumbleweed.Property.Output;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Listening.List.Scalar;

public sealed class Value<T> : List::Any<T>
{
	public Value
	(
		Property::Any<List::Any<T>> property
	)
	{
		this.property = property;
	}

	public void Unsubscribe(System::Object key) =>
		property.Value.Unsubscribe(key);

	public void Subscribe(System::Object key, T reaction) =>
		property.Value.Subscribe(key, reaction);

	private readonly Property::Any<List::Any<T>> property;
}