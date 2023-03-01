using Tumbleweed.Bits;

namespace Tumbleweed.Numerics.Integers.Signed;

public abstract class SignedEnvelope : ISignedInteger
{
	protected SignedEnvelope(ISignedInteger integer)
	{
		this.integer = integer;
	}
	
	public IBit Positive
	{
		get => integer.Positive;
	}

	public IEnumerable<IBit> Number
	{
		get => integer.Number;
	}
	
	private readonly ISignedInteger integer;
}