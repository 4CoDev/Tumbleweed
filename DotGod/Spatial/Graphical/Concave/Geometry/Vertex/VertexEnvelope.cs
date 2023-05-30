using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public IPoint<IReal> Translation => vertex.Translation;

	public IPoint<IReal> Normal => vertex.Normal;

	public IScalar<Color> Color => vertex.Color;

	public Tumbleweed.Planar.Point.IPoint<IReal> UV => vertex.UV;

	private readonly IVertex vertex;
}