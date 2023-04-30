using Tumbleweed.Booleans;

namespace Tumbleweed.Numbers.Integers.Natural;

public abstract class NaturalEnvelope : INatural
{
	protected NaturalEnvelope(INatural integer) =>
		this.integer = integer;

	public IEnumerable<IBoolean> Bits =>
		integer.Bits;

	private readonly INatural integer;
}