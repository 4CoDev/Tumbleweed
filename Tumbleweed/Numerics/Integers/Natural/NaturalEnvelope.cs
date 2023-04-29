using Tumbleweed.Booleans;

namespace Tumbleweed.Numerics.Integers.Natural;

public abstract class NaturalEnvelope : INaturalInteger
{
	protected NaturalEnvelope(INaturalInteger integer) =>
		this.integer = integer;

	public IEnumerable<IBoolean> Bits =>
		integer.Bits;

	private readonly INaturalInteger integer;
}