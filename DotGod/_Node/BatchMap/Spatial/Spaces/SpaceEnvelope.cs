using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod._Node.BatchMap.Spatial.Spaces;

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