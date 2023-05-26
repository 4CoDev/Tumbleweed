using Tumbleweed.Number.Integer.Signed;

namespace Tumbleweed.Number.Real;

public interface IReal
{
	ISigned Mantissa { get; }
	
	ISigned Base { get; }
	
	ISigned Exponent { get; }
}