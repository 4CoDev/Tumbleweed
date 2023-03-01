using Tumbleweed.Numerics.Fractional;

namespace Tumbleweed.Colors;

public interface IColor
{
	IFractional Red { get; }
	
	IFractional Green { get; }
	
	IFractional Blue { get; }
}