using Tumbleweed._Boolean;
using Tumbleweed.Number.Integer.Natural;

namespace Tumbleweed.Number.Integer.Signed;

public sealed class SignedWithValues : ISigned
{
	public SignedWithValues(IBoolean positive, INatural natural)
	{
		IsPositive = positive;
		Natural = natural;
	}
	
	public IBoolean IsPositive { get; }
	
	public INatural Natural { get; }
}