using Tumbleweed.Booleans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Natural;

public sealed class NaturalOfScalar : INatural
{
	public NaturalOfScalar(IScalar<INatural> scalar) =>
		this.scalar = scalar;

	public IEnumerable<IBoolean> Bits =>
		scalar.Value.Bits;

	private readonly IScalar<INatural> scalar;
}