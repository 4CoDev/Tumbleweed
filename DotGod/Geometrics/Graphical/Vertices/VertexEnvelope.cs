using Godot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Vertices;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public ISpatial<IFractional> Translation => vertex.Translation;

	public ISpatial<IFractional> Normal => vertex.Normal;

	public IScalar<Color> Color => vertex.Color;

	public IPlanar<IFractional> UV => vertex.UV;

	private readonly IVertex vertex;
}