using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.Property.Value;

public sealed class One : Any
{
	public One(Any<Any> any) =>
		this.any = any;

	public IEnumerable<Graphical.Surface.Any> Surfaces =>
		any.Value.Surfaces;

	private readonly Any<Any> any;
}