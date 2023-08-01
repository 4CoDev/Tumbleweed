using Listening = Tumbleweed.Event.Listening;

namespace Tumbleweed.Event.Listening;

public abstract class Envelope<T> : Listening::Any<T>
{
	protected Envelope(Listening::Any<T> listening) =>
		this.listening = listening;
	
	public void Unsubscribe() =>
		listening.Unsubscribe();

	public void Subscribe() =>
		listening.Subscribe();

	private readonly Listening::Any<T> listening;
}