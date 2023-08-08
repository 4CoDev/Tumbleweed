using Tumbleweed.Scalar.Immutable;
using Surface = DotGod.Geometry.Spatial.Concave.Graphical.Surface;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Mesh.Scalar.Value;

public sealed class One : Any
{
	public One(Any<Any> any) =>
		this.any = any;

	public IEnumerable<Surface::Any> Surfaces =>
		any.Value.Surfaces;

	private readonly Any<Any> any;
}