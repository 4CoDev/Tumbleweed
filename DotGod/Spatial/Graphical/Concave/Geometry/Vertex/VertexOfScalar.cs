using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(Tumbleweed.Scalar.Immutable.Any<IVertex> any)
	{
		this.any = any;
	}
	
	public Tumbleweed.Point.Spatial.Any<Any> Translation => any.Value.Translation;

	public Tumbleweed.Point.Spatial.Any<Any> Normal => any.Value.Normal;

	public Tumbleweed.Scalar.Immutable.Any<Color> Color => any.Value.Color;

	public Tumbleweed.Point.Planar.Any<Any> UV => any.Value.UV;

	private readonly Tumbleweed.Scalar.Immutable.Any<IVertex> any;
}