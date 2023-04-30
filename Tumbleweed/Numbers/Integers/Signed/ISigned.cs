using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Integers.Natural;

namespace Tumbleweed.Numbers.Integers.Signed;

public interface ISigned
{
	IBoolean IsPositive { get; }
	
	INatural Natural { get; }
}