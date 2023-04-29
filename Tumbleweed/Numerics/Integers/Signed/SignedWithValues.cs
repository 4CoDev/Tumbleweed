using Tumbleweed.Booleans;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedWithValues : ISignedInteger
{
	public SignedWithValues(IBoolean positive, INaturalInteger natural)
	{
		Positive = positive;
		Natural = natural;
	}
	
	public IBoolean Positive { get; }
	
	public INaturalInteger Natural { get; }
}