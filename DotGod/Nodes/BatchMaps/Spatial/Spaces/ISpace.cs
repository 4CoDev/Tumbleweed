using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public interface ISpace
{
	IPoint<IReal> From { get; }
	
	IPoint<IReal> To { get; }
}