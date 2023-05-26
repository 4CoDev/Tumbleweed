using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

public interface ISpace
{
	IPoint<IReal> From { get; }
	
	IPoint<IReal> To { get; }
}