using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedOfScalar : ISignedInteger
{
	public SignedOfScalar(IScalar<ISignedInteger> scalar) =>
		this.scalar = scalar;

	public IBit Positive => scalar.Value.Positive;

	public INaturalInteger Natural => scalar.Value.Natural;

	private readonly IScalar<ISignedInteger> scalar;
}