using TumbleGD.Nodes.Baking.Spatial.Entities;
using Tumbleweed.Arrays;

namespace TumbleGD.Nodes.Baking.Spatial.Spaces;

public interface IBakingSpace
{
	IArray<IBakingSpace> Spaces { get; }
	
	IEnumerable<IBakingEntity> Entities { get; }
	
	void Update();
}