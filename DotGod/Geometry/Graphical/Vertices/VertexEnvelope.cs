using Godot;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Vertices;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public ISpatial<IReal> Translation => vertex.Translation;

	public ISpatial<IReal> Normal => vertex.Normal;

	public IScalar<Color> Color => vertex.Color;

	public IPlanar<IReal> UV => vertex.UV;

	private readonly IVertex vertex;
}