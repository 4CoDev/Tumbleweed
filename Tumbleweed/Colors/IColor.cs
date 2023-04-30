using Tumbleweed.Numbers.Real;

namespace Tumbleweed.Colors;

public interface IColor
{
	IReal Red { get; }
	
	IReal Green { get; }
	
	IReal Blue { get; }
}