using Tumbleweed._Boolean;

namespace Tumbleweed.Number.Integer.Natural;

public abstract class NaturalEnvelope : INatural
{
	protected NaturalEnvelope(INatural integer) =>
		this.integer = integer;

	public IEnumerable<IBoolean> Bits =>
		integer.Bits;

	private readonly INatural integer;
}