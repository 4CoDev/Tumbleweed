using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public abstract class SpaceEnvelope : IOccupiedSpace
{
	protected SpaceEnvelope(IOccupiedSpace space) =>
		this.space = space;

	public ISpatial<IFractional> From =>
		space.From;

	public ISpatial<IFractional> To =>
		space.To;

	private readonly IOccupiedSpace space;
}