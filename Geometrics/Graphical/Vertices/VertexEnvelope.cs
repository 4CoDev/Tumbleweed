using Godot;
using Tumbleweed.Measurement.Planars;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Vertices;

public abstract class VertexEnvelope : IVertex
{
	protected VertexEnvelope(IVertex vertex)
	{
		this.vertex = vertex;
	}

	public ISpatial<float> Translation
	{
		get => vertex.Translation;
	}

	public ISpatial<float> Normal
	{
		get => vertex.Normal;
	}

	public IScalar<Color> Color
	{
		get => vertex.Color;
	}

	public IPlanar<float> UV
	{
		get => vertex.UV;
	}
	
	private readonly IVertex vertex;
}