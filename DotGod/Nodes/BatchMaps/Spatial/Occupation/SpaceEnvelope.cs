using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public abstract class SpaceEnvelope : IOccupiedSpace
{
	protected SpaceEnvelope(IOccupiedSpace space) =>
		this.space = space;

	public ISpatial<IReal> From =>
		space.From;

	public ISpatial<IReal> To =>
		space.To;

	private readonly IOccupiedSpace space;
}