using TumbleGD.Nodes.Spaces.Spatial.Entities;
using Tumbleweed.Arrays;

namespace TumbleGD.Nodes.Spaces.Spatial;

public abstract class SpaceEnvelope : ISpatialSpace
{
	protected SpaceEnvelope(ISpatialSpace space) =>
		this.space = space;

	public override Boolean Equals(Object? @object) =>
		space.Equals(@object);

	public override Int32 GetHashCode() =>
		space.GetHashCode();

	public override String? ToString() =>
		space.ToString();

	public IArray<ISpatialSpace> Subspaces =>
		space.Subspaces;
	
	public ICollection<ISpatialEntity> Entities =>
		space.Entities;

	private readonly ISpatialSpace space;
}