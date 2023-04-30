using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public interface IOccupiedSpace
{
	ISpatial<IReal> From { get; }
	
	ISpatial<IReal> To { get; }
}