using Tumbleweed.Numerics.Decimals;

namespace Tumbleweed.Colors;

public interface IColor
{
	IDecimal Red { get; }
	
	IDecimal Green { get; }
	
	IDecimal Blue { get; }
}