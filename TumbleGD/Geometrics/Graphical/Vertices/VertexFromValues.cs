using Godot;
using Tumbleweed.Measurement.Planars;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices;

public sealed class VertexFromValues : IVertex
{
	public VertexFromValues
	(
		ISpatial<float> translation,
		ISpatial<float> normal,
		IScalar<Color> color,
		IPlanar<float> uv
	)
	{
		Translation = translation;
		Normal = normal;
		Color = color;
		UV = uv;
	}
	
	public ISpatial<float> Translation { get; }
	
	public ISpatial<float> Normal { get; }
	
	public IScalar<Color> Color { get; }
	
	public IPlanar<float> UV { get; }
}