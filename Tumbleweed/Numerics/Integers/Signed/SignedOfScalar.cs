using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedOfScalar : ISignedInteger
{
	public SignedOfScalar(IScalar<ISignedInteger> scalar)
	{
		this.scalar = scalar;
	}

	public IBit Positive
	{
		get => scalar.Value.Positive;
	}
	
	public IEnumerable<IBit> Number
	{
		get => scalar.Value.Number;
	}
	
	private readonly IScalar<ISignedInteger> scalar;
}