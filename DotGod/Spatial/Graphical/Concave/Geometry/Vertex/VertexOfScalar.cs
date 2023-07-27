using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(Tumbleweed.Scalar.Any<IVertex> any)
	{
		this.any = any;
	}
	
	public Tumbleweed.Point.Spatial.Any<Any> Translation => any.Value.Translation;

	public Tumbleweed.Point.Spatial.Any<Any> Normal => any.Value.Normal;

	public Tumbleweed.Scalar.Any<Color> Color => any.Value.Color;

	public Tumbleweed.Point.Planar.Any<Any> UV => any.Value.UV;

	private readonly Tumbleweed.Scalar.Any<IVertex> any;
}