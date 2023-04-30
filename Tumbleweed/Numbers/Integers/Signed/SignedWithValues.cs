using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Integers.Natural;

namespace Tumbleweed.Numbers.Integers.Signed;

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