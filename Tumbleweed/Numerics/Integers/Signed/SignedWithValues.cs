using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers.Signed;

public sealed class SignedWithValues : ISignedInteger
{
	public SignedWithValues(IBit positive, IEnumerable<IBit> bits)
	{
		Positive = positive;
		Number = bits;
	}
	
	public IBit Positive { get; }
	
	public IEnumerable<IBit> Number { get; }
}