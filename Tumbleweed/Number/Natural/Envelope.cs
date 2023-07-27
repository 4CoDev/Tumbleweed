namespace Tumbleweed.Number.Natural;

public abstract class Envelope : Natural.Any
{
	protected Envelope(Natural.Any natural) =>
		this.natural = natural;

	public IEnumerable<Boolean.Any> Bits =>
		natural.Bits;

	private readonly Natural.Any natural;
}