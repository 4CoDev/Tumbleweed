using List = Tumbleweed.Event.Listening.List;
using System = System;

namespace Tumbleweed.Event.Listening.List;

public abstract class Envelope<T> : List::Any<T>
{
	protected Envelope(List::Any<T> subscription) =>
		this.subscription = subscription;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		subscription.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		subscription.GetHashCode();

	public override System::String? ToString() =>
		subscription.ToString();

	public void Unsubscribe(System::Object key) =>
		subscription.Unsubscribe(key);

	public void Subscribe
	(
		System::Object key,
		T reaction
	)
	{
		subscription.Subscribe(key, reaction);
	}

	private readonly List::Any<T> subscription;
}