using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public Tumbleweed.Points.Spatial.IPoint<IReal> Translation => vertex.Translation;

	public Tumbleweed.Points.Spatial.IPoint<IReal> Normal => vertex.Normal;

	public IScalar<Color> Color => vertex.Color;

	public Tumbleweed.Points.Planar.IPoint<IReal> UV => vertex.UV;

	private readonly IVertex vertex;
}