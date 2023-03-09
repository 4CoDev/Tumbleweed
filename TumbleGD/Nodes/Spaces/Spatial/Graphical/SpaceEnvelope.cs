using TumbleGD.Nodes.Spaces.Spatial.Graphical.Entities;
using Tumbleweed.Arrays;

namespace TumbleGD.Nodes.Spaces.Spatial.Graphical;

public abstract class SpaceEnvelope : IBakingSpace
{
	protected SpaceEnvelope(IBakingSpace space) =>
		this.space = space;

	public override Boolean Equals(Object? @object) =>
		space.Equals(@object);

	public override Int32 GetHashCode() =>
		space.GetHashCode();

	public override String? ToString() =>
		space.ToString();

	public IArray<IBakingSpace> Spaces =>
		space.Spaces;
	
	public IEnumerable<IBakingEntity> Entities =>
		space.Entities;

	public void Update() =>
		space.Update();

	private readonly IBakingSpace space;
}