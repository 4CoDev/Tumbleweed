using Tumbleweed._Boolean;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Natural;

public sealed class NaturalOfScalar : INatural
{
	public NaturalOfScalar(IScalar<INatural> scalar) =>
		this.scalar = scalar;

	public IEnumerable<IBoolean> Bits =>
		scalar.Value.Bits;

	private readonly IScalar<INatural> scalar;
}