using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices;

public sealed class VertexOfScalar : IVertex
{
	public VertexOfScalar(IScalar<IVertex> scalar)
	{
		this.scalar = scalar;
	}
	
	public ISpatial<IReal> Translation => scalar.Value.Translation;

	public ISpatial<IReal> Normal => scalar.Value.Normal;

	public IScalar<Color> Color => scalar.Value.Color;

	public IPlanar<IReal> UV => scalar.Value.UV;

	private readonly IScalar<IVertex> scalar;
}