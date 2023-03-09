using TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities;
using Tumbleweed.Arrays;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical;

public interface IBakingSpace
{
	IArray<IBakingSpace> Spaces { get; }
	
	IEnumerable<IBakingEntity> Entities { get; }
	
	void Update();
}