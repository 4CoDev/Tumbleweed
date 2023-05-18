using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public abstract class SpaceEnvelope : ISpace
{
	protected SpaceEnvelope(ISpace space) =>
		this.space = space;

	public IPoint<IReal> From =>
		space.From;

	public IPoint<IReal> To =>
		space.To;

	private readonly ISpace space;
}