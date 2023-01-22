using Godot;
using Tumbleweed.Measurement.Planars;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Vertices;

public sealed class VertexFromScalar : IVertex
{
	public VertexFromScalar(IScalar<IVertex> scalar)
	{
		this.scalar = scalar;
	}
	
	public ISpatial<float> Translation
	{
		get => scalar.Value().Translation;
	}

	public ISpatial<float> Normal
	{
		get => scalar.Value().Normal;
	}

	public IScalar<Color> Color
	{
		get => scalar.Value().Color;
	}

	public IPlanar<float> UV
	{
		get => scalar.Value().UV;
	}
	
	private readonly IScalar<IVertex> scalar;
}