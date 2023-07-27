using Tumbleweed.Number.Integer;

namespace Tumbleweed.Number.Real;

public interface Any
{
	Integer.Any Mantissa { get; }
	
	Integer.Any Base { get; }
	
	Integer.Any Exponent { get; }
}