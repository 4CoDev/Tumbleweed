using TumbleGD.Nodes.Spaces.Spatial.Entities;
using Tumbleweed.Arrays;

namespace TumbleGD.Nodes.Spaces.Spatial;

public abstract class SpaceEnvelope : ISpatialSpace
{
	protected SpaceEnvelope(ISpatialSpace spatialSpace) =>
		this.spatialSpace = spatialSpace;

	public override Boolean Equals(Object? @object) =>
		spatialSpace.Equals(@object);

	public override Int32 GetHashCode() =>
		spatialSpace.GetHashCode();

	public override String? ToString() =>
		spatialSpace.ToString();

	public IArray<ISpatialSpace> Spaces =>
		spatialSpace.Spaces;
	
	public IEnumerable<ISpatialEntity> Entities =>
		spatialSpace.Entities;

	public void Update() =>
		spatialSpace.Update();

	private readonly ISpatialSpace spatialSpace;
}