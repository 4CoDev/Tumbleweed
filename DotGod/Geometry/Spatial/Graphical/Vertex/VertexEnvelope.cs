using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public IPoint<IReal> Translation => vertex.Translation;

	public IPoint<IReal> Normal => vertex.Normal;

	public IScalar<Color> Color => vertex.Color;

	public Tumbleweed.Point.Planar.IPoint<IReal> UV => vertex.UV;

	private readonly IVertex vertex;
}