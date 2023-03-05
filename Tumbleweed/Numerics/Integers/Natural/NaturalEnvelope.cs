using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers.Natural;

public abstract class NaturalEnvelope : INaturalInteger
{
	protected NaturalEnvelope(INaturalInteger integer) =>
		this.integer = integer;

	public IEnumerable<IBit> Bits =>
		integer.Bits;

	private readonly INaturalInteger integer;
}