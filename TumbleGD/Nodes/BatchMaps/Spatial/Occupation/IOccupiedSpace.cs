using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

public interface IOccupiedSpace
{
	ISpatial<IFractional> From { get; }
	
	ISpatial<IFractional> To { get; }
}