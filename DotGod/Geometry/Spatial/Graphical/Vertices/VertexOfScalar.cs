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
	
	public Tumbleweed.Points.Spatial.IPoint<IReal> Translation => scalar.Value.Translation;

	public Tumbleweed.Points.Spatial.IPoint<IReal> Normal => scalar.Value.Normal;

	public IScalar<Color> Color => scalar.Value.Color;

	public Tumbleweed.Points.Planar.IPoint<IReal> UV => scalar.Value.UV;

	private readonly IScalar<IVertex> scalar;
}