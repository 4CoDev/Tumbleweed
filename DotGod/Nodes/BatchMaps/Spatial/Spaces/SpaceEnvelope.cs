using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public abstract class SpaceEnvelope : ISpace
{
	protected SpaceEnvelope(ISpace space) =>
		this.space = space;

	public ISpatial<IReal> From =>
		space.From;

	public ISpatial<IReal> To =>
		space.To;

	private readonly ISpace space;
}