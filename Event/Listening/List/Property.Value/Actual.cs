using List = Tumbleweed.Event.Listening.List;
using Property = Tumbleweed.Property.Output;
using System = System;

namespace Tumbleweed.Event.Listening.List.Property.Value;

public sealed class Actual<T> : List::Any<T>
{
	public Actual
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