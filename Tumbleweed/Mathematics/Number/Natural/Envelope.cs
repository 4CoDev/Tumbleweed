namespace Tumbleweed.Mathematics.Number.Natural;

public abstract class Envelope : Tumbleweed.Mathematics.Number.Natural.Any
{
	protected Envelope(Any natural) =>
		this.natural = natural;

	public IEnumerable<Boolean.Any> Bits =>
		natural.Bits;

	private readonly Any natural;
}