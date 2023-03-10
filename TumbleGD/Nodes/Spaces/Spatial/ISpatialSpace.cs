using TumbleGD.Nodes.Spaces.Spatial.Entities;
using Tumbleweed.Arrays;

namespace TumbleGD.Nodes.Spaces.Spatial;

public interface ISpatialSpace
{
	IArray<ISpatialSpace> Spaces { get; }
	
	IEnumerable<ISpatialEntity> Entities { get; }
	
	void Update();
}