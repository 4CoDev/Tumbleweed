using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedWithValues : ISignedInteger
{
	public SignedWithValues(IBit positive, INaturalInteger natural)
	{
		Positive = positive;
		Natural = natural;
	}
	
	public IBit Positive { get; }
	
	public INaturalInteger Natural { get; }
}