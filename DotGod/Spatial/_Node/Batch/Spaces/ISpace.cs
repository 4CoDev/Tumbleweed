using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Spaces;

public interface ISpace
{
	IPoint<IReal> From { get; }
	
	IPoint<IReal> To { get; }
}