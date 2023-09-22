using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.Mesh.Scalar.Value;

public sealed class One : Any
{
	public One(Any<Any> any) =>
		this.any = any;

	public IEnumerable<Graphical.Surface.Any> Surfaces =>
		any.Value.Surfaces;

	private readonly Any<Any> any;
}