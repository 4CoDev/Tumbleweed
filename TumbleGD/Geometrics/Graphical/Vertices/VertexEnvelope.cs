using Godot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public ISpatial<IDecimal> Translation
	{
		get => vertex.Translation;
	}

	public ISpatial<IDecimal> Normal
	{
		get => vertex.Normal;
	}

	public IScalar<Color> Color
	{
		get => vertex.Color;
	}

	public IPlanar<IDecimal> UV
	{
		get => vertex.UV;
	}
	
	private readonly IVertex vertex;
}