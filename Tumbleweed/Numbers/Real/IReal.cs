using Tumbleweed.Numbers.Integers.Signed;

namespace Tumbleweed.Numbers.Real;

public interface IReal
{
	ISigned Mantissa { get; }
	
	ISigned Base { get; }
	
	ISigned Exponent { get; }
}