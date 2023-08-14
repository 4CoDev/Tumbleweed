using Tumbleweed.Point.Spatial;

namespace Tumbleweed.Geometry.Spatial.Aabb;

public abstract class Envelope : Any
{
	protected Envelope(Any space) =>
		this.space = space;

	public Any<Tumbleweed.Number.Real.Any> A =>
		space.A;

	public Any<Tumbleweed.Number.Real.Any> B =>
		space.B;

	private readonly Any space;
}