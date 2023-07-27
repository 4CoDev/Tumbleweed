using System = System;

namespace Tumbleweed.Event.Subscription;

public abstract class Envelope<T> : Any<T>
{
	protected Envelope(Any<T> subscription) =>
		this.subscription = subscription;

	public override System::Boolean Equals(System::Object? @object) =>
		subscription.Equals(@object);

	public override Int32 GetHashCode() =>
		subscription.GetHashCode();

	public override System::String? ToString() =>
		subscription.ToString();

	public void Unsubscribe(System::Object key) =>
		subscription.Unsubscribe(key);

	public void Subscribe(System::Object key, T reaction) =>
		subscription.Subscribe(key, reaction);

	private readonly Any<T> subscription;
}