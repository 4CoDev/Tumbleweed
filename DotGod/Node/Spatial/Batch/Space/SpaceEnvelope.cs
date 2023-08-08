using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Space;

public abstract class SpaceEnvelope : ISpace
{
	protected SpaceEnvelope(ISpace space) =>
		this.space = space;

	public Any<Tumbleweed.Number.Real.Any> From =>
		space.From;

	public Any<Tumbleweed.Number.Real.Any> To =>
		space.To;

	private readonly ISpace space;
}