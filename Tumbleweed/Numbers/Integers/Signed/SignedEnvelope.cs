using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Integers.Natural;

namespace Tumbleweed.Numbers.Integers.Signed;

public abstract class SignedEnvelope : ISigned
{
	protected SignedEnvelope(ISigned integer) =>
		this.integer = integer;
	
	public IBoolean IsPositive => integer.IsPositive;

	public INatural Natural => integer.Natural;

	private readonly ISigned integer;
}