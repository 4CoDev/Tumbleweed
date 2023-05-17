using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public interface ISpace
{
	ISpatial<IReal> From { get; }
	
	ISpatial<IReal> To { get; }
}