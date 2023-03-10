using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers.Natural;

namespace Tumbleweed.Numerics.Integers.Signed;

public abstract class SignedEnvelope : ISignedInteger
{
	protected SignedEnvelope(ISignedInteger integer) =>
		this.integer = integer;
	
	public IBit Positive => integer.Positive;

	public INaturalInteger Natural => integer.Natural;

	private readonly ISignedInteger integer;
}