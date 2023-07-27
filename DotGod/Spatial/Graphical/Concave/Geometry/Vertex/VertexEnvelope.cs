using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public Tumbleweed.Point.Spatial.Any<Any> Translation => vertex.Translation;

	public Tumbleweed.Point.Spatial.Any<Any> Normal => vertex.Normal;

	public Tumbleweed.Scalar.Any<Color> Color => vertex.Color;

	public Tumbleweed.Point.Planar.Any<Any> UV => vertex.UV;

	private readonly IVertex vertex;
}