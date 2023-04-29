using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Natural;

public sealed class NaturalOfScalar : INaturalInteger
{
	public NaturalOfScalar(IScalar<INaturalInteger> scalar) =>
		this.scalar = scalar;

	public IEnumerable<IBoolean> Bits =>
		scalar.Value.Bits;

	private readonly IScalar<INaturalInteger> scalar;
}