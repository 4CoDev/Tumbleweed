using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

public interface ISpace
{
	IPoint<IReal> From { get; }
	
	IPoint<IReal> To { get; }
}