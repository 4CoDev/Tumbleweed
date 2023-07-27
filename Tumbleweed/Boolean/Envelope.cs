namespace Tumbleweed.Boolean;

public abstract class Envelope : Any
{
	protected Envelope(Any boolean) =>
		this.boolean = boolean;

	public global::System.Boolean State => boolean.State;

	private readonly Any boolean;
}