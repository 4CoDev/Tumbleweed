using Tumbleweed._Boolean;
using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Number.Integer.Signed;

public abstract class SignedEnvelope : ISigned
{
	protected SignedEnvelope(ISigned integer) =>
		this.integer = integer;
	
	public IBoolean IsPositive => integer.IsPositive;

	public INatural Natural => integer.Natural;

	private readonly ISigned integer;
}